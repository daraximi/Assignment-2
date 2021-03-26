using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public const string A = "ABIA";
        public const string B = "ADAMAWA";
        public const string C = "AKWA IBOM";
        public const string D = "ANAMBRA";
        public const string E = "BAUCHI";
        public const string F = "BAYELSA";
        public const string G = "BENUE";
        public const string H = "BORNO";
        public const string I = "CROSS RIVER";
        public const string J = "DELTA";
        public const string K = "EBONYI";
        public const string L = "EDO";
        public const string M = "EKITI";
        public const string N = "ENUGU";
        public const string O = "FCT";
        public const string P = "GOMBE";
        public const string Q = "IMO";
        public const string R = "JIGAWA";
        public const string S = "KADUNA";
        public const string T = "KANO";
        public const string U = "KATSINA";
        public const string V = "KEBBI";
        public const string W = "KOGI";
        public const string X = "KWARA";
        public const string Y = "LAGOS";
        public const string Z = "NASSARAWA";
        public const string AA = "NIGER";
        public const string AB = "OGUN";
        public const string AC = "ONDO";
        public const string AD = "OSUN";
        public const string AE = "OYO";
        public const string AF = "PLATEAU";
        public const string AG = "RIVERS";
        public const string AH = "SOKOTO";
        public const string AI = "TARABA";
        public const string AJ = "YOBE";
        public const string AK = "ZAMFARA";


        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        public void label1_Click (object sender, EventArgs e)
        {

        }

        public void btnClickThis_Click (object sender, EventArgs e)
        {

            pictureBox1.Image = WindowsFormsApp1.Properties.Resources.igr;

        }

        public void pictureBox1_Click (object sender, EventArgs e)
        {

        }

        public void btnLesdDet_Click (object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApp1.Properties.Resources.nigeria_administrative_map;
        }

        public void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == A)
            {
                label2.Text = "IGR : 14,769,307,658.56";
            }
            if (comboBox1.SelectedItem == B)
            {
                label2.Text = "IGR : 9,704,660,185.44";
            }
            if (comboBox1.SelectedItem == C)
            {
                label2.Text = "IGR : 32,291,014,771.52";
            }
            if (comboBox1.SelectedItem == D )
            {
                label2.Text = "IGR : 26,369,195,864.89";
            }
            if (comboBox1.SelectedItem ==  E)
            {
                label2.Text = "IGR:  11,696,955,884.75";
            }
            if (comboBox1.SelectedItem == F)
            {
                label2.Text = "IGR:  16,342,762,531.99";
            }
            if (comboBox1.SelectedItem == G)
            {
                label2.Text = "IGR:  17,850,480,389.57";
            }
            if (comboBox1.SelectedItem == H)
            {
                label2.Text = "IGR:  8,175,248,326.42";
            }
            if (comboBox1.SelectedItem == I)
            {
                label2.Text = "IGR:  22,597,063,882.55";
            }
            if (comboBox1.SelectedItem == J)
            {
                label2.Text = "IGR:  64,678,796,991.57";
            }
            if (comboBox1.SelectedItem == K)
            {
                label2.Text = "IGR:  7,455,294,676.59";
            }
            if (comboBox1.SelectedItem == L)
            {
                label2.Text = "IGR:  29,478,406,024.31";
            }
            if (comboBox1.SelectedItem == M)
            {
                label2.Text = "IGR:  8,546,875,648.24";
            }
            if (comboBox1.SelectedItem == N)
            {
                label2.Text = "IGR:  31,069,466,913.00";
            }
            if (comboBox1.SelectedItem == O)
            {
                label2.Text = "IGR:  74,564,180,835.31";
            }
            if (comboBox1.SelectedItem == P)
            {
                label2.Text = "IGR:  6,803,064,814.10";
            }
            if (comboBox1.SelectedItem == Q)
            {
                label2.Text = "IGR:  16,095,299,620.59";
            }
            if (comboBox1.SelectedItem == R)
            {
                label2.Text = "IGR:  12,926,658,146.29";
            }
            if (comboBox1.SelectedItem == S)
            {
                label2.Text = "IGR:  44,956,576,583.38";
            }
            if (comboBox1.SelectedItem == T)
            {
                label2.Text = "IGR:  40,593,701,332.48";
            }
            if (comboBox1.SelectedItem == U)
            {
                label2.Text = "IGR:  8,496,742,119.00";
            }
            if (comboBox1.SelectedItem == V)
            {
                label2.Text = "IGR:  7,367,334,837.13";
            }
            if (comboBox1.SelectedItem == W)
            {
                label2.Text = "IGR:  16,389,026,388.86";
            }
            if (comboBox1.SelectedItem == X)
            {
                label2.Text = "IGR:  30,646,731,408.92";
            }
            if (comboBox1.SelectedItem == Y)
            {
                label2.Text = "IGR:  398,732,246,493.38";
            }
            if (comboBox1.SelectedItem == Z)
            {
                label2.Text = "IGR:  10,858,822,422.98";
            }
            if (comboBox1.SelectedItem == AA)
            {
                label2.Text = "IGR:  12,765,034,972.30";
            }
            if (comboBox1.SelectedItem == AB)
            {
                label2.Text = "IGR:  70,922,590,495.89";
            }
            if (comboBox1.SelectedItem == AC)
            {
                label2.Text = "IGR:  30,135,881,918.26";
            }
            if (comboBox1.SelectedItem == AD)
            {
                label2.Text = "IGR:  17,922,394,523.43";
            }
            if (comboBox1.SelectedItem == AE)
            {
                label2.Text = "IGR:  26,746,460,235.93";
            }
            if (comboBox1.SelectedItem == AF)
            {
                label2.Text = "IGR:  16,480,111,593.83";
            }
            if (comboBox1.SelectedItem == AG)
            {
                label2.Text = "IGR:  140,398,744,302.70";
            }
            if (comboBox1.SelectedItem == AH)
            {
                label2.Text = "IGR:  19,005,093,541.11";
            }
            if (comboBox1.SelectedItem == AI)
            {
                label2.Text = "IGR:  6,533,106,447.27";
            }
            if (comboBox1.SelectedItem == AJ)
            {
                label2.Text = "IGR:  8,444,634,099.09";
            }
            if (comboBox1.SelectedItem == AK)
            {
                label2.Text = "IGR:  15,416,043,399.76";
            }
        }
    }
}
