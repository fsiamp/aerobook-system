namespace hellenicair2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label flightIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label economyClassLabel;
            System.Windows.Forms.Label businessClassLabel;
            System.Windows.Forms.Label adultsLabel;
            System.Windows.Forms.Label childrenLabel;
            System.Windows.Forms.Label infantsLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label roundTripLabel;
            System.Windows.Forms.Label oneWayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conmanageDataSet = new hellenicair2.conmanageDataSet();
            this.conmanageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conmanageTableAdapter = new hellenicair2.conmanageDataSetTableAdapters.conmanageTableAdapter();
            this.tableAdapterManager = new hellenicair2.conmanageDataSetTableAdapters.TableAdapterManager();
            this.flightIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.economyClassCheckBox = new System.Windows.Forms.CheckBox();
            this.businessClassCheckBox = new System.Windows.Forms.CheckBox();
            this.adultsTextBox = new System.Windows.Forms.TextBox();
            this.childrenTextBox = new System.Windows.Forms.TextBox();
            this.infantsTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.roundTripCheckBox = new System.Windows.Forms.CheckBox();
            this.oneWayCheckBox = new System.Windows.Forms.CheckBox();
            this.conToolStrip = new System.Windows.Forms.ToolStrip();
            this.emailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.conToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            flightIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            economyClassLabel = new System.Windows.Forms.Label();
            businessClassLabel = new System.Windows.Forms.Label();
            adultsLabel = new System.Windows.Forms.Label();
            childrenLabel = new System.Windows.Forms.Label();
            infantsLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            roundTripLabel = new System.Windows.Forms.Label();
            oneWayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageBindingSource)).BeginInit();
            this.conToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightIDLabel
            // 
            flightIDLabel.AutoSize = true;
            flightIDLabel.Location = new System.Drawing.Point(164, 246);
            flightIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            flightIDLabel.Name = "flightIDLabel";
            flightIDLabel.Size = new System.Drawing.Size(92, 13);
            flightIDLabel.TabIndex = 37;
            flightIDLabel.Text = "Kωδικός Πτήσης:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(164, 269);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(54, 13);
            lastNameLabel.TabIndex = 39;
            lastNameLabel.Text = "Επώνυμο:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(164, 292);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(44, 13);
            firstNameLabel.TabIndex = 41;
            firstNameLabel.Text = "Όνομα:";
            // 
            // economyClassLabel
            // 
            economyClassLabel.AutoSize = true;
            economyClassLabel.Location = new System.Drawing.Point(164, 316);
            economyClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            economyClassLabel.Name = "economyClassLabel";
            economyClassLabel.Size = new System.Drawing.Size(92, 13);
            economyClassLabel.TabIndex = 43;
            economyClassLabel.Text = "Οικονομική Θέση:";
            // 
            // businessClassLabel
            // 
            businessClassLabel.AutoSize = true;
            businessClassLabel.Location = new System.Drawing.Point(164, 339);
            businessClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            businessClassLabel.Name = "businessClassLabel";
            businessClassLabel.Size = new System.Drawing.Size(105, 13);
            businessClassLabel.TabIndex = 45;
            businessClassLabel.Text = "Διακεκριμένη Θέση:";
            // 
            // adultsLabel
            // 
            adultsLabel.AutoSize = true;
            adultsLabel.Location = new System.Drawing.Point(164, 363);
            adultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            adultsLabel.Name = "adultsLabel";
            adultsLabel.Size = new System.Drawing.Size(53, 13);
            adultsLabel.TabIndex = 47;
            adultsLabel.Text = "Ενήλικες:";
            // 
            // childrenLabel
            // 
            childrenLabel.AutoSize = true;
            childrenLabel.Location = new System.Drawing.Point(164, 386);
            childrenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            childrenLabel.Name = "childrenLabel";
            childrenLabel.Size = new System.Drawing.Size(51, 13);
            childrenLabel.TabIndex = 49;
            childrenLabel.Text = "Ανήλικοι:";
            // 
            // infantsLabel
            // 
            infantsLabel.AutoSize = true;
            infantsLabel.Location = new System.Drawing.Point(164, 409);
            infantsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            infantsLabel.Name = "infantsLabel";
            infantsLabel.Size = new System.Drawing.Size(42, 13);
            infantsLabel.TabIndex = 51;
            infantsLabel.Text = "Βρέφη:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(400, 244);
            telephoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 53;
            telephoneLabel.Text = "Τηλέφωνο:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(400, 266);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(78, 13);
            emailLabel.TabIndex = 55;
            emailLabel.Text = "Ηλ.Διεύθυνση:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(400, 289);
            countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(38, 13);
            countryLabel.TabIndex = 57;
            countryLabel.Text = "Χώρα:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(400, 312);
            addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 13);
            addressLabel.TabIndex = 59;
            addressLabel.Text = "Διεύθυνση:";
            // 
            // roundTripLabel
            // 
            roundTripLabel.AutoSize = true;
            roundTripLabel.Location = new System.Drawing.Point(400, 336);
            roundTripLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            roundTripLabel.Name = "roundTripLabel";
            roundTripLabel.Size = new System.Drawing.Size(92, 13);
            roundTripLabel.TabIndex = 61;
            roundTripLabel.Text = "Μετ\'επιστροφής:";
            // 
            // oneWayLabel
            // 
            oneWayLabel.AutoSize = true;
            oneWayLabel.Location = new System.Drawing.Point(400, 361);
            oneWayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            oneWayLabel.Name = "oneWayLabel";
            oneWayLabel.Size = new System.Drawing.Size(97, 13);
            oneWayLabel.TabIndex = 63;
            oneWayLabel.Text = "Χωρίς επιστροφή:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(202, 106);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(521, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(334, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Eπαλήθευση στοιχείων κράτησης";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(13, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Παρακαλώ εισάγετε το email σας για να ελέγξετε αν τα στοιχεία σας καταχωρήθηκαν σ" +
                "το σύστημα επιτυχώς:";
            // 
            // conmanageDataSet
            // 
            this.conmanageDataSet.DataSetName = "conmanageDataSet";
            this.conmanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conmanageBindingSource
            // 
            this.conmanageBindingSource.DataMember = "conmanage";
            this.conmanageBindingSource.DataSource = this.conmanageDataSet;
            // 
            // conmanageTableAdapter
            // 
            this.conmanageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.conmanageTableAdapter = this.conmanageTableAdapter;
            this.tableAdapterManager.UpdateOrder = hellenicair2.conmanageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightIDTextBox
            // 
            this.flightIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "FlightID", true));
            this.flightIDTextBox.Location = new System.Drawing.Point(249, 244);
            this.flightIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightIDTextBox.Name = "flightIDTextBox";
            this.flightIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.flightIDTextBox.TabIndex = 38;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(249, 266);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.lastNameTextBox.TabIndex = 40;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(249, 289);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.firstNameTextBox.TabIndex = 42;
            // 
            // economyClassCheckBox
            // 
            this.economyClassCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conmanageBindingSource, "EconomyClass", true));
            this.economyClassCheckBox.Location = new System.Drawing.Point(267, 312);
            this.economyClassCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.economyClassCheckBox.Name = "economyClassCheckBox";
            this.economyClassCheckBox.Size = new System.Drawing.Size(78, 20);
            this.economyClassCheckBox.TabIndex = 44;
            this.economyClassCheckBox.UseVisualStyleBackColor = true;
            // 
            // businessClassCheckBox
            // 
            this.businessClassCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conmanageBindingSource, "BusinessClass", true));
            this.businessClassCheckBox.Location = new System.Drawing.Point(267, 336);
            this.businessClassCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.businessClassCheckBox.Name = "businessClassCheckBox";
            this.businessClassCheckBox.Size = new System.Drawing.Size(78, 20);
            this.businessClassCheckBox.TabIndex = 46;
            this.businessClassCheckBox.UseVisualStyleBackColor = true;
            // 
            // adultsTextBox
            // 
            this.adultsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Adults", true));
            this.adultsTextBox.Location = new System.Drawing.Point(249, 361);
            this.adultsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adultsTextBox.Name = "adultsTextBox";
            this.adultsTextBox.Size = new System.Drawing.Size(104, 20);
            this.adultsTextBox.TabIndex = 48;
            // 
            // childrenTextBox
            // 
            this.childrenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Children", true));
            this.childrenTextBox.Location = new System.Drawing.Point(249, 384);
            this.childrenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.childrenTextBox.Name = "childrenTextBox";
            this.childrenTextBox.Size = new System.Drawing.Size(104, 20);
            this.childrenTextBox.TabIndex = 50;
            // 
            // infantsTextBox
            // 
            this.infantsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Infants", true));
            this.infantsTextBox.Location = new System.Drawing.Point(249, 406);
            this.infantsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infantsTextBox.Name = "infantsTextBox";
            this.infantsTextBox.Size = new System.Drawing.Size(104, 20);
            this.infantsTextBox.TabIndex = 52;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(486, 241);
            this.telephoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(104, 20);
            this.telephoneTextBox.TabIndex = 54;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(486, 264);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(104, 20);
            this.emailTextBox.TabIndex = 56;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(486, 287);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(104, 20);
            this.countryTextBox.TabIndex = 58;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conmanageBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(486, 310);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(104, 20);
            this.addressTextBox.TabIndex = 60;
            // 
            // roundTripCheckBox
            // 
            this.roundTripCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conmanageBindingSource, "RoundTrip", true));
            this.roundTripCheckBox.Location = new System.Drawing.Point(504, 332);
            this.roundTripCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundTripCheckBox.Name = "roundTripCheckBox";
            this.roundTripCheckBox.Size = new System.Drawing.Size(78, 20);
            this.roundTripCheckBox.TabIndex = 62;
            this.roundTripCheckBox.UseVisualStyleBackColor = true;
            // 
            // oneWayCheckBox
            // 
            this.oneWayCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conmanageBindingSource, "OneWay", true));
            this.oneWayCheckBox.Location = new System.Drawing.Point(504, 357);
            this.oneWayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oneWayCheckBox.Name = "oneWayCheckBox";
            this.oneWayCheckBox.Size = new System.Drawing.Size(78, 20);
            this.oneWayCheckBox.TabIndex = 64;
            this.oneWayCheckBox.UseVisualStyleBackColor = true;
            // 
            // conToolStrip
            // 
            this.conToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.conToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripLabel,
            this.emailToolStripTextBox,
            this.conToolStripButton});
            this.conToolStrip.Location = new System.Drawing.Point(166, 185);
            this.conToolStrip.Name = "conToolStrip";
            this.conToolStrip.Size = new System.Drawing.Size(355, 25);
            this.conToolStrip.TabIndex = 65;
            this.conToolStrip.Text = "conToolStrip";
            // 
            // emailToolStripLabel
            // 
            this.emailToolStripLabel.Name = "emailToolStripLabel";
            this.emailToolStripLabel.Size = new System.Drawing.Size(35, 22);
            this.emailToolStripLabel.Text = "Email:";
            // 
            // emailToolStripTextBox
            // 
            this.emailToolStripTextBox.Name = "emailToolStripTextBox";
            this.emailToolStripTextBox.Size = new System.Drawing.Size(196, 25);
            // 
            // conToolStripButton
            // 
            this.conToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.conToolStripButton.Name = "conToolStripButton";
            this.conToolStripButton.Size = new System.Drawing.Size(112, 22);
            this.conToolStripButton.Text = "Αναζήτηση Στοιχείων";
            this.conToolStripButton.Click += new System.EventHandler(this.conToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 66;
            this.button1.Text = "Προηγούμενο";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 457);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 67;
            this.button2.Text = "Συνέχεια";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conToolStrip);
            this.Controls.Add(flightIDLabel);
            this.Controls.Add(this.flightIDTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(economyClassLabel);
            this.Controls.Add(this.economyClassCheckBox);
            this.Controls.Add(businessClassLabel);
            this.Controls.Add(this.businessClassCheckBox);
            this.Controls.Add(adultsLabel);
            this.Controls.Add(this.adultsTextBox);
            this.Controls.Add(childrenLabel);
            this.Controls.Add(this.childrenTextBox);
            this.Controls.Add(infantsLabel);
            this.Controls.Add(this.infantsTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(roundTripLabel);
            this.Controls.Add(this.roundTripCheckBox);
            this.Controls.Add(oneWayLabel);
            this.Controls.Add(this.oneWayCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AERObook";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conmanageBindingSource)).EndInit();
            this.conToolStrip.ResumeLayout(false);
            this.conToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private conmanageDataSet conmanageDataSet;
        private System.Windows.Forms.BindingSource conmanageBindingSource;
        private conmanageDataSetTableAdapters.conmanageTableAdapter conmanageTableAdapter;
        private conmanageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox flightIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.CheckBox economyClassCheckBox;
        private System.Windows.Forms.CheckBox businessClassCheckBox;
        private System.Windows.Forms.TextBox adultsTextBox;
        private System.Windows.Forms.TextBox childrenTextBox;
        private System.Windows.Forms.TextBox infantsTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.CheckBox roundTripCheckBox;
        private System.Windows.Forms.CheckBox oneWayCheckBox;
        private System.Windows.Forms.ToolStrip conToolStrip;
        private System.Windows.Forms.ToolStripLabel emailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton conToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}
