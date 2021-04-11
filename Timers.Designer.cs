
namespace Uchet
{
    partial class Timers
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
            this.components = new System.ComponentModel.Container();
            this.Stop = new System.Windows.Forms.Button();
            this.Vixodswork = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.hourlabel = new System.Windows.Forms.Label();
            this.secundeslabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minuteslabel = new System.Windows.Forms.Label();
            this.twotochka = new System.Windows.Forms.Label();
            this.couldown = new System.Windows.Forms.Timer(this.components);
            this.couldown2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(354, 237);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(108, 61);
            this.Stop.TabIndex = 0;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Vixodswork
            // 
            this.Vixodswork.Location = new System.Drawing.Point(680, 50);
            this.Vixodswork.Name = "Vixodswork";
            this.Vixodswork.Size = new System.Drawing.Size(108, 49);
            this.Vixodswork.TabIndex = 1;
            this.Vixodswork.Text = "Завершение работы";
            this.Vixodswork.UseVisualStyleBackColor = true;
            this.Vixodswork.Click += new System.EventHandler(this.Vixodswork_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(189, 237);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(118, 61);
            this.Start.TabIndex = 2;
            this.Start.Text = "Начало Работы";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // hourlabel
            // 
            this.hourlabel.AutoSize = true;
            this.hourlabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourlabel.Location = new System.Drawing.Point(189, 91);
            this.hourlabel.Name = "hourlabel";
            this.hourlabel.Size = new System.Drawing.Size(64, 73);
            this.hourlabel.TabIndex = 3;
            this.hourlabel.Text = "0";
            // 
            // secundeslabel
            // 
            this.secundeslabel.AutoSize = true;
            this.secundeslabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secundeslabel.Location = new System.Drawing.Point(362, 91);
            this.secundeslabel.Name = "secundeslabel";
            this.secundeslabel.Size = new System.Drawing.Size(64, 73);
            this.secundeslabel.TabIndex = 5;
            this.secundeslabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(321, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 73);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // minuteslabel
            // 
            this.minuteslabel.AutoSize = true;
            this.minuteslabel.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteslabel.Location = new System.Drawing.Point(269, 91);
            this.minuteslabel.Name = "minuteslabel";
            this.minuteslabel.Size = new System.Drawing.Size(64, 73);
            this.minuteslabel.TabIndex = 7;
            this.minuteslabel.Text = "0";
            // 
            // twotochka
            // 
            this.twotochka.AutoSize = true;
            this.twotochka.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twotochka.Location = new System.Drawing.Point(232, 91);
            this.twotochka.Name = "twotochka";
            this.twotochka.Size = new System.Drawing.Size(53, 73);
            this.twotochka.TabIndex = 8;
            this.twotochka.Text = ":";
            // 
            // couldown
            // 
            this.couldown.Interval = 1000;
            this.couldown.Tick += new System.EventHandler(this.couldown_Tick);
            // 
            // couldown2
            // 
            this.couldown2.Interval = 1000;
            this.couldown2.Tick += new System.EventHandler(this.couldown2_Tick);
            // 
            // Timers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.twotochka);
            this.Controls.Add(this.minuteslabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secundeslabel);
            this.Controls.Add(this.hourlabel);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Vixodswork);
            this.Controls.Add(this.Stop);
            this.Name = "Timers";
            this.Text = "Timers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Vixodswork;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label hourlabel;
        private System.Windows.Forms.Label secundeslabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minuteslabel;
        private System.Windows.Forms.Label twotochka;
        private System.Windows.Forms.Timer couldown;
        private System.Windows.Forms.Timer couldown2;
    }
}