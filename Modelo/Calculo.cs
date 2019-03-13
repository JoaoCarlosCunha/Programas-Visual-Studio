using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_2_numero.Modelo
{
    public class Calculo
    {
        #region Atributos
        private Double n1;
        private Double n2;
        public Double res;
        #endregion

        #region Contrutores
        public Calculo(Double n1, Double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.Somar();
        }
        #endregion

        #region Propriedades 
             
        private void Somar()
        {
            this.res = this.n1 + this.n2;
        }
                
        public Double Res
        {
            get { return res; }
            
        }
        #endregion

    }
}
