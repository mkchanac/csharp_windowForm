
namespace Lab10_1
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
            this.lstBxBagStyle = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtBxQuan = new System.Windows.Forms.TextBox();
            this.lblBagStyle = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClearSelect = new System.Windows.Forms.Button();
            this.gpBxTypeShip = new System.Windows.Forms.GroupBox();
            this.rdBtnOverNight = new System.Windows.Forms.RadioButton();
            this.rdBtnThreeDay = new System.Windows.Forms.RadioButton();
            this.rdBtnStandard = new System.Windows.Forms.RadioButton();
            this.gpBxTypeShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxBagStyle
            // 
            this.lstBxBagStyle.FormattingEnabled = true;
            this.lstBxBagStyle.ItemHeight = 16;
            this.lstBxBagStyle.Items.AddRange(new object[] {
            "beaded --- $45.00",
            "fringed --- $25.00",
            "full decorative --- $50.00",
            "leather --- $80.00",
            "pirate design --- $40.00",
            "plain --- $20.00"});
            this.lstBxBagStyle.Location = new System.Drawing.Point(440, 35);
            this.lstBxBagStyle.Name = "lstBxBagStyle";
            this.lstBxBagStyle.Size = new System.Drawing.Size(253, 148);
            this.lstBxBagStyle.Sorted = true;
            this.lstBxBagStyle.TabIndex = 0;
            this.lstBxBagStyle.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(440, 186);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtBxQuan
            // 
            this.txtBxQuan.Location = new System.Drawing.Point(440, 206);
            this.txtBxQuan.Name = "txtBxQuan";
            this.txtBxQuan.Size = new System.Drawing.Size(100, 22);
            this.txtBxQuan.TabIndex = 2;
            // 
            // lblBagStyle
            // 
            this.lblBagStyle.AutoSize = true;
            this.lblBagStyle.Location = new System.Drawing.Point(440, 12);
            this.lblBagStyle.Name = "lblBagStyle";
            this.lblBagStyle.Size = new System.Drawing.Size(68, 17);
            this.lblBagStyle.TabIndex = 3;
            this.lblBagStyle.Text = "Bag Style";
            this.lblBagStyle.Click += new System.EventHandler(this.lblBagStyle_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(440, 244);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClearSelect
            // 
            this.btnClearSelect.Location = new System.Drawing.Point(588, 190);
            this.btnClearSelect.Name = "btnClearSelect";
            this.btnClearSelect.Size = new System.Drawing.Size(105, 42);
            this.btnClearSelect.TabIndex = 5;
            this.btnClearSelect.Text = "Clear Selection";
            this.btnClearSelect.UseVisualStyleBackColor = true;
            this.btnClearSelect.Click += new System.EventHandler(this.btnClearSelect_Click);
            // 
            // gpBxTypeShip
            // 
            this.gpBxTypeShip.Controls.Add(this.rdBtnStandard);
            this.gpBxTypeShip.Controls.Add(this.rdBtnThreeDay);
            this.gpBxTypeShip.Controls.Add(this.rdBtnOverNight);
            this.gpBxTypeShip.Location = new System.Drawing.Point(70, 103);
            this.gpBxTypeShip.Name = "gpBxTypeShip";
            this.gpBxTypeShip.Size = new System.Drawing.Size(283, 205);
            this.gpBxTypeShip.TabIndex = 6;
            this.gpBxTypeShip.TabStop = false;
            this.gpBxTypeShip.Text = "Type Of Shipping";
            // 
            // rdBtnOverNight
            // 
            this.rdBtnOverNight.AutoSize = true;
            this.rdBtnOverNight.Checked = true;
            this.rdBtnOverNight.Location = new System.Drawing.Point(16, 37);
            this.rdBtnOverNight.Name = "rdBtnOverNight";
            this.rdBtnOverNight.Size = new System.Drawing.Size(88, 21);
            this.rdBtnOverNight.TabIndex = 0;
            this.rdBtnOverNight.TabStop = true;
            this.rdBtnOverNight.Text = "overnight";
            this.rdBtnOverNight.UseVisualStyleBackColor = true;
            this.rdBtnOverNight.CheckedChanged += new System.EventHandler(this.rdBtnOverNight_CheckedChanged);
            this.rdBtnOverNight.Click += new System.EventHandler(this.rdBtnOverNight_Click);
            // 
            // rdBtnThreeDay
            // 
            this.rdBtnThreeDay.AutoSize = true;
            this.rdBtnThreeDay.Location = new System.Drawing.Point(16, 79);
            this.rdBtnThreeDay.Name = "rdBtnThreeDay";
            this.rdBtnThreeDay.Size = new System.Drawing.Size(89, 21);
            this.rdBtnThreeDay.TabIndex = 1;
            this.rdBtnThreeDay.TabStop = true;
            this.rdBtnThreeDay.Text = "three day";
            this.rdBtnThreeDay.UseVisualStyleBackColor = true;
            // 
            // rdBtnStandard
            // 
            this.rdBtnStandard.AutoSize = true;
            this.rdBtnStandard.Location = new System.Drawing.Point(16, 121);
            this.rdBtnStandard.Name = "rdBtnStandard";
            this.rdBtnStandard.Size = new System.Drawing.Size(85, 21);
            this.rdBtnStandard.TabIndex = 2;
            this.rdBtnStandard.TabStop = true;
            this.rdBtnStandard.Text = "standard";
            this.rdBtnStandard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpBxTypeShip);
            this.Controls.Add(this.btnClearSelect);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblBagStyle);
            this.Controls.Add(this.txtBxQuan);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lstBxBagStyle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpBxTypeShip.ResumeLayout(false);
            this.gpBxTypeShip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxBagStyle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtBxQuan;
        private System.Windows.Forms.Label lblBagStyle;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClearSelect;
        private System.Windows.Forms.GroupBox gpBxTypeShip;
        private System.Windows.Forms.RadioButton rdBtnStandard;
        private System.Windows.Forms.RadioButton rdBtnThreeDay;
        private System.Windows.Forms.RadioButton rdBtnOverNight;
    }
}

