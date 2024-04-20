//Escreva um programa que leia o número de um funcionário,
//seu número de horas trabalhadas,
//o valor que recebe por hora
//e calcula o salário desse funcionário.
//A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

using System.Globalization;

var numeroFuncionario = Convert.ToInt32(Console.ReadLine());
var horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
var salarioHora = Convert.ToDouble(Console.ReadLine());

var salario = horasTrabalhadas * salarioHora;



Console.WriteLine($"NUMBER = {numeroFuncionario}");
Console.WriteLine($"SALARY = U$ {salario.ToString("F2", new CultureInfo("en-US"))}");
