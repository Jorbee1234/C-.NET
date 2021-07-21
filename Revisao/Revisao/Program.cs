using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];//Cria Array
            int cont = 0;
            string opcaoUsuario = ObterOpcaodoUsuario();

            while (opcaoUsuario != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1"://Adicionar aluno
                        Console.WriteLine("Informe nome de aluno:");//Usuário digitar o nome do aluno
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe nota do aluno:");//Usuário digitar a nota do aluno
                        var nota = float.Parse(Console.ReadLine());//Muda o string para float
                        aluno.Nota = nota;

                        alunos[cont] = aluno;
                        cont++;
                        break;

                    case "2"://Listar aluno
                        foreach (var a in alunos)//Uma repetição que irá percorrer a array para listar 
                            if(!string.IsNullOrEmpty(a.Nome))//Nessa condição vai mostrar todos que não são nulos
                            Console.WriteLine($"Aluno:{a.Nome} - Nota:{a.Nota}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaodoUsuario();
            }
        }

        private static string ObterOpcaodoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção que você deseja:");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("x - Para sair");

            string opcaoUsuario = Console.ReadLine();//Usuario digitar informação pedida
            Console.WriteLine();
            return opcaoUsuario;
            }
        }
    }

