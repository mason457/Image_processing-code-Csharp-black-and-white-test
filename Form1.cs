using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace image
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Bitmap newbmp;
        int[,] img;
        int value;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog1.FileName);                //�Ϥ�������Ʀs���ܼ�bmp
                pictureBox1.Image = bmp;                                   //��ܩ�pictureBox1.
                img = BmpToAry.Transfer(bmp);                         //�N�۳t��Ƹm�Jtest.BmpToAry.Transfer�禡�A��X�}�Cimg            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                newbmp.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);   //����newbmp��X
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.ToString();
            value = label1.Text;
            int HEIGHT = img.GetLength(0);
            int WIDTH = img.GetLength(1);
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    if (img[i, j] < value)
                    {
                        img[i, j] = 0;
                    }
                    else
                    {
                        img[i, j] = 255;
                    }
                }
            }
            newbmp = BmpToAry.Invert(img);
            pictureBox2.Image = newbmp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}