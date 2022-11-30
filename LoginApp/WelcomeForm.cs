using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(string username, string password)
        {
            InitializeComponent();
            var datasource = new List<Language>();
            datasource.Add(new Language() { Name = "Personal Loan", Value = "5%" });
            datasource.Add(new Language() { Name = "Home loan", Value = "10%" });
            datasource.Add(new Language() { Name = "Vehicles", Value = "15%" });

            //setup data binding
            this.comboBox1.DataSource = datasource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";

            //make it readonly
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public class Language
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
