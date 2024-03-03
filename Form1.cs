using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ejercicio_trackback
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int newSize = trackBar1.Value;
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, Math.Max(1, newSize));
            label1.Text = "Tamaño de fuente: " + newSize.ToString();
        }
    }

    }

