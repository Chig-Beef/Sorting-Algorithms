using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Random rnd { get; set; }
        private static Bar[] bars { get; set; }
        private static Bar[] extra_bars { get; set; }
        private static int bar_width { get; set; }
        private static int iter { get; set; }
        enum sorts
        {
            Bubble,
            Bogo,
            Select
        }


        // Inbuilt Events
        private void Form1_Load(object sender, EventArgs e)
        {
            iter = 0;
            rnd = new Random();
            this.Size = new Size(700, 400);
            pnlBack.Size = new Size(500, 300);
            nudAmount.Maximum = 500;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (bars == null)
            {
                MessageBox.Show("Init array first", "Error");
                return;
            }

            if (comSorts.SelectedIndex == -1)
            {
                MessageBox.Show("Pick a sorting algorithm", "Error");
            }
            
            if (comSorts.SelectedIndex == Convert.ToInt32(sorts.Bubble))
            {
                Bubble_Sort();
            }
            else if (comSorts.SelectedIndex == Convert.ToInt32(sorts.Bogo))
            {
                Bogo_Sort();
            }
            else if (comSorts.SelectedIndex == Convert.ToInt32(sorts.Select))
            {
                extra_bars = new Bar[bars.Length];
                Selection_Sort();
            }
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(nudAmount.Value);
            int max = Convert.ToInt32(nudMax.Value);
            if (amount == 0)
            {
                MessageBox.Show("Invalid amount", "Error");
                return;
            }
            if (max == 0 || max == 1)
            {
                MessageBox.Show("Invalid maximum", "Error");
                return;
            }

            if (bars != null)
            {
                for (int i = 0; i < bars.Length; i++)
                {
                    bars[i].Pnl.Visible = false;
                    Controls.Remove(bars[i].Pnl);
                }
            }

            bars = new Bar[amount];
            bar_width = pnlBack.Width / amount;
            for (int i = 0; i < amount; i++)
            {
                bars[i] = new Bar(new Panel(), i, rnd.Next(1, max));
                bars[i].Pnl.Parent = pnlBack;
                bars[i].Pnl.Location = new Point(pnlBack.Left + bar_width * i, pnlBack.Top);
                bars[i].Pnl.Size = new Size(bar_width, bars[i].Value*(pnlBack.Height/max));
                bars[i].Pnl.BackColor = Color.Red;
                Controls.Add(bars[i].Pnl);
                bars[i].Pnl.BringToFront();
            }
        }

        // Custom Functions
        private void Bubble_Sort()
        {
            bool sorted = false;
            Bar extra;
            int iterations = 0;
            while (!sorted)
            {
                for (int i = 0; i < bars.Length - 1 - iterations; i++)
                {
                    if (bars[i].Value > bars[i+1].Value)
                    {
                        extra = bars[i];
                        bars[i] = bars[i + 1];
                        bars[i + 1] = extra;
                    }
                }

                iterations++;
                lblIter.Text = "Iterations: " + iterations;

                this.Update();

                Update_Bars();

                if (Check_Sorted())
                {
                    for (int i = 0; i < bars.Length; i++)
                    {
                        bars[i].Pnl.BackColor = Color.Green;
                    }
                    sorted = true;
                }
            }
        }
        private void Selection_Sort()
        {
            Bar extra;
            bool sorted = false;
            int iterations = 0;
            int minumum;
            int index = 0;
            while (!sorted)
            {
                minumum = 1000;
                for (int i = iterations; i < bars.Length; i++)
                {
                    if (bars[i].Value < minumum)
                    {
                        minumum = bars[i].Value;
                        index = i;
                    }
                }

                extra = bars[iterations];
                bars[iterations] = bars[index];
                bars[index] = extra;

                iterations++;
                lblIter.Text = "Iterations: " + iterations;

                this.Update();

                Update_Bars();

                if (Check_Sorted())
                {
                    for (int i = 0; i < bars.Length; i++)
                    {
                        bars[i].Pnl.BackColor = Color.Green;
                    }
                    sorted = true;
                }
                if (iterations >= bars.Length)
                {
                    return;
                }
            }
        }
        private void Bogo_Sort()
        {
            int iterations = 0;
            bool sorted = false;
            while (!sorted)
            {
                bars = bars.OrderBy(x => rnd.Next()).ToArray();

                iterations++;

                lblIter.Text = "Iterations: " + iterations;

                this.Update();

                Update_Bars();

                if (Check_Sorted())
                {
                    for (int i = 0; i < bars.Length; i++)
                    {
                        bars[i].Pnl.BackColor = Color.Green;
                    }
                    sorted = true;
                }
            }
        }
        private bool Check_Sorted()
        {
            for (int i = 0; i < bars.Length-1; i++)
            {
                if (bars[i].Value > bars[i+1].Value)
                {
                    return false;
                }
            }
            return true;
        }
        private void Update_Bars()
        {
            for (int i = 0; i < bars.Length; i++)
            {
                bars[i].Index = i;
                bars[i].Pnl.Location = new Point(pnlBack.Left + i * bar_width, pnlBack.Top);
                bars[i].Pnl.BringToFront();
            }
        }

        // Custom Classes
        public class Bar
        {
            public Bar(Panel pnl, int ind, int vl)
            {
                Pnl = pnl;
                Index = ind;
                Value = vl;
            }

            public Panel Pnl { get; set; }
            public int Index { get; set; }
            public int Value { get; set; }
        }
    }
}
