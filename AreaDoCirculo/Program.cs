//A fórmula para calcular a área de uma circunferência é: area = π.raio2.Considerando para este problema que π = 3.14159:

//-Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.
using System.Globalization;

const double n = 3.14159d;

var raio = double.Parse(Console.ReadLine());

var area = (raio * raio) * n;

Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");