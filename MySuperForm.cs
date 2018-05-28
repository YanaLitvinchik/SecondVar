using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingToList
{
    public partial class MySuperForm : Form
    {
        List<Man> lm;

        public MySuperForm()
        {
            InitializeComponent();
        
            lm = new List<Man>();
            lm.Add(new Man("Vasia", 20));
            lm.Add(new Man("Petia", 18));
            lm.Add(new Man("Kirill", 19));

            //
            bindingsComboBox.DataSource = lm;
            bindingsComboBox.DisplayMember = "Name";
            bindingsComboBox.ValueMember = "Id";
            lm.Add(new Man("Vadim", 29));

            //аналогичная привязка, только без указания DisplayMember
            bindingsListBox.DataSource = lm;
            bindingsListBox.ValueMember = "Id";


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Man m = new Man {Name = nameTextBox.Text};
            int id = 0;
            int.TryParse(idTextBox.Text, out id);
            m.Id = id;
            lm.Add(m);

            CurrencyManager cm = (CurrencyManager)bindingsComboBox.BindingContext[bindingsComboBox.DataSource];
            cm.Refresh();
            //((CurrencyManager)bindingsComboBox.BindingContext[lm]).Refresh();
        }
    }
}
