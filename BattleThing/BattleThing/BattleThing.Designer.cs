using BattleThing.Properties;
using System.Windows.Forms;

namespace BattleThing
{
    partial class BattleThing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PvCButt = new Button();
            PvPButt = new Button();
            TitleLab = new Label();
            StartButt = new Button();
            ExitButt = new Button();
            FinishTurn = new Button();
            SubTitle = new Label();
            MageChooseButt = new Button();
            WarriorChooseButt = new Button();
            PlayerOneCharacters = new DataGridView();
            PlayerTwoCharacters = new DataGridView();
            ComputerCharacters = new DataGridView();
            PlayerCharacters = new DataGridView();
            PlayerCharacterTwo = new PictureBox();
            PlayerCharacterOne = new PictureBox();
            ComputerCharacterOne = new PictureBox();
            ComputerCharacterTwo = new PictureBox();
            PlayerHeal = new Button();
            PlayerHit = new Button();
            PlayerFire = new Button();
            ComputerHeal = new Button();
            ComputerHit = new Button();
            MagePicture = new PictureBox();
            WarriorPicture = new PictureBox();
            ComputerFire = new Button();
            ChooseWarriorHealth = new Label();
            ChooseWarriorMana = new Label();
            ChooseWarriorLevel = new Label();
            ChooseWarriorStrength = new Label();
            ChooseMageHealth = new Label();
            ChooseMageMana = new Label();
            ChooseMageLevel = new Label();
            ChooseMageInteligence = new Label();
            RoundLable = new Label();
            RoundCount = 1;
            PlayerActionsLeft = 1;
            ComputerActionsLeft = 1;
            PlayerHealthOne = new PictureBox();
            PlayerHealthTwo = new PictureBox();
            ComputerHealthOne = new PictureBox();
            ComputerHealthTwo = new PictureBox();
            PlayerHealthOneLab = new Label();
            PlayerHealthTwoLab = new Label();
            ComputerHealthTwoLab = new Label();
            ComputerHealthOneLab = new Label();
            PlayerManaText = new Label();
            ComputerManaText = new Label();
            DemageSelf = new Button();
            Next = new Button();
            SuspendLayout();
            // 
            // TitleLab
            // 
            TitleLab.BackColor = Color.Transparent;
            TitleLab.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLab.ForeColor = SystemColors.ButtonFace;
            TitleLab.Location = new Point(35, 30);
            TitleLab.Name = "TitleLab";
            TitleLab.Size = new Size(940, 200);
            TitleLab.TabIndex = 0;
            TitleLab.Text = "Battle Thingy";
            TitleLab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartButt
            // 
            StartButt.BackColor = Color.Transparent;
            StartButt.BackgroundImageLayout = ImageLayout.None;
            StartButt.FlatAppearance.BorderSize = 10;
            StartButt.FlatStyle = FlatStyle.Popup;
            StartButt.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            StartButt.Location = new Point(335, 300);
            StartButt.Name = "StartButt";
            StartButt.Size = new Size(350, 120);
            StartButt.TabIndex = 1;
            StartButt.Text = "Start";
            StartButt.UseVisualStyleBackColor = false;
            StartButt.Click += StartButt_Click;
            // 
            // ExitButt
            // 
            ExitButt.BackColor = Color.Red;
            ExitButt.BackgroundImageLayout = ImageLayout.None;
            ExitButt.FlatStyle = FlatStyle.Popup;
            ExitButt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButt.ForeColor = SystemColors.ControlLight;
            ExitButt.Location = new Point(879, 12);
            ExitButt.Name = "ExitButt";
            ExitButt.Size = new Size(113, 39);
            ExitButt.TabIndex = 2;
            ExitButt.Text = "Exit";
            ExitButt.UseVisualStyleBackColor = false;
            ExitButt.Click += ExitButt_Click;
            // 
            // SubTitle
            // 
            SubTitle.BackColor = Color.Transparent;
            SubTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            SubTitle.ForeColor = SystemColors.Control;
            SubTitle.Location = new Point(350, 185);
            SubTitle.Name = "SubTitle";
            SubTitle.Size = new Size(310, 45);
            SubTitle.TabIndex = 3;
            SubTitle.Text = "Mages and Warriors";
            SubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BattleThing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Resources.Webp_net_resizeimage;
            ClientSize = new Size(1004, 511);
            Controls.Add(SubTitle);
            Controls.Add(ExitButt);
            Controls.Add(StartButt);
            Controls.Add(TitleLab);
            Name = "BattleThing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BattleThing";
            ResumeLayout(false);
        }

        #endregion


        //Common
        private Label TitleLab;
        private Button StartButt;
        private Button ExitButt;
        private Label SubTitle;
        private Button PvCButt;
        private Button PvPButt;
        private Button MageChooseButt;
        private Button WarriorChooseButt;
        private Label RoundLable;
        private int RoundCount;
        private PictureBox MagePicture;
        private PictureBox WarriorPicture;


        private Label ChooseWarriorHealth;
        private Label ChooseWarriorMana;
        private Label ChooseWarriorLevel;
        private Label ChooseWarriorStrength;

        private Label ChooseMageHealth;
        private Label ChooseMageMana;
        private Label ChooseMageLevel;
        private Label ChooseMageInteligence;
        //PvP
        private DataGridView PlayerOneCharacters;
        private DataGridView PlayerTwoCharacters;
        private PictureBox PlayerOneCharacter;
        private PictureBox PlayerTwoCharacter;

        //PvC
        private DataGridView ComputerCharacters;
        private DataGridView PlayerCharacters;
        private PictureBox PlayerCharacterTwo;
        private PictureBox PlayerCharacterOne;
        private PictureBox ComputerCharacterOne;
        private PictureBox ComputerCharacterTwo;
        private Button PlayerHeal;
        private Button PlayerHit;
        private Button PlayerFire;
        private Button ComputerHeal;
        private Button ComputerHit;
        private Button ComputerFire;
        private PictureBox PlayerHealthOne;
        private PictureBox PlayerHealthTwo;
        private PictureBox ComputerHealthOne;
        private PictureBox ComputerHealthTwo;
        private Label PlayerHealthOneLab;
        private Label PlayerHealthTwoLab;
        private Label ComputerHealthOneLab;
        private Label ComputerHealthTwoLab;
        private Label PlayerManaText;
        private Label ComputerManaText;
        private int PlayerActionsLeft;
        private int ComputerActionsLeft;
        private Button DemageSelf;
        private Button Next;
        private Button FinishTurn;
    }
}