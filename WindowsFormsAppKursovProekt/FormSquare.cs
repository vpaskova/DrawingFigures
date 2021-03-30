using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKursovProekt
{
    public partial class FormSquare : Form
    {
        public static float passingSize;
        public static Color passingColorSquare;
        public FormSquare()
        {
            InitializeComponent();
        }

        private void btnAddSqOnScene_Click(object sender, EventArgs e)
        {
            try
            {
                passingSize = float.Parse(textBoxSize.Text);
            }
            catch 
            {
                MessageBox.Show("Моля, въведете валидни стойности!");
                return;
            }     
            if (passingSize<=0)
            {
                MessageBox.Show("Моля, въведете положителни стойности!");
                return;
            }
            this.Hide();
        }
    

        private void btnColorSquare_Click(object sender, EventArgs e)
        {
            colorDialogSquare.AllowFullOpen = true;
            if (colorDialogSquare.ShowDialog() == DialogResult.OK)
            {
                passingColorSquare = colorDialogSquare.Color;
            }
        }
    }
}
