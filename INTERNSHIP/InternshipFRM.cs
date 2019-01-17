using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERNSHIP
{
    public partial class InternshipFRM : Form
    {
        public InternshipFRM()
        {
            InitializeComponent();
        }

        private void InternshipFRM_Load(object sender, EventArgs e)
        {
            //I chose the initial attributes on 'properties' part.
        }

        string dummy = "dummy";   //I use dummy string because in BridgeBtn2 I will use same function for 4 inputs. So it's just for dynamism and practicability. 
        private void BridgeBtn1_Click(object sender, EventArgs e)
        {
            bool cntrlSFull = fullfill(tbSName.Text, tbSurname.Text, tbID.Text, dummy);
            bool cntrlEmailFill = E_Mail_fill(tbEmail.Text);
            bool cntrlID = IDcontrol(tbID.Text);
            bool cntrlIDnum = ID_num_Control(tbID.Text);
            bool cntrlEmail = E_Mail_Control(tbEmail.Text);

            if (cntrlSFull == false)   //for checking if the user enter all information in first groupbox or not.
            {
                MessageBox.Show("You must enter all asked information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (cntrlID == false || cntrlIDnum == false)   //for checking if there are 11 digits in written ID or not.
            {
                MessageBox.Show("Your ID must include 11 digits and should be number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (cntrlEmailFill == false)   //If user forgot writting sth in E-Mail part thismessage will remind him/her.
            {
                MessageBox.Show("You must enter an E-Mail adress", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                        
            else if (cntrlEmail == false)   //for checking if the E-Mail ends with '@anadolu.edu.tr' or not.
            {
                MessageBox.Show("Your E-Mail adress must finish with '@anadolu.edu.tr'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else   //also as an user I prefer be warned in step by step than all warnings are raining on me. So I thought 'direction arrows' are more usefull.
            {      //because of that I have to change the enable property frequently for preventing confusion. 
                grbFirm.Enabled = true;
                BridgeBtn2.Enabled = true;
                BridgeBackBtn1.Enabled = true;
                grbStudent.Enabled = false;
                BridgeBtn1.Enabled = false;
            }
        }

        private bool fullfill(string x, string y, string z, string t)   //for more dinamic fullfill controle; I add 4 input strings; 1st fillful part has 3 strings and second has 4 strings...
        {
            bool b = false;
            if (x.Length != 0 && y.Length != 0 && z.Length != 0 && t.Length != 0)
                b = true;

            return b;
        }

        private bool IDcontrol(string x)   //in ID number of digits has to be 11.
        {            
            bool b = false;
            if (x.Length == 11)
                b = true;
           
            return b;
        }

        private bool ID_num_Control(string x)
        {
            bool b = x.All(char.IsDigit);            
            return b;
        }

        private bool E_Mail_fill(string x)   //this function is different from fullfill function because in the textbox there have been already written '@anadolu.edu.tr'; so string length have already been different from zero. 
        {
            bool b = false;
            int index = x.IndexOf('@');
            string y = x.Remove(index);
            if (y.Length != 0)
            {
                b = true;
            }
            return b;
        }

        private bool E_Mail_Control(string x)   //E-Mail should end with '@anadolu.edu.tr'.
        {
            bool b = false;
            for(int i = 0; i < x.Length-10; i++)
            {
                if (x.Substring(i) == "@anadolu.edu.tr")
                {
                    b = true;
                    break;
                }                                
            }
            return b;
        }

        private void BridgeBackBtn1_Click(object sender, EventArgs e)
        {
            grbStudent.Enabled = true;   //if user wants to change an information he/she can change by these BridgeBack buttons.
            BridgeBtn1.Enabled = true;   //changes in enable proprties are for guaranteeing no mistakes again and again.
            grbFirm.Enabled = false;
            BridgeBtn2.Enabled = false;
            BridgeBackBtn1.Enabled = false;
        }

        private void BridgeBtn2_Click(object sender, EventArgs e)
        {
            bool cntrlFfull = fullfill(tbFName.Text, cbCity.Text, tbWeb.Text, cbEngineer.Text);
            if (cntrlFfull == false)   //for controlling is there any empty places left in firm groupbox.
            {
                MessageBox.Show("You must enter all asked information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else   //I chose radio button's(for No choice) checked property true at the begining of design.So I don't have to check if they are empty of not. They can't be empty anymore.
            {
                grbFirm.Enabled = false;          
                BridgeBackBtn1.Enabled = false;  
                BridgeBtn2.Enabled = false;
                grbInternship.Enabled = true;   //if there is no problem in the grbfirm, they can go to next part.
                BridgeBackBtn2.Enabled = true;
                SubmitBtn.Enabled = true;
            }
        }

        private void BridgeBackBtn2_Click(object sender, EventArgs e)
        {
            grbInternship.Enabled = false;
            BridgeBackBtn2.Enabled = false;   //if user wants to change an information he/she can change by these BridgeBack buttons.
            grbFirm.Enabled = true;           //changes in enable proprties are for guaranteeing no mistakes again and again.
            BridgeBackBtn1.Enabled = true;
            BridgeBtn2.Enabled = true;
            SubmitBtn.Enabled = false;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (calculate_semester() == false)   //for checking if user finis 4 semester or not.
            {
                MessageBox.Show("You are not appropriate for internship: You haven't finished 4 semester yet.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if (course_selection() == false)   //for checking if user took and finised all required courses.
            {
                MessageBox.Show("You are not appropriate for internship: You haven't finished all required courses yet.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if (control_manifacturing() == false)   //for checking if there is manifacturing workshop in firm or not.
            {
                MessageBox.Show("The firm is not appropriate for internship: It doesn't have any manifacturing workshop.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if (control_engineer_num() == false)   //for checking number of engineers in firm.
            {
                MessageBox.Show("The firm is not appropriate for internship: It doesn't have any engineer.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if (calculate_saturdays(20) == false)   //for calculating #of working days with or without saturday. 
            {
                MessageBox.Show("Internship process is not appropriate: You must work 20 workdays.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else   //This message is for if user's form is accepted.
            {
                MessageBox.Show("You are accepted for internship.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BridgeBackBtn2.Enabled = false;   //for finishing user entry process.(be accepted or not)
            grbInternship.Enabled = false;
            SubmitBtn.Enabled = false;
        }

        private bool calculate_semester()
        {
            bool b = false;
            DateTime today = DateTime.Now;   //today's date
            DateTime start_dep = Convert.ToDateTime(dtpSDate.Value);   //selected date in grbStudent
            TimeSpan difference = today - start_dep;   //difference between this two dates
            double differ = Convert.ToDouble(difference.TotalDays);  
            if (differ > 730)   //if the difference is bigger than 2 years, there will be no problem in internship.
            {
                b = true;
            }

            return b;
        }

        private bool course_selection()
        {
            bool b = false;   //if user select all check boxes, there will be no problem in internship.
            if (chbBİL255.Checked == true && chbBİM211.Checked == true && chbENM102.Checked == true && chbENM214.Checked == true)
                b = true;

            return b;
        }

        private bool control_manifacturing()
        {
            bool b = false;
            if (rbYesM.Checked == true)   //if the firm has manifacturing workshop, there will be no problem in internship.
                b = true;

            return b;
        }

        private bool control_engineer_num()
        {
            bool b = true;
            if (cbEngineer.Text == "Non")   //if there is at least one engineer in firm, there will be no problem in internship.
                b = false;

            return b;
        }

        private bool calculate_saturdays(int work_day_num)
        {
            bool b = false;            
            int num_of_day = 0;   //this variable is counter

            if (rbYesS.Checked == true)   //if user chose saturday as a workday...
            {
                do
                {
                    if(dtpSDateIntern.Value.DayOfWeek != DayOfWeek.Sunday)   //if the beginning day is different from sunday; 'counter' will increase(+1).
                    {
                        num_of_day++;
                    }
                    dtpSDateIntern.Value = dtpSDateIntern.Value.AddDays(1);   //then, the beginning date will increase(+1).
                }
                while (dtpSDateIntern.Value <= dtpEDateIntern.Value);   //untill the date reach to the ending day.
                if (num_of_day == work_day_num)   
                    b = true;   //when the loop finished; if counter equals the conditional workday(20), there will be no problem in internship.
            }
            else   //if user didn't chose saturday as a workday...
            {
                do
                {
                    if(dtpSDateIntern.Value.DayOfWeek != DayOfWeek.Saturday && dtpSDateIntern.Value.DayOfWeek != DayOfWeek.Sunday)   //if the beginning day is different from saturday or sunday; 'counter' will increase(+1).
                    {
                        num_of_day++;
                    }
                    dtpSDateIntern.Value = dtpSDateIntern.Value.AddDays(1);   //then, the beginning date will increase(+1).
                }
                while (dtpSDateIntern.Value <= dtpEDateIntern.Value);   //untill the date reach to the ending day.
                if (num_of_day == work_day_num)
                    b = true;   //when the loop finished; if counter equals the conditional workday(20), there will be no problem in internship.
            }

            return b;
        }
    }
    
}
