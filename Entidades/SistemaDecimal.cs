using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal: Numeracion
    {

        public SistemaDecimal(string valor)
            :base(valor)
        {

        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this;
            }
            else
            {
                return DecimalABinario();
            }
        }
        
        private SistemaBinario DecimalABinario()
        {
            
            if(this.ValorNumerico < 0)
            {
                return new SistemaBinario(Numeracion.msgError);
            }
            else
            {

                string numeroBinario = "";
                double numero = this.ValorNumerico;
                while (numero > 0)
                {
                    double resto = numero % 2;
                    numero /= 2;
                    numeroBinario = resto.ToString() + numeroBinario;
                }

                return new SistemaBinario(numeroBinario);
            }
        }

        protected bool EsNumeracionValida(string valor)
        {
            if(string.IsNullOrEmpty(valor))
            {
                return false;
            }
            else if(double.TryParse(valor, out double numero))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return EsNumeracionValida(valor);
        }

        public static implicit operator SistemaDecimal(double valor) 
        {
            return new SistemaDecimal(valor.ToString());
        }
        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }

        internal double ValorNumerico
        {
            get
            {
                return base.ValorNumerico;
            }
        }



    }
}
