﻿using System;
using System.Windows.Forms;
using JenkinsTray.BusinessComponents;
using JenkinsTray.Entities;
using Spring.Context.Support;

namespace JenkinsTray.UI
{
    partial class ClaimBuildBox : Form
    {
        private BuildDetails buildDetails;
        private readonly ClaimService claimService;
        private Project project;

        public ClaimBuildBox()
        {
            InitializeComponent();

            claimService = (ClaimService)ContextRegistry.GetContext().GetObject("ClaimService");
        }

        public void Initialize(Project project, BuildDetails buildDetails)
        {
            this.project = project;
            this.buildDetails = buildDetails;

            buildNumberLabel.Text = buildDetails.Number.ToString();
            reasonMemoEdit.Select();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var reason = reasonMemoEdit.Text;
            var sticky = stickyCheckEdit.Checked;
            claimService.ClaimBuild(project, buildDetails, reason, sticky);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
