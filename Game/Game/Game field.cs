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
        static string[] words;
        static string current_word;
        static int lives;
        static PictureBox[] lives_image;
        public Game_field()
        {
            InitializeComponent();
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            words = new string[] { "карнавал", "ёлочка", "праздник", "дед мороз", "олень", "сюрприз", "зима", "снегурочка" };
            current_word = "";
            lives = lives_image.Length;
            start_game(wordArea);
        }
        static void start_game(RichTextBox wordArea)
        {
            Random rnd = new Random();
            current_word = words[rnd.Next(0, words.Length)];
            wordArea.Text = get_show_text(current_word);
            centering_text(wordArea);
        }
        static string get_show_text(string word)
        {
            string result_string = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    result_string += " ";
                }
                else
                {
                    result_string += "@";
                }
            }
            return result_string;
        }
        static void centering_text(RichTextBox word_area)
        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
        }
        static bool is_contains(string word, char symbol)
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
        static string get_new_show_text(string word, char symbol, string old_show_text)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    old_show_text = old_show_text.Remove(i, 1);
                    old_show_text = old_show_text.Insert(i, symbol.ToString());
                }
            }
            return old_show_text;
        }
        static void button_symbol_click(RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {
            if (is_contains(current_word, symbol))
            {
                string new_show_text = get_new_show_text(current_word, symbol, wordArea.Text);
                wordArea.Text = new_show_text;
                centering_text(wordArea);
            }
            else
            {
                lives--;
                lives_image[lives].Visible = false;
            }

            cur_button.Enabled = false;
            
            if (!is_contains(wordArea.Text, '@'))
            {
                using (SuccessForm successForm = new SuccessForm())
                {
                    successForm.ShowDialog();
                }
            }
            
            if (lives == 0)
            {
                using (LossForm lossForm = new LossForm())
                {
                    lossForm.ShowDialog();
                }
                startButton.PerformClick();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'а', button1, button21);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'б', button2, button21);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'в', button3, button21);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'г', button4, button21);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'д', button5, button21);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'е', button6, button21);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ё', button7, button21);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ж', button8, button21);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'з', button9, button21);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'и', button10, button21);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'й', button11, button21);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'к', button12, button21);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'л', button13, button21);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'м', button14, button21);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'н', button16, button21);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'о', button35, button21);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'п', button24, button21);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'р', button15, button21);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'с', button19, button21);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'т', button32, button21);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'у', button34, button21);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ф', button33, button21);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'х', button25, button21);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ц', button18, button21);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ч', button17, button21);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ш', button20, button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'щ', button22, button21);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ъ', button23, button21);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ы', button26, button21);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ь', button31, button21);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'э', button27, button21);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ю', button28, button21);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'я', button29, button21);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            start_game(wordArea);

            Button[] buttons = new Button[] { button1, button2, button3, button4, button5,
            button6, button7, button8, button9, button10, button11, button12, button13,
            button14, button15, button16, button17, button18, button19, button20, button21,
            button22, button23, button24, button25, button26, button27, button28, button29,
            button30, button31, button32, button33, button34, button35};

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
            }
        }
    }
}
