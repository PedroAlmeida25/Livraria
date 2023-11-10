using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_Livros
{
    class ClienteFomulario
    {
        public int dados;
        public string resultado;
        public string email;
        public string senha;
        public string nome;
        public string telefone;
        public string dataDeNascimento;
        public string endereco;
        public int livros;
        public int login;
        public int confirme;
        public int numCartao;
        public int codCartao;
        public int valCartao;
        

        ModelExercício exercicio;
        public ClienteFomulario()
        {
            exercicio = new ModelExercício();//Conecta a classe model e a control
        }
        public void Menu()
        {
            Console.WriteLine("\n\n ----- Início -----\n\n" +
                              "1. Login\n" +
                              "2. Cadastro\n");
            dados = Convert.ToInt32(Console.ReadLine());
        }

        public void Acesso()
        {
            do
            {
                Menu();
                switch (dados)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Informe o email: ");
                            email = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Informe a senha: ");
                            senha = Convert.ToString(Console.ReadLine());
                            Quantidade();
                        } while (login != 0);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Informe o email: ");
                            email = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Informe a senha: ");
                            senha = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Informe o seu nome: ");
                            nome = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Informe a data de nascimento: ");
                            dataDeNascimento = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Informe o telefone: ");
                            telefone = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Informe o endereço: ");
                            endereco = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Cadastro Concluído");
                        } while (login != 0);
                        Catalogo();
                        break;

                }
            } while (dados != 0);
        }//fim do método

        public int Catalogo()
        {
            Console.WriteLine("\n\n ----- Catálogo de Livros -----\n\n" +
                              "1. O pequeno Príncipe\n" +
                              "2. Senhor do Anéis\n" +
                              "3. Lado Feio do Amor\n" +
                              "4. Todas as Suas (im)perfeições\n" +
                              "5. Romeu e Julieta\n" +
                              "6. Hamlet\n" +
                              "7. Macbeth\n" +
                              "8. Os Lusíadas\n" +
                              "9. O Prícipe\n" +
                              "10. Dom Casmurro\n" +
                              "11. As Tranças do Rei Careca\n" + 
                              "12. Harry Potter\n" +
                              "13. Star Wars\n" +
                              "14. O Rei Leão\n" +
                              "15. Os Três Porquinhos\n" +
                              "16. Poeira em Alto Mar\n" +
                              "17. Lógica de Programação\n" +
                              "18. A Volta dos que não foram\n" +
                              "19. O Homem mais rico da Babilônia\n" +
                              "20. Os Segredos da Mente Milionária\n");
            livros = Convert.ToInt32(Console.ReadLine());
            return livros;
        }//fim do método

        public void Quantidade()
        {
            do
            {
                livros = Catalogo();
                switch (livros)
                {
                    case 1:
                        Console.WriteLine("O Pequeno Príncipe tem: " + exercicio.PequenoPrincipe() + " unidades.\n");
                        EfetuarCompra();
                        break;
                    case 2:
                        Console.WriteLine("Senhor do Anéis tem: " + exercicio.SenhorDosAneis() + " unidades.");
                        EfetuarCompra();
                        break;
                    case 3:
                        Console.WriteLine("O Lado Feio do Amor tem: " + exercicio.LadoFeio() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 4:
                        Console.WriteLine("O Todas as Suas (im)perfeições tem: " + exercicio.TodasAs() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 5:
                        Console.WriteLine("O Romeu e Julieta tem: " + exercicio.RomeuJulieta() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 6:
                        Console.WriteLine("O Hamlet tem: " + exercicio.Hamlet() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 7:
                        Console.WriteLine("O Macbeth tem: " + exercicio.Macbeth() + " unidades.\n");
                        EfetuarCompra();
                        break;  
                        case 8:
                        Console.WriteLine("O Lusíadas tem: " + exercicio.Lusiadas() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 9:
                        Console.WriteLine("O Príncipe tem: " + exercicio.Principe() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 10:
                        Console.WriteLine("O Dom Casmurro tem: " + exercicio.DomCasmurro() + " unidades.\n");
                        EfetuarReserva();
                        break;
                        case 11:
                        Console.WriteLine("As tranças do Rei Careca tem: " + exercicio.AsTrancas() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 12:
                        Console.WriteLine("O Harry Potter tem: " + exercicio.HarryPotter() + " unidades.\n");
                        EfetuarReserva();
                        break;
                        case 13:
                        Console.WriteLine("O Star Wars: " + exercicio.StarWars() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 14:
                        Console.WriteLine("O Rei Leão tem: " + exercicio.ReiLeao() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 15:
                        Console.WriteLine("O Os três Porquinhos tem: " + exercicio.Tres() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 16:
                        Console.WriteLine("O Poeira em Alto Mar tem: " + exercicio.Poeira() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 17:
                        Console.WriteLine("O Lógica de Programação tem: " + exercicio.Logica() + " unidades.\n");
                        EfetuarReserva();
                        break;
                        case 18:
                        Console.WriteLine("O A Volta dos que não foram tem: " + exercicio.Avolta() + " unidades.\n");
                        EfetuarReserva();
                        break;
                        case 19:
                        Console.WriteLine("O O Homem mais rico da Babilônia tem: " + exercicio.HomemRico() + " unidades.\n");
                        EfetuarCompra();
                        break;
                        case 20:
                        Console.WriteLine("O Segredos da Mente Milionária tem: " + exercicio.Mente() + " unidades.\n");
                        EfetuarReserva();
                        break;
                    default:
                        Console.WriteLine("Fim do método");
                        break;
                }
            }while(livros != 0);
        }
        public int Confirmacao()
        {
            Console.WriteLine("\n\n ----- Deseja confirmar a compra -----\n\n" +
                               "1. Sim\n" +
                               "2. Não\n");
            dados = Convert.ToInt32(Console.ReadLine());
            return dados;
        }//fim do método

        public void EfetuarCompra()
        {
           
                confirme = Confirmacao();
                switch (confirme)
                {
                    case 1:
                        Console.WriteLine("Digite o número do seu cartão.");
                        numCartao = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Digite o código de segurança.");
                        codCartao = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite a válidade do cartão.");
                        valCartao = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Sua compra foi realizada com sucesso!");
                            Quantidade();
                        break;
                    case 2:
                    Quantidade();
                    break;
                }//fim do switch
          
        }
        public int Reserva()
        {
            Console.WriteLine("\n\n ----- O livro não está disponível no momento, deseja fazer a reserva? -----\n\n" +
                               "1. Sim\n" +
                               "2. Não\n");
            dados = Convert.ToInt32(Console.ReadLine());
            return dados;
        }

        public void EfetuarReserva()
        {

            confirme = Reserva();
            switch (confirme)
            {
                case 1:
                    Console.WriteLine("Sua reserva foi feita com sucesso\n" + "quando estiver diponível, entraremos em contato.");
                    Quantidade();
                    break;
                case 2:
                    Quantidade();
                    break;
            }//fim do switch
        }//fim do método
    }//fim da classe
}//fim do projeto
