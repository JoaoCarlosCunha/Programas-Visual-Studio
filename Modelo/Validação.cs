using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_2_numero.Modelo
{
    public class Validação
    {
        private string num1;
        private string num2;
        private Double n1;
        private Double n2;
        private string mensagem;

        public double N1 { get => this.n1;}
        public double N2 { get => this.n2;}
        public string Mensagem { get => this.mensagem;}

        public Validação(string num1, string num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.Validar();
        }

        private void Validar()
        {
            this.mensagem = "";
            try
            {
                this.n1 = Convert.ToDouble(this.num1);
                this.n2 = Convert.ToDouble(this.num2);
            }
            catch (FormatException)
            {
                this.mensagem = "Numero invalido";
            }
        }
    }
}
