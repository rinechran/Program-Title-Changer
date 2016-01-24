using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int SetWindowText(IntPtr hWnd, String lpString);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public Form1()
        {
            InitializeComponent();
            Process_reload();
        }

        private void Process_reload()
        {
            ProcessView.Items.Clear();
            Process[] localAll;
            localAll = System.Diagnostics.Process.GetProcesses();
            ProcessView.BeginUpdate();
            for (int i = 0; i < localAll.Length; ++i)
            {
                if (localAll[i].MainWindowTitle != "")
                {
                    ListViewItem Li = new ListViewItem();
                    Li.Text += localAll[i].Id;
                    Li.SubItems.Add(localAll[i].ProcessName);
                    Li.SubItems.Add(localAll[i].MainWindowTitle);
                    Li.SubItems.Add(localAll[i].VirtualMemorySize64.ToString());
                    Li.SubItems.Add(localAll[i].StartTime.ToString());
                    ProcessView.Items.Add(Li);
                }
            }
            

            ProcessView.EndUpdate();
           
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            Process_reload();
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            string temp_title = Proccess_new_name.Text;
            Proccess_new_name.Text = "";


            if (ProcessView.SelectedItems.Count > 0 && temp_title != "")
            {
                string title = ProcessView.SelectedItems[0].SubItems[2].Text;
                IntPtr handle = FindWindow(null, title);
                SetWindowText(handle, temp_title);
            }
            Process_reload();
        }

        private void git_btn_Click(object sender, EventArgs e)
        {
            string target = "https://github.com/rinechran/";
            System.Diagnostics.Process.Start(target);
        }
    }
}
