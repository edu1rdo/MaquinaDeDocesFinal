using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //conectar com a classe control produto
           ControlProduto controlprod = new ControlProduto();

            //chamar
            controlprod.operacao();
          





          

            /*
            //consultar os dados desse produto
            Console.WriteLine("\n\n\n ninforme o codigo do produto que esteja consultando");
            
            codigo = Convert.ToInt32(Console.ReadLine());
            //escrever o resultado na tela
            Console.WriteLine("os dados do produto escolhido sao \n\n\n " + prod.ConsultarProduto(codigo));



            
            
            
            prod.ConsultarProduto(1);


            

            Console.ReadLine();// manter a janela aberta, o mesmo que o leia

         */
        
        }// fim do metodo main
    }// fim da classe
}//fim do projeto
