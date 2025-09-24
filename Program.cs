// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu nome.");

string user;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
user = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

Console.WriteLine("Olá " + user + " , seja bem vindo.");
