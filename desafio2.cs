using System;

class Program
{
    public static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtual) {
        return valorAtual >= valorMinimo && valorAtual <= valorMaximo;
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();
        int valorMinimo = Convert.ToInt32(Console.ReadLine());
        int valorMaximo = Convert.ToInt32(Console.ReadLine());
        int valorAtual = Convert.ToInt32(Console.ReadLine());
        
        bool dentroDoIntervalo = VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtual);
        if (dentroDoIntervalo) {
            Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
        } else {
            Console.WriteLine("O valor do atributo está fora do intervalo especificado");
        }

    }
}
