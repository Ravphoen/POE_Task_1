namespace Gade_Assignment_1
{
    partial class BattleForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.textDisplayBox = new System.Windows.Forms.RichTextBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.MapTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(467, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(467, 68);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 50);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(13, 12);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(81, 29);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "label1";
            // 
            // textDisplayBox
            // 
            this.textDisplayBox.Location = new System.Drawing.Point(432, 124);
            this.textDisplayBox.Name = "textDisplayBox";
            this.textDisplayBox.Size = new System.Drawing.Size(212, 313);
            this.textDisplayBox.TabIndex = 3;
            this.textDisplayBox.Text = "";
            this.textDisplayBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MapTextBox
            // 
            this.MapTextBox.Location = new System.Drawing.Point(18, 44);
            this.MapTextBox.Name = "MapTextBox";
            this.MapTextBox.Size = new System.Drawing.Size(350, 350);
            this.MapTextBox.TabIndex = 4;
            this.MapTextBox.Text = "";
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.MapTextBox);
            this.Controls.Add(this.textDisplayBox);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Name = "BattleForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.RichTextBox textDisplayBox;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.RichTextBox MapTextBox;
    }
}

