using System;
using System.Threading;
using Singleton;


TesteSingletonSimples();

Thread process1 = new Thread(() =>
{

});
Thread process2 = new Thread(() =>
{

});

process1.Start();
process2.Start();

process1.Join();
process2.Join();





 static void TesteSingletonSimples()
{
    var instancia2 = SingletonSimples.GetInstance("Maria");
    var instancia1 = SingletonSimples.GetInstance("Joao");

    Console.WriteLine(instancia1.Name);
    Console.WriteLine(instancia2.Name);
}

