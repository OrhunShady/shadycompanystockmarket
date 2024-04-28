namespace _20200305026
{
    partial class stockmanagement
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
            dataGridView1 = new DataGridView();
            exitbutton = new Button();
            namelabel = new Label();
            textname = new TextBox();
            unitlabel = new Label();
            textunit = new TextBox();
            pricelabel = new Label();
            textprice = new TextBox();
            datelabel = new Label();
            textdate = new TextBox();
            buttonadd = new Button();
            buttondelete = new Button();
            searchbutton = new Button();
            textsearch = new TextBox();
            updatebutton = new Button();
            sortbutton = new Button();
            clearbutton = new Button();
            quantitylabel = new Label();
            textquantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(692, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(804, 715);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // exitbutton
            // 
            exitbutton.Anchor = AnchorStyles.None;
            exitbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exitbutton.Location = new Point(12, 714);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(94, 38);
            exitbutton.TabIndex = 1;
            exitbutton.Text = "Back";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.BorderStyle = BorderStyle.Fixed3D;
            namelabel.Cursor = Cursors.No;
            namelabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            namelabel.Location = new Point(250, 193);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(63, 27);
            namelabel.TabIndex = 2;
            namelabel.Text = "Name";
            namelabel.Click += namelabel_Click;
            // 
            // textname
            // 
            textname.Location = new Point(382, 190);
            textname.Name = "textname";
            textname.Size = new Size(236, 27);
            textname.TabIndex = 3;
            textname.TextChanged += textname_TextChanged;
            // 
            // unitlabel
            // 
            unitlabel.AutoSize = true;
            unitlabel.BorderStyle = BorderStyle.Fixed3D;
            unitlabel.Cursor = Cursors.No;
            unitlabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            unitlabel.Location = new Point(250, 150);
            unitlabel.Name = "unitlabel";
            unitlabel.Size = new Size(112, 25);
            unitlabel.TabIndex = 4;
            unitlabel.Text = "Unit Number";
            unitlabel.Click += unitlabel_Click;
            // 
            // textunit
            // 
            textunit.Location = new Point(382, 143);
            textunit.Name = "textunit";
            textunit.Size = new Size(236, 27);
            textunit.TabIndex = 5;
            textunit.TextChanged += textunit_TextChanged;
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.BorderStyle = BorderStyle.Fixed3D;
            pricelabel.Cursor = Cursors.No;
            pricelabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            pricelabel.Location = new Point(250, 302);
            pricelabel.Name = "pricelabel";
            pricelabel.Size = new Size(55, 27);
            pricelabel.TabIndex = 6;
            pricelabel.Text = "Price";
            // 
            // textprice
            // 
            textprice.Location = new Point(382, 299);
            textprice.Name = "textprice";
            textprice.Size = new Size(236, 27);
            textprice.TabIndex = 7;
            textprice.TextChanged += textprice_TextChanged;
            // 
            // datelabel
            // 
            datelabel.AutoSize = true;
            datelabel.BorderStyle = BorderStyle.Fixed3D;
            datelabel.Cursor = Cursors.No;
            datelabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            datelabel.Location = new Point(250, 365);
            datelabel.Name = "datelabel";
            datelabel.Size = new Size(53, 27);
            datelabel.TabIndex = 8;
            datelabel.Text = "Date";
            // 
            // textdate
            // 
            textdate.Location = new Point(382, 362);
            textdate.Name = "textdate";
            textdate.Size = new Size(236, 27);
            textdate.TabIndex = 9;
            textdate.TextChanged += textdate_TextChanged;
            // 
            // buttonadd
            // 
            buttonadd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonadd.Location = new Point(250, 533);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(94, 38);
            buttonadd.TabIndex = 10;
            buttonadd.Text = "ADD";
            buttonadd.UseVisualStyleBackColor = true;
            buttonadd.Click += buttonadd_Click_1;
            // 
            // buttondelete
            // 
            buttondelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttondelete.Location = new Point(382, 533);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(94, 38);
            buttondelete.TabIndex = 11;
            buttondelete.Text = "DELETE";
            buttondelete.UseVisualStyleBackColor = true;
            buttondelete.Click += buttondelete_Click;
            // 
            // searchbutton
            // 
            searchbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            searchbutton.Location = new Point(250, 449);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(94, 34);
            searchbutton.TabIndex = 12;
            searchbutton.Text = "SEARCH";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += searchbutton_Click_1;
            // 
            // textsearch
            // 
            textsearch.Location = new Point(382, 454);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(236, 27);
            textsearch.TabIndex = 13;
            textsearch.TextChanged += textsearch_TextChanged;
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(524, 533);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(94, 38);
            updatebutton.TabIndex = 14;
            updatebutton.Text = "UPDATE";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
            // 
            // sortbutton
            // 
            sortbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sortbutton.Location = new Point(382, 595);
            sortbutton.Name = "sortbutton";
            sortbutton.Size = new Size(94, 36);
            sortbutton.TabIndex = 15;
            sortbutton.Text = "SORT";
            sortbutton.UseVisualStyleBackColor = true;
            sortbutton.Click += sortbutton_Click_1;
            // 
            // clearbutton
            // 
            clearbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            clearbutton.Location = new Point(524, 595);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(94, 36);
            clearbutton.TabIndex = 16;
            clearbutton.Text = "CLEAR";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // quantitylabel
            // 
            quantitylabel.AutoSize = true;
            quantitylabel.BorderStyle = BorderStyle.Fixed3D;
            quantitylabel.Cursor = Cursors.No;
            quantitylabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            quantitylabel.Location = new Point(250, 250);
            quantitylabel.Name = "quantitylabel";
            quantitylabel.Size = new Size(87, 27);
            quantitylabel.TabIndex = 17;
            quantitylabel.Text = "Quantity";
            quantitylabel.Click += quantitylabel_Click;
            // 
            // textquantity
            // 
            textquantity.Location = new Point(382, 247);
            textquantity.Name = "textquantity";
            textquantity.Size = new Size(236, 27);
            textquantity.TabIndex = 18;
            textquantity.TextChanged += textquantity_TextChanged;
            // 
            // stockmanagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1540, 777);
            Controls.Add(textquantity);
            Controls.Add(quantitylabel);
            Controls.Add(clearbutton);
            Controls.Add(sortbutton);
            Controls.Add(updatebutton);
            Controls.Add(textsearch);
            Controls.Add(searchbutton);
            Controls.Add(buttondelete);
            Controls.Add(buttonadd);
            Controls.Add(textdate);
            Controls.Add(datelabel);
            Controls.Add(textprice);
            Controls.Add(pricelabel);
            Controls.Add(textunit);
            Controls.Add(unitlabel);
            Controls.Add(textname);
            Controls.Add(namelabel);
            Controls.Add(exitbutton);
            Controls.Add(dataGridView1);
            Name = "stockmanagement";
            Text = "currentstockform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button exitbutton;
        private Label namelabel;
        private TextBox textname;
        private Label unitlabel;
        private TextBox textunit;
        private Label pricelabel;
        private TextBox textprice;
        private Label datelabel;
        private TextBox textdate;
        private Button buttonadd;
        private Button buttondelete;
        private Button searchbutton;
        private TextBox textsearch;
        private Button updatebutton;
        private Button sortbutton;
        private Button clearbutton;
        private Label quantitylabel;
        private TextBox textquantity;
    }
}