using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAudit
{
    public partial class Main : Form
    {
        private SchoolDB db = new SchoolDB();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<Class> clss = new List<Class>();
            cbo_Degrees.DataSource = db.Degrees.ToList();
            cbo_Degrees.DisplayMember = "DName";
            cbo_Degrees.ValueMember = "DName";
            IEnumerable<Class> classquery1 =
                from classes in db.Classes
                where classes.DName == null
                select classes;
            foreach (Class cl in classquery1)
            {
                clss.Add(cl);
            }
            lbo_GenClassList.DataSource = clss;
            lbo_GenClassList.DisplayMember = "CName";
            lbo_GenClassList.ValueMember = "Credits";
        }

        private void btn_Populate_Click(object sender, EventArgs e)
        {
            Degree selctdgree = new Degree();
            selctdgree = (Degree)cbo_Degrees.SelectedItem;
            txt_MinGenCredits.Text = selctdgree.MinGenCredits.ToString();
            txt_MinDegClasses.Text = selctdgree.MinCoreCredits.ToString();
            List<Class> clss = new List<Class>();
            IEnumerable<Class> classquery2 =
                from classes in db.Classes
                where classes.DName == selctdgree.DName
                select classes;
            foreach (Class cl in classquery2)
            {
                clss.Add(cl);
            }
            lbo_ProgClasses.DataSource = clss;
            lbo_ProgClasses.DisplayMember = "CName";
            lbo_ProgClasses.ValueMember = "Credits";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Audit_Click(object sender, EventArgs e)
        {
            Degree selctdeg = (Degree)cbo_Degrees.SelectedItem;
            String sugcoreclasses = "";
            String suggenclasses = "";
            int genclasscredttl = 0;
            int coreclasscredttl = 0;
            for (int i = 0; i < lbo_GenClassList.Items.Count; i++)
            {
                Class c = new Class();
                c =  (Class)lbo_GenClassList.Items[i];
                if (lbo_GenClassList.SelectedItems.Contains(c))
                {
                    genclasscredttl += c.Credits;
                }
                else
                {
                    suggenclasses += c.CName + "\n";
                }
            }
            for (int i = 0; i < lbo_ProgClasses.Items.Count; i++)
            {
                Class c = new Class();
                c = (Class)lbo_ProgClasses.Items[i];
                if (lbo_ProgClasses.SelectedItems.Contains(c))
                {
                    coreclasscredttl += c.Credits;
                }
                else
                {
                    sugcoreclasses += c.CName + "\n";
                }
            }
            if (genclasscredttl == selctdeg.MinGenCredits && coreclasscredttl == selctdeg.MinCoreCredits)
            {
                MessageBox.Show("You have completed all the classes you need to graduate.");
            }
            else if (genclasscredttl < selctdeg.MinGenCredits && coreclasscredttl == selctdeg.MinCoreCredits)
            {
                MessageBox.Show("You have not completed all the required general classes for this degree.\nHere are some classes you can take:\n\n" + suggenclasses);
            }
            else if (coreclasscredttl < selctdeg.MinCoreCredits && genclasscredttl == selctdeg.MinGenCredits)
            {
                MessageBox.Show("You have not completed all the required core classes for this degree.\nHere are some classes you can take:\n\n" + sugcoreclasses);
            }
            else if (coreclasscredttl < selctdeg.MinCoreCredits && genclasscredttl < selctdeg.MinGenCredits)
            {
                MessageBox.Show("You have not completed the required core and general classes for this degree.\nHere are some classes you can take:\n\nGeneral Classes:\n\n" + suggenclasses + "\nCore Classes:\n\n" + sugcoreclasses);
            }
            else
            {
                MessageBox.Show("You shouldn't be able to get this message, if you did, something went horribly wrong.");
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1: Select a degree from the drop down menu at the top then press the 'Populate' button.\n\nStep 2: Select all of the classes you have taken so far and press the 'Audit Button'.");
        }
    }
}
