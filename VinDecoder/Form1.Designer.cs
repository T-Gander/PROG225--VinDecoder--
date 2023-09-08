namespace VinDecoder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtVin = new TextBox();
            btnDecode = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGenerate = new Button();
            txtRegion = new TextBox();
            txtCountry = new TextBox();
            txtVIS = new TextBox();
            txtVDS = new TextBox();
            txtYear = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 0;
            label1.Text = "VIN DECODER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 61);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter a Valid 17 digit VIN:";
            // 
            // txtVin
            // 
            txtVin.Location = new Point(39, 79);
            txtVin.MaxLength = 17;
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(198, 23);
            txtVin.TabIndex = 2;
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(243, 79);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(75, 23);
            btnDecode.TabIndex = 3;
            btnDecode.Text = "Decode";
            btnDecode.UseVisualStyleBackColor = true;
            btnDecode.Click += btnDecode_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 129);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Region";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 129);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 5;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 178);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 6;
            label5.Text = "VDS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 178);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 7;
            label6.Text = "Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 129);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 8;
            label7.Text = "VIS";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(324, 79);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(141, 23);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate Vin";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // txtRegion
            // 
            txtRegion.Enabled = false;
            txtRegion.Location = new Point(39, 147);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(100, 23);
            txtRegion.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Enabled = false;
            txtCountry.Location = new Point(145, 147);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 11;
            // 
            // txtVIS
            // 
            txtVIS.Enabled = false;
            txtVIS.Location = new Point(251, 147);
            txtVIS.Name = "txtVIS";
            txtVIS.Size = new Size(100, 23);
            txtVIS.TabIndex = 12;
            // 
            // txtVDS
            // 
            txtVDS.Enabled = false;
            txtVDS.Location = new Point(39, 196);
            txtVDS.Name = "txtVDS";
            txtVDS.Size = new Size(100, 23);
            txtVDS.TabIndex = 13;
            // 
            // txtYear
            // 
            txtYear.Enabled = false;
            txtYear.Location = new Point(145, 196);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtYear);
            Controls.Add(txtVDS);
            Controls.Add(txtVIS);
            Controls.Add(txtCountry);
            Controls.Add(txtRegion);
            Controls.Add(btnGenerate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnDecode);
            Controls.Add(txtVin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Vin Decoder App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label label1;
        internal Label label2;
        internal TextBox txtVin;
        internal Button btnDecode;
        internal Label label3;
        internal Label label4;
        internal Label label5;
        internal Label label6;
        internal Label label7;
        internal Button btnGenerate;
        internal TextBox txtRegion;
        internal TextBox txtCountry;
        internal TextBox txtVIS;
        internal TextBox txtVDS;
        internal TextBox txtYear;
    }
}