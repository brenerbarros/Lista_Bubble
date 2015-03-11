namespace _2015_3003_1BIM_ListaEncadeada
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Posicao = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.Organizarbublle = new System.Windows.Forms.Button();
            this.Visualizador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inicializar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InicializarLista);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Adiciona Elemento";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.AdicionaElemento);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exibir Lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExibirLista);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Elemento Específico";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AdicionarElementoEspecifico);
            // 
            // Posicao
            // 
            this.Posicao.Location = new System.Drawing.Point(62, 98);
            this.Posicao.Name = "Posicao";
            this.Posicao.Size = new System.Drawing.Size(147, 20);
            this.Posicao.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(139, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 22);
            this.button5.TabIndex = 5;
            this.button5.Text = "Elemento Por Valor";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(421, 12);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(130, 26);
            this.BubbleSort.TabIndex = 6;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // Organizarbublle
            // 
            this.Organizarbublle.Location = new System.Drawing.Point(421, 44);
            this.Organizarbublle.Name = "Organizarbublle";
            this.Organizarbublle.Size = new System.Drawing.Size(130, 29);
            this.Organizarbublle.TabIndex = 7;
            this.Organizarbublle.Text = "Organizar";
            this.Organizarbublle.UseVisualStyleBackColor = true;
            this.Organizarbublle.Click += new System.EventHandler(this.Organizarbublle_Click);
            // 
            // Visualizador
            // 
            this.Visualizador.Location = new System.Drawing.Point(377, 79);
            this.Visualizador.Multiline = true;
            this.Visualizador.Name = "Visualizador";
            this.Visualizador.Size = new System.Drawing.Size(207, 83);
            this.Visualizador.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 188);
            this.Controls.Add(this.Visualizador);
            this.Controls.Add(this.Organizarbublle);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Posicao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Lista Encadeada";
            this.Load += new System.EventHandler(this.CarregarPrograma);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Posicao;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button Organizarbublle;
        private System.Windows.Forms.TextBox Visualizador;

    }
}

