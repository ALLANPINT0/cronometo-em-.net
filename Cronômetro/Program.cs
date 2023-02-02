using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronômetro
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("S = SEGUNDOS => 10S(10 SEGUNDOS) \nM = MINUTOS => 1M(1 MINUTO)\n0 = SAIR => ZERO PARA SAIR DA APLICACAO\n \nQuanto tempo Deseja Contar?");
            string dado = Console.ReadLine().ToLower();
            char tipo = char.Parse(dado.Substring(dado.Length -1 ,1));
            int tempo = int.Parse(dado.Substring(0,dado.Length -1));
            Console.WriteLine(tipo);
            Console.WriteLine(tempo);
            int x = 1;
            if (tipo == 'm')
            {
                x = 60;
            }else if (tipo == 0)
            {
                System.Environment.Exit(0);
            }
            start(tempo * x);
            

        }
        static void start(int Tempo)
        {
            
             
            int TempoAtual = 0;

            while(TempoAtual != Tempo)
            {
                Console.Clear();
                Console.WriteLine("tempo ");
                TempoAtual++;
                Console.WriteLine(TempoAtual + "S");
                Thread.Sleep(1000);

            }
            Console.Clear() ;
            Console.WriteLine("ACABOU LEVANTA");
            Thread.Sleep(2500);
            
        }
    }
}
