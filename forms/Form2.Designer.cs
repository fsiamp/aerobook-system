namespace hellenicair2
{
    partial class Form2
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
            System.Windows.Forms.Label departureLabel;
            System.Windows.Forms.Label destinationLabel;
            System.Windows.Forms.Label departureDateTimeLabel;
            System.Windows.Forms.Label arrivalDateTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flightIDTextBox = new System.Windows.Forms.TextBox();
            this.flights3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsDataSet = new hellenicair2.flightsDataSet();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.departureDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.flights3TableAdapter = new hellenicair2.flightsDataSetTableAdapters.flights3TableAdapter();
            this.tableAdapterManager = new hellenicair2.flightsDataSetTableAdapters.TableAdapterManager();
            this.αναζήτησηToolStrip = new System.Windows.Forms.ToolStrip();
            this.flightIDToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.αναζήτησηToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.flights3DataGridView = new System.Windows.Forms.DataGridView();
            this.flightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            flightIDLabel = new System.Windows.Forms.Label();
            departureLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            departureDateTimeLabel = new System.Windows.Forms.Label();
            arrivalDateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flights3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).BeginInit();
            this.αναζήτησηToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flights3DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flightIDLabel
            // 
            flightIDLabel.AutoSize = true;
            flightIDLabel.Location = new System.Drawing.Point(23, 219);
            flightIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            flightIDLabel.Name = "flightIDLabel";
            flightIDLabel.Size = new System.Drawing.Size(91, 13);
            flightIDLabel.TabIndex = 20;
            flightIDLabel.Text = "Αριθμός Πτήσης:";
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Location = new System.Drawing.Point(23, 241);
            departureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new System.Drawing.Size(69, 13);
            departureLabel.TabIndex = 22;
            departureLabel.Text = "Αναχώρηση:";
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new System.Drawing.Point(23, 264);
            destinationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(69, 13);
            destinationLabel.TabIndex = 24;
            destinationLabel.Text = "Προορισμός:";
            // 
            // departureDateTimeLabel
            // 
            departureDateTimeLabel.AutoSize = true;
            departureDateTimeLabel.Location = new System.Drawing.Point(23, 287);
            departureDateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departureDateTimeLabel.Name = "departureDateTimeLabel";
            departureDateTimeLabel.Size = new System.Drawing.Size(101, 13);
            departureDateTimeLabel.TabIndex = 26;
            departureDateTimeLabel.Text = "Ώρα Αναχώρησης:";
            // 
            // arrivalDateTimeLabel
            // 
            arrivalDateTimeLabel.AutoSize = true;
            arrivalDateTimeLabel.Location = new System.Drawing.Point(23, 310);
            arrivalDateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            arrivalDateTimeLabel.Name = "arrivalDateTimeLabel";
            arrivalDateTimeLabel.Size = new System.Drawing.Size(71, 13);
            arrivalDateTimeLabel.TabIndex = 28;
            arrivalDateTimeLabel.Text = "Ώρα Άφιξης:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(341, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Πίνακας Διαθέσιμων Πτήσεων";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(205, 110);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(521, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // flightIDTextBox
            // 
            this.flightIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "FlightID", true));
            this.flightIDTextBox.Location = new System.Drawing.Point(136, 216);
            this.flightIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightIDTextBox.Name = "flightIDTextBox";
            this.flightIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.flightIDTextBox.TabIndex = 21;
            // 
            // flights3BindingSource
            // 
            this.flights3BindingSource.DataMember = "flights3";
            this.flights3BindingSource.DataSource = this.flightsDataSet;
            // 
            // flightsDataSet
            // 
            this.flightsDataSet.DataSetName = "flightsDataSet";
            this.flightsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departureTextBox
            // 
            this.departureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "Departure", true));
            this.departureTextBox.Location = new System.Drawing.Point(136, 239);
            this.departureTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(76, 20);
            this.departureTextBox.TabIndex = 23;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "Destination", true));
            this.destinationTextBox.Location = new System.Drawing.Point(136, 262);
            this.destinationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(76, 20);
            this.destinationTextBox.TabIndex = 25;
            // 
            // departureDateTimeTextBox
            // 
            this.departureDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "DepartureDateTime", true));
            this.departureDateTimeTextBox.Location = new System.Drawing.Point(136, 284);
            this.departureDateTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departureDateTimeTextBox.Name = "departureDateTimeTextBox";
            this.departureDateTimeTextBox.Size = new System.Drawing.Size(76, 20);
            this.departureDateTimeTextBox.TabIndex = 27;
            // 
            // arrivalDateTimeTextBox
            // 
            this.arrivalDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "ArrivalDateTime", true));
            this.arrivalDateTimeTextBox.Location = new System.Drawing.Point(136, 307);
            this.arrivalDateTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arrivalDateTimeTextBox.Name = "arrivalDateTimeTextBox";
            this.arrivalDateTimeTextBox.Size = new System.Drawing.Size(76, 20);
            this.arrivalDateTimeTextBox.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FlightID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FlightID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Departure";
            this.dataGridViewTextBoxColumn2.HeaderText = "Departure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn3.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepartureDateTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepartureDateTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ArrivalDateTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "ArrivalDateTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 30;
            this.button1.Text = "Προηγούμενο";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 388);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 24);
            this.button2.TabIndex = 31;
            this.button2.Text = "Επόμενο";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 388);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 24);
            this.button3.TabIndex = 32;
            this.button3.Text = "Συνέχεια";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(12, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 29);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "πτήσειςToolStrip";
            // 
            // flights3TableAdapter
            // 
            this.flights3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.flights3TableAdapter = this.flights3TableAdapter;
            this.tableAdapterManager.UpdateOrder = hellenicair2.flightsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // αναζήτησηToolStrip
            // 
            this.αναζήτησηToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.αναζήτησηToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightIDToolStripTextBox1,
            this.αναζήτησηToolStripButton});
            this.αναζήτησηToolStrip.Location = new System.Drawing.Point(26, 162);
            this.αναζήτησηToolStrip.Name = "αναζήτησηToolStrip";
            this.αναζήτησηToolStrip.Size = new System.Drawing.Size(339, 25);
            this.αναζήτησηToolStrip.TabIndex = 36;
            this.αναζήτησηToolStrip.Text = "αναζήτησηToolStrip";
            // 
            // flightIDToolStripTextBox1
            // 
            this.flightIDToolStripTextBox1.Name = "flightIDToolStripTextBox1";
            this.flightIDToolStripTextBox1.Size = new System.Drawing.Size(226, 25);
            // 
            // αναζήτησηToolStripButton
            // 
            this.αναζήτησηToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.αναζήτησηToolStripButton.Name = "αναζήτησηToolStripButton";
            this.αναζήτησηToolStripButton.Size = new System.Drawing.Size(101, 22);
            this.αναζήτησηToolStripButton.Text = "Αναζήτηση Πτήσης";
            this.αναζήτησηToolStripButton.Click += new System.EventHandler(this.αναζήτησηToolStripButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(23, 388);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 14);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Σύνδεση Διαχειριστή";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(506, 388);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 24);
            this.button4.TabIndex = 38;
            this.button4.Text = "Αρχή";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flights3DataGridView
            // 
            this.flights3DataGridView.AutoGenerateColumns = false;
            this.flights3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flights3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightIDDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.departureDateTimeDataGridViewTextBoxColumn,
            this.arrivalDateTimeDataGridViewTextBoxColumn});
            this.flights3DataGridView.DataSource = this.flights3BindingSource;
            this.flights3DataGridView.Location = new System.Drawing.Point(225, 216);
            this.flights3DataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flights3DataGridView.Name = "flights3DataGridView";
            this.flights3DataGridView.RowTemplate.Height = 24;
            this.flights3DataGridView.Size = new System.Drawing.Size(461, 155);
            this.flights3DataGridView.TabIndex = 29;
            // 
            // flightIDDataGridViewTextBoxColumn
            // 
            this.flightIDDataGridViewTextBoxColumn.DataPropertyName = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.HeaderText = "Κωδικός Πτήσης";
            this.flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
            this.flightIDDataGridViewTextBoxColumn.Width = 140;
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Αναχώρηση";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Προορισμός";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // departureDateTimeDataGridViewTextBoxColumn
            // 
            this.departureDateTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureDateTime";
            this.departureDateTimeDataGridViewTextBoxColumn.HeaderText = "Ώρα Αναχώρησης";
            this.departureDateTimeDataGridViewTextBoxColumn.Name = "departureDateTimeDataGridViewTextBoxColumn";
            this.departureDateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // arrivalDateTimeDataGridViewTextBoxColumn
            // 
            this.arrivalDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDateTime";
            this.arrivalDateTimeDataGridViewTextBoxColumn.HeaderText = "Ώρα Άφιξης";
            this.arrivalDateTimeDataGridViewTextBoxColumn.Name = "arrivalDateTimeDataGridViewTextBoxColumn";
            this.arrivalDateTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 488);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.αναζήτησηToolStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flights3DataGridView);
            this.Controls.Add(flightIDLabel);
            this.Controls.Add(this.flightIDTextBox);
            this.Controls.Add(departureLabel);
            this.Controls.Add(this.departureTextBox);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(departureDateTimeLabel);
            this.Controls.Add(this.departureDateTimeTextBox);
            this.Controls.Add(arrivalDateTimeLabel);
            this.Controls.Add(this.arrivalDateTimeTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AERObook";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flights3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).EndInit();
            this.αναζήτησηToolStrip.ResumeLayout(false);
            this.αναζήτησηToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flights3DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private flightsDataSet flightsDataSet;
        private System.Windows.Forms.BindingSource flights3BindingSource;
        private flightsDataSetTableAdapters.flights3TableAdapter flights3TableAdapter;
        private flightsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox flightIDTextBox;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox departureDateTimeTextBox;
        private System.Windows.Forms.TextBox arrivalDateTimeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip αναζήτησηToolStrip;
        private System.Windows.Forms.ToolStripTextBox flightIDToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton αναζήτησηToolStripButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView flights3DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateTimeDataGridViewTextBoxColumn;

    }
}
