using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serial
{
    class Operacoes
    {
        private Dados dados;
        public Operacoes()
        {
            dados = new Dados();
        }
        public void inserir()
        {
            Aluno aluno;
            do
            {
                aluno = new Aluno();
                Console.Clear();
                Console.WriteLine("Cadastro de Alunos");
                Console.WriteLine("==================");
                Console.WriteLine("Codigo...: {0}", aluno.Codigo);
                Console.Write("Nome.....: "); aluno.Nome = Console.ReadLine();
                Console.Write("Telefone.: "); aluno.Telefone = Console.ReadLine();
                Console.Write("Email....: "); aluno.Email = Console.ReadLine();
                dados.inserir(aluno);
                Console.WriteLine("Inserir outro aluno? (ESC para sair)");
            } while (Console.ReadKey().Key!=ConsoleKey.Escape);
        }
    }
}
