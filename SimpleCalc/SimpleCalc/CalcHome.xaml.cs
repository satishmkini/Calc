using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SimpleCalc
{
    public partial class CalcHome : ContentPage
    {
        public CalcHome()
        {
            InitializeComponent();
        }

        private void Add_OnClicked(object sender, EventArgs e)
        {
            Double Res = Convert.ToDouble(Num1.Text) + Convert.ToDouble(Num2.Text);
            Result.Text = Convert.ToString(Res);
        }

        private void Sub_OnClicked(object sender, EventArgs e)
        {
            Double Res = Convert.ToDouble(Num1.Text) - Convert.ToDouble(Num2.Text);
            Result.Text = Convert.ToString(Res);
        }

        private void Mul_OnClicked(object sender, EventArgs e)
        {
            Double Res = Convert.ToDouble(Num1.Text) * Convert.ToDouble(Num2.Text);
            Result.Text = Convert.ToString(Res);
        }

        private void Div_OnClicked(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(Num1.Text);
            Double b = Convert.ToDouble(Num2.Text);
            Double Res = a / b;
            Result.Text = Convert.ToString(Res);
        }
    }
}

