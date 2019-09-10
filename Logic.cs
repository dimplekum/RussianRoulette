using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    public class Logic
    {
        // Variables
        private int bulletsAvailable = 0;
        private int maximumBulletsInRevolver = 6;
        private int[] bulletChamber = new int[6];
        private int shootAwayChances = 2;
        private LinkedList<int> bulletSlots;
        private string[] message = { "You Won!", "You Lost!", "You are out of Shoot Away Chances!", "The chamber was empty!", "You survived" };
        private int errorCode;
        private bool bDidWon = false;
        private int score = 0;
        private bool bGameOver = false;


        // Helper Functions
        private void SetIsGameOver(bool GameOver)
        {
            bGameOver = GameOver;
        }

        public bool GetIsGameOver()
        {
            return bGameOver;
        }

        public int GetTheScore()
        {
            return score;
        }

        private void AddTheScore(int value)
        {
            score += value;
        }

        private void SetTheErrorCode(int code)
        {
            errorCode = code;
        }

        private int GetTheErrorCode()
        {
            return errorCode;
        }

        public string GetTheErrorMessage()
        {
            return message[GetTheErrorCode()];
        }

        public int GetAvailableShootAwayChances()
        {
            return shootAwayChances;
        }

        public int GetTheAvailableBullets()
        {
            return bulletsAvailable;
        }

        public int GetTheMaxBullets()
        {
            return maximumBulletsInRevolver;
        }

        public int[] GetTheBulletChamber()
        {
            return bulletChamber;
        }

        public bool GetIfPlayerWon()
        {
            return bDidWon;
        }

        private void SetThePlayerWon(bool bWon)
        {
            bDidWon = bWon;
        }

        public void ResetStats()
        {
            SetThePlayerWon(false);
            SetIsGameOver(false);
            score = 0;
        }


        // Reload Function
        public void ReloadChamber()
        {
            shootAwayChances = 2;
            SetThePlayerWon(false);
            if (ChamberBulletsNeedsToBeCleared())
            {
                // This will empty all the bullets from the chambers
                Array.Clear(bulletChamber, 0, bulletChamber.Length);
                loadAmmo();
            }
            else
            {
                loadAmmo();
            }
        }

        // Checks if bullet needs to be removed from revolver
        private bool ChamberBulletsNeedsToBeCleared()
        {
            foreach (int bullet in GetTheBulletChamber())
            {
                if (bullet == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }


        // Spins the chamber
        public void SpinTheChambers()
        {
            // Moves the bullet to random slot
            Shuffle(bulletChamber);
            bulletSlots = new LinkedList<int>(bulletChamber);


            // The loop below is only used for testing purpose during development
            /**
            for (int i = 0; i < bulletChamber.Length; i++)
            {
                Console.WriteLine(bulletSlots.ElementAt(i));
            }
            Console.ReadLine();
            */
        }

        // Fire's ammo
        private void FireTheBullet(bool bShootAway)
        {
            if (GetTheAvailableBullets() > 0)
            {
                bulletsAvailable--;
                if (bShootAway)
                {
                    if (bulletSlots.ElementAt(0) == 1)
                    {
                        SetTheErrorCode(0);
                        AddTheScore(150);
                        SetThePlayerWon(true);
                        SetIsGameOver(true);
                    }
                    else
                    {
                        AddTheScore(10);
                        SetTheErrorCode(3);
                    }
                }
                else
                {
                    if (bulletSlots.ElementAt(0) == 1)
                    {
                        SetIsGameOver(true);
                        AddTheScore(0);
                        SetThePlayerWon(false);
                        SetTheErrorCode(1);
                    }
                    else
                    {
                        AddTheScore(50);
                        SetTheErrorCode(3);
                    }
                }
                bulletSlots.AddLast(bulletSlots.ElementAt(0));
                bulletSlots.RemoveFirst();
            }
        }

        // Shoots away
        public void ShootAway()
        {
            shootAwayChances--;
            FireTheBullet(true);
        }

        // Shot's self
        public void Shoot()
        {
            FireTheBullet(false);
        }

        // Load ammo to your revolver
        private void loadAmmo()
        {
            for (int i = 0; i < GetTheMaxBullets(); i++)
            {
                if (i < 1 || i > 1)
                {
                    bulletChamber[i] = 0;
                }
                else
                {
                    bulletChamber[i] = i;
                }
                bulletsAvailable = bulletChamber.Length;
            }
        }

        // Shuffling Logic
        public void Shuffle(int[] chambers)
        {
            int n = chambers.Length;
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                Replacer(chambers, i, i + rand.Next(n - i));
            }
        }

        // Randomizer
        private void Replacer(int[] arr, int a, int b)
        {
            // Swaps all index's
            int randomInt = arr[a];
            arr[a] = arr[b];
            arr[b] = randomInt;
        }
    }
}
