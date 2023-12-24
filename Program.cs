using System.Formats.Asn1;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new("123", "a1", "123456", 32);

Console.WriteLine("Testes Nokia\n");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");
Console.WriteLine("-----------------\n");
Iphone p1 = new("123", "a1", "123456", 32);

Console.WriteLine("Testes IPhone\n");
p1.Ligar();
p1.ReceberLigacao();
p1.InstalarAplicativo("WhatsApp");


