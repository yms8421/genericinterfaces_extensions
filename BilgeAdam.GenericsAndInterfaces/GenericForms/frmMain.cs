using System;
using System.Windows.Forms;

namespace BilgeAdam.GenericsAndInterfaces.GenericForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenForm<T>() where T: Form
        {
            //Açılan form bir daha açılmasın. Çünkü zaten açık
            //Reflection: 
            //var f = Activator.CreateInstance(typeof(T)) as Form;
            var f = Activator.CreateInstance<T>();
            f.MdiParent = this;
            f.Show();
        }

        private void msbClients_Click(object sender, EventArgs e)
        {
            //OpenForm<Person>();
            OpenForm<frmClients>();
        }

        private void msbPeople_Click(object sender, EventArgs e)
        {
            OpenForm<frmPeople>();
        }

        private void msbProducts_Click(object sender, EventArgs e)
        {
            OpenForm<frmProducts>();
        }

        private void msbStudents_Click(object sender, EventArgs e)
        {
            OpenForm<frmStudents>();
        }
    }
}
