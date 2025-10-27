// test
namespace lab03
{
    public partial class Kalkulator_Procentowy : Form
    {
        public Kalkulator_Procentowy()
        {
            InitializeComponent();
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
                MessageBox.Show("Proszê wpisaæ poprawne dane!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cmbVessel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVessel.SelectedIndex == 0)
            {
                txtCapacity.Text = "50";
            }
            else if (cmbVessel.SelectedIndex == 1)
            {
                txtCapacity.Text = "300";
            }
        }

        private void cmbSolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSolution.SelectedIndex == 0)
            {
                txtPercent.Text = "28";
                txtCount.Text = "1";

            }
            if (cmbSolution.SelectedIndex == 1)
            {
                txtPercent.Text = "15";
                txtCount.Text = "1";
            }
            if (cmbSolution.SelectedIndex == 2)
            {
                txtPercent.Text = "40";
                txtCount.Text = "1";
            }
            if (cmbSolution.SelectedIndex == 3)
            {
                txtPercent.Text = "95";
                txtCount.Text = "1";
            }
        }

    }
}
