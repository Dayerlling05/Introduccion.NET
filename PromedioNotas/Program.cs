// See https://aka.ms/new-console-template for more information
Console.WriteLine("  ** Promedio de Notas **");
string alumno;
int nota1, nota2 ,nota3;

Console.WriteLine("Ingre el nombre del alumno: ");
alumno = Console.ReadLine();
Console.WriteLine("Ingrese la nota 1: ");
nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 2: ");
nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 3: ");
nota3 = int.Parse(Console.ReadLine());

double promedio = (nota1 + nota2 + nota3) / 3.0;
Console.WriteLine("-------------------------------");
Console.WriteLine("El promedio de " + alumno + " es : " + promedio.ToString("0.00"));