namespace frmCalculator
{


    public partial class frmCalculator : Form
    {
        bool BreakTyping = false;
        bool Result = false;

        List<decimal> Arguments;

        /// <summary>
        /// true : denotes argument 1 is typing now, false : denotes argument 2 is typing.
        /// </summary>


        bool IsArgument1Typing;
        bool IsArgument2Entered;

        decimal Argument1 = 0;
        decimal Argument2 = 0;
        eOperator SelectedOperator;


        public frmCalculator()
        {
            InitializeComponent();
            Arguments = new List<decimal>();
            IsArgument1Typing = true;

            txtResult.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArgument_Click(object sender, EventArgs e)
        {


            if (BreakTyping)
            {
                txtResult.Text = ((Button)sender).Text;
                BreakTyping = false;
            }
            else
            {
                txtResult.Text += ((Button)sender).Text;

            }
            if (sender != btnDecimal)
            {
                decimal v = 0;
                decimal.TryParse(txtResult.Text, out v);
                txtResult.Text = v.ToString();

            }


            IsArgument2Entered = (!IsArgument1Typing);

            //if (!IsArgument1Typing)
            //{
            //    IsArgument2Entered = true;
            //}
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {

            if (IsArgument1Typing || SelectedOperator == eOperator.None)
            {
                Argument1 = (decimal.Parse(txtResult.Text));
                IsArgument1Typing = false;
                txtLastOperationHistory.Text += Argument1.ToString();
            }
            else if (IsArgument2Entered || sender == btnEqualTo)
            {

                if (IsArgument2Entered)
                {
                    Argument2 = decimal.Parse(txtResult.Text);
                    txtLastOperationHistory.Text += Argument2.ToString();
                }
                IsArgument2Entered = false;
                decimal Result = 0;

                switch (SelectedOperator)
                {
                    case eOperator.Add:
                        Result = Argument1 + Argument2;
                        
                        break;
                    case eOperator.Subtract:
                        Result = Argument1 - Argument2;
                        
                        break;
                    case eOperator.Multiplication:
                        Result = Argument1 * Argument2;
                        
                        break;
                    case eOperator.Division:
                        if (Argument2 == 0)
                        {

                            txtResult.Text = "Cannot divide by 0";
                            BreakTyping = true;
                            txtLastOperationHistory.Text = "";
                            IsArgument1Typing = true;
                            IsArgument2Entered = false;
                            SelectedOperator = eOperator.None;
                            return;
                        }
                        Result = Argument1 / Argument2;
                        
                       
                        break;
                    default:
                        IsArgument1Typing = true;
                        Result = Argument1;
                        break;
                }

                txtResult.Text = Result.ToString();
                Argument1 = Result;
                //Argument2 = 0;

            }
            BreakTyping = true;

            if (sender == btnAdd)
            {
                SelectedOperator = eOperator.Add;
            }
            else if (sender == btnSubtract)
            {
                SelectedOperator = eOperator.Subtract;
            }
            else if (sender == btnMultiplication)
            {
                SelectedOperator = eOperator.Multiplication;
            }
            else if (sender == btnDivision)
            {
                SelectedOperator = eOperator.Division;
            }

            txtLastOperationHistory.Text +=" " + ((Control)sender).Text + " ";
            //else
            //{
            //    SelectedOperator = eOperator.None;
            //}

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Text = (-decimal.Parse(txtResult.Text)).ToString();
        }


        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtLastOperationHistory.Text = " ";
            IsArgument1Typing = true;
            IsArgument2Entered = false;
            SelectedOperator = eOperator.None;
            Argument1 = 0;
            Argument2 = 0;
            BreakTyping = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            txtResult.Text = (-decimal.Parse(txtResult.Text)).ToString();
        }

        public enum eOperator
        {
            None = 0,
            Add = 1,
            Subtract = 2,
            Multiplication = 3,
            Division = 4

        }
    }
}