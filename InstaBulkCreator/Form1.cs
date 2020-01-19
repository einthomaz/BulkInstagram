using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.IO;
using DotTrick;

namespace InstaBulkCreator
{
    public partial class Form1 : Form
    {

        bool stopped = false;
        string pathToSeleniumChromeDriver = "";

        string[] names =
        {
            "Genna",
            "Wand",
            "Tawna",
            "Kinnison",
            "Jerold",
            "Cousins",
            "Katelin",
            "Haire",
            "Aura",
            "Lauer",
            "Bernadine",
            "Pelosi",
            "Shantell",
            "Dorner",
            "Marlys",
            "Lablanc",
            "Alisa",
            "Koren",
            "Joetta",
            "Belew",
            "Mabel",
            "Kettering",
            "Treva",
            "Brehm",
            "Lael",
            "Emond",
            "Casey",
            "Vogelsang",
            "Yuonne",
            "Underwood",
            "Hugo",
            "Mickelsen",
            "Nichelle",
            "Crace",
            "Julian",
            "Dupuis",
            "Nicky",
            "Kilkenny",
            "Edris",
            "Whiddon",
            "Anita",
            "Daughtry",
            "Ima",
            "Nero",
            "Martin",
            "Sheckler",
            "Dwayne",
            "Stiltner",
            "Marybeth",
            "Shock",
            "Evita",
            "Sowell",
            "Eleanor",
            "Tharpe",
            "Shirl",
            "Bryon",
            "Renetta",
            "Hopp",
            "Elvin",
            "Harvill",
            "Holli",
            "Hanney",
            "Masako",
            "Votaw",
            "Magdalen",
            "Wethington",
            "Rebekah",
            "Bellefeuille",
            "Mozella",
            "Dubon",
            "Myriam",
            "Pavlak",
            "Emelda",
            "Rugh",
            "Randall",
            "Ishida",
            "Yahaira",
            "Skillings",
            "Yan",
            "Islam",
            "Katia",
            "Lofton",
            "Claretha",
            "Blasingame",
            "Angelica",
            "Auslander",
            "Cole",
            "Swingle",
            "Lianne",
            "Ballard",
            "Trudie",
            "Bodin",
            "Cindi",
            "Ramsdell",
            "Marguerite",
            "Bachelor",
            "Pei",
            "Tawney",
            "Ivette",
            "Crater"
        };

        IWebDriver driver;
        string[] usernames;
        string[] passwords;
        string[] emails;
        string[] proxys;

