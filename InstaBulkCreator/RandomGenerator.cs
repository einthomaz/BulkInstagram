using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaBulkCreator
{
    public partial class RandomGenerator : Form
    {

        public string[] randomString(int number, int length, Random rnd)
        {
            
            string[] retStringArray = new string[number + 1];

            string charSet = "abcdefghijklmnopqrstuvwxyz";
            charSet += charSet.ToUpper();

            while (number >= 0)
            {
                string tempString = "";
                for (var i = 0; i < length; i++)
                {
                    tempString = tempString + charSet[rnd.Next(0, charSet.Length - 1)].ToString();
                }
                retStringArray[number] = tempString;
                number--;
            }

            return retStringArray;
        }

        public void writeStringListToFile(string[] stringList, string file)
        {
            using (StreamWriter writetext = new StreamWriter(file))
            {
                foreach (string val in stringList)
                {
                    writetext.Write(val + "\n");
                }
            }
            
        }
        public RandomGenerator()
        {
            InitializeComponent();
        }

        private void RandomGenerator_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = string.Format("Number of Accounts : {0}", bunifuSlider1.Value);
            bunifuCustomLabel2.Text = string.Format("Username Length : {0}", bunifuSlider2.Value);
            bunifuCustomLabel3.Text = string.Format("Password Length : {0}", bunifuSlider3.Value);
            bunifuCustomLabel4.Text = string.Format("Email Length : {0}", bunifuSlider4.Value);
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = string.Format("Number of Accounts : {0}", bunifuSlider1.Value);
            
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] emails = new string[bunifuSlider1.Value + 1];
            string[] usernames = new string[bunifuSlider1.Value+1];
            string[] passwords = new string[bunifuSlider1.Value + 1];

            if (bunifuCheckbox2.Checked)
                usernames = randomString(bunifuSlider1.Value, bunifuSlider2.Value, rnd);
            if (bunifuCheckbox3.Checked)
                passwords = randomString(bunifuSlider1.Value, bunifuSlider2.Value, rnd);
            if (bunifuCheckbox4.Checked)
            {
                emails = randomString(bunifuSlider1.Value, bunifuSlider2.Value, rnd);
                for(var i = 0; i < emails.Length; i++)
                {
                    emails[i] = emails[i] + "@funnymail.de";
                }
            }

            if (usernames[0] != null) {
                saveFileDialog1.FileName = "usernames.txt";
                saveFileDialog1.Filter = "Text Files|*.txt";
                saveFileDialog1.ShowDialog();
                writeStringListToFile(usernames, saveFileDialog1.FileName);
            }
            if(passwords[0] != null)
            {
                saveFileDialog1.FileName = "passwords.txt";
                saveFileDialog1.Filter = "Text Files|*.txt";
                saveFileDialog1.ShowDialog();
                writeStringListToFile(passwords, saveFileDialog1.FileName);
            }
            if(emails[0] != null)
            {
                saveFileDialog1.FileName = "emails.txt";
                saveFileDialog1.Filter = "Text Files|*.txt";
                saveFileDialog1.ShowDialog();
                writeStringListToFile(emails, saveFileDialog1.FileName);
            }
        }

        private void bunifuSlider2_ValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = string.Format("Username Length : {0}", bunifuSlider2.Value);

        }

        private void bunifuSlider3_ValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel3.Text = string.Format("Password Length : {0}", bunifuSlider3.Value);
            
        }

        private void bunifuSlider4_ValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel4.Text = string.Format("Email Length : {0}", bunifuSlider4.Value);
        }
    }
}
