using BasicProject.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicProject
{
    public partial class FMain : MetroFramework.Forms.MetroForm
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //private Thread main;
        private Control control;
        private Control control2;
        private List<string> UserAgents = new List<string>();
        private int regSuccess = 0;
        private int regFail = 0;

        public FMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            control = lbSuccess;
            control2 = lbFail;
        }

        private void WriteLogSuccess(string msg)
        {
            control.BeginInvoke((MethodInvoker)delegate ()
            {
                lbSuccess.Text = msg;
            });
        }

        private void WriteLogFail(string msg)
        {
            control2.BeginInvoke((MethodInvoker)delegate ()
            {
                lbFail.Text = msg;
            });
        }

        private async Task<bool> Auto(int indexUA)
        {
            var account = await HttpRequestCommon.GetAccount(txtTokenApp.Text.Trim(), txtIDApp.Text.Trim(), UserAgents[indexUA]);
            if (account != null)
            {
                log.Info(account.toString());
                txtRsAccount.Text += account.toString() + Environment.NewLine;
                regSuccess++;
                WriteLogSuccess(regSuccess.ToString());
                return true;
            }

            regFail++;
            WriteLogFail(regFail.ToString());
            return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int countAccount = 100;
                int numOfThread = 20;
                int i = 0;
                Random rd = new Random();
                List<Task> ListTask = new List<Task>();
                while (i < countAccount)
                {
                    // Stop
                    if (i >= numOfThread)
                    {
                        Task.WaitAny(ListTask.ToArray());
                    }

                    // New Task
                    Task task = new Task(async () =>
                    {
                        int indexUA = rd.Next(0, UserAgents.Count - 1);
                        var account = await HttpRequestCommon.GetAccount(txtTokenApp.Text.Trim(), txtIDApp.Text.Trim(), UserAgents[indexUA]);
                        if (account != null)
                        {
                            log.Info(account.toString());
                            regSuccess++;
                            WriteLogSuccess(regSuccess.ToString());
                        }
                        else
                        {
                            regFail++;
                            WriteLogFail(regFail.ToString());
                        }
                    });
                    task.Start();
                    ListTask.Add(task);
                    i++;
                }
            }
            catch (Exception ex)
            {
                lbError.Text += DateTime.Now + ex.Message + Environment.NewLine;
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("user-agent.txt"))
            {
                string[] str = File.ReadAllLines("user-agent.txt");
                foreach(var s in str)
                {
                    UserAgents.Add(s.Split('|')[0]);
                }
            }
        }

        private async void btnGetTokenApp_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtIDApp.Text.Trim()) && !string.IsNullOrEmpty(txtClientSecrec.Text.Trim()))
            {
                var tokenApp = await HttpRequestCommon.GetTokenApp(txtIDApp.Text.Trim(), txtClientSecrec.Text.Trim());
                if(tokenApp != null)
                {
                    txtTokenApp.Text = tokenApp.Access_Token;
                }
            }
        }
    }
}
