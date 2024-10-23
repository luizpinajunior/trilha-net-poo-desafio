using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone  nokia = new Nokia(numero: "352550", modelo: "Modelo 1", IMei: "89864474935", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone (numero: "4050100", modelo: "Modelo 2", IMei: "89674843135", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Google Earth Pro");
