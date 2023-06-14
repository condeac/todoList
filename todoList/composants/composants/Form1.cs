using composants.uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace composants
{
    public partial class Form1 : Form
    {
        int count=0, countDone=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ToDo toDo = new ToDo(this);
            toDo.Dock = DockStyle.Top;
            pnl.Controls.Add(toDo);
            count += 1;
            lblCount.Text = count.ToString();
        }
        public void Remove(ToDo toDo)
        {
            pnl.Controls.Remove(toDo);
            count -= 1;
            if(toDo.IsDone())
                countDone -= 1;

            lblCount.Text = count.ToString();
            lblDone.Text = countDone.ToString();
        }
        public string getText()
        {
            return txtTask.Text;
        }

        internal void Check(ToDo toDo)
        {
            countDone += toDo.IsDone() ? 1 : -1;
            lblDone.Text = countDone.ToString();
        }
    }
}
