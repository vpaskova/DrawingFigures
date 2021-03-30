namespace WindowsFormsAppKursovProekt
{
    partial class FormCircle
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
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.btnAddCirOnScene = new System.Windows.Forms.Button();
            this.btnColorCircle = new System.Windows.Forms.Button();
            this.colorDialogCircle = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "радиус  =";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(72, 36);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(127, 20);
            this.textBoxRadius.TabIndex = 1;
            // 
            // btnAddCirOnScene
            // 
            this.btnAddCirOnScene.Location = new System.Drawing.Point(169, 181);
            this.btnAddCirOnScene.Name = "btnAddCirOnScene";
            this.btnAddCirOnScene.Size = new System.Drawing.Size(104, 43);
            this.btnAddCirOnScene.TabIndex = 2;
            this.btnAddCirOnScene.Text = "Добави фигурата на сцената";
            this.btnAddCirOnScene.UseVisualStyleBackColor = true;
            this.btnAddCirOnScene.Click += new System.EventHandler(this.btnAddCirOnScene_Click);
            // 
            // btnColorCircle
            // 
            this.btnColorCircle.Location = new System.Drawing.Point(72, 96);
            this.btnColorCircle.Name = "btnColorCircle";
            this.btnColorCircle.Size = new System.Drawing.Size(75, 23);
            this.btnColorCircle.TabIndex = 8;
            this.btnColorCircle.Text = "Цвят";
            this.btnColorCircle.UseVisualStyleBackColor = true;
            this.btnColorCircle.Click += new System.EventHandler(this.btnColorCircle_Click);
            // 
            // FormCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 248);
            this.Controls.Add(this.btnColorCircle);
            this.Controls.Add(this.btnAddCirOnScene);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.label1);
            this.Name = "FormCircle";
            this.Text = "Кръг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Button btnAddCirOnScene;
        private System.Windows.Forms.Button btnColorCircle;
        private System.Windows.Forms.ColorDialog colorDialogCircle;
    }
}