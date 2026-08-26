public class Board
{
    private readonly Cell[,] celulas;

    public Board(Cell[,] celulas)
    {
        this.celulas = celulas;
        this.Ancho = celulas.GetLength(0);
        this.Alto = celulas.GetLength(1);
    }

    public int Ancho { get; }

    public int Alto { get; }

    public Cell ObtenerCelula(int x, int y)
    {
        return this.celulas[x, y];
    }
}