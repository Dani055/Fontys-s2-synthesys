namespace DuelSysDesktop.forms
{
    partial class EditGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGame));
            this.btxP2pts = new System.Windows.Forms.NumericUpDown();
            this.tbxP1pts = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPlayers = new System.Windows.Forms.Label();
            this.lblPlayer1Pts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnEditGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btxP2pts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxP1pts)).BeginInit();
            this.SuspendLayout();
            // 
            // btxP2pts
            // 
            this.btxP2pts.BackColor = System.Drawing.Color.Gainsboro;
            this.btxP2pts.Location = new System.Drawing.Point(250, 200);
            this.btxP2pts.Name = "btxP2pts";
            this.btxP2pts.Size = new System.Drawing.Size(85, 27);
            this.btxP2pts.TabIndex = 96;
            // 
            // tbxP1pts
            // 
            this.tbxP1pts.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxP1pts.Location = new System.Drawing.Point(52, 200);
            this.tbxP1pts.Name = "tbxP1pts";
            this.tbxP1pts.Size = new System.Drawing.Size(84, 27);
            this.tbxP1pts.TabIndex = 95;
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.ForeColor = System.Drawing.Color.Black;
            this.lblMaxPlayers.Location = new System.Drawing.Point(250, 174);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(85, 20);
            this.lblMaxPlayers.TabIndex = 91;
            this.lblMaxPlayers.Text = "Player 2 pts";
            // 
            // lblPlayer1Pts
            // 
            this.lblPlayer1Pts.AutoSize = true;
            this.lblPlayer1Pts.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer1Pts.Location = new System.Drawing.Point(51, 172);
            this.lblPlayer1Pts.Name = "lblPlayer1Pts";
            this.lblPlayer1Pts.Size = new System.Drawing.Size(85, 20);
            this.lblPlayer1Pts.TabIndex = 90;
            this.lblPlayer1Pts.Text = "Player 1 pts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(123, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(321, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 93;
            this.label4.Text = "*";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPlayer2.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer2.Location = new System.Drawing.Point(250, 84);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Padding = new System.Windows.Forms.Padding(5);
            this.lblPlayer2.Size = new System.Drawing.Size(71, 30);
            this.lblPlayer2.TabIndex = 98;
            this.lblPlayer2.Text = "Player 2";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPlayer1.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer1.Location = new System.Drawing.Point(51, 84);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Padding = new System.Windows.Forms.Padding(5);
            this.lblPlayer1.Size = new System.Drawing.Size(71, 30);
            this.lblPlayer1.TabIndex = 99;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.ForeColor = System.Drawing.Color.Black;
            this.lblP2Name.Location = new System.Drawing.Point(251, 127);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(70, 20);
            this.lblP2Name.TabIndex = 100;
            this.lblP2Name.Text = "Unknown";
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.ForeColor = System.Drawing.Color.Black;
            this.lblP1Name.Location = new System.Drawing.Point(52, 127);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(70, 20);
            this.lblP1Name.TabIndex = 101;
            this.lblP1Name.Text = "Unknown";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(166, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(5);
            this.lblDate.Size = new System.Drawing.Size(51, 30);
            this.lblDate.TabIndex = 102;
            this.lblDate.Text = "Date";
            // 
            // btnEditGame
            // 
            this.btnEditGame.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditGame.FlatAppearance.BorderSize = 0;
            this.btnEditGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGame.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditGame.Location = new System.Drawing.Point(0, 279);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(374, 49);
            this.btnEditGame.TabIndex = 103;
            this.btnEditGame.Text = "Enter result";
            this.btnEditGame.UseVisualStyleBackColor = false;
            // 
            // EditGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 328);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblP1Name);
            this.Controls.Add(this.lblP2Name);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.btxP2pts);
            this.Controls.Add(this.tbxP1pts);
            this.Controls.Add(this.lblMaxPlayers);
            this.Controls.Add(this.lblPlayer1Pts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditGame";
            this.Text = "EditGame";
            ((System.ComponentModel.ISupportInitialize)(this.btxP2pts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxP1pts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown btxP2pts;
        private NumericUpDown tbxP1pts;
        private Label lblMaxPlayers;
        private Label lblPlayer1Pts;
        private Label label3;
        private Label label4;
        private Label lblPlayer2;
        private Label lblPlayer1;
        private Label lblP2Name;
        private Label lblP1Name;
        private Label lblDate;
        private Button btnEditGame;
    }
}