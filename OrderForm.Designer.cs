namespace pizza
{
    partial class OrderForm
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
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.grbCrust = new System.Windows.Forms.GroupBox();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkCapsicum = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.grbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdTakeout = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.labForTotalPrice = new System.Windows.Forms.Label();
            this.labForWhereToEat = new System.Windows.Forms.Label();
            this.labForCrustType = new System.Windows.Forms.Label();
            this.labForToppings = new System.Windows.Forms.Label();
            this.labForSize = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbSize.SuspendLayout();
            this.grbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.grbWhereToEat.SuspendLayout();
            this.grbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.rdLarg);
            this.grbSize.Controls.Add(this.rdMedium);
            this.grbSize.Controls.Add(this.rdSmall);
            this.grbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSize.Location = new System.Drawing.Point(51, 35);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(224, 232);
            this.grbSize.TabIndex = 0;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Location = new System.Drawing.Point(27, 164);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(65, 28);
            this.rdLarg.TabIndex = 2;
            this.rdLarg.Tag = "25";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(27, 106);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(97, 28);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.Tag = "15";
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Checked = true;
            this.rdSmall.Location = new System.Drawing.Point(27, 48);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(74, 28);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "10";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // grbCrust
            // 
            this.grbCrust.Controls.Add(this.rdThick);
            this.grbCrust.Controls.Add(this.rdThin);
            this.grbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrust.Location = new System.Drawing.Point(51, 297);
            this.grbCrust.Name = "grbCrust";
            this.grbCrust.Size = new System.Drawing.Size(224, 201);
            this.grbCrust.TabIndex = 1;
            this.grbCrust.TabStop = false;
            this.grbCrust.Text = "Crust Type";
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(27, 93);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(122, 28);
            this.rdThick.TabIndex = 4;
            this.rdThick.Tag = "7";
            this.rdThick.Text = "Thick Crust";
            this.rdThick.UseVisualStyleBackColor = true;
            this.rdThick.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Checked = true;
            this.rdThin.Location = new System.Drawing.Point(27, 40);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(114, 28);
            this.rdThin.TabIndex = 3;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "1";
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkCapsicum);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushroom);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(399, 35);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(390, 232);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkCapsicum
            // 
            this.chkCapsicum.AutoSize = true;
            this.chkCapsicum.Location = new System.Drawing.Point(193, 145);
            this.chkCapsicum.Name = "chkCapsicum";
            this.chkCapsicum.Size = new System.Drawing.Size(113, 28);
            this.chkCapsicum.TabIndex = 5;
            this.chkCapsicum.Tag = "1";
            this.chkCapsicum.Text = "Capsicum";
            this.chkCapsicum.UseVisualStyleBackColor = true;
            this.chkCapsicum.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(193, 96);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(81, 28);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "4";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(193, 42);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(81, 28);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "1";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(35, 145);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(113, 28);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "1";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(35, 96);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(120, 28);
            this.chkMushroom.TabIndex = 1;
            this.chkMushroom.Tag = "4";
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(35, 42);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(143, 28);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "4";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // grbWhereToEat
            // 
            this.grbWhereToEat.Controls.Add(this.rdTakeout);
            this.grbWhereToEat.Controls.Add(this.rdEatIn);
            this.grbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWhereToEat.Location = new System.Drawing.Point(399, 308);
            this.grbWhereToEat.Name = "grbWhereToEat";
            this.grbWhereToEat.Size = new System.Drawing.Size(390, 116);
            this.grbWhereToEat.TabIndex = 2;
            this.grbWhereToEat.TabStop = false;
            this.grbWhereToEat.Text = "Where To Eat";
            // 
            // rdTakeout
            // 
            this.rdTakeout.AutoSize = true;
            this.rdTakeout.Location = new System.Drawing.Point(193, 43);
            this.rdTakeout.Name = "rdTakeout";
            this.rdTakeout.Size = new System.Drawing.Size(101, 28);
            this.rdTakeout.TabIndex = 3;
            this.rdTakeout.Text = "Take out";
            this.rdTakeout.UseVisualStyleBackColor = true;
            this.rdTakeout.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Checked = true;
            this.rdEatIn.Location = new System.Drawing.Point(35, 43);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(75, 28);
            this.rdEatIn.TabIndex = 3;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat in";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.UpdateOrderSummary);
            // 
            // grbSummary
            // 
            this.grbSummary.Controls.Add(this.labForTotalPrice);
            this.grbSummary.Controls.Add(this.labForWhereToEat);
            this.grbSummary.Controls.Add(this.labForCrustType);
            this.grbSummary.Controls.Add(this.labForToppings);
            this.grbSummary.Controls.Add(this.labForSize);
            this.grbSummary.Controls.Add(this.labTotalPrice);
            this.grbSummary.Controls.Add(this.labWhereToEat);
            this.grbSummary.Controls.Add(this.labCrustType);
            this.grbSummary.Controls.Add(this.labToppings);
            this.grbSummary.Controls.Add(this.labSize);
            this.grbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSummary.Location = new System.Drawing.Point(829, 35);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(390, 536);
            this.grbSummary.TabIndex = 2;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "Order Summary";
            // 
            // labForTotalPrice
            // 
            this.labForTotalPrice.AutoSize = true;
            this.labForTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labForTotalPrice.ForeColor = System.Drawing.Color.RosyBrown;
            this.labForTotalPrice.Location = new System.Drawing.Point(188, 450);
            this.labForTotalPrice.Name = "labForTotalPrice";
            this.labForTotalPrice.Size = new System.Drawing.Size(62, 42);
            this.labForTotalPrice.TabIndex = 9;
            this.labForTotalPrice.Text = "0$";
            // 
            // labForWhereToEat
            // 
            this.labForWhereToEat.AutoSize = true;
            this.labForWhereToEat.Location = new System.Drawing.Point(206, 346);
            this.labForWhereToEat.Name = "labForWhereToEat";
            this.labForWhereToEat.Size = new System.Drawing.Size(0, 24);
            this.labForWhereToEat.TabIndex = 8;
            this.labForWhereToEat.Tag = "10";
            // 
            // labForCrustType
            // 
            this.labForCrustType.AutoSize = true;
            this.labForCrustType.Location = new System.Drawing.Point(191, 262);
            this.labForCrustType.Name = "labForCrustType";
            this.labForCrustType.Size = new System.Drawing.Size(0, 24);
            this.labForCrustType.TabIndex = 7;
            // 
            // labForToppings
            // 
            this.labForToppings.Location = new System.Drawing.Point(46, 180);
            this.labForToppings.Name = "labForToppings";
            this.labForToppings.Size = new System.Drawing.Size(338, 70);
            this.labForToppings.TabIndex = 6;
            this.labForToppings.UseMnemonic = false;
            this.labForToppings.UseWaitCursor = true;
            // 
            // labForSize
            // 
            this.labForSize.AutoSize = true;
            this.labForSize.Location = new System.Drawing.Point(110, 65);
            this.labForSize.Name = "labForSize";
            this.labForSize.Size = new System.Drawing.Size(0, 24);
            this.labForSize.TabIndex = 5;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Location = new System.Drawing.Point(51, 438);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(104, 24);
            this.labTotalPrice.TabIndex = 4;
            this.labTotalPrice.Text = "Total Price:";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Location = new System.Drawing.Point(51, 346);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(132, 24);
            this.labWhereToEat.TabIndex = 3;
            this.labWhereToEat.Text = "Where To Eat:";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Location = new System.Drawing.Point(51, 262);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(111, 24);
            this.labCrustType.TabIndex = 2;
            this.labCrustType.Text = "Crust Type: ";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Location = new System.Drawing.Point(51, 145);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(95, 24);
            this.labToppings.TabIndex = 1;
            this.labToppings.Text = "Toppings:";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(51, 62);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(51, 24);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(399, 473);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(132, 50);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(657, 473);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 50);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 583);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grbSummary);
            this.Controls.Add(this.grbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.grbCrust);
            this.Controls.Add(this.grbSize);
            this.Name = "OrderForm";
            this.Text = "Order Your Pizza";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbCrust.ResumeLayout(false);
            this.grbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.grbWhereToEat.ResumeLayout(false);
            this.grbWhereToEat.PerformLayout();
            this.grbSummary.ResumeLayout(false);
            this.grbSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.GroupBox grbCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox grbWhereToEat;
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.CheckBox chkCapsicum;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.RadioButton rdTakeout;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label labForSize;
        private System.Windows.Forms.Label labForToppings;
        private System.Windows.Forms.Label labForCrustType;
        private System.Windows.Forms.Label labForWhereToEat;
        private System.Windows.Forms.Label labForTotalPrice;
    }
}