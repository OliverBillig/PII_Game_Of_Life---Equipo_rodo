// conocer el tablero
// crear generación

using System;

namespace Library
{
    public class Engine
    {
        public Cell[,] NextGeneration(Cell[,] tablero)
        {
            int ancho = tablero.GetLength(Board.Ancho);
            int altura = tablero.GetLength(Board.Alto);
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
                            if (i >= 0 && i < ancho && j >= 0 && j < altura && tablero[i, j].GetEstado())
                            {
                                vecinosVivos++;
                            }
                        }
                    }

                    if (tablero[x, y].GetEstado())
                    {
                        vecinosVivos--;
                    }

                    Cell nuevaCelula = new Cell();

                    if (tablero[x, y].GetEstado() && vecinosVivos < 2)
                    {
                        nuevaCelula.SetEstado(false); // muere por baja población
                    }
                    else if (tablero[x, y].GetEstado() && vecinosVivos > 3)
                    {
                        nuevaCelula.SetEstado(false); // muere por sobrepoblación
                    }
                    else if (!tablero[x, y].GetEstado() && vecinosVivos == 3)
                    {
                        nuevaCelula.SetEstado(true); // nace por reproducción
                    }
                    else
                    {
                        nuevaCelula.SetEstado(tablero[x, y].GetEstado()); // mantiene el estado
                    }

                    tableroClon[x, y] = nuevaCelula;
                }
            }

            return tableroClon;
        }
    }
}