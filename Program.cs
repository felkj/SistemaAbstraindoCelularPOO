using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone14 = new Iphone("1199919999", "Iphone 14", "355086751969684", 16);

Nokia nokia1 = new Nokia("1191919199", "Nokia 5", "3550867514222345", 6);

iphone14.Ligar("1191919199");

nokia1.ReceberLigacao("1199919999");

iphone14.InstalarAplicativo("WhatsApp");

nokia1.InstalarAplicativo("Telegram");