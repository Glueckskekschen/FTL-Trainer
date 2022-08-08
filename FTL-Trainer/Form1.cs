using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTL_Trainer
{
    public partial class Form1 : Form
    {
        //-----Make a borderless Form movable-----------------------------------------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //----------------------------------------------------------------------------------

        Memory mem;
        private bool timerProcessIsBusy = false;
        private bool timerReadIsBusy = false;

        int iBase;
        int iPlayerData;
        int iReactor;
        int iMissPointer2;
        int iDronePointer2Ship2;

        public Form1()
        {
            InitializeComponent();
            mem = new Memory("FTLGame");
            enOrDisableButtons(false);
            timerProcess.Start();
        }

        private void timerProcess_Tick(object sender, EventArgs e)
        {
            if (!timerProcessIsBusy)
            {
                timerProcessIsBusy = true; //lock timer
                if (mem.AccessProcessOnce())
                {
                    label_status.ForeColor = Color.Green;
                    label_status.Text = "Ready";
                    timerProcess.Stop();
                    timerRead.Start();
                    enOrDisableButtons(true);
                }
                else
                {
                    label_status.ForeColor = Color.Red;
                    if (label_status.Text.Equals("Wait for the Game :)"))
                    {
                        label_status.Text = "Wait for the Game  :)";
                    }
                    else
                    {
                        label_status.Text = "Wait for the Game :)";
                    }
                }
                timerProcessIsBusy = false; //free timer
            }
        }
                
        private void timerRead_Tick(object sender, EventArgs e)
        {
            if (!timerReadIsBusy)
            {
                timerReadIsBusy = true;
                try
                {                    
                    iBase = (int)mem.GetProcessBase();
                    iPlayerData = mem.ReadInt(iBase + Offsets.iPlayerData);
                    iReactor = mem.ReadInt(iBase + Offsets.iReactor);
                    
                    int iFuel = mem.ReadInt(iPlayerData + Offsets.iFuel);
                    tB_FuelCurrent.Text = iFuel.ToString();
                    
                    iMissPointer2 = mem.ReadInt(iPlayerData + 0x48);
                    int iMissShip1 = mem.ReadInt(iMissPointer2 + 0x1E8);
                    tB_MissCurrent1.Text = iMissShip1.ToString();
                    
                    tB_MissCurrent2.Text = iMissShip1.ToString();

                    int iDroneShip1 = mem.ReadInt(iPlayerData + 0x800);
                    tB_DroneCurrent1.Text = iDroneShip1.ToString();

                    iDronePointer2Ship2 = mem.ReadInt(iPlayerData + 0x4C);
                    int iDroneShip2 = mem.ReadInt(iDronePointer2Ship2 + 0x1CC);
                    tB_DroneCurrent2.Text = iDroneShip2.ToString();

                    int iHealth = mem.ReadInt(iPlayerData + Offsets.iPlayerHP);
                    tB_HealthCurrent.Text = iHealth.ToString();

                    int iSrcap = mem.ReadInt(iPlayerData + Offsets.iScrap);
                    tB_ScrapCurrent.Text = iSrcap.ToString();

                    int iReactorPoints = mem.ReadInt(iReactor + Offsets.iEnergy);
                    tB_EnergyCurrent.Text = iReactorPoints.ToString();
                    
                }
                catch (Exception ex)
                {
                    timerRead.Stop();
                    enOrDisableButtons(false);
                    timerProcess.Start();
                }
                finally
                {
                    timerReadIsBusy = false;
                }                
            }
        }

        private void enOrDisableButtons(bool b)
        {
            foreach(Button button in Controls.OfType<Button>())
            {
                if (!button.Name.Equals("bn_Exit"))
                {
                    button.Enabled = b;
                }                
            }
        }

        private void bn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bn_ApplyFuel_Click(object sender, EventArgs e)
        {
            if (tB_FuelUser.Text.Length != 0)
            {
                int iTemp;
                if (int.TryParse(tB_FuelUser.Text, out iTemp))
                {
                    mem.WriteInt(iPlayerData + Offsets.iFuel, iTemp);
                }                
            }                         
        }

        private void bn_ApplyMiss1_Click(object sender, EventArgs e)
        {
            if (tB_MissUser1.Text.Length != 0)
            {
                int iTemp;
                if (int.TryParse(tB_MissUser1.Text, out iTemp))
                {
                    mem.WriteInt(iMissPointer2 + 0x1E8, iTemp);
                }
            }
        }

        private void bn_ApplyMiss2_Click(object sender, EventArgs e)
        {
            if(tB_MissUser2.Text.Length != 0)
            {
                int iTemp;
                if (int.TryParse(tB_MissUser2.Text, out iTemp))
                {
                    mem.WriteInt(iMissPointer2 + 0x1E8, iTemp);
                }
            }
        }

        private void bn_ApplyDrone1_Click(object sender, EventArgs e)
        {
            if (tB_DroneUser1.Text.Length != 0)
            {
                int iTemp;
                if (int.TryParse(tB_DroneUser1.Text, out iTemp))
                {
                    mem.WriteInt(iPlayerData + 0x800, iTemp);
                }
            }
        }

        private void bn_ApplyDrone2_Click(object sender, EventArgs e)
        {
            if (tB_DroneUser2.Text.Length != 0)
            {
                int iTemp;
                if (int.TryParse(tB_DroneUser2.Text, out iTemp))
                {
                    mem.WriteInt(iDronePointer2Ship2 + 0x1CC, iTemp);
                }
            }
        }

        private void bn_ApplyHealth_Click(object sender, EventArgs e)
        {
            if (tB_HealthUser.Text.Length != 0)
            {
                int iTemp;
                if (int.TryParse(tB_HealthUser.Text, out iTemp))
                {
                    mem.WriteInt(iPlayerData + Offsets.iPlayerHP, iTemp);
                }
            }
        }

        private void bn_ApplyEnergy_Click(object sender, EventArgs e)
        {
            if (tB_EnergyUser.Text.Length != 0)
            {
                int iTemp;
                if (int.TryParse(tB_EnergyUser.Text, out iTemp))
                {
                    mem.WriteInt(iReactor + Offsets.iEnergy, iTemp);
                }
            }
        }

        private void bn_ApplyScrap_Click(object sender, EventArgs e)
        {
            if (tB_ScrapUser.Text.Length != 0)
            {
                int iTemp;
                if (int.TryParse(tB_ScrapUser.Text, out iTemp))
                {
                    mem.WriteInt(iPlayerData + Offsets.iScrap, iTemp);
                }
            }
        }

       

        private void bn_ApplyAll_Click(object sender, EventArgs e)
        {
            foreach (Button button in Controls.OfType<Button>())
            {
                if (!button.Name.Equals("bn_Exit"))
                {
                    if (!button.Name.Equals("bn_ApplyAll"))
                    {
                        button.PerformClick();
                    }                   
                }
            }
        }        
    }
}
