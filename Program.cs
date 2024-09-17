using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        // As instruções para o usuário.

        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.Write("Quanto tempo deseja contar? ");
            // lê a entrada do usuário como uma string, 
            string data = Console.ReadLine().ToLower(); // converte toda a string para letras minúsculas.
            // extrai o último caractere da string, que indica o tipo de tempo (s para segundos ou m para minutos).
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // char.Parse() converte essa substring em um caractere.
            //  extrai todos os caracteres da string, exceto o último, que representam o valor numérico do tempo.
            int time = int.Parse(data.Substring(0, data.Length - 1)); // int.Parse() converte essa substring em um inteiro.

            // Console.WriteLine(time);
            // Console.WriteLine(type);
            // Este valor será usado para converter o tempo em segundos.
            int multiplier = 1;
            // Se for 'm', o multiplicador é ajustado para 60, convertendo minutos em segundos.
            if (type == 'm')
                multiplier = 60;
            // Se o valor do tempo for 0, o programa é encerrado usando 
            if (time == 0)
                System.Environment.Exit(0);
            // inicia a contagem regressiva com uma pequena introdução.
            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }


        static void Start(int time)
        {
            //  Acompanhar o tempo atual, começando em 0.
            int currentTime = 0;
            // O loop while continua até que currentTime seja igual ao tempo total.
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.Write("StopWatch finalizado");
            Thread.Sleep(2500);
            Menu();

        }

    }

}