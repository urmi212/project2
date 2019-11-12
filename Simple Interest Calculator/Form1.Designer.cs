namespace Simple_Interest_Calculator
{
    partial class peryear2Label
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
            this.solveForcomboBox = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.showlabel = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.thirdTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.Firstlabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.resulitLabel = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.perYearLabel = new System.Windows.Forms.Label();
            this.perYearUnderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solveForcomboBox
            // 
            this.solveForcomboBox.BackColor = System.Drawing.SystemColors.Info;
            this.solveForcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.solveForcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveForcomboBox.FormattingEnabled = true;
            this.solveForcomboBox.Location = new System.Drawing.Point(181, 62);
            this.solveForcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.solveForcomboBox.Name = "solveForcomboBox";
            this.solveForcomboBox.Size = new System.Drawing.Size(367, 33);
            this.solveForcomboBox.TabIndex = 0;
            this.solveForcomboBox.SelectedIndexChanged += new System.EventHandler(this.SolveForcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solve For";
            // 
            // showlabel
            // 
            this.showlabel.AutoSize = true;
            this.showlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showlabel.Location = new System.Drawing.Point(251, 108);
            this.showlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showlabel.Name = "showlabel";
            this.showlabel.Size = new System.Drawing.Size(0, 20);
            this.showlabel.TabIndex = 2;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTextBox.Location = new System.Drawing.Point(183, 150);
            this.firstTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(366, 26);
            this.firstTextBox.TabIndex = 1;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextBox.Location = new System.Drawing.Point(183, 210);
            this.secondTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(366, 26);
            this.secondTextBox.TabIndex = 2;
            // 
            // thirdTextBox
            // 
            this.thirdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdTextBox.Location = new System.Drawing.Point(183, 277);
            this.thirdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.thirdTextBox.Name = "thirdTextBox";
            this.thirdTextBox.Size = new System.Drawing.Size(366, 26);
            this.thirdTextBox.TabIndex = 3;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(181, 422);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(367, 44);
            this.resultTextBox.TabIndex = 6;
            // 
            // Firstlabel
            // 
            this.Firstlabel.AutoSize = true;
            this.Firstlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstlabel.Location = new System.Drawing.Point(29, 150);
            this.Firstlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Firstlabel.Name = "Firstlabel";
            this.Firstlabel.Size = new System.Drawing.Size(64, 24);
            this.Firstlabel.TabIndex = 8;
            this.Firstlabel.Text = "Value";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(29, 212);
            this.secondLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(64, 24);
            this.secondLabel.TabIndex = 9;
            this.secondLabel.Text = "Value";
            // 
            // thirdLabel
            // 
            this.thirdLabel.AutoSize = true;
            this.thirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLabel.Location = new System.Drawing.Point(29, 279);
            this.thirdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(64, 24);
            this.thirdLabel.TabIndex = 10;
            this.thirdLabel.Text = "Value";
            // 
            // resulitLabel
            // 
            this.resulitLabel.AutoSize = true;
            this.resulitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulitLabel.Location = new System.Drawing.Point(26, 422);
            this.resulitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resulitLabel.Name = "resulitLabel";
            this.resulitLabel.Size = new System.Drawing.Size(98, 31);
            this.resulitLabel.TabIndex = 11;
            this.resulitLabel.Text = "Result";
            // 
            // timeComboBox
            // 
            this.timeComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(422, 316);
            this.timeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(127, 28);
            this.timeComboBox.TabIndex = 4;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeComboBox_SelectedIndexChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(399, 361);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(149, 50);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(183, 361);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(149, 50);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(177, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Simple Interest Calculator";
            // 
            // perYearLabel
            // 
            this.perYearLabel.AutoSize = true;
            this.perYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perYearLabel.Location = new System.Drawing.Point(74, 249);
            this.perYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.perYearLabel.Name = "perYearLabel";
            this.perYearLabel.Size = new System.Drawing.Size(0, 16);
            this.perYearLabel.TabIndex = 15;
            // 
            // perYearUnderLabel
            // 
            this.perYearUnderLabel.AutoSize = true;
            this.perYearUnderLabel.Location = new System.Drawing.Point(74, 314);
            this.perYearUnderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.perYearUnderLabel.Name = "perYearUnderLabel";
            this.perYearUnderLabel.Size = new System.Drawing.Size(0, 16);
            this.perYearUnderLabel.TabIndex = 16;
            // 
            // peryear2Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(668, 490);
            this.Controls.Add(this.perYearUnderLabel);
            this.Controls.Add(this.perYearLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.resulitLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.Firstlabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.thirdTextBox);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.showlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solveForcomboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "peryear2Label";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox solveForcomboBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showlabel;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.TextBox thirdTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label Firstlabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label resulitLabel;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label perYearLabel;
        private System.Windows.Forms.Label perYearUnderLabel;
    }
}

