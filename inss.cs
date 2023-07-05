using System;
using System.Collections.Generic;
using System.Text;

namespace INSS
{
    class inss
    {
        public Double salario;
        public Double horasextras;
        public Double salariobruto;
        public Double salarioliquido;
        public Double dsctoinss;

        public void Calcularsalbruto()
        {
            this.salariobruto = salario + horasextras;
         }
        
        public void Calcularinss()
        {

            if (this.salariobruto <= 1000)
            {
                dsctoinss = salariobruto * 0.08;
            }
            else if (this.salariobruto > 1000 &&  this.salariobruto <= 1500 ) 
            {
                dsctoinss = salariobruto * 0.09;
            }
            else if (this.salariobruto > 1500)
            {
                dsctoinss = salariobruto * 0.11;
            }

            this.salarioliquido = salariobruto - dsctoinss;
        }
             
        
    }
}
