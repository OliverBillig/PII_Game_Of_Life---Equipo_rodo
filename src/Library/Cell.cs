// conocer el estado
// cambiar su estado
using System;
using System.Globalization;

public class Cell
{
    public bool estado; // true = viva, false = muerta

    // conocer el estado
    public bool GetEstado() // funcion que retorna el estado actual de la celula
    {
        return estado;
    }

    // cambiar su estado
    public void SetEstado(bool nuevoEstado) // funcion que cambia el estado de la celula a un nuevo estado
    {
        estado = nuevoEstado;
    }
}