        public string[] randomString(int number, int length)
        {
            Random rnd = new Random();
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
        public string[] parseTextFile(string pathToTextFile)
        {

            string text = System.IO.File.ReadAllText(pathToTextFile);
            return text.Split('\n');
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.ShowDialog();
            bunifuMetroTextbox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.ShowDialog();
            bunifuMetroTextbox3.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.ShowDialog();
            bunifuMetroTextbox2.Text = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.ShowDialog();
            bunifuMetroTextbox4.Text = openFileDialog1.FileName;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (pathToSeleniumChromeDriver == "")
            {
                MessageBox.Show("Please set the chromedriver location using the Chromedriver button on the top left!");
            }
            else
            {
                if (bunifuThinButton21.ButtonText == "Start")
                {
                    bunifuThinButton21.ButtonText = "Stop";
                    bunifuThinButton21.ForeColor = Color.DarkRed;
                    bunifuThinButton21.ActiveFillColor = Color.DarkRed;
                    bunifuThinButton21.ActiveLineColor = Color.DarkRed;
                    bunifuThinButton21.IdleLineColor = Color.DarkRed;
                    bunifuThinButton21.IdleForecolor = Color.DarkRed;


                    if (bunifuCheckbox1.Checked == false)
                    {
                        usernames = parseTextFile(bunifuMetroTextbox1.Text);
                    }

                    if (bunifuCheckbox2.Checked == false)
                    {
                        passwords = parseTextFile(bunifuMetroTextbox2.Text);
                    }

                    if (bunifuCheckbox3.Checked == false && bunifuCheckbox4.Checked == false)
                    {
                        emails = parseTextFile(bunifuMetroTextbox3.Text);
                    }

                    proxys = parseTextFile(bunifuMetroTextbox4.Text);


                    if (usernames.Length != passwords.Length || usernames.Length != emails.Length || passwords.Length != emails.Length)
                    {
                        MessageBox.Show("Different Number of Usernames and Passwords or Emails");
                        MessageBox.Show(String.Format("Usernames : {0}\nPasswords : {1}\nEmails : {2}", usernames.Length, passwords.Length, emails.Length));
                        return;
                    }


                    for (var i = 0; i < usernames.Length; i++)
                    {
                        if (stopped)
                        {
                            break;
                            return;
                        }
                        Thread startCrhome = new Thread(() => CreateInstagramAccount(usernames[i], passwords[i], emails[i], proxys[new Random().Next(0, proxys.Length - 1)]));
                        startCrhome.Start();
                        while (startCrhome.IsAlive)
                        {
                            Thread.Sleep(500);
                            Application.DoEvents();
                        }
                    }
                }
                else
                {
                    bunifuThinButton21.ButtonText = "Start";
                    bunifuThinButton21.ForeColor = Color.SeaGreen;
                    bunifuThinButton21.ActiveFillColor = Color.SeaGreen;
                    bunifuThinButton21.ActiveLineColor = Color.SeaGreen;
                    bunifuThinButton21.IdleLineColor = Color.SeaGreen;
                    bunifuThinButton21.IdleForecolor = Color.SeaGreen;
                    stopped = true;
                    return;
                }
            }

        }


        public void SaveToCSV(string username, string password, string email, string name, string proxy, string file)
        {
            using (var w = new StreamWriter(file))
            {
                var line = string.Format("{0},{1},{2},{3},{4}", username, password, email, name, proxy);
                w.WriteLine(line);
                w.Flush();
            }
        }

        public void CreateInstagramAccount(string username, string password, string email, string proxy)
        {
            if (stopped)
            {
                return;
            }

            var driverService = ChromeDriverService.CreateDefaultService(pathToSeleniumChromeDriver);
            driverService.HideCommandPromptWindow = true;

            var chromeOptions = new ChromeOptions();

            if (bunifuCheckbox5.Checked)
                chromeOptions.AddArgument("--headless");

            var prox = new Proxy();
            prox.HttpProxy = proxy;
            chromeOptions.Proxy = prox;

            driver = new ChromeDriver(driverService, chromeOptions);

            driver.Url = "https://www.instagram.com/accounts/emailsignup/";
            driver.Navigate();

            Thread.Sleep(1000);

            var inputs = driver.FindElement(By.TagName("input"));

            foreach (IWebElement elem in driver.FindElements(By.TagName("input")))
            {
                if (elem.GetAttribute("aria-label").Contains("E-Mail") == true)
                {
                    new Actions(driver).SendKeys(elem, email).Perform();
                } else if (elem.GetAttribute("aria-label").Contains("Name") == true && elem.GetAttribute("aria-label").Contains(" ") == true)
                {
                    new Actions(driver).SendKeys(elem, string.Format("{0} {1}", names[new Random().Next(0, names.Length - 1)], names[new Random().Next(0, names.Length - 1)])).Perform();
                } else if (elem.GetAttribute("aria-label").Contains("ername") == true)
                {
                    new Actions(driver).SendKeys(elem, username).Perform();
                } else if (elem.GetAttribute("aria-label").Contains("Passw") == true)
                {
                    new Actions(driver).SendKeys(elem, password).Perform();
                }
            }

            Thread.Sleep(1000);

            if (driver.FindElements(By.ClassName("coreSpriteInputError")).Count > 0)
            {
                driver.Close();
                return;
            }


            new Actions(driver).Click(driver.FindElements(By.TagName("button"))[driver.FindElements(By.TagName("button")).Count - 1]).Perform();

            Thread.Sleep(1000);



            new Actions(driver).Click(driver.FindElement(By.Id("igCoreRadioButtonageRadioabove_18"))).Perform();
            new Actions(driver).Click(driver.FindElements(By.TagName("button"))[driver.FindElements(By.TagName("button")).Count - 1]).Perform();

            Thread.Sleep(5000);

            SaveToCSV(username, password, email, "Thomas Konan", proxy, Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Desktop\\save.csv"));

            driver.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = false;
            bunifuCheckbox2.Checked = false;
            bunifuCheckbox3.Checked = false;
            bunifuCheckbox4.Checked = false;
            bunifuCheckbox5.Checked = false;
            bunifuCustomLabel10.Text = string.Format("Number of Accounts : {0}", bunifuSlider1.Value.ToString());
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                bunifuCustomLabel10.Enabled = true;
                bunifuCustomLabel10.Visible = true;

                bunifuSlider1.Enabled = true;
                bunifuSlider1.Visible = true;

                usernames = randomString(bunifuSlider1.Value, 10);
            } else
            {
                bunifuCustomLabel10.Enabled = false;
                bunifuCustomLabel10.Visible = false;

                bunifuSlider1.Enabled = false;
                bunifuSlider1.Visible = false;
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            bunifuCustomLabel10.Text = string.Format("Number of Accounts : {0}", bunifuSlider1.Value.ToString());
            usernames = randomString(bunifuSlider1.Value, 10);
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                if (bunifuCheckbox2.Checked)
                    passwords = randomString(bunifuSlider1.Value, 10);
            } else
            {
                passwords = randomString(usernames.Length, 10);
            }
        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            RandomGenerator randomGenerator = new RandomGenerator();
            randomGenerator.Show();
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (bunifuCheckbox1.Checked)
            {
                if (bunifuCheckbox3.Checked)
                    emails = randomString(bunifuSlider1.Value, 10);
                for (var i = 0; i < emails.Length; i++)
                {
                    emails[i] = emails[i] + "@funnymail.de";
                }
            }
            else
            {
                emails = randomString(usernames.Length, 10);
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    pathToSeleniumChromeDriver = fbd.SelectedPath;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Before ticked just put your gmail in the emails field! F.e test@gmail.com");
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox4.Checked)
            {
                bunifuCheckbox3.Checked = false;

                var gmails = DotTrickClass.Generate(bunifuMetroTextbox3.Text, (bunifuCheckbox1.Checked) ? bunifuSlider1.Value+1 : usernames.Length+1);
                var result = String.Join(";", gmails.ToArray()).Split(';');

                emails = result;

                for(var i = 0; i < emails.Length; i++)
                {
                    emails[i] += "@gmail.com";
                }

                MessageBox.Show(String.Format("Generated : {0} Emails of of this Gmail", result.Length));
            } else
            {

            }
        }
    }
}
