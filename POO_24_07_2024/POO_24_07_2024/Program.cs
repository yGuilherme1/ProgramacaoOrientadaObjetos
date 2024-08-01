List<Aluno> listaAlunos = new List<Aluno>();

Aluno a1 = new ("Valentino Garavani", 01, "111111111-11", "valentino@mail.com", new DateOnly(1998, 10, 01));
Aluno a2 = new ("Yves Saint-Laurent", 02, "222222222-22", "saint.laurent@mail.com", new DateOnly(1997, 11, 2));
Aluno a3 = new ("Giorgio Armani", 03, "333333333-33", "armani@mail.com", new DateOnly(1996, 09, 3));
Aluno a4 = new ("Manolo Blanc", 04, "444444444-44", "manolo.blanc@mail.com", new DateOnly(1995, 01, 04));
Aluno a5 = new ("Coco Chanel", 05, "555555555-55", "coco.chanel@mail.com", new DateOnly(1994, 08, 05));


listaAlunos.Add(a1);
listaAlunos.Add(a2);
listaAlunos.Add(a3);
listaAlunos.Add(a4);
listaAlunos.Add(a5);

Console.WriteLine($"\n\n\n\n    Lista de Alunos:\n");
foreach (Aluno a in listaAlunos)
{
    Console.WriteLine(a.ToString());
}

// Retorna uma lista com todos que atendem a um critério de consulta;
List<Aluno> lista2 = listaAlunos.Where(x => x.Matricula > 2).ToList();
// foreach(Aluno a in lista2) { Console.WriteLine(busca.ToString());}

// para buscar objeto específico
Aluno search = listaAlunos.FirstOrDefault(x => x.Matricula == 2);
int minimo = listaAlunos.Min(x => x.Matricula);
// ou
Aluno busca = listaAlunos.Find(a => a.Matricula == 2);
// if (busca is not null) { Console.WriteLine(busca.ToString());}

// Retorna lista ordenada pelo nome;
List<Aluno> listaOrdenada = listaAlunos.OrderBy(x => x.Nome).ToList();

// Retorna lista com alunos que não repetem o elemento escolhido como critério.
List<Aluno> listaElementosDistintos = listaAlunos.DistinctBy(x => x.Nome).ToList();

// Retorna lista sem redundância de objetos (quando os objetos são diferentes por inteiro)
List<Aluno> listaDistinta = listaAlunos.Distinct().ToList();

// Retorna lista que conhtenha certos caracteres.
List<Aluno> listaContem = listaAlunos.Where(x => x.Nome.ToLower().Contains("eli")).ToList();

// Remove elemento da lista que foi encontrado.
listaAlunos.Remove(busca);