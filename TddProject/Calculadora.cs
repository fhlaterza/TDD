using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TddProject
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listaHistorico.Insert(0, "Num1: " + num1 + " + Num2: " + num2 + " = " + resultado + "data: " + data);
            return resultado;
            //return 0;
        }

        public int subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listaHistorico.Insert(0, "Num1: " + num1 + " - Num2: " + num2 + " = " + resultado + "data: " + data);
            return resultado;
            //return 0;
        }

        public int multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listaHistorico.Insert(0, "Num1: " + num1 + " x Num2: " + num2 + " = " + resultado + "data: " + data);
            return resultado;
            //return 0;
        }

        public int dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listaHistorico.Insert(0, "Num1: " + num1 + " / Num2: " + num2 + " = " + resultado + "data: " + data);
            return resultado;
            //return 0;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3,listaHistorico.Count-3); 
            //apenas os 3 últimos incluídos, que são os 3 primeiros da lista, sendo que fomos incluindo sempre na posição 0)

            return listaHistorico;
        }

        
    }
}