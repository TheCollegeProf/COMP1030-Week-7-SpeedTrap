namespace speedTrapTest
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSpeedLimit = new System.Windows.Forms.TextBox();
            this.txtCar1 = new System.Windows.Forms.TextBox();
            this.txtCar2 = new System.Windows.Forms.TextBox();
            this.txtCar3 = new System.Windows.Forms.TextBox();
            this.txtCar4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCar1 = new System.Windows.Forms.Label();
            this.lblCar2 = new System.Windows.Forms.Label();
            this.lblCar3 = new System.Windows.Forms.Label();
            this.lblCar4 = new System.Windows.Forms.Label();
            this.lblAverageSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(134, 254);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSpeedLimit
            // 
            this.txtSpeedLimit.Location = new System.Drawing.Point(134, 48);
            this.txtSpeedLimit.Name = "txtSpeedLimit";
            this.txtSpeedLimit.Size = new System.Drawing.Size(100, 20);
            this.txtSpeedLimit.TabIndex = 1;
            // 
            // txtCar1
            // 
            this.txtCar1.Location = new System.Drawing.Point(134, 91);
            this.txtCar1.Name = "txtCar1";
            this.txtCar1.Size = new System.Drawing.Size(100, 20);
            this.txtCar1.TabIndex = 2;
            // 
            // txtCar2
            // 
            this.txtCar2.Location = new System.Drawing.Point(134, 128);
            this.txtCar2.Name = "txtCar2";
            this.txtCar2.Size = new System.Drawing.Size(100, 20);
            this.txtCar2.TabIndex = 3;
            // 
            // txtCar3
            // 
            this.txtCar3.Location = new System.Drawing.Point(134, 166);
            this.txtCar3.Name = "txtCar3";
            this.txtCar3.Size = new System.Drawing.Size(100, 20);
            this.txtCar3.TabIndex = 4;
            // 
            // txtCar4
            // 
            this.txtCar4.Location = new System.Drawing.Point(134, 203);
            this.txtCar4.Name = "txtCar4";
            this.txtCar4.Size = new System.Drawing.Size(100, 20);
            this.txtCar4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Speed Limit";
            // 
            // lblCar1
            // 
            this.lblCar1.AutoSize = true;
            this.lblCar1.Location = new System.Drawing.Point(274, 97);
            this.lblCar1.Name = "lblCar1";
            this.lblCar1.Size = new System.Drawing.Size(0, 13);
            this.lblCar1.TabIndex = 7;
            // 
            // lblCar2
            // 
            this.lblCar2.AutoSize = true;
            this.lblCar2.Location = new System.Drawing.Point(274, 134);
            this.lblCar2.Name = "lblCar2";
            this.lblCar2.Size = new System.Drawing.Size(0, 13);
            this.lblCar2.TabIndex = 8;
            // 
            // lblCar3
            // 
            this.lblCar3.AutoSize = true;
            this.lblCar3.Location = new System.Drawing.Point(274, 172);
            this.lblCar3.Name = "lblCar3";
            this.lblCar3.Size = new System.Drawing.Size(0, 13);
            this.lblCar3.TabIndex = 9;
            // 
            // lblCar4
            // 
            this.lblCar4.AutoSize = true;
            this.lblCar4.Location = new System.Drawing.Point(277, 209);
            this.lblCar4.Name = "lblCar4";
            this.lblCar4.Size = new System.Drawing.Size(0, 13);
            this.lblCar4.TabIndex = 10;
            // 
            // lblAverageSpeed
            // 
            this.lblAverageSpeed.AutoSize = true;
            this.lblAverageSpeed.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageSpeed.Location = new System.Drawing.Point(510, 116);
            this.lblAverageSpeed.Name = "lblAverageSpeed";
            this.lblAverageSpeed.Size = new System.Drawing.Size(0, 69);
            this.lblAverageSpeed.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Average Speed";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(499, 206);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 13);
            this.lblAverage.TabIndex = 13;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(230, 254);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAverageSpeed);
            this.Controls.Add(this.lblCar4);
            this.Controls.Add(this.lblCar3);
            this.Controls.Add(this.lblCar2);
            this.Controls.Add(this.lblCar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCar4);
            this.Controls.Add(this.txtCar3);
            this.Controls.Add(this.txtCar2);
            this.Controls.Add(this.txtCar1);
            this.Controls.Add(this.txtSpeedLimit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSpeedLimit;
        private System.Windows.Forms.TextBox txtCar1;
        private System.Windows.Forms.TextBox txtCar2;
        private System.Windows.Forms.TextBox txtCar3;
        private System.Windows.Forms.TextBox txtCar4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCar1;
        private System.Windows.Forms.Label lblCar2;
        private System.Windows.Forms.Label lblCar3;
        private System.Windows.Forms.Label lblCar4;
        private System.Windows.Forms.Label lblAverageSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnRestart;
    }
}

