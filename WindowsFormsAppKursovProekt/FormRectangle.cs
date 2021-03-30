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
    public partial class FormRectangle : System.Windows.Forms.Form
    {
        public static float passingWidth;
        public static float passingHeight;
        public static Color passingColorRectangle;
        public FormRectangle()
        {
            InitializeComponent();

        }

        private void btnAddRecOnScene_Click(object sender, EventArgs e)
        {
            
            try
            {
                passingWidth = float.Parse(textBoxWidth.Text);
                passingHeight = float.Parse(textBoxHeight.Text);
            }
            catch
            {
                MessageBox.Show("Моля, въведете валидни стойности!");
                return;
            }
            if (passingWidth <= 0 || passingHeight<=0)
            {
                MessageBox.Show("Моля, въведете положителни стойности!");
                return;

            }
            this.Hide();
        }

        private void btnColorRectangle_Click(object sender, EventArgs e)
        {
            colorDialogRectangle.AllowFullOpen = true;
            if (colorDialogRectangle.ShowDialog() == DialogResult.OK)
            {
                passingColorRectangle = colorDialogRectangle.Color;
            }
        }
    }
}

