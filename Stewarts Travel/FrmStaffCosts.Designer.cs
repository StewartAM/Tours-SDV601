namespace Stewarts_Travel
{
    partial class FrmStaffCosts
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
            this.txtStaffType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCostPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.Text = "Staff Cost";
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.Text = "Cost $";
            // 
            // txtCostName
            // 
            this.txtCostName.Location = new System.Drawing.Point(116, 76);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(48, 79);
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.Text = "Staff Name";
            // 
            // numCostPrice
            // 
            this.numCostPrice.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCostPrice.TabIndex = 3;
            this.numCostPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtStaffType
            // 
            this.txtStaffType.Location = new System.Drawing.Point(116, 107);
            this.txtStaffType.Name = "txtStaffType";
            this.txtStaffType.Size = new System.Drawing.Size(120, 20);
            this.txtStaffType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Staff Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "/day";
            // 
            // FrmStaffCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStaffType);
            this.Name = "FrmStaffCosts";
            this.Controls.SetChildIndex(this.numCostPrice, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCostName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtStaffType, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numCostPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStaffType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
