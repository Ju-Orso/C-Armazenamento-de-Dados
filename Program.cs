using AttClasses.Classes;

Person[] people = new Person[]
{
    new userWorker{
        NomePessoa = "Matheus"
        , CargoDaPessoa = "Gerente"
        , Aniversário = new DateTime(1979, 2, 04)
        , Generos = "Masculino"
        , Setores = "Geral"
        , Admissao = new DateTime(2008, 2, 1)
        , Salario = 8000.50m
    },

    new userSupervisor{
        NomePessoa = "Felipe"
        , CargoDaPessoa = "Supervisor"
        , Aniversário = new DateTime(1997, 6, 02)
        , Generos = "Masculino"
        , Setores = "T.I"
        , Admissao = new DateTime(2010, 7, 21)
        , Horario = "Noturno"
    },

    new userSupervisor{
        NomePessoa = "Arthur"
        , CargoDaPessoa = "Supervisor"
        , Aniversário = new DateTime(1985, 3, 14)
        , Generos = "Masculino"
        , Setores = "T.I"
        , Admissao = new DateTime(2011, 5, 8)
        , Horario = "Diurno"
    },

    new userWorker{
        NomePessoa = "Camila"
        , CargoDaPessoa = "Funcionário"
        , Aniversário = new DateTime(2002, 8, 19)
        , Generos = "Feminino"
        , Setores = "T.I"
        , Admissao = new DateTime(2019, 3, 5)
        , Funcao = "Manutenção"
    },
    new userWorker{
        NomePessoa = "Paulo"
        , CargoDaPessoa = "Funcionário"
        , Aniversário = new DateTime(2001, 12, 01)
        , Generos = "Masculino"
        , Setores = "T.I"
        , Admissao = new DateTime(2017, 2, 5)
        , Funcao = "Sistemas"
    },
    new userWorker{
        NomePessoa = "Rafaela"
        , CargoDaPessoa = "Funcionário"
        , Aniversário = new DateTime(1998, 11, 30)
        , Generos = "Feminino"
        , Setores = "Recepção"
        , Admissao = new DateTime(2017, 3, 18)
        , Funcao = "Recepcionista"
    }
};

for(int i = 0; i < people.Length; i++)
{
   Console.WriteLine($"Pessoa {i + 1}:");
   Console.WriteLine($"NomePessoa: {people[i].NomePessoa}" + $" / CargoDaPessoa: {people[i].CargoDaPessoa}");

   Console.WriteLine($"Data de nascimento: {people[i].Aniversário.ToShortDateString()}");
   Console.WriteLine($"Data de contratação: {people[i].Admissao.ToShortDateString()}");
   Console.WriteLine($"Gênero: {people[i].Generos}");
   Console.WriteLine($"Setores: {people[i].Setores}");


   if(people[i] is userWorker)
   {
    userWorker manager = (userWorker)people[i];
    Console.WriteLine($"Salário: {manager.Salario}");
   }
   else if (people[i] is userSupervisor)
   {
    userSupervisor supervisor = (userSupervisor)people[i];
    Console.WriteLine($"Período de trabalho: {supervisor.Horario}");
   }
   else if (people[i] is userWorker)
   {
    userWorker operario = (userWorker)people[i];
    Console.WriteLine($"Função: {operario.Funcao}");
   }

   Console.WriteLine();
}
