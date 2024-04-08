namespace GeneradorDeContraseñas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtGenerate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGenerate = new Button();
            chkUper = new CheckBox();
            chkLower = new CheckBox();
            chkNum = new CheckBox();
            chkSpecial = new CheckBox();
            txtLongitud = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 23);
            label1.Name = "label1";
            label1.Size = new Size(590, 47);
            label1.TabIndex = 0;
            label1.Text = "GENERADOR DE CONTRASEÑAS";
            // 
            // txtGenerate
            // 
            txtGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGenerate.Location = new Point(177, 73);
            txtGenerate.Multiline = true;
            txtGenerate.Name = "txtGenerate";
            txtGenerate.Size = new Size(451, 97);
            txtGenerate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 194);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Longitud";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 237);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 3;
            label3.Text = "Incluir mayúsculas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 266);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 4;
            label4.Text = "Incluir minúsculas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 303);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 5;
            label5.Text = "Incluir números";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 335);
            label6.Name = "label6";
            label6.Size = new Size(185, 20);
            label6.TabIndex = 6;
            label6.Text = "Incluir simbolos especiales";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Goldenrod;
            btnGenerate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerate.Location = new Point(303, 382);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(184, 42);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generar contraseña";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // chkUper
            // 
            chkUper.AutoSize = true;
            chkUper.Location = new Point(447, 240);
            chkUper.Name = "chkUper";
            chkUper.Size = new Size(18, 17);
            chkUper.TabIndex = 9;
            chkUper.UseVisualStyleBackColor = true;
            // 
            // chkLower
            // 
            chkLower.AutoSize = true;
            chkLower.Location = new Point(447, 269);
            chkLower.Name = "chkLower";
            chkLower.Size = new Size(18, 17);
            chkLower.TabIndex = 10;
            chkLower.UseVisualStyleBackColor = true;
            // 
            // chkNum
            // 
            chkNum.AutoSize = true;
            chkNum.Location = new Point(447, 303);
            chkNum.Name = "chkNum";
            chkNum.Size = new Size(18, 17);
            chkNum.TabIndex = 11;
            chkNum.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            chkSpecial.AutoSize = true;
            chkSpecial.Location = new Point(447, 335);
            chkSpecial.Name = "chkSpecial";
            chkSpecial.Size = new Size(18, 17);
            chkSpecial.TabIndex = 12;
            chkSpecial.UseVisualStyleBackColor = true;
            // 
            // txtLongitud
            // 
            txtLongitud.AccessibleName = "";
            txtLongitud.Location = new Point(303, 187);
            txtLongitud.MaxLength = 2;
            txtLongitud.Name = "txtLongitud";
            txtLongitud.PlaceholderText = "ej.20(max 99)";
            txtLongitud.Size = new Size(107, 27);
            txtLongitud.TabIndex = 13;
            txtLongitud.KeyPress += txtLongitud_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(txtLongitud);
            Controls.Add(chkSpecial);
            Controls.Add(chkNum);
            Controls.Add(chkLower);
            Controls.Add(chkUper);
            Controls.Add(btnGenerate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtGenerate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PSSG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGenerate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGenerate;
        private CheckBox chkUper;
        private CheckBox chkLower;
        private CheckBox chkNum;
        private CheckBox chkSpecial;
        private TextBox txtLongitud;
    }
}
