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

namespace Infosoft_technical.Transaction
{
    public partial class ReturnForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public Customer Customer { get; set; }
        public BindingList<Video> Videos { get; set; }
        public List<VideoRental> Rental { get; set; }
        public Video SelectedVideo { get; set; }
        public VideoRental VideoRental { get; set; }

        public int DaysRented { get; set; } = 1;
        public int DaysPastDue { get; set; }
        public decimal PenaltyAmount { get; set; }
        public decimal TotalAmount { get; set; }

        public ReturnForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;

            var customers = unitOfWork.Customer.GetAll().ToList();
            if (customers.Count > 0)
                Customer = customers[0];
            else
                Customer = new Customer();

            customersList.DataSource = customers;
            var rentals = unitOfWork.Rental.Find(rental => rental.Customer.ID == Customer.ID && rental.Status == RentalStatus.Rented).ToList();
            Rental = rentals;
            var videos = rentals.Select(rental => rental.Video).ToList();
            //var videosRentedId = rentals.Select(rental => rental.Video).ToList().Select(video => video.ID).ToList();
            //var rentedVideos = _unitOfWork.Video.Find(video => videosRentedId.Contains(video.ID)).ToList();
            videosList.DataSource = videos;
            if (videos.Count > 0)
                SelectedVideo = videos[0];
            else
            {
                SelectedVideo = new Video();
                SelectedVideo.Category = VideoCategory.DVD;
            }

            VideoRental = Rental.Where(rent => rent.Video.ID == SelectedVideo.ID).FirstOrDefault();

            firstname.DataBindings.Add("Text", Customer, nameof(Customer.FirstName));
            lastname.DataBindings.Add("Text", Customer, nameof(Customer.LastName));
            age.DataBindings.Add("Value", Customer, nameof(Customer.Age));

            Title.DataBindings.Add("Text", SelectedVideo, nameof(SelectedVideo.Title));
            rentalPrice.DataBindings.Add("Value", SelectedVideo, nameof(SelectedVideo.Price));
            category.DataSource = Enum.GetNames(typeof(VideoCategory));
            category.DataBindings.Add("SelectedIndex", SelectedVideo, nameof(SelectedVideo.Category));

            daysRented.DataBindings.Add("Value", this, nameof(this.DaysRented));
            daysPastDue.DataBindings.Add("Value", this, nameof(this.DaysPastDue));
            penaltyAmount.DataBindings.Add("Text", this, nameof(this.PenaltyAmount));
            totalAmount.DataBindings.Add("Text", this, nameof(this.TotalAmount));

