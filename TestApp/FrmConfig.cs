using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class FrmConfig : Form
    {
        private StudentDbContext db = new StudentDbContext();
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var config = db.Configs.FirstOrDefault();
            config.StartIndex = (int)numericUpDown1.Value;
            config.EndIndex = (int)numericUpDown2.Value;

            db.SaveChanges();
            this.Close();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            var config = db.Configs.FirstOrDefault();
            numericUpDown1.Value = config.StartIndex;
            numericUpDown2.Value = config.EndIndex;
        }
    }
}
