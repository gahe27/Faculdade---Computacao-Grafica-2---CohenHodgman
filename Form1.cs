using System.Drawing.Drawing2D;
using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Collections.Generic;

namespace AlgoritmoCohenHodgman
{
    public partial class Form1 : Form
    {
        // Variáveis globais
        Point[] viewport;
        Point[] poligonog;

        public Point calculaInterseccao(Point p1, Point p2, double xmin, double xmax, double ymin, double ymax)
        {
            double X1 = p1.X;
            double Y1 = p1.Y;
            double X2 = p2.X;
            double Y2 = p2.Y;

            double m1 = (Y2 - Y1) / (X2 - X1);
            double m2 = (X2 - X1) / (Y2 - Y1);

            double XInter = 0;
            double YInter = 0;

            if (X1 < xmin || X1 > xmax || Y1 < ymin || Y1 > ymax)
            {
                if (X1 < xmin)
                {
                    XInter = xmin;
                    YInter = Y1 + (xmin - X1) * m1;
                }
                else if (X1 > xmax)
                {
                    XInter = xmax;
                    YInter = Y1 + (xmax - X1) * m1;
                }
                else if (Y1 < ymin)
                {
                    YInter = ymin;
                    XInter = X1 + (ymin - Y1) * m2;
                }
                else if (Y1 > ymax)
                {
                    YInter = ymax;
                    XInter = X1 + (ymax - Y1) * m2;
                }
                return new Point((int)XInter, (int)YInter);
            }
            return Point.Empty;
        }

