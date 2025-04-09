using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe seu peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe sua altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe seu gênero (M/F): ");
        string genero = Console.ReadLine();

        double imc = peso / (altura * altura);
        Console.WriteLine($"\nSeu IMC é: {imc:F1}");

        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Classificação: Peso ideal (parabéns)");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Classificação: Levemente acima do peso");
        }
        else if (imc < 35)
        {
            Console.WriteLine("Classificação: Obesidade grau I");
        }
        else if (imc < 40)
        {
            Console.WriteLine("Classificação: Obesidade grau II (severa)");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade grau III (mórbida)");
        }
    }
}
