using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Numeracion
    {

        protected static string msgError;
        protected string valor;

        static Numeracion()            
        {
            Numeracion.msgError = "Numero Invalido";
        }
        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }
        
        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = Numeracion.msgError;
            }
        }

        protected bool EsNumeracionValida(string valor) 
        {
            if(double.TryParse(valor, out double numero))           
            {
                this.valor = valor;
                return true;
            }
            else
            {
                this.valor = Numeracion.msgError;
                return false;
            }
        }

        public string Valor
        {
            get 
            {
                return this.valor;
            }
        }

        internal double ValorNumerico
        {
            get
            {
                double.TryParse(this.valor, out double resultado);
                return resultado;
            }
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 is null || n2 is null)
            {
                return false;
            }
            if (n1.GetType() != n2.GetType())
            {
                return false;
            }
            
            return n1.Valor == n2.Valor;
        }

        public static bool operator !=(Numeracion n1,Numeracion n2)
        {
            return !(n1.Valor == n2.Valor);
        }

        public static explicit operator double (Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        }
}