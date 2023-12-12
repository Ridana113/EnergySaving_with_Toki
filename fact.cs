using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class fact : Form
    {
        public fact()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lamp_nacal_Click(object sender, EventArgs e)
        {
            Zagolovok.Visible = false;
            Lamp_nacal.Visible = false;
            LED_lamp.Visible = false;
            Gas_und_lumi_lamp.Visible = false;
            Back_fact.Visible = true;
            Nacal_fact.Visible = true;
            this.BackgroundImage = Properties.Resources.town_light;
            label1.Visible = true;
        }

        private void Back_fact_Click(object sender, EventArgs e)
        {
            Zagolovok.Visible = true;
            Lamp_nacal.Visible = true;
            LED_lamp.Visible = true;
            Gas_und_lumi_lamp.Visible = true;
            Back_fact.Visible = false;
            Nacal_fact.Visible = false;
            LED_fact.Visible = false;
            Gas_lumi_fact.Visible = false;
            label1.Visible = false;
            this.BackgroundImage = Properties.Resources.town;
        }

        private void LED_lamp_Click(object sender, EventArgs e)
        {
            Zagolovok.Visible = false;
            Lamp_nacal.Visible = false;
            LED_lamp.Visible = false;
            Gas_und_lumi_lamp.Visible = false;
            Back_fact.Visible = true;
            LED_fact.Visible = true;
            this.BackgroundImage = Properties.Resources.town_light;
            label1.Visible = true;
        }

        private void Gas_und_lumi_lamp_Click(object sender, EventArgs e)
        {
            Zagolovok.Visible = false;
            Lamp_nacal.Visible = false;
            LED_lamp.Visible = false;
            Gas_und_lumi_lamp.Visible = false;
            Back_fact.Visible = true;
            Gas_lumi_fact.Visible = true;
            this.BackgroundImage = Properties.Resources.town_light;
            label1.Visible = true;
        }
    }
}
