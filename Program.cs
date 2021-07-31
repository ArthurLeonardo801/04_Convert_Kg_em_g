using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Converte_Kg_em_g
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1) Valkiria é uma empreendedora que vende produtos naturais, ela está querendo fazer um mini programa para vender lentilha 
            Faça um programa que calcule, o valor da lentilha vs o preço do peso.
            Valor do peso da lentilha: 1,50 o KG

            No final do programa, mostrar o valor total e quantos KG a pessoa selecionou, detalhe o pedido também pode ser vendido em gramas*/


            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("     Exercicio de fixação operadores Logicos C#       ");
            Console.WriteLine("       Valor do peso da lentilha: 1,50 o KG           ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Informe a quantidade de Lentilhas em gramas desejada: ");
            double qtd = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double kg = qtd / 1000;
            Console.WriteLine("Valor Total a ser pago: " + kg * 1.50);
            Console.WriteLine("Total em KG: " + kg);

        }
    }
}
