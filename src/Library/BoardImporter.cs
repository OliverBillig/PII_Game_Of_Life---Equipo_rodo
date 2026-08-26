//------------------------------------------------------------------------------
// <copyright file="BoardImporter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.IO;

public class BoardImporter
{
    public Cell[,] ImportarDesdeArchivo(string rutaArchivo)
    {
        string[] lineas = File.ReadAllLines(rutaArchivo);

        int altura = lineas.Length;
        int ancho = lineas[0].Length;

        Cell[,] tablero = new Cell[ancho, altura];

        for (int y = 0; y < altura; y++)
        {
            string linea = lineas[y];
            for (int x = 0; x < ancho; x++)
            {
                Cell celula = new Cell();
                celula.SetEstado(linea[x] == '1');
                tablero[x, y] = celula;
            }
        }

        return tablero;
    }
}