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
            Double GivenBMI = 0.0;

            if (RBImperial.Checked == true)
            {
                GivenBMI = BmiCalc(Weight, Height, 'I');

            }
            else if (RBMetric.Checked == true)
            {
                GivenBMI = BmiCalc(Weight, Height, 'M');
            }

            lblBMIvalue.Text = BMIlabelCol(GivenBMI);
        }

        private void lblBMIvalue_Click(object sender, EventArgs e)
        {

        }

        private double BmiCalc(float Weight, float Height, char Metric)
        {
            if (Metric == 'I')
            {
                return Math.Round((703 * Weight / Math.Pow(Height, 2)), 1);
            }
            else
            {
                return Math.Round((Weight / Math.Pow(Height, 2)), 1);
            }

        }
        private string BMIlabelCol(double BMI)
        {
            if (BMI < 16)
            {
                lblBMIvalue.ForeColor = Color.Red;
                return $"You are severely thin, BMI: {BMI}KG/M^2";
            }
            else if ((BMI >= 16) && (BMI < 17))
            {
                lblBMIvalue.ForeColor = Color.Orange;
                return $"You are moderately thin, BMI: {BMI}KG/M^2";
            }
            else if ((BMI >= 17) && (BMI < 18.5))
            {
                lblBMIvalue.ForeColor = Color.Yellow;
                return $"You are mildly thin, BMI: {BMI}KG/M^2";
            }
            else if ((BMI >= 18.5) && (BMI < 25))
            {
                lblBMIvalue.ForeColor = Color.Green;
                return $"You are normal, BMI: {BMI}KG/M^2";
            }
            else if ((BMI >= 25) && (BMI < 30))
            {
                lblBMIvalue.ForeColor = Color.Yellow;
                return $"You are overweight, BMI: {BMI}KG/M^2";
            }
            else if ((BMI >= 30) && (BMI < 35))
            {
                lblBMIvalue.ForeColor = Color.Orange;
                return $"You are Obese Class 1, BMI: {BMI}KG/M^2";
            }
            else if ((BMI >= 35) && (BMI < 40))
            {
                lblBMIvalue.ForeColor = Color.Red;
                return $"You are Obese Class 2, BMI: {BMI}KG/M^2";
            }
            else if ((BMI >= 40))
            {
                lblBMIvalue.ForeColor = Color.Maroon;
                return $"You are Obese Class 3, BMI: {BMI}KG/M^2";
            }
            else
            {
                lblBMIvalue.ForeColor = Color.Black;
                return "NaN";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RBMetric.Checked = true;
            lblBMIvalue.Text = "";
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