namespace MathsCount
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
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstEdge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirstEdge = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.lblEmptyDataField = new System.Windows.Forms.Label();
            this.lblEmptyDataPerimeter = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtLongEdge = new System.Windows.Forms.TextBox();
            this.lblLongEdge = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSquare.Location = new System.Drawing.Point(194, 42);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(96, 37);
            this.btnSquare.TabIndex = 0;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRectangle.Location = new System.Drawing.Point(426, 42);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(96, 37);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(326, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // txtFirstEdge
            // 
            this.txtFirstEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstEdge.Location = new System.Drawing.Point(184, 23);
            this.txtFirstEdge.Name = "txtFirstEdge";
            this.txtFirstEdge.Size = new System.Drawing.Size(96, 21);
            this.txtFirstEdge.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 5;
            // 
            // lblFirstEdge
            // 
            this.lblFirstEdge.AutoSize = true;
            this.lblFirstEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstEdge.Location = new System.Drawing.Point(53, 23);
            this.lblFirstEdge.Name = "lblFirstEdge";
            this.lblFirstEdge.Size = new System.Drawing.Size(86, 20);
            this.lblFirstEdge.TabIndex = 6;
            this.lblFirstEdge.Text = "First Edge:";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblField.Location = new System.Drawing.Point(53, 135);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(38, 20);
            this.lblField.TabIndex = 7;
            this.lblField.Text = "field";
            // 
            // lblEmptyDataField
            // 
            this.lblEmptyDataField.AutoSize = true;
            this.lblEmptyDataField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmptyDataField.Location = new System.Drawing.Point(146, 135);
            this.lblEmptyDataField.Name = "lblEmptyDataField";
            this.lblEmptyDataField.Size = new System.Drawing.Size(14, 20);
            this.lblEmptyDataField.TabIndex = 8;
            this.lblEmptyDataField.Text = "-";
            // 
            // lblEmptyDataPerimeter
            // 
            this.lblEmptyDataPerimeter.AutoSize = true;
            this.lblEmptyDataPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmptyDataPerimeter.Location = new System.Drawing.Point(146, 170);
            this.lblEmptyDataPerimeter.Name = "lblEmptyDataPerimeter";
            this.lblEmptyDataPerimeter.Size = new System.Drawing.Size(14, 20);
            this.lblEmptyDataPerimeter.TabIndex = 10;
            this.lblEmptyDataPerimeter.Text = "-";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPerimeter.Location = new System.Drawing.Point(53, 170);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(76, 20);
            this.lblPerimeter.TabIndex = 9;
            this.lblPerimeter.Text = "perimeter";
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCount.Location = new System.Drawing.Point(193, 101);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(72, 25);
            this.btnCount.TabIndex = 11;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtLongEdge
            // 
            this.txtLongEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLongEdge.Location = new System.Drawing.Point(184, 64);
            this.txtLongEdge.Name = "txtLongEdge";
            this.txtLongEdge.Size = new System.Drawing.Size(96, 21);
            this.txtLongEdge.TabIndex = 12;
            // 
            // lblLongEdge
            // 
            this.lblLongEdge.AutoSize = true;
            this.lblLongEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLongEdge.Location = new System.Drawing.Point(53, 65);
            this.lblLongEdge.Name = "lblLongEdge";
            this.lblLongEdge.Size = new System.Drawing.Size(91, 20);
            this.lblLongEdge.TabIndex = 13;
            this.lblLongEdge.Text = "Long Edge:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblFirstEdge);
            this.panel1.Controls.Add(this.lblLongEdge);
            this.panel1.Controls.Add(this.txtFirstEdge);
            this.panel1.Controls.Add(this.txtLongEdge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCount);
            this.panel1.Controls.Add(this.lblField);
            this.panel1.Controls.Add(this.lblEmptyDataPerimeter);
            this.panel1.Controls.Add(this.lblEmptyDataField);
            this.panel1.Controls.Add(this.lblPerimeter);
            this.panel1.Location = new System.Drawing.Point(194, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 220);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(193, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(755, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnSquare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstEdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFirstEdge;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblEmptyDataField;
        private System.Windows.Forms.Label lblEmptyDataPerimeter;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtLongEdge;
        private System.Windows.Forms.Label lblLongEdge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

