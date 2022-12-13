using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddForm : Form
    {
        //const double MaxHours = 9.00;
        const int SquareFootMeasure = 115;
       // const double HourPayInt = 20.00;
       // const double OverTimeRate = 1.5;
        const double InteriorFee = 50.00;
        const double ExteriorFee = 70.00;

        // List<String> idS = new List<String>();
        ShowRecordsForm show = new ShowRecordsForm();
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?");
            this.Close();
        }
        private void clearAll()
        {
            txtBoxName.Clear();
            txtBoxID.Clear();
            txtBoxYear.Clear();
            txtBoxArea.Text= "0";
            txtBoxMarerials.Clear();
            txtBoxDisc.Clear();
            textBoxEmail.Clear();
            textBoxExtra.Clear();
            txtBoxNotes.Clear();
            comboBoxDescr.ResetText();
            comboBoxMonth.ResetText();
            numericDay.ResetText();
            checkBoxDisc.Checked= false;
            checkExtraFees.Checked= false;
            txtBoxName.Focus();
            
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();


        }
        
        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            string finalInfo = txtBoxID.Text + ", " + txtBoxName.Text + ", " +
                numericDay.Text +" "+ comboBoxMonth.Text +" " +txtBoxYear.Text + ", " +
                comboBoxDescr.Text+ ", " + txtBoxArea.Text + "ft2,  " + txtBoxMarerials.Text + ", "
                + textBoxEmail.Text +", ";

            finalInfo += checkBoxDisc.Checked ? "Discount, " : "No Discount, ";
            finalInfo += checkExtraFees.Checked ? "Extra Fees,  " : " No Extra Fees, " ;
            finalInfo += string.Format("{0:C}", calculateEstimate(double.Parse(txtBoxArea.Text), double.Parse(txtBoxMarerials.Text)));

            if (txtBoxName.Text == "" || txtBoxID.Text == "" || txtBoxArea.Text == "" || numericDay.Text == ""|| txtBoxYear.Text == ""
                                       || comboBoxMonth.Text =="Select" || comboBoxDescr.Text ==""|| txtBoxMarerials.Text==""
                                       || textBoxEmail.Text=="")
            {
                MessageBox.Show("Some of the fields are incomplete. Please verify you entered all necessary information.");
            }else
            {
                ShowRecordsForm saveRec = new ShowRecordsForm();
                saveRec.receiveRecords(finalInfo);
                MessageBox.Show("Saved record --> " + finalInfo);
              
                
                clearAll();
            }
        }



        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void txtBoxArea_TextChanged(object sender, EventArgs e)
        {
            string input = txtBoxArea.Text;
            double workArea;

            //validate input

            if (!(double.TryParse(input, out workArea) &&
                    workArea > 0.0 ))
            {
                string message = "Square foot area must be higher than zero" ;
                MessageBox.Show(message);
                txtBoxArea.Text = "";
                txtBoxArea.Focus();
                txtBoxArea.SelectAll();
            }

        }

        private void txtBoxDays_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private double calculateEstimate(double area, double materials)
        {
            double estimate = 0;
            double totalHours = (area / SquareFootMeasure)*8; //gets the total of hours needed
            double totalMaterials =(area / SquareFootMeasure) * materials; //total cost of the materials 

            //Initial estimate of the cost depending on the job description 

            string option = comboBoxDescr.Text;

            switch (option) {
                case "Exterior":
                    estimate = (totalHours * ExteriorFee) + (totalMaterials);
                    break;
                case "Interior":
                    estimate = (totalHours * InteriorFee) + (totalMaterials);
                    break;
            }

            //check for discounts or extra fees 
            if (checkExtraFees.Checked)
            {
                estimate += double.Parse(textBoxExtra.Text);
            }       
            
            if (checkBoxDisc.Checked)
            { 
               estimate -= double.Parse(txtBoxDisc.Text);  
                
            } 

            return estimate;
        }

        private void area_enter(object sender, EventArgs e)
        {
            txtBoxArea.SelectAll();
        }

      

        private void numericDays_ValueChanged(object sender, EventArgs e)
        {

         
            numericDay.Maximum = 31;
            numericDay.Minimum = 1;
          
            
        }

        private void txtBoxYear_TextChanged(object sender, EventArgs e)
        {
            string input = txtBoxYear.Text;
            int finalYear;

            if (!(int.TryParse(input, out finalYear) && finalYear > 0 && finalYear <3000  ))
            {
                MessageBox.Show("Enter Valid Year (4 digits) ");
                txtBoxYear.Clear();
                txtBoxYear.Focus();
            }
        }


        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBoxID_Key(object sender, KeyEventArgs e)
        {
            
            string input = txtBoxID.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (!(show.retrieveiDs().Contains(txtBoxID.Text)))
                {
                    show.addIdS(input);

                }
                else if ((show.retrieveiDs().Contains(txtBoxID.Text)))
                //txtBoxID.SelectAll(); }

                { 
                    string message = "ID cannot be repeated";
                    MessageBox.Show(message);
                    txtBoxID.Clear();
                    txtBoxID.Focus();
                }
            }

        }

        private void emailVal(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string email = textBoxEmail.Text;

                if (!(email.IndexOf("@") >= 1 && (email.Substring(email.LastIndexOf(".") + 1)).Equals("com")))
                {
                    MessageBox.Show("Enter Valid email");
                    textBoxEmail.Clear();
                    textBoxEmail.Focus();
                }
            }
        }
    }
}
