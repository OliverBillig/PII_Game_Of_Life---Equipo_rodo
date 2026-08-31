//------------------------------------------------------------------------------
// <copyright file="Board.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

public class Board
{
    private readonly Cell[,] celulas;

    public Board(int ancho, int alto)
    {
        this.Ancho = ancho;
        this.Alto = alto;
        this.celulas = new Cell[ancho, alto];

        for (int x = 0; x < ancho; x++)
        {
            for (int y = 0; y < alto; y++)
            {
                this.celulas[x, y] = new Cell();
            }
        }
    }

    public int Ancho { get; }

    public int Alto { get; }

    public void SetEstado(int x, int y, bool viva)
    {
        this.celulas[x, y].SetEstado(viva);
    }

    public bool GetEstado(int x, int y)
    {
        if (x < 0 || x >= this.Ancho || y < 0 || y >= this.Alto)
        {
            return false;
        }

        return this.celulas[x, y].GetEstado();
    }
}