using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace hellenicair2
{
    partial class Form11 : Form
    {
        public Form11()
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

        private void flights3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flights3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightsDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightsDataSet.flights3' table. You can move, or remove it, as needed.
            this.flights3TableAdapter.Fill(this.flightsDataSet.flights3);

        }

        private void flight116ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.flights3TableAdapter.flight116(this.flightsDataSet.flights3, flightIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            // Show another form.
            Form12 f2 = new Form12();
            f2.ShowDialog();
            linkLabel1.LinkVisited = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flights3BindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flights3BindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show another form.
            Form1 f2 = new Form1();
            f2.ShowDialog(this);

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show another form.
            Form16 f2 = new Form16();
            f2.ShowDialog(this);

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
