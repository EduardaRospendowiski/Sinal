Console.Clear();
 
int numero;
ConsoleColor cor;
 
Console.WriteLine("--- Sinal ---");
 
Console.Write("Digite um numero: ");
numero = Convert.ToInt32(Console.ReadLine());
 
if (numero > 0)
{
    cor = ConsoleColor.Blue;
    Console.ForegroundColor = cor;
    Console.WriteLine("Positivo");
    Console.ResetColor();
}
 
else if (numero == 0)
{
    cor = ConsoleColor.Magenta;
    Console.ForegroundColor = cor;
    Console.WriteLine("Zero");
    Console.ResetColor();
}
 
else
{
    cor = ConsoleColor.DarkRed;
    Console.ForegroundColor = cor;
    Console.WriteLine("Negativo");
    Console.ResetColor();
}
