using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = EMIRMONSTER\\SQLEXPRESS;Initial Catalog=QuizDatabase;Integrated Security = True");
        int sayaç = 0;
        int puan = 0;
        int zaman = 21;
        private void btnbasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;

            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;

            btnbasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            btnbasla.Text = "Sonraki";
            sayaç++;
            lblsoru2.Text = sayaç.ToString();

            if (sayaç ==1)
            {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from Questions order by NEWID()",baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
                {
                button1.Text = (oku["OptionA"].ToString());
                button2.Text = (oku["OptionB"].ToString());
                button3.Text = (oku["OptionC"].ToString());
                button4.Text = (oku["OptionD"].ToString());

                textBox1.Text = (oku["QuestionText"].ToString());
                lbldogru.Text = (oku["CorrectAnswer"].ToString());
                }
            baglan.Close();
            }
            if (sayaç ==2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Question6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["OptionA"].ToString());
                    button2.Text = (oku["OptionB"].ToString());
                    button3.Text = (oku["OptionC"].ToString());
                    button4.Text = (oku["OptionD"].ToString());

                    textBox1.Text = (oku["QuestionText"].ToString());
                    lbldogru.Text = (oku["CorrectAnswer"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Questions3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["OptionA"].ToString());
                    button2.Text = (oku["OptionB"].ToString());
                    button3.Text = (oku["OptionC"].ToString());
                    button4.Text = (oku["OptionD"].ToString());

                    textBox1.Text = (oku["QuestionText"].ToString());
                    lbldogru.Text = (oku["CorrectAnswer"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Questions4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["OptionA"].ToString());
                    button2.Text = (oku["OptionB"].ToString());
                    button3.Text = (oku["OptionC"].ToString());
                    button4.Text = (oku["OptionD"].ToString());

                    textBox1.Text = (oku["QuestionText"].ToString());
                    lbldogru.Text = (oku["CorrectAnswer"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 5)
            {
                btnbasla.Text = "Oyun Bitti";
                btnbasla.Enabled = false;

                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Questions5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["OptionA"].ToString());
                    button2.Text = (oku["OptionB"].ToString());
                    button3.Text = (oku["OptionC"].ToString());
                    button4.Text = (oku["OptionD"].ToString());

                    textBox1.Text = (oku["QuestionText"].ToString());
                    lbldogru.Text = (oku["CorrectAnswer"].ToString());
                }
                baglan.Close();
            }
            if (sayaç == 8)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblsoru2.Text = sayaç.ToString();
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            lbldogru.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text ==lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor= Color.Red;
            }
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
        }
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblzaman.Text = zaman.ToString();

            if (zaman == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnbasla.Enabled = true;
            }
        }
    }
}
