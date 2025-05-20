//Atividade "PesoIdeal" Italo

double Altura, PesoIdeal;
string Sexo;

Console.Clear();

Console.WriteLine("----Saiba seu peso ideal----");

Console.Write("Me diga sua altura em metros para sabermos seu peso ideal:...  ");

Altura = Convert.ToDouble(Console.ReadLine ());

Console.Write("Qual seu sexo? se você for Homem digite (H), se for mulher digite (M):... ");
Sexo = (Console.ReadLine())!.ToUpper();

if (Sexo == "H")
{
    Console.WriteLine("como você é homem seu peso ideal é de...");

    PesoIdeal = Convert.ToDouble(1);

    PesoIdeal = (Altura * 72.7) - 58.0;

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\nE seu peso ideal é {PesoIdeal:N1}kg");
}
else if (Sexo == "M")
{
    Console.WriteLine("já que você é mulher, seu peso ideal é de...");

    PesoIdeal = Convert.ToDouble(0);

    PesoIdeal = (Altura * 62.1) - 44.7;

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\nE seu peso ideal é {PesoIdeal:N1}kg");
}
Console.ResetColor();
Console.WriteLine("E ai, está em forma?");