using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bazaSQLite
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void personDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void menu_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.PersonData' . Możesz go przenieść lub usunąć.
            this.personDataTableAdapter.Fill(this.dataSet1.PersonData);

        }

        private void btnPokazSzczegoly_Click(object sender, EventArgs e)
        {
            PersonDetail personDetail = new PersonDetail();
            
            int ipersonId = int.Parse(personIdTextBox.Text);

            var mPerson = (from x in this.dataSet1.PersonData
                           where x.PersonId == ipersonId
                           select x).ToList();
            personDetail.Show();
            
        }
    }
}
