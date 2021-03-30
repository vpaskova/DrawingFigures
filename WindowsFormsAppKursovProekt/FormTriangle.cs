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
    public partial class FormTriangle : System.Windows.Forms.Form
    {
        public static float passingA;
        public static float passingB;
        public static float passingC;
        public static Color passingColorTriangle;
        public FormTriangle()
        {
            InitializeComponent();
        }

        private void buttonAddTrOnScene_Click(object sender, EventArgs e)
        {             
            try
            {             
                passingA = float.Parse(textBoxA.Text);
                passingB = float.Parse(textBoxB.Text);
                passingC = float.Parse(textBoxC.Text);
            }
            catch
            {
                MessageBox.Show("Моля, въведете валидни стойности!");
                return;
            }
            if (passingA+passingB <= passingC || passingB+passingC <= passingA || passingA+passingC <= passingB)
            {
                MessageBox.Show("Не съществува такъв триъгилник! \n" +
                        "Сборът от кои да е два страни на триъгълника трябва да е по-голям от дължината на третата!");
                return;
            }
            if (passingA <= 0 || passingB<=0 || passingC<=0)
            {
                MessageBox.Show("Моля, въведете положителни стойности!");
                return;

            }
            this.Hide();

        }

        private void btnColorTriangle_Click(object sender, EventArgs e)
        {
            colorDialogTriangle.AllowFullOpen = true;
            if (colorDialogTriangle.ShowDialog() == DialogResult.OK)
            {
                passingColorTriangle = colorDialogTriangle.Color;
            }
        }
    }
}
