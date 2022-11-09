
namespace OOP
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.clear = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.crush = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.extraction = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.deleteLastNode = new System.Windows.Forms.Button();
            this.DataInput = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.IndianRed;
            this.clear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clear.Location = new System.Drawing.Point(6, 134);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(50, 50);
            this.clear.TabIndex = 8;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Square.FlatAppearance.BorderSize = 0;
            this.Square.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square.Location = new System.Drawing.Point(61, 134);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(50, 50);
            this.Square.TabIndex = 9;
            this.Square.Text = "x²";
            this.Square.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.LightYellow;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Location = new System.Drawing.Point(174, 134);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 11;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // crush
            // 
            this.crush.BackColor = System.Drawing.Color.LightYellow;
            this.crush.FlatAppearance.BorderSize = 0;
            this.crush.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.crush.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crush.Location = new System.Drawing.Point(174, 190);
            this.crush.Name = "crush";
            this.crush.Size = new System.Drawing.Size(50, 50);
            this.crush.TabIndex = 15;
            this.crush.Text = "x";
            this.crush.UseVisualStyleBackColor = false;
            this.crush.Click += new System.EventHandler(this.crush_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Location = new System.Drawing.Point(118, 190);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 50);
            this.nine.TabIndex = 14;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Location = new System.Drawing.Point(62, 190);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(50, 50);
            this.eight.TabIndex = 13;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Location = new System.Drawing.Point(6, 190);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(50, 50);
            this.seven.TabIndex = 12;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // extraction
            // 
            this.extraction.BackColor = System.Drawing.Color.LightYellow;
            this.extraction.FlatAppearance.BorderSize = 0;
            this.extraction.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.extraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extraction.Location = new System.Drawing.Point(174, 246);
            this.extraction.Name = "extraction";
            this.extraction.Size = new System.Drawing.Size(50, 50);
            this.extraction.TabIndex = 19;
            this.extraction.Text = "-";
            this.extraction.UseVisualStyleBackColor = false;
            this.extraction.Click += new System.EventHandler(this.extraction_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Location = new System.Drawing.Point(118, 246);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(50, 50);
            this.six.TabIndex = 18;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Location = new System.Drawing.Point(62, 246);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(50, 50);
            this.five.TabIndex = 17;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Location = new System.Drawing.Point(6, 246);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(50, 50);
            this.four.TabIndex = 16;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.LightYellow;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Location = new System.Drawing.Point(174, 302);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 50);
            this.plus.TabIndex = 23;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Location = new System.Drawing.Point(117, 302);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 50);
            this.three.TabIndex = 22;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Location = new System.Drawing.Point(62, 302);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 50);
            this.two.TabIndex = 21;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Location = new System.Drawing.Point(6, 302);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 50);
            this.one.TabIndex = 20;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.OliveDrab;
            this.calculate.FlatAppearance.BorderSize = 0;
            this.calculate.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculate.Location = new System.Drawing.Point(174, 358);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(50, 50);
            this.calculate.TabIndex = 27;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.point.FlatAppearance.BorderSize = 0;
            this.point.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.point.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(117, 358);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(50, 50);
            this.point.TabIndex = 26;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero.Location = new System.Drawing.Point(62, 358);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(50, 50);
            this.zero.TabIndex = 25;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Location = new System.Drawing.Point(6, 358);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 50);
            this.button20.TabIndex = 24;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // deleteLastNode
            // 
            this.deleteLastNode.BackColor = System.Drawing.Color.Gold;
            this.deleteLastNode.FlatAppearance.BorderSize = 0;
            this.deleteLastNode.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.deleteLastNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteLastNode.Location = new System.Drawing.Point(118, 134);
            this.deleteLastNode.Name = "deleteLastNode";
            this.deleteLastNode.Size = new System.Drawing.Size(50, 50);
            this.deleteLastNode.TabIndex = 29;
            this.deleteLastNode.Text = "<";
            this.deleteLastNode.UseVisualStyleBackColor = false;
            this.deleteLastNode.Click += new System.EventHandler(this.deleteLastNode_Click);
            // 
            // DataInput
            // 
            this.DataInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DataInput.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataInput.Location = new System.Drawing.Point(6, 35);
            this.DataInput.Name = "DataInput";
            this.DataInput.Size = new System.Drawing.Size(218, 40);
            this.DataInput.TabIndex = 36;
            this.DataInput.Text = "0";
            this.DataInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result.ForeColor = System.Drawing.SystemColors.GrayText;
            this.result.Location = new System.Drawing.Point(6, 83);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(218, 40);
            this.result.TabIndex = 37;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(229, 431);
            this.Controls.Add(this.result);
            this.Controls.Add(this.DataInput);
            this.Controls.Add(this.deleteLastNode);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.extraction);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.crush);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.clear);
            this.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(245, 470);
            this.MinimumSize = new System.Drawing.Size(225, 470);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button crush;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button extraction;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button deleteLastNode;
        private System.Windows.Forms.Label DataInput;
        private System.Windows.Forms.Label result;
    }
}

