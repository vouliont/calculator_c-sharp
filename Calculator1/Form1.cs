using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        double chislo1 = 0;
        double chislo2 = 0;
        bool flag = false;
        string znak = "";
        string zriz = "";
        int znakPosh;


        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "0";
                    }
                    else
                    {
                        label1.Text = "0";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "0";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "0";
                        }
                    }
                }
                else
                {
                    label1.Text += "0";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "0";
                    }
                    else
                    {
                        label1.Text = "0";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "0";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "0";
                        }
                    }
                }
                else
                {
                    label1.Text += "0";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "1";
                    }
                    else
                    {
                        label1.Text = "1";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "1";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "1";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "1";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "1";
                    }
                }
                else
                {
                    label1.Text += "1";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "1";
                    }
                    else
                    {
                        label1.Text = "1";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "1";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "1";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "1";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "1";
                    }
                }
                else
                {
                    label1.Text += "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "2";
                    }
                    else
                    {
                        label1.Text = "2";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "2";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "2";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "2";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "2";
                    }
                }
                else
                {
                    label1.Text += "2";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "2";
                    }
                    else
                    {
                        label1.Text = "2";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "2";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "2";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "2";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "2";
                    }
                }
                else
                {
                    label1.Text += "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "3";
                    }
                    else
                    {
                        label1.Text = "3";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "3";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "3";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "3";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "3";
                    }
                }
                else
                {
                    label1.Text += "3";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "3";
                    }
                    else
                    {
                        label1.Text = "3";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "3";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "3";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "3";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "3";
                    }
                }
                else
                {
                    label1.Text += "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "4";
                    }
                    else
                    {
                        label1.Text = "4";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "4";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "4";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "4";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "4";
                    }
                }
                else
                {
                    label1.Text += "4";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "4";
                    }
                    else
                    {
                        label1.Text = "4";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "4";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "4";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "4";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "4";
                    }
                }
                else
                {
                    label1.Text += "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "5";
                    }
                    else
                    {
                        label1.Text = "5";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "5";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "5";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "5";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "5";
                    }
                }
                else
                {
                    label1.Text += "5";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "5";
                    }
                    else
                    {
                        label1.Text = "5";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "5";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "5";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "5";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "5";
                    }
                }
                else
                {
                    label1.Text += "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "6";
                    }
                    else
                    {
                        label1.Text = "6";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "6";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "6";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "6";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "6";
                    }
                }
                else
                {
                    label1.Text += "6";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "6";
                    }
                    else
                    {
                        label1.Text = "6";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "6";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "6";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "6";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "6";
                    }
                }
                else
                {
                    label1.Text += "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "7";
                    }
                    else
                    {
                        label1.Text = "7";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "7";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "7";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "7";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "7";
                    }
                }
                else
                {
                    label1.Text += "7";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "7";
                    }
                    else
                    {
                        label1.Text = "7";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "7";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "7";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "7";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "7";
                    }
                }
                else
                {
                    label1.Text += "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "8";
                    }
                    else
                    {
                        label1.Text = "8";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "8";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "8";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "8";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "8";
                    }
                }
                else
                {
                    label1.Text += "8";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "8";
                    }
                    else
                    {
                        label1.Text = "8";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "8";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "8";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "8";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "8";
                    }
                }
                else
                {
                    label1.Text += "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "9";
                    }
                    else
                    {
                        label1.Text = "9";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "0")
                    {
                        label1.Text += "9";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 1)
                    {
                        if (label1.Text.Substring(znakPosh + 2, 1) == ",")
                        {
                            label1.Text += "9";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "9";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "9";
                    }
                }
                else
                {
                    label1.Text += "9";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && label1.Text != "0" && label1.Text != "Error")
                    {
                        label1.Text += "9";
                    }
                    else
                    {
                        label1.Text = "9";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1)
                {
                    if (label1.Text.Substring(znakPosh + 2, 1) != "0")
                    {
                        label1.Text += "9";
                    }
                    else if (label1.Text.Length - 1 > znakPosh + 2)
                    {
                        if (label1.Text.Substring(znakPosh + 3, 1) == ",")
                        {
                            label1.Text += "9";
                        }
                        else
                        {
                            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                            label1.Text += "9";
                        }
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                        label1.Text += "9";
                    }
                }
                else
                {
                    label1.Text += "9";
                }
            }
        }

        private void buttonSimvol_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Substring(1).Contains("+")) &&
                !(label1.Text.Substring(1).Contains("-")) &&
                !(label1.Text.Substring(1).Contains("×")) &&
                !(label1.Text.Substring(1).Contains("÷")))
            {
                if ((label1.Text.Length != 1 && !(label1.Text.Length == 2 && label1.Text.Substring(0, 1) == "-")) &&
                    flag == false && label1.Text != "-0,")
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                }
                else
                {
                    label1.Text = "0";
                    flag = false;
                }
            }
            else
            {
                if (label1.Text.Substring(1).Contains("+"))
                {
                    znakPosh = label1.Text.Substring(1).IndexOf("+") + 1;
                }
                else if (label1.Text.Substring(1).Contains("×"))
                {
                    znakPosh = label1.Text.Substring(1).IndexOf("×") + 1;
                }
                else if (label1.Text.Substring(1).Contains("÷"))
                {
                    znakPosh = label1.Text.Substring(1).IndexOf("÷") + 1;
                }
                else if (label1.Text.Substring(1).Contains("-"))
                {
                    znakPosh = label1.Text.Substring(1).IndexOf("-") + 1;
                }
                if (label1.Text.Length - 1 != znakPosh)
                {
                    if (!(label1.Text.Substring(znakPosh + 1).Length == 2 && label1.Text.Substring(znakPosh + 1, 1) == "-") &&
                        label1.Text.Substring(znakPosh + 1) != "-0," && flag == false)
                    {
                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                    }
                    else
                    {
                        label1.Text = label1.Text.Substring(0, znakPosh + 1);
                    }
                }
                else
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                }
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void buttonKvadrat_Click(object sender, EventArgs e)
        {
                if (label1.Text != "Error" &&
                    !(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    chislo1 = Convert.ToDouble(label1.Text);
                    label1.Text = Convert.ToString(chislo1 * chislo1);
                }
                else
                {
                    label1.Text = "Error";
                }
            flag = true;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Error" &&
                !(label1.Text.Contains("+")) &&
                !(label1.Text.Contains("-")) &&
                !(label1.Text.Contains("×")) &&
                !(label1.Text.Contains("÷")))
            {
                chislo1 = Convert.ToDouble(label1.Text);
                label1.Text = Convert.ToString(Math.Sqrt(chislo1));
            }
            else
            {
                label1.Text = "Error";
            }
            flag = true;
        }

        private void button1Dilx_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0" && label1.Text != "-0," && label1.Text != "Error" &&
                !(label1.Text.Substring(1).Contains("+")) &&
                !(label1.Text.Substring(1).Contains("-")) &&
                !(label1.Text.Substring(1).Contains("×")) &&
                !(label1.Text.Substring(1).Contains("÷")))
            {
                chislo1 = Convert.ToDouble(label1.Text);
                if (chislo1 != 0)
                {
                    label1.Text = Convert.ToString(1 / chislo1);
                }
                else
                {
                    label1.Text = "Error";
                }
            }
            else
            {
                label1.Text = "Error";
            }
            flag = true;
        }

        private void buttonKoma_Click(object sender, EventArgs e)
        {
            if (label1.Text.Substring(0, 1) != "-")
            {
                znakPosh = label1.Text.IndexOf(znak);
                if (!(label1.Text.Contains("+")) &&
                    !(label1.Text.Contains("-")) &&
                    !(label1.Text.Contains("×")) &&
                    !(label1.Text.Contains("÷")))
                {
                    if (flag == false && !(label1.Text.Contains(",")) && label1.Text != "Error")
                    {
                        label1.Text += ",";
                        flag = false;
                    }
                    else if (flag != false)
                    {
                        label1.Text = "0,";
                        flag = false;
                    }
                    else if (label1.Text == "Error")
                    {
                        label1.Text = "0,";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh && label1.Text != "Error")
                {
                    if (!(label1.Text.Substring(znakPosh + 1).Contains(",")))
                    {
                        label1.Text += ",";
                    }
                }
                else if (label1.Text.Length - 1 == znakPosh && label1.Text != "Error")
                {
                    label1.Text += "0,";
                }
            }
            else
            {
                znakPosh = label1.Text.Substring(1).IndexOf(znak);
                if (!(label1.Text.Substring(1).Contains("+")) &&
                    !(label1.Text.Substring(1).Contains("-")) &&
                    !(label1.Text.Substring(1).Contains("×")) &&
                    !(label1.Text.Substring(1).Contains("÷")))
                {
                    if (flag == false && !(label1.Text.Contains(",")) && label1.Text != "Error")
                    {
                        label1.Text += ",";
                        flag = false;
                    }
                    else if (flag != false)
                    {
                        label1.Text = "0,";
                        flag = false;
                    }
                    else if (label1.Text == "Error")
                    {
                        label1.Text = "0,";
                        flag = false;
                    }
                }
                else if (label1.Text.Length - 1 > znakPosh + 1 && label1.Text != "Error")
                {
                    if (!(label1.Text.Substring(znakPosh + 2).Contains(",")))
                    {
                        label1.Text += ",";
                    }
                }
                else if (label1.Text.Length - 1 == znakPosh + 1 && label1.Text != "Error")
                {
                    label1.Text += "0,";
                }
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Substring(1).Contains("+")) &&
                !(label1.Text.Substring(1).Contains("-")) &&
                !(label1.Text.Substring(1).Contains("×")) &&
                !(label1.Text.Substring(1).Contains("÷")) && label1.Text != "Error")
            {
                chislo1 = Convert.ToDouble(label1.Text);
                label1.Text += "+";
                zriz = label1.Text;
                znak = "+";
                flag = false;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Substring(1).Contains("+")) &&
                !(label1.Text.Substring(1).Contains("-")) &&
                !(label1.Text.Substring(1).Contains("×")) &&
                !(label1.Text.Substring(1).Contains("÷")) && label1.Text != "Error")
            {
                chislo1 = Convert.ToDouble(label1.Text);
                label1.Text += "-";
                zriz = label1.Text;
                znak = "-";
                flag = false;
            }
        }

        private void buttonMnozh_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) &&
                !(label1.Text.Substring(1).Contains("-")) &&
                !(label1.Text.Substring(1).Contains("×")) &&
                !(label1.Text.Substring(1).Contains("÷")) && label1.Text != "Error")
            {
                chislo1 = Convert.ToDouble(label1.Text);
                label1.Text += "×";
                zriz = label1.Text;
                znak = "×";
                flag = false;
            }
        }

        private void buttonDil_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Substring(1).Contains("+")) &&
                !(label1.Text.Substring(1).Contains("-")) &&
                !(label1.Text.Substring(1).Contains("×")) &&
                !(label1.Text.Substring(1).Contains("÷")) && label1.Text != "Error")
            {
                chislo1 = Convert.ToDouble(label1.Text);
                label1.Text += "÷";
                zriz = label1.Text;
                znak = "÷";
                flag = false;
            }
        }

        private void buttonDorivn_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("+") ||
                label1.Text.Contains("-") ||
                label1.Text.Contains("×") ||
                label1.Text.Contains("÷"))
            {
                chislo2 = Convert.ToDouble(label1.Text.Substring(zriz.Length));
                switch (znak)
                {
                    case "+":
                        label1.Text = Convert.ToString(chislo1 + chislo2);
                        break;
                    case "-":
                        label1.Text = Convert.ToString(chislo1 - chislo2);
                        break;
                    case "×":
                        label1.Text = Convert.ToString(chislo1 * chislo2);
                        break;
                    case "÷":
                        if (chislo2 == 0)
                        {
                            label1.Text = "Error";
                        }
                        else
                        {
                            label1.Text = Convert.ToString(chislo1 / chislo2);
                        }
                        break;
                }
            }
            flag = true;
        }

        private void buttonZnak_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Substring(1).Contains("+")) &&
                !(label1.Text.Substring(1).Contains("-")) &&
                !(label1.Text.Substring(1).Contains("×")) &&
                !(label1.Text.Substring(1).Contains("÷")) && label1.Text != "Error" && label1.Text != "0")
            {
                if (label1.Text.Substring(0, 1) != "-")
                {
                    label1.Text = "-" + label1.Text;
                }
                else
                {
                    label1.Text = label1.Text.Remove(0, 1);
                }
            }
            else if (label1.Text != "Error" && label1.Text != "0")
            {
                if (label1.Text.Contains("+"))
                {
                    znakPosh = label1.Text.IndexOf("+");
                }
                else if (label1.Text.Contains("×"))
                {
                    znakPosh = label1.Text.IndexOf("×");
                }
                else if (label1.Text.Contains("÷"))
                {
                    znakPosh = label1.Text.IndexOf("÷");
                }
                else if (label1.Text.Substring(1).Contains("-"))
                {
                    znakPosh = label1.Text.Substring(1).IndexOf("-") + 1;
                }
                if (label1.Text.Length - 1 != znakPosh)
                {
                    if (label1.Text.Substring(znakPosh + 1, 1) != "-" &&
                        label1.Text.Substring(znakPosh + 1) != "0")
                    {
                        label1.Text = label1.Text.Insert(znakPosh + 1, "-");
                    }
                    else if (label1.Text.Substring(znakPosh + 1) != "0")
                    {
                        label1.Text = label1.Text.Remove(znakPosh + 1, 1);
                    }
                }
            }
        }
    }
}
