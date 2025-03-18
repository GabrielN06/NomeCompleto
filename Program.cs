string nome;
string sobrenome;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine("");

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome completo: {sobrenome.ToUpper()}{","} {nome}");