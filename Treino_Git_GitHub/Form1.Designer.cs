namespace Treino_Git_GitHub
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
            this.btnAug = new System.Windows.Forms.Button();
            this.btnCarlos = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConflito1 = new System.Windows.Forms.Button();
            this.btnConflito2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAug
            // 
            this.btnAug.Location = new System.Drawing.Point(6, 25);
            this.btnAug.Name = "btnAug";
            this.btnAug.Size = new System.Drawing.Size(220, 121);
            this.btnAug.TabIndex = 0;
            this.btnAug.Text = "Augusto";
            this.btnAug.UseVisualStyleBackColor = true;
            this.btnAug.Click += new System.EventHandler(this.btnAug_Click);
            // 
            // btnCarlos
            // 
            this.btnCarlos.Location = new System.Drawing.Point(254, 25);
            this.btnCarlos.Name = "btnCarlos";
            this.btnCarlos.Size = new System.Drawing.Size(220, 121);
            this.btnCarlos.TabIndex = 1;
            this.btnCarlos.Text = "Carlos";
            this.btnCarlos.UseVisualStyleBackColor = true;
            this.btnCarlos.Click += new System.EventHandler(this.btnCarlos_Click);
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(503, 25);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(220, 121);
            this.btnGui.TabIndex = 2;
            this.btnGui.Text = "Guilherme";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAug);
            this.groupBox1.Controls.Add(this.btnGui);
            this.groupBox1.Controls.Add(this.btnCarlos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Push sem conflitos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConflito1);
            this.groupBox2.Controls.Add(this.btnConflito2);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 161);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Push com conflitos";
            // 
            // btnConflito1
            // 
            this.btnConflito1.Location = new System.Drawing.Point(115, 25);
            this.btnConflito1.Name = "btnConflito1";
            this.btnConflito1.Size = new System.Drawing.Size(220, 121);
            this.btnConflito1.TabIndex = 0;
            this.btnConflito1.Text = "Conflito 1";
            this.btnConflito1.UseVisualStyleBackColor = true;
            this.btnConflito1.Click += new System.EventHandler(this.btnConflito1_Click);
            // 
            // btnConflito2
            // 
            this.btnConflito2.Location = new System.Drawing.Point(396, 25);
            this.btnConflito2.Name = "btnConflito2";
            this.btnConflito2.Size = new System.Drawing.Size(220, 121);
            this.btnConflito2.TabIndex = 1;
            this.btnConflito2.Text = "Conflito 2";
            this.btnConflito2.UseVisualStyleBackColor = true;
            this.btnConflito2.Click += new System.EventHandler(this.btnConflito2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAug;
        private System.Windows.Forms.Button btnCarlos;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConflito1;
        private System.Windows.Forms.Button btnConflito2;
    }
}

