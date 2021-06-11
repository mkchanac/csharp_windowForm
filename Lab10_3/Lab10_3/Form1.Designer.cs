
namespace Lab10_3
{
    partial class FileAccessApp
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
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.btnLargest = new System.Windows.Forms.Button();
            this.lblDisplayResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.Location = new System.Drawing.Point(250, 83);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(300, 50);
            this.btnAverage.TabIndex = 0;
            this.btnAverage.Text = "Display Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSmallest
            // 
            this.btnSmallest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallest.Location = new System.Drawing.Point(250, 152);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(300, 50);
            this.btnSmallest.TabIndex = 1;
            this.btnSmallest.Text = "Display Smallest Value";
            this.btnSmallest.UseVisualStyleBackColor = true;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // btnLargest
            // 
            this.btnLargest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargest.Location = new System.Drawing.Point(250, 224);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(300, 50);
            this.btnLargest.TabIndex = 2;
            this.btnLargest.Text = "Display Largest Value";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // lblDisplayResult
            // 
            this.lblDisplayResult.AutoSize = true;
            this.lblDisplayResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayResult.Location = new System.Drawing.Point(250, 329);
            this.lblDisplayResult.Name = "lblDisplayResult";
            this.lblDisplayResult.Size = new System.Drawing.Size(72, 25);
            this.lblDisplayResult.TabIndex = 3;
            this.lblDisplayResult.Text = "Result";
            // 
            // FileAccessApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayResult);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.btnSmallest);
            this.Controls.Add(this.btnAverage);
            this.Name = "FileAccessApp";
            this.Text = "File Access App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSmallest;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.Label lblDisplayResult;
    }
}

