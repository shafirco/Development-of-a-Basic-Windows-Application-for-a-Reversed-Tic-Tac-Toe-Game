namespace Ex05.GameUI
{
    partial class GameSettingsForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2Player1 = new System.Windows.Forms.TextBox();
            this.textBox1player2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1Rows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Cols = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Cols)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonStart.Location = new System.Drawing.Point(28, 259);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(263, 32);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.272727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Players:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.272727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 1:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.272727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(74, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player 2:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.272727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(188, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cols:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.272727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(24, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Board Size:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.272727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(47, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rows:";
            // 
            // textBox2Player1
            // 
            this.textBox2Player1.Location = new System.Drawing.Point(168, 60);
            this.textBox2Player1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2Player1.Multiline = true;
            this.textBox2Player1.Name = "textBox2Player1";
            this.textBox2Player1.Size = new System.Drawing.Size(123, 23);
            this.textBox2Player1.TabIndex = 2;
            // 
            // textBox1player2
            // 
            this.textBox1player2.Enabled = false;
            this.textBox1player2.Location = new System.Drawing.Point(168, 100);
            this.textBox1player2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1player2.Multiline = true;
            this.textBox1player2.Name = "textBox1player2";
            this.textBox1player2.Size = new System.Drawing.Size(123, 23);
            this.textBox1player2.TabIndex = 10;
            this.textBox1player2.Text = "Computer";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(51, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(17, 23);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1Rows
            // 
            this.numericUpDown1Rows.Location = new System.Drawing.Point(109, 190);
            this.numericUpDown1Rows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1Rows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1Rows.Name = "numericUpDown1Rows";
            this.numericUpDown1Rows.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown1Rows.TabIndex = 12;
            this.numericUpDown1Rows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1Rows.ValueChanged += new System.EventHandler(this.numericUpDown1Rows_ValueChanged);
            // 
            // numericUpDown2Cols
            // 
            this.numericUpDown2Cols.Location = new System.Drawing.Point(241, 190);
            this.numericUpDown2Cols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2Cols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2Cols.Name = "numericUpDown2Cols";
            this.numericUpDown2Cols.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown2Cols.TabIndex = 13;
            this.numericUpDown2Cols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2Cols.ValueChanged += new System.EventHandler(this.numericUpDown2Cols_ValueChanged);
            // 
            // GameSettingsForm
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(340, 320);
            this.Controls.Add(this.numericUpDown2Cols);
            this.Controls.Add(this.textBox1player2);
            this.Controls.Add(this.textBox2Player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1Rows);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettingsForm_Load);
            this.MouseEnter += new System.EventHandler(this.GameSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Cols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2Player1;
        private System.Windows.Forms.TextBox textBox1player2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1Rows;
        private System.Windows.Forms.NumericUpDown numericUpDown2Cols;
        private System.Windows.Forms.Button buttonStart;
    }
}

