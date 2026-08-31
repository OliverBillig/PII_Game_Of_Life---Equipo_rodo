// conocer el tablero
// crear generación

using System;

namespace Library
{
    public class Engine
    {
        public Board NextGeneration(Board tablero)
        {
            int ancho = tablero.Ancho;
            int altura = tablero.Alto;
            Cell[,] tableroClon = new Cell[ancho, altura];

            for (int x = 0; x < ancho; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    int vecinosVivos = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < ancho && j >= 0 && j < altura && tablero.ObtenerCelula(i, j).GetEstado())
                            {
                                vecinosVivos++;
                            }
                        }
                    }
                    if (tablero.ObtenerCelula(x, y).GetEstado())
                    {
                        vecinosVivos--;
                    }

                    Cell nuevaCelula = new Cell();

                    if (tablero.ObtenerCelula(x, y).GetEstado() && vecinosVivos < 2)
                    {
                        nuevaCelula.SetEstado(false); // muere por baja población
                    }
                    else if (tablero.ObtenerCelula(x, y).GetEstado() && vecinosVivos > 3)
                    {
                        nuevaCelula.SetEstado(false); // muere por sobrepoblación
                    }
                    else if (!tablero.ObtenerCelula(x, y).GetEstado() && vecinosVivos == 3)
                    {
                        nuevaCelula.SetEstado(true); // nace por reproducción
                    }
                    else
                    {
                        nuevaCelula.SetEstado(tablero.ObtenerCelula(x, y).GetEstado()); // mantiene el estado
                    }

                    tableroClon[x, y] = nuevaCelula;
                }
            }

            return new Board(tableroClon);
        }
    }
}