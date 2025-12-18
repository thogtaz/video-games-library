namespace video_games_library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            p_background = new Panel();
            p_filtre = new Panel();
            pb_jacquette = new PictureBox();
            dataGridView1 = new DataGridView();
            p_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_jacquette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // p_background
            // 
            p_background.BackColor = SystemColors.ControlDark;
            p_background.Controls.Add(dataGridView1);
            p_background.Controls.Add(pb_jacquette);
            p_background.Controls.Add(p_filtre);
            p_background.Location = new Point(-2, 0);
            p_background.Name = "p_background";
            p_background.Size = new Size(1577, 954);
            p_background.TabIndex = 0;
            // 
            // p_filtre
            // 
            p_filtre.BackColor = SystemColors.InactiveCaption;
            p_filtre.Location = new Point(0, 0);
            p_filtre.Name = "p_filtre";
            p_filtre.Size = new Size(370, 954);
            p_filtre.TabIndex = 0;
            // 
            // pb_jacquette
            // 
            pb_jacquette.BackColor = SystemColors.InactiveCaptionText;
            pb_jacquette.Location = new Point(1216, 75);
            pb_jacquette.Name = "pb_jacquette";
            pb_jacquette.Size = new Size(312, 315);
            pb_jacquette.TabIndex = 2;
            pb_jacquette.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(766, 837);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 951);
            Controls.Add(p_background);
            Name = "Form1";
            Text = "Form1";
            p_background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_jacquette).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel p_background;
        private Panel p_filtre;
        private PictureBox pb_jacquette;
        private DataGridView dataGridView1;
    }
}
