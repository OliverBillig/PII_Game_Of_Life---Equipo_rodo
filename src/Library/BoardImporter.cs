using System.IO;

public static class BoardImporter
{
    public static Board ImportarDesdeArchivo(string rutaArchivo)
    {
        string[] lineas = File.ReadAllLines(rutaArchivo);

        int altura = lineas.Length;
        int ancho = lineas[0].Length;

        Board tablero = new Board(ancho, altura);

        for (int y = 0; y < altura; y++)
        {
            string linea = lineas[y];
            for (int x = 0; x < ancho; x++)
            {
                bool viva = linea[x] == '1';

                tablero.SetEstado(x, y, viva);
            }
        }

        return tablero;
    }
}