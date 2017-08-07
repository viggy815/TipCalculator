namespace VigneroTipCalculator
{
    partial class TipCalcForm
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
            this.components = new System.ComponentModel.Container();
            this.gbTotals = new System.Windows.Forms.GroupBox();
            this.txtTotal20 = new System.Windows.Forms.TextBox();
            this.txtTotal15 = new System.Windows.Forms.TextBox();
            this.lblTotal20 = new System.Windows.Forms.Label();
            this.lblTotal15 = new System.Windows.Forms.Label();
            this.lblTip15 = new System.Windows.Forms.Label();
            this.lblTip20 = new System.Windows.Forms.Label();
            this.txtTip15 = new System.Windows.Forms.TextBox();
            this.txtTip20 = new System.Windows.Forms.TextBox();
            this.gbTipTotals = new System.Windows.Forms.GroupBox();
            this.lblTopArrow = new System.Windows.Forms.Label();
            this.lblBottomArrow = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.tipCalcToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.gbTotals.SuspendLayout();
            this.gbTipTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTotals
            // 
            this.gbTotals.Controls.Add(this.txtTotal20);
            this.gbTotals.Controls.Add(this.txtTotal15);
            this.gbTotals.Controls.Add(this.lblTotal20);
            this.gbTotals.Controls.Add(this.lblTotal15);
            this.gbTotals.Location = new System.Drawing.Point(299, 237);
            this.gbTotals.Name = "gbTotals";
            this.gbTotals.Size = new System.Drawing.Size(198, 100);
            this.gbTotals.TabIndex = 9;
            this.gbTotals.TabStop = false;
            this.gbTotals.Text = "Bill Totals w/Tip and taxes";
            // 
            // txtTotal20
            // 
            this.txtTotal20.Location = new System.Drawing.Point(90, 56);
            this.txtTotal20.Name = "txtTotal20";
            this.txtTotal20.ReadOnly = true;
            this.txtTotal20.Size = new System.Drawing.Size(100, 20);
            this.txtTotal20.TabIndex = 8;
            this.txtTotal20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal15
            // 
            this.txtTotal15.Location = new System.Drawing.Point(90, 19);
            this.txtTotal15.Name = "txtTotal15";
            this.txtTotal15.ReadOnly = true;
            this.txtTotal15.Size = new System.Drawing.Size(100, 20);
            this.txtTotal15.TabIndex = 7;
            this.txtTotal15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal20
            // 
            this.lblTotal20.AutoSize = true;
            this.lblTotal20.Location = new System.Drawing.Point(18, 59);
            this.lblTotal20.Name = "lblTotal20";
            this.lblTotal20.Size = new System.Drawing.Size(34, 13);
            this.lblTotal20.TabIndex = 5;
            this.lblTotal20.Text = "Total:";
            // 
            // lblTotal15
            // 
            this.lblTotal15.AutoSize = true;
            this.lblTotal15.Location = new System.Drawing.Point(18, 24);
            this.lblTotal15.Name = "lblTotal15";
            this.lblTotal15.Size = new System.Drawing.Size(34, 13);
            this.lblTotal15.TabIndex = 4;
            this.lblTotal15.Text = "Total:";
            // 
            // lblTip15
            // 
            this.lblTip15.AutoSize = true;
            this.lblTip15.Location = new System.Drawing.Point(18, 22);
            this.lblTip15.Name = "lblTip15";
            this.lblTip15.Size = new System.Drawing.Size(48, 13);
            this.lblTip15.TabIndex = 0;
            this.lblTip15.Text = "15% Tip:";
            // 
            // lblTip20
            // 
            this.lblTip20.AutoSize = true;
            this.lblTip20.Location = new System.Drawing.Point(18, 59);
            this.lblTip20.Name = "lblTip20";
            this.lblTip20.Size = new System.Drawing.Size(48, 13);
            this.lblTip20.TabIndex = 1;
            this.lblTip20.Text = "20% Tip:";
            // 
            // txtTip15
            // 
            this.txtTip15.Location = new System.Drawing.Point(94, 19);
            this.txtTip15.Name = "txtTip15";
            this.txtTip15.ReadOnly = true;
            this.txtTip15.Size = new System.Drawing.Size(100, 20);
            this.txtTip15.TabIndex = 5;
            this.txtTip15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTip20
            // 
            this.txtTip20.Location = new System.Drawing.Point(94, 56);
            this.txtTip20.Name = "txtTip20";
            this.txtTip20.ReadOnly = true;
            this.txtTip20.Size = new System.Drawing.Size(100, 20);
            this.txtTip20.TabIndex = 6;
            this.txtTip20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbTipTotals
            // 
            this.gbTipTotals.Controls.Add(this.txtTip15);
            this.gbTipTotals.Controls.Add(this.txtTip20);
            this.gbTipTotals.Controls.Add(this.lblTip15);
            this.gbTipTotals.Controls.Add(this.lblTip20);
            this.gbTipTotals.Location = new System.Drawing.Point(12, 237);
            this.gbTipTotals.Name = "gbTipTotals";
            this.gbTipTotals.Size = new System.Drawing.Size(200, 100);
            this.gbTipTotals.TabIndex = 10;
            this.gbTipTotals.TabStop = false;
            this.gbTipTotals.Text = "Tip Totals";
            // 
            // lblTopArrow
            // 
            this.lblTopArrow.AutoSize = true;
            this.lblTopArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTopArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopArrow.Location = new System.Drawing.Point(242, 259);
            this.lblTopArrow.Name = "lblTopArrow";
            this.lblTopArrow.Size = new System.Drawing.Size(30, 24);
            this.lblTopArrow.TabIndex = 13;
            this.lblTopArrow.Text = "→";
            // 
            // lblBottomArrow
            // 
            this.lblBottomArrow.AutoSize = true;
            this.lblBottomArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBottomArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomArrow.Location = new System.Drawing.Point(242, 296);
            this.lblBottomArrow.Name = "lblBottomArrow";
            this.lblBottomArrow.Size = new System.Drawing.Size(30, 24);
            this.lblBottomArrow.TabIndex = 14;
            this.lblBottomArrow.Text = "→";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(251, 37);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBillAmount.TabIndex = 0;
            this.tipCalcToolTips.SetToolTip(this.txtBillAmount, "Enter the bill amount before taxes");
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Location = new System.Drawing.Point(135, 40);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(90, 13);
            this.lblBillAmount.TabIndex = 12;
            this.lblBillAmount.Text = "Enter Bill Amount:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(225, 79);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.tipCalcToolTips.SetToolTip(this.btnCalculate, "Calculate the bill amount with tip and taxes");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.tipCalcToolTips.SetToolTip(this.btnClear, "Reset all amounts");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 137);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.tipCalcToolTips.SetToolTip(this.btnExit, "Exit Application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(222, 175);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(68, 13);
            this.lblTaxes.TabIndex = 11;
            this.lblTaxes.Text = "Taxes 5.75%";
            // 
            // txtTaxes
            // 
            this.txtTaxes.Location = new System.Drawing.Point(209, 191);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.ReadOnly = true;
            this.txtTaxes.Size = new System.Drawing.Size(100, 20);
            this.txtTaxes.TabIndex = 4;
            this.txtTaxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TipCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 349);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblBillAmount);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.lblBottomArrow);
            this.Controls.Add(this.lblTopArrow);
            this.Controls.Add(this.gbTipTotals);
            this.Controls.Add(this.gbTotals);
            this.Name = "TipCalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            this.gbTotals.ResumeLayout(false);
            this.gbTotals.PerformLayout();
            this.gbTipTotals.ResumeLayout(false);
            this.gbTipTotals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTotals;
        private System.Windows.Forms.TextBox txtTotal20;
        private System.Windows.Forms.TextBox txtTotal15;
        private System.Windows.Forms.Label lblTotal20;
        private System.Windows.Forms.Label lblTotal15;
        private System.Windows.Forms.Label lblTip15;
        private System.Windows.Forms.Label lblTip20;
        private System.Windows.Forms.TextBox txtTip15;
        private System.Windows.Forms.TextBox txtTip20;
        private System.Windows.Forms.GroupBox gbTipTotals;
        private System.Windows.Forms.Label lblTopArrow;
        private System.Windows.Forms.Label lblBottomArrow;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip tipCalcToolTips;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.TextBox txtTaxes;
    }
}