            videosList.SelectionChanged += delegate { SelectionChangedRental(); };
            customersList.SelectionChanged += delegate { SelectionChangedCustomer(); };



        }

        private void returnVideo_Click(object sender, EventArgs e)
        {
            var rentalInfo = _unitOfWork.Rental.Get(VideoRental.ID);
            rentalInfo.Status = RentalStatus.Returned;
            rentalInfo.ReturnDate = DateTime.Now;
            var video = _unitOfWork.Video.Get(VideoRental.Video.ID);
            video.InStock++;

            _unitOfWork.Rental.Update(rentalInfo);
            _unitOfWork.Video.Update(video);
            _unitOfWork.Complete();

            var rentals = _unitOfWork.Rental.Find(rental => rental.Customer.ID == Customer.ID && rental.Status == RentalStatus.Rented).ToList();
            Rental = rentals;
            var videos = rentals.Select(rental => rental.Video).ToList();
            videosList.DataSource = videos;
            if (Rental.Count > 0)
                SelectedVideo = Rental[0].Video;
            VideoRental = Rental.Where(rent => rent.Video.ID == SelectedVideo.ID).FirstOrDefault();
            if (VideoRental != null)
            {
                DaysRented = (VideoRental.RentDate - DateTime.Now).Days;
                if (DaysRented <= 0)
                    DaysRented = 1;
                DaysPastDue = (VideoRental.DueDate - DateTime.Now).Days;
                PenaltyAmount = DaysPastDue * 5;
                TotalAmount = (VideoRental.Video.Price * (DaysRented + DaysPastDue)) + PenaltyAmount;
                daysRented.DataBindings.Clear();
                daysRented.DataBindings.Add("Value", this, nameof(this.DaysRented));
                daysPastDue.DataBindings.Clear();
                daysPastDue.DataBindings.Add("Value", this, nameof(this.DaysPastDue));
                penaltyAmount.DataBindings.Clear();
                penaltyAmount.DataBindings.Add("Value", this, nameof(this.PenaltyAmount));
                totalAmount.DataBindings.Clear();
                totalAmount.DataBindings.Add("Value", this, nameof(this.TotalAmount));
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectionChangedRental()
        {
            if (videosList != null)
            {
                if (videosList.SelectedRows.Count > 0)
                {
                    var video = videosList.SelectedRows[0].DataBoundItem as Video;
                    if (video != null)
                    {
                        SelectedVideo = video;

                        Title.DataBindings.Clear();
                        rentalPrice.DataBindings.Clear();
                        category.DataBindings.Clear();

                        Title.DataBindings.Add("Text", SelectedVideo, nameof(SelectedVideo.Title));
                        rentalPrice.DataBindings.Add("Value", SelectedVideo, nameof(SelectedVideo.Price));
                        category.DataBindings.Add("SelectedIndex", SelectedVideo, nameof(SelectedVideo.Category));

                        //DaysRented = Rental.Where(rent => rent.Video.ID == SelectedVideo.ID).Select(items => items.Video).Sum(video => video.Price);

                        VideoRental = Rental.Where(rent => rent.Video.ID == SelectedVideo.ID).FirstOrDefault();
                        if (VideoRental != null)
                        {
                            DaysRented = (VideoRental.RentDate - DateTime.Now).Days;
                            if (DaysRented <= 0)
                                DaysRented = 1;
                            DaysPastDue = (VideoRental.DueDate - DateTime.Now).Days;
                            PenaltyAmount = DaysPastDue * 5;
                            TotalAmount = (VideoRental.Video.Price * (DaysRented + DaysPastDue)) + PenaltyAmount;
                            daysRented.DataBindings.Clear();
                            daysRented.DataBindings.Add("Value", this, nameof(this.DaysRented));
                            daysPastDue.DataBindings.Clear();
                            daysPastDue.DataBindings.Add("Value", this, nameof(this.DaysPastDue));
                            penaltyAmount.DataBindings.Clear();
                            penaltyAmount.DataBindings.Add("Value", this, nameof(this.PenaltyAmount));
                            totalAmount.DataBindings.Clear();
                            totalAmount.DataBindings.Add("Value", this, nameof(this.TotalAmount));
                        }
                    }
                }
            }
        }

        private void SelectionChangedCustomer()
        {
            if (customersList != null)
            {
                if (customersList.SelectedRows.Count > 0)
                {
                    var customer = customersList.SelectedRows[0].DataBoundItem as Customer;
                    Customer = customer;

                    firstname.DataBindings.Clear();
                    lastname.DataBindings.Clear();
                    age.DataBindings.Clear();

                    firstname.DataBindings.Add("Text", Customer, nameof(Customer.FirstName));
                    lastname.DataBindings.Add("Text", Customer, nameof(Customer.LastName));
                    age.DataBindings.Add("Value", Customer, nameof(Customer.Age));

                    var rentals = _unitOfWork.Rental.Find(rental => rental.Customer.ID == Customer.ID && rental.Status == RentalStatus.Rented).ToList();
                    Rental = rentals;
                    var videos = rentals.Select(rental => rental.Video).ToList();
                    videosList.DataSource = videos;
                    if (videos.Count > 0)
                        SelectedVideo = videos[0];
                    else
                    {
                        SelectedVideo = new Video();
                        SelectedVideo.Category = VideoCategory.DVD;
                    }
                }
            }
        }
    }
}