        public Point[] cohenHodgman()
        {
            List<Point> poligonoR = new List<Point>();
            int xmin, xmax, ymin, ymax;
            bool atualD, antD, proxD, ultimoD;

            xmin = viewport[0].X;
            xmax = viewport[1].X;
            ymin = viewport[0].Y;
            ymax = viewport[1].Y;

            for (int i = 0; i < poligonog.Length; i++)
            {
                if (i == 0)
                {
                    atualD = (poligonog[i].X >= xmin && poligonog[i].X <= xmax && poligonog[i].Y >= ymin && poligonog[i].Y <= ymax);
                    if (atualD)
                    {
                        poligonoR.Add(poligonog[i]);
                    }
                    else
                    {
                        proxD = (poligonog[i + 1].X >= xmin && poligonog[i + 1].X <= xmax && poligonog[i + 1].Y >= ymin && poligonog[i + 1].Y <= ymax);
                        antD = (poligonog[poligonog.Length - 1].X >= xmin && poligonog[poligonog.Length - 1].X <= xmax && poligonog[poligonog.Length - 1].Y >= ymin && poligonog[poligonog.Length - 1].Y <= ymax);

                        if (!antD && !atualD && !proxD && poligonog[i].X < xmin && poligonog[i].Y < ymin)
                        {
                            poligonoR.Add(new Point(xmin, ymin));
                        }
                        else if (!antD && !atualD && !proxD && poligonog[i].X < xmin && poligonog[i].Y > ymax)
                        {
                            poligonoR.Add(new Point(xmin, ymax));
                        }
                        else if (!antD && !atualD && !proxD && poligonog[i].X > xmax && poligonog[i].Y > ymax)
                        {
                            poligonoR.Add(new Point(xmax, ymax));
                        }
                        else if (!antD && !atualD && !proxD && poligonog[i].X > xmax && poligonog[i].Y < ymin)
                        {
                            poligonoR.Add(new Point(xmax, ymin));
                        }
                        else if (!atualD && proxD && !antD && (poligonog[i].X > xmax && poligonog[i].Y > ymin && poligonog[poligonog.Length - 1].Y < ymin && poligonog[poligonog.Length - 1].X > xmax))
                        {
                            poligonoR.Add(new Point(xmax, ymin));
                        }
                        else if (!atualD && proxD && !antD && (poligonog[i].X < xmax && poligonog[i].Y < ymin && poligonog[poligonog.Length - 1].Y < ymin && poligonog[poligonog.Length - 1].X > xmax))
                        {
                            poligonoR.Add(new Point(xmax, ymin));
                        }
                        else if (!atualD && proxD && !antD && (poligonog[i].X > xmax && poligonog[i].Y < ymax && poligonog[poligonog.Length - 1].Y > ymax && poligonog[poligonog.Length - 1].X > xmax))
                        {
                            poligonoR.Add(new Point(xmax, ymax));
                        }
                        else if (!atualD && proxD && !antD && (poligonog[i].X < xmax && poligonog[i].Y > ymin && poligonog[poligonog.Length - 1].Y > ymax && poligonog[poligonog.Length - 1].X > xmax))
                        {
                            poligonoR.Add(new Point(xmax, ymax));
                        }
                        else if (!atualD && proxD && !antD && (poligonog[i].X < xmin && poligonog[i].Y > ymin && poligonog[poligonog.Length - 1].Y < ymin && poligonog[poligonog.Length - 1].X < xmin))
                        {
                            poligonoR.Add(new Point(xmin, ymin));
                        }
                        else if (!atualD && proxD && !antD && (poligonog[i].X < xmax && poligonog[i].Y < ymin && poligonog[poligonog.Length - 1].Y < ymin && poligonog[poligonog.Length - 1].X < xmin))
                        {
                            poligonoR.Add(new Point(xmin, ymin));
                        }
                        else if (!atualD && proxD && !antD && (poligonog[i].X < xmax && poligonog[i].Y > ymax && poligonog[poligonog.Length - 1].Y > ymax && poligonog[poligonog.Length - 1].X < xmin))
                        {
                            poligonoR.Add(new Point(xmin, ymax));
                        }
                        else if (!atualD && proxD && !antD && (poligonog[i].X < xmin && poligonog[i].Y < ymax && poligonog[poligonog.Length - 1].Y > ymax && poligonog[poligonog.Length - 1].X < xmin))
                        {
                            poligonoR.Add(new Point(xmin, ymax));
                        }
                    }
                }
                else
                {
                    antD = (poligonog[i - 1].X >= xmin && poligonog[i - 1].X <= xmax && poligonog[i - 1].Y >= ymin && poligonog[i - 1].Y <= ymax);
                    atualD = (poligonog[i].X >= xmin && poligonog[i].X <= xmax && poligonog[i].Y >= ymin && poligonog[i].Y <= ymax);

                    if (!antD && atualD)
                    {
                        //calcular o vértice de intersecção de poligonog[i-1] com a viewport
                        Point pInt = calculaInterseccao(poligonog[i - 1], poligonog[i], xmin, xmax, ymin, ymax);
                        poligonoR.Add(pInt);/*recebe o valor da intersecção*/ //posR++;
                        poligonoR.Add(poligonog[i]); //posR++;


                    }
                    else if (antD && atualD)
                    {
                        poligonoR.Add(poligonog[i]); //posR++;
                    }
                    else if (antD & !atualD)
                    {
                        //calcular o vértice de intersecção de poligonog[i] com a viewport
                        Point pInt = calculaInterseccao(poligonog[i], poligonog[i - 1], xmin, xmax, ymin, ymax);
                        poligonoR.Add(pInt);
                        //posR++;
                    }
                    else
                    {
                        if (i < poligonog.Length - 1)
                        {
                            proxD = (poligonog[i + 1].X >= xmin && poligonog[i + 1].X <= xmax && poligonog[i + 1].Y >= ymin && poligonog[i + 1].Y <= ymax);
                            //ultimoD = (poligonog[poligonog.Length-1].X >= xmin && poligonog[poligonog.Length - 1].X <= xmax && poligonog[poligonog.Length - 1].Y >= ymin && poligonog[poligonog.Length - 1].Y <= ymax);

                            if (!antD && !atualD && !proxD && poligonog[i].X < xmin && poligonog[i].Y < ymin)
                            {
                                poligonoR.Add(new Point(xmin, ymin));
                            }
                            else if (!antD && !atualD && !proxD && poligonog[i].X < xmin && poligonog[i].Y > ymax)
                            {
                                poligonoR.Add(new Point(xmin, ymax));
                            }
                            else if (!antD && !atualD && !proxD && poligonog[i].X > xmax && poligonog[i].Y > ymax)
                            {
                                poligonoR.Add(new Point(xmax, ymax));
                            }
                            else if (!antD && !atualD && !proxD && poligonog[i].X > xmax && poligonog[i].Y < ymin)
                            {
                                poligonoR.Add(new Point(xmax, ymin));
                            }
                        }
                        else
                        {
                            proxD = (poligonog[poligonog.Length - 1].X >= xmin && poligonog[poligonog.Length - 1].X <= xmax && poligonog[poligonog.Length - 1].Y >= ymin && poligonog[poligonog.Length - 1].Y <= ymax);

                            if (!antD && !atualD && !proxD && poligonog[i].X < xmin && poligonog[i].Y < ymin)
                            {
                                poligonoR.Add(new Point(xmin, ymin));
                            }
                            else if (!antD && !atualD && !proxD && poligonog[i].X < xmin && poligonog[i].Y > ymax)
                            {
                                poligonoR.Add(new Point(xmin, ymax));
                            }
                            else if (!antD && !atualD && !proxD && poligonog[i].X > xmax && poligonog[i].Y > ymax)
                            {
                                poligonoR.Add(new Point(xmax, ymax));
                            }
                            else if (!antD && !atualD && !proxD && poligonog[i].X > xmax && poligonog[i].Y < ymin)
                            {
                                poligonoR.Add(new Point(xmax, ymin));
                            }
                        }
                    }
                }
            }

            antD = (poligonog[poligonog.Length - 1].X >= xmin && poligonog[poligonog.Length - 1].X <= xmax && poligonog[poligonog.Length - 1].Y >= ymin && poligonog[poligonog.Length - 1].Y <= ymax);
            atualD = (poligonog[0].X >= xmin && poligonog[0].X <= xmax && poligonog[0].Y >= ymin && poligonog[0].Y <= ymax);

            if (!antD && atualD)
            {
                //calcular o vértice de intersecção de poligonog[i-1] com a viewport
                Point pInt = calculaInterseccao(poligonog[poligonog.Length - 1], poligonog[0], xmin, xmax, ymin, ymax);
                poligonoR.Add(pInt);/*recebe o valor da intersecção*/ //posR++;
                //poligonoR.Add(poligonog[i]); //posR++;
            }
            /*else if (antD && atualD)
            {
                poligonoR.Add(poligonog[0]); //posR++;
            }*/
            else if (antD & !atualD)
            {
                //calcular o vértice de intersecção de poligonog[i] com a viewport
                Point pInt = calculaInterseccao(poligonog[0], poligonog[poligonog.Length - 1], xmin, xmax, ymin, ymax);
                poligonoR.Add(pInt);
                //posR++;
            }
            return poligonoR.ToArray();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;

            if (!txtX1.Text.ToString().Equals("") && !txtY1.Text.ToString().Equals("") && !txtX2.Text.ToString().Equals("") && !txtY2.Text.ToString().Equals(""))
            {

                x1 = int.Parse(txtX1.Text.ToString());
                x2 = int.Parse(txtX2.Text.ToString());
                y1 = int.Parse(txtY1.Text.ToString());
                y2 = int.Parse(txtY2.Text.ToString());

                Graphics g = panelDesenhos.CreateGraphics();
                Color c1 = Color.Black;
                Color c2 = Color.White;
                Pen p = new Pen(c1);
                SolidBrush s = new SolidBrush(c2);
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);

                Retangulo r = new Retangulo(p, s, c1, c2);
                r.Desenhar(g, p1, p2);
                r.Preencher(g, p1, p2);

                viewport = new Point[2]
                {
                    p1, p2
                };

                //MessageBox.Show("P1: " + viewport[0].X + ", " + viewport[0].Y + " - P2: " + viewport[1].X + ", " + viewport[1].Y, "Aviso!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            panelDesenhos.Invalidate();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                x1v1.Enabled = true;
                y1v1.Enabled = true;
                x2v2.Enabled = true;
                y2v2.Enabled = true;
                x3v3.Enabled = true;
                y3v3.Enabled = true;
                x4v4.Enabled = false;
                y4v4.Enabled = false;
                x5v5.Enabled = false;
                y5v5.Enabled = false;
                x6v6.Enabled = false;
                y6v6.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                x1v1.Enabled = true;
                y1v1.Enabled = true;
                x2v2.Enabled = true;
                y2v2.Enabled = true;
                x3v3.Enabled = true;
                y3v3.Enabled = true;
                x4v4.Enabled = true;
                y4v4.Enabled = true;
                x5v5.Enabled = false;
                y5v5.Enabled = false;
                x6v6.Enabled = false;
                y6v6.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                x1v1.Enabled = true;
                y1v1.Enabled = true;
                x2v2.Enabled = true;
                y2v2.Enabled = true;
                x3v3.Enabled = true;
                y3v3.Enabled = true;
                x4v4.Enabled = true;
                y4v4.Enabled = true;
                x5v5.Enabled = true;
                y5v5.Enabled = true;
                x6v6.Enabled = false;
                y6v6.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                x1v1.Enabled = true;
                y1v1.Enabled = true;
                x2v2.Enabled = true;
                y2v2.Enabled = true;
                x3v3.Enabled = true;
                y3v3.Enabled = true;
                x4v4.Enabled = true;
                y4v4.Enabled = true;
                x5v5.Enabled = true;
                y5v5.Enabled = true;
                x6v6.Enabled = true;
                y6v6.Enabled = true;
            }
            else
            {
                x1v1.Enabled = false;
                y1v1.Enabled = false;
                x2v2.Enabled = false;
                y2v2.Enabled = false;
                x3v3.Enabled = false;
                y3v3.Enabled = false;
                x4v4.Enabled = false;
                y4v4.Enabled = false;
                x5v5.Enabled = false;
                y5v5.Enabled = false;
                x6v6.Enabled = false;
                y6v6.Enabled = false;
            }
        }

