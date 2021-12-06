using System;
using DIO.Cadastro.Interfaces;

namespace DIO.Cadastro{
    public class Menu
    {
        static PessoaRepositorio pessoaRepo = new PessoaRepositorio();
        public static void VisualizarPessoa()
        {
            Console.Write("Digite o id da pessoa: ");
            int indicePessoa = int.Parse(Console.ReadLine());

            var pessoa = pessoaRepo.RetornaPorId(indicePessoa);

            Console.WriteLine(pessoa);
        }

        public static void ExcluirPessoa()
        {
            Console.Write("Digite o id do usuario: ");
            int indiceCad = int.Parse(Console.ReadLine());

            pessoaRepo.Exclui(indiceCad);
        }

        public static void AtualizarPessoa()
        {
            Console.Write("Digite o id do usuario: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Sexo))){
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Sexo), i));
            }

            Console.Write("Digite o sexo dentre as opções acima: ");
            int entradaSexo = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome: ");
            string entradaNome = Console.ReadLine();
            Console.Write("Digite o ano do seu nascimento: ");
            int entradaAnoNasc = int.Parse(Console.ReadLine());
            Console.Write("Digite o endereço: ");
            string entradaEnd = Console.ReadLine();

            Pessoa atualizaCad = new Pessoa(Id: indiceSerie,
                                            Sexo: (Sexo)entradaSexo,
                                            Nome: entradaNome,
                                            AnoNasc: entradaAnoNasc,
                                            Endereco: entradaEnd,
                                            Cadastro: DateTime.Today.Date);

            pessoaRepo.Atualiza(indiceSerie, atualizaCad);
        }

        public static void InserirPessoa()
        {
            Console.WriteLine("Cadastrar novo usuario: ");

            foreach (int i in Enum.GetValues(typeof(Sexo)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Sexo), i));
            }

            Console.Write("Digite o sexo dentre as opções acima: ");
            int entradaSexo = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome: ");
            string entradaNome = Console.ReadLine();
            Console.Write("Digite o ano do seu nascimento: ");
            int entradaAnoNasc = int.Parse(Console.ReadLine());
            Console.Write("Digite o endereço: ");
            string entradaDesc = Console.ReadLine();

            Pessoa novaPessoa = new Pessoa(Id: pessoaRepo.ProximoId(), Sexo: (Sexo)entradaSexo
            ,Nome: entradaNome,
            AnoNasc: entradaAnoNasc, Endereco: entradaDesc, Cadastro: DateTime.Today.Date);
            
            pessoaRepo.Insere(novaPessoa);
        }

        public static void ListarPessoas()
        {
            Console.WriteLine("Listar séries: ");

            var lista = pessoaRepo.Lista();

            if (lista.Count == 0){
                Console.WriteLine("Nenhuma série cadastrada. ");
                return;
            }

            foreach (var pessoa in lista){
                var excluido = pessoa.retornaExcluido();
                if (!excluido) {
                    Console.WriteLine("#ID {0}: - {1}", pessoa.retornaId(), pessoa.retornaNome());
                }
            }
        }
    }
}