namespace GraphicsProject
{
    partial class GraphicsForm
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numberLinesTextBox = new System.Windows.Forms.TextBox();
            this.drawLinesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.horRadioBut = new System.Windows.Forms.RadioButton();
            this.verRadioBut = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingPanel.BackColor = System.Drawing.Color.White;
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Location = new System.Drawing.Point(12, 88);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(365, 268);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Lines";
            // 
            // numberLinesTextBox
            // 
            this.numberLinesTextBox.Location = new System.Drawing.Point(15, 37);
            this.numberLinesTextBox.Name = "numberLinesTextBox";
            this.numberLinesTextBox.ShortcutsEnabled = false;
            this.numberLinesTextBox.Size = new System.Drawing.Size(69, 20);
            this.numberLinesTextBox.TabIndex = 2;
            this.numberLinesTextBox.Text = "5";
            // 
            // drawLinesButton
            // 
            this.drawLinesButton.Location = new System.Drawing.Point(105, 34);
            this.drawLinesButton.Name = "drawLinesButton";
            this.drawLinesButton.Size = new System.Drawing.Size(75, 23);
            this.drawLinesButton.TabIndex = 3;
            this.drawLinesButton.Text = "Draw Lines";
            this.drawLinesButton.UseVisualStyleBackColor = true;
            this.drawLinesButton.Click += new System.EventHandler(this.drawLinesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.verRadioBut);
            this.groupBox1.Controls.Add(this.horRadioBut);
            this.groupBox1.Location = new System.Drawing.Point(201, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orientation";
            // 
            // horRadioBut
            // 
            this.horRadioBut.AutoSize = true;
            this.horRadioBut.Location = new System.Drawing.Point(6, 16);
            this.horRadioBut.Name = "horRadioBut";
            this.horRadioBut.Size = new System.Drawing.Size(72, 17);
            this.horRadioBut.TabIndex = 0;
            this.horRadioBut.TabStop = true;
            this.horRadioBut.Text = "Horizontal";
            this.horRadioBut.UseVisualStyleBackColor = true;
            // 
            // verRadioBut
            // 
            this.verRadioBut.AutoSize = true;
            this.verRadioBut.Location = new System.Drawing.Point(6, 39);
            this.verRadioBut.Name = "verRadioBut";
            this.verRadioBut.Size = new System.Drawing.Size(60, 17);
            this.verRadioBut.TabIndex = 1;
            this.verRadioBut.TabStop = true;
            this.verRadioBut.Text = "Vertical";
            this.verRadioBut.UseVisualStyleBackColor = true;
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drawLinesButton);
            this.Controls.Add(this.numberLinesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawingPanel);
            this.DoubleBuffered = true;
            this.Name = "GraphicsForm";
            this.Text = "Graphics Example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberLinesTextBox;
        private System.Windows.Forms.Button drawLinesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton verRadioBut;
        private System.Windows.Forms.RadioButton horRadioBut;
    }
}

