using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLiraA2_4SS
{
    public partial class Splash_Form : Form
    {
        public Splash_Form()
        {
            InitializeComponent();
        }
        
        public int timeLeft { get; set; }

        private void Splash_Form_Load(object sender, EventArgs e)
        {
            timeLeft = 15;
            tmr_Splash.Start();
        }
        private void tmr_Splash_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;

            }
            else 
            {
                tmr_Splash.Stop();
                new Calculator().Show();
                this.Hide();
            }
        }
    }

}
