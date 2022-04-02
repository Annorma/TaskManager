using System;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UpdateListView();

            LisViewProcc.MouseClick += listView_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Name != "btnStart")
            {
                myProcess.myStart(((Button)sender).Text);
            }
            else
            {
                myProcess.myStart(tbNameProc.Text);
            }
        }

        private void btnStopProc_Click(object sender, EventArgs e)
        {
            myProcess.Kill(LisViewProcc.GetSelectedListId());
            btnStopProc.Enabled = false;
            UpdateListView();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            LisViewProcc.ListViewItemSorter = new ListViewColumnComparer(e.Column);
        }

        private void listView_Click(object sender, EventArgs e)
        {
            btnStopProc.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void btnTimeUp_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(tbUpDown.Text) * 1000;
        }

        private void btnUpdateListView_Click(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            LisViewProcc.Clear();
            LisViewProcc.myColumns();
            LisViewProcc.SetListProc();
        }
    }
}
