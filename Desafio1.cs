using System;

class Program
{
    static int CalcularDano(int ataque, int defesa) 
    {
      int dano = ataque - defesa;
        if (dano < 0) {
            dano = 0;
        }
        return dano;
    }

    public static void Main (string[] args) {

        int ataque = Convert.ToInt32(Console.ReadLine());
        int defesa = Convert.ToInt32(Console.ReadLine());
        int dano = CalcularDano(ataque, defesa);
        Console.WriteLine($"O dano causado pelo ataque foi: {dano}");
    }

}
