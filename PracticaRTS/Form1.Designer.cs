namespace PracticaRTS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPlano = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnR = new System.Windows.Forms.Button();
            this.btnGenR = new System.Windows.Forms.Button();
            this.txtAngR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrasT = new System.Windows.Forms.Button();
            this.btnGenT = new System.Windows.Forms.Button();
            this.txtTPY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPTX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSy1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSx1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSy2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSx2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSx = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnS = new System.Windows.Forms.Button();
            this.btnGenS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlano)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPlano);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plano";
            // 
            // pbPlano
            // 
            this.pbPlano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlano.Location = new System.Drawing.Point(3, 16);
            this.pbPlano.Name = "pbPlano";
            this.pbPlano.Size = new System.Drawing.Size(560, 471);
            this.pbPlano.TabIndex = 0;
            this.pbPlano.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(566, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 490);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnS);
            this.groupBox5.Controls.Add(this.btnGenS);
            this.groupBox5.Controls.Add(this.txtSy);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtSx);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtSy2);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtSx2);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtSy1);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtSx1);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 286);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 201);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Escala";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnR);
            this.groupBox4.Controls.Add(this.btnGenR);
            this.groupBox4.Controls.Add(this.txtAngR);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtRy);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtRx);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 139);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rotación";
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(10, 105);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(213, 23);
            this.btnR.TabIndex = 9;
            this.btnR.Text = "Rotar punto";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnGenR
            // 
            this.btnGenR.Location = new System.Drawing.Point(10, 76);
            this.btnGenR.Name = "btnGenR";
            this.btnGenR.Size = new System.Drawing.Size(213, 23);
            this.btnGenR.TabIndex = 8;
            this.btnGenR.Text = "Generar punto";
            this.btnGenR.UseVisualStyleBackColor = true;
            this.btnGenR.Click += new System.EventHandler(this.btnGenR_Click);
            // 
            // txtAngR
            // 
            this.txtAngR.Location = new System.Drawing.Point(44, 50);
            this.txtAngR.Name = "txtAngR";
            this.txtAngR.Size = new System.Drawing.Size(175, 20);
            this.txtAngR.TabIndex = 7;
            this.txtAngR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ang.:";
            // 
            // txtRy
            // 
            this.txtRy.Location = new System.Drawing.Point(140, 24);
            this.txtRy.Name = "txtRy";
            this.txtRy.Size = new System.Drawing.Size(79, 20);
            this.txtRy.TabIndex = 5;
            this.txtRy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Y:";
            // 
            // txtRx
            // 
            this.txtRx.Location = new System.Drawing.Point(44, 24);
            this.txtRx.Name = "txtRx";
            this.txtRx.Size = new System.Drawing.Size(67, 20);
            this.txtRx.TabIndex = 3;
            this.txtRx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTy);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTx);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnTrasT);
            this.groupBox3.Controls.Add(this.btnGenT);
            this.groupBox3.Controls.Add(this.txtTPY);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPTX);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 131);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Traslación";
            // 
            // txtTy
            // 
            this.txtTy.Location = new System.Drawing.Point(145, 43);
            this.txtTy.Name = "txtTy";
            this.txtTy.Size = new System.Drawing.Size(74, 20);
            this.txtTy.TabIndex = 9;
            this.txtTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ty:";
            // 
            // txtTx
            // 
            this.txtTx.Location = new System.Drawing.Point(145, 17);
            this.txtTx.Name = "txtTx";
            this.txtTx.Size = new System.Drawing.Size(74, 20);
            this.txtTx.TabIndex = 7;
            this.txtTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tx:";
            // 
            // btnTrasT
            // 
            this.btnTrasT.Location = new System.Drawing.Point(6, 98);
            this.btnTrasT.Name = "btnTrasT";
            this.btnTrasT.Size = new System.Drawing.Size(213, 23);
            this.btnTrasT.TabIndex = 5;
            this.btnTrasT.Text = "Trasladar punto";
            this.btnTrasT.UseVisualStyleBackColor = true;
            this.btnTrasT.Click += new System.EventHandler(this.btnTrasT_Click);
            // 
            // btnGenT
            // 
            this.btnGenT.Location = new System.Drawing.Point(6, 69);
            this.btnGenT.Name = "btnGenT";
            this.btnGenT.Size = new System.Drawing.Size(213, 23);
            this.btnGenT.TabIndex = 4;
            this.btnGenT.Text = "Generar punto";
            this.btnGenT.UseVisualStyleBackColor = true;
            this.btnGenT.Click += new System.EventHandler(this.btnGenT_Click);
            // 
            // txtTPY
            // 
            this.txtTPY.Location = new System.Drawing.Point(30, 43);
            this.txtTPY.Name = "txtTPY";
            this.txtTPY.Size = new System.Drawing.Size(81, 20);
            this.txtTPY.TabIndex = 3;
            this.txtTPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // txtPTX
            // 
            this.txtPTX.Location = new System.Drawing.Point(30, 17);
            this.txtPTX.Name = "txtPTX";
            this.txtPTX.Size = new System.Drawing.Size(81, 20);
            this.txtPTX.TabIndex = 1;
            this.txtPTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // txtSy1
            // 
            this.txtSy1.Location = new System.Drawing.Point(146, 19);
            this.txtSy1.Name = "txtSy1";
            this.txtSy1.Size = new System.Drawing.Size(73, 20);
            this.txtSy1.TabIndex = 9;
            this.txtSy1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y1:";
            // 
            // txtSx1
            // 
            this.txtSx1.Location = new System.Drawing.Point(44, 19);
            this.txtSx1.Name = "txtSx1";
            this.txtSx1.Size = new System.Drawing.Size(67, 20);
            this.txtSx1.TabIndex = 7;
            this.txtSx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "X1:";
            // 
            // txtSy2
            // 
            this.txtSy2.Location = new System.Drawing.Point(145, 45);
            this.txtSy2.Name = "txtSy2";
            this.txtSy2.Size = new System.Drawing.Size(73, 20);
            this.txtSy2.TabIndex = 13;
            this.txtSy2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Y2:";
            // 
            // txtSx2
            // 
            this.txtSx2.Location = new System.Drawing.Point(43, 45);
            this.txtSx2.Name = "txtSx2";
            this.txtSx2.Size = new System.Drawing.Size(67, 20);
            this.txtSx2.TabIndex = 11;
            this.txtSx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "X2:";
            // 
            // txtSy
            // 
            this.txtSy.Location = new System.Drawing.Point(145, 71);
            this.txtSy.Name = "txtSy";
            this.txtSy.Size = new System.Drawing.Size(73, 20);
            this.txtSy.TabIndex = 17;
            this.txtSy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(116, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Sy:";
            // 
            // txtSx
            // 
            this.txtSx.Location = new System.Drawing.Point(43, 71);
            this.txtSx.Name = "txtSx";
            this.txtSx.Size = new System.Drawing.Size(67, 20);
            this.txtSx.TabIndex = 15;
            this.txtSx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Sx:";
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(9, 126);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(213, 23);
            this.btnS.TabIndex = 19;
            this.btnS.Text = "Escalar puntos";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnGenS
            // 
            this.btnGenS.Location = new System.Drawing.Point(9, 97);
            this.btnGenS.Name = "btnGenS";
            this.btnGenS.Size = new System.Drawing.Size(213, 23);
            this.btnGenS.TabIndex = 18;
            this.btnGenS.Text = "Generar puntos";
            this.btnGenS.UseVisualStyleBackColor = true;
            this.btnGenS.Click += new System.EventHandler(this.btnGenS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlano)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPlano;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTrasT;
        private System.Windows.Forms.Button btnGenT;
        private System.Windows.Forms.TextBox txtTPY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPTX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnGenR;
        private System.Windows.Forms.TextBox txtAngR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSy1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSx1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSy2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSx2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnGenS;
    }
}

