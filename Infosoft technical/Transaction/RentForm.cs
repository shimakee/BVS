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
    public partial class RentForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public Customer Customer { get; set; }

        public int DaysRental { get; set; } = 1;

        public decimal TotalAmount
        {
            get { return Rentals.Sum(video => video.Price) * DaysRental; }
        }
        public BindingList<Video> Rentals { get; set; }
        public Video VideoSelected { get; set; }
        public RentForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _unitOfWork = unitOfWork;

            var videos = _unitOfWork.Video.GetAll().ToList();
            if (videos.Count > 0)
                VideoSelected = videos[0];

            var customers = _unitOfWork.Customer.GetAll().ToList();
            if (customers.Count > 0)
                Customer = customers[0];
            else
                Customer = new Customer();

            customersList.DataSource = customers;

            firstname.DataBindings.Add("Text", Customer, nameof(Customer.FirstName));
            lastname.DataBindings.Add("Text", Customer, nameof(Customer.LastName));
            age.DataBindings.Add("Value", Customer, nameof(Customer.Age));

            totalAmount.DataBindings.Add("Text", this, nameof(this.TotalAmount));

            daysRental.DataBindings.Add("Value", this, nameof(this.DaysRental));

            videosList.DataSource = _unitOfWork.Video.GetAll().ToList();
            rentalList.DataSource = Rentals = new BindingList<Video>();

            daysRental.ValueChanged += delegate { daysChanged(); };
            videosList.SelectionChanged += delegate { SelectionChanged(); };
            rentalList.SelectionChanged += delegate { SelectionChangedRental(); };
            customersList.SelectionChanged += delegate { SelectionChangedCustomer(); };
        }

        private void daysChanged()
        {
            totalAmount.DataBindings.Clear();
            totalAmount.DataBindings.Add("Text", this, nameof(this.TotalAmount));
        }

        private void rent_Click(object sender, EventArgs e)
        {
            foreach (var video in Rentals)
            {
                var rental = new VideoRental();
                var v = _unitOfWork.Video.Get(rental.Video.ID);
                if(v.InStock > 0)
                {
                    rental.Customer = Customer;
                    rental.Video = video;
                    rental.RentDate = DateTime.Now;
                    rental.DueDate = DateTime.Now.AddDays(DaysRental);
                    rental.Status = RentalStatus.Rented;
                    _unitOfWork.Rental.Add(rental);

                    //change video stock here
                    v.InStock--;
                    _unitOfWork.Video.Update(v);
                }



            }

            _unitOfWork.Complete();

            rentalList.DataSource = Rentals = new BindingList<Video>();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(!Rentals.Contains(VideoSelected))
                Rentals.Add(VideoSelected);

            rentalList.DataSource = Rentals;
            totalAmount.DataBindings.Clear();
            totalAmount.DataBindings.Add("Text", this, nameof(this.totalAmount));
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (Rentals.Contains(VideoSelected))
                Rentals.Remove(VideoSelected);

            rentalList.DataSource = Rentals;
            totalAmount.DataBindings.Clear();
            totalAmount.DataBindings.Add("Text", this, nameof(this.totalAmount));
        }

        private void SelectionChanged()
        {
            if (videosList != null)
            {
                if (videosList.SelectedRows.Count > 0)
                {
                    var video = videosList.SelectedRows[0].DataBoundItem as Video;
                    if (video != null)
                    {
                        VideoSelected = video;
                    }
                }
            }
        }

        private void SelectionChangedRental()
        {
            if (rentalList != null)
            {
                if (rentalList.SelectedRows.Count > 0)
                {
                    var video = rentalList.SelectedRows[0].DataBoundItem as Video;
                    if (video != null)
                    {
                        VideoSelected = video;
                    }
                }
            }
        }

        private void SelectionChangedCustomer()
        {
            if(customersList != null)
            {
                if(customersList.SelectedRows.Count > 0)
                {
                    var customer = customersList.SelectedRows[0].DataBoundItem as Customer;
                    Customer = customer;

                    firstname.DataBindings.Clear();
                    lastname.DataBindings.Clear();
                    age.DataBindings.Clear();

                    firstname.DataBindings.Add("Text", Customer, nameof(Customer.FirstName));
                    lastname.DataBindings.Add("Text", Customer, nameof(Customer.LastName));
                    age.DataBindings.Add("Value", Customer, nameof(Customer.Age));
                }
            }
        }
    }
}
