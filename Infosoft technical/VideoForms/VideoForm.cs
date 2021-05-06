using BusinessLayer;
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
        public VideoForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //refresh
        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
