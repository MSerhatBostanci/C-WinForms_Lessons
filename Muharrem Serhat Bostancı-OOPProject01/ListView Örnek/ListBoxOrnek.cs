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
    public partial class ListBoxOrnek : Form
    {
        public ListBoxOrnek()
        {
            InitializeComponent();

            // Populate the list box using an array as DataSource.*****

            ArrayList USStates = new ArrayList();
            USStates.Add(new USState("Alabama", "AL"));

            //USState c1 = new USStates("Alabama", "AL");
            //USStates.Add(c1);

            USStates.Add(new USState("Washington", "WA"));
            USStates.Add(new USState("West Virginia", "WV"));
            USStates.Add(new USState("Wisconsin", "WI"));
            USStates.Add(new USState("Wyoming", "WY"));
            listBox1.DataSource = USStates;

            // Set the long name as the property to be displayed and the short
            // name as the value to be returned when a row is selected.  Here
            // these are properties; if we were binding to a database table or
            // query these could be column names.
            listBox1.DisplayMember = "LongName";
            listBox1.ValueMember = "ShortName";

            // Ensure the form opens with no rows selected.
            listBox1.ClearSelected();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Bind the SelectedValueChanged event to our handler for it.
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = ((USState)listBox1.SelectedItem).LongName;
                textBox1.Text = listBox1.SelectedValue.ToString();
                // If we also wanted to get the displayed text we could use
                // the SelectedItem item property:
                // string s = ((USState)ListBox1.SelectedItem).LongName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ArrayList USStates = new ArrayList();
            USState st1 = new USState(textBox2.Text, textBox1.Text);

            if (listBox1.Items.Count > 0)
            {
                foreach (USState item in listBox1.Items)
                {
                    USStates.Add(item);
                }
            }

            USStates.Add(st1);
            listBox1.DataSource = USStates;
            listBox1.DisplayMember = "LongName";
            listBox1.ValueMember = "ShortName";

            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                ((USState)listBox1.SelectedItem).LongName = textBox2.Text;
                ((USState)listBox1.SelectedItem).ShortName = textBox1.Text;
                // If we also wanted to get the displayed text we could use
                // the SelectedItem item property:
                // string s = ((USState)ListBox1.SelectedItem).LongName;
            }

        }
    }
    public class USState
    {
        private string myShortName;
        private string myLongName;

        public USState(string strLongName, string strShortName)
        {

            this.myShortName = strShortName;
            this.myLongName = strLongName;
        }

        public string ShortName
        {
            get
            {
                return myShortName;
            }
            set
            {
                myShortName = value;
            }
        }

        public string LongName
        {

            get
            {
                return myLongName;
            }
            set
            {
                myLongName = value;
            }
        }

    }
}
