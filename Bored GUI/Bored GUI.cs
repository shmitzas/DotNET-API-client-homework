using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoredAPI_Client;
using BoredAPI_Client.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bored_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadingLabel.Hide();
        }
        private readonly ActivityProvider AP = new ActivityProvider();

        private async void button1_Click(object sender, EventArgs e)
        {
            activityList.Items.Clear();
            loadingLabel.Show();
            ActivityModel activity = new ActivityModel();
            if (use_key.Checked)
            {
                activity.Key = (int)key_box.Value;
                var res = await AP.GetTask(activity);
                loadingLabel.Hide();
                if (res.Activity != null)
                {
                    string[] row = { string.Concat(char.ToUpper(res.Type[0]), res.Type[1..]), res.Participants.ToString(), res.Price.ToString(), res.Accessibility.ToString(), res.Link };
                    activityList.Items.Add(res.Activity).SubItems.AddRange(row);
                }
                else
                {
                    MessageBox.Show($"No activity found with the specified key.\nKey: {activity.Key}", "Invalid key",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                activity.Type = activity_type_box.SelectedItem != null && use_type.Checked ? activity_type_box.SelectedItem.ToString() : "Random";
                if (use_participants.Checked) activity.Participants = (int)participants_num_box.Value;
                if (use_price.Checked) activity.PriceMin = price_min_box.Value;
                if (use_price.Checked) activity.PriceMax = price_max_box.Value;
                if (use_accessibility.Checked) activity.AccessibilityMin = acc_min_box.Value;
                if (use_accessibility.Checked) activity.AccessibilityMax = acc_max_box.Value;
                try
                {
                    List<ActivityModel> ResList = await AP.GetTasks(activity);
                    DisplayResults(ResList);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        private async void random_activity_Click(object sender, EventArgs e)
        {
            activityList.Items.Clear();
            loadingLabel.Show();
            try
            {
                List<ActivityModel> ResList = await AP.GetRandomTasks();
                DisplayResults(ResList);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
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
    }
}
