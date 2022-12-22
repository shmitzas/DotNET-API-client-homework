using System.Windows.Forms;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.limitResults = new System.Windows.Forms.CheckBox();
            this.resultLimit = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.useAccessibility = new System.Windows.Forms.CheckBox();
            this.usePrice = new System.Windows.Forms.CheckBox();
            this.useType = new System.Windows.Forms.CheckBox();
            this.useParticipants = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.useKey = new System.Windows.Forms.CheckBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accMaxBox = new System.Windows.Forms.NumericUpDown();
            this.accMinBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceMaxBox = new System.Windows.Forms.NumericUpDown();
            this.priceMinBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.activityTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.participantsNumBox = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.resultLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMaxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMaxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsNumBox)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.limitResults);
            this.splitContainer1.Panel1.Controls.Add(this.resultLimit);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.useAccessibility);
            this.splitContainer1.Panel1.Controls.Add(this.usePrice);
            this.splitContainer1.Panel1.Controls.Add(this.useType);
            this.splitContainer1.Panel1.Controls.Add(this.useParticipants);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.useKey);
            this.splitContainer1.Panel1.Controls.Add(this.searchBtn);
            this.splitContainer1.Panel1.Controls.Add(this.randomBtn);
            this.splitContainer1.Panel1.Controls.Add(this.keyBox);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.accMaxBox);
            this.splitContainer1.Panel1.Controls.Add(this.accMinBox);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.priceMaxBox);
            this.splitContainer1.Panel1.Controls.Add(this.priceMinBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.activityTypeBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.participantsNumBox);
            this.splitContainer1.Panel1.Controls.Add(this.participants_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.loadingLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.activityList);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 522);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 182);
            this.label11.MaximumSize = new System.Drawing.Size(200, 20);
            this.label11.MinimumSize = new System.Drawing.Size(200, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "By default results are limited to 1";
            // 
            // limitResults
            // 
            this.limitResults.AutoSize = true;
            this.limitResults.Location = new System.Drawing.Point(84, 159);
            this.limitResults.Name = "limitResults";
            this.limitResults.Size = new System.Drawing.Size(15, 14);
            this.limitResults.TabIndex = 27;
            this.limitResults.UseVisualStyleBackColor = true;
            // 
            // resultLimit
            // 
            this.resultLimit.Location = new System.Drawing.Point(12, 154);
            this.resultLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resultLimit.Name = "resultLimit";
            this.resultLimit.Size = new System.Drawing.Size(69, 23);
            this.resultLimit.TabIndex = 26;
            this.resultLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Limit results to";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // useAccessibility
            // 
            this.useAccessibility.AutoSize = true;
            this.useAccessibility.Checked = true;
            this.useAccessibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useAccessibility.Location = new System.Drawing.Point(323, 94);
            this.useAccessibility.Name = "useAccessibility";
            this.useAccessibility.Size = new System.Drawing.Size(15, 14);
            this.useAccessibility.TabIndex = 23;
            this.useAccessibility.UseVisualStyleBackColor = true;
            // 
            // usePrice
            // 
            this.usePrice.AutoSize = true;
            this.usePrice.Checked = true;
            this.usePrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usePrice.Location = new System.Drawing.Point(140, 94);
            this.usePrice.Name = "usePrice";
            this.usePrice.Size = new System.Drawing.Size(15, 14);
            this.usePrice.TabIndex = 22;
            this.usePrice.UseVisualStyleBackColor = true;
            // 
            // useType
            // 
            this.useType.AutoSize = true;
            this.useType.Checked = true;
            this.useType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useType.Location = new System.Drawing.Point(324, 33);
            this.useType.Name = "useType";
            this.useType.Size = new System.Drawing.Size(15, 14);
            this.useType.TabIndex = 21;
            this.useType.UseVisualStyleBackColor = true;
            // 
            // useParticipants
            // 
            this.useParticipants.AutoSize = true;
            this.useParticipants.Checked = true;
            this.useParticipants.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useParticipants.Location = new System.Drawing.Point(84, 32);
            this.useParticipants.Name = "useParticipants";
            this.useParticipants.Size = new System.Drawing.Size(15, 14);
            this.useParticipants.TabIndex = 20;
            this.useParticipants.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 289);
            this.label8.MaximumSize = new System.Drawing.Size(200, 50);
            this.label8.MinimumSize = new System.Drawing.Size(200, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 50);
            this.label8.TabIndex = 19;
            this.label8.Text = "Searching with key enabled will ignore all other parameters";
            // 
            // useKey
            // 
            this.useKey.AutoSize = true;
            this.useKey.Location = new System.Drawing.Point(9, 267);
            this.useKey.Name = "useKey";
            this.useKey.Size = new System.Drawing.Size(120, 19);
            this.useKey.TabIndex = 18;
            this.useKey.Text = "Add key to search";
            this.useKey.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(136, 427);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.AutoSize = true;
            this.randomBtn.Location = new System.Drawing.Point(84, 485);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(178, 25);
            this.randomBtn.TabIndex = 14;
            this.randomBtn.Text = "I don\'t know what I want to do";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.random_activity_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(12, 233);
            this.keyBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(152, 23);
            this.keyBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Search by key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // accMaxBox
            // 
            this.accMaxBox.DecimalPlaces = 2;
            this.accMaxBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.accMaxBox.Location = new System.Drawing.Point(267, 89);
            this.accMaxBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.accMaxBox.Name = "accMaxBox";
            this.accMaxBox.Size = new System.Drawing.Size(53, 23);
            this.accMaxBox.TabIndex = 10;
            this.accMaxBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // accMinBox
            // 
            this.accMinBox.DecimalPlaces = 2;
            this.accMinBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.accMinBox.Location = new System.Drawing.Point(195, 89);
            this.accMinBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.accMinBox.Name = "accMinBox";
            this.accMinBox.Size = new System.Drawing.Size(53, 23);
            this.accMinBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Accessibility";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // priceMaxBox
            // 
            this.priceMaxBox.DecimalPlaces = 2;
            this.priceMaxBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceMaxBox.Location = new System.Drawing.Point(84, 89);
            this.priceMaxBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceMaxBox.Name = "priceMaxBox";
            this.priceMaxBox.Size = new System.Drawing.Size(53, 23);
            this.priceMaxBox.TabIndex = 6;
            this.priceMaxBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceMinBox
            // 
            this.priceMinBox.DecimalPlaces = 2;
            this.priceMinBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceMinBox.Location = new System.Drawing.Point(12, 89);
            this.priceMinBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceMinBox.Name = "priceMinBox";
            this.priceMinBox.Size = new System.Drawing.Size(53, 23);
            this.priceMinBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price range";
            // 
            // activityTypeBox
            // 
            this.activityTypeBox.FormattingEnabled = true;
            this.activityTypeBox.Items.AddRange(new object[] {
            "Random",
            "Education",
            "Recreational",
            "Social",
            "DYI",
            "Charity",
            "Cooking",
            "Relaxation",
            "Music",
            "Busywork"});
            this.activityTypeBox.Location = new System.Drawing.Point(195, 27);
            this.activityTypeBox.Name = "activityTypeBox";
            this.activityTypeBox.Size = new System.Drawing.Size(126, 23);
            this.activityTypeBox.TabIndex = 4;
            this.activityTypeBox.Text = "Random";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activity type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // participantsNumBox
            // 
            this.participantsNumBox.Location = new System.Drawing.Point(12, 27);
            this.participantsNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.participantsNumBox.Name = "participantsNumBox";
            this.participantsNumBox.Size = new System.Drawing.Size(69, 23);
            this.participantsNumBox.TabIndex = 1;
            this.participantsNumBox.Value = new decimal(new int[] {
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
            this.loadingLabel.Location = new System.Drawing.Point(285, 266);
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
            this.activityList.MultiSelect = false;
            this.activityList.Name = "activityList";
            this.activityList.Size = new System.Drawing.Size(695, 522);
            this.activityList.TabIndex = 0;
            this.activityList.UseCompatibleStateImageBehavior = false;
            this.activityList.View = System.Windows.Forms.View.Details;
            this.activityList.DoubleClick += new System.EventHandler(this.activityList_DoubleClick);
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
            this.ClientSize = new System.Drawing.Size(1047, 522);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Bored";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMaxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMaxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsNumBox)).EndInit();
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
        private System.Windows.Forms.NumericUpDown participantsNumBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown priceMaxBox;
        private System.Windows.Forms.NumericUpDown priceMinBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox activityTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown accMaxBox;
        private System.Windows.Forms.NumericUpDown accMinBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.NumericUpDown keyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.CheckBox useKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.CheckBox useAccessibility;
        private System.Windows.Forms.CheckBox usePrice;
        private System.Windows.Forms.CheckBox useType;
        private System.Windows.Forms.CheckBox useParticipants;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox limitResults;
        private System.Windows.Forms.NumericUpDown resultLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}
