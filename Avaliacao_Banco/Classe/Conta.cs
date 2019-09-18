using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Banco.Classe
{
    class Conta
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

            if (Saldo < ValorSaque || ValorSaque > Limite)
            {
                ValorSaque = 0.00;
                Console.WriteLine("Saldo Insuficiente");
                Extrato.AppendLine($"Saldo: {Saldo - ValorSaque}");
            }
            else
            {
                Extrato.AppendLine($"Saque: {ValorSaque}");
                Extrato.AppendLine($"Saldo: {Saldo - ValorSaque}");
                return this.Saldo -= ValorSaque;
                
            }

            return Saldo;
        }

        public double depositar()
        {
            Extrato.AppendLine($"Deposito: {ValorDeposito}");
            Extrato.AppendLine($"Saldo: {Saldo + ValorDeposito}");
            return this.Saldo += ValorDeposito;
        }

        
    }
}
