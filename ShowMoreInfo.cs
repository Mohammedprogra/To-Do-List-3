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
    public partial class ShowMoreInfo : Form
    {
        public ShowMoreInfo(string TaskTitle , string TaskDescription , string Priority , bool IsDaily , bool IsMonthly , bool IsPersonal ,
             bool IsWork , DateTime date , DateTime Time)
        {
            InitializeComponent();

            laTaskTitle.Text = TaskTitle;
            laDescription.Text = TaskDescription;
            laPriority.Text = Priority;
            
            if(IsDaily == true)
            {
                laPeride.Text = "Daily";
                laTime.Text = Time.ToShortTimeString();
            }
            if(IsMonthly == true)
            {
                laPeride.Text = "Monthly";
                laTime.Text = date.ToString();
            }

            if(IsPersonal == true)
            {
                laType.Text = "Personal";
            }
            if(IsWork == true)
            {
                laType.Text = "Work";
            }
                

        }




    }
}
