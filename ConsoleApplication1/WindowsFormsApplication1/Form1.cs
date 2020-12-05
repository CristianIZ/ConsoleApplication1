using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private TimeSpan TotalTime = new TimeSpan();
        private TimeSpan ActualTime = new TimeSpan();
        /// <summary>
        /// Cantidad de veces que se reanuda la actividad
        /// </summary>
        private int Reanudations = 0;
        private DateTime LastReanudation = new DateTime();
        private Stopwatch clock = new Stopwatch();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStartApp.Text = DateTime.Now.ToString();
        }

        internal struct LASTINPUTINFO
        {
            public uint cbSize;

            public uint dwTime;
        }

        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);


        public static uint GetIdleTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            GetLastInputInfo(ref lastInPut);

            return ((uint)Environment.TickCount - lastInPut.dwTime);
        }

        /// <summary>
        /// Get the Last input time in milliseconds
        /// </summary>
        /// <returns></returns>
        public static long GetLastInputTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            if (!GetLastInputInfo(ref lastInPut))
            {
                // throw new Exception(GetLastError().ToString());
            }
            return lastInPut.dwTime;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var secondsToStart = 30;

            StartStopClock(secondsToStart);
            RefreshText(secondsToStart);
        }

        /// <summary>
        /// Reanuda los contadores despues del tiempo establecido y suma el tiempo de retardo a los contadores
        /// </summary>
        /// <param name="secondsToStart">Tiempo minimo de inactividad para comenzar el conteo</param>
        public void StartStopClock(int secondsToStart)
        {
            var idleTime = TimeSpan.FromMilliseconds(GetIdleTime());

            if (idleTime.Seconds >= secondsToStart)
            {
                ActivateClock(true);

                TotalTime = new TimeSpan(clock.Elapsed.Duration().Ticks + new TimeSpan(0, 0, (Reanudations * secondsToStart)).Ticks);
                ActualTime = new TimeSpan(DateTime.Now.Ticks).Subtract(new TimeSpan(LastReanudation.Ticks));
            }
            else
            {
                ActivateClock(false);
            }
        }

        private void RefreshText(int secondsToStart)
        {
            var idleTime = TimeSpan.FromMilliseconds(GetIdleTime());

            txtActualInactivityTime.Text = $"{ActualTime.Hours}:{ActualTime.Minutes}:{ActualTime.Seconds}";
            txtActualStartInactivityTime.Text = $"{LastReanudation.Hour}:{LastReanudation.Minute}:{LastReanudation.Second}";
            txtTotalInactivityTime.Text = $"{TotalTime.Hours}:{TotalTime.Minutes}:{TotalTime.Seconds}";
            txtStartCount.Text = (secondsToStart - idleTime.Seconds) > 0 ? $"{secondsToStart - idleTime.Seconds}" : "En curso";
        }

        private void ActivateClock(bool activate)
        {
            if (activate)
            {
                if (!clock.IsRunning)
                {
                    IncrementReanudation();
                    LastReanudation = DateTime.Now;
                    clock.Start();
                }
            }
            else
            {
                if (clock.IsRunning)
                    clock.Stop();
            }
        }

        private void IncrementReanudation()
        {
            Reanudations++;
        }
    }
}
