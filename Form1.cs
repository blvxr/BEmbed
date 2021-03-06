using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord.Rest;
using Discord;

namespace BotGUI
{
    public partial class Form1 : Form
    {

        private PageOne pageOne = new PageOne();
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Add(pageOne);
        }

        private void discord()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
