
Console.Clear();
Console.WriteLine("\n\n\n");


Album albumDo7Minutoz = new Album();

albumDo7Minutoz.Nome = "Agente Zero";

Banda uniaoZ = new Banda("777");

uniaoZ.AdicionarAlbum(albumDo7Minutoz);
uniaoZ.ExibirDiscografia();

Musica kratos = new Musica(uniaoZ);
kratos.Nome = "Kratos";
kratos.Duracao = 195;
kratos.Disponivel = true;

Musica nemesis = new Musica(uniaoZ);
nemesis.Nome = "Nemesis";
nemesis.Duracao = 200;
nemesis.Disponivel = true;

albumDo7Minutoz.AdicionarMusica(kratos);
albumDo7Minutoz.AdicionarMusica(nemesis);


albumDo7Minutoz.ExibirMusica();

