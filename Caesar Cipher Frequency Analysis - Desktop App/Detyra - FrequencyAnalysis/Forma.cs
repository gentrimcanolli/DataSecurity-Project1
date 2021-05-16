using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detyra___FrequencyAnalysis
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
        }

        public const string ENGLISH_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static int ToNumber(char c)
        {
            return c - 'A'; // kthen poziten e karakterit c ne ENGLISH_ALPHABET
        }

        static int[] CountLetters(string message)   //fisnik
        {
            int[] letterCount = new int[ENGLISH_ALPHABET.Length];   // letterCount = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}

            foreach (char letter in message)    // itero neper karakteret e mesazhit
            {
                for (int i = 0; i < ENGLISH_ALPHABET.Length; i++)
                {
                    if (letter == ENGLISH_ALPHABET[i])  // nese ai karakter eshte pjese e alfabetit, count i tij rritet per 1
                    {
                        int position = ToNumber(letter);
                        letterCount[position] += 1;         
                    }
                }
            }

            return letterCount;
        }

        private void Decrypt(int _key)
        {
            int key = _key;

            List<string> plainText = new List<string>();

            foreach (String line in txtResult.Lines)    // iteron neper cdo rresht te tekstit ne textboxin txtResult
            {
                string ciphertext = line;

                StringBuilder sbPlaintext = new StringBuilder(ciphertext);

                for (int i = 0; i < ciphertext.Length; i++)
                {
                    char ch = ciphertext[i];
                    if (ch == ' ')
                    {
                        continue;
                    }
                    else if (Char.IsUpper(ch))
                    {
                        int characterPosition = ch - 'A';
                        characterPosition = (characterPosition - key + 26) % 26; // 0 - 3 = -3 ------- 0-3 = -3 + 26 = 23 % 26 = 23 

                        ch = (char)(characterPosition + 'A');
                        sbPlaintext[i] = ch;
                    }
                    else if (Char.IsLower(ch))
                    {
                        int characterPosition = ch - 'a';
                        characterPosition = (characterPosition - key + 26) % 26; 

                        ch = (char)(characterPosition + 'a');
                        sbPlaintext[i] = ch;
                    }
                    else
                    {
                        sbPlaintext[i] = ch;
                    }

                }

                plainText.Add(sbPlaintext.ToString());

            }

            txtResult.Text = "";

            foreach (String line in plainText)  // e shkruan rresht-per-rresht mesazhin e dekriptuar ne textbox 
            {
                txtResult.Text += line + "\n";
            }
        }


        // -------------------- BUTONAT ----------------------------------

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Open Text File";
            opf.Filter = "txt files (*.txt)|*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = opf.FileName;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";

            string extension = Path.GetExtension(txtFilePath.Text);
            if (extension != ".txt")
            {
                MessageBox.Show("Only files with .txt extension are allowed!");
                return;
            }

            List<string> lines = new List<string>();
            try
            {
                lines = File.ReadAllLines(txtFilePath.Text).ToList();   // lexo tekstin nga fajlli
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            foreach(String line in lines)
            {
                txtResult.Text += line + "\n";
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // nese ne momentin e klikimit te butonit nuk ka tekst ne txtResult 
            if (string.IsNullOrWhiteSpace(txtResult.Text))
            {
                MessageBox.Show("There's no text to encrypt!");
                return;
            }

            int key;

            EncryptDialog objEncryptDialog = new EncryptDialog();
            objEncryptDialog.ShowDialog();
            key = objEncryptDialog.celesi;

            List<string> cipherText = new List<string>();

            foreach(String line in txtResult.Lines)
            {
                string plaintext = line; 

                StringBuilder sbCiphertext = new StringBuilder(plaintext);
                for (int i = 0; i < plaintext.Length; i++)
                {
                    char ch = plaintext[i];
                    if (ch == ' ')
                    {
                        continue;
                    }
                   
                    else if (Char.IsUpper(ch))
                    {
                        int characterPosition = ch - 'A';
                        characterPosition = (characterPosition + key) % 26;

                        ch = (char)(characterPosition + 'A');
                        sbCiphertext[i] = ch;
                    }
                    else if (Char.IsLower(ch))
                    {
                        int characterPosition = ch - 'a';
                        characterPosition = (characterPosition + key) % 26;

                        ch = (char)(characterPosition + 'a');
                        sbCiphertext[i] = ch;
                    }
                    else
                    {
                        sbCiphertext[i] = ch;
                    }
                }

                cipherText.Add(sbCiphertext.ToString());
                
            }

            txtResult.Text = "";

            foreach (String line in cipherText)
            {
                txtResult.Text += line + "\n";
            }



            
        }

        

        

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            // nese ne momentin e klikimit te butonit nuk ka tekst ne txtResult
            if (string.IsNullOrWhiteSpace(txtResult.Text))
            {
                MessageBox.Show("There's no text to analize and decrypt!");
                return;
            }

            string message = txtResult.Text.ToUpper();

            int max = 0;
            int pozita = 0;


            int[] letterCount = CountLetters(message);

            //------------ gjen celesin
            for (int i = 0; i < letterCount.Length; i++)
            {
                if (letterCount[i] > max)
                {
                    max = letterCount[i];
                    pozita = i;
                }
            }

            int key = pozita - ToNumber('E');

            Decrypt(key);


            txtResult.Text += "\n";

            // -----------

            Analizo objAnaliza = new Analizo();     //krijohet objekti i klases Analizo
            objAnaliza._letterCount = letterCount;


            txtResult.Text += ("The most frequent letter was: " + ENGLISH_ALPHABET[pozita] + ". ");
            txtResult.Text += ("It appearead " + letterCount[pozita] + " times.\n");
            txtResult.Text += ("The key was: " + key);

            

            objAnaliza.ShowDialog();    //shfaqet chart
        }
    }
    
}
