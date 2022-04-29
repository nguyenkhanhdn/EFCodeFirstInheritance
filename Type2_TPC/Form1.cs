using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Type2_TPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new TPCContext())
            {
                OnlineCourse oc = new OnlineCourse();
                oc.Details = "New course";
                oc.Name= "New name";
                oc.Trainer = "New trainer";
                oc.URL= "New URL";

               
                context.OnlineCourses.Add(oc);

                context.SaveChanges();
                MessageBox.Show("Saved");
            }
        }

        private void btnOffllineCourse_Click(object sender, EventArgs e)
        {
            using (var context = new TPCContext())
            {
                OfflineCourse offc = new OfflineCourse();
                offc.Details = "New course";
                offc.Name = "New name";
                offc.Trainer = "New trainer";
                offc.Address = "New Address";
                context.OfflineCourses.Add(offc);

                context.SaveChanges();
                MessageBox.Show("Saved");
            }
        }
    }
}
