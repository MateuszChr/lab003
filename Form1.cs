// test
using System.Runtime.CompilerServices;

namespace lab03
{
    public partial class Kalkulator_Procentowy : Form
    {
        public Kalkulator_Procentowy()
        {
            InitializeComponent();
        }
        private bool isFirstChangeVessel = true;
        private bool isFirstChangeSolution = true;




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

                if (Capacity <= 0 || Count <= 0 || Percent < 0 || Percent>100)
                {
                    txtTotal.Clear();
                    txtPure.Clear();
                    MessageBox.Show("Wartoœci musz¹ byæ dodatnie, a procent nie mo¿e przekraczaæ 100!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

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

            isFirstChangeVessel = true;

            if (cmbVessel.SelectedIndex == 0)
            {
                txtCapacity.Text = "50";
            }
            else if (cmbVessel.SelectedIndex == 1)
            {
                txtCapacity.Text = "300";
            }


            isFirstChangeVessel = false;
        }

        private void cmbSolution_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbSolution.SelectedIndex != -1)
            {
                isFirstChangeSolution = true;

                if (cmbSolution.SelectedIndex == 0)
                {
                    txtPercent.Text = "28";
                    txtCount.Text = "1";
                }
                else if (cmbSolution.SelectedIndex == 1)
                {
                    txtPercent.Text = "15";
                    txtCount.Text = "1";
                }
                else if (cmbSolution.SelectedIndex == 2)
                {
                    txtPercent.Text = "40";
                    txtCount.Text = "1";
                }
                else if (cmbSolution.SelectedIndex == 3)
                {
                    txtPercent.Text = "95";
                    txtCount.Text = "1";
                }

                isFirstChangeSolution = false;
            }
        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {
            if (isFirstChangeVessel == false)
            {
                cmbVessel.SelectedIndex = -1;
            }

        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            if (isFirstChangeSolution == false)
            {
                cmbSolution.SelectedIndex = -1;
            }
        }
    }
}
