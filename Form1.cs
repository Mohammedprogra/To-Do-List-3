using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct stTaskToDo
        {
            public string TaskTitle;
            public string TaskDescription;
            public string Priority;
            public bool IsDaily;
            public bool IsMonthly;
            public bool IsPersonal;
            public bool IsWork;
            public DateTime date;
            public DateTime Time;
        }

        List<stTaskToDo> AllTask = new List<stTaskToDo>();
        List<stTaskToDo> HistoryTask = new List<stTaskToDo>();

        private void rbTime_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDaily.Checked)
            {
                dateTimeTime.Enabled = true;
                dateTimeDate.Enabled = false;
            }

            if (rbMonthly.Checked)
            {
                dateTimeTime.Enabled = false;
                dateTimeDate.Enabled = true;
            }
        }

        void AddToList()
        {
            stTaskToDo Task;

            Task.TaskTitle = txtTaskTitle.Text;
            Task.TaskDescription = txtTaskDescription.Text;

            Task.Priority = cBoxPriority.SelectedItem.ToString();

            Task.IsDaily = rbDaily.Checked;
            Task.IsMonthly = rbMonthly.Checked;

            Task.IsPersonal = rbPersonal.Checked;
            Task.IsWork = rbWork.Checked;

            Task.date = dateTimeDate.Value;
            Task.Time = dateTimeTime.Value;
            AllTask.Add(Task);
        }

        void ResetForm()
        {
            txtTaskTitle.Clear();
            txtTaskDescription.Clear();
            txtTaskTitle.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToList();
            ResetForm();
        }

        private void txtTaskDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskDescription.Text))
            {
                e.Cancel = true;
                txtTaskDescription.Focus();
                errorProvider1.SetError(txtTaskDescription, "You have to add task Description");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTaskDescription, "");
            }
        }

        private void tbShowList_Enter(object sender, EventArgs e)
        {
            ShowTask();
        }

        void SeeIfDailyOrMonthly(stTaskToDo task)
        {
            if (rbShowDaily.Checked && task.IsDaily == true)
            {
                chBoxList.Items.Add("Task : " + task.TaskTitle + "  Time : " + task.Time.ToShortTimeString());
                return;
            }
            if (rbShowMonthly.Checked && task.IsMonthly == true)
            {
                chBoxList.Items.Add("Task : " + task.TaskTitle + "  Date : " + task.date);
                return;
            }
        }

        void SeeIfPersonalOrWork(stTaskToDo task)
        {
            if (rbShowPersonal.Checked && task.IsPersonal == true)
            {
                SeeIfDailyOrMonthly(task); 
            }
            if (rbShowWork.Checked && task.IsWork == true)
            {
                SeeIfDailyOrMonthly(task);
            }

        }

        void ShowTask()
        {
            chBoxList.Items.Clear();
            foreach(stTaskToDo task in AllTask)
            {
                if(cBoxShowPriority.SelectedItem.ToString() == "All")
                    SeeIfPersonalOrWork(task);

                if (cBoxShowPriority.SelectedItem.ToString() == "Hight" &&  task.Priority == "Hight")
                    SeeIfPersonalOrWork(task);

                if (cBoxShowPriority.SelectedItem.ToString() == "Medium" && task.Priority == "Medium")
                    SeeIfPersonalOrWork(task);

                if (cBoxShowPriority.SelectedItem.ToString() == "Low" && task.Priority == "Low")
                    SeeIfPersonalOrWork(task);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxShowPriority.SelectedIndex = 0;
            cBoxPriority.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach(stTaskToDo task in AllTask)
            {
                if(counter == chBoxList.SelectedIndex)
                {
                    HistoryTask.Add(task);
                    AllTask.Remove(task);
                    counter = 0;
                    if (AllTask.Count == 0)
                    {
                        ShowTask();
                        return;
                    }

                }
                counter++;
            }
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(chBoxList.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void moreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (stTaskToDo task in AllTask)
            {
                if (counter == chBoxList.SelectedIndex)
                {
                    ShowMoreInfo Info = new ShowMoreInfo(task.TaskTitle, task.TaskDescription, task.Priority,
                        task.IsDaily, task.IsMonthly, task.IsPersonal, task.IsWork, task.date, task.Time);
                    Info.ShowDialog();
                    counter = 0;
                }
                counter++;
            }
        }

        void PrintItems(stTaskToDo task)
        {
            if(task.IsDaily == true)
            {
                chBoxHistory.Items.Add("Task : " + task.TaskTitle + " Time : " + task.Time.ToShortTimeString());
                return;
            }
            if(task.IsMonthly == true)
            {
                chBoxHistory.Items.Add("Task : " + task.TaskTitle + " Date : " + task.date);
                return;
            }
        }

        void ShowHistory()
        {
            chBoxHistory.Items.Clear();
            foreach (stTaskToDo task in HistoryTask)
            {
                PrintItems(task);
            }
        }

        private void rbHistory_Enter(object sender, EventArgs e)
        {
            ShowHistory();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to clear history", "Confige", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                chBoxHistory.Items.Clear();
                HistoryTask.Clear();
            }
            
        }

        private void moreInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (stTaskToDo task in HistoryTask)
            {
                if (counter == chBoxHistory.SelectedIndex)
                {
                    ShowMoreInfo Info = new ShowMoreInfo(task.TaskTitle, task.TaskDescription, task.Priority,
                        task.IsDaily, task.IsMonthly, task.IsPersonal, task.IsWork, task.date, task.Time);
                    Info.ShowDialog();
                    counter = 0;
                }
                counter++;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (stTaskToDo task in AllTask)
            {
                if (counter == chBoxList.SelectedIndex)
                {
                    AllTask.Remove(task);
                    ShowTask();
                    counter = 0;
                    break;
                }
                counter++;
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (stTaskToDo task in HistoryTask)
            {
                if (counter == chBoxHistory.SelectedIndex)
                {
                    HistoryTask.Remove(task);
                    ShowHistory();
                    counter = 0;
                    break;
                }
                counter++;
            }
        }
    }
}
