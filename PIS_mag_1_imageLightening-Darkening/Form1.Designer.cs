namespace PIS_mag_1_imageLightening_Darkening
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
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.filterLevelNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.darkerRadioButton = new System.Windows.Forms.RadioButton();
            this.lighterRadioButton = new System.Windows.Forms.RadioButton();
            this.grayscaleRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLevelNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.Location = new System.Drawing.Point(10, 35);
            this.inputPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(600, 404);
            this.inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputPictureBox.TabIndex = 0;
            this.inputPictureBox.TabStop = false;
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.Location = new System.Drawing.Point(10, 35);
            this.outputPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(600, 404);
            this.outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outputPictureBox.TabIndex = 1;
            this.outputPictureBox.TabStop = false;
            // 
            // filterLevelNumeric
            // 
            this.filterLevelNumeric.DecimalPlaces = 1;
            this.filterLevelNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.filterLevelNumeric.Location = new System.Drawing.Point(16, 220);
            this.filterLevelNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterLevelNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.filterLevelNumeric.Name = "filterLevelNumeric";
            this.filterLevelNumeric.Size = new System.Drawing.Size(220, 31);
            this.filterLevelNumeric.TabIndex = 2;
            this.filterLevelNumeric.Visible = false;
            this.filterLevelNumeric.ValueChanged += new System.EventHandler(this.filterLevelNumeric_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(628, 452);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оригинал";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 487);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(628, 452);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Предпросмотр:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grayscaleRadioButton);
            this.groupBox3.Controls.Add(this.noneRadioButton);
            this.groupBox3.Controls.Add(this.darkerRadioButton);
            this.groupBox3.Controls.Add(this.lighterRadioButton);
            this.groupBox3.Controls.Add(this.filterLevelNumeric);
            this.groupBox3.Location = new System.Drawing.Point(662, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(258, 275);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтр";
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Checked = true;
            this.noneRadioButton.Location = new System.Drawing.Point(16, 35);
            this.noneRadioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(80, 29);
            this.noneRadioButton.TabIndex = 5;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "Нет";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            this.noneRadioButton.CheckedChanged += new System.EventHandler(this.noneRadioButton_CheckedChanged);
            // 
            // darkerRadioButton
            // 
            this.darkerRadioButton.AutoSize = true;
            this.darkerRadioButton.Location = new System.Drawing.Point(16, 123);
            this.darkerRadioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.darkerRadioButton.Name = "darkerRadioButton";
            this.darkerRadioButton.Size = new System.Drawing.Size(165, 29);
            this.darkerRadioButton.TabIndex = 4;
            this.darkerRadioButton.Text = "Затемнение";
            this.darkerRadioButton.UseVisualStyleBackColor = true;
            this.darkerRadioButton.CheckedChanged += new System.EventHandler(this.darkerRadioButton_CheckedChanged);
            // 
            // lighterRadioButton
            // 
            this.lighterRadioButton.AutoSize = true;
            this.lighterRadioButton.Location = new System.Drawing.Point(16, 79);
            this.lighterRadioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lighterRadioButton.Name = "lighterRadioButton";
            this.lighterRadioButton.Size = new System.Drawing.Size(163, 29);
            this.lighterRadioButton.TabIndex = 3;
            this.lighterRadioButton.Text = "Осветление";
            this.lighterRadioButton.UseVisualStyleBackColor = true;
            this.lighterRadioButton.CheckedChanged += new System.EventHandler(this.lighterRadioButton_CheckedChanged);
            // 
            // grayscaleRadioButton
            // 
            this.grayscaleRadioButton.AutoSize = true;
            this.grayscaleRadioButton.Location = new System.Drawing.Point(16, 168);
            this.grayscaleRadioButton.Name = "grayscaleRadioButton";
            this.grayscaleRadioButton.Size = new System.Drawing.Size(199, 29);
            this.grayscaleRadioButton.TabIndex = 6;
            this.grayscaleRadioButton.TabStop = true;
            this.grayscaleRadioButton.Text = "Оттенки серого";
            this.grayscaleRadioButton.UseVisualStyleBackColor = true;
            this.grayscaleRadioButton.CheckedChanged += new System.EventHandler(this.grayscaleRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 958);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(950, 961);
            this.Name = "Form1";
            this.Text = "Photoshop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLevelNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.PictureBox outputPictureBox;
        private System.Windows.Forms.NumericUpDown filterLevelNumeric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.RadioButton darkerRadioButton;
        private System.Windows.Forms.RadioButton lighterRadioButton;
        private System.Windows.Forms.RadioButton grayscaleRadioButton;
    }
}

