using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PlaceManager>().As<IPlaceService>().SingleInstance();
            builder.RegisterType<EfPlaceDal>().As<IPlaceDal>().SingleInstance();

            builder.RegisterType<UserTypeManager>().As<IUserTypeService>().SingleInstance();
            builder.RegisterType<EfUserTypeDal>().As<IUserTypeDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<PlaceCategoryManager>().As<IPlaceCategoryService>().SingleInstance();
            builder.RegisterType<EfPlaceCategoryDal>().As<IPlaceCategoryDal>().SingleInstance();

            builder.RegisterType<MenuManager>().As<IMenuService>().SingleInstance();
            builder.RegisterType<EfMenuDal>().As<IMenuDal>().SingleInstance();

            builder.RegisterType<MenuCategoryManager>().As<IMenuCategoryService>().SingleInstance();
            builder.RegisterType<EfMenuCategoryDal>().As<IMenuCategoryDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }

    }
}
