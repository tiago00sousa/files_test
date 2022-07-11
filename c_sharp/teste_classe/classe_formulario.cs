using System;

using Funcionario;

namespace Entrevista{

    public class formulario{

        static void Main(){

            Funcionario funcionario =  new Funcionario();

            Console.WriteLine("Digite nome");
            string nome = Console.ReadLine()
            
            Console.WriteLine("Digite rg");
            string rg = Console.ReadLine();

            
            Console.WriteLine("Digite funcao");
            string funcao = Console.ReadLine();

            
            Console.WriteLine("Digite status");
            string status = Console.ReadLine();


            funcionario.nome = nome;
            funcionario.rg = rg;
            funcionario.funcao = funcao;
            funcionario.status = status;

            funcionario.Cadastra_funcionario(nome.rg,funcao,status);




        }

        



    }

}