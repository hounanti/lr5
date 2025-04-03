using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lr5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void TextBox1_TextChanged(object sender, EventArgs e)
            {
                CalculateResult();
            }

            private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                CalculateResult();
            }

            private void CalculateResult()
            {
                if (double.TryParse(textBox1.Text, out double input))
                {
                    string selectedFunction = listBox1.SelectedItem?.ToString();
                    if (selectedFunction != null)
                    {
                        switch (selectedFunction)
                        {
                            case "Тангенс":
                                textBox2.Text = Math.Tan(input).ToString();
                                break;
                            case "Синус":
                                textBox2.Text = Math.Sin(input).ToString();
                                break;
                            case "Логарифм":
                                if (input > 0)
                                {
                                    textBox2.Text = Math.Log(input).ToString();
                                }
                                else
                                {
                                    textBox2.Text = "Недопустимо";
                                }
                                break;
                            default:
                                textBox2.Text = "Выберите функцию";
                                break;
                        }
                    }
                }
                else
                {
                    textBox1.Text = "Введите число";
                }
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
                listBox1.Items.Add("Тангенс");
                listBox1.Items.Add("Синус");
                listBox1.Items.Add("Логарифм");
            }
        }
    }
