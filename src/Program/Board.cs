using System;

namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        private bool[,] celulas;

        public Board(int ancho, int alto)
        {
            this.Ancho = ancho;
            this.Alto = alto;
            this.celulas = new bool[ancho, alto];
        }
        private int ancho;
        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        private int alto;
        public int Alto
        {
            get { return alto; }
            set { alto = value; }
        }
       public bool[,] GetCelulas()
        {
            return celulas;
        }

        public bool GetCelula(int x, int y)
        {
            return celulas[x, y];
        }

        public void SetCelula(int posX, int posY, bool valor)
        {
            celulas[posX, posY] = valor;
        }
    }
}