// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.WriteLine("Hello, World!");

PlaceManager placeManager = new PlaceManager(new EfPlaceDal());

var result = placeManager.GetPlaceDetails();

if (result.Success)
{
foreach (var place in result.Data)
{
    Console.WriteLine(place.PlaceName+" "+place.ProductName+" "+place.UnitPrice+" "+place.MenuCategoryName);

  }
}

else
{
    Console.WriteLine(result.Message);
}


