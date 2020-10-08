using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        GetAnswer Addition, Subtraction, Multiplication, Division;

        public Form1()
        {
            InitializeComponent();

            Addition = new GetAnswer(Calcu_Formula.GetSum);
            Subtraction = new GetAnswer(Calcu_Formula.GetDifference);
            Multiplication = new GetAnswer(Calcu_Formula.GetProduct);
            Division = new GetAnswer(Calcu_Formula.GetQuotient);

        }
        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                String title = "Sum";
                
                int num1 = Int32.Parse(txtNum1.Text);
                int num2 = Int32.Parse(txtNum2.Text);

                DialogResult result = MessageBox.Show(Addition(num1, num2).ToString(), title, MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Cancel)
                {
                    String exit = "Do you want to exit?";
                    String close = "Close Window";
                    DialogResult result_2 = MessageBox.Show(exit, close, MessageBoxButtons.YesNo);
                    if (result_2 == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                String message = "Please input the first and second number before clicking operation symbols !";
                String title = "Warning!";
                    MessageBox.Show(message,title,MessageBoxButtons.OK,MessageBoxIcon.Warning);                             
            }
           
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            try
            {

            String title = "Difference";
               
            int num1 = Int32.Parse(txtNum1.Text);
            int num2 = Int32.Parse(txtNum2.Text);

            DialogResult result = MessageBox.Show(Subtraction(num1, num2).ToString(), title, MessageBoxButtons.RetryCancel);

            if (result == DialogResult.Cancel)
            {
                String exit = "Do you want to exit?";
                String close = "Close Window";
                DialogResult result_2 = MessageBox.Show(exit, close, MessageBoxButtons.YesNo);
                if (result_2 == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
            catch (Exception)
            {
                String message = "Please input the first and second number before clicking operation symbols !";
                String title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {

                String title = "Product";
                
                int num1 = Int32.Parse(txtNum1.Text);
                int num2 = Int32.Parse(txtNum2.Text);

                DialogResult result = MessageBox.Show(Multiplication(num1, num2).ToString(), title, MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Cancel)
                {
                    String exit = "Do you want to exit?";
                    String close = "Close Window";
                    DialogResult result_2 = MessageBox.Show(exit, close, MessageBoxButtons.YesNo);
                    if (result_2 == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            
             catch (Exception)
            {
                String message = "Please input the first and second number before clicking operation symbols !";
                String title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                String title = "Qoutient";
                int num1 = Int32.Parse(txtNum1.Text);
                int num2 = Int32.Parse(txtNum2.Text);

                DialogResult result = MessageBox.Show(Division(num1, num2).ToString(), title, MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Cancel)
                {
                    String exit = "Do you want to exit?";
                    String close = "Close Window";
                    DialogResult result_2 = MessageBox.Show(exit, close, MessageBoxButtons.YesNo);
                    if (result_2 == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                String message = "Please input the first and second number before clicking operation symbols !";
                String title = "Warning!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
