using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    public class PrintBoard
    {
        public static void ImprimirTablero(Board board)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < board.Alto; y++)
                {
                    for (int x = 0; x < board.Ancho; x++)
                    {
                        if(board.GetCelula(x,y))
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                
                Engine.NextGeneration(); //Invoca método para calcular siguiente generación

                Thread.Sleep(300); // cooldown
            }
        }
    }
}