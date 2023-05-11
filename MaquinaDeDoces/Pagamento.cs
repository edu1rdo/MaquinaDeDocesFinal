using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        private int Codigo;
        private string Descricao;
        private double ValorTotal;
        private double FormadePagamento;
        private DateTime Data;
        private DateTime hora;
        private int CodCartao;
        private string BandeiraCartao;


        //metodo construtor

        public Pagamento() 
        
        {
            ModificarCodigo                  = 0;
            ModificarDescricao               = "";
            ModificarValorTotal              = 0; 
            ModificarFormadePagamento        = 0;
            ModificarData                    = new DateTime();//0000/00/00 00:00:00
            ModificarHora                    = new DateTime();//0000/00/00 00:00:00
            ModificarCodCartao               = 0;
            ModificarBandeiraCartao          = "";
        
        
        }// fim do metodo construtor
        

        public Pagamento(int codigo, string descricao, double valoraTotal, double formadePagamento,
            DateTime data, DateTime hora, int codCartao, string bandeiraCartao)
        {//metodo construtor com parametros
            ModificarCodigo            = codigo;
            ModificarDescricao         = descricao;
            ModificarValorTotal        = valoraTotal;
            ModificarFormadePagamento  = formadePagamento;
            ModificarData              = data;
            ModificarHora              = hora;
            ModificarCodCartao         = codCartao;
            ModificarBandeiraCartao    = bandeiraCartao;
        }// fim do metodo construtor com parametros



        //Métodos Get e Set
        //Métodos de acesso e modificação
        public int ModificarCodigo
        {
            get
            {
                return this.Codigo;
            }//fim do get - retornar o código

            set
            {
                this.Codigo = value;
            }//fim do set - modificar o código
       
        
            }//fim do ModificarCodigo

        public string ModificarDescricao
        {//modificar valor total
            get {return this.Descricao;}
            set { this.Descricao = value; }
        }//fim moidificar descricao

        public double ModificarValorTotal
        {
            get { return this.ValorTotal; }
            set { this.ValorTotal = value; }
        }//fim modificar valor total

        public double ModificarFormadePagamento
        {//modificar valor total
            get { return this.FormadePagamento;}
            set { this.FormadePagamento = value;}
        }//fim modificar valor total

        public DateTime ModificarData
        {//modificar data
            get { return this.Data; }
            set { this.Data = value; }
            
               
            
        }//fim modificar data

        public DateTime ModificarHora
        {//modificar hora
            get { return this.hora; }
            set { this.hora = value; }

        }//fim modificar hora

        public int ModificarCodCartao
        {//modificar codcartao
            get { return this.CodCartao; }
            set { this.CodCartao = value; }
        }// fim modificar codcartao

        public string ModificarBandeiraCartao
        {//modificar bandeiraCartao
            get { return this.BandeiraCartao;}
            set { this.BandeiraCartao = value;}
        }// fim modificar Bandeiracartao

        //metodo cadastrar pagamento

        public void VerificarNotas(int codigo,string descricao, double valorTotal,
            double FormadePagamento, string BandeiraCartao)
        {//metodo cadastrar pagamento

            ModificarCodigo                   = codigo;
            ModificarDescricao                = descricao;
            ModificarValorTotal               = valorTotal;
            ModificarFormadePagamento         = FormadePagamento;
                      
            ModificarBandeiraCartao           =  BandeiraCartao;



        }// fim do metodo cadastrar pagamento

        public void ConsultarPagamento(int codigo)
        {
            string msg = "";//Criando uma variável local
            if (ModificarCodigo == codigo)
            {
                msg = "\nCódigo: "     + ModificarCodigo +
                    "\nValorTotal"     + ModificarValorTotal +
                "\nFormadePagamento "  + ModificarFormadePagamento;

            }
            else
            {
                msg = "O código digitado não existe!";
            }





        }



    }// fim das classes




}//fim do projeto
