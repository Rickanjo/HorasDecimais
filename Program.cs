// See https://aka.ms/new-console-template for more information
Console.WriteLine("---- Horas Decimais ----\n");

Console.Write("Digite um valor decimal de horas: ");
double horas = double.Parse(Console.ReadLine()!);

int horasInt = (int)horas;
double minutosRestantes = (horas - horasInt) * 60;
int minutosInt = (int)minutosRestantes;
int segundosRestantes = (int)((minutosRestantes - minutosInt) * 60);

Console.WriteLine($"\n{horasInt} horas, {minutosInt} minutos e {segundosRestantes} segundos.");