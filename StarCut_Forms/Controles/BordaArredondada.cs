using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class BordaArredondada
{
    public static void Arredondar(Control controle, int raio)
    {
        var bounds = controle.ClientRectangle;
        var path = new GraphicsPath();
        int diametro = raio * 2;

        path.StartFigure();
        path.AddArc(bounds.X, bounds.Y, diametro, diametro, 180, 90); // topo-esquerda
        path.AddArc(bounds.Right - diametro, bounds.Y, diametro, diametro, 270, 90); // topo-direita
        path.AddArc(bounds.Right - diametro, bounds.Bottom - diametro, diametro, diametro, 0, 90); // baixo-direita
        path.AddArc(bounds.X, bounds.Bottom - diametro, diametro, diametro, 90, 90); // baixo-esquerda
        path.CloseFigure();

        controle.Region = new Region(path); // aplica a forma
    }
}
