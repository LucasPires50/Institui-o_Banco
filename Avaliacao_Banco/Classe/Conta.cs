using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Banco.Classe
{
    public class Conta
    {
        public StringBuilder Extrato = new StringBuilder();
        public string NumeroConta { get; set; }

        public string DigitoVerificador { get; set; }

        public double Saldo { get; set; }

        public double Limite { get; set; }

        public double ValorDeposito { get; set; }

        public double ValorSaque { get; set; }



        public double Sacar()
        {

            if (Saldo < ValorSaque)
            {
                ValorSaque = 0.00;
                Console.WriteLine("Saldo insuficiente");
                Extrato.AppendLine($"Saque: {ValorSaque - ValorSaque}");

            }
            else
            {
                Extrato.AppendLine($"Saque: {ValorSaque}");
                Extrato.AppendLine($"Saldo: {Saldo - ValorSaque}");
                return this.Saldo -= ValorSaque;


            }

            return Saldo;

        }

        public double Depositar()
        {
            Extrato.AppendLine($"Deposito: {ValorDeposito}");
            Extrato.AppendLine($"Saldo: {Saldo + ValorDeposito}");
            return this.Saldo += ValorDeposito;
        }

        public string InfoConta()
        {
            StringBuilder InfoConta = new StringBuilder();
            InfoConta.AppendLine($"Conta: {NumeroConta}-{DigitoVerificador}");

            return InfoConta.ToString();
        }
        
    }
}
