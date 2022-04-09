Console.Clear();

double numeroEscrito;

Console.Write("Escreva um número qualquer: ");
numeroEscrito = Convert.ToDouble(Console.ReadLine());

if (numeroEscrito % 2 == 1)
{
    Console.WriteLine($"O número {numeroEscrito} é ímpar...");
}

else
{
    Console.WriteLine($"O número {numeroEscrito} é par!");
}