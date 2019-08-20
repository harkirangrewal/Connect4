using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method "new game" makes everything equal to -1


        /*private int Search_Array()
        int rows;
        {
          for (rows = 6; rows < 7; rows= rows - 1)
        } 
        return 
        */

            /* for (row =5; row <=5; r--)
            {
                  if(ConnectBoard[col,row] == -1)
                  {
                  return row;
                  }
                else
            }
        


        int[,] ConnectBoard = new int[7, 6];
        // -1 empty
        // 0 Yellow
        // 1 Red

        private void pb_grid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen black_pen = new Pen(Color.Black, 5);

            g.DrawLine(black_pen, 0, 0, 700, 0);
            g.DrawLine(black_pen, 0, 0, 0, 600);
            g.DrawLine(black_pen, 0, 600, 700, 600);
            g.DrawLine(black_pen, 700, 600, 700, 0);
            // The outline of the connect four grid

            g.DrawLine(black_pen, 0, 100, 700, 100);
            g.DrawLine(black_pen, 0, 200, 700, 200);
            g.DrawLine(black_pen, 0, 300, 700, 300);
            g.DrawLine(black_pen, 0, 400, 700, 400);
            g.DrawLine(black_pen, 0, 500, 700, 500);
            g.DrawLine(black_pen, 0, 600, 700, 600);
            // The outline of the inner grid 

            g.DrawLine(black_pen, 100, 0, 100, 600);
            g.DrawLine(black_pen, 200, 0, 200, 600);
            g.DrawLine(black_pen, 300, 0, 300, 600);
            g.DrawLine(black_pen, 400, 0, 400, 600);
            g.DrawLine(black_pen, 500, 0, 500, 600);
            g.DrawLine(black_pen, 600, 0, 600, 600);
            g.DrawLine(black_pen, 700, 0, 700, 600);
            // The outline of the veritcal lines

        }
    }
}
