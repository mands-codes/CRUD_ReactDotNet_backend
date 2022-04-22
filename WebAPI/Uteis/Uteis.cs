using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Uteis
{
    public class Uteis
    {

        public static decimal padronizaCNPJ(string cnpj)
        {
            var cnpjEditado = cnpj.Replace("/", "").Replace(".", "");

            decimal novoCNPJ = decimal.Parse(cnpjEditado);

            return novoCNPJ;

        }

    }
}