        private void btnDesenharPolígono_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int x1, x2, x3, y1, y2, y3;

                if (!x1v1.Text.ToString().Equals("") && !y1v1.Text.ToString().Equals("") && !x2v2.Text.ToString().Equals("") && !y2v2.Text.ToString().Equals("") && !x3v3.Text.ToString().Equals("") && !y3v3.Text.ToString().Equals(""))
                {

                    x1 = int.Parse(x1v1.Text.ToString());
                    x2 = int.Parse(x2v2.Text.ToString());
                    y1 = int.Parse(y1v1.Text.ToString());
                    y2 = int.Parse(y2v2.Text.ToString());
                    x3 = int.Parse(x3v3.Text.ToString());
                    y3 = int.Parse(y3v3.Text.ToString());

                    Graphics g = panelDesenhos.CreateGraphics();
                    Color c1 = Color.Black;
                    Color c2 = Color.Yellow;
                    Pen p = new Pen(c1);
                    SolidBrush s = new SolidBrush(c2);
                    Point p1 = new Point(x1, y1);
                    Point p2 = new Point(x2, y2);
                    Point p3 = new Point(x3, y3);
                    Point[] ps = { p1, p2, p3 };
                    Poligono po = new Poligono(p, s, c1, c2);
                    po.Desenhar(g, ps);
                    po.Preencher(g, ps);
                    poligonog = new Point[3] { p1, p2, p3 };
                    //MessageBox.Show("P1: " + poligonog[0].X + ", " + poligonog[0].Y + " - P2: " + poligonog[1].X + ", " + poligonog[1].Y + " - P3: " + poligonog[2].X + ", " + poligonog[2].Y, "Aviso!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                int x1, x2, x3, x4, y1, y2, y3, y4;

                if (!x1v1.Text.ToString().Equals("") && !y1v1.Text.ToString().Equals("") && !x2v2.Text.ToString().Equals("") && !y2v2.Text.ToString().Equals("") && !x3v3.Text.ToString().Equals("") && !y3v3.Text.ToString().Equals("") && !x4v4.Text.ToString().Equals("") && !y4v4.Text.ToString().Equals(""))
                {

                    x1 = int.Parse(x1v1.Text.ToString());
                    x2 = int.Parse(x2v2.Text.ToString());
                    y1 = int.Parse(y1v1.Text.ToString());
                    y2 = int.Parse(y2v2.Text.ToString());
                    x3 = int.Parse(x3v3.Text.ToString());
                    y3 = int.Parse(y3v3.Text.ToString());
                    x4 = int.Parse(x4v4.Text.ToString());
                    y4 = int.Parse(y4v4.Text.ToString());

                    Graphics g = panelDesenhos.CreateGraphics();
                    Color c1 = Color.Black;
                    Color c2 = Color.Yellow;
                    Pen p = new Pen(c1);
                    SolidBrush s = new SolidBrush(c2);
                    Point p1 = new Point(x1, y1);
                    Point p2 = new Point(x2, y2);
                    Point p3 = new Point(x3, y3);
                    Point p4 = new Point(x4, y4);
                    Point[] ps = { p1, p2, p3, p4 };
                    Poligono po = new Poligono(p, s, c1, c2);
                    po.Desenhar(g, ps);
                    po.Preencher(g, ps);
                    poligonog = new Point[4] { p1, p2, p3, p4 };
                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int x1, x2, x3, x4, x5, y1, y2, y3, y4, y5;

                if (!x1v1.Text.ToString().Equals("") && !y1v1.Text.ToString().Equals("") &&
                    !x2v2.Text.ToString().Equals("") && !y2v2.Text.ToString().Equals("") &&
                    !x3v3.Text.ToString().Equals("") && !y3v3.Text.ToString().Equals("") &&
                    !x4v4.Text.ToString().Equals("") && !y4v4.Text.ToString().Equals("") &&
                    !x5v5.Text.ToString().Equals("") && !y5v5.Text.ToString().Equals(""))
                {

                    x1 = int.Parse(x1v1.Text.ToString());
                    x2 = int.Parse(x2v2.Text.ToString());
                    y1 = int.Parse(y1v1.Text.ToString());
                    y2 = int.Parse(y2v2.Text.ToString());
                    x3 = int.Parse(x3v3.Text.ToString());
                    y3 = int.Parse(y3v3.Text.ToString());
                    x4 = int.Parse(x4v4.Text.ToString());
                    y4 = int.Parse(y4v4.Text.ToString());
                    x5 = int.Parse(x5v5.Text.ToString());
                    y5 = int.Parse(y5v5.Text.ToString());

                    Graphics g = panelDesenhos.CreateGraphics();
                    Color c1 = Color.Black;
                    Color c2 = Color.Yellow;
                    Pen p = new Pen(c1);
                    SolidBrush s = new SolidBrush(c2);
                    Point p1 = new Point(x1, y1);
                    Point p2 = new Point(x2, y2);
                    Point p3 = new Point(x3, y3);
                    Point p4 = new Point(x4, y4);
                    Point p5 = new Point(x5, y5);
                    Point[] ps = { p1, p2, p3, p4, p5 };
                    Poligono po = new Poligono(p, s, c1, c2);
                    po.Desenhar(g, ps);
                    po.Preencher(g, ps);
                    poligonog = new Point[5] { p1, p2, p3, p4, p5 };
                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                int x1, x2, x3, x4, x5, x6, y1, y2, y3, y4, y5, y6;

                if (!x1v1.Text.ToString().Equals("") && !y1v1.Text.ToString().Equals("") &&
                    !x2v2.Text.ToString().Equals("") && !y2v2.Text.ToString().Equals("") &&
                    !x3v3.Text.ToString().Equals("") && !y3v3.Text.ToString().Equals("") &&
                    !x4v4.Text.ToString().Equals("") && !y4v4.Text.ToString().Equals("") &&
                    !x5v5.Text.ToString().Equals("") && !y5v5.Text.ToString().Equals("") &&
                    !x6v6.Text.ToString().Equals("") && !y6v6.Text.ToString().Equals(""))
                {

                    x1 = int.Parse(x1v1.Text.ToString());
                    x2 = int.Parse(x2v2.Text.ToString());
                    y1 = int.Parse(y1v1.Text.ToString());
                    y2 = int.Parse(y2v2.Text.ToString());
                    x3 = int.Parse(x3v3.Text.ToString());
                    y3 = int.Parse(y3v3.Text.ToString());
                    x4 = int.Parse(x4v4.Text.ToString());
                    y4 = int.Parse(y4v4.Text.ToString());
                    x5 = int.Parse(x5v5.Text.ToString());
                    y5 = int.Parse(y5v5.Text.ToString());
                    x6 = int.Parse(x6v6.Text.ToString());
                    y6 = int.Parse(y6v6.Text.ToString());

                    Graphics g = panelDesenhos.CreateGraphics();
                    Color c1 = Color.Black;
                    Color c2 = Color.Yellow;
                    Pen p = new Pen(c1);
                    SolidBrush s = new SolidBrush(c2);
                    Point p1 = new Point(x1, y1);
                    Point p2 = new Point(x2, y2);
                    Point p3 = new Point(x3, y3);
                    Point p4 = new Point(x4, y4);
                    Point p5 = new Point(x5, y5);
                    Point p6 = new Point(x6, y6);
                    Point[] ps = { p1, p2, p3, p4, p5, p6 };
                    Poligono po = new Poligono(p, s, c1, c2);
                    po.Desenhar(g, ps);
                    po.Preencher(g, ps);
                    poligonog = new Point[6] { p1, p2, p3, p4, p5, p6 };
                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimparVertices_Click(object sender, EventArgs e)
        {
            x1v1.Text = "";
            y1v1.Text = "";
            x2v2.Text = "";
            y2v2.Text = "";
            x3v3.Text = "";
            y3v3.Text = "";
            x4v4.Text = "";
            y4v4.Text = "";
            x5v5.Text = "";
            y5v5.Text = "";
            x6v6.Text = "";
            y6v6.Text = "";
        }

        private void btnRecortar_Click_1(object sender, EventArgs e)
        {
            panelDesenhos.Invalidate();
            Point[] recortado = cohenHodgman();
            for (int i = 0; i < recortado.Length; i++)
            {
                MessageBox.Show("Ponto[" + i + "]: " + recortado[i].X + ", " + recortado[i].Y, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Graphics g = panelDesenhos.CreateGraphics();
            Color c1 = Color.Black;
            Color c2 = Color.White;
            Pen p = new Pen(c1);
            SolidBrush s = new SolidBrush(c2);
            Retangulo r = new Retangulo(p, s, c1, c2);
            r.Desenhar(g, viewport[0], viewport[1]);
            r.Preencher(g, viewport[0], viewport[1]);
            Color c3 = Color.Red;
            Color c4 = Color.Yellow;
            Pen p1 = new Pen(c3, 2);
            SolidBrush s1 = new SolidBrush(c4);
            Poligono po = new Poligono(p1, s1, c3, c4);
            po.Desenhar(g, recortado);
            po.Preencher(g, recortado);
        }

        private void txtY2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}