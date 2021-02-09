
namespace Variables_Practice
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
            this.Hockey = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            this.Carpet = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hockey
            // 
            this.Hockey.Location = new System.Drawing.Point(33, 41);
            this.Hockey.Name = "Hockey";
            this.Hockey.Size = new System.Drawing.Size(165, 99);
            this.Hockey.TabIndex = 0;
            this.Hockey.Text = "Hockey ";
            this.Hockey.UseVisualStyleBackColor = true;
            this.Hockey.Click += new System.EventHandler(this.Hockey_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(33, 210);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(165, 104);
            this.Area.TabIndex = 1;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // Carpet
            // 
            this.Carpet.Location = new System.Drawing.Point(33, 399);
            this.Carpet.Name = "Carpet";
            this.Carpet.Size = new System.Drawing.Size(165, 104);
            this.Carpet.TabIndex = 2;
            this.Carpet.Text = "Carpet";
            this.Carpet.UseVisualStyleBackColor = true;
            this.Carpet.Click += new System.EventHandler(this.Carpet_Click);
            // 
            // Bill
            // 
            this.Bill.Location = new System.Drawing.Point(33, 595);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(165, 104);
            this.Bill.TabIndex = 3;
            this.Bill.Text = "Bill";
            this.Bill.UseVisualStyleBackColor = true;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(243, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1058, 658);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Welcome to useless facts!";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1054, 658);
            this.label2.TabIndex = 5;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1054, 658);
            this.label3.TabIndex = 6;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1054, 658);
            this.label4.TabIndex = 7;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1054, 658);
            this.label5.TabIndex = 8;
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1344, 790);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.Carpet);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Hockey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hockey;
        private System.Windows.Forms.Button Area;
        private System.Windows.Forms.Button Carpet;
        private System.Windows.Forms.Button Bill;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

