// conocer el estado
// cambiar su estado
using System;
using System.Globalization;

public class Cell
{
    public bool estado; // true = viva, false = muerta

    // conocer el estado
    public bool GetEstado()
    {
        return estado;
    }

    // cambiar su estado
    public void SetEstado(bool nuevoEstado)
    {
        estado = nuevoEstado;
    }
}