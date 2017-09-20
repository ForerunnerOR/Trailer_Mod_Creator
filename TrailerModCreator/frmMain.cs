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

namespace TrailerModCreator
{
    public partial class frmMain : Form
    {
        //Pull in resources
        public string[] TrailersStr = Properties.Resources.defTrailers.Split('\n');
        public string[] ChassisStr = Properties.Resources.defChassis.Split('\n');
        public string[] CargoStr = Properties.Resources.defCargo.Split('\n');

        public List<defTrailer> Trailers = new List<defTrailer>();

        public frmMain()
        {
            InitializeComponent();
            foreach (string current in TrailersStr)
            {
                defTrailer toAdd = new defTrailer();
                toAdd.filePath = (current.Split(','))[0];
                toAdd.unitName = (current.Split(','))[1];
                Trailers.Add(toAdd);
            }

            defChassisCargo toAddCargo = new defChassisCargo();
            toAddCargo.filePath = ("none");
            toAddCargo.displayName = (" No Cargo");
            cmbTrailerCargo.Items.Add(toAddCargo);
            toAddCargo = null;

            foreach (string current in ChassisStr)
            {
                defChassisCargo toAdd = new defChassisCargo();
                toAdd.filePath = (current.Split(','))[0];
                toAdd.displayName = (current.Split(','))[1];
                cmbTrailerChassis.Items.Add(toAdd);
            }

            foreach (string current in CargoStr)
            {
                defChassisCargo toAdd = new defChassisCargo();
                toAdd.filePath = (current.Split(','))[0];
                toAdd.displayName = (current.Split(','))[1];
                cmbTrailerCargo.Items.Add(toAdd);
            }

        }

        private void btnBuildMod_Click(object sender, EventArgs e)
        {
            if (txtModName.Text.Length == 0)
            {
                MessageBox.Show("You must enter a mod name.");
                return;
            }
            if (cmbTrailerChassis.Text.Length == 0)
            {
                MessageBox.Show("You must select a trailer chassis.");
                return;
            }
            if (cmbTrailerCargo.Text.Length == 0)
            {
                MessageBox.Show("You must select a cargo.");
                return;
            }

            //Gets location of program. Should be in mod folder.
            string localPath = AppDomain.CurrentDomain.BaseDirectory;
            Directory.CreateDirectory(localPath + txtModName.Text + "/def/vehicle/trailer");

            //Write files
            foreach (defTrailer currentTrailer in Trailers)
            {

            }
        }
    }
}
