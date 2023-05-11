using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlProduto
    {
        Produto prod;

        private int opcao;





        
        public ControlProduto()
        {

            prod = new Produto();
            modificaropcao = -1;


        }//fim do construtor

        //metodo getset

    
        public int modificaropcao
       { 
           get{ return opcao; }
           set { opcao = value; }
                
                
        

        }


        public void menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n +" +
                "1. cadastrar um produto\n" +
                "2. consultar produto \n" +
                "3. atualizar um produto\n" +
                "4. mudar situacao\n");

            modificaropcao = Convert.ToInt32(Console.ReadLine());


        }//fim do metodo menu
         
        //realizar a operacao

        public void operacao() 
            
        {
           
                menu(); //mostrando o menu na tela
            switch(modificaropcao)
            {
                case 0:
                    Console.WriteLine("obrigado");

                    Console.Clear();// limpa tela
                    break;

                case 1:
                    coletarDados();

                    Console.Clear();// limpa tela
                    break;

                case 2:
                    consultar();

                    Console.Clear();// limpa tela
                    break;

                case 3:
                    atualizar();

                    Console.Clear();// limpa tela
                    break; 
                case 4:
                    alterarsituacao();

                    Console.Clear();// limpa tela

                    break;
                default:
                    Console.WriteLine("opcao escolhida nao e valida");

                    Console.Clear();// limpa tela
                    break;
                    



            }
        
        }

        //criar um metodo de solicitaçao de dados

        public void coletarDados()
        {


            //coletar dados
            Console.WriteLine("informe um codigo");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("faça uma breve descriçcao do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("infome o preco do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a quantidade de produtos em estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe a data de validade do lote do produto: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("informe a situacao: true - ativo | false - inativo ");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

            //cadastrar produto
           
            prod.CadastrarProduto(codigo, nome, descricao, preco,quantidade, data, situacao);
            Console.WriteLine("dado registrado!");
        
        }// fim coletar dados

        //consultar
        public void consultar()
        {
            Console.WriteLine("\n\n\n ninforme o codigo do produto que esteja consultando");

           int codigo = Convert.ToInt32(Console.ReadLine());
            //escrever o resultado na tela
            Console.WriteLine("os dados do produto escolhido sao \n\n\n " + prod.ConsultarProduto(codigo));


        }//fim do metodo

        //atualizar

        public void atualizar()
        {

            // atualizar produto
            Console.WriteLine("\n\ninforme o codigo do produto que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
         
            
          do 
          {



                Console.WriteLine("informe o campo que deseja atualizar de acordo com a regra abaixo: \n + " +
                                 "1. nome\n" +
                                 "2. descricao\n" +
                                 "3. preco\n" +
                                 "4. data de validade\n" +
                                 "5 situacao\n" +
                                 "6. quantidade\n");
                  campo = Convert.ToInt16(Console.ReadLine());
                //avisando o usuario
                if while ((campo < 1) || (campo > 6)) 
                {
                    Console.WriteLine("erro, escoha um codigo entre 1 e 6");
                }
          } while ((campo < 1) || (campo > 6));



            Console.WriteLine("informe o dado para a atualizacao: ");
            string novoDado = Console.ReadLine();

            //chamar o metodo de atualizacao
            prod.AtualizarProduto( codigo, campo, novoDado);


        }//fim do metodo atualizar

        public void alterarsituacao()
        {
            Console.WriteLine("informe o codigo do produto que deseeja alterar o status: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //chamar metodo alterar situacao - classe produto
            prod.AlterarSituacao(codigo);
            Console.WriteLine("alterado");
        }//fim do metodo

     }//fim da classe

}//fim do projeto
