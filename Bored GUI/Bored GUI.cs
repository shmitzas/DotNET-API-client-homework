using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoredAPI_Client;
using BoredAPI_Client.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Bored_GUI
{
    public partial class Form1 : Form
    {
        private readonly ActivityProvider AP = new ActivityProvider();
        public Form1()
        {
            InitializeComponent();
            loadingLabel.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            activityList.Items.Clear();
            loadingLabel.Show();
            ActivityModel activity = new ActivityModel();
            if (useKey.Checked)
            {
                var key = (int)keyBox.Value;
                var res = await AP.GetTaskByKey(key);
                loadingLabel.Hide();
                if (res.Activity != null)
                {
                    string[] row = { string.Concat(char.ToUpper(res.Type[0]), res.Type[1..]), res.Participants.ToString(), res.Price.ToString(), res.Accessibility.ToString(), res.Link };
                    activityList.Items.Add(res.Activity).SubItems.AddRange(row);
                }
                else
                {
                    MessageBox.Show($"No activity found with the specified key.\nKey: {key}", "Invalid key",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                activity.Type = activityTypeBox.SelectedItem != null && useType.Checked ? activityTypeBox.SelectedItem.ToString() : "Random";
                if (useParticipants.Checked) activity.Participants = (int)participantsNumBox.Value;
                if (usePrice.Checked) activity.PriceMin = priceMinBox.Value;
                if (usePrice.Checked) activity.PriceMax = priceMaxBox.Value;
                if (useAccessibility.Checked) activity.AccessibilityMin = accMinBox.Value;
                if (useAccessibility.Checked) activity.AccessibilityMax = accMaxBox.Value;
                try
                {
                    List<ActivityModel> ResList = await AP.GetTasks(activity, limitResults.Checked ? (int)resultLimit.Value : 1);
                    DisplayResults(ResList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured.\nError: {ex}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void random_activity_Click(object sender, EventArgs e)
        {
            activityList.Items.Clear();
            loadingLabel.Show();
            try
            {
                List<ActivityModel> ResList = await AP.GetTasks(new ActivityModel { },limitResults.Checked ? (int)resultLimit.Value : 1);
                DisplayResults(ResList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured.\nError: {ex}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayResults(List<ActivityModel> activities)
        {
            loadingLabel.Hide();
            foreach (var res in activities)
            {
                if (res.Activity != null)
                {
                    string[] row = { string.Concat(char.ToUpper(res.Type[0]), res.Type[1..]), res.Participants.ToString(), res.Price.ToString(), res.Accessibility.ToString(), res.Link };
                    activityList.Items.Add(res.Activity).SubItems.AddRange(row);
                }
            }
        }

        private void activityList_DoubleClick(object sender, EventArgs e)
        {
            Form form = new Form();
            var sublist = activityList.SelectedItems[0].SubItems;
            var link = sublist[5].Text == "" ? "No link is available" : sublist[5].Text;      
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Text = sublist[0].Text;
            form.Size = new Size(400, 200);

            TextBox textBox = new TextBox();
            textBox.Text = 
                $"Activity: {sublist[0].Text}" + Environment.NewLine
                + $"Type: {sublist[1].Text}" + Environment.NewLine
                + $"Participants: {sublist[2].Text}" + Environment.NewLine
                + $"Price: {sublist[3].Text}" + Environment.NewLine
                + $"Accessibility: {sublist[4].Text}" + Environment.NewLine + Environment.NewLine
                + $"Link: {link}";
            textBox.ReadOnly = true;
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            form.Controls.Add(textBox);
            textBox.ClientSize = TextRenderer.MeasureText(textBox.Text, textBox.Font);
            form.Size = textBox.Size;

            form.ShowDialog();
        }
    }
}
