﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbCelsiuspfahr.Checked)
                {

                    //Converte de Celsius para Fahrenheit
                    Conversor conv = new Conversor();
                    conv.TempCelsius = Double.Parse(txtCelsius.Text);
                    txtFahrenheit.Text = Convert.ToString(conv.ConverterParaFahrenheit());
                }
                else if (rdbFahrenheitpCelsius.Checked)
                {
                    //Converte de Fahrenheit para Celsius
                    Conversor conv = new Conversor();
                    conv.TempFahrenheit = Double.Parse(txtFahrenheit.Text);
                    txtCelsius.Text = Convert.ToString(conv.ConverterParaCelsius());
                }
                else
                {
                    MessageBox.Show("Selecione uma opção");
                }
            }catch( FormatException)
            {
                MessageBox.Show("Digite um número");

            }

        } 

        private void rdbCelsiuspfahr_CheckedChanged(object sender, EventArgs e)
        {
            txtFahrenheit.Enabled = false;
            txtCelsius.Enabled = true;
        }

        private void rdbFahrenheitpCelsius_CheckedChanged(object sender, EventArgs e)
        {
            txtCelsius.Enabled = false;
            txtFahrenheit.Enabled = true;
        }
    }
}
