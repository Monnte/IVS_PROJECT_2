using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IVS_Calculator
{
    public partial class Colours : Form
    {
        public string configfile;
        List<string> settings = new List<string>();
        public Colours(string configfile)
        {
            this.configfile = configfile;
            InitializeComponent();
            loadConfig();
            this.color_dialog = new System.Windows.Forms.ColorDialog();
            if (File.Exists(configfile))
                settings.AddRange(File.ReadAllLines(configfile));
        }

        private void saveSettings()
        {
            File.WriteAllLines(configfile, settings);
            loadConfig();
            Close();
        }
        private void changeColor(string componentName)
        {
            this.color_dialog.ShowDialog();

            string newColor = color_dialog.Color.ToArgb().ToString();
            string attribute = string.Empty;
            if (check_background.Checked)
                attribute = "backColor";
            if (check_font.Checked)
                attribute = "fontColor";
            for (int i = 0; i < settings.Count; i++)
            {
                if (settings[i].Split(':')[0].Trim(' ', '"') == componentName && settings[i].Split(':')[1].Split('=')[0].Trim(' ', '"') == attribute)
                    settings.RemoveAt(i);

            }
            settings.Add(componentName + ":" + attribute + "=" + newColor);

            loadSettings(settings);
        }
        public void loadConfig()
        {
            if (!File.Exists(configfile)) return;
                string[] configLines = File.ReadAllLines(configfile);
            loadSettings(configLines.ToList());

        }
        private void loadSettings(List<string> settings)
        {
            foreach (string line in settings)
            {
                if (!line.Contains(":")) continue;
                List<string> config = line.Split(':').ToList<string>();
                if (!config[1].Contains("=")) continue;
                config.AddRange(config[1].Split('='));
                config.RemoveAt(1);
                IEnumerable<Control> found = GetAll(this, config[0].Trim(' ', '"'));
                if (found.Count() == 0) continue;
                foreach (Control con in found)
                {
                    if (config[1].Trim(' ', '"') == "backColor")
                        con.BackColor = Color.FromArgb(int.Parse(config[2].Trim(' ', '"')));
                    if (config[1].Trim(' ', '"') == "fontColor")
                        con.ForeColor = Color.FromArgb(int.Parse(config[2].Trim(' ', '"')));
                }

            }
        }

        public IEnumerable<Control> GetAll(Control control, string name)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, name))
                                      .Concat(controls)
                                      .Where(c => c.Name.Contains(name));
        }

        private void button_memory_mc_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_memory_mr_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_memory_plus_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_memory_minus_Click(object sender, EventArgs e)
        {
            //changeColor("button_memory_minus");
            changeColor(((Button)sender).Name);
        }

        private void button_memory_ms_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_factorial_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_power_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_root_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_abs_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_fraction_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_power2_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_root2_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_division_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_7_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_8_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_9_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_4_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_5_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_6_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_1_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_2_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_3_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_num_0_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_multiply_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_minus_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_plus_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_change_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_dot_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_equal_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeColor("Calculator");
        }

        private void button_oper_percent_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_ce_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_c_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void button_oper_del_Click(object sender, EventArgs e)
        {
            changeColor(((Button)sender).Name);
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void all_operators_Click(object sender, EventArgs e)
        {
            changeColor("button_oper");
        }

        private void all_numbers_Click(object sender, EventArgs e)
        {
            changeColor("button_num");
        }

        private void reset_default_Click(object sender, EventArgs e)
        {
            settings.Clear();
            settings.Add("button_oper:backColor=" + Color.FromArgb(64, 64, 64).ToArgb().ToString());
            settings.Add("button_num:backColor=" + Color.FromArgb(235, 143, 88).ToArgb().ToString());
            settings.Add("button_oper:fontColor=" + Color.White.ToArgb().ToString());
            settings.Add("button_num:fontColor=" + Color.White.ToArgb().ToString());
            loadSettings(settings);
        }
    }
}
