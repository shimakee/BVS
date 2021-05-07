using BusinessLayer;
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
            titleInput.DataBindings.Add("Text", video, nameof(video.Title));
            stockInput.DataBindings.Add("Value", video, nameof(video.InStock));
            categoryInput.DataSource = Enum.GetNames(typeof(VideoCategory));
            categoryInput.DataBindings.Add("SelectedIndex", video, nameof(video.Category));
            categoryInput.SelectedIndexChanged += delegate { ComboSelectionChanged(); };

        }

        private void submit_Click(object sender, EventArgs e)
        {
            _unitOfWork.Video.Add(video);
            _unitOfWork.Complete();
            video = new Video();
            video.Category = VideoCategory.DVD;

            titleInput.DataBindings.Clear();
            categoryInput.DataBindings.Clear();
            stockInput.DataBindings.Clear();


            titleInput.DataBindings.Add("Text", video, nameof(video.Title));
            stockInput.DataBindings.Add("Value", video, nameof(video.InStock));
            categoryInput.DataBindings.Add("SelectedIndex", video, nameof(video.Category));

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboSelectionChanged()
        {
            if (categoryInput != null)
            {
                if (categoryInput.Items.Count > 0)
                {
                    var selection = (VideoCategory)Enum.Parse(typeof(VideoCategory), categoryInput.SelectedValue.ToString());
                    video.Category = selection;
                }
            }
        }
    }
}
