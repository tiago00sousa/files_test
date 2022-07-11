using System;

namespace Entrevista{


        class Funcionario{
        
            public string nome;
            public int rg;
            public string funcao;
            public bool status;
            

            static void Main(){

                Cadastra_funcionario();


            }

            public void Cadastra_funcionario( string nome, int rg,string funcao, bool status){

                this.nome = nome;
                this.rg = rg;
                this.funcao = funcao;
                this.status = status;

                Console.WriteLine("{0}"nome);
                Console.WriteLine("{0}"rg);
                Console.WriteLine("{0}"funcao);
                Console.WriteLine("{0}"status);




            }

        }


}