namespace _20200305026
{
    partial class menü
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
            labelshady = new Label();
            stockmanagementbutton = new Button();
            currentstockbutton = new Button();
            quıtbutton = new Button();
            SuspendLayout();
            // 
            // labelshady
            // 
            labelshady.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelshady.AutoSize = true;
            labelshady.BorderStyle = BorderStyle.Fixed3D;
            labelshady.Cursor = Cursors.No;
            labelshady.Font = new Font("Lucida Handwriting", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelshady.Location = new Point(243, 100);
            labelshady.Name = "labelshady";
            labelshady.Size = new Size(562, 42);
            labelshady.TabIndex = 0;
            labelshady.Text = "SHADY COMPANY STOCK MARKET";
            // 
            // stockmanagementbutton
            // 
            stockmanagementbutton.Anchor = AnchorStyles.None;
            stockmanagementbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            stockmanagementbutton.Location = new Point(243, 252);
            stockmanagementbutton.Name = "stockmanagementbutton";
            stockmanagementbutton.Size = new Size(218, 51);
            stockmanagementbutton.TabIndex = 1;
            stockmanagementbutton.Text = "Stock Management";
            stockmanagementbutton.UseVisualStyleBackColor = true;
            stockmanagementbutton.Click += stockmanagementbutton_Click;
            // 
            // currentstockbutton
            // 
            currentstockbutton.Anchor = AnchorStyles.None;
            currentstockbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            currentstockbutton.Location = new Point(568, 252);
            currentstockbutton.Name = "currentstockbutton";
            currentstockbutton.Size = new Size(235, 51);
            currentstockbutton.TabIndex = 2;
            currentstockbutton.Text = "Current Stock";
            currentstockbutton.UseVisualStyleBackColor = true;
            currentstockbutton.Click += currentstockbutton_Click;
            // 
            // quıtbutton
            // 
            quıtbutton.Anchor = AnchorStyles.None;
            quıtbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            quıtbutton.Location = new Point(439, 337);
            quıtbutton.Name = "quıtbutton";
            quıtbutton.Size = new Size(149, 58);
            quıtbutton.TabIndex = 3;
            quıtbutton.Text = "Exit";
            quıtbutton.UseVisualStyleBackColor = true;
            quıtbutton.Click += quıtbutton_Click;
            // 
            // menü
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1033, 596);
            Controls.Add(quıtbutton);
            Controls.Add(currentstockbutton);
            Controls.Add(stockmanagementbutton);
            Controls.Add(labelshady);
            Name = "menü";
            Text = "menü";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelshady;
        private Button stockmanagementbutton;
        private Button currentstockbutton;
        private Button quıtbutton;
    }
}
