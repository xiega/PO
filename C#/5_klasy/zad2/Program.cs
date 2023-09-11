//global using zad2.classes;

Person kowalski = new Person();
//WriteLine("test");
kowalski.firstName = "Janusz";
kowalski.height = 180;
Console.WriteLine("Imię: "+kowalski.getName()); //Imię: Janusz

Person nowak = kowalski;
Console.WriteLine(nowak.firstName + " Nowak"); //Janusz Nowak

nowak.firstName = "Tomasz";
Console.WriteLine(nowak.firstName + " Nowak"); //Tomasz Nowak
Console.WriteLine(kowalski.firstName + " Kowalski"); //Tomasz Kowalski

nowak = null;
//Console.WriteLine(nowak.firstName + " Nowak"); NIC NIE WYPISZE
Console.WriteLine(kowalski.firstName + " Kowalski"); //Tomasz Kowalski

//nowak.firstName = "Andrzej"; Po przypisaniu null, nowak nie jest już obiektem

nowak = kowalski;
nowak.firstName = "Andrzej";
Console.WriteLine(nowak.firstName + " Nowak"); //Andrzej Nowak