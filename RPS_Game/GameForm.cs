using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPS_Game
{
    public partial class GameForm : Form
    {
        private GameController controller;

        public GameForm(GameController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        public void RunGame()
        {

        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
