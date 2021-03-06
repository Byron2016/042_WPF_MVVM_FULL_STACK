// See https://aka.ms/new-console-template for more information
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;

IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());

//userService.Create(new User { 
//    Username = "Test" ,
//    Email = "test@yahoo.com",
//    Password = "TestPassword",
//    DatedJoined = DateTime.UtcNow.Date
//}).Wait();


//Console.WriteLine(userService.GetAll().Result.Count());

//Console.WriteLine(userService.Get(2).Result);

//Console.WriteLine(userService.Update(2 , new User
//{
//    Username = "TestNuevo",
//    Email = "test@yahoo.com",
//    Password = "TestPassword",
//    DatedJoined = DateTime.UtcNow.Date
//}).Result);

Console.WriteLine(userService.Delete(2).Result);

Console.ReadLine();
