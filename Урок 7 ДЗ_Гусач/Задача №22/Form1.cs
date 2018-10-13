using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// Гусач Урок 7 ДЗ задача № 2
/// 
/// Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от
/// больше или меньше загаданное число введенного. Для ввода данных от человека
/// используется элемент TextBox.
/// 
/// </summary>
namespace Задача__22
{
    public partial class Form1 : Form
    {
        int n;
        string text;
        int answer;
        int answerP;
        int tries = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random r= new Random();
            n = r.Next(1, 100);
            textBoxAnswer.ReadOnly = false;
            labelTries.Text = "0";
            tries = 0;
            labelResult.Text = "";
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {            
            
        }

        private void enterAnswer_Click(object sender, EventArgs e)
        {
            
            tries++;
            labelTries.Text = tries.ToString();
            bool status = int.TryParse(textBoxAnswer.Text, out answerP);
            answer = answerP;
            if (answer < 1 || answer > 100)
            {
                labelResult.Text = "Number is not in range";
            }
            if (!status)
            {
                labelResult.Text = "That is not a valid number,or not a number at all!";
            }
            if (answer == n)
            {
                labelResult.Text = "Right!";
            }           
            if (answer > n && answer <= 100)
            {
                labelResult.Text = "Number is too big";
            }
            else if(answer < n && answer >0)
            {
                labelResult.Text = "Number is too low";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
