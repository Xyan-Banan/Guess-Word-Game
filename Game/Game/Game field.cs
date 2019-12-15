using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game_field : Form
    {
        public Game_field()
        {
            InitializeComponent();
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            words = new string[] { "карнавал", "ёлочка", "праздник", "дед мороз", "олень", "сюрприз", "зима", "снегурочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_image.Length;
            //pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            start_game(wordArea);
        }
        static string[] words;
        static string current_word;
        static string show_text;
        static int count_success;
        static int count_spaces;
        static int lives;
        static PictureBox[] lives_image;
        static void start_game (RichTextBox wordArea)
        {
            Random rnd = new Random();
            current_word = words[rnd.Next(0, words.Length)];
            wordArea.Text = get_show_text(current_word);
        }
        static string get_show_text (string word)
        {
            string result_string = "";
            for (int i = 0; i < word.Length; i++)
            {
                result_string += "—";
            }
            return result_string;
        }
        static void centering_text(RichTextBox word_area)
        {

        }
        static bool is_contains (string word,char symbol)
        {
           for (int i = 0; i < word.Length; i++)
           {
                if (word[i] == symbol)
                {
                    return true;
                }
           }
           return false;
        }
        static string get_new_show_text (string word, char symbol,string old_show_text)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i]==symbol)
                {
                    old_show_text = old_show_text.Remove(i, 1);
                    old_show_text = old_show_text.Insert(i, symbol.ToString());
                }
            }
            return old_show_text;
        }
        static void button_symbol_click (RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {
            if (is_contains(current_word, symbol))
            {
                wordArea.Text = get_new_show_text(current_word, symbol, wordArea.Text);
                if(is_contains(wordArea.Text, '—'))
                {
                    return;
                }
                else
                {
                    using (Saccess_form saccess_Form = new Saccess_form())
                    {
                        saccess_Form.ShowDialog();
                    }
                }
            }
            else 
            {
                lives--;
                lives_image[lives].Visible = false;
                if(lives > 0)
                {
                    return;
                }
                else
                {
                    using (Lose_form lose_Form = new Lose_form())
                    {
                        lose_Form.ShowDialog();
                    }
                }
            }
        }

        private void button01_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'а', button01, button21);
        }

        private void Button02_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'б', button02, button21);
        }

        private void Button03_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'в', button03, button21);
        }

        private void Button04_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'г', button04, button21);
        }

        private void Button05_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'д', button05, button21);
        }

        private void Button06_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'е', button06, button21);
        }

        private void Button07_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ё', button07, button21);
        }

        private void Button08_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ж', button08, button21);
        }

        private void Button09_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'з', button09, button21);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'и', button10, button21);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'й', button11, button21);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'к', button12, button21);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'л', button13, button21);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'м', button14, button21);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'н', button15, button21);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'о', button16, button21);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'п', button17, button21);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'р', button18, button21);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'с', button19, button21);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'т', button20, button21);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'у', button21, button21);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ф', button22, button21);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'х', button23, button21);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ц', button24, button21);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ч', button25, button21);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ш', button26, button21);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'щ', button27, button21);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ъ', button28, button21);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ы', button29, button21);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ь', button30, button21);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'э', button31, button21);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ю', button32, button21);
        }

        private void Button33_Click(object sender, EventArgs e)
        {

            button_symbol_click(wordArea, 'я', button33, button21);
        }
    }
}
