namespace IComparble_Practice_Hongfei
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(460, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(786, 701);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(106, 170);
            button1.Name = "button1";
            button1.Size = new Size(306, 58);
            button1.TabIndex = 1;
            button1.Text = "Sort By CSIGrade";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(106, 293);
            button2.Name = "button2";
            button2.Size = new Size(306, 58);
            button2.TabIndex = 2;
            button2.Text = "Sort By GenEdGrade";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(106, 551);
            button3.Name = "button3";
            button3.Size = new Size(306, 58);
            button3.TabIndex = 3;
            button3.Text = "Sort By First Name";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(106, 390);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(305, 45);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Sort By Ascending ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(107, 467);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(315, 45);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Sort By Descending";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 877);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
