namespace lab03
{
    partial class Kalkulator_Procentowy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Cllean up any resources being used.
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
            cmbVessel = new ComboBox();
            lbVessel = new Label();
            lbCapacity = new Label();
            lbSolution = new Label();
            lbPercent = new Label();
            lbCount = new Label();
            lbTotal = new Label();
            lbPure = new Label();
            cmbSolution = new ComboBox();
            txtTotal = new TextBox();
            txtPure = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            txtCapacity = new TextBox();
            txtPercent = new TextBox();
            txtCount = new TextBox();
            lbPer = new Label();
            txtMl = new Label();
            SuspendLayout();
            // 
            // cmbVessel
            // 
            cmbVessel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVessel.FormattingEnabled = true;
            cmbVessel.Items.AddRange(new object[] { "Kieliszek ( 50ml )", "Szklanka ( 300ml )" });
            cmbVessel.Location = new Point(279, 48);
            cmbVessel.Name = "cmbVessel";
            cmbVessel.Size = new Size(121, 23);
            cmbVessel.TabIndex = 0;
            cmbVessel.SelectedIndexChanged += cmbVessel_SelectedIndexChanged;
            // 
            // lbVessel
            // 
            lbVessel.AutoSize = true;
            lbVessel.Location = new Point(70, 56);
            lbVessel.Name = "lbVessel";
            lbVessel.Size = new Size(78, 15);
            lbVessel.TabIndex = 1;
            lbVessel.Text = "Typ naczynia:";
            // 
            // lbCapacity
            // 
            lbCapacity.AutoSize = true;
            lbCapacity.Location = new Point(70, 105);
            lbCapacity.Name = "lbCapacity";
            lbCapacity.Size = new Size(69, 15);
            lbCapacity.TabIndex = 2;
            lbCapacity.Text = "Pojemność:";
            // 
            // lbSolution
            // 
            lbSolution.AutoSize = true;
            lbSolution.Location = new Point(70, 148);
            lbSolution.Name = "lbSolution";
            lbSolution.Size = new Size(79, 15);
            lbSolution.TabIndex = 3;
            lbSolution.Text = "Typ roztworu:";
            // 
            // lbPercent
            // 
            lbPercent.AutoSize = true;
            lbPercent.Location = new Point(70, 200);
            lbPercent.Name = "lbPercent";
            lbPercent.Size = new Size(120, 15);
            lbPercent.TabIndex = 4;
            lbPercent.Text = "Zawartość substancji:";
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Location = new Point(70, 243);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(113, 15);
            lbCount.TabIndex = 5;
            lbCount.Text = "Liczba sztuk naczyń:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(70, 349);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(127, 15);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "Łączna objętość płynu:";
            // 
            // lbPure
            // 
            lbPure.AutoSize = true;
            lbPure.Location = new Point(70, 396);
            lbPure.Name = "lbPure";
            lbPure.Size = new Size(151, 15);
            lbPure.TabIndex = 7;
            lbPure.Text = "Objętość czystej substancji:";
            // 
            // cmbSolution
            // 
            cmbSolution.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSolution.FormattingEnabled = true;
            cmbSolution.Items.AddRange(new object[] { "Wódka smakowa", "Wino", "Whisty" });
            cmbSolution.Location = new Point(279, 148);
            cmbSolution.Name = "cmbSolution";
            cmbSolution.Size = new Size(121, 23);
            cmbSolution.TabIndex = 8;
            cmbSolution.SelectedIndexChanged += cmbSolution_SelectedIndexChanged;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(279, 349);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 9;
            // 
            // txtPure
            // 
            txtPure.Enabled = false;
            txtPure.Location = new Point(279, 393);
            txtPure.Name = "txtPure";
            txtPure.ReadOnly = true;
            txtPure.Size = new Size(100, 23);
            txtPure.TabIndex = 10;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(393, 309);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Oblicz";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(491, 309);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(279, 97);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 23);
            txtCapacity.TabIndex = 13;
            // 
            // txtPercent
            // 
            txtPercent.Location = new Point(279, 192);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(100, 23);
            txtPercent.TabIndex = 14;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(279, 235);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(100, 23);
            txtCount.TabIndex = 15;
            // 
            // lbPer
            // 
            lbPer.AutoSize = true;
            lbPer.Location = new Point(383, 195);
            lbPer.Name = "lbPer";
            lbPer.Size = new Size(17, 15);
            lbPer.TabIndex = 16;
            lbPer.Text = "%";
            // 
            // txtMl
            // 
            txtMl.AutoSize = true;
            txtMl.Location = new Point(385, 100);
            txtMl.Name = "txtMl";
            txtMl.Size = new Size(21, 15);
            txtMl.TabIndex = 17;
            txtMl.Text = "ml";
            // 
            // Kalkulator_Procentowy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMl);
            Controls.Add(lbPer);
            Controls.Add(txtCount);
            Controls.Add(txtPercent);
            Controls.Add(txtCapacity);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtPure);
            Controls.Add(txtTotal);
            Controls.Add(cmbSolution);
            Controls.Add(lbPure);
            Controls.Add(lbTotal);
            Controls.Add(lbCount);
            Controls.Add(lbPercent);
            Controls.Add(lbSolution);
            Controls.Add(lbCapacity);
            Controls.Add(lbVessel);
            Controls.Add(cmbVessel);
            Name = "Kalkulator_Procentowy";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbVessel;
        private Label lbVessel;
        private Label lbCapacity;
        private Label lbSolution;
        private Label lbPercent;
        private Label lbCount;
        private Label lbTotal;
        private Label lbPure;
        private ComboBox cmbSolution;
        private TextBox txtTotal;
        private TextBox txtPure;
        private Button btnCalculate;
        private Button btnClear;
        private TextBox txtCapacity;
        private TextBox txtPercent;
        private TextBox txtCount;
        private Label lbPer;
        private Label txtMl;
    }
}
