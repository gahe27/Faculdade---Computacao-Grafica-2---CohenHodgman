using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AlgoritmoCohenHodgman
{
    internal class Poligono : Desenho
    {
        public Poligono(Pen caneta, Brush preenche, Color cor_caneta, Color cor_preenche)
        {
            this.caneta = caneta;
            this.preenche = preenche;
            this.cor_caneta = cor_caneta;
            this.cor_preenche = cor_preenche;
        }

        public void Desenhar(Graphics graph, Point[] points)
        {
            if(points == null | points.Length == 0)
            {
                MessageBox.Show("Não há pontos suficientes para desenhar o poligono.", "Aviso", MessageBoxButtons.OK);
            }
            graph.DrawPolygon(caneta, points);
        }

        public void Preencher(Graphics graph, Point[] points)
        {
            graph.DrawPolygon(caneta, points);

            RectangleF fillRegion = new RectangleF(points[0].X, points[0].Y, points[2].X - points[0].X, points[1].Y - points[0].Y);
            graph.FillPolygon(preenche, points);
            graph.SetClip(fillRegion, CombineMode.Exclude); 
            graph.DrawPolygon(caneta, points);
            graph.ResetClip();
        }
    }
}
