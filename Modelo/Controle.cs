using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_2_numero.Modelo
{
    public class Controle
    {
        private String num1;
        private String num2;
        private String resultado;
        private String mensagem;

        
        public string Resultado { get => this.resultado;}
        public string Mensagem { get => this.mensagem;}

        public Controle(string num1, string num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.Executar();
        }

        private void Executar()
        {
            this.mensagem = "";
            Validação validacao = new Validação(this.num1, this.num2);
            if(validacao.Mensagem.Equals(""))
            {
                Calculo calculos = new Calculo(validacao.N1, validacao.N2);
                this.resultado = calculos.res.ToString();
                
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
                       
        }
    }
}
