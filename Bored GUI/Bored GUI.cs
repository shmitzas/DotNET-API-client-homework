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
        }
        private ActivityProvider AP = new ActivityProvider();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void activityList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void key_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            activityList.Items.Clear();
            ActivityModel activity = new ActivityModel();
            if (add_key_cb.Checked)
            {
                activity.Key = (int)key_box.Value;
                var res = await AP.GetTask(activity);
                if (res.Activity != null)
                {
                    string[] row = { String.Concat(char.ToUpper(res.Type[0]), res.Type.Substring(1)), res.Participants.ToString(), res.Price.ToString(), res.Accessibility.ToString(), res.Link };
                    activityList.Items.Add(res.Activity).SubItems.AddRange(row);
                }
                else
                {
                    Debug.WriteLine("No activity found with the specified key.");
                }
            }
            else
            {
                activity.Type = activity_type_box.SelectedItem != null ? activity_type_box.SelectedItem.ToString() : "Random";
                activity.Participants = (int)participants_num_box.Value;
                activity.PriceMin = price_min_box.Value;
                activity.PriceMax = price_max_box.Value;
                activity.AccessibilityMin = acc_min_box.Value;
                activity.AccessibilityMax = acc_max_box.Value;
                activity.Key = null;
                try
                {
                    List<ActivityModel> ResList = await AP.GetTasks(activity);
                    foreach (var res in ResList)
                    {
                        
                        if (res.Activity != null)
                        {
                            string[] row = { string.Concat(char.ToUpper(res.Type[0]), res.Type.Substring(1)), res.Participants.ToString(), res.Price.ToString(), res.Accessibility.ToString(), res.Link };
                            activityList.Items.Add(res.Activity).SubItems.AddRange(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("BTN_GetTasks\n" + ex);
                }
            }
        }

        private async void random_activity_Click(object sender, EventArgs e)
        {
            activityList.Items.Clear();
            try
            {
                List<ActivityModel> ResList = await AP.GetRandomTasks();
                foreach (var res in ResList)
                {
                    string[] row = { String.Concat(char.ToUpper(res.Type[0]), res.Type.Substring(1)), res.Participants.ToString(), res.Price.ToString(), res.Accessibility.ToString(), res.Link };
                    activityList.Items.Add(res.Activity).SubItems.AddRange(row);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("BTN_GetRandomTasks\n" + ex);
            }
        }
    }
}
