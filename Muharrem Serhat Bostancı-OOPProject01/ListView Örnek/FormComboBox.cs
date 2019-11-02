using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Örnek
{
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();

            ArrayList PersonInformation = new ArrayList();

            PersonInformation.Add(new Person("21", "Serhat Bostancı"));
            PersonInformation.Add(new Person("22", "Eyüp Sağlık"));
            PersonInformation.Add(new Person("21", "Ali Esenkaya"));

            comboBox1.DataSource = PersonInformation;

            comboBox1.ValueMember = "PersonId";
            comboBox1.DisplayMember = "PersonFullName";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ArrayList PersonInformation = new ArrayList();
            Person st1 = new Person(txtId.Text, txtAd.Text);

            if (comboBox1.Items.Count > 0)
            {
                foreach (Person item in comboBox1.Items)
                {
                    PersonInformation.Add(item);
                }
            }

            PersonInformation.Add(st1);
            comboBox1.DataSource = PersonInformation;
            comboBox1.DisplayMember = "PersonFullName";
            comboBox1.ValueMember = "PersonId";

            txtId.Clear();
            txtAd.Clear();
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                ((Person)comboBox1.SelectedItem).PersonId = txtId.Text;
                ((Person)comboBox1.SelectedItem).PersonFullName = txtAd.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                txtId.Text = ((Person)comboBox1.SelectedItem).PersonId;
                txtAd.Text = ((Person)comboBox1.SelectedItem).PersonFullName;
            }
        }
        public class Person
        {
            private string personId;
            private string personFullName;

            public Person(string strId, string strFullName)
            {

                this.personId = strId;
                this.personFullName = strFullName;
            }

            public string PersonId
            {
                get
                {
                    return personId;
                }
                set
                {
                    personId = value;
                }
            }

            public string PersonFullName
            {

                get
                {
                    return personFullName;
                }
                set
                {
                    personFullName = value;
                }
            }

        }
    }
}
