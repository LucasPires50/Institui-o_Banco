﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Banco.Classe
{
    public class Agencia
    {
        public string NumeroAgencia { get; set; }

        //public string Endereco { get; set; }

        //public string Cidade { get; set; }

        //public string Estado { get; set; }

        public string InfoAgencia()
        {
            StringBuilder InfoAgencia = new StringBuilder();
            InfoAgencia.AppendLine($"Número Agência: {NumeroAgencia}");
            //InfoAgencia.AppendLine($"Endereço: {Endereco}, {Cidade}-{Estado}");

            return InfoAgencia.ToString();
        }

    }
}
