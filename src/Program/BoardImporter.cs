using System.IO;

namespace Ucu.Poo.GameOfLife
{
    public static class BoardImporter
    {
        public static Board ImportarTablero(string rutaArchivo)
        {
            string[] lineas = File.ReadAllLines(rutaArchivo);

            int alto = lineas.Length;
            int ancho = lineas[0].Length;

            Board tablero = new Board(ancho, alto);

            for (int y = 0; y < alto; y++)
            {
                string linea = lineas[y];
                for (int x = 0; x < ancho; x++)
                {
                    bool viva = linea[x] == '1';

                    tablero.SetCelula(x, y, viva);
                }
            }
            return tablero;
        }
    }
}