﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace ApplicazioneCondivisione
{
    public partial class ApplicazioneCondivisione : MetroFramework.Forms.MetroForm
    {
        
        public ApplicazioneCondivisione()
        {
            InitializeComponent();

            // Associa il menu alla tray icon nella taskbar, per quando clicchi con il tasto destro
            this.taskbarIcon.ContextMenuStrip = contextMenuStripTaskbarIcon;

            // Associo le credenziali dell'admin, ossia dove si sta facendo girare l'applicazione
            metroLabel4.Text = "Le tue credenziali: ";
            name.Text = Program.luh.getAdmin().getName();
            surname.Text = Program.luh.getAdmin().getSurname();
            state.Text = Program.luh.getAdmin().getState();

        }

        private void applicazioneCondivisione_Load(object sender, EventArgs e)
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
=======

>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
        {   
            Program.timer.Interval = (2 * 1000); // 2 secs
            Program.timer.Tick += new EventHandler(timer_Tick);
            Program.timer.Start();

            
            // Setto il colore iniziale del bottone di cambio stato
            if (Program.luh.getAdminState().CompareTo("online") == 0)
                changeState.Style = MetroFramework.MetroColorStyle.Green;
            else
                changeState.Style = MetroFramework.MetroColorStyle.Red;

            // Setto il colore di sfondo del refresh button
            refreshButton.Style = MetroFramework.MetroColorStyle.White;
        }
<<<<<<< HEAD
=======
=======

>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
        {
            int w = listaUsers.Width / 5;
            
            listaUsers.View = View.Details;
            imageList1.ImageSize = new Size(32, 32);

            imageList1.Images.Add("key", Image.FromFile("C:\\ProgramData\\Microsoft\\User Account Pictures\\user.bmp"));
            listaUsers.Columns.Add("Nome", w*2, HorizontalAlignment.Center);
            listaUsers.Columns.Add("Cognome", w*2, HorizontalAlignment.Center);
            listaUsers.Columns.Add("Stato", w, HorizontalAlignment.Center);
            listaUsers.CheckBoxes = true;
<<<<<<< HEAD
>>>>>>> origin/gianpao
=======

>>>>>>> b6392adda2ee89b8277b49922055920c9023644f

        {
            int w = listaUsers.Width / 5;
            
            listaUsers.View = View.Details;
            imageList1.ImageSize = new Size(32, 32);

            imageList1.Images.Add("key", Image.FromFile("C:\\ProgramData\\Microsoft\\User Account Pictures\\user.bmp"));
            listaUsers.Columns.Add("Nome", w*2, HorizontalAlignment.Center);
            listaUsers.Columns.Add("Cognome", w*2, HorizontalAlignment.Center);
            listaUsers.Columns.Add("Stato", w, HorizontalAlignment.Center);
            listaUsers.CheckBoxes = true;


        private void timer_Tick(object sender, EventArgs e)
        {
            Program.luh.clean();
            Program.luh.refreshButtonClick();
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
=======

>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
        // Bottoni dentro al form
        private void condividiButton_Click(object sender, EventArgs e)
        {
            Program.luh.condividiButtonClick();
<<<<<<< HEAD
<<<<<<< HEAD
=======
            listaUsers.Items.Add(item1);
            listaUsers.Items.Add(item2);
            listaUsers.StateImageList = this.imageList1;
>>>>>>> origin/gianpao
=======
=======
>>>>>>> b6392adda2ee89b8277b49922055920c9023644f

            listaUsers.Items.Add(item1);
            listaUsers.Items.Add(item2);
            listaUsers.StateImageList = this.imageList1;

<<<<<<< HEAD
>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
=======
>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            base.SetVisibleCore(false);
            this.WindowState = FormWindowState.Minimized;
        }

        private void changeState_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            MetroFramework.Controls.MetroTile changeState = sender as MetroFramework.Controls.MetroTile;
            if (Program.luh.getAdminState().Equals("online"))
=======
            if (listaUsers.SelectedIndices.Count > 0)
>>>>>>> origin/gianpao
=======
=======
>>>>>>> b6392adda2ee89b8277b49922055920c9023644f

            MetroFramework.Controls.MetroTile changeState = sender as MetroFramework.Controls.MetroTile;
            if (Program.luh.getAdminState().Equals("online"))
            if (listaUsers.SelectedIndices.Count > 0)
<<<<<<< HEAD
>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
=======
>>>>>>> b6392adda2ee89b8277b49922055920c9023644f
            {
                Program.luh.changeAdminState("offline");
                changeState.Style = MetroFramework.MetroColorStyle.Red;
            }
            else
            {
                Program.luh.changeAdminState("online");
                changeState.Style = MetroFramework.MetroColorStyle.Green;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.timer_Tick(sender, e);
        }

        private void settingsButton_Click(object sender, MouseEventArgs e)
        {
            // Devo aprire la finestra delle impostazioni
            Settings s = new Settings();
            s.StartPosition = FormStartPosition.CenterScreen;
            s.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            s.Show();
        }

        // Click sulla taskbar
        private void taskbarIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.SetVisibleCore(true);
            this.WindowState = FormWindowState.Normal;
        }

        // Opzioni nel context strip menu
        private void offlineOptionIconContextMenu_Click(object sender, EventArgs e)
        {
            Program.luh.changeAdminState("offline");
        }

        private void onlineOptionIconContextMenu_Click(object sender, EventArgs e)
        {
            Program.luh.changeAdminState("online");
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Sei sicuro di volere uscire?", "Esci dall'applicazione", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    break;
                default:
                    FormClosingEventArgs fcea = new FormClosingEventArgs(CloseReason.WindowsShutDown, false);
                    Program.closeEverything = true;
                    Program.serverThread.Join();
                    Program.pipeThread.Join();
                    base.OnFormClosing(fcea);
                    Application.Exit();
                    break;
            }
        }

        private void apriOptionIconContextMenu_Click(object sender, EventArgs e)
        {
            base.SetVisibleCore(true);
            this.WindowState = FormWindowState.Normal;
        }

        // Override delle funzioni di base
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Program.closeEverything)
                return;

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            base.SetVisibleCore(false);
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
            taskbarIcon.Visible = true;
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }

        private void ApplicazioneCondivisione_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.pipeThread.Abort();
            this.Dispose();
        }
    }
}
