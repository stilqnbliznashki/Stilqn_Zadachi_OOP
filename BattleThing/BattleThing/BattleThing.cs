using BattleThing.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleThing
{
    
    public partial class BattleThing : Form
    {
        public BattleThing()
        {
            InitializeComponent();
        }
        
        ToolTip Hover;

        //PvP
        
            //Create
        private void CreatePvPButton()
        {

            Point PvPLocation = new Point
            {
                X = 35,
                Y = 348
            };
            PvPButt.Location = PvPLocation;

            PvPButt.Text = "Player vs Player";
            Font PvPfont = new Font("Segoe UI", 36);
            PvPButt.Font = PvPfont;

            Size PvPSize = new Size
            {
                Width = 363,
                Height = 151
            };
            PvPButt.Size = PvPSize;
            PvPButt.ForeColor = Color.Black;
            PvPButt.BackColor = ColorTranslator.FromHtml("#5d7fa2");
            PvPButt.Click += new EventHandler(PvPButt_Click);
            this.Controls.Add(PvPButt);
        }
        private void PvPButt_Click(object sender, EventArgs e)
        {
            TitleLab.Text = "I'm not that smart";

        }




        //PvC
            //Create
            DataTable PlayerCharactersTable;
        DataTable ComputerCharactersTable;
        DataTable MageLevelsTable;
        DataTable WarriorLevelsTable;
        System.Windows.Forms.Timer imgTimer;
        private void CreatePvCButton()
        {
            //DataTable_Create

            PlayerCharactersTable = new DataTable();

            PlayerCharactersTable.Columns.Add("Type", typeof(string));
            PlayerCharactersTable.Columns.Add("Level", typeof(int));
            PlayerCharactersTable.Columns.Add("Health", typeof(int));
            PlayerCharactersTable.Columns.Add("Mana", typeof(int));
            PlayerCharactersTable.Columns.Add("Special", typeof(int));
            PlayerCharactersTable.Columns.Add("Image", typeof(Image));
            PlayerCharactersTable.Columns.Add("HealthLevel", typeof(int));
            PlayerCharactersTable.Columns.Add("ManaLevel", typeof(int));
            PlayerCharactersTable.Columns.Add("SpecialLevel", typeof(int));
            PlayerCharacters.DataSource = PlayerCharactersTable;

            //Computer
            ComputerCharactersTable = new DataTable();
            ComputerCharactersTable.Columns.Add("Type", typeof(string));
            ComputerCharactersTable.Columns.Add("Level", typeof(int));
            ComputerCharactersTable.Columns.Add("Health", typeof(int));
            ComputerCharactersTable.Columns.Add("Mana", typeof(int));
            ComputerCharactersTable.Columns.Add("Special", typeof(int));
            ComputerCharacters.DataSource = ComputerCharactersTable;





            //MageTable
            MageLevelsTable = new DataTable();
            MageLevelsTable.Columns.Add("Level", typeof(int));
            MageLevelsTable.Columns.Add("Health", typeof(int));
            MageLevelsTable.Columns.Add("Mana", typeof(int));
            MageLevelsTable.Columns.Add("Special", typeof(int));
            MageLevelsTable.Rows.Add(1, 100, 15, 10);
            MageLevelsTable.Rows.Add(2, 115, 17, 12);
            MageLevelsTable.Rows.Add(3, 132, 20, 14);
            MageLevelsTable.Rows.Add(4, 152, 23, 16);
            MageLevelsTable.Rows.Add(5, 175, 26, 18);

            //WarriorsTable
            WarriorLevelsTable = new DataTable();
            WarriorLevelsTable.Columns.Add("Level", typeof(int));
            WarriorLevelsTable.Columns.Add("Health", typeof(int));
            WarriorLevelsTable.Columns.Add("Mana", typeof(int));
            WarriorLevelsTable.Columns.Add("Special", typeof(int));
            WarriorLevelsTable.Rows.Add(1, 125, 10, 10);
            WarriorLevelsTable.Rows.Add(2, 144, 12, 12);
            WarriorLevelsTable.Rows.Add(3, 166, 14, 14);
            WarriorLevelsTable.Rows.Add(4, 191, 16, 16);
            WarriorLevelsTable.Rows.Add(5, 220, 18, 18);


            Point PvCLocation = new Point
            {
                X = 612,
                Y = 348
            };
            PvCButt.Location = PvCLocation;
            
            PvCButt.Text = "Player vs Computer";
            Font PvCfont = new Font("Segoe UI", 36);
            PvCButt.Font = PvCfont;

            Size PvCSize = new Size
            {
                Width = 363,
                Height = 151
            };
            PvCButt.Size = PvCSize;
            PvCButt.ForeColor = Color.Black;
            PvCButt.BackColor = ColorTranslator.FromHtml("#5d7fa2");
            PvCButt.Click += new EventHandler(PvCButt_Click);
            this.Controls.Add(PvCButt);
        }
        private void PvCButt_Click(object sender, EventArgs e)
        {
            PvC_ChooseCharacter();

        }
            //Choose
        private void PvC_ChooseCharacter()
        {
            
            PvCButt.Hide();
            TitleLab.Text = "Choose a character:";
            TitleLab.Location = new Point(35, 30);
            TitleLab.Size = new Size(940, 91);
            TitleLab.Font = new Font("Segoe UI", 48);
            SubTitle.Hide();
            PvPButt.Hide();
            


            //Mage
            MagePicture.Image = Properties.Resources.Mage;
            MagePicture.Size = new Size(211, 240);
            MagePicture.Location = new Point(133, 142);
            MagePicture.BackColor = Color.Transparent;
            this.Controls.Add(MagePicture);
            MagePicture.Show();

            ChooseMageHealth.Text = "Health: 100";
            ChooseMageHealth.Location = new Point(350, 174);
            ChooseMageHealth.AutoSize = true;
            ChooseMageHealth.Font = new Font("Segoe UI", 18);
            ChooseMageHealth.BackColor = Color.Transparent;
            this.Controls.Add(ChooseMageHealth);
            ChooseMageHealth.Show();

            ChooseMageLevel.Text = "Level: 1";
            ChooseMageLevel.Location = new Point(350, 142);
            ChooseMageLevel.AutoSize = true;
            ChooseMageLevel.Font = new Font("Segoe UI", 18);
            ChooseMageLevel.BackColor = Color.Transparent;
            this.Controls.Add(ChooseMageLevel);
            ChooseMageLevel.Show();

            ChooseMageInteligence.Text = "Inteligence: 10";
            ChooseMageInteligence.Location = new Point(350, 206);
            ChooseMageInteligence.AutoSize = true;
            ChooseMageInteligence.Font = new Font("Segoe UI", 18);
            ChooseMageInteligence.BackColor = Color.Transparent;
            this.Controls.Add(ChooseMageInteligence);
            ChooseMageInteligence.Show();

            ChooseMageMana.Text = "Mana: 15";
            ChooseMageMana.Location = new Point(350, 238);
            ChooseMageMana.AutoSize = true;
            ChooseMageMana.Font = new Font("Segoe UI", 18);
            ChooseMageMana.BackColor = Color.Transparent;
            this.Controls.Add(ChooseMageMana);
            ChooseMageMana.Show();





            //Warrior
            WarriorPicture.Image = Properties.Resources.Warrior;
            WarriorPicture.Size = new Size(211, 240);
            WarriorPicture.Location = new Point(676, 142);
            WarriorPicture.BackColor = Color.Transparent;
            this.Controls.Add(WarriorPicture);
            WarriorPicture.Show();

            ChooseWarriorMana.Text = "Mana: 10";
            ChooseWarriorMana.Location = new Point(558, 238);
            ChooseWarriorMana.AutoSize = true;
            ChooseWarriorMana.Font = new Font("Segoe UI", 18);
            ChooseWarriorMana.BackColor = Color.Transparent;
            this.Controls.Add(ChooseWarriorMana);
            ChooseWarriorMana.Show();

            ChooseWarriorHealth.Text = "Health: 125";
            ChooseWarriorHealth.Location = new Point(535, 174);
            ChooseWarriorHealth.AutoSize = true;
            ChooseWarriorHealth.Font = new Font("Segoe UI", 18);
            ChooseWarriorHealth.BackColor = Color.Transparent;
            this.Controls.Add(ChooseWarriorHealth);
            ChooseWarriorHealth.Show();

            ChooseWarriorStrength.Text = "Strength: 10";
            ChooseWarriorStrength.Location = new Point(527, 206);
            ChooseWarriorStrength.AutoSize = true;
            ChooseWarriorStrength.Font = new Font("Segoe UI", 18);
            ChooseWarriorStrength.BackColor = Color.Transparent;
            this.Controls.Add(ChooseWarriorStrength);
            ChooseWarriorStrength.Show();

            ChooseWarriorLevel.Text = "Level: 1";
            ChooseWarriorLevel.Location = new Point(576, 142);
            ChooseWarriorLevel.AutoSize = true;
            ChooseWarriorLevel.Font = new Font("Segoe UI", 18);
            ChooseWarriorLevel.BackColor = Color.Transparent;
            this.Controls.Add(ChooseWarriorLevel);
            ChooseWarriorLevel.Show();



            MageChooseButt.Show();
            MageChooseButt_Create();
            WarriorChooseButt.Show();
            WarriorChooseButt_Create();

        }



        //Mage

            //Choose
        private void MageChooseButt_Create()
        {
            Point MageChooseLocation = new Point
            {
                X = 120,
                Y = 407
            };
            MageChooseButt.Location = MageChooseLocation;

            MageChooseButt.Text = "Mage";
            Font MageChooseFont = new Font("Segoe UI", 36);
            MageChooseButt.Font = MageChooseFont;

            Size MageChooseSize = new Size
            {
                Width = 235,
                Height = 92
            };
            MageChooseButt.Size = MageChooseSize;
            MageChooseButt.ForeColor = Color.Black;
            MageChooseButt.BackColor = ColorTranslator.FromHtml("#5d7fa2");
            MageChooseButt.Click += new EventHandler(MageChooseButt_Click);
            this.Controls.Add(MageChooseButt);

        }
        private void MageChooseButt_Click(object sender, EventArgs e)
        {
            AddMage();
        }


        //Warrior
        
            //Choose
            
        private void WarriorChooseButt_Create()
        {
            Point WarriorChoosePoint = new Point
            {
                X = 665,
                Y = 407
            };
            WarriorChooseButt.Location = WarriorChoosePoint;

            WarriorChooseButt.Text = "Warrior";
            Font WarriorChooseFont = new Font("Segoe UI", 36);
            WarriorChooseButt.Font = WarriorChooseFont;

            Size WarriorChooseSize = new Size
            {
                Width = 235,
                Height = 92
            };
            WarriorChooseButt.Size = WarriorChooseSize;
            WarriorChooseButt.BackColor = ColorTranslator.FromHtml("#5d7fa2");
            WarriorChooseButt.ForeColor = Color.Black;

            WarriorChooseButt.Click += new EventHandler(WarriorChooseButt_Click);
            this.Controls.Add(WarriorChooseButt);

        }
        private void WarriorChooseButt_Click(Object sender, EventArgs e)
        {
            AddWarrior();
            //PlayerOneCharacters.Location = new Point(100,100);
            //PlayerOneCharacters.Size = new Size(750, 500);
            //PlayerOneCharacters.Show();
            //this.Controls.Add(PlayerOneCharacters);
        }
        
        //Create_User
        
        private void AddWarrior()
        {
            //PlayerCharactersTable.Rows.Add("Warrior", 1, 125, 10, 10, Properties.Resources.Warrior, 1,1 ,1);
            //ComputerCharactersTable.Rows.Add("Mage", 1, 100, 15, 10);
            TitleLab.Text = "Not a thing yet";

        }
        private void AddMage()
        {
            PlayerCharactersTable.Rows.Add("Mage", 1, 100, 15, 10, Properties.Resources.Mage, 1, 1,1 );
            ComputerCharactersTable.Rows.Add("Mage", 1, 100, 15, 10);
            RoundsOneFour();
        }

        //Round 1-4
        private void RoundsOneFour()
        {
            MageChooseButt.Hide();
            WarriorChooseButt.Hide();
            ChooseMageHealth.Hide();
            ChooseMageInteligence.Hide();
            ChooseMageLevel.Hide();
            ChooseMageMana.Hide();
            ChooseWarriorHealth.Hide();
            ChooseWarriorLevel.Hide();
            ChooseWarriorMana.Hide();
            ChooseWarriorStrength.Hide();
            MagePicture.Hide();
            WarriorPicture.Hide();
            TitleLab.Hide();




            RoundLable.Text = $"Round: {RoundCount}";
            RoundLable.Location = new Point(200, 200);
            RoundLable.BackColor = Color.Transparent;
            RoundLable.Location = new Point { X = 406, Y = 12 };
            RoundLable.Font = new Font("Segoe UI", 36);
            RoundLable.AutoSize = true;
            this.Controls.Add(RoundLable);
            RoundLable.Show();


            if (RoundCount == 1)
            {
                //Player

                Font ActionsFont = new Font("Segoe UI", 22);

                    //Heal

                PlayerHeal.Text = "Heal";
                PlayerHeal.Font = ActionsFont;
                PlayerHeal.Size = new Size(144, 47);
                PlayerHeal.Location = new Point(24, 127);
                PlayerHeal.BackColor = Color.White;
                PlayerHeal.Click += new EventHandler(Heal_Click);
                this.Controls.Add(PlayerHeal);
                PlayerHeal.Show();


                    //Hit

                PlayerHit.Text = "Hit";
                PlayerHit.Font = ActionsFont;
                PlayerHit.Size = PlayerHeal.Size;
                PlayerHit.Location = new Point(24,180);
                PlayerHit.BackColor = Color.White;
                this.Controls.Add(PlayerHit);
                PlayerHit.Show();
                PlayerHit.Click += new EventHandler(Hit_Click);

                    //Health

                        //Bar

                PlayerHealthOne.Image = Properties.Resources.Ten;
                PlayerHealthOne.Size = new Size(180, 20);
                PlayerHealthOne.Location = new Point(205, 381);
                this.Controls.Add(PlayerHealthOne);
                PlayerHealthOne.Show();

                //Number

                int HealthLvlIndex = int.Parse(PlayerCharactersTable.Rows[0].ItemArray[6].ToString());

                if (PlayerCharactersTable.Rows[0].ItemArray[0].ToString() == "Mage")
                {
                    PlayerHealthOneLab.Text = MageLevelsTable.Rows[HealthLvlIndex-1].ItemArray[1].ToString();

                }
                else
                {
                    PlayerHealthOneLab.Text = WarriorLevelsTable.Rows[HealthLvlIndex - 1].ItemArray[1].ToString();
                }


                PlayerHealthOneLab.BackColor = Color.Transparent;
                PlayerHealthOneLab.Location = new Point(174, 381);
                PlayerHealthOneLab.Size = new Size(25,20);
                this.Controls.Add(PlayerHealthOneLab);
                PlayerHealthOneLab.Show();

                //Picture

                if (PlayerCharactersTable.Rows[0].ItemArray[0].ToString() == "Mage") {
                    PlayerCharacterOne.Image = Properties.Resources.Mage;
                }
                else
                {
                    PlayerCharacterOne.Image = Properties.Resources.Warrior;
                }
                PlayerCharacterOne.Size = new Size(211, 240);
                PlayerCharacterOne.Location = new Point(174, 127);
                PlayerCharacterOne.BackColor = Color.Transparent;
                this.Controls.Add(PlayerCharacterOne);
                PlayerCharacterOne.Show();

                //Mana
                PlayerManaText.Text = $"Mana: {PlayerCharactersTable.Rows[0].ItemArray[3]}";
                PlayerManaText.AutoSize = true;
                PlayerManaText.Font = new Font("Segoe UI", 26);
                PlayerManaText.Location = new Point(174, 404);
                PlayerManaText.BackColor = Color.Transparent;
                this.Controls.Add(PlayerManaText);
                PlayerManaText.Show();

                //DamageSelf
                DemageSelf.Text = "Demage Self";
                DemageSelf.Location = new Point(12, 452);
                DemageSelf.BackColor = Color.White;
                DemageSelf.Size = new Size(142, 47);
                DemageSelf.Font = new Font("Segoe UI", 14);
                this.Controls.Add(DemageSelf);
                DemageSelf.Click += new EventHandler(DemageSelf_Click);
                DemageSelf.Show();
                Hover = new ToolTip();
                Hover.SetToolTip(DemageSelf, "Set own and computer Health to 1 and reset turns");

                //Computer
                //Mana
                ComputerManaText.Text = $"Mana: {MageLevelsTable.Rows[RoundCount-1].ItemArray[2]}";
                ComputerManaText.AutoSize = true;
                ComputerManaText.Font = new Font("Segoe UI", 26);
                ComputerManaText.Location = new Point(665, 404);
                ComputerManaText.BackColor = Color.Transparent;
                this.Controls.Add(ComputerManaText);
                ComputerManaText.Show();
                

                //Picture
                
                ComputerCharacterOne.Image = Properties.Resources.Mage;
                ComputerCharacterOne.Size = new Size(211, 240);
                ComputerCharacterOne.Location = new Point(665, 127);
                ComputerCharacterOne.BackColor = Color.Transparent;
                this.Controls.Add(ComputerCharacterOne);
                ComputerCharacterOne.Show();

                    //Health

                    //Bar

                ComputerHealthOne.Image = Properties.Resources.Ten;
                ComputerHealthOne.Size = new Size(180, 20);
                ComputerHealthOne.Location = new Point(696, 381);
                this.Controls.Add(ComputerHealthOne);
                ComputerHealthOne.Show();

                //Number



                ComputerHealthOneLab.Text = ComputerCharactersTable.Rows[RoundCount - 1].ItemArray[2].ToString();

                ComputerHealthOneLab.BackColor = Color.Transparent;
                ComputerHealthOneLab.Location = new Point(665, 381);
                ComputerHealthOneLab.Size = new Size(25, 20);
                this.Controls.Add(ComputerHealthOneLab);
                ComputerHealthOneLab.Show();


                //Next
                Next.Text = "Next";
                Next.Font = new Font("Segoe UI", 22);
                Next.BackColor = Color.White;
                Next.Location = new Point(850, 452);
                Next.Size = new Size(142, 47);
                Next.Click += new EventHandler(Next_Click);
                this.Controls.Add(Next);
                Next.Show();

                //FinishTurn
                FinishTurn.Text = "Finish Turn";
                FinishTurn.Font = new Font("Segoe UI", 18);
                FinishTurn.BackColor = Color.White;
                FinishTurn.Location = new Point(850, 452);
                FinishTurn.Size = new Size(142, 47);
                FinishTurn.Click += new EventHandler(FinishTurn_Click);
                this.Controls.Add(FinishTurn);
                









            }
            else if(RoundCount > 5)
            {



            }











        }


        //You won
        private void PlayerWon()
        {
            ExitButt.Size = new Size(381, 115);
            ExitButt.Location = new Point(308, 305);
            ExitButt.Font = new Font("Segoe UI", 36);
            TitleLab.Text = "You Won";
            SubTitle.Text = "Cant be bothered making more rounds yet";
            SubTitle.Location = new Point(308, 176);
            SubTitle.Size = new Size(381, 72);
            SubTitle.Font = new Font("Segue UI", 11);
            SubTitle.Show();
            TitleLab.Show();
            RoundLable.Hide();
            PlayerHeal.Hide();
            PlayerHit.Hide();
            PlayerHealthOne.Hide(); 
            PlayerHealthOneLab.Hide();
            PlayerCharacterOne.Hide();
            PlayerManaText.Hide();
            DemageSelf.Hide();
            Next.Hide(); 
            ComputerHealthOneLab.Hide();
            ComputerHealthOne.Hide();
            ComputerCharacterOne.Hide();
            ComputerManaText.Hide();
            FinishTurn.Hide();

        }

        private void ComputerWon()
        {
            ExitButt.Size = new Size(381, 115);
            ExitButt.Location = new Point(308, 305);
            ExitButt.Font = new Font("Segoe UI", 36);
            TitleLab.Text = "You Lost";
            SubTitle.Text = "Cant be bothered making more rounds yet";
            SubTitle.Location = new Point(308, 176);
            SubTitle.Size = new Size(381, 72);
            SubTitle.Font = new Font("Segue UI", 11);
            SubTitle.Show();
            TitleLab.Show();
            RoundLable.Hide();
            PlayerHeal.Hide();
            PlayerHit.Hide();
            PlayerHealthOne.Hide();
            PlayerHealthOneLab.Hide();
            PlayerCharacterOne.Hide();
            PlayerManaText.Hide();
            DemageSelf.Hide();
            Next.Hide();
            ComputerHealthOneLab.Hide();
            ComputerHealthOne.Hide();
            ComputerCharacterOne.Hide();
            ComputerManaText.Hide();
            FinishTurn.Hide();
        }


        //ActionButtons
        private void Heal_Click(object sender, EventArgs e)
        {
            int mana = int.Parse(PlayerCharactersTable.Rows[0]["Mana"].ToString());
            if (mana >= 4)
            {
                double playerCurrentHealth = int.Parse(PlayerCharactersTable.Rows[0].ItemArray[2].ToString());
                double playerFullHealth = 0;
                if (PlayerCharactersTable.Rows[0]["Type"] == "Mage")
                {
                    playerFullHealth = int.Parse(MageLevelsTable.Rows[int.Parse(PlayerCharactersTable.Rows[0].ItemArray[6].ToString()) - 1].ItemArray[1].ToString());
                }
                else if (PlayerCharactersTable.Rows[0]["Type"] == "Warrior")
                {
                    playerFullHealth = int.Parse(WarriorLevelsTable.Rows[int.Parse(PlayerCharactersTable.Rows[0].ItemArray[6].ToString()) - 1].ItemArray[1].ToString());
                }
                double playerHealMargin = playerFullHealth - (playerFullHealth / 10);
                if (PlayerActionsLeft != 0 && playerCurrentHealth <= playerHealMargin)
                {
                    double healAmount = (playerFullHealth / 10) * int.Parse(PlayerCharactersTable.Rows[0].ItemArray[8].ToString());
                    double newHealth = playerCurrentHealth + healAmount;
                    PlayerCharactersTable.Rows[0]["Health"] = newHealth;
                    PlayerHealthOneLab.Text = newHealth.ToString();
                    PlayerActionsLeft = 0;
                int newManaPerson = int.Parse(PlayerCharactersTable.Rows[0]["Mana"].ToString()) - 4;
                if (newManaPerson < 0)
                {
                    newManaPerson = 0;
                }
                PlayerCharactersTable.Rows[0]["Mana"] = newManaPerson;
                PlayerManaText.Text = "Mana: " + newManaPerson;
                }
            }

        }
        private void Hit_Click(object sender, EventArgs e)
        {
            int mana = int.Parse(ComputerCharactersTable.Rows[0]["Mana"].ToString());
            if (mana >= 3)
            {
                if (PlayerActionsLeft != 0)
                {
                    int Special = int.Parse(PlayerCharactersTable.Rows[0].ItemArray[4].ToString());
                    int Level = 1;
                    int baseDamagePerLevel = 15;
                    double SpecialMultiplier = 1.75;
                    int baseDamage = (int)(baseDamagePerLevel * Level);
                    int physicalDamage = (int)(Special * SpecialMultiplier);
                    int totalDamage = baseDamage + physicalDamage;

                    int currentHealth = int.Parse(ComputerCharactersTable.Rows[0]["Health"].ToString()) - totalDamage;
                    ComputerCharactersTable.Rows[0]["Health"] = currentHealth;
                    if (PlayerCharactersTable.Rows[0]["Type"] == "Mage")
                    {
                        PlayerCharacterOne.Image = Properties.Resources.Attack_Mage;
                        imgTimer = new System.Windows.Forms.Timer();
                        imgTimer.Interval = 500;
                        imgTimer.Start();
                        imgTimer.Tick += new EventHandler(OnTimerTick);
                    }
                    int newManaPerson = int.Parse(PlayerCharactersTable.Rows[0]["Mana"].ToString()) - 3;
                    if (newManaPerson < 0)
                    {
                        newManaPerson = 0;
                    }
                    PlayerCharactersTable.Rows[0]["Mana"] = newManaPerson;
                    PlayerManaText.Text = "Mana: " + newManaPerson;

                    ComputerUpdateHealthAttacked();
                }
            }

        }
        private void DemageSelf_Click(object sende, EventArgs e)
        {
            PlayerCharactersTable.Rows[0]["Health"] = 1;
                int ShowHealth = int.Parse(PlayerCharactersTable.Rows[0].ItemArray[2].ToString());
            PlayerHealthOneLab.Text = ShowHealth.ToString();
            PlayerActionsLeft = 1 ;
            ComputerCharactersTable.Rows[0]["Health"] = 1;
            ShowHealth = int.Parse(ComputerCharactersTable.Rows[0].ItemArray[2].ToString());
            ComputerHealthOneLab.Text = ShowHealth.ToString();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            bool anyAlive = false;
            foreach(DataRow row in ComputerCharactersTable.Rows)
            {
                int health = int.Parse(row["Health"].ToString());
                if(health > 0)
                {
                    anyAlive = true;
                }
            }

            if(anyAlive)
            {
                //RoundLable.Text = "AliveRobots";
            Next.Hide();
            FinishTurn.Show();
                ComputerAcction();
            }
            else
            {
                PlayerWon();
            }
        }

        private void FinishTurn_Click(object sender, EventArgs e)
        {
            
                bool anyAlive = false;
                foreach (DataRow row in PlayerCharactersTable.Rows)
                {
                    int health = int.Parse(row["Health"].ToString());
                    if (health > 0)
                    {
                        anyAlive = true;
                    }
                }

                if (anyAlive)
                {
                    //RoundLable.Text = "AlivePlayers";
                    int newManaPerson = int.Parse(PlayerCharactersTable.Rows[0]["Mana"].ToString()) + 2;
                    PlayerCharactersTable.Rows[0]["Mana"] = newManaPerson;

                    int newManaComputer = int.Parse(ComputerCharactersTable.Rows[0]["Mana"].ToString()) + 2;
                    ComputerCharactersTable.Rows[0]["Mana"] = newManaComputer;
                    ComputerManaText.Text = "Mana: " + newManaComputer.ToString();
                    PlayerManaText.Text = "Mana: " + newManaPerson.ToString();

                    ComputerActionsLeft = 1;
                    PlayerActionsLeft = 1;

                

                }
                else
                {
                    ComputerWon();
                }
            if (ComputerActionsLeft != 0)
            {
                Next.Show();
                FinishTurn.Hide();
            }




        }

        //ComputerActions

        private void ComputerUseHit()
        {
            int mana = int.Parse(ComputerCharactersTable.Rows[0]["Mana"].ToString());
            if (mana >= 3)
            {
                if (ComputerActionsLeft != 0)
                {
                    int Special = int.Parse(ComputerCharactersTable.Rows[0].ItemArray[4].ToString());
                    int Level = 1;
                    int baseDamagePerLevel = 15;
                    double SpecialMultiplier = 1.75;
                    int baseDamage = (int)(baseDamagePerLevel * Level);
                    int physicalDamage = (int)(Special * SpecialMultiplier);
                    int totalDamage = baseDamage + physicalDamage;

                    int currentHealth = int.Parse(PlayerCharactersTable.Rows[0]["Health"].ToString()) - totalDamage;
                    PlayerCharactersTable.Rows[0]["Health"] = currentHealth;
                    if (ComputerCharactersTable.Rows[0]["Type"] == "Mage")
                    {
                        ComputerCharacterOne.Image = Properties.Resources.Attack_Mage;
                        imgTimer = new System.Windows.Forms.Timer();
                        imgTimer.Interval = 500;
                        imgTimer.Start();
                        imgTimer.Tick += new EventHandler(OnTimerTick);
                    }
                    int newManaComputer = int.Parse(ComputerCharactersTable.Rows[0]["Mana"].ToString()) - 3;
                    if (newManaComputer < 0)
                    {
                        newManaComputer = 0;
                    }
                    ComputerCharactersTable.Rows[0]["Mana"] = newManaComputer;
                    ComputerManaText.Text = "Mana: " + newManaComputer;



                    PlayerUpdateHealthAttacked();
                }
            }
        }
        private void ComputerUseHeal()
        {
            int mana = int.Parse(ComputerCharactersTable.Rows[0]["Mana"].ToString());
            if (mana >= 4) {
                double computerCurrentHealth = int.Parse(ComputerCharactersTable.Rows[0].ItemArray[2].ToString());
                double computerFullHealth = int.Parse(MageLevelsTable.Rows[RoundCount].ItemArray[1].ToString());
                double computerHealMargin = computerFullHealth - (computerFullHealth / 10);
                if (ComputerActionsLeft != 0 && computerCurrentHealth <= computerHealMargin)
                {
                    double healAmount = (computerFullHealth / 10) * int.Parse(ComputerCharactersTable.Rows[0].ItemArray[RoundCount].ToString());
                    double newHealth = computerCurrentHealth + healAmount;
                    ComputerCharactersTable.Rows[0]["Health"] = newHealth;
                    ComputerHealthOneLab.Text = ComputerCharactersTable.Rows[0].ItemArray[2].ToString();
                    ComputerActionsLeft = 0;
                }
                int newManaComputer = int.Parse(ComputerCharactersTable.Rows[0]["Mana"].ToString()) - 4;
                if (newManaComputer < 0)
                {
                    newManaComputer = 0;
                }
                ComputerCharactersTable.Rows[0]["Mana"] = newManaComputer;
                ComputerManaText.Text = "Mana: " + newManaComputer;
            }
        }


        //UpdateHealthIcon
        private void ComputerUpdateHealthAttacked()
        {

            if (PlayerActionsLeft != 0)
            {
                double currentHealth = int.Parse(ComputerCharactersTable.Rows[0]["Health"].ToString());
                

                if (currentHealth < 0)
                {
                    currentHealth = 0;
                }

                ComputerHealthOneLab.Text = currentHealth.ToString();
                ComputerHealthOneLab.Show();
                PlayerActionsLeft = 0;
            }
            
        }
        private void PlayerUpdateHealthAttacked()
        {

            if (ComputerActionsLeft != 0)
            {
                double currentHealth = int.Parse(PlayerCharactersTable.Rows[0]["Health"].ToString());
                /*double fullHealth = int.Parse(ComputerCharactersTable.Rows[0]["Health"].ToString());
                double tenth = fullHealth / 10;

                double ninety = fullHealth - (1 * tenth);
                double eighty = fullHealth - (2 * tenth);
                double seventy = fullHealth - (3 * tenth);
                double sixty = fullHealth - (4 * tenth);
                double fifty = fullHealth - (5 * tenth);
                double fourty = fullHealth - (6 * tenth);
                double thirty = fullHealth - (7 * tenth);
                double twenty = fullHealth - (8 * tenth);
                double ten = fullHealth - (9 * tenth);
                double zero = 0;


                    if (currentHealth > ninety)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Ten;
                    }
                     else if (currentHealth < ninety && currentHealth > eighty)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Nine;
                    }
                     else if (currentHealth < eighty && currentHealth > seventy)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Eight;
                    }
                    else if (currentHealth < seventy && currentHealth > sixty)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Seven;
                    }
                    else if (currentHealth < sixty && currentHealth > fifty)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Siz;
                    }
                     else if (currentHealth < fifty && currentHealth > fourty)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Five;
                    }
                     else if (currentHealth < fourty && currentHealth > thirty)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Four;
                    }
                    else  if (currentHealth < thirty && currentHealth > twenty)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Three;
                    }
                    else  if (currentHealth < twenty && currentHealth > ten)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Two;
                    }
                    else  if (currentHealth < ten && currentHealth > zero)
                    {
                        ComputerHealthOne.Image = Properties.Resources.One;
                    }
                    else if (currentHealth == 0)
                    {
                        ComputerHealthOne.Image = Properties.Resources.Zero;
                    }*/

                if (currentHealth < 0)
                {
                    currentHealth = 0;
                }

                PlayerHealthOneLab.Text = currentHealth.ToString();
                ComputerActionsLeft = 0;
            }

        }

        //Timers
        private void OnTimerTick(object sender, EventArgs e)
        {
            PlayerCharacterOne.Image = Properties.Resources.Mage;
            ComputerCharacterOne.Image = Properties.Resources.Mage;
            imgTimer.Stop();
        }




        //BotAction
        private void ComputerAcction()
        {
            if (ComputerActionsLeft != 0)
            {
                Random r = new Random();
                int ComputerChoiceChance = r.Next(100);
                int ComputerHealth = int.Parse(ComputerCharactersTable.Rows[0]["Health"].ToString());
                int FullHealth = int.Parse(MageLevelsTable.Rows[RoundCount]["Health"].ToString());
                int HalfHealth = FullHealth - (FullHealth / 2);
                int AlmostFullHealth = FullHealth - (FullHealth / 10);
                if (ComputerHealth <= HalfHealth)
                {
                    if (ComputerChoiceChance <= 60)
                    {
                        ComputerUseHeal();
                    }
                    else
                    {
                        ComputerUseHit();
                    }
                } else if (ComputerHealth > HalfHealth && ComputerHealth <= AlmostFullHealth)
                {
                    if(ComputerChoiceChance <= 60)
                    {
                        ComputerUseHit();
                    }
                    else
                    {
                        ComputerUseHeal();
                    }



                } else if (ComputerHealth > AlmostFullHealth)
                {
                    ComputerUseHit();
                }




            }
        }

        private void StartButt_Click(object sender, EventArgs e)
        {
            //TitleLab.Hide();
            //SubTitle.Hide();
            StartButt.Hide();

            CreatePvPButton();
            CreatePvCButton();
        }
        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
