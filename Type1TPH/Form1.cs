using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Type1TPH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TPHContext db = new TPHContext();
            OnlineCourse oc = new OnlineCourse();
            oc.Details = "Details";
            oc.Name = "new name";
            oc.Trainer = "new trainer";
            oc.URL = "new URL";
            db.Courses.Add(oc);
            db.SaveChanges();
            MessageBox.Show("Saved");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //IQueryable<OnlineCourse> query = from b in context.Courses.OfType<OnlineCourse>()
            //                                select b;
        }
        private void btnOfflineCourse_Click(object sender, EventArgs e)
        {
            TPHContext db = new TPHContext();
            OfflineCourse oc = new OfflineCourse();
            oc.Details = "Details";
            oc.Name = "new name";
            oc.Trainer = "new trainer";
            oc.Address = "02 An Hai";
            db.Courses.Add(oc);
            db.SaveChanges();
            MessageBox.Show("Saved");
        }
    }
}
