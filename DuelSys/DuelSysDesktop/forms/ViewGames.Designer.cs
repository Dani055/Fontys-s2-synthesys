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
            this.lvTournaments = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colPlayerId1 = new System.Windows.Forms.ColumnHeader();
            this.colPlayerId2 = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.colTourneyId = new System.Windows.Forms.ColumnHeader();
            this.colPlayer1Points = new System.Windows.Forms.ColumnHeader();
            this.colPlayer2Points = new System.Windows.Forms.ColumnHeader();
            this.colWinnerId = new System.Windows.Forms.ColumnHeader();
            this.btnEditGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTournaments
            // 
            this.lvTournaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colPlayerId1,
            this.colPlayerId2,
            this.colDate,
            this.colTourneyId,
            this.colPlayer1Points,
            this.colPlayer2Points,
            this.colWinnerId});
            this.lvTournaments.GridLines = true;
            this.lvTournaments.Location = new System.Drawing.Point(12, 12);
            this.lvTournaments.Name = "lvTournaments";
            this.lvTournaments.Size = new System.Drawing.Size(787, 411);
            this.lvTournaments.TabIndex = 8;
            this.lvTournaments.UseCompatibleStateImageBehavior = false;
            this.lvTournaments.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 50;
            // 
            // colPlayerId1
            // 
            this.colPlayerId1.Text = "Player 1 ID";
            this.colPlayerId1.Width = 90;
            // 
            // colPlayerId2
            // 
            this.colPlayerId2.Text = "Player 2 ID";
            this.colPlayerId2.Width = 90;
            // 
            // colDate
            // 
            this.colDate.Text = "Date held";
            this.colDate.Width = 150;
            // 
            // colTourneyId
            // 
            this.colTourneyId.Text = "Tournament ID";
            this.colTourneyId.Width = 120;
            // 
            // colPlayer1Points
            // 
            this.colPlayer1Points.Text = "Points - P1";
            this.colPlayer1Points.Width = 100;
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
            this.btnEditGame.Location = new System.Drawing.Point(0, 443);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(813, 49);
            this.btnEditGame.TabIndex = 23;
            this.btnEditGame.Text = "Enter result";
            this.btnEditGame.UseVisualStyleBackColor = false;
            this.btnEditGame.Click += new System.EventHandler(this.btnEditGame_Click);
            // 
            // ViewGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 492);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.lvTournaments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewGames";
            this.Text = "View Games";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvTournaments;
        private ColumnHeader colId;
        private ColumnHeader colPlayerId1;
        private ColumnHeader colPlayerId2;
        private ColumnHeader colDate;
        private ColumnHeader colTourneyId;
        private ColumnHeader colPlayer1Points;
        private ColumnHeader colPlayer2Points;
        private ColumnHeader colWinnerId;
        private Button btnEditGame;
    }
}