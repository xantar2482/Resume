using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiehausResume
{
    public partial class FormResume : Form
    {
        //private string aboutMeFileName = @"bin/Files/AboutMeSection.txt";
        //private string familyFileName = @"bin/Files/FamilySection.txt";
        //private string hobbiesFileName = @"bin/Files/HobbiesSection.txt";
        //private string UMSLFileName = @"bin/Files/UMSL.txt";
        //private string DSFCFileName = @"bin/Files/DSFC.txt";
        //private string EmmausFileName = @"bin/Files/Emmaus.txt";

        private GroupBox[] currentDisplay = new GroupBox[6];

        // Start
        public FormResume()
        {
            InitializeComponent();
            link_GitHub.Links.Add(0,12, "https://github.com/xantar2482");
            link_LinkedIN.Links.Add(0, 12, "https://www.linkedin.com/in/chris-niehaus");
            
        }

        // Main Functions
        private void startApp()
        {
            populateGroupBoxes();

            gBox_Welcome.Visible = true;
            pnl_Welcome.Visible = false;
            pnl_Start.Visible = true;
        }

        private void populateGroupBoxes()
        {
            currentDisplay[0] = gBox_Welcome;
            currentDisplay[1] = gBox_Objective;
            currentDisplay[2] = gBox_AboutMe;
            currentDisplay[3] = gBox_Education;
            currentDisplay[4] = gBox_Skills;
            currentDisplay[5] = gBox_WorkHistory;
         }      

        private void cycleComboOptions()
        {
            if (cBox_ResumeCats.SelectedItem.ToString() == "Select")
            {
                //msg
            }
            if (cBox_ResumeCats.SelectedItem.ToString() == "Objective")
            {
                setCurrentVisibleFalse();
                gBox_Objective.Visible = true;
            }
            if (cBox_ResumeCats.SelectedItem.ToString() == "About Me")
            {
                setCurrentVisibleFalse();
                gBox_AboutMe.Visible = true;
            }
            if (cBox_ResumeCats.SelectedItem.ToString() == "Education")
            {
                setCurrentVisibleFalse();
                gBox_Education.Visible = true;
            }
            if (cBox_ResumeCats.SelectedItem.ToString() == "Skills")
            {
                setCurrentVisibleFalse();
                gBox_Skills.Visible = true;
            }
            if (cBox_ResumeCats.SelectedItem.ToString() == "Work History")
            {
                setCurrentVisibleFalse();
                gBox_WorkHistory.Visible = true;
            }
        }

        private void setCurrentVisibleFalse()
        {
            for (int i = 0; i < currentDisplay.Length; i++)
            {
                if (currentDisplay[i].Visible == true)
                {
                    currentDisplay[i].Visible = false;
                }
            }

        }

        private void cycleWorkHistory()
        {
            if (rb_UMSL.Checked == true)
            {
                rtb_WorkHistory.Text = Properties.Resources.UMSL.ToString();
            }

            if (rb_DSFC.Checked == true)
            {
                rtb_WorkHistory.Text = Properties.Resources.DSFC.ToString();
            }

            if (rb_Emmaus.Checked == true)
            {
                rtb_WorkHistory.Text = Properties.Resources.Emmaus.ToString();
            }
        }

        private void cycleAboutMe()
        {
            if (lstBx_AboutMe.SelectedItem.ToString() == "About Me")
            {

                rtb_AboutMe.Text = Properties.Resources.AboutMeSection.ToString() ;
            }

            if (lstBx_AboutMe.SelectedItem.ToString() == "Family")
            {
                rtb_AboutMe.Text = Properties.Resources.FamilySection.ToString();
            }

            if (lstBx_AboutMe.SelectedItem.ToString() == "Hobbies")
            {
                rtb_AboutMe.Text = Properties.Resources.HobbiesSection.ToString();
            }
        }

        // Events
        private void btn_AboutMeSelect(object sender, EventArgs e)
        {
            rtb_AboutMe.Clear();
            cycleAboutMe();
        }

        private void doExit(object sender, EventArgs e)
        {
            link_GitHub.Dispose();
            link_LinkedIN.Dispose();
            rtb_AboutMe.Dispose();
            rtb_WorkHistory.Dispose();
            pBox_AboutMePic.Dispose();
            wb_Skills.Dispose();
            Close();
        }

        private void btn_SelectMain_Click(object sender, EventArgs e)
        {
            cycleComboOptions();
        }

        private void link_LinkedIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void link_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void btn_EmpHistory_Click(object sender, EventArgs e)
        {
            cycleWorkHistory();
        }

        private void Menu_FileStart_Click(object sender, EventArgs e)
        {
            startApp();
        }

        private void noEditComboBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
