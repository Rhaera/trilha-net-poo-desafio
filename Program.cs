using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone10 = new Iphone("(00) 9 0000-0000", "Iphone 10", "000000-00-000000-1", 128);
Nokia nokiaSpecial   = new Nokia("(00) 9 0000-0000", "Nokia Special", "000000-00-000000-2", 64);

iphone10.InstalarAplicativo("TestAppIOS");
iphone10.ReceberLigacao();
iphone10.Ligar();

nokiaSpecial.InstalarAplicativo("TestAppNokia");
nokiaSpecial.ReceberLigacao();
nokiaSpecial.Ligar();
