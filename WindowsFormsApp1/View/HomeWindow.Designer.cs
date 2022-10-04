namespace WindowsFormsApp1.View
{
    partial class HomeWindow
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
            this.oilLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.quantityRadioB = new System.Windows.Forms.RadioButton();
            this.moneyRadiob = new System.Windows.Forms.RadioButton();
            this.sumpriceLbl = new System.Windows.Forms.Label();
            this.petrolCombob = new System.Windows.Forms.ComboBox();
            this.priceTxtb = new System.Windows.Forms.TextBox();
            this.quantityTxtb = new System.Windows.Forms.TextBox();
            this.moneyTxtb = new System.Windows.Forms.TextBox();
            this.sumpriceTxtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.chechListB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oil Station";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oilLbl
            // 
            this.oilLbl.AutoSize = true;
            this.oilLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oilLbl.Location = new System.Drawing.Point(85, 148);
            this.oilLbl.Name = "oilLbl";
            this.oilLbl.Size = new System.Drawing.Size(91, 31);
            this.oilLbl.TabIndex = 1;
            this.oilLbl.Text = "Petrol";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLbl.Location = new System.Drawing.Point(85, 217);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(81, 31);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "Price";
            // 
            // quantityRadioB
            // 
            this.quantityRadioB.AutoSize = true;
            this.quantityRadioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityRadioB.Location = new System.Drawing.Point(91, 293);
            this.quantityRadioB.Name = "quantityRadioB";
            this.quantityRadioB.Size = new System.Drawing.Size(142, 35);
            this.quantityRadioB.TabIndex = 2;
            this.quantityRadioB.TabStop = true;
            this.quantityRadioB.Text = "Quantity";
            this.quantityRadioB.UseVisualStyleBackColor = true;
            this.quantityRadioB.CheckedChanged += new System.EventHandler(this.quantityRadioB_CheckedChanged);
            // 
            // moneyRadiob
            // 
            this.moneyRadiob.AutoSize = true;
            this.moneyRadiob.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyRadiob.Location = new System.Drawing.Point(91, 361);
            this.moneyRadiob.Name = "moneyRadiob";
            this.moneyRadiob.Size = new System.Drawing.Size(118, 35);
            this.moneyRadiob.TabIndex = 2;
            this.moneyRadiob.TabStop = true;
            this.moneyRadiob.Text = "Money";
            this.moneyRadiob.UseVisualStyleBackColor = true;
            this.moneyRadiob.CheckedChanged += new System.EventHandler(this.moneyRadiob_CheckedChanged);
            // 
            // sumpriceLbl
            // 
            this.sumpriceLbl.AutoSize = true;
            this.sumpriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumpriceLbl.Location = new System.Drawing.Point(85, 436);
            this.sumpriceLbl.Name = "sumpriceLbl";
            this.sumpriceLbl.Size = new System.Drawing.Size(147, 31);
            this.sumpriceLbl.TabIndex = 1;
            this.sumpriceLbl.Text = "Sum Price";
            // 
            // petrolCombob
            // 
            this.petrolCombob.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolCombob.FormattingEnabled = true;
            this.petrolCombob.Location = new System.Drawing.Point(291, 140);
            this.petrolCombob.Name = "petrolCombob";
            this.petrolCombob.Size = new System.Drawing.Size(219, 39);
            this.petrolCombob.TabIndex = 3;
            this.petrolCombob.SelectedIndexChanged += new System.EventHandler(this.petrolCombob_SelectedIndexChanged);
            // 
            // priceTxtb
            // 
            this.priceTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxtb.Location = new System.Drawing.Point(291, 214);
            this.priceTxtb.Name = "priceTxtb";
            this.priceTxtb.Size = new System.Drawing.Size(219, 38);
            this.priceTxtb.TabIndex = 4;
            // 
            // quantityTxtb
            // 
            this.quantityTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTxtb.Location = new System.Drawing.Point(291, 293);
            this.quantityTxtb.Name = "quantityTxtb";
            this.quantityTxtb.Size = new System.Drawing.Size(219, 38);
            this.quantityTxtb.TabIndex = 4;
            this.quantityTxtb.TextChanged += new System.EventHandler(this.quantityTxtb_TextChanged);
            // 
            // moneyTxtb
            // 
            this.moneyTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyTxtb.Location = new System.Drawing.Point(291, 360);
            this.moneyTxtb.Name = "moneyTxtb";
            this.moneyTxtb.Size = new System.Drawing.Size(219, 38);
            this.moneyTxtb.TabIndex = 4;
            this.moneyTxtb.TextChanged += new System.EventHandler(this.moneyTxtb_TextChanged);
            // 
            // sumpriceTxtb
            // 
            this.sumpriceTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumpriceTxtb.Location = new System.Drawing.Point(91, 482);
            this.sumpriceTxtb.Name = "sumpriceTxtb";
            this.sumpriceTxtb.Size = new System.Drawing.Size(222, 80);
            this.sumpriceTxtb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(516, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "USD";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(516, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "L.";
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBtn.Location = new System.Drawing.Point(873, 630);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(205, 78);
            this.checkBtn.TabIndex = 5;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // chechListB
            // 
            this.chechListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chechListB.FormattingEnabled = true;
            this.chechListB.ItemHeight = 25;
            this.chechListB.Location = new System.Drawing.Point(873, 118);
            this.chechListB.Name = "chechListB";
            this.chechListB.Size = new System.Drawing.Size(375, 479);
            this.chechListB.TabIndex = 6;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 720);
            this.Controls.Add(this.chechListB);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.sumpriceTxtb);
            this.Controls.Add(this.moneyTxtb);
            this.Controls.Add(this.quantityTxtb);
            this.Controls.Add(this.priceTxtb);
            this.Controls.Add(this.petrolCombob);
            this.Controls.Add(this.moneyRadiob);
            this.Controls.Add(this.quantityRadioB);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.sumpriceLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oilLbl);
            this.Controls.Add(this.label1);
            this.Name = "HomeWindow";
            this.Text = "HomeWindow";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oilLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.RadioButton quantityRadioB;
        private System.Windows.Forms.RadioButton moneyRadiob;
        private System.Windows.Forms.Label sumpriceLbl;
        private System.Windows.Forms.ComboBox petrolCombob;
        private System.Windows.Forms.TextBox priceTxtb;
        private System.Windows.Forms.TextBox quantityTxtb;
        private System.Windows.Forms.TextBox moneyTxtb;
        private System.Windows.Forms.TextBox sumpriceTxtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.ListBox chechListB;
    }
}