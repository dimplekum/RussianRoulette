using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class Form1 : Form
    {

        private Logic log = new Logic();

        public Form1()
        {
            InitializeComponent();

            Assembly assemble = Assembly.GetExecutingAssembly();
            Bitmap bm = new Bitmap(RussianRoulette.Properties.Resources.russian_roulette_by_reddii_d4x39wz);
            pictureBox1.Image = bm;
        }

        private void SpinClamber_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sfx = new System.Media.SoundPlayer(RussianRoulette.Properties.Resources.spinning);
            sfx.Play();
            Bitmap bitmap = new Bitmap(RussianRoulette.Properties.Resources.spin);
            pictureBox1.Image = bitmap;
            log.SpinTheChambers();
            reloadRevolver.Enabled = false;
            spinClamber.Enabled = false;
            shootAway.Enabled = true;
            Fire.Enabled = true;
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sfx = new System.Media.SoundPlayer(RussianRoulette.Properties.Resources.shoot1);
            sfx.Play();
            Bitmap bitmap = new Bitmap(RussianRoulette.Properties.Resources.shootself);
            pictureBox1.Image = bitmap;
            log.Shoot();
            errorLabel.Text = log.GetTheErrorMessage();
            reloadRevolver.Enabled = false;
            spinClamber.Enabled = false;

            scoreLabel.Text = "Score: " + log.GetTheScore().ToString();

            if (!log.GetIsGameOver())
            {
                if (log.GetTheAvailableBullets() > 0)
                {
                    Fire.Enabled = true;
                }
                else
                {
                    Fire.Enabled = false;
                }
            }
            else
            {
                shootAway.Enabled = false;
                Fire.Enabled = false;
                errorLabel.Text = log.GetTheErrorMessage();
                victoryIndicator.Text = log.GetTheErrorMessage();
                resetGame.Enabled = true;
            }
        }

        private void ReloadRevolver_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sfx = new System.Media.SoundPlayer(RussianRoulette.Properties.Resources.Gun_Reload);
            sfx.Play();
            Bitmap bitmap = new Bitmap(RussianRoulette.Properties.Resources.reload);
            pictureBox1.Image = bitmap;
            log.ReloadChamber();
            reloadRevolver.Enabled = false;
            spinClamber.Enabled = true;
            shootAway.Enabled = false;
            Fire.Enabled = false;

        }

        private void ResetGame_Click(object sender, EventArgs e)
        {
            reloadRevolver.Enabled = true;
            spinClamber.Enabled = false;
            shootAway.Enabled = false;
            Fire.Enabled = false;
            Bitmap bitmap = new Bitmap(RussianRoulette.Properties.Resources.russian_roulette_by_reddii_d4x39wz);
            pictureBox1.Image = bitmap;
            log.ResetStats();
            resetGame.Enabled = false;
            victoryIndicator.Text = "Vic Indicator";
            errorLabel.Text = "Error Message: ";
            scoreLabel.Text = "Score: 0";
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sfx = new System.Media.SoundPlayer(RussianRoulette.Properties.Resources.shoot1);
            sfx.Play();
            Bitmap bitmap = new Bitmap(RussianRoulette.Properties.Resources.shoot_in_the_air);
            pictureBox1.Image = bitmap;
            log.ShootAway();
            reloadRevolver.Enabled = false;
            spinClamber.Enabled = false;
            errorLabel.Text = log.GetTheErrorMessage();

            scoreLabel.Text = "Score: " + log.GetTheScore().ToString();

            if (!log.GetIsGameOver())
            {
                if (log.GetAvailableShootAwayChances() > 0)
                {
                    shootAway.Enabled = true;
                }
                else
                {
                    shootAway.Enabled = false;
                }

                Fire.Enabled = true;
            }
            else
            {
                shootAway.Enabled = false;
                Fire.Enabled = false;
                errorLabel.Text = log.GetTheErrorMessage();
                victoryIndicator.Text = log.GetTheErrorMessage();
                resetGame.Enabled = true;
            }
        }
    }
}
