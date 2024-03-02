string? n;
int num = 0;

Console.Write("Número de alunos: ");
n = Console.ReadLine();
Int32.TryParse(n, out num);

double[] vetg1 = new double[num];
double[] vetg2 = new double[num];
double[] vetmed = new double[num];

for (int i = 0; i < vetg1.Length; i++)
{
    Console.Write("Valor da nota G1 do " + i + "º aluno: ");
    n = Console.ReadLine();
    Double.TryParse(n, out vetg1[i]);

    Console.Write("Valor da nota G2 do " + i + "º aluno: ");
    n = Console.ReadLine();
    Double.TryParse(n, out vetg2[i]);

    vetmed[i] = (vetg1[i] + vetg2[i]) / 2;
}

for (int i = 0; i < vetg1.Length; i++)
{
    Console.WriteLine("");
    Console.Write("Valor da nota G1 do " + i + "º aluno: " + vetg1[i]);
    Console.WriteLine("");
    Console.Write("Valor da nota G2 do " + i + "º aluno: " + vetg2[i]);
    Console.WriteLine("");
    Console.Write("Valor da média entre G1 e G2 do " + i + "º aluno: " + vetmed[i]);
    Console.WriteLine("");
    Console.WriteLine("");
}