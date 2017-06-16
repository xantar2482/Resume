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
        private GroupBox[] groupVisBox = new GroupBox[6];

        // Start
        public FormResume()
        {
            InitializeComponent();
            link_GitHub.Links.Add(0,12, "https://github.com/xantar2482");
            link_LinkedIN.Links.Add(0, 12, "https://www.linkedin.com/in/chris-niehaus");
            populateGroupBoxes();
        }

        // Main Functions
        private void startApp()
        {
            gBox_Welcome.Visible = true;
            pnl_Welcome.Visible = false;
            pnl_Start.Visible = true;
        }

        private void populateGroupBoxes()
        {
            groupVisBox[0] = gBox_Welcome;
            groupVisBox[1] = gBox_Objective;
            groupVisBox[2] = gBox_AboutMe;
            groupVisBox[3] = gBox_Education;
            groupVisBox[4] = gBox_Skills;
            groupVisBox[5] = gBox_WorkHistory;
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
            for (int i = 0; i < groupVisBox.Length; i++)
            {
                if (groupVisBox[i].Visible == true)
                {
                    groupVisBox[i].Visible = false;
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

        private void cycleExplain()
        {
            //cycle groupBoxes

            if (pnl_Welcome.Visible == true)
            {
                Explain show = new Explain();
                show.setMessage("     -pnl_Welcome.vis true"
                    + Environment.NewLine
                    + "     -Environment.NewLine"
                    + Environment.NewLine
                    + "     -pnl_Start.vis false");

                show.ShowDialog();
             }

            for (int i = 0; i < groupVisBox.Length; i++)
            {
                //groupVisBox[0] = gBox_Welcome;
                //groupVisBox[1] = gBox_Objective;
                //groupVisBox[2] = gBox_AboutMe;
                //groupVisBox[3] = gBox_Education;
                //groupVisBox[4] = gBox_Skills;
                //groupVisBox[5] = gBox_WorkHistory;

                if (groupVisBox[i].Visible == true)
                {
                    if (i == 0) // gb Welcome
                    {
                        Explain show = new Explain();
                        show.setMessage("pnl_welcome.Visible = false"
                            + Environment.NewLine
                            + "Components used:  "
                            + Environment.NewLine
                            + "     -ComboBox"
                            + Environment.NewLine
                            + "     -btn_Select > Event > if index selected == x > display"
                            + Environment.NewLine
                            + "     -LinkedLabel & Labels");

                        show.ShowDialog();
                    }
                    if (i == 1) // gb Objective
                    {
                        Explain show = new Explain();
                        show.setMessage("Simple labels and groupboxes, nothing fancy");
                        show.ShowDialog();
                    }
                    if (i == 2) // gb About Me
                    {
                        Explain show = new Explain();
                        show.setMessage( "Components:  "
                            + Environment.NewLine
                            + "     -Listbox"
                            + Environment.NewLine
                            + "     -Richtext box -> The text displayed is read from a .txt file that has been embedded into resources"
                            + Environment.NewLine
                            + "     -PictureBox -> embedded bitmap"
                            + Environment.NewLine
                            + "View button triggers an if() statement that finds selected item.ToString() == 'text'"
                            + Environment.NewLine
                            + "");
                        show.ShowDialog();
                    }
                    if (i == 3) // gb Education
                    {
                        Explain show = new Explain();
                        show.setMessage("Simple labels and groupbox, nothing fancy");
                        show.ShowDialog();
                    }
                    if (i == 4) // gb Skills
                    {
                        Explain show = new Explain();
                        show.setMessage("Components:  "
                            + Environment.NewLine
                            + "     -This section uses the WebBrowser component, which is linked to my wordpress blog (created for this project)" 
                            + Environment.NewLine
                            + "     -This is a live view of the site.");
                        show.ShowDialog();
                    }
                    if (i == 5) // gb Work History
                    {
                        Explain show = new Explain();
                        show.setMessage("Components:  "
                            + Environment.NewLine
                            + "     -Richtext box- agian reading .txt from embedded resource"
                            + Environment.NewLine
                            + "     -Radio Buttons- Simple, no tricks.  View button event finds the .Checked == true then reads file");
                        show.ShowDialog();
                    }
                }  
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

        private void btn_Explain_Click(object sender, EventArgs e)
        {
            cycleExplain();
        }

        private void btn_Whatis_Click(object sender, EventArgs e)
        {
            Explain show = new Explain();

            show.setMessage("This is a form used as a custom message box" 
                + Environment.NewLine 
                + "     -When you click the 'What is going on' button..." 
                + Environment.NewLine 
                + "          -new Explain() / showDialog()" 
                + Environment.NewLine 
                + "          -Loop for *groupBox.Visible == true"
                +Environment.NewLine
                + "          -Explain.cs -> setMessage(string message);"
                + Environment.NewLine
                + "          -Dispose() on button event ok");

            show.ShowDialog();
            show.Dispose();
        }
    }
}
