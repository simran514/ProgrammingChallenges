using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Calculator
{
	public partial class Form1 : Form
	{
		double sum    = 0;
		double diff   = 0;
		double total1 = 0;
		double total2 = 0;
		bool plusClicked  = false;
		bool minusClicked = false;
		bool divClicked   = false;
		bool multClicked  = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnOne_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnOne.Text;
		}

		private void btnTwo_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnTwo.Text;
		}

		private void btnThree_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnThree.Text;
		}

		private void btnFour_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnFour.Text;
		}

		private void btnFive_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnFive.Text;
		}

		private void btnSix_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnSix.Text;
		}

		private void btnSeven_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnSeven.Text;
		}

		private void btnEight_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnEight.Text;
		}

		private void btnNine_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnNine.Text;
		}

		private void btnZero_Click(object sender, EventArgs e)
		{
			txtDisplay.Text += btnZero.Text;
		}

		private void btnPoint_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text.Contains("."))
			{
				MessageBox.Show("Cannot add another decimal point", "Error");
			}
			else
			{
				txtDisplay.Text += btnPoint.Text;
			}

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDisplay.Clear();
			minusClicked = false;
			plusClicked = false;
			sum = 0;
			diff = 0;
		}

		private void btnEquals_Click(object sender, EventArgs e)
		{

			if (txtDisplay.Text.Length > 0)
			{
				if (plusClicked)
					total1 = (total1 + Convert.ToDouble(txtDisplay.Text));
				else if (minusClicked)
					total1 = (total1 - Convert.ToDouble(txtDisplay.Text));
				else if (multClicked)
					total1 = (total1 * Convert.ToDouble(txtDisplay.Text));
				else if (divClicked)
					total1 = (total1 / Convert.ToDouble(txtDisplay.Text));

				txtDisplay.Clear();
				txtDisplay.Text = total1.ToString();
				minusClicked = false;
				plusClicked = false;
				multClicked = false;
				divClicked = false;
				total1 = 0;
				total2 = 0;
			}
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text.Length > 0)
			{
				if (!(plusClicked && minusClicked && multClicked && divClicked))
					total1 += Convert.ToDouble(txtDisplay.Text);
				else if (plusClicked)
					total1 += Convert.ToDouble(txtDisplay.Text);
				else if (minusClicked)
					total1 -= Convert.ToDouble(txtDisplay.Text);
				else if (multClicked)
					total1 *= Convert.ToDouble(txtDisplay.Text);
				else if (divClicked)
					total1 /= Convert.ToDouble(txtDisplay.Text);

				plusClicked = true;
				minusClicked = false;
				multClicked = false;
				divClicked = false;
				txtDisplay.Clear();
			}
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text.Length > 0)
			{
				if (!(plusClicked && minusClicked && multClicked && divClicked))
					total1 += Convert.ToDouble(txtDisplay.Text);
				else if (plusClicked)
					total1 += Convert.ToDouble(txtDisplay.Text);
				else if (minusClicked)
					total1 -= Convert.ToDouble(txtDisplay.Text);
				else if (multClicked)
					total1 *= Convert.ToDouble(txtDisplay.Text);
				else if (divClicked)
					total1 /= Convert.ToDouble(txtDisplay.Text);

				plusClicked = false;
				minusClicked = true;
				multClicked = false;
				divClicked = false;
				txtDisplay.Clear();
			}
		}

		private void btnMult_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text.Length > 0)
			{
				if (!(plusClicked && minusClicked && multClicked && divClicked))
					total1 += Convert.ToDouble(txtDisplay.Text);
				else if (plusClicked)
					total1 += Convert.ToDouble(txtDisplay.Text);
				else if (minusClicked)
					total1 -= Convert.ToDouble(txtDisplay.Text);
				else if (multClicked)
					total1 *= Convert.ToDouble(txtDisplay.Text);
				else if (divClicked)
					total1 /= Convert.ToDouble(txtDisplay.Text);

				plusClicked = false;
				minusClicked = false;
				multClicked = true;
				divClicked = false;
				txtDisplay.Clear();
			}
		}

		private void btnDiv_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text.Length > 0)
			{
				if (!(plusClicked && minusClicked && multClicked && divClicked))
					total1 += Convert.ToDouble(txtDisplay.Text);
				else if (plusClicked)
					total1 += Convert.ToDouble(txtDisplay.Text);
				else if (minusClicked)
					total1 -= Convert.ToDouble(txtDisplay.Text);
				else if (multClicked)
					total1 *= Convert.ToDouble(txtDisplay.Text);
				else if (divClicked)
					total1 /= Convert.ToDouble(txtDisplay.Text);

				plusClicked = false;
				minusClicked = false;
				multClicked = false;
				divClicked = true;
				txtDisplay.Clear();
			}
		}
	}
}
