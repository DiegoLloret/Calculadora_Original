using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Original
{
    public partial class Form1 : Form
    {

        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //numero 1
            textBox1.Text = textBox1.Text+ "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //numero 2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //numero 3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //numero 4
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //numero 5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //numero 6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //numero 7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //numero 8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //numero 9
            textBox1.Text = textBox1.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //numero 0
            textBox1.Text = textBox1.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // boton limpiar
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //boton igual
            valor2 = Convert.ToDouble(textBox1.Text);
            resultado = valor1 + valor2;
            switch (operacion)
            {
                case 1: resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 / valor2;
                    break;
                case 4:
                    resultado = valor1 * valor2;
                    break;

            }
            textBox1.Text = resultado.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Boton restar
            operacion = 2;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Boton division
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Boton multiplicacion
            operacion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
