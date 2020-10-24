using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string guessed_word = "Inception";
            string guessing_word = "";
            int start_count = 0;
            int attempt_limit = 3;
            bool No_more_guesses = false;
           

            while (guessed_word != guessing_word && !No_more_guesses )
            {

                if (start_count < attempt_limit)
                {
                    textBox1.Text = "Enter your guessing word: ";
                    start_count++;
                }
                else
                {
                    No_more_guesses = true;
                    textBox1.Text = "Sorry! Try again: ";
                }             

            }
            if (No_more_guesses)
            {
                textBox1.Text = "You lose!!";
            }
            else
            {
                textBox1.Text = "You have Won";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "WELCOME TO THE GUESSING GAME!!";
            label1.Text = "Please check the hints for the word: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Film was released in 2013: ");
            MessageBox.Show("Actor: Leonardo Docaprio: ");
            MessageBox.Show("Director: Christopher Nolan: ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter your guessing word:";
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter another guess: ";
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Opps!! Last chance: ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on submit, after finishing");
        } 
    }
}
