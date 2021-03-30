namespace WindowsFormsAppKursovProekt
{
    partial class FormSquare
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
            this.btnAddSqOnScene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.btnColorSquare = new System.Windows.Forms.Button();
            this.colorDialogSquare = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnAddSqOnScene
            // 
            this.btnAddSqOnScene.Location = new System.Drawing.Point(148, 186);
            this.btnAddSqOnScene.Name = "btnAddSqOnScene";
            this.btnAddSqOnScene.Size = new System.Drawing.Size(107, 35);
            this.btnAddSqOnScene.TabIndex = 0;
            this.btnAddSqOnScene.Text = "Добави фигурата на сцената";
            this.btnAddSqOnScene.UseVisualStyleBackColor = true;
            this.btnAddSqOnScene.Click += new System.EventHandler(this.btnAddSqOnScene_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "страната =";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(80, 40);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize.TabIndex = 2;
            // 
            // btnColorSquare
            // 
            this.btnColorSquare.Location = new System.Drawing.Point(80, 93);
            this.btnColorSquare.Name = "btnColorSquare";
            this.btnColorSquare.Size = new System.Drawing.Size(75, 23);
            this.btnColorSquare.TabIndex = 8;
            this.btnColorSquare.Text = "Цвят";
            this.btnColorSquare.UseVisualStyleBackColor = true;
            this.btnColorSquare.Click += new System.EventHandler(this.btnColorSquare_Click);
            // 
            // FormSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.btnColorSquare);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSqOnScene);
            this.Name = "FormSquare";
            this.Text = "Квадрат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSqOnScene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button btnColorSquare;
        private System.Windows.Forms.ColorDialog colorDialogSquare;
    }
}