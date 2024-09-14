using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("123","1","11111111","1");
iphone.Ligar();
Nokia nokia = new Nokia("123","1","11111111","1");
nokia.ReceberLigacao();

iphone.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Instagram");