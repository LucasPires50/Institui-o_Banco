using Avaliacao_Banco.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Banco banco = new Banco();

            Agencia agencia = new Agencia();

            Conta conta = new Conta();


            bool Pecorrer = false;
            string Saque = "";
            string Deposito = "";
            string Ano = "";
            string Mes = "";
            string Dia = "";

            Console.WriteLine("Informe seu nome:");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Informer seu CPF:");
            cliente.CPF = Console.ReadLine();
            Console.WriteLine("Informe sua data de nascimento:");
            Console.WriteLine("Dia: ");
            Dia = Console.ReadLine();
            int dia = Convert.ToInt32(Dia);
            Console.WriteLine("Mês: ");
            Mes = Console.ReadLine();
            int mes = Convert.ToInt32(Mes);
            Console.WriteLine("Ano: ");
            Ano = Console.ReadLine();
            int ano = Convert.ToInt32(Ano);
            cliente.DataDeNascimento = new DateTime(ano, mes, dia);
            banco.NomeBanco = "Banco Java";
            banco.CodigoBanco = 032;
            Console.WriteLine(" Informe o número da Agência: ");
            agencia.NumeroAgencia = Console.ReadLine();
            //agencia.Endereco = "Rua Amazonas, nº 64, Bairro: Bits";
            //agencia.Cidade = "Alameda";
            //agencia.Estado = "AM";
            conta.Saldo = 0.00;
            Console.WriteLine("Informe o número da conta: ");
            conta.NumeroConta = Console.ReadLine();
            Console.WriteLine("Informe o Digito Verificador: ");
            conta.DigitoVerificador = Console.ReadLine();


            while (!Pecorrer)
            {
                Console.WriteLine(
                    $"1 - Sacar \n" +
                    $"2 - Depositar \n" +
                    $"3 - Consultar Saldo Disponível \n" +
                    $"4 - Imprimir Extrato \n" +
                    $"5 - Sair \n" +
                    $"Escolha qual operação deseja realizar: ");
                string operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "1":
                        Console.WriteLine($"SAQUE \n" +
                            $"Qual valor do saque: ");
                        Saque = Console.ReadLine();
                        conta.ValorSaque = Convert.ToDouble(Saque);
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine($"Saque: {conta.ValorSaque} \n" +
                            $"Saldo: {conta.Sacar()}");
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "2":
                        Console.WriteLine($"DEPÓSITO \n" +
                            $"Qual o valor do depósito: ");
                        Deposito = Console.ReadLine();
                        conta.ValorDeposito = Convert.ToDouble(Deposito);
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine($"Depósito: {conta.ValorDeposito} \n" +
                            $"Saldo: {conta.Depositar()}");
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "3":
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine($"SALDO DISPONIVEL \n" +
                            $"Saldo: {conta.Saldo}");
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "4":
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine(cliente.InfoCliente() + banco.InfoBanco()
                            + agencia.InfoAgencia() + conta.InfoConta());
                        
                        Console.WriteLine(conta.Extrato.ToString());
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;

                }

            }
        }
    }
}
