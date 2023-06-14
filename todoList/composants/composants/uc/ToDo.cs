using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace composants.uc
{
    public partial class ToDo : UserControl
    {
        Form1 myForm;
        public ToDo()
        {
            InitializeComponent();
        }

        public ToDo(Form1 myForm ):this()
        {
            this.myForm = myForm;
            chkTask.Text = myForm.getText();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            myForm.Remove(this);
        }
    
        public Boolean IsDone() { return chkTask.Checked; }

        private void chkTask_CheckedChanged(object sender, EventArgs e)
        {
            myForm.Check(this);
        }
    }
}
