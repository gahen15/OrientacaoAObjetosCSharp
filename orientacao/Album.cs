public class Album
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; set; }
    // A duração total é  soma da duração de todas a música.
    public int DuracaoTotal => musicas.Sum(m=>m.Duracao);












    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusica()
    {
        Console.WriteLine($"Músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");

        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal} segundos");
    }


}