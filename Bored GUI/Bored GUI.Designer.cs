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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.add_key_cb = new System.Windows.Forms.CheckBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_by_key_btn = new System.Windows.Forms.Button();
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
            this.activityList = new System.Windows.Forms.ListView();
            this.Activity = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.Participants = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Accessibility = new System.Windows.Forms.ColumnHeader();
            this.Link = new System.Windows.Forms.ColumnHeader();
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
            this.splitContainer1.Panel1.Controls.Add(this.add_key_cb);
            this.splitContainer1.Panel1.Controls.Add(this.search_btn);
            this.splitContainer1.Panel1.Controls.Add(this.search_by_key_btn);
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
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.activityList);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // add_key_cb
            // 
            this.add_key_cb.AutoSize = true;
            this.add_key_cb.Location = new System.Drawing.Point(12, 290);
            this.add_key_cb.Name = "add_key_cb";
            this.add_key_cb.Size = new System.Drawing.Size(120, 19);
            this.add_key_cb.TabIndex = 18;
            this.add_key_cb.Text = "Add key to search";
            this.add_key_cb.UseVisualStyleBackColor = true;
            this.add_key_cb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.Location = new System.Drawing.Point(96, 329);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 16;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_by_key_btn
            // 
            this.search_by_key_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_by_key_btn.Enabled = false;
            this.search_by_key_btn.Location = new System.Drawing.Point(176, 27);
            this.search_by_key_btn.Name = "search_by_key_btn";
            this.search_by_key_btn.Size = new System.Drawing.Size(80, 23);
            this.search_by_key_btn.TabIndex = 15;
            this.search_by_key_btn.Text = "Search";
            this.search_by_key_btn.UseVisualStyleBackColor = true;
            // 
            // random_activity
            // 
            this.random_activity.Location = new System.Drawing.Point(77, 415);
            this.random_activity.Name = "random_activity";
            this.random_activity.Size = new System.Drawing.Size(113, 23);
            this.random_activity.TabIndex = 14;
            this.random_activity.Text = "Feeling Lucky";
            this.random_activity.UseVisualStyleBackColor = true;
            this.random_activity.Click += new System.EventHandler(this.random_activity_Click);
            // 
            // key_box
            // 
            this.key_box.Location = new System.Drawing.Point(12, 27);
            this.key_box.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.key_box.Name = "key_box";
            this.key_box.Size = new System.Drawing.Size(152, 23);
            this.key_box.TabIndex = 13;
            this.key_box.ValueChanged += new System.EventHandler(this.key_box_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Search by key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // acc_max_box
            // 
            this.acc_max_box.DecimalPlaces = 2;
            this.acc_max_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.acc_max_box.Location = new System.Drawing.Point(84, 250);
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
            this.acc_max_box.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // acc_min_box
            // 
            this.acc_min_box.DecimalPlaces = 2;
            this.acc_min_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.acc_min_box.Location = new System.Drawing.Point(12, 250);
            this.acc_min_box.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.acc_min_box.Name = "acc_min_box";
            this.acc_min_box.Size = new System.Drawing.Size(53, 23);
            this.acc_min_box.TabIndex = 8;
            this.acc_min_box.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Accessibility";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 199);
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
            this.price_max_box.Location = new System.Drawing.Point(84, 197);
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
            this.price_min_box.Location = new System.Drawing.Point(12, 197);
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
            this.label3.Location = new System.Drawing.Point(12, 179);
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
            this.activity_type_box.Location = new System.Drawing.Point(133, 144);
            this.activity_type_box.Name = "activity_type_box";
            this.activity_type_box.Size = new System.Drawing.Size(121, 23);
            this.activity_type_box.TabIndex = 4;
            this.activity_type_box.Text = "Random";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activity type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // participants_num_box
            // 
            this.participants_num_box.Location = new System.Drawing.Point(12, 144);
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
            this.participants_num_box.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // participants_label
            // 
            this.participants_label.AutoSize = true;
            this.participants_label.Location = new System.Drawing.Point(12, 126);
            this.participants_label.Name = "participants_label";
            this.participants_label.Size = new System.Drawing.Size(69, 15);
            this.participants_label.TabIndex = 0;
            this.participants_label.Text = "Participants";
            this.participants_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // activityList
            // 
            this.activityList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Activity,
            this.Type,
            this.Participants,
            this.Price,
            this.Accessibility,
            this.Link});
            this.activityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityList.HideSelection = false;
            this.activityList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.activityList.Location = new System.Drawing.Point(0, 0);
            this.activityList.Name = "activityList";
            this.activityList.Size = new System.Drawing.Size(530, 450);
            this.activityList.TabIndex = 0;
            this.activityList.UseCompatibleStateImageBehavior = false;
            this.activityList.View = System.Windows.Forms.View.Details;
            this.activityList.SelectedIndexChanged += new System.EventHandler(this.activityList_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Bored";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button search_by_key_btn;
        private System.Windows.Forms.Button random_activity;
        private System.Windows.Forms.NumericUpDown key_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.CheckBox add_key_cb;
    }
}
