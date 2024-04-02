using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine($"Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "99999-9999", modelo: "6110", imei: "1111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Snake Game");
nokia.ReceberLigacao();

Console.WriteLine();

Console.WriteLine($"Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "98888-9999", modelo: "15", imei: "2222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Apple Music");
iphone.Ligar();
