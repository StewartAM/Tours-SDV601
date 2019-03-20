namespace Stewarts_Travel
{
    partial class FrmCostsList
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditCosts = new System.Windows.Forms.Button();
            this.lblTourName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbCosts = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEnterNewCosts = new System.Windows.Forms.Button();
            this.btnDeleteCosts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCostType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter or Edit the Tours Costs";
            // 
            // btnEditCosts
            // 
            this.btnEditCosts.Location = new System.Drawing.Point(233, 276);
            this.btnEditCosts.Name = "btnEditCosts";
            this.btnEditCosts.Size = new System.Drawing.Size(121, 23);
            this.btnEditCosts.TabIndex = 2;
            this.btnEditCosts.Text = "Edit Costs";
            this.btnEditCosts.UseVisualStyleBackColor = true;
            this.btnEditCosts.Click += new System.EventHandler(this.btnEditCosts_Click);
            // 
            // lblTourName
            // 
            this.lblTourName.AutoSize = true;
            this.lblTourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourName.Location = new System.Drawing.Point(158, 57);
            this.lblTourName.Name = "lblTourName";
            this.lblTourName.Size = new System.Drawing.Size(0, 16);
            this.lblTourName.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(311, 346);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbCosts
            // 
            this.lbCosts.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCosts.FormattingEnabled = true;
            this.lbCosts.ItemHeight = 14;
            this.lbCosts.Location = new System.Drawing.Point(42, 108);
            this.lbCosts.Name = "lbCosts";
            this.lbCosts.Size = new System.Drawing.Size(344, 130);
            this.lbCosts.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(42, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit Costs";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnEnterNewCosts
            // 
            this.btnEnterNewCosts.CausesValidation = false;
            this.btnEnterNewCosts.Location = new System.Drawing.Point(233, 247);
            this.btnEnterNewCosts.Name = "btnEnterNewCosts";
            this.btnEnterNewCosts.Size = new System.Drawing.Size(121, 23);
            this.btnEnterNewCosts.TabIndex = 14;
            this.btnEnterNewCosts.Text = "Enter New Costs";
            this.btnEnterNewCosts.UseVisualStyleBackColor = true;
            this.btnEnterNewCosts.Click += new System.EventHandler(this.btnEnterNewCosts_Click);
            // 
            // btnDeleteCosts
            // 
            this.btnDeleteCosts.Location = new System.Drawing.Point(233, 305);
            this.btnDeleteCosts.Name = "btnDeleteCosts";
            this.btnDeleteCosts.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteCosts.TabIndex = 23;
            this.btnDeleteCosts.Text = "Delete Costs ";
            this.btnDeleteCosts.UseVisualStyleBackColor = true;
            this.btnDeleteCosts.Click += new System.EventHandler(this.btnDeleteCosts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cost Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Input Cost";
            // 
            // cbCostType
            // 
            this.cbCostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostType.FormattingEnabled = true;
            this.cbCostType.Location = new System.Drawing.Point(91, 247);
            this.cbCostType.Name = "cbCostType";
            this.cbCostType.Size = new System.Drawing.Size(121, 21);
            this.cbCostType.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Staff Type";
            // 
            // FrmCostsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(429, 382);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCostType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteCosts);
            this.Controls.Add(this.btnEnterNewCosts);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbCosts);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTourName);
            this.Controls.Add(this.btnEditCosts);
            this.Controls.Add(this.label1);
            this.Name = "FrmCostsList";
            this.Text = "Tour Costs List";
            this.Load += new System.EventHandler(this.FrmCostsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditCosts;
        private System.Windows.Forms.Label lblTourName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbCosts;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEnterNewCosts;
        private System.Windows.Forms.Button btnDeleteCosts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCostType;
        private System.Windows.Forms.Label label2;
    }
}