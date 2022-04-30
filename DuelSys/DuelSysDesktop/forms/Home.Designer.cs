namespace DuelSysDesktop.forms
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnLogout = new System.Windows.Forms.Button();
            this.lvTournaments = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colSport = new System.Windows.Forms.ColumnHeader();
            this.colDesc = new System.Windows.Forms.ColumnHeader();
            this.colStartDate = new System.Windows.Forms.ColumnHeader();
            this.colEndDate = new System.Windows.Forms.ColumnHeader();
            this.colHasStarted = new System.Windows.Forms.ColumnHeader();
            this.colMinPlayers = new System.Windows.Forms.ColumnHeader();
            this.colMaxPlayers = new System.Windows.Forms.ColumnHeader();
            this.colLoc = new System.Windows.Forms.ColumnHeader();
            this.colSystem = new System.Windows.Forms.ColumnHeader();
            this.cbxTourneyStatus = new System.Windows.Forms.ComboBox();
            this.btnRegisterStaff = new System.Windows.Forms.Button();
            this.btnCreateTouney = new System.Windows.Forms.Button();
            this.btnEditTourney = new System.Windows.Forms.Button();
            this.btnDelTourney = new System.Windows.Forms.Button();
            this.btnStartTourneys = new System.Windows.Forms.Button();
            this.btnViewTourney = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1152, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lvTournaments
            // 
            this.lvTournaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colSport,
            this.colDesc,
            this.colStartDate,
            this.colEndDate,
            this.colHasStarted,
            this.colMinPlayers,
            this.colMaxPlayers,
            this.colLoc,
            this.colSystem});
            this.lvTournaments.Location = new System.Drawing.Point(12, 12);
            this.lvTournaments.Name = "lvTournaments";
            this.lvTournaments.Size = new System.Drawing.Size(1052, 411);
            this.lvTournaments.TabIndex = 7;
            this.lvTournaments.UseCompatibleStateImageBehavior = false;
            this.lvTournaments.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 50;
            // 
            // colSport
            // 
            this.colSport.Text = "Sport";
            this.colSport.Width = 100;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Description";
            this.colDesc.Width = 150;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Starts";
            this.colStartDate.Width = 120;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "Ends";
            this.colEndDate.Width = 120;
            // 
            // colHasStarted
            // 
            this.colHasStarted.Text = "Status";
            this.colHasStarted.Width = 80;
            // 
            // colMinPlayers
            // 
            this.colMinPlayers.Text = "Min. Players";
            this.colMinPlayers.Width = 100;
            // 
            // colMaxPlayers
            // 
            this.colMaxPlayers.Text = "Max. Players";
            this.colMaxPlayers.Width = 100;
            // 
            // colLoc
            // 
            this.colLoc.Text = "Location";
            this.colLoc.Width = 120;
            // 
            // colSystem
            // 
            this.colSystem.Text = "System";
            this.colSystem.Width = 100;
            // 
            // cbxTourneyStatus
            // 
            this.cbxTourneyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTourneyStatus.FormattingEnabled = true;
            this.cbxTourneyStatus.Items.AddRange(new object[] {
            "Pending",
            "Ongoing",
            "Ended"});
            this.cbxTourneyStatus.Location = new System.Drawing.Point(12, 445);
            this.cbxTourneyStatus.Name = "cbxTourneyStatus";
            this.cbxTourneyStatus.Size = new System.Drawing.Size(151, 28);
            this.cbxTourneyStatus.TabIndex = 8;
            // 
            // btnRegisterStaff
            // 
            this.btnRegisterStaff.Location = new System.Drawing.Point(1085, 71);
            this.btnRegisterStaff.Name = "btnRegisterStaff";
            this.btnRegisterStaff.Size = new System.Drawing.Size(168, 53);
            this.btnRegisterStaff.TabIndex = 9;
            this.btnRegisterStaff.Text = "Register account";
            this.btnRegisterStaff.UseVisualStyleBackColor = true;
            this.btnRegisterStaff.Click += new System.EventHandler(this.btnRegisterStaff_Click);
            // 
            // btnCreateTouney
            // 
            this.btnCreateTouney.Location = new System.Drawing.Point(12, 495);
            this.btnCreateTouney.Name = "btnCreateTouney";
            this.btnCreateTouney.Size = new System.Drawing.Size(130, 53);
            this.btnCreateTouney.TabIndex = 10;
            this.btnCreateTouney.Text = "Create tournament";
            this.btnCreateTouney.UseVisualStyleBackColor = true;
            this.btnCreateTouney.Click += new System.EventHandler(this.btnCreateTouney_Click);
            // 
            // btnEditTourney
            // 
            this.btnEditTourney.Location = new System.Drawing.Point(162, 495);
            this.btnEditTourney.Name = "btnEditTourney";
            this.btnEditTourney.Size = new System.Drawing.Size(130, 53);
            this.btnEditTourney.TabIndex = 11;
            this.btnEditTourney.Text = "Edit tournament";
            this.btnEditTourney.UseVisualStyleBackColor = true;
            this.btnEditTourney.Click += new System.EventHandler(this.btnEditTourney_Click);
            // 
            // btnDelTourney
            // 
            this.btnDelTourney.Location = new System.Drawing.Point(308, 495);
            this.btnDelTourney.Name = "btnDelTourney";
            this.btnDelTourney.Size = new System.Drawing.Size(130, 53);
            this.btnDelTourney.TabIndex = 12;
            this.btnDelTourney.Text = "Delete tournament";
            this.btnDelTourney.UseVisualStyleBackColor = true;
            // 
            // btnStartTourneys
            // 
            this.btnStartTourneys.Location = new System.Drawing.Point(1085, 145);
            this.btnStartTourneys.Name = "btnStartTourneys";
            this.btnStartTourneys.Size = new System.Drawing.Size(168, 76);
            this.btnStartTourneys.TabIndex = 13;
            this.btnStartTourneys.Text = "Start pending tournaments";
            this.btnStartTourneys.UseVisualStyleBackColor = true;
            // 
            // btnViewTourney
            // 
            this.btnViewTourney.Location = new System.Drawing.Point(459, 495);
            this.btnViewTourney.Name = "btnViewTourney";
            this.btnViewTourney.Size = new System.Drawing.Size(130, 53);
            this.btnViewTourney.TabIndex = 14;
            this.btnViewTourney.Text = "View tournament";
            this.btnViewTourney.UseVisualStyleBackColor = true;
            this.btnViewTourney.Click += new System.EventHandler(this.btnViewTourney_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(830, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(1085, 240);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(168, 50);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "00:00:00";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 590);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewTourney);
            this.Controls.Add(this.btnStartTourneys);
            this.Controls.Add(this.btnDelTourney);
            this.Controls.Add(this.btnEditTourney);
            this.Controls.Add(this.btnCreateTouney);
            this.Controls.Add(this.btnRegisterStaff);
            this.Controls.Add(this.cbxTourneyStatus);
            this.Controls.Add(this.lvTournaments);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogout;
        private ListView lvTournaments;
        private ColumnHeader colId;
        private ColumnHeader colSport;
        private ColumnHeader colDesc;
        private ColumnHeader colStartDate;
        private ColumnHeader colEndDate;
        private ColumnHeader colHasStarted;
        private ColumnHeader colMinPlayers;
        private ColumnHeader colMaxPlayers;
        private ColumnHeader colLoc;
        private ColumnHeader colSystem;
        private ComboBox cbxTourneyStatus;
        private Button btnRegisterStaff;
        private Button btnCreateTouney;
        private Button btnEditTourney;
        private Button btnDelTourney;
        private Button btnStartTourneys;
        private Button btnViewTourney;
        private PictureBox pictureBox1;
        private Label lblTime;
        private System.Windows.Forms.Timer tmr;
    }
}