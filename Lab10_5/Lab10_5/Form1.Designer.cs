
namespace Lab10_5
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxNum = new System.Windows.Forms.TextBox();
            this.txtBxPay = new System.Windows.Forms.TextBox();
            this.txtBxHours = new System.Windows.Forms.TextBox();
            this.txtBxTotal = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.txtBxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(108, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(156, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(108, 69);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(173, 25);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Employee Number";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(108, 108);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(91, 25);
            this.lblPay.TabIndex = 2;
            this.lblPay.Text = "Pay Rate";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(108, 147);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(138, 25);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Hours Wokred";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(108, 186);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(184, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total amount of pay";
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(108, 254);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(250, 50);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute and Store";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxName.Location = new System.Drawing.Point(318, 30);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(300, 30);
            this.txtBxName.TabIndex = 6;
            // 
            // txtBxNum
            // 
            this.txtBxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNum.Location = new System.Drawing.Point(318, 69);
            this.txtBxNum.Name = "txtBxNum";
            this.txtBxNum.Size = new System.Drawing.Size(300, 30);
            this.txtBxNum.TabIndex = 7;
            // 
            // txtBxPay
            // 
            this.txtBxPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPay.Location = new System.Drawing.Point(318, 108);
            this.txtBxPay.Name = "txtBxPay";
            this.txtBxPay.Size = new System.Drawing.Size(300, 30);
            this.txtBxPay.TabIndex = 8;
            // 
            // txtBxHours
            // 
            this.txtBxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxHours.Location = new System.Drawing.Point(318, 147);
            this.txtBxHours.Name = "txtBxHours";
            this.txtBxHours.Size = new System.Drawing.Size(300, 30);
            this.txtBxHours.TabIndex = 9;
            // 
            // txtBxTotal
            // 
            this.txtBxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTotal.Location = new System.Drawing.Point(318, 186);
            this.txtBxTotal.Name = "txtBxTotal";
            this.txtBxTotal.ReadOnly = true;
            this.txtBxTotal.Size = new System.Drawing.Size(300, 30);
            this.txtBxTotal.TabIndex = 10;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.Location = new System.Drawing.Point(382, 254);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(250, 50);
            this.btnRetrieve.TabIndex = 11;
            this.btnRetrieve.Text = "Retrieve and Display";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // txtBxDisplay
            // 
            this.txtBxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDisplay.Location = new System.Drawing.Point(108, 345);
            this.txtBxDisplay.Multiline = true;
            this.txtBxDisplay.Name = "txtBxDisplay";
            this.txtBxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxDisplay.Size = new System.Drawing.Size(537, 223);
            this.txtBxDisplay.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.txtBxDisplay);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.txtBxTotal);
            this.Controls.Add(this.txtBxHours);
            this.Controls.Add(this.txtBxPay);
            this.Controls.Add(this.txtBxNum);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxNum;
        private System.Windows.Forms.TextBox txtBxPay;
        private System.Windows.Forms.TextBox txtBxHours;
        private System.Windows.Forms.TextBox txtBxTotal;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.TextBox txtBxDisplay;
    }
}

