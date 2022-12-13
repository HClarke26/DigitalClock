using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {

        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000; //milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            t.Start(); 

        }

        private void t_Tick(object sender, EventArgs e)
        {
            // current time
            int hh = DateTime.Now.Hour; 
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            DayOfWeek dd = DateTime.Now.DayOfWeek;
            string longDate = DateTime.Now.ToString("dd MMMM yyyy");

            //time string 
            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label1.Text = time;
            label4.Text = dd.ToString();
            label3.Text = longDate; 
        }
    }
}
