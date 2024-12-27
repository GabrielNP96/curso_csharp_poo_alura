using System.Net.WebSockets;
using System.Runtime.InteropServices;

class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }

   
    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
    if(Disponivel) {
        Console.WriteLine("disponível no plano");
    } else
    {
        Console.WriteLine("Adiquira o plano premium");
    }
    }
}
