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
    public partial class VideoForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private AddVideoForm _addVideoForm { get; set; }
        public Video Video { get; set; }

        public VideoForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
            Video = new Video();
            Video.Category = VideoCategory.DVD;

            title.DataBindings.Add("Text", Video, nameof(Video.Title));
            category.DataSource = Enum.GetNames(typeof(VideoCategory));
            category.DataBindings.Add("SelectedIndex", Video, nameof(Video.Category));

            videoList.DataSource = unitOfWork.Video.GetAll().ToList();
            videoList.SelectionChanged += delegate { SelectionChanged(); };
            category.SelectedIndexChanged += delegate { ComboSelectionChanged(); };
        }

        private void ComboSelectionChanged()
        {
            if(category != null)
            {
                if(category.Items.Count > 0)
                {
                    var selection = (VideoCategory)Enum.Parse(typeof(VideoCategory), category.SelectedValue.ToString());

                    Video.Category = selection;
                    //category.DataBindings.Clear();
                    //category.DataBindings.Add("SelectedIndex", Video, nameof(Video.Category));

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add
            if (_addVideoForm == null)
                _addVideoForm = new AddVideoForm(_unitOfWork);

            _addVideoForm.ShowDialog();
            _addVideoForm.FormClosed += refreshList;

        }

        private void refreshList(object sender, FormClosedEventArgs e)
        {
            videoList.DataSource = _unitOfWork.Video.GetAll().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //refresh
            videoList.DataSource = _unitOfWork.Video.GetAll().ToList();

        }

        private void submit_Click(object sender, EventArgs e)
        {
            _unitOfWork.Video.Update(Video);
            _unitOfWork.Complete();

            videoList.DataSource = _unitOfWork.Video.GetAll().ToList();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            _unitOfWork.Video.Remove(Video);
            _unitOfWork.Complete();

            videoList.DataSource = _unitOfWork.Video.GetAll().ToList();
        }

        private void SelectionChanged()
        {
            if (videoList != null)
            {
                if (videoList.SelectedRows.Count > 0)
                {
                    var video = videoList.SelectedRows[0].DataBoundItem as Video;
                    if (video != null)
                    {
                        Video = video;

                        title.DataBindings.Clear();
                        category.DataBindings.Clear();

                        title.DataBindings.Add("Text", Video, nameof(Video.Title));
                        category.DataBindings.Add("SelectedIndex", Video, nameof(Video.Category));
                    }
                }
            }
        }
    }
}
