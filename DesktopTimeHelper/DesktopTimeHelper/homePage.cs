using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTimeHelper
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }
        public void UyariSaatBasi()
        {
            SoundPlayer player = new SoundPlayer();
            string path = @"muzik\m.wav";
            player.SoundLocation = path;
            player.Play();
        }

        public void UyariBitis()
        {
            SoundPlayer player = new SoundPlayer();
            string path = @"muzik\h.wav";
            player.SoundLocation = path;
            player.Play();
        }


        void islemler()
        {
            if (rShutDown.Checked)
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");
            }
            else if (rSleep.Checked)
            {
                Application.SetSuspendState(PowerState.Suspend, false, false);
            }
            else if (rRestart.Checked)
            {
                System.Diagnostics.Process.Start("ShutDown", "/r -f -t 1");
            }
            else if (rLogout.Checked)
            {
                System.Diagnostics.Process.Start("shutdown", "-l -f");
            }
        }

        int hour = 0, minute = 0;
        int sn = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHour.Text = hour.ToString();
            lblMinute.Text = minute.ToString();            
            lblSn.Text = sn.ToString();
            if (sn==0)
            {
                if (minute != 0)
                {
                    sn = 60;
                    minute -= 1;
                }
                else if (hour != 0)
                {
                    minute = 59;
                    sn = 60;
                    hour -= 1;
                    UyariSaatBasi();
                }
                else if (sn == 0)
                {
                    UyariBitis();
                    timer1.Stop();
                    islemler();
                    Yenile();                    
                }
            }
            sn--;
           
        }


        public void Yenile()
        {
            timer1.Stop();
            timer2.Stop();
            tbxHour.Text = "01";
            tbxMinute.Text = "00";
            sn = 60;
            sn2 = 0;
            dak = 0;
            saat = 0;
            lblHour.Text = "00";
            lblMinute.Text = "00";
            lblSn.Text = "00";
            btnStart.Text = "START";
            btnTimeRun.Text = "TIMER";
            rTakeTime.Checked = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnTimeRun_Click(object sender, EventArgs e)
        {
            if (btnTimeRun.Text=="TIMER" || btnTimeRun.Text=="GO")
            {
                btnTimeRun.Text = "STOP";
                timer2.Start();
            }
            else
            {
                btnTimeRun.Text = "GO";
                timer2.Stop();
                sn2 = 0;
            }
        }
        int sn2 = 0, dak = 0, saat = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sn2++;
            if (sn2==60)
            {
                sn2 = 0;
                dak++;
                if (dak==60)
                {
                    dak = 0;
                    saat++;
                }
            }
            lblSn.Text = sn2.ToString();
            lblMinute.Text = dak.ToString();
            lblHour.Text = saat.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hour = int.Parse(tbxHour.Text);
            minute = int.Parse(tbxMinute.Text);
            if (int.Parse(tbxMinute.Text) >= 0 && int.Parse(tbxHour.Text) >= 0)
            {
                if (btnStart.Text == "START")
                {
                    btnStart.Text = "STOP";                    
                    timer1.Start();
                }
                else
                {
                    btnStart.Text = "START";
                    timer1.Stop();
                }
            }
            else
            {
                MessageBox.Show("Hour or Minute Enter.", "ERROR!");
            }
        }
    }
}
