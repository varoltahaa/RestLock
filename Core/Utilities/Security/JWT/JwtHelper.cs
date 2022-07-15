using Core.Extensions;
using Core.Utilities.Security.Encryption;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; } //apideki appsettings.json dosyasını okumaya yarar
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration; 
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>(); //apideki appsettings.json dosyasında eklediğimiz TokenOptions bilgileri ile Core.Utilities.Security.JWT altında bulunan TokenOptions clasımızı birleştirir.

        }
        public AccessToken CreateToken(User user, List<UserType> userType)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration); //Bu tokenın ne zaman biteceği
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey); // appsettings.json dosyasından securitykey i almamıza yarar
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey); // hangi key'i hangi algoritmayı kullanıcak
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, userType);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<UserType> userType)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, userType),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, List<UserType> userType)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.UserId.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(userType.Select(c => c.UserTypeName).ToArray());

            return claims;
        }
    }
}
