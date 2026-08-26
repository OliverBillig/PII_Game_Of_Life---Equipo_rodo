using System;
using System.Globalization;
using System.Text;
using System.Threading;

public class PrintBoard
{
    public bool[,] b;
    public int width;
    public int height;

    public PrintBoard(bool [,] board, int width, int height) // constructor
    {
        this.b = board;
        this.width = width;
        this.height = height;
    }


    public void Run() // runea el while que hace el recorrido de la tabla
    {
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if(b[x,y])
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

            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            
            Thread.Sleep(300); // cooldown
        }
    }
}