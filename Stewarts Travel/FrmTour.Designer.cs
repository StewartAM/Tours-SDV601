namespace Stewarts_Travel
{
    partial class FrmTour
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
            this.lblTourCode = new System.Windows.Forms.Label();
            this.txtTourCode = new System.Windows.Forms.TextBox();
            this.btnEnterEditCosts = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.numMaxPassenger = new System.Windows.Forms.NumericUpDown();
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.numMarkUp = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTourDays = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalCosts = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPricePassenger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarkUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTourCode
            // 
            this.lblTourCode.AutoSize = true;
            this.lblTourCode.Location = new System.Drawing.Point(22, 39);
            this.lblTourCode.Name = "lblTourCode";
            this.lblTourCode.Size = new System.Drawing.Size(57, 13);
            this.lblTourCode.TabIndex = 0;
            this.lblTourCode.Text = "Tour Code";
            // 
            // txtTourCode
            // 
            this.txtTourCode.Location = new System.Drawing.Point(129, 36);
            this.txtTourCode.MaxLength = 10;
            this.txtTourCode.Name = "txtTourCode";
            this.txtTourCode.Size = new System.Drawing.Size(100, 20);
            this.txtTourCode.TabIndex = 1;
            this.txtTourCode.Leave += new System.EventHandler(this.txtTourCode_Leave);
            // 
            // btnEnterEditCosts
            // 
            this.btnEnterEditCosts.Location = new System.Drawing.Point(101, 341);
            this.btnEnterEditCosts.Name = "btnEnterEditCosts";
            this.btnEnterEditCosts.Size = new System.Drawing.Size(148, 23);
            this.btnEnterEditCosts.TabIndex = 2;
            this.btnEnterEditCosts.Text = "Enter or Edit Tour Costs";
            this.btnEnterEditCosts.UseVisualStyleBackColor = true;
            this.btnEnterEditCosts.Click += new System.EventHandler(this.btnEnterEditCosts_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tour Name";
            // 
            // txtTourName
            // 
            this.txtTourName.Location = new System.Drawing.Point(129, 63);
            this.txtTourName.MaxLength = 50;
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(200, 20);
            this.txtTourName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tour Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tour End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price / Passenger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max Passengers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter or Edit the Tour Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Travel Distance (km)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mark Up %";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(129, 89);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.Leave += new System.EventHandler(this.dtpStartDate_Leave);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(129, 116);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 4;
            this.dtpEndDate.Leave += new System.EventHandler(this.dtpEndDate_Leave);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(21, 413);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(146, 23);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numMaxPassenger
            // 
            this.numMaxPassenger.Location = new System.Drawing.Point(129, 168);
            this.numMaxPassenger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxPassenger.Name = "numMaxPassenger";
            this.numMaxPassenger.Size = new System.Drawing.Size(120, 20);
            this.numMaxPassenger.TabIndex = 5;
            this.numMaxPassenger.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numDistance
            // 
            this.numDistance.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDistance.Location = new System.Drawing.Point(129, 194);
            this.numDistance.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDistance.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(120, 20);
            this.numDistance.TabIndex = 6;
            this.numDistance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMarkUp
            // 
            this.numMarkUp.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMarkUp.Location = new System.Drawing.Point(129, 221);
            this.numMarkUp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMarkUp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMarkUp.Name = "numMarkUp";
            this.numMarkUp.Size = new System.Drawing.Size(120, 20);
            this.numMarkUp.TabIndex = 7;
            this.numMarkUp.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tour Days";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(101, 377);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(148, 23);
            this.btnCalculateTotal.TabIndex = 24;
            this.btnCalculateTotal.Text = "Calculate Totals";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total Costs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Total Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "(after Mark Up)";
            // 
            // lblTourDays
            // 
            this.lblTourDays.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTourDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourDays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTourDays.Location = new System.Drawing.Point(129, 146);
            this.lblTourDays.Name = "lblTourDays";
            this.lblTourDays.Size = new System.Drawing.Size(120, 20);
            this.lblTourDays.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(120, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(120, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(119, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "$";
            // 
            // lblTotalCosts
            // 
            this.lblTotalCosts.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTotalCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCosts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalCosts.Location = new System.Drawing.Point(129, 252);
            this.lblTotalCosts.Name = "lblTotalCosts";
            this.lblTotalCosts.Size = new System.Drawing.Size(120, 20);
            this.lblTotalCosts.TabIndex = 37;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalPrice.Location = new System.Drawing.Point(129, 281);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(120, 20);
            this.lblTotalPrice.TabIndex = 38;
            // 
            // lblPricePassenger
            // 
            this.lblPricePassenger.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPricePassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePassenger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPricePassenger.Location = new System.Drawing.Point(129, 311);
            this.lblPricePassenger.Name = "lblPricePassenger";
            this.lblPricePassenger.Size = new System.Drawing.Size(120, 20);
            this.lblPricePassenger.TabIndex = 39;
            // 
            // FrmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(348, 448);
            this.ControlBox = false;
            this.Controls.Add(this.lblPricePassenger);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalCosts);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTourDays);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numMarkUp);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.numMaxPassenger);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnterEditCosts);
            this.Controls.Add(this.txtTourCode);
            this.Controls.Add(this.lblTourCode);
            this.Name = "FrmTour";
            this.Text = "Tour Details";
            this.Enter += new System.EventHandler(this.btnOK_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarkUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTourCode;
        private System.Windows.Forms.TextBox txtTourCode;
        private System.Windows.Forms.Button btnEnterEditCosts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown numMaxPassenger;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.NumericUpDown numMarkUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTourDays;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalCosts;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPricePassenger;
    }
}