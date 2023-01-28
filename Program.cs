using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Attempt");

Iphone iphone1 = new Iphone("(00) 9 0000-0000", "Iphone 10", "000000-00-000000-1", 128);
Nokia nokia1   = new Nokia("(00) 9 0000-0000", "Nokia Special", "000000-00-000000-2", 64);

nokia1.InstalarAplicativo("Rha&Ra");
nokia1.ReceberLigacao();
