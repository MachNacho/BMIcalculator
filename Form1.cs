namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            float Weight = (float)RollWeight.Value;
            float Height = (float)RollHeight.Value;

            if (RBImperial.Checked == true)
            {
                BmiCalc(Weight, Height,'I');
                
            }
            else if (RBMetric.Checked == true)
            {
                BmiCalc(Weight, Height, 'M');
            }
           
        }

        private void lblBMIvalue_Click(object sender, EventArgs e)
        {

        }

        private double BmiCalc(float Weight,float Height, char Metric) 
        {
            if(Metric == 'I')
            {
                return (703 * Weight / (Math.Pow(Height, 2)));
            }
            else 
            {
                return (Weight / (Math.Pow(Height, 2)));
            }
           
        }
    }
}