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
    public partial class FormCircle : Form
    {
        public static float passingRadius;
        public static Color passingColorCircle;
        public FormCircle()
        {
            InitializeComponent();
        }

        private void btnAddCirOnScene_Click(object sender, EventArgs e)
        {

            try
            {
                passingRadius = float.Parse(textBoxRadius.Text);               
            }
            catch
            {
                MessageBox.Show("Моля, въведете валидни стойности!");
                return;
            }
            if (passingRadius <= 0)
            {
                MessageBox.Show("Моля, въведете положителни стойности!");
                return;
            }
            this.Hide();
        }

        private void btnColorCircle_Click(object sender, EventArgs e)
        {
            colorDialogCircle.AllowFullOpen = true;
            if (colorDialogCircle.ShowDialog() == DialogResult.OK)
            {
                passingColorCircle = colorDialogCircle.Color;
            }
        }
    }
}
