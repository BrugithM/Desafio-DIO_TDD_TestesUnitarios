using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }
        
        public int Soma(int num1, int num2)
        {
            var resultado = num1 + num2;
            InserirNoHistorico(resultado);
            return resultado;
        }
        public int Subtracao(int num1,int num2)
        {
            var resultado = num1 - num2;
            InserirNoHistorico(resultado);
            return resultado;
        }
        public int Multiplicacao(int num1,int num2)
        {
            var resultado = num1 * num2;
            InserirNoHistorico(resultado);
            return resultado;
        }
        public int Divisao(int num1,int num2)
        {
            var resultado = num1 / num2;
            InserirNoHistorico(resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            if (historico.Count > 3)
            {
                historico.RemoveRange(3, historico.Count - 3);
            }

            return historico;
        }

        public void InserirNoHistorico(int resultado)
        {
            historico.Insert(0, $"Resultado: {resultado} | Data: {DateTime.Now:dd/MM}");
        }
    }
}