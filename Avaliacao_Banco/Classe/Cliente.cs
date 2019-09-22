using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Banco.Classe
{
    public class Cliente
    {

        public string Nome { get; set; }

        public string CPF { get; set; }
        
        public DateTime DataDeNascimento { get; set;}

        //public DateTime DataDeAberturaDaConta { get; set; }

        public string InfoCliente()
        {
            StringBuilder InfoCliente = new StringBuilder();
            InfoCliente.AppendLine($"Nome: {Nome}");
            InfoCliente.AppendLine($"CPF: {CPF}");
            InfoCliente.AppendLine($"Data de Nascimento: {DataDeNascimento}");
            //InfoCliente.AppendLine($"Data de abertura da conta: {DataDeAberturaDaConta}");

            return InfoCliente.ToString();
        }


    }
}
