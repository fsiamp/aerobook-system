using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace hellenicair2
{
    partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
           
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conmanageDataSet.conmanage' table. You can move, or remove it, as needed.
            this.conmanageTableAdapter.Fill(this.conmanageDataSet.conmanage);

        }

        private void conmanageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conmanageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.conmanageDataSet);

        }

        private void flightIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void conmanageBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void economyClassLabel_Click(object sender, EventArgs e)
        {

        }

        private void businessClassLabel_Click(object sender, EventArgs e)
        {

        }

        private void businessClassCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void adultsLabel_Click(object sender, EventArgs e)
        {

        }

        private void adultsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void childrenLabel_Click(object sender, EventArgs e)
        {

        }

        private void infantsLabel_Click(object sender, EventArgs e)
        {

        }

        private void infantsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countryLabel_Click(object sender, EventArgs e)
        {

        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oneWayLabel_Click(object sender, EventArgs e)
        {

        }

        private void oneWayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void roundTripLabel_Click(object sender, EventArgs e)
        {

        }

        private void roundTripCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
         

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             try
            {
                VisitLink();
            }
             catch (Exception )
             {
                 MessageBox.Show("Unable to open link that was clicked.");
             }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
             try
            {
                VisitLink2();
            }
             catch (Exception)
             {
                 MessageBox.Show("Unable to open link that was clicked.");
             }
        }

        
            private void VisitLink()
{
   // Change the color of the link text by setting LinkVisited 
   // to true.
 
   //Call the Process.Start method to open the default browser 
   //with a URL:
   System.Diagnostics.Process.Start("http://www.paypal.com");
}


            private void VisitLink2()
            {
                // Change the color of the link text by setting LinkVisited 
                // to true.

                //Call the Process.Start method to open the default browser 
                //with a URL:
                System.Diagnostics.Process.Start("http://www.wmtransfer.com");
            }

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    VisitLink3();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

            private void VisitLink3()
            {
                // Change the color of the link text by setting LinkVisited 
                // to true.

                //Call the Process.Start method to open the default browser 
                //with a URL:
                System.Diagnostics.Process.Start("http://www.eurobank.gr");
            }

            private void button2_Click(object sender, EventArgs e)
            {
                this.Hide();

                // Show another form.
                Form4 f2 = new Form4();
                f2.ShowDialog(this);
                this.Close();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                this.Hide();

                // Show another form.
                Form6 f2 = new Form6();
                f2.ShowDialog(this);
                this.Close();
            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

        }
    }
