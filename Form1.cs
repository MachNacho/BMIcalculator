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
            label1.Text = "Weight (Kilograms)";
            label2.Text = "Height (Meters)";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            float Weight = (float)RollWeight.Value;
            float Height = (float)RollHeight.Value;     

            if (RBImperial.Checked == true)
            {
                lblBMIvalue.Text = BmiCalc(Weight, Height, 'I').ToString();

            }
            else if (RBMetric.Checked == true)
            {
                lblBMIvalue.Text = BmiCalc(Weight, Height, 'M').ToString();
            }

        }

        private void lblBMIvalue_Click(object sender, EventArgs e)
        {

        }

        private double BmiCalc(float Weight, float Height, char Metric)
        {
            if (Metric == 'I')
            {
                return Math.Round( (703 * Weight / Math.Pow(Height, 2)),1);
            }
            else
            {
                return Math.Round((Weight / Math.Pow(Height, 2)),1);
            }

        }
        private string BMIlabelCol(double BMI)
        {
            if (BMI<16)
            {

            }
            else if ((BMI >=16)&&(BMI<17))
            {

            }
            else if ((BMI >= 17) && (BMI < 18.5))
            {

            }
            else if ((BMI >= 18.5) && (BMI < 25))
            {

            }
            else if ((BMI >= 25) && (BMI < 30))
            {

            }
            else if ((BMI >= 30) && (BMI <35))
            {

            }
           else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RBMetric.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RBImperial_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Weight (Pounds)";
            label2.Text = "Height (Inches)";
        }
    }
}