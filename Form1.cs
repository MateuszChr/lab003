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
            try
            {
                double Capacity = double.Parse(txtCapacity.Text);
                double Count = double.Parse(txtCount.Text);
                double Percent = double.Parse(txtPercent.Text);

                double Result = Capacity * Count;
                double ResultPure = Result * (Percent / 100);

                txtTotal.Text = Result.ToString();
                txtPure.Text = ResultPure.ToString();
            }
            catch
            {
                MessageBox.Show("Proszê wpisaæ poprawne liczby!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
