namespace Bored_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.use_accessibility = new System.Windows.Forms.CheckBox();
            this.use_price = new System.Windows.Forms.CheckBox();
            this.use_type = new System.Windows.Forms.CheckBox();
            this.use_participants = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.use_key = new System.Windows.Forms.CheckBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.random_activity = new System.Windows.Forms.Button();
            this.key_box = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.acc_max_box = new System.Windows.Forms.NumericUpDown();
            this.acc_min_box = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price_max_box = new System.Windows.Forms.NumericUpDown();
            this.price_min_box = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.activity_type_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.participants_num_box = new System.Windows.Forms.NumericUpDown();
            this.participants_label = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.activityList = new System.Windows.Forms.ListView();
            this.Activity = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.Participants = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Accessibility = new System.Windows.Forms.ColumnHeader();
            this.Link = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_max_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_min_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_max_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_min_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participants_num_box)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.use_accessibility);
            this.splitContainer1.Panel1.Controls.Add(this.use_price);
            this.splitContainer1.Panel1.Controls.Add(this.use_type);
            this.splitContainer1.Panel1.Controls.Add(this.use_participants);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.use_key);
            this.splitContainer1.Panel1.Controls.Add(this.search_btn);
            this.splitContainer1.Panel1.Controls.Add(this.random_activity);
            this.splitContainer1.Panel1.Controls.Add(this.key_box);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.acc_max_box);
            this.splitContainer1.Panel1.Controls.Add(this.acc_min_box);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.price_max_box);
            this.splitContainer1.Panel1.Controls.Add(this.price_min_box);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.activity_type_box);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.participants_num_box);
            this.splitContainer1.Panel1.Controls.Add(this.participants_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.loadingLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.activityList);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // use_accessibility
            // 
            this.use_accessibility.AutoSize = true;
            this.use_accessibility.Checked = true;
            this.use_accessibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.use_accessibility.Location = new System.Drawing.Point(141, 196);
            this.use_accessibility.Name = "use_accessibility";
            this.use_accessibility.Size = new System.Drawing.Size(15, 14);
            this.use_accessibility.TabIndex = 23;
            this.use_accessibility.UseVisualStyleBackColor = true;
            // 
            // use_price
            // 
            this.use_price.AutoSize = true;
            this.use_price.Checked = true;
            this.use_price.CheckState = System.Windows.Forms.CheckState.Checked;
            this.use_price.Location = new System.Drawing.Point(140, 142);
            this.use_price.Name = "use_price";
            this.use_price.Size = new System.Drawing.Size(15, 14);
            this.use_price.TabIndex = 22;
            this.use_price.UseVisualStyleBackColor = true;
            // 
            // use_type
            // 
            this.use_type.AutoSize = true;
            this.use_type.Checked = true;
            this.use_type.CheckState = System.Windows.Forms.CheckState.Checked;
            this.use_type.Location = new System.Drawing.Point(136, 86);
            this.use_type.Name = "use_type";
            this.use_type.Size = new System.Drawing.Size(15, 14);
            this.use_type.TabIndex = 21;
            this.use_type.UseVisualStyleBackColor = true;
            // 
            // use_participants
            // 
            this.use_participants.AutoSize = true;
            this.use_participants.Checked = true;
            this.use_participants.CheckState = System.Windows.Forms.CheckState.Checked;
            this.use_participants.Location = new System.Drawing.Point(84, 32);
            this.use_participants.Name = "use_participants";
            this.use_participants.Size = new System.Drawing.Size(15, 14);
            this.use_participants.TabIndex = 20;
            this.use_participants.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 302);
            this.label8.MaximumSize = new System.Drawing.Size(200, 50);
            this.label8.MinimumSize = new System.Drawing.Size(200, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 50);
            this.label8.TabIndex = 19;
            this.label8.Text = "Searching with key enabled will ignore all other parameters";
            // 
            // use_key
            // 
            this.use_key.AutoSize = true;
            this.use_key.Location = new System.Drawing.Point(12, 280);
            this.use_key.Name = "use_key";
            this.use_key.Size = new System.Drawing.Size(120, 19);
            this.use_key.TabIndex = 18;
            this.use_key.Text = "Add key to search";
            this.use_key.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(84, 355);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 16;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // random_activity
            // 
            this.random_activity.AutoSize = true;
            this.random_activity.Location = new System.Drawing.Point(32, 413);
            this.random_activity.Name = "random_activity";
            this.random_activity.Size = new System.Drawing.Size(178, 25);
            this.random_activity.TabIndex = 14;
            this.random_activity.Text = "I don\'t know what I want to do";
            this.random_activity.UseVisualStyleBackColor = true;
            this.random_activity.Click += new System.EventHandler(this.random_activity_Click);
            // 
            // key_box
            // 
            this.key_box.Location = new System.Drawing.Point(15, 246);
            this.key_box.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.key_box.Name = "key_box";
            this.key_box.Size = new System.Drawing.Size(152, 23);
            this.key_box.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Search by key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // acc_max_box
            // 
            this.acc_max_box.DecimalPlaces = 2;
            this.acc_max_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.acc_max_box.Location = new System.Drawing.Point(85, 191);
            this.acc_max_box.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.acc_max_box.Name = "acc_max_box";
            this.acc_max_box.Size = new System.Drawing.Size(53, 23);
            this.acc_max_box.TabIndex = 10;
            this.acc_max_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // acc_min_box
            // 
            this.acc_min_box.DecimalPlaces = 2;
            this.acc_min_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.acc_min_box.Location = new System.Drawing.Point(13, 191);
            this.acc_min_box.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.acc_min_box.Name = "acc_min_box";
            this.acc_min_box.Size = new System.Drawing.Size(53, 23);
            this.acc_min_box.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Accessibility";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // price_max_box
            // 
            this.price_max_box.DecimalPlaces = 2;
            this.price_max_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.price_max_box.Location = new System.Drawing.Point(84, 137);
            this.price_max_box.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.price_max_box.Name = "price_max_box";
            this.price_max_box.Size = new System.Drawing.Size(53, 23);
            this.price_max_box.TabIndex = 6;
            this.price_max_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // price_min_box
            // 
            this.price_min_box.DecimalPlaces = 2;
            this.price_min_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.price_min_box.Location = new System.Drawing.Point(12, 137);
            this.price_min_box.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.price_min_box.Name = "price_min_box";
            this.price_min_box.Size = new System.Drawing.Size(53, 23);
            this.price_min_box.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price range";
            // 
            // activity_type_box
            // 
            this.activity_type_box.FormattingEnabled = true;
            this.activity_type_box.Items.AddRange(new object[] {
            "Random",
            "Education",
            "Recreational",
            "Social",
            "DYI",
            "Charity",
            "Cooking",
            "Relaxation",
            "Music",
            "Busy work"});
            this.activity_type_box.Location = new System.Drawing.Point(12, 80);
            this.activity_type_box.Name = "activity_type_box";
            this.activity_type_box.Size = new System.Drawing.Size(121, 23);
            this.activity_type_box.TabIndex = 4;
            this.activity_type_box.Text = "Random";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activity type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // participants_num_box
            // 
            this.participants_num_box.Location = new System.Drawing.Point(12, 27);
            this.participants_num_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.participants_num_box.Name = "participants_num_box";
            this.participants_num_box.Size = new System.Drawing.Size(69, 23);
            this.participants_num_box.TabIndex = 1;
            this.participants_num_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // participants_label
            // 
            this.participants_label.AutoSize = true;
            this.participants_label.Location = new System.Drawing.Point(12, 9);
            this.participants_label.Name = "participants_label";
            this.participants_label.Size = new System.Drawing.Size(69, 15);
            this.participants_label.TabIndex = 0;
            this.participants_label.Text = "Participants";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadingLabel.Location = new System.Drawing.Point(218, 207);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(123, 15);
            this.loadingLabel.TabIndex = 1;
            this.loadingLabel.Text = "Loading, please wait...";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 1;
            // 
            // activityList
            // 
            this.activityList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activityList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Activity,
            this.Type,
            this.Participants,
            this.Price,
            this.Accessibility,
            this.Link});
            this.activityList.HideSelection = false;
            this.activityList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.activityList.Location = new System.Drawing.Point(0, 0);
            this.activityList.Name = "activityList";
            this.activityList.Size = new System.Drawing.Size(530, 426);
            this.activityList.TabIndex = 0;
            this.activityList.UseCompatibleStateImageBehavior = false;
            this.activityList.View = System.Windows.Forms.View.Details;
            // 
            // Activity
            // 
            this.Activity.Text = "Activity";
            this.Activity.Width = 140;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // Participants
            // 
            this.Participants.Text = "Participants";
            this.Participants.Width = 76;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 40;
            // 
            // Accessibility
            // 
            this.Accessibility.Text = "Accessibility";
            this.Accessibility.Width = 78;
            // 
            // Link
            // 
            this.Link.Text = "Link";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Bored";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.key_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_max_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_min_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_max_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_min_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participants_num_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView activityList;
        private System.Windows.Forms.ColumnHeader Activity;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Participants;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Accessibility;
        private System.Windows.Forms.ColumnHeader Link;
        private System.Windows.Forms.Label participants_label;
        private System.Windows.Forms.NumericUpDown participants_num_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown price_max_box;
        private System.Windows.Forms.NumericUpDown price_min_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox activity_type_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown acc_max_box;
        private System.Windows.Forms.NumericUpDown acc_min_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button random_activity;
        private System.Windows.Forms.NumericUpDown key_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.CheckBox use_key;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.CheckBox use_accessibility;
        private System.Windows.Forms.CheckBox use_price;
        private System.Windows.Forms.CheckBox use_type;
        private System.Windows.Forms.CheckBox use_participants;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
