namespace WindowsFormsAppKursovProekt
{
    partial class FormTriangle
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonAddTrOnScene = new System.Windows.Forms.Button();
            this.btnColorTriangle = new System.Windows.Forms.Button();
            this.colorDialogTriangle = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "страната a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "страната b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "страната c =";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(89, 33);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(75, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(89, 77);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(75, 20);
            this.textBoxB.TabIndex = 4;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(89, 122);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(75, 20);
            this.textBoxC.TabIndex = 5;
            // 
            // buttonAddTrOnScene
            // 
            this.buttonAddTrOnScene.Location = new System.Drawing.Point(169, 212);
            this.buttonAddTrOnScene.Name = "buttonAddTrOnScene";
            this.buttonAddTrOnScene.Size = new System.Drawing.Size(110, 37);
            this.buttonAddTrOnScene.TabIndex = 6;
            this.buttonAddTrOnScene.Text = "Добави фигурата на сцената";
            this.buttonAddTrOnScene.UseVisualStyleBackColor = true;
            this.buttonAddTrOnScene.Click += new System.EventHandler(this.buttonAddTrOnScene_Click);
            // 
            // btnColorTriangle
            // 
            this.btnColorTriangle.Location = new System.Drawing.Point(89, 166);
            this.btnColorTriangle.Name = "btnColorTriangle";
            this.btnColorTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnColorTriangle.TabIndex = 7;
            this.btnColorTriangle.Text = "Цвят";
            this.btnColorTriangle.UseVisualStyleBackColor = true;
            this.btnColorTriangle.Click += new System.EventHandler(this.btnColorTriangle_Click);
            // 
            // FormTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 271);
            this.Controls.Add(this.btnColorTriangle);
            this.Controls.Add(this.buttonAddTrOnScene);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTriangle";
            this.Text = "Триъгълник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button buttonAddTrOnScene;
        private System.Windows.Forms.Button btnColorTriangle;
        private System.Windows.Forms.ColorDialog colorDialogTriangle;
    }
}