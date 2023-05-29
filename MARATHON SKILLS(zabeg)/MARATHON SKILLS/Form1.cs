using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARATHON_SKILLS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true; pictureBox3.Visible = true; 
            pictureBox6.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false;
            label1.Visible = true;
            label1.Text = "МЦК Лужники";
            label2.Visible = true; label3.Visible = true;
            label4.Visible = false; label5.Visible = false; label6.Visible = false;
            label7.Visible = false; label8.Visible = false;
            pictureBox5.Location = new Point(522, 352);
            label6.Location = new Point(631, 378);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible=true; pictureBox3.Visible=true; pictureBox6.Visible=true; pictureBox4.Visible=true; pictureBox5.Visible=true;
            label1.Visible = true;
            label1.Text = "Новодевичий монастырь";
            label2.Visible=true; label3.Visible=true;label4.Visible=true; label5.Visible=true;label6.Visible=true;
            label7.Visible = false; label8.Visible = false;
            pictureBox5.Location = new Point(522, 352);
            label6.Location = new Point(631, 378);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible=true; pictureBox3.Visible=true ;pictureBox6.Visible=true ;
            pictureBox4.Visible=false; pictureBox5.Visible=false ;
            label1.Visible = true;
            label1.Text = "Метро Киевская";
            label2.Visible = true; label3.Visible = true; label4.Visible=true;
            label5.Visible=false; label6.Visible=false; 
            label7.Visible=false;label8.Visible=false;
            pictureBox5.Location = new Point(522, 352);
            label6.Location = new Point(631, 378);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible= true; pictureBox3.Visible=true ; pictureBox6.Visible=true ;pictureBox5.Visible = true ;
            pictureBox4.Visible = false;
            label1.Visible = true;
            label1.Text = "МИД";
            label2.Visible=true ;label3.Visible = true; label4.Visible = true;label6.Visible = true;
            label5.Visible = false;
            label7.Visible= false;label8.Visible = false;
            pictureBox5.Location= new Point(522, 282);
            label6.Location = new Point(631, 306);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible= true; pictureBox3.Visible=true ;pictureBox6.Visible= true ;pictureBox4.Visible = true ;
            pictureBox5.Visible=false;
            label1.Visible = true;
            label1.Text = "Парк Горького";
            label2.Visible = true; label3.Visible=true; label4.Visible = true;label5.Visible=true;
            label6.Visible=false;
            label7.Visible=false;label8.Visible= false;
            pictureBox5.Location = new Point(522, 352);
            label6.Location = new Point(631, 378);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible= true; pictureBox3.Visible=true ;pictureBox6.Visible = true ;
            pictureBox4.Visible = false ; pictureBox5.Visible = false;
            label1.Visible = true;
            label1.Text = "Здание РАН";
            label2.Visible = true; label3.Visible = true; label4.Visible = true;
            label5.Visible=false;label6.Visible=false;
            label7.Visible = false;label8.Visible=false;
            pictureBox5.Location = new Point(522, 352);
            label6.Location = new Point(631, 378);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox6.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true;
            label1.Visible = true;
            label1.Text = "Метро Воробьёвы горы";
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            label7.Visible = false; label8.Visible = false;
            pictureBox5.Location = new Point(522, 352);
            label6.Location = new Point(631, 378);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox6.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true;
            label1.Visible = true;
            label1.Text = "Станция Лужники";
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            label7.Visible = false; label8.Visible = false;
            pictureBox5.Location = new Point(522, 352);
            label6.Location = new Point(631, 378);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox6.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false;
            label1.Visible = false;
            label2.Visible = false; label3.Visible = false;label4.Visible = false; label5.Visible = false; label6.Visible = false;
            label7.Visible = true; label8.Visible = true;
            label7.Text = "Старт марафона"; label8.Text = "Полный забег: 40 км";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox6.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false;
            label1.Visible = false;
            label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
            label7.Visible = true; label8.Visible = true;
            label7.Text = "Старт марафона"; label8.Text = "Неполный забег: 20 км";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox6.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false;
            label1.Visible = false;
            label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
            label7.Visible = true; label8.Visible = true;
            label7.Text = "Старт марафона"; label8.Text = "Неполный забег: 5 км";
        }
    }
}
