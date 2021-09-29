namespace PizzaProblem
{
    partial class FrmPizzaProblem
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
            this.LblBasePrice = new System.Windows.Forms.Label();
            this.LblSurcharge = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.TxtSurcharge = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpSize = new System.Windows.Forms.GroupBox();
            this.RdpXLarge = new System.Windows.Forms.RadioButton();
            this.RdpLarge = new System.Windows.Forms.RadioButton();
            this.RdpMedium = new System.Windows.Forms.RadioButton();
            this.RdpSmalll = new System.Windows.Forms.RadioButton();
            this.GrpType = new System.Windows.Forms.GroupBox();
            this.RdpDeluxe = new System.Windows.Forms.RadioButton();
            this.RdpStuffedCrust = new System.Windows.Forms.RadioButton();
            this.RdpMeat = new System.Windows.Forms.RadioButton();
            this.RdpVeggie = new System.Windows.Forms.RadioButton();
            this.RdpBasic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpSize.SuspendLayout();
            this.GrpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblBasePrice
            // 
            this.LblBasePrice.AutoSize = true;
            this.LblBasePrice.Location = new System.Drawing.Point(47, 75);
            this.LblBasePrice.Name = "LblBasePrice";
            this.LblBasePrice.Size = new System.Drawing.Size(58, 13);
            this.LblBasePrice.TabIndex = 0;
            this.LblBasePrice.Text = "Base Price";
            // 
            // LblSurcharge
            // 
            this.LblSurcharge.AutoSize = true;
            this.LblSurcharge.Location = new System.Drawing.Point(47, 112);
            this.LblSurcharge.Name = "LblSurcharge";
            this.LblSurcharge.Size = new System.Drawing.Size(79, 13);
            this.LblSurcharge.TabIndex = 1;
            this.LblSurcharge.Text = "Item Surcharge";
            this.LblSurcharge.Click += new System.EventHandler(this.LblSurcharge_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(50, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(50, 189);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(46, 13);
            this.LblQuantity.TabIndex = 3;
            this.LblQuantity.Text = "Quantity";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(50, 226);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(50, 266);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(50, 306);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(199, 75);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBasePrice.TabIndex = 7;
            // 
            // TxtSurcharge
            // 
            this.TxtSurcharge.Location = new System.Drawing.Point(199, 112);
            this.TxtSurcharge.Name = "TxtSurcharge";
            this.TxtSurcharge.Size = new System.Drawing.Size(100, 20);
            this.TxtSurcharge.TabIndex = 8;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(199, 150);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtPrice.TabIndex = 9;
            this.TxtPrice.TextChanged += new System.EventHandler(this.TxtPrice_TextChanged);
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(199, 189);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantity.TabIndex = 10;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(199, 226);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.TxtSubtotal.TabIndex = 11;
            // 
            // TxtTax
            // 
            this.TxtTax.Location = new System.Drawing.Point(199, 266);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.Size = new System.Drawing.Size(100, 20);
            this.TxtTax.TabIndex = 12;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(199, 306);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 13;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(420, 302);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 14;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Location = new System.Drawing.Point(420, 348);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.BtnNewOrder.TabIndex = 15;
            this.BtnNewOrder.Text = "New Order";
            this.BtnNewOrder.UseVisualStyleBackColor = true;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(612, 348);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 16;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GrpSize
            // 
            this.GrpSize.Controls.Add(this.RdpXLarge);
            this.GrpSize.Controls.Add(this.RdpLarge);
            this.GrpSize.Controls.Add(this.RdpMedium);
            this.GrpSize.Controls.Add(this.RdpSmalll);
            this.GrpSize.Location = new System.Drawing.Point(420, 75);
            this.GrpSize.Name = "GrpSize";
            this.GrpSize.Size = new System.Drawing.Size(115, 171);
            this.GrpSize.TabIndex = 17;
            this.GrpSize.TabStop = false;
            this.GrpSize.Text = "Size";
            // 
            // RdpXLarge
            // 
            this.RdpXLarge.AutoSize = true;
            this.RdpXLarge.Location = new System.Drawing.Point(6, 129);
            this.RdpXLarge.Name = "RdpXLarge";
            this.RdpXLarge.Size = new System.Drawing.Size(79, 17);
            this.RdpXLarge.TabIndex = 3;
            this.RdpXLarge.TabStop = true;
            this.RdpXLarge.Text = "Extra Large";
            this.RdpXLarge.UseVisualStyleBackColor = true;
            this.RdpXLarge.CheckedChanged += new System.EventHandler(this.RdpXLarge_CheckedChanged);
            // 
            // RdpLarge
            // 
            this.RdpLarge.AutoSize = true;
            this.RdpLarge.Location = new System.Drawing.Point(7, 92);
            this.RdpLarge.Name = "RdpLarge";
            this.RdpLarge.Size = new System.Drawing.Size(52, 17);
            this.RdpLarge.TabIndex = 2;
            this.RdpLarge.TabStop = true;
            this.RdpLarge.Text = "Large";
            this.RdpLarge.UseVisualStyleBackColor = true;
            this.RdpLarge.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // RdpMedium
            // 
            this.RdpMedium.AutoSize = true;
            this.RdpMedium.Location = new System.Drawing.Point(7, 54);
            this.RdpMedium.Name = "RdpMedium";
            this.RdpMedium.Size = new System.Drawing.Size(62, 17);
            this.RdpMedium.TabIndex = 1;
            this.RdpMedium.TabStop = true;
            this.RdpMedium.Text = "Medium";
            this.RdpMedium.UseVisualStyleBackColor = true;
            this.RdpMedium.CheckedChanged += new System.EventHandler(this.RdpMedium_CheckedChanged);
            // 
            // RdpSmalll
            // 
            this.RdpSmalll.AutoSize = true;
            this.RdpSmalll.Location = new System.Drawing.Point(7, 20);
            this.RdpSmalll.Name = "RdpSmalll";
            this.RdpSmalll.Size = new System.Drawing.Size(50, 17);
            this.RdpSmalll.TabIndex = 0;
            this.RdpSmalll.TabStop = true;
            this.RdpSmalll.Text = "Small";
            this.RdpSmalll.UseVisualStyleBackColor = true;
            this.RdpSmalll.CheckedChanged += new System.EventHandler(this.RdpSmalll_CheckedChanged);
            // 
            // GrpType
            // 
            this.GrpType.Controls.Add(this.RdpDeluxe);
            this.GrpType.Controls.Add(this.RdpStuffedCrust);
            this.GrpType.Controls.Add(this.RdpMeat);
            this.GrpType.Controls.Add(this.RdpVeggie);
            this.GrpType.Controls.Add(this.RdpBasic);
            this.GrpType.Location = new System.Drawing.Point(612, 75);
            this.GrpType.Name = "GrpType";
            this.GrpType.Size = new System.Drawing.Size(140, 204);
            this.GrpType.TabIndex = 18;
            this.GrpType.TabStop = false;
            this.GrpType.Text = "Type";
            // 
            // RdpDeluxe
            // 
            this.RdpDeluxe.AutoSize = true;
            this.RdpDeluxe.Location = new System.Drawing.Point(6, 164);
            this.RdpDeluxe.Name = "RdpDeluxe";
            this.RdpDeluxe.Size = new System.Drawing.Size(58, 17);
            this.RdpDeluxe.TabIndex = 4;
            this.RdpDeluxe.TabStop = true;
            this.RdpDeluxe.Text = "Deluxe";
            this.RdpDeluxe.UseVisualStyleBackColor = true;
            this.RdpDeluxe.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // RdpStuffedCrust
            // 
            this.RdpStuffedCrust.AutoSize = true;
            this.RdpStuffedCrust.Location = new System.Drawing.Point(7, 129);
            this.RdpStuffedCrust.Name = "RdpStuffedCrust";
            this.RdpStuffedCrust.Size = new System.Drawing.Size(86, 17);
            this.RdpStuffedCrust.TabIndex = 3;
            this.RdpStuffedCrust.TabStop = true;
            this.RdpStuffedCrust.Text = "Stuffed Crust";
            this.RdpStuffedCrust.UseVisualStyleBackColor = true;
            this.RdpStuffedCrust.CheckedChanged += new System.EventHandler(this.RdpStuffedCrust_CheckedChanged);
            // 
            // RdpMeat
            // 
            this.RdpMeat.AutoSize = true;
            this.RdpMeat.Location = new System.Drawing.Point(7, 92);
            this.RdpMeat.Name = "RdpMeat";
            this.RdpMeat.Size = new System.Drawing.Size(49, 17);
            this.RdpMeat.TabIndex = 2;
            this.RdpMeat.TabStop = true;
            this.RdpMeat.Text = "Meat";
            this.RdpMeat.UseVisualStyleBackColor = true;
            this.RdpMeat.CheckedChanged += new System.EventHandler(this.RdpMeat_CheckedChanged);
            // 
            // RdpVeggie
            // 
            this.RdpVeggie.AutoSize = true;
            this.RdpVeggie.Location = new System.Drawing.Point(7, 54);
            this.RdpVeggie.Name = "RdpVeggie";
            this.RdpVeggie.Size = new System.Drawing.Size(58, 17);
            this.RdpVeggie.TabIndex = 1;
            this.RdpVeggie.TabStop = true;
            this.RdpVeggie.Text = "Veggie";
            this.RdpVeggie.UseVisualStyleBackColor = true;
            this.RdpVeggie.CheckedChanged += new System.EventHandler(this.RdpVeggie_CheckedChanged);
            // 
            // RdpBasic
            // 
            this.RdpBasic.AutoSize = true;
            this.RdpBasic.Location = new System.Drawing.Point(7, 20);
            this.RdpBasic.Name = "RdpBasic";
            this.RdpBasic.Size = new System.Drawing.Size(51, 17);
            this.RdpBasic.TabIndex = 0;
            this.RdpBasic.TabStop = true;
            this.RdpBasic.Text = "Basic";
            this.RdpBasic.UseVisualStyleBackColor = true;
            this.RdpBasic.CheckedChanged += new System.EventHandler(this.RdpBasic_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "A1 Pizza Menu";
            // 
            // FrmPizzaProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrpType);
            this.Controls.Add(this.GrpSize);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnNewOrder);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtTax);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtSurcharge);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.LblSurcharge);
            this.Controls.Add(this.LblBasePrice);
            this.Name = "FrmPizzaProblem";
            this.Text = "A1 Pizza";
            this.Load += new System.EventHandler(this.FrmPizzaProblem_Load);
            this.GrpSize.ResumeLayout(false);
            this.GrpSize.PerformLayout();
            this.GrpType.ResumeLayout(false);
            this.GrpType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBasePrice;
        private System.Windows.Forms.Label LblSurcharge;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox TxtSurcharge;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GrpSize;
        private System.Windows.Forms.RadioButton RdpXLarge;
        private System.Windows.Forms.RadioButton RdpLarge;
        private System.Windows.Forms.RadioButton RdpMedium;
        private System.Windows.Forms.RadioButton RdpSmalll;
        private System.Windows.Forms.GroupBox GrpType;
        private System.Windows.Forms.RadioButton RdpDeluxe;
        private System.Windows.Forms.RadioButton RdpStuffedCrust;
        private System.Windows.Forms.RadioButton RdpMeat;
        private System.Windows.Forms.RadioButton RdpVeggie;
        private System.Windows.Forms.RadioButton RdpBasic;
        private System.Windows.Forms.Label label1;
    }
}

