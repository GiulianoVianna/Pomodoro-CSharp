
namespace PomodoroApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.nmTempo = new System.Windows.Forms.NumericUpDown();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.lbPercentual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo";
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btIniciar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btIniciar.Location = new System.Drawing.Point(232, 22);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(115, 50);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // nmTempo
            // 
            this.nmTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmTempo.Location = new System.Drawing.Point(92, 33);
            this.nmTempo.Name = "nmTempo";
            this.nmTempo.Size = new System.Drawing.Size(75, 30);
            this.nmTempo.TabIndex = 2;
            // 
            // pgBar
            // 
            this.pgBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pgBar.Location = new System.Drawing.Point(17, 92);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(330, 34);
            this.pgBar.TabIndex = 3;
            // 
            // lbPercentual
            // 
            this.lbPercentual.AutoSize = true;
            this.lbPercentual.Location = new System.Drawing.Point(14, 72);
            this.lbPercentual.Name = "lbPercentual";
            this.lbPercentual.Size = new System.Drawing.Size(28, 17);
            this.lbPercentual.TabIndex = 4;
            this.lbPercentual.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 143);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPercentual);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.nmTempo);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            ((System.ComponentModel.ISupportInitialize)(this.nmTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.NumericUpDown nmTempo;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Label lbPercentual;
        private System.Windows.Forms.Label label2;
    }
}

