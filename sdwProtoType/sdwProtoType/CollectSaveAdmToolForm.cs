using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdwProtoType
{
    public partial class CollectSaveAdmToolForm : Form
    {
        public CollectSaveAdmToolForm()
        {
            InitializeComponent();
            _monthCalendar1.Visible = false;
            _monthCalendar1.MaxSelectionCount = 1;
            _monthCalendar2.Visible = false;
            _monthCalendar2.MaxSelectionCount = 1;
            _monthCalendar3.Visible = false;
            _monthCalendar3.MaxSelectionCount = 1;
        }

        private void btnCalendar1_Click(object sender, EventArgs e)
        {
            Point pt = new System.Drawing.Point(Cursor.Position.X+10,Cursor.Position.Y);
            _monthCalendar1.Location = PointToClient(pt);
            _monthCalendar1.Show();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            tbDate1.Text = e.Start.ToShortDateString();
            _monthCalendar1.Visible = false;
        }
        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            _monthCalendar1.Visible = false;
        }
        private void btnCalendar2_Click(object sender, EventArgs e)
        {
            //_monthCalendar2.Location = new System.Drawing.Point(Cursor.Position.X + 1, Cursor.Position.Y + 1);
            Point pt = new System.Drawing.Point(Cursor.Position.X + 10, Cursor.Position.Y);
            _monthCalendar2.Location = PointToClient(pt);
            _monthCalendar2.Show();
        }
        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            tbDate2.Text = e.Start.ToShortDateString();
            _monthCalendar2.Visible = false;
        }
        private void monthCalendar2_Leave(object sender, EventArgs e)
        {
            _monthCalendar2.Visible = false;
        }
        private void btnCalendar3_Click(object sender, EventArgs e)
        {
            //_monthCalendar3.Location = new System.Drawing.Point(Cursor.Position.X + 1, Cursor.Position.Y + 1);
            Point pt = new System.Drawing.Point(Cursor.Position.X + 10, Cursor.Position.Y);
            _monthCalendar3.Location = PointToClient(pt);
            _monthCalendar3.Show();
        }
        private void monthCalendar3_DateSelected(object sender, DateRangeEventArgs e)
        {
            tbDate3.Text = e.Start.ToShortDateString();
            _monthCalendar3.Visible = false;
        }
        private void monthCalendar3_Leave(object sender, EventArgs e)
        {
            _monthCalendar3.Visible = false;
        }
    }
}
