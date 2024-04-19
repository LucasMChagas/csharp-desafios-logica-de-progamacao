//Leia quatro valores inteiros A, B, C e D.
//A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

var a = Convert.ToInt32(Console.ReadLine());
var b = Convert.ToInt32(Console.ReadLine());
var c = Convert.ToInt32(Console.ReadLine());
var d = Convert.ToInt32(Console.ReadLine());

var diferenca = (a * b - c * d);

Console.WriteLine($"DIFERENCA = {diferenca}");
