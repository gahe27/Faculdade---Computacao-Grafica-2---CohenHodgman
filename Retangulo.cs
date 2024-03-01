using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmoCohenHodgman
{
    internal class Retangulo : Desenho
    {

        public Retangulo(Pen caneta, SolidBrush preenche, Color cor_caneta, Color cor_preenche)
        {
            this.caneta = caneta;
            this.preenche = preenche;
            this.cor_caneta = cor_caneta;
            this.cor_preenche = cor_preenche;
        }

        public void Desenhar(Graphics graph, Point p1, Point p2) 
        {
            graph.DrawRectangle(caneta, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);       
        }

        public void Preencher(Graphics graph, Point p1, Point p2)
        {
            graph.FillRectangle(preenche, p1.X + 1, p1.Y + 1, p2.X - p1.Y - 1, p2.Y - p1.Y - 1);
        }
    }
}
