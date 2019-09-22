using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Banco.Classe
{
    class Banco
    {
        public string NomeBanco { get; set; }

        public int CodigoBanco { get; set; }

        public override string ToString()
        {
            StringBuilder InfoBanco = new StringBuilder();
            InfoBanco.AppendLine($"{NomeBanco}-{CodigoBanco}");

            return base.ToString();
        }
    }
}
