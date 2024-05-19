using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Checkerboard
{
    public partial class Form1 : Form
    {
        private const int boardSize = 8;  // 8x8 board
        private const int tileSize = 50; // Size of each tile in pixels
        public Form1()
        {
            InitializeComponent();
            this.Text = "Demo-Checkboard";
            this.Width = boardSize * tileSize + 30 * 2;
            this.Height = boardSize * tileSize + 40 * 2;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeBoard();
            AddLabels();
        }


        private void InitializeBoard()
        {
            // Create a simple 8 x 8 board of buttons
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Button tile = new Button();
                    tile.Width = tileSize;
                    tile.Height = tileSize;
                    tile.Left = col * tileSize + 30;
                    tile.Top = row * tileSize + 30;
                    tile.BackColor = (row + col) % 2 == 0 ? Color.Beige : Color.Black;
                    this.Controls.Add(tile);
                }
            }
        }

        private void AddLabels()
        {
            for (int col = 0; col < boardSize; col++)
            {
                Label label = new Label();
                label.Text = ((char)('A' + col)).ToString();
                label.Width = tileSize;
                label.Height = 20;
                label.Left = col * tileSize + 30;
                label.Top = 10; // Above the board;
                label.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add((label));
            }

            for (int row = 0; row < boardSize; row++)
            {
                Label label = new Label();
                label.Text = (boardSize - row).ToString();
                label.Width = 20;
                label.Height = tileSize;
                label.Left = 10;
                label.Top = row * tileSize + 30;
                label.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add((label));
            }

        }
    }
}
