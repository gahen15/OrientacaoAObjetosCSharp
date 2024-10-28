public class Musica
{
    // isso é um construtor, uma regra que é exigida na criação de um objeto.
    public Musica(Banda artista)
    {
        Artista = artista;
    }

    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    //Sem o set as outras classes não podem editar, porém podem visualizar.

    public string DescricaoResumida
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista} e possui {Duracao} segundos de duração.";
        }
    }
    //public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista} e possui {Duracao} segundos de duração.";
    //Isso faz a mesma coisa porém mais resumido.

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}\nArtista: {Artista}\nDuração: {Duracao}\nDescrição: {DescricaoResumida}");
        if (Disponivel)
        {
            Console.WriteLine("Disponibildade: Disponível\n\n");
        }
        else
        {
            Console.WriteLine("Disponibilidade: Indisponível\n\n");
        }
    }





}


