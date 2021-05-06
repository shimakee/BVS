﻿using BusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infosoft_technical.VideoForms
{
    public partial class AddVideoForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public Video video { get; set; }
        public AddVideoForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            video = new Video();
            video.Category = VideoCategory.DVD;

            titleInput.DataBindings.Add("Text", video, nameof(video.Title));
            categoryInput.Items.AddRange(Enum.GetNames(typeof(VideoCategory)));
            categoryInput.DataBindings.Add("SelectedItem", video, nameof(video.Category));
        }

        private void submit_Click(object sender, EventArgs e)
        {
            _unitOfWork.Video.Add(video);
            _unitOfWork.Complete();
            video = new Video();
            video.Category = VideoCategory.DVD;

            titleInput.DataBindings.Clear();
            categoryInput.DataBindings.Clear();

            titleInput.DataBindings.Add("Text", video, nameof(video.Title));
            categoryInput.DataBindings.Add("SelectedItem", video, nameof(video.Category));

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
