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
///Гусач Урок 7 ДЗ задача № 1
///
/// Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
/// Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
/// должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
/// Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте
/// обобщенный класс Stack.
/// 
/// </summary>
namespace Задача__1
{
    public partial class Form1 : Form
    {
        Stack<string> answers = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
            
        }        

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            clicks.Text = (int.Parse(clicks.Text) + 1).ToString();
            answers.Push(lblNumber.Text);
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            clicks.Text = (int.Parse(clicks.Text) + 1).ToString();
            answers.Push(lblNumber.Text);
        }

        private void btnCommand3_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            clicks.Text = "0";
            aimNumber.Text = "";
            answers.Clear();
        }

        private void btnCommand4_Click(object sender, EventArgs e)
        {
            lblNumber.Text = answers.Pop();
            clicks.Text = (int.Parse(clicks.Text) + 1).ToString();
        }

        private void btnCommand5_Click(object sender, EventArgs e)
        {
            Random aim=new Random();
            int A = aim.Next(0, int.MaxValue);
            aimNumber.Text = A.ToString();
        }
    }
}
