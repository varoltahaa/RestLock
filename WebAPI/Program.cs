using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(options =>
{
    options.RegisterModule(new AutofacBusinessModule());
});
//builder.Services.AddSingleton<IPlaceService, PlaceManager>();
//builder.Services.AddSingleton<IPlaceDal, EfPlaceDal>();

//builder.Services.AddSingleton<IUserTypeService, UserTypeManager>();
//builder.Services.AddSingleton<IUserTypeDal, EfUserTypeDal>();

//builder.Services.AddSingleton<IUserService, UserManager>();
//builder.Services.AddSingleton<IUserDal, EfUserDal>();

//builder.Services.AddSingleton<IProductService, ProductManager>();
//builder.Services.AddSingleton<IProductDal, EfProductDal>();

//builder.Services.AddSingleton<IPlaceCategoryService, PlaceCategoryManager>();
//builder.Services.AddSingleton<IPlaceCategoryDal, EfPlaceCategoryDal>();

//builder.Services.AddSingleton<IMenuService, MenuManager>();
//builder.Services.AddSingleton<IMenuDal, EfMenuDal>();

//builder.Services.AddSingleton<IMenuCategoryService, MenuCategoryManager>();
//builder.Services.AddSingleton<IMenuCategoryDal, EfMenuCategoryDal>();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); 
    app.UseSwaggerUI();
    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

