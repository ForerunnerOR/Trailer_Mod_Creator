using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public List<defChassisCargo> Chassis = new List<defChassisCargo>();
        public List<defChassisCargo> Cargo = new List<defChassisCargo>();

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

            foreach (string current in ChassisStr)
            {
                defChassisCargo toAdd = new defChassisCargo();
                toAdd.filePath = (current.Split(','))[0];
                toAdd.displayName = (current.Split(','))[1];
                Chassis.Add(toAdd);
            }

            foreach (string current in CargoStr)
            {
                defChassisCargo toAdd = new defChassisCargo();
                toAdd.filePath = (current.Split(','))[0];
                toAdd.displayName = (current.Split(','))[1];
                Cargo.Add(toAdd);
            }

        }
    }
}
