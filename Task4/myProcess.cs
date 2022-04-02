using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace TaskManager
{
    static class myProcess
    {
        public static void myStart(string name)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = $"{name}.exe";
                    process.Start();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetMyProc(ref ListView listView)
        {
            Process[] ProcArray = Process.GetProcesses();

            foreach (Process process in ProcArray)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                try
                {
                    item.SubItems.Add(process.Id.ToString());
                    item.SubItems.Add(process.StartTime.ToShortTimeString());
                    item.SubItems.Add(process.TotalProcessorTime.Milliseconds.ToString());
                    item.SubItems.Add(process.HandleCount.ToString());
                    item.SubItems.Add(process.Threads.Count.ToString());
                    item.SubItems.Add(true.ToString());
                }
                catch (Exception)
                {
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                    item.SubItems.Add(false.ToString());
                }
                listView.Items.Add(item);
            }
        }

        public static void Kill(List<int> listProcId)
        {
            if (listProcId != null)
            {
                foreach (int id in listProcId)
                {
                    Process process = Process.GetProcessById(id);
                    process.Kill();
                }
            }
        }
    }
}
