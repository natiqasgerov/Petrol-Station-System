
using System.Media;

namespace Lesson3
{
    public partial class Form1 : Form
    {
        public Dictionary<float, string> Data = new()
        {
            { 1.0f, "A-92" },
            { 1.25f, "A-95" },
            { 1.6f, "A-98" },
            { 0.8f, "Dizel" },
        };

        public List<float> Values = new() { 1.5f,1.8f ,2.3f , 1.0f , 1.0f, 1.20f };

        public float Sum { get; set; }
        public float Sum1 { get; set; } = 0;
        public float Result { get; set; }

        public SoundPlayer soundPlayer1;

        public Form1()
        {
            InitializeComponent();
            soundPlayer1 = new SoundPlayer("music2.wav");
            soundPlayer1.PlayLooping();

            foreach (var item in Data.Values)
            {
                comboBoxBenzin.Items.Add(item);
            }
            comboBoxBenzin.SelectedItem = Data.Values.First();
            
            textBox3.Text =Values[0].ToString();
            textBox5.Text =Values[1].ToString();
            textBox8.Text =Values[2].ToString();
            textBox10.Text =Values[3].ToString();
            textBox12.Text =Values[4].ToString();
            textBox14.Text =Values[5].ToString();
            textBox4.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox13.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = Data.Keys.ElementAt(comboBoxBenzin.SelectedIndex).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = !radioButton1.Checked;
            textBox2.Text = null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = !radioButton2.Checked;
            textBox1.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                label1.Text = "0";
            else
            {
                var a = float.Parse(textBox1.Text);
                var b = float.Parse(textBoxPrice.Text);
                Sum1 = a * b;
                label1.Text = (a * b).ToString();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
                label1.Text = "0";
            else
            {
                label1.Text = textBox2.Text;
                Sum1 = float.Parse(textBox2.Text);
            }
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = !checkBox1.Checked;
            textBox4.Text = null;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
                label4.Text = "0";
            else
            {
                var count = float.Parse(textBox4.Text);
                var res = count * Values[0];
                Sum += res;
                label4.Text = Sum.ToString();

            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = !checkBox4.Checked;
            textBox6.Text = null;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
                label4.Text = "0";
            else
            {
                var count = float.Parse(textBox6.Text);
                var res = count * Values[1];
                Sum += res;
                label4.Text = Sum.ToString();

            }
                
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.ReadOnly = !checkBox3.Checked;
            textBox7.Text = null;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
                label4.Text = "0";
            else
            {
                var count = float.Parse(textBox7.Text);
                var res = count * Values[2];
                Sum += res;
                label4.Text = Sum.ToString();

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.ReadOnly = !checkBox7.Checked;
            textBox9.Text = null;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
                label4.Text = "0";
            else
            {
                var count = float.Parse(textBox9.Text);
                var res = count * Values[3];
                Sum += res;
                label4.Text = Sum.ToString();

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.ReadOnly = !checkBox8.Checked;
            textBox11.Text = null;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox11.Text))
                label4.Text = "0";
            else
            {
                var count = float.Parse(textBox11.Text);
                var res = count * Values[4];
                Sum += res;
                label4.Text = Sum.ToString();

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox13.ReadOnly = !checkBox6.Checked;
            textBox13.Text = null;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox13.Text))
                label4.Text = "0";
            else
            {
                var count = float.Parse(textBox13.Text);
                var res = count * Values[5];
                Sum += res;
                label4.Text = Sum.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer1.Stop();
            SoundPlayer soundPlayer = new SoundPlayer("music.wav");
           soundPlayer.Play();         
           Result = Sum + Sum1;       
           label5.Text = Result.ToString();
           Thread.Sleep(970);
           soundPlayer1.Play();
           
           
        }
    }
}