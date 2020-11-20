using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new MilhaMar();

            Console.Write("Informe o valor da distância em milhas marítmas: ");
            a1.SetValor(double.Parse(Console.ReadLine()));

            if(a1.GetValor() == 1)
            {
                Console.WriteLine($"{a1.GetValor()} milha marítma = {a1.ConverterMilhaMarParaMetros()} metros");
            }
            else if(a1.GetConvertido() == 1)
            {
                Console.WriteLine($"{a1.GetValor()} milhas marítmas = {a1.ConverterMilhaMarParaMetros()} metro");
            }
            else
            {
                Console.WriteLine($"{a1.GetValor()} milhas marítmas = {a1.ConverterMilhaMarParaMetros()} metros");
            }
        }
    }
}
