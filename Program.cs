using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Software_inteligente
{
    class Program
    {
        public void pergunta(){
            Random num = new Random();
            int aleatorio;
            String pergunta;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Faça uma pergunta.....");
                Console.ForegroundColor = ConsoleColor.Gray;
                pergunta = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if(pergunta.ToLower() == "Sair")
                {
                    break;
                }
                if (pergunta.Contains("Nome"))
                {
                    Console.WriteLine("Nome é inteligente!");
                    continue;
                }
                if(pergunta.Length == 0)
                {
                    Console.WriteLine("Voce não perguntou nada!");
                    continue;
                }
                if(!pergunta.Contains("?"))
                {
                    Console.WriteLine("isso não foi uma pregunta....");
                    continue;
                }

                aleatorio = num.Next(5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pensando na resposta......");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                switch (aleatorio)
                {
                    case 0:
                        {
                            Console.WriteLine("Sim");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Não");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Talvez");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Quem Sabe");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Não sei");
                            break;
                        }

                }
            }
            Console.ReadKey();
        }

        void perguntaComplexa(){
            Random aleatorio = new Random();
            int num;
            num = aleatorio.Next(6);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pensando na resposta......");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            switch(num){
                case 0: {
                    Console.WriteLine("por que a pergunta ?");
                    break;
                }

                case 1:{
                    Console.WriteLine("Voce e um idiota");
                    break;
                }

                case 2:{
                    Console.WriteLine("faz difernça ?");
                    break;
                }

                case 3:{
                    Console.WriteLine("...... não sei");
                    break;
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program me = new Program();
            me.pergunta();
        }
    }
}
