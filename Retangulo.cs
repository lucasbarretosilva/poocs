using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poocs 
{
   public class Retangulo
    {
        private double comprimento;
        private double altura;
        private bool valido;
        
        public void DefinirMedidas(double comprimento, double altura)
            {
               this.comprimento = comprimento;
               this.altura = altura;    
               this.valido = true;

            }

        }
    }

