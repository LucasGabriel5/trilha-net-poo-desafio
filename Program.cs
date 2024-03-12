using DesafioPOO.Models;


Console.WriteLine("smartphone Nokia:");
Smartphone nokia = new Nokia("12121212", "modelo-1", "asasasas1", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nsmartphone Iphone:");
Smartphone iphone = new Iphone("13131313", "modelo-2", "asasasas2", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");