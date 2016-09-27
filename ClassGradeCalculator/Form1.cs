using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassGradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Disabled";
                textBox1.Visible = false;
                textBox8.Visible = false;
            }
            else
            {
                checkBox1.Text = "Enabled";
                textBox1.Visible = true;
                textBox8.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Text = "Disabled";
                textBox2.Visible = false;
                textBox9.Visible = false;
            }
            else
            {
                checkBox2.Text = "Enabled";
                textBox2.Visible = true;
                textBox9.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Text = "Disabled";
                textBox3.Visible = false;
                textBox10.Visible = false;
            }
            else
            {
                checkBox3.Text = "Enabled";
                textBox3.Visible = true;
                textBox10.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox4.Text = "Disabled";
                textBox4.Visible = false;
                textBox11.Visible = false;
            }
            else
            {
                checkBox4.Text = "Enabled";
                textBox4.Visible = true;
                textBox11.Visible = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox5.Text = "Disabled";
                textBox5.Visible = false;
                textBox12.Visible = false;
            }
            else
            {
                checkBox5.Text = "Enabled";
                textBox5.Visible = true;
                textBox12.Visible = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6.Text = "Disabled";
                textBox6.Visible = false;
                textBox13.Visible = false;
            }
            else
            {
                checkBox6.Text = "Enabled";
                textBox6.Visible = true;
                textBox13.Visible = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox7.Text = "Disabled";
                textBox7.Visible = false;
                textBox14.Visible = false;
            }
            else
            {
                checkBox7.Text = "Enabled";
                textBox7.Visible = true;
                textBox14.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valueStore = 0;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else if (double.TryParse(textBox1.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            else if (double.TryParse(textBox2.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            else if (double.TryParse(textBox3.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox3.Focus();
                return;
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            else if (double.TryParse(textBox4.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox4.Focus();
                return;
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }
            else if (double.TryParse(textBox5.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox5.Focus();
                return;
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            else if (double.TryParse(textBox6.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox6.Focus();
                return;
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            else if (double.TryParse(textBox7.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox7.Focus();
                return;
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            else if (double.TryParse(textBox8.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox8.Focus();
                return;
            }

            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            else if (double.TryParse(textBox9.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox9.Focus();
                return;
            }

            if (textBox10.Text == "")
            {
                textBox10.Text = "0";
            }
            else if (double.TryParse(textBox10.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox10.Focus();
                return;
            }

            if (textBox11.Text == "")
            {
                textBox11.Text = "0";
            }
            else if (double.TryParse(textBox11.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox11.Focus();
                return;
            }

            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }
            else if (double.TryParse(textBox12.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox12.Focus();
                return;
            }

            if (textBox13.Text == "")
            {
                textBox13.Text = "0";
            }
            else if (double.TryParse(textBox13.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox13.Focus();
                return;
            }

            if (textBox14.Text == "")
            {
                textBox14.Text = "0";
            }
            else if (double.TryParse(textBox14.Text, out valueStore) != true)
            {
                MessageBox.Show("Please enter a valid value");
                textBox14.Focus();
                return;
            }



            double earnedPoints, ofPoints, finalGrade;
            string letterGrade;


           
                
            earnedPoints = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text) +
                            double.Parse(textBox4.Text) + double.Parse(textBox5.Text) + double.Parse(textBox6.Text) +
                            double.Parse(textBox7.Text));

            ofPoints = (double.Parse(textBox8.Text) + double.Parse(textBox9.Text) + double.Parse(textBox10.Text)
                + double.Parse(textBox11.Text) + double.Parse(textBox12.Text) + double.Parse(textBox13.Text) + double.Parse(textBox14.Text));

            finalGrade = earnedPoints / ofPoints;

            if (finalGrade >= .90)
            {
                letterGrade = "A";
            }
            else if (finalGrade >= .80)
            {
                letterGrade = "B";
            }
            else if (finalGrade >= .70)
            {
                letterGrade = "C";
            }
            else if (finalGrade >= .60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            label23.Text = String.Format("Grade: {0} \t ({1:P})", letterGrade, finalGrade );

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was designed to give users flexibility from class to class\n"
                            + "to be able to calculate their overall grades accurately and efforlessly.\n"
                            + "Disable lines that you dont need by clicking the check boxes to the left\n"
                            + "of the un-needed line.\n\n\n\tDesigned and Programmed by: Jacques Wiese");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
