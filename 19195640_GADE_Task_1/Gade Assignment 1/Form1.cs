﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gade_Assignment_1
{
    public partial class BattleForm : Form
    {
        public BattleForm()
        {
            InitializeComponent();
        }

        GameEngine gameengine = new GameEngine();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MapTextBox.Text = gameengine.Updatedisplay();
            lblRound.Text = gameengine.roundscompleted.ToString();
            gameengine.startround();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gametimer.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            gametimer.Enabled = false;
        }
    }
}
