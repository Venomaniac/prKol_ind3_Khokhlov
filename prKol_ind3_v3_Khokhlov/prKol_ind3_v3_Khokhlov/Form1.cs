using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prKol_ind3_v3_Khokhlov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            V3D v1 = new V3D();
            V3D v2 = new V3D();
            v1.X = double.Parse(textBox1.Text);
            v1.Y = double.Parse(textBox2.Text);
            v1.Z = double.Parse(textBox3.Text);
            v2.X = double.Parse(textBox4.Text);
            v2.Y = double.Parse(textBox5.Text);
            v2.Z = double.Parse(textBox6.Text);
            listBox1.Items.Add($"Вектор 1: {v1}");
            listBox1.Items.Add($"Вектор 2: {v2}");
            V3D sum = v1.Add(v2);
            V3D diff = v1.Subtract(v2);
            listBox1.Items.Add($"Сумма векторов: {sum}");
            listBox1.Items.Add($"Разность векторов: {diff}");
            double dot = v1.DotProduct(v2);
            listBox1.Items.Add($"Скалярное произведение: {dot:F2}");
            listBox1.Items.Add($"Длина v1: {v1.Length():F2}");
            listBox1.Items.Add($"Длина v2: {v2.Length():F2}");
            double cos = v1.CosAngle(v2);
            double angle = Math.Acos(cos) * 180 / Math.PI;
            listBox1.Items.Add($"Косинус угла между векторами: {cos:F4}");
            listBox1.Items.Add($"Угол между векторами: {angle:F2}°");
        }
    }
}
