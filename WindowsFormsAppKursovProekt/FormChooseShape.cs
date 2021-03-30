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
    public partial class FormChooseShape : System.Windows.Forms.Form
    {
        public FormChooseShape()
        {
            InitializeComponent();
        }
      
        private void btnSizes_Click(object sender, EventArgs e)
        {
            if (comboBoxShapes.SelectedIndex >= 0)
            {
                string text = comboBoxShapes.SelectedItem.ToString();

                if (text == "Триъгълник")
                {
                    new FormTriangle().Show();
                    this.Hide();
                }
                else if (text == "Квадрат")
                {
                    new FormSquare().Show();
                    this.Hide();
                }
                else if (text == "Правоъгълник")
                {
                    new FormRectangle().Show();
                    this.Hide();
                }
                else if (text == "Кръг")
                {
                    new FormCircle().Show();
                    this.Hide();
                }
            }
            else 
            {
                MessageBox.Show("Моля, изберете фигура!");
            }

        }


    }
}

