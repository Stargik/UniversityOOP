namespace Task5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.authorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelPagesCount = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.buttonAddFoodProduct = new System.Windows.Forms.Button();
            this.numericUpDownPagesCount = new System.Windows.Forms.NumericUpDown();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelMeasureUnit = new System.Windows.Forms.Label();
            this.textBoxMeasureUnit = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.dateTimeExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddBookProduct = new System.Windows.Forms.Button();
            this.labeld = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.packageDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(805, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(729, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.bookBindingSource;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1589, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 33);
            this.toolStripButton1.Text = "Add book";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(162, 33);
            this.toolStripButton2.Text = "Add food product";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(148, 33);
            this.toolStripButton3.Text = "Remove product";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // authorsBindingSource1
            // 
            this.authorsBindingSource1.DataMember = "Authors";
            this.authorsBindingSource1.DataSource = this.bookBindingSource;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 109);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name: ";
            this.labelName.Visible = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 141);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(97, 20);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description: ";
            this.labelDescription.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(14, 173);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 20);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price: ";
            this.labelPrice.Visible = false;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 205);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(72, 20);
            this.labelCountry.TabIndex = 5;
            this.labelCountry.Text = "Country: ";
            this.labelCountry.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(153, 103);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(286, 26);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.Visible = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(153, 135);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(286, 26);
            this.textBoxDescription.TabIndex = 7;
            this.textBoxDescription.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(153, 167);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(286, 26);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.Visible = false;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(153, 199);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(286, 26);
            this.textBoxCountry.TabIndex = 9;
            this.textBoxCountry.Visible = false;
            // 
            // labelPagesCount
            // 
            this.labelPagesCount.AutoSize = true;
            this.labelPagesCount.Location = new System.Drawing.Point(12, 237);
            this.labelPagesCount.Name = "labelPagesCount";
            this.labelPagesCount.Size = new System.Drawing.Size(106, 20);
            this.labelPagesCount.TabIndex = 10;
            this.labelPagesCount.Text = "Pages count: ";
            this.labelPagesCount.Visible = false;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(12, 269);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(82, 20);
            this.labelPublisher.TabIndex = 11;
            this.labelPublisher.Text = "Publisher: ";
            this.labelPublisher.Visible = false;
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Location = new System.Drawing.Point(14, 301);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(73, 20);
            this.labelAuthors.TabIndex = 12;
            this.labelAuthors.Text = "Authors: ";
            this.labelAuthors.Visible = false;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(153, 263);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(286, 26);
            this.textBoxPublisher.TabIndex = 14;
            this.textBoxPublisher.Visible = false;
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(153, 295);
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.Size = new System.Drawing.Size(286, 26);
            this.textBoxAuthors.TabIndex = 15;
            this.textBoxAuthors.Visible = false;
            // 
            // buttonAddFoodProduct
            // 
            this.buttonAddFoodProduct.Location = new System.Drawing.Point(478, 231);
            this.buttonAddFoodProduct.Name = "buttonAddFoodProduct";
            this.buttonAddFoodProduct.Size = new System.Drawing.Size(321, 44);
            this.buttonAddFoodProduct.TabIndex = 16;
            this.buttonAddFoodProduct.Text = "Add product";
            this.buttonAddFoodProduct.UseVisualStyleBackColor = true;
            this.buttonAddFoodProduct.Visible = false;
            this.buttonAddFoodProduct.Click += new System.EventHandler(this.buttonAddFoodProduct_Click);
            // 
            // numericUpDownPagesCount
            // 
            this.numericUpDownPagesCount.Location = new System.Drawing.Point(153, 231);
            this.numericUpDownPagesCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPagesCount.Name = "numericUpDownPagesCount";
            this.numericUpDownPagesCount.Size = new System.Drawing.Size(286, 26);
            this.numericUpDownPagesCount.TabIndex = 17;
            this.numericUpDownPagesCount.Visible = false;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Location = new System.Drawing.Point(474, 109);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(119, 20);
            this.labelExpirationDate.TabIndex = 18;
            this.labelExpirationDate.Text = "Expiration date:";
            this.labelExpirationDate.Visible = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(474, 141);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 20);
            this.labelQuantity.TabIndex = 19;
            this.labelQuantity.Text = "Quantity: ";
            this.labelQuantity.Visible = false;
            // 
            // labelMeasureUnit
            // 
            this.labelMeasureUnit.AutoSize = true;
            this.labelMeasureUnit.Location = new System.Drawing.Point(474, 173);
            this.labelMeasureUnit.Name = "labelMeasureUnit";
            this.labelMeasureUnit.Size = new System.Drawing.Size(109, 20);
            this.labelMeasureUnit.TabIndex = 20;
            this.labelMeasureUnit.Text = "Measure unit: ";
            this.labelMeasureUnit.Visible = false;
            // 
            // textBoxMeasureUnit
            // 
            this.textBoxMeasureUnit.Location = new System.Drawing.Point(599, 168);
            this.textBoxMeasureUnit.Name = "textBoxMeasureUnit";
            this.textBoxMeasureUnit.Size = new System.Drawing.Size(200, 26);
            this.textBoxMeasureUnit.TabIndex = 21;
            this.textBoxMeasureUnit.Visible = false;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(599, 136);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 26);
            this.numericUpDownQuantity.TabIndex = 22;
            this.numericUpDownQuantity.Visible = false;
            // 
            // dateTimeExpirationDate
            // 
            this.dateTimeExpirationDate.Location = new System.Drawing.Point(599, 101);
            this.dateTimeExpirationDate.Name = "dateTimeExpirationDate";
            this.dateTimeExpirationDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimeExpirationDate.TabIndex = 23;
            this.dateTimeExpirationDate.Visible = false;
            // 
            // buttonAddBookProduct
            // 
            this.buttonAddBookProduct.Location = new System.Drawing.Point(16, 356);
            this.buttonAddBookProduct.Name = "buttonAddBookProduct";
            this.buttonAddBookProduct.Size = new System.Drawing.Size(423, 44);
            this.buttonAddBookProduct.TabIndex = 24;
            this.buttonAddBookProduct.Text = "Add product";
            this.buttonAddBookProduct.UseVisualStyleBackColor = true;
            this.buttonAddBookProduct.Visible = false;
            this.buttonAddBookProduct.Click += new System.EventHandler(this.buttonAddBookProduct_Click);
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Location = new System.Drawing.Point(12, 43);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(34, 20);
            this.labeld.TabIndex = 25;
            this.labeld.Text = "ID: ";
            this.labeld.Visible = false;
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(71, 43);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownId.TabIndex = 26;
            this.numericUpDownId.Visible = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(16, 75);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(175, 42);
            this.buttonRemove.TabIndex = 27;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Width = 150;
            // 
            // packageDateDataGridViewTextBoxColumn
            // 
            this.packageDateDataGridViewTextBoxColumn.DataPropertyName = "PackageDate";
            this.packageDateDataGridViewTextBoxColumn.HeaderText = "PackageDate";
            this.packageDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.packageDateDataGridViewTextBoxColumn.Name = "packageDateDataGridViewTextBoxColumn";
            this.packageDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(Task5.Product);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Task5.Book);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(Task5.Product);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Task5.Product);
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            // 
            // foodProductBindingSource
            // 
            this.foodProductBindingSource.DataSource = typeof(Task5.FoodProduct);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(197, 75);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(183, 20);
            this.labelError.TabIndex = 28;
            this.labelError.Text = "Incorrect input. Try again";
            this.labelError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.labeld);
            this.Controls.Add(this.buttonAddBookProduct);
            this.Controls.Add(this.dateTimeExpirationDate);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.textBoxMeasureUnit);
            this.Controls.Add(this.labelMeasureUnit);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.numericUpDownPagesCount);
            this.Controls.Add(this.buttonAddFoodProduct);
            this.Controls.Add(this.textBoxAuthors);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.labelAuthors);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelPagesCount);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingSource foodProductBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource authorsBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelPagesCount;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxAuthors;
        private System.Windows.Forms.Button buttonAddFoodProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownPagesCount;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labelMeasureUnit;
        private System.Windows.Forms.TextBox textBoxMeasureUnit;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.DateTimePicker dateTimeExpirationDate;
        private System.Windows.Forms.Button buttonAddBookProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelError;
    }
}

