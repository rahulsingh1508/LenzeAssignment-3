namespace StringCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if ((String1TextBox.Text == "" && String2TextBox.Text != "") || (String2TextBox.Text == "" && String1TextBox.Text != ""))
            {
                MessageBox.Show("Please Enter both the strings");
            }
            else if (String1TextBox.Text == String2TextBox.Text)
            {
                MessageBox.Show("Both String are Equal");

            }
            else if (String1TextBox.Text != String2TextBox.Text)
            {
                MessageBox.Show("Both String are not Equal");
            }
        }
        public string ReverseString(string Input)
        {
            char[] charArray = Input.ToCharArray();

            string reversedString = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {

                reversedString += charArray[i];
            }

            return reversedString;
        }
        private void PalindromeButton_Click(object sender, EventArgs e)
        {
            string reversestring1 = ReverseString(String1TextBox.Text);
            string reversestring2 = ReverseString(String2TextBox.Text);
            MessageBox.Show("String 1 is Palindrome : "+ reversestring1.Equals(String1TextBox.Text).ToString() + 
                "\nString 1 is Palindrome : "+ reversestring2.Equals(String2TextBox.Text).ToString());
           
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
           // string reversestring1 = ReverseString(String1TextBox.Text);
            //string reversestring2 = ReverseString(String2TextBox.Text);
            MessageBox.Show("String 1 reverse is : " + ReverseString(String1TextBox.Text) +
                "\n String 2 reverse is : " + ReverseString(String2TextBox.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String1TextBox.Text == "" && String2TextBox.Text == "") {
                MessageBox.Show("Please Enter the string");
            }
            else if(String1TextBox.Text == "" || String2TextBox.Text == "")
            {
                MessageBox.Show("For concentation we required 2 strings");
            }
            else
            {
                ConcentationTextBox.Text = String1TextBox.Text + String2TextBox.Text;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            String1TextBox.Text = "";
            String2TextBox.Text = "";
            ConcentationTextBox.Text = "";

        }
    }
}
