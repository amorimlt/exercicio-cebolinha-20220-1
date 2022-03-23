string frase;

Console.Write("Digite uma frase: ");
frase = Console.ReadLine()!;

frase = frase  
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine($"{frase}");