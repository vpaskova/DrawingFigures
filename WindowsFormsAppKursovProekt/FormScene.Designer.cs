namespace WindowsFormsAppKursovProekt
{
    partial class FormScene
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
            this.btnAddNewShape = new System.Windows.Forms.Button();
            this.btnRemoveFromScene = new System.Windows.Forms.Button();
            this.textBoxSurface = new System.Windows.Forms.TextBox();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewShape
            // 
            this.btnAddNewShape.Location = new System.Drawing.Point(97, 415);
            this.btnAddNewShape.Name = "btnAddNewShape";
            this.btnAddNewShape.Size = new System.Drawing.Size(84, 45);
            this.btnAddNewShape.TabIndex = 0;
            this.btnAddNewShape.Text = "Добави нова фигура";
            this.btnAddNewShape.UseVisualStyleBackColor = true;
            this.btnAddNewShape.Click += new System.EventHandler(this.btnAddNewShape_Click);
            // 
            // btnRemoveFromScene
            // 
            this.btnRemoveFromScene.Location = new System.Drawing.Point(97, 344);
            this.btnRemoveFromScene.Name = "btnRemoveFromScene";
            this.btnRemoveFromScene.Size = new System.Drawing.Size(78, 45);
            this.btnRemoveFromScene.TabIndex = 1;
            this.btnRemoveFromScene.Text = "Изтрий фигурата";
            this.btnRemoveFromScene.UseVisualStyleBackColor = true;
            this.btnRemoveFromScene.Click += new System.EventHandler(this.btnRemoveFromScene_Click);
            // 
            // textBoxSurface
            // 
            this.textBoxSurface.Location = new System.Drawing.Point(97, 11);
            this.textBoxSurface.Name = "textBoxSurface";
            this.textBoxSurface.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurface.TabIndex = 2;
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Location = new System.Drawing.Point(97, 56);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxPerimeter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Площ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Периметър:";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(97, 259);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(78, 45);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "Запази ";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnInstruction);
            this.panel1.Controls.Add(this.btnSaveFile);
            this.panel1.Controls.Add(this.btnRemoveFromScene);
            this.panel1.Controls.Add(this.textBoxSurface);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPerimeter);
            this.panel1.Controls.Add(this.btnAddNewShape);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(883, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 474);
            this.panel1.TabIndex = 7;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(97, 212);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(78, 41);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "Зареди файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnInstruction
            // 
            this.btnInstruction.Location = new System.Drawing.Point(97, 117);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(78, 45);
            this.btnInstruction.TabIndex = 7;
            this.btnInstruction.Text = "Инструкции";
            this.btnInstruction.UseVisualStyleBackColor = true;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1085, 473);
            this.Controls.Add(this.panel1);
            this.Name = "FormScene";
            this.Text = "Сцена";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewShape;
        private System.Windows.Forms.Button btnRemoveFromScene;
        private System.Windows.Forms.TextBox textBoxSurface;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

