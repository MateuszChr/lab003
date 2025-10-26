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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulator_Procentowy));
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
            sepTop = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            lbTitle1 = new Label();
            lbTitle = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            pbxPreview = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPreview).BeginInit();
            SuspendLayout();
            // 
            // cmbVessel
            // 
            cmbVessel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVessel.FormattingEnabled = true;
            cmbVessel.Items.AddRange(new object[] { "Kieliszek ( 50ml )", "Szklanka ( 300ml )" });
            cmbVessel.Location = new Point(595, 160);
            cmbVessel.Name = "cmbVessel";
            cmbVessel.Size = new Size(138, 25);
            cmbVessel.TabIndex = 0;
            cmbVessel.SelectedIndexChanged += cmbVessel_SelectedIndexChanged;
            // 
            // lbVessel
            // 
            lbVessel.AutoSize = true;
            lbVessel.Location = new Point(471, 168);
            lbVessel.Name = "lbVessel";
            lbVessel.Size = new Size(91, 17);
            lbVessel.TabIndex = 1;
            lbVessel.Text = "Typ naczynia:";
            // 
            // lbCapacity
            // 
            lbCapacity.AutoSize = true;
            lbCapacity.Location = new Point(471, 210);
            lbCapacity.Name = "lbCapacity";
            lbCapacity.Size = new Size(79, 17);
            lbCapacity.TabIndex = 2;
            lbCapacity.Text = "Pojemność:";
            // 
            // lbSolution
            // 
            lbSolution.AutoSize = true;
            lbSolution.Location = new Point(69, 176);
            lbSolution.Name = "lbSolution";
            lbSolution.Size = new Size(93, 17);
            lbSolution.TabIndex = 3;
            lbSolution.Text = "Typ roztworu:";
            // 
            // lbPercent
            // 
            lbPercent.AutoSize = true;
            lbPercent.Location = new Point(69, 218);
            lbPercent.Name = "lbPercent";
            lbPercent.Size = new Size(140, 17);
            lbPercent.TabIndex = 4;
            lbPercent.Text = "Zawartość substancji:";
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Location = new Point(69, 261);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(132, 17);
            lbCount.TabIndex = 5;
            lbCount.Text = "Liczba sztuk naczyń:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(78, 346);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(148, 17);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "Łączna objętość płynu:";
            // 
            // lbPure
            // 
            lbPure.AutoSize = true;
            lbPure.Location = new Point(78, 403);
            lbPure.Name = "lbPure";
            lbPure.Size = new Size(177, 17);
            lbPure.TabIndex = 7;
            lbPure.Text = "Objętość czystej substancji:";
            // 
            // cmbSolution
            // 
            cmbSolution.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSolution.FormattingEnabled = true;
            cmbSolution.Items.AddRange(new object[] { "Wódka smakowa", "Wino", "Whisty", "Spirytus" });
            cmbSolution.Location = new Point(218, 165);
            cmbSolution.Name = "cmbSolution";
            cmbSolution.Size = new Size(138, 25);
            cmbSolution.TabIndex = 8;
            cmbSolution.SelectedIndexChanged += cmbSolution_SelectedIndexChanged;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(280, 338);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(123, 25);
            txtTotal.TabIndex = 9;
            // 
            // txtPure
            // 
            txtPure.Enabled = false;
            txtPure.Location = new Point(280, 395);
            txtPure.Name = "txtPure";
            txtPure.ReadOnly = true;
            txtPure.Size = new Size(123, 25);
            txtPure.TabIndex = 10;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(515, 270);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 26);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Oblicz";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(647, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 26);
            btnClear.TabIndex = 12;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(595, 202);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(138, 25);
            txtCapacity.TabIndex = 13;
            // 
            // txtPercent
            // 
            txtPercent.Location = new Point(218, 210);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(138, 25);
            txtPercent.TabIndex = 14;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(218, 258);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(138, 25);
            txtCount.TabIndex = 15;
            // 
            // lbPer
            // 
            lbPer.AutoSize = true;
            lbPer.Location = new Point(362, 213);
            lbPer.Name = "lbPer";
            lbPer.Size = new Size(19, 17);
            lbPer.TabIndex = 16;
            lbPer.Text = "%";
            // 
            // txtMl
            // 
            txtMl.AutoSize = true;
            txtMl.Location = new Point(739, 205);
            txtMl.Name = "txtMl";
            txtMl.Size = new Size(24, 17);
            txtMl.TabIndex = 17;
            txtMl.Text = "ml";
            // 
            // sepTop
            // 
            sepTop.BackColor = SystemColors.HotTrack;
            sepTop.Dock = DockStyle.Top;
            sepTop.Font = new Font("Segoe UI", 1.5F, FontStyle.Bold, GraphicsUnit.Point, 238);
            sepTop.Location = new Point(16, 16);
            sepTop.Name = "sepTop";
            sepTop.Size = new Size(882, 10);
            sepTop.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(16, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 468);
            panel2.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.Location = new Point(10, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(872, 10);
            panel5.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(888, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 468);
            panel1.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbTitle1);
            panel3.Controls.Add(lbTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(26, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(862, 111);
            panel3.TabIndex = 23;
            // 
            // lbTitle1
            // 
            lbTitle1.AutoSize = true;
            lbTitle1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbTitle1.Location = new Point(172, 54);
            lbTitle1.Name = "lbTitle1";
            lbTitle1.Size = new Size(474, 37);
            lbTitle1.TabIndex = 1;
            lbTitle1.Text = "~ Mateusz Chryścienko || Bartłomiej Kielar";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbTitle.Location = new Point(217, 3);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(358, 51);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Kalkulator procentowy";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(26, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(862, 10);
            panel4.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Highlight;
            panel6.Location = new Point(19, 305);
            panel6.Name = "panel6";
            panel6.Size = new Size(876, 10);
            panel6.TabIndex = 25;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Highlight;
            panel7.Location = new Point(19, 484);
            panel7.Name = "panel7";
            panel7.Size = new Size(876, 10);
            panel7.TabIndex = 26;
            // 
            // pbxPreview
            // 
            pbxPreview.BackgroundImage = (Image)resources.GetObject("pbxPreview.BackgroundImage");
            pbxPreview.Image = (Image)resources.GetObject("pbxPreview.Image");
            pbxPreview.Location = new Point(630, 321);
            pbxPreview.Name = "pbxPreview";
            pbxPreview.Size = new Size(150, 150);
            pbxPreview.TabIndex = 27;
            pbxPreview.TabStop = false;
            // 
            // Kalkulator_Procentowy
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 510);
            Controls.Add(pbxPreview);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(sepTop);
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
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(640, 420);
            Name = "Kalkulator_Procentowy";
            Padding = new Padding(16);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kalkulator procentowy ";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPreview).EndInit();
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
        private Panel sepTop;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label lbTitle;
        private Panel panel4;
        private Label lbTitle1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pbxPreview;
    }
}
