using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager
{
    public static class myListViewProcess
    {
        public static void myColumns(this ListView LisViewProcc)
        {
            LisViewProcc.View = View.Details;
            LisViewProcc.GridLines = true;
            LisViewProcc.FullRowSelect = true;
            LisViewProcc.AllowDrop = true;
            LisViewProcc.Columns.Add("Process Name", 250);
            LisViewProcc.Columns.Add("PID", 100);
            LisViewProcc.Columns.Add("Start Time", 130);
            LisViewProcc.Columns.Add("Total Time", 150);
            LisViewProcc.Columns.Add("Handle Count", 160);
            LisViewProcc.Columns.Add("Threads Count", 160);
            LisViewProcc.Columns.Add("Access Modifier", 160);
        }

        public static void SetListProc(this ListView LisViewProcc)
        {
            myProcess.GetMyProc(ref LisViewProcc);
        }

        public static List<int> GetSelectedListId(this ListView LisViewProcc)
        {
            List<int> LisProcId = new List<int>();

            foreach (ListViewItem item in LisViewProcc.SelectedItems)
            {
                if(item.SubItems[3].Text != "-")
                {
                    LisProcId.Add(Convert.ToInt32(item.SubItems[1].Text));
                    LisViewProcc.Items.Remove(item);
                }
                else
                {
                    MessageBox.Show("U can't close this app!!! \n\n\t Access Modifier = false");
                    return null;
                } 
            }
            return LisProcId;
        }
    }
}
