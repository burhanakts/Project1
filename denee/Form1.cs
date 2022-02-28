using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using Konuşma_yakalayıcı;

namespace denee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ChromeDriver driver = new ChromeDriver();
        private void Form1_Load(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://ceviri.yandex.com.tr/?lang=tr-en");
            //driver.FindElement(By.Id("tta_srcsl")).SendKeys("Türkçe");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //driver.FindElement(By.Id("tta_playiconsrc")).Click();
            driver.FindElement(By.Id("textSpeaker")).Click();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
            //driver.FindElement(By.Id("tta_input_ta")).Clear();
            driver.FindElement(By.Id("fakeArea")).Clear();
            driver.FindElement(By.Id("fakeArea")).SendKeys(textBox1.Text);
            //driver.FindElement(By.Id("tta_input_ta")).SendKeys(textBox1.Text);
            //driver.FindElement(By.Id("tta_playiconsrc")).Click();
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = a.ToString();
            a++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.FindElement(By.Id("microphone")).Click();
        }
    }
}
