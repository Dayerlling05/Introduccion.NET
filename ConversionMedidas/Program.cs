// See https://aka.ms/new-console-template for more information
Console.WriteLine("  ** Converion de longitudes **");

int metros;

Console.WriteLine(" Ingrese los metros a convertir :  ");
metros = int.Parse(Console.ReadLine());

double centimetros = metros * 100; 
double pulgadas = centimetros / 2.54;
double pies = pulgadas / 12;
double yardas = pies / 3;

Console.WriteLine("----------------------------------------");
Console.WriteLine("Metros = " + metros.ToString());
Console.WriteLine("Centimetros = " + centimetros.ToString());
Console.WriteLine("Yardas = " + yardas.ToString("0.00"));
Console.WriteLine("Pulgadas = " + pulgadas.ToString("0.00"));
Console.WriteLine("Pies = "+ pies.ToString("0.00"));
