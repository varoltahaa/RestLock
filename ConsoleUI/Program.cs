// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.WriteLine("Hello, World!");

PlaceManager placeManager = new PlaceManager(new EfPlaceDal());

foreach (var place in placeManager.GetPlaceDetails())
{
    Console.WriteLine(place.PlaceName+" "+place.ProductName+" "+place.UnitPrice+" "+place.MenuCategoryName);

}
