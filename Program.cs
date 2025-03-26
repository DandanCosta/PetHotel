byte idade = 0;

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                 Pet Hotel Check In                      |");
Console.WriteLine("+=========================================================+");
Console.Write($"Especie: ");
string especie = Console.ReadLine()!;

Console.Write("Raça: ");
string raça = Console.ReadLine()!;

Console.Write("Alcunha: ");
string alcunha = Console.ReadLine()!;

Console.Write("Idade: ");
idade = byte.Parse(Console.ReadLine()!);

Console.Write("Cor: ");
string Cor = Console.ReadLine()!;

Console.ForegroundColor= ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.ForegroundColor= ConsoleColor.DarkYellow;
Console.WriteLine("|                      Pet Hotel \" BS\"                    |");
Console.ForegroundColor=ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor= ConsoleColor.DarkBlue;
Console.Write($"| Especie: {especie.PadLeft(15,'.').ToUpper()}");
Console.Write(" |");
Console.ForegroundColor= ConsoleColor.DarkBlue;
Console.Write($" Raça: {raça.PadLeft(22,'.').ToUpper()}");
Console.Write(" |");
Console.ForegroundColor=ConsoleColor.DarkGray;
Console.Write("\n+=========================================================+");
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.Write($"\n| Atende pela alcunha de: {alcunha.PadLeft(31,'.').ToUpper()}");
Console.Write(" |");
Console.Write($"\n| Idade: {idade.ToString("00")} ano(s)");
Console.Write(" |");
Console.Write($" Pelagem/Cor: {Cor.PadLeft(23,'.').ToUpper()}");
Console.Write(" |");
Console.ForegroundColor= ConsoleColor.DarkGray;
Console.Write("\n+=========================================================+");

Console.ResetColor();
