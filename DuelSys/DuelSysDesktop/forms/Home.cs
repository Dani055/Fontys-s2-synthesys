﻿using BusinessLayer.services;
using Microsoft.Extensions.DependencyInjection;
using BusinessLayer.models;
using BusinessLayer.validators;

namespace DuelSysDesktop.forms
{
    public partial class Home : Form
    {
        bool closedByButton = false;
        private readonly TournamentService _tournamentService;
        private readonly TournamentValidator _tournamentValidator;
        private readonly MatchService _matchService;
        private List<Tournament> tourneys = new List<Tournament>();

        public Home()
        {
            InitializeComponent();
            _tournamentService = Program.ServiceProvider.GetService<TournamentService>();
            _tournamentValidator = Program.ServiceProvider.GetService<TournamentValidator>();
            _matchService = Program.ServiceProvider.GetService<MatchService>();

            cbxTourneyStatus.SelectedIndex = 0;
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            tmr.Start();
            LoadTournaments(cbxTourneyStatus.SelectedItem.ToString());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            closedByButton = true;
            this.Dispose();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closedByButton)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void LoadTournaments(string status)
        {
            try
            {
                tourneys = _tournamentService.GetTournaments(status);
            }
            catch (Exception ex)
            {
                DesktopUtils.ShowError(ex.Message);
            }
            lvTournaments.Items.Clear();
            foreach (Tournament tourney in tourneys)
            {
                string[] row = { tourney.Id.ToString(),tourney.Name, tourney.SportName, tourney.Description, tourney.StartDate.ToShortDateString(), tourney.EndDate.ToShortDateString(), tourney.HasStarted.ToString(), tourney.MinPlayers.ToString(), tourney.MaxPlayers.ToString(), tourney.Location, tourney.SystemName };

                ListViewItem lv = new ListViewItem(row);
                lv.Tag = tourney;
                lvTournaments.Items.Add(lv);
            }
        }




        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            RegisterAccount ra = new RegisterAccount();
            ra.ShowDialog();        
        }

        private void btnCreateTouney_Click(object sender, EventArgs e)
        {
            CreateTournament ct = new CreateTournament();
            ct.ShowDialog();
        }

        private void btnEditTourney_Click(object sender, EventArgs e)
        {
            Tournament tourney = lvTournaments.SelectedItems[0].Tag as Tournament;
            if (_tournamentValidator.CheckIfTournamentBeginsInOneWeek(tourney))
            {
                DesktopUtils.ShowError("Tournament begins in less than one week and cannot be edited!");
                return;
            }
            EditTournament et = new EditTournament(tourney.Id);
            et.ShowDialog();
        }

        private void btnViewTourney_Click(object sender, EventArgs e)
        {
            ViewGames vg = new ViewGames();
            vg.ShowDialog();
        }

        private void cbxTourneyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTournaments(cbxTourneyStatus.SelectedItem.ToString());
        }

        private void btnDelTourney_Click(object sender, EventArgs e)
        {
            try
            {
                int tourneyId = Convert.ToInt16(lvTournaments.SelectedItems[0].Text);
                DialogResult dr = DesktopUtils.ShowConfirmation("Are you sure you want to delete this tournament? This action cannot be undone!");
                if (dr == DialogResult.OK)
                {
                    bool result = _tournamentService.DeleteTournament(tourneyId, DesktopUtils.loggedUser);
                    if (result)
                    {
                        DesktopUtils.ShowInfo("Tournament deleted");
                    }
                    LoadTournaments(cbxTourneyStatus.SelectedItem.ToString());
                }
            }

            catch (ArgumentOutOfRangeException)
            {
                DesktopUtils.ShowError("Select tournament to delete!");
            }
            catch (Exception ex)
            {
                DesktopUtils.ShowError(ex.Message);
            }
        }

        private void btnStartTournament_Click(object sender, EventArgs e)
        {
            try
            {
                int tourneyId = Convert.ToInt16(lvTournaments.SelectedItems[0].Text);
                bool result = _matchService.ScheduleTournament(tourneyId, DesktopUtils.loggedUser);
                if (result)
                {
                    DesktopUtils.ShowInfo("Tournament scheduled");
                    LoadTournaments(cbxTourneyStatus.SelectedItem.ToString());
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                DesktopUtils.ShowError("Select tournament to delete!");
            }
            catch (Exception ex)
            {
                DesktopUtils.ShowError(ex.Message);
                LoadTournaments(cbxTourneyStatus.SelectedItem.ToString());
            }
        }
    }
}
