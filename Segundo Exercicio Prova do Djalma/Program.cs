using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Exercicio_Prova_do_Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            string cidade = null;
            Console.WriteLine(" 1–Atibaia" + "\n" + "2–Bragança Paulista" + "\n" + "3-Mairiporã" + "\n" + "4-Nazaré" + "\n" + "5-Terra Preta" + "\n" + "6-Extrema" + "\n" + "7-Vargem");
            Console.WriteLine("Informe o codigo da cidade escolhida.");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O codigo é: " + codigo);
            switch (codigo)
            {
                case 1:
                    cidade = "Atibaia";
                    break;

                case 2:
                    cidade = "Bragança Paulista";
                    break;

                case 3:
                    cidade = "Mairiporã";
                    break;

                case 4:
                    cidade = "Nazaré";
                    break;

                case 5:
                    cidade = "Terra Preta";
                    break;

                case 6:
                    cidade = "Extrema";
                    break;

                case 7:
                    cidade = "Vargem";
                    break;





            }
            int mes, dia, ano;
            Console.WriteLine("Digite uma Data  (dd/mm/aaaa):");
            var dataatual = Convert.ToDateTime(Console.ReadLine());
            mes = dataatual.Month;
            dia = dataatual.Day;
            ano = dataatual.Year;

            string datadesejada = Dataextenso(mes);
            Console.WriteLine(cidade + "," + dia + " de " + datadesejada + " de " + ano);

            Console.ReadKey();
        }
        static public string Dataextenso(int mes)
        {
            string mesextenso = null;
            switch (mes)

            {
                case 1:
                    mesextenso = "Janeiro";
                    break;

                case 2:
                    mesextenso = "Fevereiro";
                    break;

                case 3:
                    mesextenso = "Março";
                    break;

                case 4:
                    mesextenso = "Abril";
                    break;

                case 5:
                    mesextenso = "Maio";
                    break;

                case 6:
                    mesextenso = "Junho";
                    break;

                case 7:
                    mesextenso = "Julho";
                    break;

                case 8:
                    mesextenso = "Agosto";
                    break;

                case 9:
                    mesextenso = "Setembro";
                    break;

                case 10:
                    mesextenso = "Outubro";
                    break;

                case 11:
                    mesextenso = "Novembro";
                    break;

                case 12:
                    mesextenso = "Dezembro";
                    break;


            }
            string dataconvertida = mesextenso;

            return dataconvertida;

            
            
            
            
        }


    }


            
           

        
          
    
}







