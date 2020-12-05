using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoApagado
{
    public partial class Form1 : Form
    {
        public DateTime ShutdownTime { get; set; }
        public bool SystemOn { get; set; }
        public static ErrorForm ErrorF = new ErrorForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempNumHours.Value = 1;
            tempNumMinutes.Value = 30;

            timeNumDays.Value = DateTime.Now.Day;
            timeNumHours.Value = DateTime.Now.Hour + 1;
            timeNumMinutes.Value = DateTime.Now.Minute;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateRemainingTime();

            if (this.SystemOn && isTimeToShutdown())
            {
                this.SystemOn = false;
                Shutdown();
            }

        }

        private void UpdateRemainingTime()
        {
            if (SystemOn)
                lblRemainingTime.Text = (ShutdownTime - DateTime.Now).ToString(@"dd\ hh\:mm\:ss");
            else
                lblRemainingTime.Text = "0";
        }

        private bool isTimeToShutdown()
        {
            if (DateTime.Now > ShutdownTime)
                return true;

            return false;
        }

        private void tempNumHours_ValueChanged(object sender, EventArgs e)
        {
        }

        private void tempNumMinutes_ValueChanged(object sender, EventArgs e)
        {
        }

        private void tempNumDays_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tempBtnReset_Click(object sender, EventArgs e)
        {
            tempNumDays.Value = 0;
            tempNumHours.Value = 0;
            tempNumMinutes.Value = 0;
        }

        private void tempBtnAceptar_Click(object sender, EventArgs e)
        {
            var days = Convert.ToInt32(tempNumDays.Value);
            var hours = Convert.ToInt32(tempNumHours.Value);
            var minutes = Convert.ToInt32(tempNumMinutes.Value);

            this.ShutdownTime = DateTime.Now.AddDays(days).AddHours(hours).AddMinutes(minutes);
            this.SystemOn = true;
        }

        private void Shutdown()
        {
            var cmdFileName = ConfigurationManager.AppSettings.Get("CmdFN");
            var cmdArgument = ConfigurationManager.AppSettings.Get("CmdArg");
            // var psi = new ProcessStartInfo("shutdown", "/s /t 0");

            var psi = new ProcessStartInfo(cmdFileName, cmdArgument);
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void timeBtnAceptar_Click(object sender, EventArgs e)
        {
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var actualDay = DateTime.Now.Day;

            var days = Convert.ToInt32(timeNumDays.Value) - DateTime.Now.Day;
            var hours = Convert.ToInt32(timeNumHours.Value);
            var minutes = Convert.ToInt32(timeNumMinutes.Value);

            var timeToShutDown = new DateTime(year, month, actualDay).AddDays(days).AddHours(hours).AddMinutes(minutes);

            if (DateTime.Now > timeToShutDown)
            {
                ErrorF.Show();
            }
            else
            {
                this.ShutdownTime = timeToShutDown;
                this.SystemOn = true;
            }
        }

        private void timeBtnReset_Click(object sender, EventArgs e)
        {
            this.timeNumDays.Value = 0;
            this.timeNumHours.Value = 0;
            this.timeNumMinutes.Value = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.SystemOn = false;
        }
    }
}
