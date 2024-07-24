namespace Rabanut
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
            label1 = new Label();
            YearcomboBox = new ComboBox();
            CalButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ManthcomboBox = new ComboBox();
            DayManthcomboBox = new ComboBox();
            DaycomboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 23);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "כתיבת תאריך";
            // 
            // YearcomboBox
            // 
            YearcomboBox.FormattingEnabled = true;
            YearcomboBox.Items.AddRange(new object[] { "תשפד", "תשפה", "תשפו", "תשפז", "תשפח", "תשפט", "תשצ", "תשצא", "תשצב", "תשצג", "תשצד" });
            YearcomboBox.Location = new Point(47, 137);
            YearcomboBox.Name = "YearcomboBox";
            YearcomboBox.Size = new Size(151, 28);
            YearcomboBox.TabIndex = 1;
            // 
            // CalButton
            // 
            CalButton.Location = new Point(80, 335);
            CalButton.Name = "CalButton";
            CalButton.Size = new Size(94, 29);
            CalButton.TabIndex = 2;
            CalButton.Text = "חשב";
            CalButton.UseVisualStyleBackColor = true;
            CalButton.Click += CalButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 102);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "יום בשבוע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 102);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "יום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 102);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "חודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 102);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 6;
            label5.Text = "שנה";
            // 
            // ManthcomboBox
            // 
            ManthcomboBox.FormattingEnabled = true;
            ManthcomboBox.Items.AddRange(new object[] { "תשרי", "חשוון", "כסליו", "טבת", "שבט", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" });
            ManthcomboBox.Location = new Point(215, 137);
            ManthcomboBox.Name = "ManthcomboBox";
            ManthcomboBox.Size = new Size(151, 28);
            ManthcomboBox.TabIndex = 7;
            // 
            // DayManthcomboBox
            // 
            DayManthcomboBox.FormattingEnabled = true;
            DayManthcomboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayManthcomboBox.Location = new Point(391, 137);
            DayManthcomboBox.Name = "DayManthcomboBox";
            DayManthcomboBox.Size = new Size(151, 28);
            DayManthcomboBox.TabIndex = 8;
            // 
            // DaycomboBox
            // 
            DaycomboBox.FormattingEnabled = true;
            DaycomboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            DaycomboBox.Location = new Point(570, 137);
            DaycomboBox.Name = "DaycomboBox";
            DaycomboBox.Size = new Size(151, 28);
            DaycomboBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DaycomboBox);
            Controls.Add(DayManthcomboBox);
            Controls.Add(ManthcomboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CalButton);
            Controls.Add(YearcomboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox YearcomboBox;
        private Button CalButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox ManthcomboBox;
        private ComboBox DayManthcomboBox;
        private ComboBox DaycomboBox;
    }
}
