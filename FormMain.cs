using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game._002
{
    public partial class FormMain : Form
    {
        WorkSpace wrkspace;
        public FormMain()
        {
            InitializeComponent();
            wrkspace = new WorkSpace();
            wrkspace.OnMessage += Progress;
        }

        bool _dodo = false;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "▶" || btnStart.Text == "Start")
            {
                wrkspace.StartWork();
                btnStart.Text = "⏸";
                lbl1.Text = "Game is Going";
                //timer1.Start();
                _dodo = true;
                Task.Run(() => tik1());
            }
            else
            {
                wrkspace.StopWork();
                btnStart.Text = "▶";
                lbl1.Text= "Game is Stop";
                //timer1.Stop();

                _dodo = false;
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Progress(string msg)
        {
            this.Invoke(new Action(() =>
            {
                txtLog.Text = msg + "\r\n" + txtLog.Text;
            }));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lbl1.Text.Contains("Game is Going"))
            {
                if (lbl1.Text.Contains("..."))
                {
                    lbl1.Text = "Game is Going";
                }
                else lbl1.Text += ".";
            }
        }
        void tik1()
        {
            while (_dodo)
            {
                Invoke(new Action(() =>
                {
                    if (lbl1.Text.Contains("..."))
                    {
                        lbl1.Text = "Game is Going";
                    }
                    lbl1.Text += ".";
                }));
                Thread.Sleep(500);
            }
        }
    }
}
