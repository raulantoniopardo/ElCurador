// See https://aka.ms/new-console-template for more information
using ElCurador;

//create a method that returns a number

Operator o = new Operator();
Random random = new Random();

while (true)
{
    MainExecution(o, random);
}

static void MainExecution(Operator o, Random random)
{
    int randomNumber = random.Next(1, 5);
    var code = o.Execute(randomNumber);

    var result = 5 / code;

    Console.WriteLine("--------------------");
    Console.WriteLine("result3: " + result);
    Console.WriteLine("\r\n");
}

//create a method that returns a number