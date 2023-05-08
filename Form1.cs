using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr_17
{
    public partial class Form1 : Form
    {
        private Array array;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OutputLabel.Text = "  ";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int[] inputData = inputTextBox.Text.Split(',').Select(int.Parse).ToArray();
            if (AndRadioButton.Checked)
            {
                array = new Andarray(inputData);
            }
            else if (OnRadioButton.Checked)
            {
                array = new Onarray(inputData);
            }
            OutputLabel.Text = "Тип об'єкту обрано";
        }

        private void ForEach_Click(object sender, EventArgs e)
        {
            if (array != null)
            {
                array.ForEach(element => OutputTextBox.AppendText(element + " "));
            }
            else
            {
                OutputTextBox.Text = "Помилка";
            }



        }

        private void Add_Click(object sender, EventArgs e)
        {
            int[] inputData = inputTextBox.Text.Split(',').Select(int.Parse).ToArray();
            Array otherArray;
            if (AndRadioButton.Checked)
            {
                otherArray = new Andarray(inputData);
            }
            else if (OnRadioButton.Checked)
            {
                otherArray = new Onarray(inputData);
            }
            else
            {
                OutputTextBox.Text = "Обрано тип";
                return;
            }

            int[] result = array.Add(otherArray);
            OutputTextBox.AppendText("\nРезультат: ");
            foreach (int element in result)
            {
                OutputTextBox.AppendText(element + " ");
            }
        }
    }
}
