double qtdeReais, qtdeDolar;

 Console.WriteLine("Escreva a quantidade de reais");
 qtdeReais = double.Parse(Console.ReadLine());
 qtdeDolar = qtdeReais / 5.45;
 qtdeDolar = Math.Round(qtdeDolar, 2, MidpointRounding.AwayFromZero);
Console.WriteLine($"Você tem {qtdeDolar} dolares");
Console.ReadKey();
