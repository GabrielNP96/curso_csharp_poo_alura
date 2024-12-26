using System.Net.WebSockets;
using System.Runtime.InteropServices;

class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
    if(disponivel) {
        Console.WriteLine("disponível no plano");
    } else
    {
        Console.WriteLine("Adiquira o plano premium");
    }
    }
}

