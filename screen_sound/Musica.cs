using System.Net.WebSockets;
using System.Runtime.InteropServices;

class Musica
{
    public Musica()
    {
        Artista = Artista;
    }

    public string Nome { get; set;}
    public Banda Artista { get; }
    public int Duracao { get; set;}
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertece {Artista}";

   
    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Descrição: {DescricaoResumida}");
    if(Disponivel) {
        Console.WriteLine("disponível no plano");
    } else
    {
        Console.WriteLine("Adiquira o plano premium");
    }
    }
}
