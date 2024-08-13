int n1, n2, n3, n4, media, notaExame, mediaExame;
Console.WriteLine("Digite a primeira nota:");
n1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
n2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
n3 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite a quarta nota:");
n4 = Convert.ToInt16(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine($"Sua nota média é: {media}");

if (media >= 7)
{
    Console.WriteLine("Aprovado!");
    Console.ReadKey();
}

else
{
    Console.WriteLine("Reprovado! Digite a nota do exame:");
    notaExame = Convert.ToInt16(Console.ReadLine());
    mediaExame = (media + notaExame) / 2;

    if (mediaExame >= 5)
    {
        Console.WriteLine("Aprovado!");
    }

    else
    {
        Console.WriteLine("Reprovado!");
    }
}