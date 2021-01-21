using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeWeek15
{
    public partial class FormKalkulator : Form
    {
        public FormKalkulator()
        {
            InitializeComponent();
        }

        private void buttonSatu_Click(object sender, EventArgs e)
        {
            listViewTampilan.Items.Add("1");
        }
    }
}
