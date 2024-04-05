using System;
using System.Linq;

class Program
{
    static string VerificarForcaSenha(string senha)
    {
        int comprimentoMinimo = 8;
        bool temLetraMaiuscula = false;
        bool temLetraMinuscula = false;
        bool temNumero = false;
        bool temCaractereEspecial = false;
        if (senha.Length < comprimentoMinimo) {
            return "Sua senha e muito curta. Recomenda-se no minimo 8 caracteres.";
        }
        temLetraMaiuscula = senha.Any(char.IsUpper);
        temLetraMinuscula = senha.Any(char.IsLower);
        
        string[] sequenciasComuns = { "123456", "abcdef" };
        if (sequenciasComuns.Any(s => senha.Contains(s))) {
            return "Sua senha contém uma sequência comum. Tente uma senha mais complexa.";
        }
        string[] palavrasComuns = { "password", "123456", "qwerty" };
        if (palavrasComuns.Contains(senha)) {
            return "Sua senha é muito comum. Tente uma senha mais complexa.";
        }
        temNumero = senha.Any(char.IsDigit);
        temCaractereEspecial = senha.Any(c => !char.IsLetterOrDigit(c));
        if (temLetraMinuscula && temLetraMaiuscula && temNumero && temCaractereEspecial) {
            return "Sua senha atende aos requisitos de seguranca. Parabens!";
        } else {
            return "Sua senha nao atende aos requisitos de seguranca.";
        }

    }

    static void Main(string[] args)
    {
        string senha = Console.ReadLine().Trim();

        string resultado = VerificarForcaSenha(senha);

        Console.WriteLine(resultado);
    }
}
