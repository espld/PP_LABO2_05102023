using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {

        public SistemaBinario(string valor) 
            :base(valor)
        {
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return this;
            }
            else
            {
                return BinarioADecimal();
            }
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char caracter in valor)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        protected bool EsNumeracionValida(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return false;
            }
            else if(EsSistemaBinarioValido(valor))
            {
                return true;
            }                   
            else
            {
                return false;
            }
        }

        public SistemaDecimal BinarioADecimal()
        {
            double resultado = 0;
            string valorBinario = this.Valor;
            for (int i = valorBinario.Length - 1; i >= 0; i--)
            {
                if (valorBinario[i] == '1')
                {
                    resultado += Math.Pow(2, valorBinario.Length - 1 - i);
                }
            }
            return new SistemaDecimal(resultado.ToString());
        }
        internal double ValorNumerico
        {
            get
            {
                return base.ValorNumerico;
            }
        }

        public static implicit operator SistemaBinario(string valor)
        {
                return new SistemaBinario(valor);
        }

    }
}
