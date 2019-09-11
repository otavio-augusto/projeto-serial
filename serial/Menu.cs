using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serial
{
    static class Menu
    {
        
        public static void mostrarMenu(Operacoes operacoes)
        {
            char op;
            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Alunos");
                Console.WriteLine("==================\n");
                Console.WriteLine(
                    "1 - Inserir\n" +
                    "2 - Alterar\n" +
                    "3 - Excluir\n" +
                    "4 - Pesquisar\n" +
                    "5 - Listar\n" +
                    "6 - Ordenar\n" +
                    "7 - Salvar Dados\n" +
                    "8 - Ler Dados\n" +
                    "9 - Sair\n");
                Console.Write("Opção: "); op = Console.ReadLine()[0];
                switch (op)
                {
                    case '1':
                        operacoes.inserir();
                        break;
                    case '2':
                        //TODO Alterar
                        break;
                    case '3':
                        //TODO Exculir
                        break;
                    case '4':
                        //TODO Pesquisar
                        break;
                    case '5':
                        //TODO Listar
                        break;
                    case '6':
                        //TODO Ordenar
                        break;
                    case '7':
                        //TODO Salvar Dados
                        break;
                    case '8':
                        //TODO Ler Dados
                        break;
                    case '9':
                        Console.WriteLine("Saindo....");
                        break;
                    default:
                        Console.WriteLine("Tente Novamente!");
                        break;
                }
            } while (op != '9');
        }
    }
}
