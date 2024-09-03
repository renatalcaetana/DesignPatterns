// See https://aka.ms/new-console-template for more information
using CriptografiaSha512;

Console.WriteLine("Hello, World!");


var Criptografia = new Sha512();
var key =  Criptografia.Criptografar("renatalcaetana@gmail.com");
Console.WriteLine($"Valor Criptografado {key}");
