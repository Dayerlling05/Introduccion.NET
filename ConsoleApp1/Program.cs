// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** Capital empresa. **");
int aporte1, aporte2, aporte3;
Console.WriteLine("Ingrese el aporte del la`primera persona : ");
aporte1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el aporte de la segunda persona : ");
aporte2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el aporte de la tercera persona : ");
aporte3 = int.Parse(Console.ReadLine());

int capital = aporte3 + aporte2 + aporte1;
double porcentaje1 = (aporte1 * 100) / capital;
double porcentaje2 = (aporte2 * 100) / capital;
double porcentaje3 = (aporte3 * 100) / capital;

Console.WriteLine("Capital = " + capital.ToString());
Console.WriteLine("porcentaje de la primera persona = " + porcentaje1.ToString());
Console.WriteLine("porcentaje de la segunda persona = " + porcentaje2.ToString());
Console.WriteLine("porcentaje de la tercera persona = " + porcentaje3.ToString());