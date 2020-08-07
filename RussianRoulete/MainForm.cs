using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulete
{
    public partial class MainForm : Form
    {
        LogicClass SettingObj = new LogicClass();
       
            
        public MainForm()
        {
            InitializeComponent();
            SettingObj.Bullet = 0;
        }


        private void ShootAtHead_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Resource1.shootatheadvoice);
            player.Play();
            textBox1.Text = SettingObj.Point + "";
            SettingObj.ShootAtHead();
            //ShootAway.Enabled = false;
            ShootAtHead.Enabled = true;
            PlayAgain.Enabled = true;

        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Resource1.shootaway123);
            player.Play();
            SettingObj.ShootAway();
           
            ShootAway.Enabled = true;
            //ShootAtHead.Enabled = false;
            PlayAgain.Enabled = true;

        }


        private void Spin_Click(object sender, EventArgs e)
        {
            //Spinning the revolver, giving bullet a random position
            Random rand = new Random();
            SettingObj.Bullet = rand.Next(0, 6);

            SoundPlayer player = new SoundPlayer(Resource1.tortuer);
            player.Play();
            Spin.Enabled = false;
            ShootAway.Enabled = true;
            ShootAtHead.Enabled = true;
            SaveMe.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

            LoadBtn.Enabled = true;
            ShootAway.Enabled = false;
            ShootAtHead.Enabled = false;
            Spin.Enabled = false;
            SaveMe.Enabled = false;
            PlayAgain.Enabled = false;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            //loading the weapon, setting the bullet to be zero
            SettingObj.Bullet = 0;
            SoundPlayer player = new SoundPlayer(Resource1.loading123);
            player.Play();
            LoadBtn.Enabled = false;
            Spin.Enabled = true;
        }

        private void SaveMe_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Resource1.saved123);
            player.Play();
            MessageBox.Show("You saved the person (he ran away)");
            ShootAway.Enabled = false;
            ShootAtHead.Enabled = false;
            Spin.Enabled = false;
            SaveMe.Enabled = false;
            PlayAgain.Enabled = true;
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to replay?");
            ShootAway.Enabled = false;
            ShootAtHead.Enabled = false;
            Spin.Enabled = false;
            SaveMe.Enabled = false;
            LoadBtn.Enabled = true;

        }
    }
}
