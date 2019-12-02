namespace ShlukovaAnalyza
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.Button_soubor = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.number_final = new System.Windows.Forms.NumericUpDown();
            this.label_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_random = new System.Windows.Forms.Button();
            this.number_random = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_krokovat = new System.Windows.Forms.CheckBox();
            this.button_krok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_random)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(666, 615);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Button_soubor
            // 
            this.Button_soubor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_soubor.Location = new System.Drawing.Point(672, 14);
            this.Button_soubor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_soubor.Name = "Button_soubor";
            this.Button_soubor.Size = new System.Drawing.Size(325, 82);
            this.Button_soubor.TabIndex = 1;
            this.Button_soubor.Text = "Vyber vstupní data";
            this.Button_soubor.UseVisualStyleBackColor = true;
            this.Button_soubor.Click += new System.EventHandler(this.Button_soubor_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start.Location = new System.Drawing.Point(672, 502);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(325, 113);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Seshlukuj!";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // number_final
            // 
            this.number_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number_final.Location = new System.Drawing.Point(677, 428);
            this.number_final.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_final.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number_final.Name = "number_final";
            this.number_final.Size = new System.Drawing.Size(293, 38);
            this.number_final.TabIndex = 3;
            this.number_final.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_count.Location = new System.Drawing.Point(671, 375);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(285, 29);
            this.label_count.TabIndex = 4;
            this.label_count.Text = "Počáteční počet shluků: 0";
            this.label_count.Click += new System.EventHandler(this.label_count_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(672, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cílový počet shluků";
            // 
            // button_random
            // 
            this.button_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_random.Location = new System.Drawing.Point(672, 123);
            this.button_random.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(325, 82);
            this.button_random.TabIndex = 6;
            this.button_random.Text = "Vytvoř data náhodně";
            this.button_random.UseVisualStyleBackColor = true;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // number_random
            // 
            this.number_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number_random.Location = new System.Drawing.Point(677, 209);
            this.number_random.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_random.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.number_random.Name = "number_random";
            this.number_random.Size = new System.Drawing.Size(293, 38);
            this.number_random.TabIndex = 7;
            this.number_random.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(677, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Počáteční počet shluků\r\npokud chcete náhodně\r\n";
            // 
            // checkBox_krokovat
            // 
            this.checkBox_krokovat.AutoSize = true;
            this.checkBox_krokovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_krokovat.Location = new System.Drawing.Point(681, 310);
            this.checkBox_krokovat.Name = "checkBox_krokovat";
            this.checkBox_krokovat.Size = new System.Drawing.Size(155, 24);
            this.checkBox_krokovat.TabIndex = 9;
            this.checkBox_krokovat.Text = "Ručně krokovat?";
            this.checkBox_krokovat.UseVisualStyleBackColor = true;
            this.checkBox_krokovat.CheckedChanged += new System.EventHandler(this.checkBox_krokovat_CheckedChanged);
            // 
            // button_krok
            // 
            this.button_krok.Enabled = false;
            this.button_krok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_krok.Location = new System.Drawing.Point(845, 298);
            this.button_krok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_krok.Name = "button_krok";
            this.button_krok.Size = new System.Drawing.Size(152, 43);
            this.button_krok.TabIndex = 10;
            this.button_krok.Text = "Udělej krok";
            this.button_krok.UseVisualStyleBackColor = true;
            this.button_krok.Click += new System.EventHandler(this.button_krok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 630);
            this.Controls.Add(this.button_krok);
            this.Controls.Add(this.checkBox_krokovat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number_random);
            this.Controls.Add(this.button_random);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.number_final);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.Button_soubor);
            this.Controls.Add(this.canvas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shluková Analýza by Neuron";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_random)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button Button_soubor;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.NumericUpDown number_final;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.NumericUpDown number_random;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_krokovat;
        private System.Windows.Forms.Button button_krok;
    }
}

