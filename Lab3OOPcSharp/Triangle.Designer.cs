namespace Lab3OOPcSharp
{
    partial class TriangleForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.XAtextBox = new System.Windows.Forms.TextBox();
            this.YAtextBox = new System.Windows.Forms.TextBox();
            this.XBtextBox = new System.Windows.Forms.TextBox();
            this.YBtextBox = new System.Windows.Forms.TextBox();
            this.XCtextBox = new System.Windows.Forms.TextBox();
            this.YCtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SideACtextBox = new System.Windows.Forms.TextBox();
            this.SideBCtextBox = new System.Windows.Forms.TextBox();
            this.PerimetertextBox = new System.Windows.Forms.TextBox();
            this.AreatextBox = new System.Windows.Forms.TextBox();
            this.SideABtextBox = new System.Windows.Forms.TextBox();
            this.MedianCrossPointtextBox = new System.Windows.Forms.TextBox();
            this.IsExisttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XAtextBox
            // 
            this.XAtextBox.Location = new System.Drawing.Point(39, 24);
            this.XAtextBox.Name = "XAtextBox";
            this.XAtextBox.Size = new System.Drawing.Size(34, 20);
            this.XAtextBox.TabIndex = 0;
            // 
            // YAtextBox
            // 
            this.YAtextBox.Location = new System.Drawing.Point(79, 24);
            this.YAtextBox.Name = "YAtextBox";
            this.YAtextBox.Size = new System.Drawing.Size(34, 20);
            this.YAtextBox.TabIndex = 6;
            // 
            // XBtextBox
            // 
            this.XBtextBox.Location = new System.Drawing.Point(119, 24);
            this.XBtextBox.Name = "XBtextBox";
            this.XBtextBox.Size = new System.Drawing.Size(34, 20);
            this.XBtextBox.TabIndex = 7;
            // 
            // YBtextBox
            // 
            this.YBtextBox.Location = new System.Drawing.Point(159, 24);
            this.YBtextBox.Name = "YBtextBox";
            this.YBtextBox.Size = new System.Drawing.Size(34, 20);
            this.YBtextBox.TabIndex = 8;
            // 
            // XCtextBox
            // 
            this.XCtextBox.Location = new System.Drawing.Point(199, 24);
            this.XCtextBox.Name = "XCtextBox";
            this.XCtextBox.Size = new System.Drawing.Size(34, 20);
            this.XCtextBox.TabIndex = 9;
            // 
            // YCtextBox
            // 
            this.YCtextBox.Location = new System.Drawing.Point(239, 24);
            this.YCtextBox.Name = "YCtextBox";
            this.YCtextBox.Size = new System.Drawing.Size(34, 20);
            this.YCtextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SideACtextBox
            // 
            this.SideACtextBox.Location = new System.Drawing.Point(68, 85);
            this.SideACtextBox.Name = "SideACtextBox";
            this.SideACtextBox.ReadOnly = true;
            this.SideACtextBox.Size = new System.Drawing.Size(115, 20);
            this.SideACtextBox.TabIndex = 13;
            // 
            // SideBCtextBox
            // 
            this.SideBCtextBox.Location = new System.Drawing.Point(68, 111);
            this.SideBCtextBox.Name = "SideBCtextBox";
            this.SideBCtextBox.ReadOnly = true;
            this.SideBCtextBox.Size = new System.Drawing.Size(115, 20);
            this.SideBCtextBox.TabIndex = 14;
            // 
            // PerimetertextBox
            // 
            this.PerimetertextBox.Location = new System.Drawing.Point(68, 137);
            this.PerimetertextBox.Name = "PerimetertextBox";
            this.PerimetertextBox.ReadOnly = true;
            this.PerimetertextBox.Size = new System.Drawing.Size(115, 20);
            this.PerimetertextBox.TabIndex = 15;
            // 
            // AreatextBox
            // 
            this.AreatextBox.Location = new System.Drawing.Point(68, 163);
            this.AreatextBox.Name = "AreatextBox";
            this.AreatextBox.ReadOnly = true;
            this.AreatextBox.Size = new System.Drawing.Size(115, 20);
            this.AreatextBox.TabIndex = 16;
            // 
            // SideABtextBox
            // 
            this.SideABtextBox.Location = new System.Drawing.Point(68, 59);
            this.SideABtextBox.Name = "SideABtextBox";
            this.SideABtextBox.ReadOnly = true;
            this.SideABtextBox.Size = new System.Drawing.Size(115, 20);
            this.SideABtextBox.TabIndex = 17;
            // 
            // MedianCrossPointtextBox
            // 
            this.MedianCrossPointtextBox.Location = new System.Drawing.Point(213, 85);
            this.MedianCrossPointtextBox.Name = "MedianCrossPointtextBox";
            this.MedianCrossPointtextBox.ReadOnly = true;
            this.MedianCrossPointtextBox.Size = new System.Drawing.Size(100, 20);
            this.MedianCrossPointtextBox.TabIndex = 18;
            // 
            // IsExisttextBox
            // 
            this.IsExisttextBox.Location = new System.Drawing.Point(68, 190);
            this.IsExisttextBox.Name = "IsExisttextBox";
            this.IsExisttextBox.ReadOnly = true;
            this.IsExisttextBox.Size = new System.Drawing.Size(115, 20);
            this.IsExisttextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "SideAB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "SideAC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "SideBC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Perimeter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "MedianCrossPoint";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "IsExist";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Enter a(x,y),b(x,y),c(x,y)";
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 270);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsExisttextBox);
            this.Controls.Add(this.MedianCrossPointtextBox);
            this.Controls.Add(this.SideABtextBox);
            this.Controls.Add(this.AreatextBox);
            this.Controls.Add(this.PerimetertextBox);
            this.Controls.Add(this.SideBCtextBox);
            this.Controls.Add(this.SideACtextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YCtextBox);
            this.Controls.Add(this.XCtextBox);
            this.Controls.Add(this.YBtextBox);
            this.Controls.Add(this.XBtextBox);
            this.Controls.Add(this.YAtextBox);
            this.Controls.Add(this.XAtextBox);
            this.Name = "TriangleForm";
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XAtextBox;
        private System.Windows.Forms.TextBox YAtextBox;
        private System.Windows.Forms.TextBox XBtextBox;
        private System.Windows.Forms.TextBox YBtextBox;
        private System.Windows.Forms.TextBox XCtextBox;
        private System.Windows.Forms.TextBox YCtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SideACtextBox;
        private System.Windows.Forms.TextBox SideBCtextBox;
        private System.Windows.Forms.TextBox PerimetertextBox;
        private System.Windows.Forms.TextBox AreatextBox;
        private System.Windows.Forms.TextBox SideABtextBox;
        private System.Windows.Forms.TextBox MedianCrossPointtextBox;
        private System.Windows.Forms.TextBox IsExisttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

