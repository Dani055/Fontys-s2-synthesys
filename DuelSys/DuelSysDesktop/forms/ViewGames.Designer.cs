namespace DuelSysDesktop.forms
{
    partial class ViewGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGames));
            this.lvMatches = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colTourneyId = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.colPlayerId1 = new System.Windows.Forms.ColumnHeader();
            this.colPlayer1firstname = new System.Windows.Forms.ColumnHeader();
            this.colPlayer1lastname = new System.Windows.Forms.ColumnHeader();
            this.colPlayer1Points = new System.Windows.Forms.ColumnHeader();
            this.colPlayerId2 = new System.Windows.Forms.ColumnHeader();
            this.colPlayer2firstname = new System.Windows.Forms.ColumnHeader();
            this.colPlayer2lastname = new System.Windows.Forms.ColumnHeader();
            this.colPlayer2Points = new System.Windows.Forms.ColumnHeader();
            this.colWinnerId = new System.Windows.Forms.ColumnHeader();
            this.btnEditGame = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTourneyName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblRegisteredPlayers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvMatches
            // 
            this.lvMatches.BackColor = System.Drawing.Color.Gainsboro;
            this.lvMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTourneyId,
            this.colDate,
            this.colPlayerId1,
            this.colPlayer1firstname,
            this.colPlayer1lastname,
            this.colPlayer1Points,
            this.colPlayerId2,
            this.colPlayer2firstname,
            this.colPlayer2lastname,
            this.colPlayer2Points,
            this.colWinnerId});
            this.lvMatches.FullRowSelect = true;
            this.lvMatches.GridLines = true;
            this.lvMatches.Location = new System.Drawing.Point(12, 12);
            this.lvMatches.MultiSelect = false;
            this.lvMatches.Name = "lvMatches";
            this.lvMatches.Size = new System.Drawing.Size(1265, 411);
            this.lvMatches.TabIndex = 8;
            this.lvMatches.UseCompatibleStateImageBehavior = false;
            this.lvMatches.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 50;
            // 
            // colTourneyId
            // 
            this.colTourneyId.Text = "Tournament ID";
            this.colTourneyId.Width = 120;
            // 
            // colDate
            // 
            this.colDate.Text = "Date held";
            this.colDate.Width = 150;
            // 
            // colPlayerId1
            // 
            this.colPlayerId1.Text = "Player 1 ID";
            this.colPlayerId1.Width = 90;
            // 
            // colPlayer1firstname
            // 
            this.colPlayer1firstname.Text = "P1 First name";
            this.colPlayer1firstname.Width = 120;
            // 
            // colPlayer1lastname
            // 
            this.colPlayer1lastname.Text = "P1 Last name";
            this.colPlayer1lastname.Width = 120;
            // 
            // colPlayer1Points
            // 
            this.colPlayer1Points.Text = "Points - P1";
            this.colPlayer1Points.Width = 100;
            // 
            // colPlayerId2
            // 
            this.colPlayerId2.Text = "Player 2 ID";
            this.colPlayerId2.Width = 90;
            // 
            // colPlayer2firstname
            // 
            this.colPlayer2firstname.Text = "P2 First name";
            this.colPlayer2firstname.Width = 120;
            // 
            // colPlayer2lastname
            // 
            this.colPlayer2lastname.Text = "P2 Last name";
            this.colPlayer2lastname.Width = 120;
            // 
            // colPlayer2Points
            // 
            this.colPlayer2Points.Text = "Points - P2";
            this.colPlayer2Points.Width = 100;
            // 
            // colWinnerId
            // 
            this.colWinnerId.Text = "Winner ID";
            this.colWinnerId.Width = 80;
            // 
            // btnEditGame
            // 
            this.btnEditGame.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditGame.FlatAppearance.BorderSize = 0;
            this.btnEditGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGame.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditGame.Location = new System.Drawing.Point(0, 563);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(1308, 49);
            this.btnEditGame.TabIndex = 23;
            this.btnEditGame.Text = "Enter game result";
            this.btnEditGame.UseVisualStyleBackColor = false;
            this.btnEditGame.Click += new System.EventHandler(this.btnEditGame_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(21, 445);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 20);
            this.lbl1.TabIndex = 27;
            this.lbl1.Text = "Tournament name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "End date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Start date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Registered players";
            // 
            // lblTourneyName
            // 
            this.lblTourneyName.AutoSize = true;
            this.lblTourneyName.Location = new System.Drawing.Point(156, 445);
            this.lblTourneyName.Name = "lblTourneyName";
            this.lblTourneyName.Size = new System.Drawing.Size(50, 20);
            this.lblTourneyName.TabIndex = 31;
            this.lblTourneyName.Text = "label4";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(101, 486);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(50, 20);
            this.lblStartDate.TabIndex = 32;
            this.lblStartDate.Text = "label5";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(101, 525);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(50, 20);
            this.lblEndDate.TabIndex = 33;
            this.lblEndDate.Text = "label6";
            // 
            // lblRegisteredPlayers
            // 
            this.lblRegisteredPlayers.AutoSize = true;
            this.lblRegisteredPlayers.Location = new System.Drawing.Point(542, 445);
            this.lblRegisteredPlayers.Name = "lblRegisteredPlayers";
            this.lblRegisteredPlayers.Size = new System.Drawing.Size(50, 20);
            this.lblRegisteredPlayers.TabIndex = 34;
            this.lblRegisteredPlayers.Text = "label7";
            // 
            // ViewGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 612);
            this.Controls.Add(this.lblRegisteredPlayers);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblTourneyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.lvMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewGames";
            this.Text = "View Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvMatches;
        private ColumnHeader colId;
        private ColumnHeader colPlayerId1;
        private ColumnHeader colPlayerId2;
        private ColumnHeader colDate;
        private ColumnHeader colTourneyId;
        private ColumnHeader colPlayer1Points;
        private ColumnHeader colPlayer2Points;
        private ColumnHeader colWinnerId;
        private Button btnEditGame;
        private Label lbl1;
        private Label label2;
        private Label label3;
        private Label label1;
        private ColumnHeader colPlayer1firstname;
        private ColumnHeader colPlayer1lastname;
        private ColumnHeader colPlayer2firstname;
        private ColumnHeader colPlayer2lastname;
        private Label lblTourneyName;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblRegisteredPlayers;
    }
}