using System;
namespace CALCULOIMC
{
    public class CalculoIMC
    {
        public static void Main()
        {
            double imcTotal, alturaIMC, pesoIMC;
            string nome;
            Console.WriteLine("Cálculo IMC do Guilherme e do Kaick \r\nUsar vírgula nos valores.");
            Console.WriteLine("Desnutrição = IMC Abaixo de 16");
            Console.WriteLine("Abaixo do peso = IMC Entre 16 e 18.5");
            Console.WriteLine("Peso ideal = IMC Entre 18.5 e 24.9");
            Console.WriteLine("Acima do peso = IMC Entre 25.0 e 29.9");
            Console.WriteLine("Obesidade de grau I = IMC Entre 30.0 e 34.9");
            Console.WriteLine("Obesidade de grau II (SEVERA) = IMC Entre 35.0 e 39.9");
            Console.WriteLine("Obesidade de grau III (MÓRBIDA) = IMC Acima de 40.0");

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Insira o valor do peso: ");
            pesoIMC = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura: ");
            alturaIMC = double.Parse(Console.ReadLine());

            imcTotal = pesoIMC / (alturaIMC * alturaIMC);
            if (imcTotal > 16.0 && imcTotal <= 18.5)
            {
                Console.WriteLine($"Usuário(a) {nome} com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra abaixo do peso. \r\nIMC: {imcTotal:F2}");
            }
            else if (imcTotal > 18.5 && imcTotal <= 24.9)
            {
                Console.WriteLine($"Usuário(a) {nome} com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra no peso ideal. \r\nIMC: {imcTotal:F2}");
            }
            else if (imcTotal >= 25.0 && imcTotal <= 29.9)
            {
                Console.WriteLine($"Usuário(a) {nome} com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra levemente acima do peso. \r\nIMC: {imcTotal:F2}");
            }
            else if (imcTotal >= 30.0 && imcTotal <= 34.9)
            {
                Console.WriteLine($"Usuário(a) {nome} com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra com obesidade de grau I. \r\nIMC: {imcTotal:F2}");
            }
            else if (imcTotal >= 35.0 && imcTotal <= 39.9)
            {
                Console.WriteLine($"Usuário(a) {nome} com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra com obesidade de grau II: SEVERA. \r\nIMC: {imcTotal:F2}");
            }
            else if (imcTotal >= 40)
            {
                Console.WriteLine($"Usuário(a) {nome} com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra com obesidade de grau III: MÓRBIDA. \r\nIMC: {imcTotal:F2}");
            }
            else
            {
                Console.WriteLine($"Usuário(a) {nome} com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra com desnutrição grave a depender da idade. \r\nIMC: {imcTotal:F2}");
            }
        }
    }
}
