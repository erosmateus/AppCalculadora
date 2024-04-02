namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btZero = new System.Windows.Forms.Button();
            this.btCinco = new System.Windows.Forms.Button();
            this.btSeis = new System.Windows.Forms.Button();
            this.btQuatro = new System.Windows.Forms.Button();
            this.btTres = new System.Windows.Forms.Button();
            this.btDois = new System.Windows.Forms.Button();
            this.btUm = new System.Windows.Forms.Button();
            this.btNove = new System.Windows.Forms.Button();
            this.btOito = new System.Windows.Forms.Button();
            this.btSete = new System.Windows.Forms.Button();
            this.btVirgula = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btLimpa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(13, 22);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(273, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btZero
            // 
            this.btZero.Location = new System.Drawing.Point(95, 335);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(58, 58);
            this.btZero.TabIndex = 1;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = true;
            this.btZero.Click += new System.EventHandler(this.btZero_Click);
            // 
            // btCinco
            // 
            this.btCinco.Location = new System.Drawing.Point(95, 205);
            this.btCinco.Name = "btCinco";
            this.btCinco.Size = new System.Drawing.Size(58, 58);
            this.btCinco.TabIndex = 2;
            this.btCinco.Text = "5";
            this.btCinco.UseVisualStyleBackColor = true;
            this.btCinco.Click += new System.EventHandler(this.btCinco_Click);
            // 
            // btSeis
            // 
            this.btSeis.Location = new System.Drawing.Point(159, 205);
            this.btSeis.Name = "btSeis";
            this.btSeis.Size = new System.Drawing.Size(58, 58);
            this.btSeis.TabIndex = 3;
            this.btSeis.Text = "6";
            this.btSeis.UseVisualStyleBackColor = true;
            this.btSeis.Click += new System.EventHandler(this.btSeis_Click);
            // 
            // btQuatro
            // 
            this.btQuatro.Location = new System.Drawing.Point(31, 205);
            this.btQuatro.Name = "btQuatro";
            this.btQuatro.Size = new System.Drawing.Size(58, 58);
            this.btQuatro.TabIndex = 4;
            this.btQuatro.Text = "4";
            this.btQuatro.UseVisualStyleBackColor = true;
            this.btQuatro.Click += new System.EventHandler(this.btQuatro_Click);
            // 
            // btTres
            // 
            this.btTres.Location = new System.Drawing.Point(159, 269);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(58, 58);
            this.btTres.TabIndex = 5;
            this.btTres.Text = "3";
            this.btTres.UseVisualStyleBackColor = true;
            this.btTres.Click += new System.EventHandler(this.btTres_Click);
            // 
            // btDois
            // 
            this.btDois.Location = new System.Drawing.Point(95, 269);
            this.btDois.Name = "btDois";
            this.btDois.Size = new System.Drawing.Size(58, 58);
            this.btDois.TabIndex = 6;
            this.btDois.Text = "2";
            this.btDois.UseVisualStyleBackColor = true;
            this.btDois.Click += new System.EventHandler(this.btDois_Click);
            // 
            // btUm
            // 
            this.btUm.Location = new System.Drawing.Point(31, 269);
            this.btUm.Name = "btUm";
            this.btUm.Size = new System.Drawing.Size(58, 58);
            this.btUm.TabIndex = 7;
            this.btUm.Text = "1";
            this.btUm.UseVisualStyleBackColor = true;
            this.btUm.Click += new System.EventHandler(this.btUm_Click);
            // 
            // btNove
            // 
            this.btNove.Location = new System.Drawing.Point(159, 141);
            this.btNove.Name = "btNove";
            this.btNove.Size = new System.Drawing.Size(58, 58);
            this.btNove.TabIndex = 8;
            this.btNove.Text = "9";
            this.btNove.UseVisualStyleBackColor = true;
            this.btNove.Click += new System.EventHandler(this.btNove_Click);
            // 
            // btOito
            // 
            this.btOito.Location = new System.Drawing.Point(95, 141);
            this.btOito.Name = "btOito";
            this.btOito.Size = new System.Drawing.Size(58, 58);
            this.btOito.TabIndex = 9;
            this.btOito.Text = "8";
            this.btOito.UseVisualStyleBackColor = true;
            this.btOito.Click += new System.EventHandler(this.btOito_Click);
            // 
            // btSete
            // 
            this.btSete.Location = new System.Drawing.Point(31, 141);
            this.btSete.Name = "btSete";
            this.btSete.Size = new System.Drawing.Size(58, 58);
            this.btSete.TabIndex = 10;
            this.btSete.Text = "7";
            this.btSete.UseVisualStyleBackColor = true;
            this.btSete.Click += new System.EventHandler(this.btSete_Click);
            // 
            // btVirgula
            // 
            this.btVirgula.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btVirgula.Location = new System.Drawing.Point(31, 335);
            this.btVirgula.Name = "btVirgula";
            this.btVirgula.Size = new System.Drawing.Size(58, 58);
            this.btVirgula.TabIndex = 11;
            this.btVirgula.Text = ",";
            this.btVirgula.UseVisualStyleBackColor = true;
            this.btVirgula.Click += new System.EventHandler(this.btVirgula_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(159, 333);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(58, 58);
            this.btIgual.TabIndex = 12;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btMais
            // 
            this.btMais.Location = new System.Drawing.Point(223, 333);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(58, 58);
            this.btMais.TabIndex = 13;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // btMenos
            // 
            this.btMenos.Location = new System.Drawing.Point(223, 269);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(58, 58);
            this.btMenos.TabIndex = 14;
            this.btMenos.Text = "_";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(223, 205);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(58, 58);
            this.btMultiplicar.TabIndex = 15;
            this.btMultiplicar.Text = "X";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(223, 141);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(58, 58);
            this.btDividir.TabIndex = 16;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(223, 77);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(58, 58);
            this.btLimpa.TabIndex = 17;
            this.btLimpa.Text = "C";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btVirgula);
            this.Controls.Add(this.btSete);
            this.Controls.Add(this.btOito);
            this.Controls.Add(this.btNove);
            this.Controls.Add(this.btUm);
            this.Controls.Add(this.btDois);
            this.Controls.Add(this.btTres);
            this.Controls.Add(this.btQuatro);
            this.Controls.Add(this.btSeis);
            this.Controls.Add(this.btCinco);
            this.Controls.Add(this.btZero);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btCinco;
        private System.Windows.Forms.Button btSeis;
        private System.Windows.Forms.Button btQuatro;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Button btDois;
        private System.Windows.Forms.Button btUm;
        private System.Windows.Forms.Button btNove;
        private System.Windows.Forms.Button btOito;
        private System.Windows.Forms.Button btSete;
        private System.Windows.Forms.Button btVirgula;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Label label1;
    }
}

