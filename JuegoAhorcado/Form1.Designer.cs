﻿
namespace JuegoAhorcado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblIntento = new System.Windows.Forms.Label();
            this.TxtPalabraSecreta = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnIniciarJuego = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.PBintentos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBintentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra Secreta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intentos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // LblIntento
            // 
            this.LblIntento.AutoSize = true;
            this.LblIntento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntento.Location = new System.Drawing.Point(706, 202);
            this.LblIntento.Name = "LblIntento";
            this.LblIntento.Size = new System.Drawing.Size(19, 20);
            this.LblIntento.TabIndex = 3;
            this.LblIntento.Text = "0";
            // 
            // TxtPalabraSecreta
            // 
            this.TxtPalabraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPalabraSecreta.Location = new System.Drawing.Point(226, 46);
            this.TxtPalabraSecreta.Name = "TxtPalabraSecreta";
            this.TxtPalabraSecreta.Size = new System.Drawing.Size(362, 30);
            this.TxtPalabraSecreta.TabIndex = 4;
            this.TxtPalabraSecreta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPalabraSecreta_KeyPress);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.Location = new System.Drawing.Point(195, 136);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(362, 27);
            this.TxtResultado.TabIndex = 5;
            this.TxtResultado.TextChanged += new System.EventHandler(this.TxtResultado_TextChanged);
            // 
            // BtnIniciarJuego
            // 
            this.BtnIniciarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarJuego.Location = new System.Drawing.Point(337, 82);
            this.BtnIniciarJuego.Name = "BtnIniciarJuego";
            this.BtnIniciarJuego.Size = new System.Drawing.Size(156, 37);
            this.BtnIniciarJuego.TabIndex = 7;
            this.BtnIniciarJuego.Text = "Iniciar Juego";
            this.BtnIniciarJuego.UseVisualStyleBackColor = true;
            this.BtnIniciarJuego.Click += new System.EventHandler(this.BtnIniciarJuego_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(663, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "A";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(337, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 45);
            this.button4.TabIndex = 10;
            this.button4.Text = "E";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(264, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 45);
            this.button5.TabIndex = 11;
            this.button5.Text = "D";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(195, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 45);
            this.button6.TabIndex = 12;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(406, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 45);
            this.button7.TabIndex = 13;
            this.button7.Text = "F";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BtnClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(475, 202);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 45);
            this.button8.TabIndex = 14;
            this.button8.Text = "G";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BtnClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(121, 202);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 45);
            this.button9.TabIndex = 15;
            this.button9.Text = "B";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.BtnClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(121, 266);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 45);
            this.button10.TabIndex = 22;
            this.button10.Text = "I";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.BtnClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(475, 266);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(51, 45);
            this.button11.TabIndex = 21;
            this.button11.Text = "N";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BtnClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(406, 267);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(51, 45);
            this.button12.TabIndex = 20;
            this.button12.Text = "M";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.BtnClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(195, 266);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(51, 45);
            this.button13.TabIndex = 19;
            this.button13.Text = "J";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.BtnClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(264, 266);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 45);
            this.button14.TabIndex = 18;
            this.button14.Text = "K";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.BtnClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(337, 267);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 45);
            this.button15.TabIndex = 17;
            this.button15.Text = "L";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.BtnClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(48, 267);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(51, 45);
            this.button16.TabIndex = 16;
            this.button16.Text = "H";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.BtnClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(121, 328);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(51, 45);
            this.button17.TabIndex = 29;
            this.button17.Text = "O";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.BtnClick);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(475, 328);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(51, 45);
            this.button18.TabIndex = 28;
            this.button18.Text = "T";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.BtnClick);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(406, 329);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(51, 45);
            this.button19.TabIndex = 27;
            this.button19.Text = "S";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.BtnClick);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(195, 328);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(51, 45);
            this.button20.TabIndex = 26;
            this.button20.Text = "P";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.BtnClick);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(264, 328);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(51, 45);
            this.button21.TabIndex = 25;
            this.button21.Text = "Q";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.BtnClick);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(337, 329);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(51, 45);
            this.button22.TabIndex = 24;
            this.button22.Text = "R";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.BtnClick);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(48, 329);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(51, 45);
            this.button23.TabIndex = 23;
            this.button23.Text = "Ñ";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.BtnClick);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(121, 392);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(51, 45);
            this.button24.TabIndex = 35;
            this.button24.Text = "V";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.BtnClick);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(406, 393);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(51, 45);
            this.button25.TabIndex = 34;
            this.button25.Text = "Z";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.BtnClick);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(195, 392);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(51, 45);
            this.button26.TabIndex = 33;
            this.button26.Text = "W";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.BtnClick);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(264, 392);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(51, 45);
            this.button27.TabIndex = 32;
            this.button27.Text = "X";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.BtnClick);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(337, 393);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(51, 45);
            this.button28.TabIndex = 31;
            this.button28.Text = "Y";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.BtnClick);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(48, 393);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(51, 45);
            this.button29.TabIndex = 30;
            this.button29.Text = "U";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.BtnClick);
            // 
            // PBintentos
            // 
            this.PBintentos.Location = new System.Drawing.Point(578, 237);
            this.PBintentos.Name = "PBintentos";
            this.PBintentos.Size = new System.Drawing.Size(200, 200);
            this.PBintentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBintentos.TabIndex = 36;
            this.PBintentos.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 456);
            this.Controls.Add(this.PBintentos);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnIniciarJuego);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtPalabraSecreta);
            this.Controls.Add(this.LblIntento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de Ahorcado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBintentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblIntento;
        private System.Windows.Forms.TextBox TxtPalabraSecreta;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnIniciarJuego;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.PictureBox PBintentos;
    }
}

