using DesafioPOO.Models;

Console.WriteLine("Iphone: ");
Iphone iphone = new Iphone(numero:"1", modelo:"a", imei: "1", memoria: 9);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");

Console.WriteLine("\n");
Console.WriteLine("Nokia: ");
Nokia nokia = new Nokia(numero:"2", modelo:"b", imei: "2", memoria: 15);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Binance");

