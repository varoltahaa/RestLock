// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.WriteLine("Hello, World!");

PlaceManager placeManager = new PlaceManager(new EfPlaceDal());

foreach (var place in placeManager.GetAllByCategoryId(2))
{
    Console.WriteLine(place.Description);
    Console.WriteLine(place.PlacePhoneNumber);
    Console.WriteLine(place.PlaceAddress);
    Console.WriteLine(place.PlaceName);
    Console.WriteLine(place.CloseTime);
}
