namespace AngleConverter
{
    partial class frmDegreeConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRevolutions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDegrees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadians = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMilliradians = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArcminutes = new System.Windows.Forms.TextBox();
            this.txtGradians = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Revolutions:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRevolutions
            // 
            this.txtRevolutions.Location = new System.Drawing.Point(150, 19);
            this.txtRevolutions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRevolutions.Name = "txtRevolutions";
            this.txtRevolutions.Size = new System.Drawing.Size(114, 27);
            this.txtRevolutions.TabIndex = 1;
            this.txtRevolutions.TextChanged += new System.EventHandler(this.txtRevolutions_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Degrees:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDegrees
            // 
            this.txtDegrees.Location = new System.Drawing.Point(150, 57);
            this.txtDegrees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDegrees.Name = "txtDegrees";
            this.txtDegrees.ReadOnly = true;
            this.txtDegrees.Size = new System.Drawing.Size(114, 27);
            this.txtDegrees.TabIndex = 3;
            this.txtDegrees.TabStop = false;
            this.txtDegrees.TextChanged += new System.EventHandler(this.txtDegrees_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Radians:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRadians
            // 
            this.txtRadians.Location = new System.Drawing.Point(150, 96);
            this.txtRadians.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRadians.Name = "txtRadians";
            this.txtRadians.ReadOnly = true;
            this.txtRadians.Size = new System.Drawing.Size(114, 27);
            this.txtRadians.TabIndex = 5;
            this.txtRadians.TabStop = false;
            this.txtRadians.TextChanged += new System.EventHandler(this.txtRadians_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Milliradians:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMilliradians
            // 
            this.txtMilliradians.Location = new System.Drawing.Point(150, 135);
            this.txtMilliradians.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMilliradians.Name = "txtMilliradians";
            this.txtMilliradians.ReadOnly = true;
            this.txtMilliradians.Size = new System.Drawing.Size(114, 27);
            this.txtMilliradians.TabIndex = 7;
            this.txtMilliradians.TabStop = false;
            this.txtMilliradians.TextChanged += new System.EventHandler(this.txtMilliradians_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(76, 262);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(86, 31);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(178, 262);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gradians:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Arcminutes:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtArcminutes
            // 
            this.txtArcminutes.Location = new System.Drawing.Point(150, 215);
            this.txtArcminutes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArcminutes.Name = "txtArcminutes";
            this.txtArcminutes.ReadOnly = true;
            this.txtArcminutes.Size = new System.Drawing.Size(114, 27);
            this.txtArcminutes.TabIndex = 11;
            this.txtArcminutes.TabStop = false;
            this.txtArcminutes.TextChanged += new System.EventHandler(this.txtArcminutes_TextChanged);
            // 
            // txtGradians
            // 
            this.txtGradians.Location = new System.Drawing.Point(150, 175);
            this.txtGradians.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGradians.Name = "txtGradians";
            this.txtGradians.ReadOnly = true;
            this.txtGradians.Size = new System.Drawing.Size(114, 27);
            this.txtGradians.TabIndex = 12;
            this.txtGradians.TabStop = false;
            this.txtGradians.TextChanged += new System.EventHandler(this.txtGradians_TextChanged);
            // 
            // frmDegreeConverter
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(290, 327);
            this.Controls.Add(this.txtGradians);
            this.Controls.Add(this.txtArcminutes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMilliradians);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRadians);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDegrees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRevolutions);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDegreeConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angle Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRevolutions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDegrees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadians;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMilliradians;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArcminutes;
        private System.Windows.Forms.TextBox txtGradians;
    }
}

