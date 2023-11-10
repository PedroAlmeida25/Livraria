using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_Livros
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteFomulario control = new ClienteFomulario();//Instanciando
            control.Acesso();

            //Manter aberto
            Console.ReadLine();
        }//fim do método main
    }//fim da classe
}//fim do projeto
