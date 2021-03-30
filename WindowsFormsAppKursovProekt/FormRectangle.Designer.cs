namespace WindowsFormsAppKursovProekt
{
    partial class FormRectangle
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.btnAddRecOnScene = new System.Windows.Forms.Button();
            this.btnColorRectangle = new System.Windows.Forms.Button();
            this.colorDialogRectangle = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "широчина = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "височина = ";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(103, 25);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(87, 20);
            this.textBoxWidth.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(103, 61);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(87, 20);
            this.textBoxHeight.TabIndex = 3;
            // 
            // btnAddRecOnScene
            // 
            this.btnAddRecOnScene.Location = new System.Drawing.Point(172, 175);
            this.btnAddRecOnScene.Name = "btnAddRecOnScene";
            this.btnAddRecOnScene.Size = new System.Drawing.Size(104, 34);
            this.btnAddRecOnScene.TabIndex = 4;
            this.btnAddRecOnScene.Text = "Добави фигурата на сцената";
            this.btnAddRecOnScene.UseVisualStyleBackColor = true;
            this.btnAddRecOnScene.Click += new System.EventHandler(this.btnAddRecOnScene_Click);
            // 
            // btnColorRectangle
            // 
            this.btnColorRectangle.Location = new System.Drawing.Point(103, 109);
            this.btnColorRectangle.Name = "btnColorRectangle";
            this.btnColorRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnColorRectangle.TabIndex = 8;
            this.btnColorRectangle.Text = "Цвят";
            this.btnColorRectangle.UseVisualStyleBackColor = true;
            this.btnColorRectangle.Click += new System.EventHandler(this.btnColorRectangle_Click);
            // 
            // FormRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 234);
            this.Controls.Add(this.btnColorRectangle);
            this.Controls.Add(this.btnAddRecOnScene);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRectangle";
            this.Text = "Правоъгълник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button btnAddRecOnScene;
        private System.Windows.Forms.Button btnColorRectangle;
        private System.Windows.Forms.ColorDialog colorDialogRectangle;
    }
}