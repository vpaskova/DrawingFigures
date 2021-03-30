namespace WindowsFormsAppKursovProekt
{
    partial class FormChooseShape
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.btnSizes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изберете желаната фигура";
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.FormattingEnabled = true;
            this.comboBoxShapes.Items.AddRange(new object[] {
            "Триъгълник",
            "Правоъгълник",
            "Квадрат",
            "Кръг"});
            this.comboBoxShapes.Location = new System.Drawing.Point(184, 39);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(287, 21);
            this.comboBoxShapes.TabIndex = 2;
            // 
            // btnSizes
            // 
            this.btnSizes.Location = new System.Drawing.Point(371, 97);
            this.btnSizes.Name = "btnSizes";
            this.btnSizes.Size = new System.Drawing.Size(113, 23);
            this.btnSizes.TabIndex = 7;
            this.btnSizes.Text = "OK";
            this.btnSizes.UseVisualStyleBackColor = true;
            this.btnSizes.Click += new System.EventHandler(this.btnSizes_Click);
            // 
            // FormChooseShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 140);
            this.Controls.Add(this.btnSizes);
            this.Controls.Add(this.comboBoxShapes);
            this.Controls.Add(this.label1);
            this.Name = "FormChooseShape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxShapes;
        private System.Windows.Forms.Button btnSizes;
    }
}