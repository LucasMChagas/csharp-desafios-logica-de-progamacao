﻿//Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
//Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

var notaA = double.Parse(Console.ReadLine());
var notaB = double.Parse(Console.ReadLine());

var media = ((notaA * 3.5) + (notaB * 7.5)) / (3.5 + 7.5);

Console.WriteLine($"MEDIA = {media.ToString("F5")}");
