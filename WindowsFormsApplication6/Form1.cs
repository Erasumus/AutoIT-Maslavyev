using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace MaslavyevAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AutoItX3Lib.AutoItX3 code = new AutoItX3Lib.AutoItX3();
        
        //AUTOITX3 НАСТРОЙКА БОТА НАЖАТИЙ F5

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true; //Включить timer
                int interval = int.Parse(textBox1.Text); //Ввести сколько секунд щелкать определенную клавишу.
                timer1.Interval = interval * 1000;
            }
            catch //Условие для того, чтобы если не введено было значение
            {
                timer1.Enabled = false;
                MessageBox.Show("Вы не ввели таймер.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; //остановить.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            code.ControlSend("Dota2", "", "", "{F5}"); //Щелкать {S} определенному приложению "GAME" допустим вместо "GAME" будет игра "Dota2" и там для применения игры нужно щелкать "F5" 
        }

    
        //AUTOITX3 SHOW VERSION MessageBOX

        private void button3_Click(object sender, EventArgs e)
        {
            code.MouseMove(0, 0, 10); //Перемещение мышки.
            code.Sleep(100);
            if(code.error == 0)
            {
                MessageBox.Show("Verison 1.0");
            }
        }

        //БОТ СООБЩЕНИЙ, НЕОБХОДИМО ОТКРЫТЬ БЛОКНОТ И БУДЕТ СПАМИТЬ, КАЖДЫЙ РАЗ ПОСЛЕ ВВОДА ПРОЖИМАТЬ ENTER.

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox2.Text); //Вводить значения из текстового поля.
            SendKeys.Send("{ENTER}"); //Щелкать при вводе.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start(); //Начать 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Stop(); //Остановить
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
