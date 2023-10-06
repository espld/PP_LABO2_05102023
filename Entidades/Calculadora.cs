using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;

        static Calculadora()
        {
            sistema = ESistema.Decimal;
        }

        public Calculadora()             
        {
            this.operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno)          
        {
            this.nombreAlumno = nombreAlumno;
        }










    }
}
