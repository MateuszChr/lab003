namespace lab03
{
    public partial class Kalkulator_Procentowy : Form
    {
        public Kalkulator_Procentowy()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Capacity = double.Parse(txtCapacity.Text);
            double Count = double.Parse(txtCount.Text);
            double Result = Capacity * Count;
            double Percent = double.Parse(txtPercent.Text);
            txtTotal.Text = Result.ToString();
            double ResultPure = Result * (Percent / 100);
            txtPure.Text = ResultPure.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbSolution.SelectedIndex = -1;
            txtCapacity.Clear();
            cmbVessel.SelectedIndex = -1;   
            txtPercent.Clear();
            txtCount.Clear();
            txtTotal.Clear();
            txtPure.Clear();
        }
    }
}
