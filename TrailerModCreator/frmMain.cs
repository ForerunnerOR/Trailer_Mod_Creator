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
        public int wheelOffset = 0;

        public List<defTrailer> Trailers = new List<defTrailer>();

        public frmMain()
        {
            InitializeComponent();
            foreach (string current in TrailersStr)
            {
                defTrailer toAdd = new defTrailer();
                toAdd.filePath = (current.Split(','))[0];
                toAdd.unitName = (current.Split(','))[1];
                toAdd.unitName = toAdd.unitName.Remove(toAdd.unitName.Length - 1);
                Trailers.Add(toAdd);
            }

            defChassisCargo toAddCargo = new defChassisCargo();
            toAddCargo.filePath = ("none");
            toAddCargo.displayName = ("No Cargo");
            cmbTrailerCargo.Items.Add(toAddCargo);
            toAddCargo = null;

            foreach (string current in ChassisStr)
            {
                defChassisCargo toAdd = new defChassisCargo();
                toAdd.filePath = (current.Split(','))[0];
                toAdd.displayName = (current.Split(','))[1];
                toAdd.axleCount = Convert.ToInt16((current.Split(','))[2]);
                if ((current.Split(','))[3].Contains("true"))
                {
                    toAdd.isPainted = true;
                }
                else
                {
                    toAdd.isPainted = false;
                }
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

        public string addWheel (string inString)
        {
            string outString = inString;

            outString = outString.Replace("\t#addwheelacc", "\taccessories[]: .<intname>.twheel"+wheelOffset.ToString()+"\n\t#addwheelacc");
            outString = outString.Replace("#addwheeldef", "vehicle_wheel_accessory : .<intname>.twheel" + wheelOffset.ToString() + " {\n\toffset: " + wheelOffset.ToString() + "\n\tdata_path: @/def/vehicle/t_wheel/single.sii@\n}\n#addwheeldef");
            wheelOffset = wheelOffset + 2;

            return outString;
        }

        public string addWheelSmall(string inString)
        {
            string outString = inString;

            outString = outString.Replace("\t#addwheelacc", "\taccessories[]: .<intname>.twheel" + wheelOffset.ToString() + "\n\t#addwheelacc");
            outString = outString.Replace("#addwheeldef", "vehicle_wheel_accessory : .<intname>.twheel" + wheelOffset.ToString() + " {\n\toffset: " + wheelOffset.ToString() + "\n\tdata_path: @/def/vehicle/t_wheel/overweight.sii@\n}\n#addwheeldef");
            wheelOffset = wheelOffset + 2;

            return outString;
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

            defChassisCargo tempCargo = cmbTrailerCargo.SelectedItem as defChassisCargo;
            defChassisCargo tempTrailer = cmbTrailerChassis.SelectedItem as defChassisCargo;

            //Write files
            foreach (defTrailer currentTrailer in Trailers)
            {
                //Start and reset variables
                string siiContent = Properties.Resources.blankSii;
                wheelOffset = 0;

                //Add wheels
                if (tempTrailer.axleCount > 0)
                {
                    for (int i = 0; i < tempTrailer.axleCount; i++)
                    {
                        siiContent = addWheel(siiContent);
                    }
                }
                else
                {
                    for (int i = 0; i < tempTrailer.axleCount * -1; i++)
                    {
                        siiContent = addWheelSmall(siiContent);
                    }
                }

                //Add cargo or remove guidelines
                if (cmbTrailerCargo.Text == "No Cargo")
                {
                    siiContent = siiContent.Replace("\t#addcargoacc\n", "").Replace("#addcargodef\n", "");
                }
                else
                {
                    siiContent = siiContent.Replace("\t#addcargoacc", "\taccessories[]: .<intname>.cargo");
                    siiContent = siiContent.Replace("#addcargodef", "vehicle_accessory : .<intname>.cargo {\n\tdata_path: @/def/vehicle/trailer/" + tempCargo.filePath +"@\n}");
                }

                if (tempTrailer.isPainted == true)
                {
                    siiContent = siiContent.Replace("\t#addpaintacc", "\taccessories[]: .<intname>.paint");
                    siiContent = siiContent.Replace("#addpaintdef", "vehicle_paint_job_accessory : .<intname>.paint {\n\tdata_path: @/def/vehicle/trailer/krone/profiliner/company_paint_job/default.sii@\n}");
                }
                else
                {
                    siiContent = siiContent.Replace("\t#addpaintacc\n", "").Replace("#addpaintdef\n", "");
                }

                siiContent = siiContent.Replace("<trailer>", tempTrailer.filePath).Replace('@','"').Replace("<intname>",currentTrailer.unitName);

                using (StreamWriter siiout = new StreamWriter(localPath + txtModName.Text + "/def/vehicle/trailer/" + currentTrailer.filePath + ".sii"))
                {
                    siiout.Write(siiContent);
                }
                Console.Write(currentTrailer + " has been written\n");

            }
        }
    }
}
