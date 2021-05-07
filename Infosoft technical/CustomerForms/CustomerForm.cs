using BusinessLayer;
using DataAccessLayer;
using Models;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infosoft_technical
{
    public partial class CustomerForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private AddCustomerForm addCustomerForm { get; set; }
        public Customer Customer { get; set; }
        public CustomerForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            Customer = new Customer();
            InputFirstName.DataBindings.Add("Text", Customer, nameof(Customer.FirstName));
            InputLastName.DataBindings.Add("Text", Customer, nameof(Customer.LastName));
            InputBirthdate.DataBindings.Add("Value", Customer, nameof(Customer.Birthdate));
            //submit.Click += delegate { viewModel.UpdateCustomer(); };
            //cancel.Click += delegate { viewModel.Cancel(); };
            //AddButton.Click += delegate { viewModel.OpenAddCustomerForm(); };
            ListOfCustomers.DataSource = unitOfWork.Customer.GetAll().ToList();
            rentals.DataSource = unitOfWork.Rental.Find(rent => rent.Customer.ID == Customer.ID).ToList();
            ListOfCustomers.SelectionChanged += delegate { SelectionChanged(); };
        }


        private void SelectionChanged()
        {
            if(ListOfCustomers != null)
            {
                if(ListOfCustomers.SelectedRows.Count > 0)
                {
                    var customer = ListOfCustomers.SelectedRows[0].DataBoundItem as Customer;
                    if(customer != null)
                    {
                        Customer = customer;
                        rentals.DataSource = _unitOfWork.Rental.Find(rent => rent.Customer.ID == Customer.ID).ToList();

                        InputFirstName.DataBindings.Clear();
                        InputLastName.DataBindings.Clear();
                        InputBirthdate.DataBindings.Clear();
                        InputFirstName.DataBindings.Add("Text", Customer, nameof(Customer.FirstName));
                        InputLastName.DataBindings.Add("Text", Customer, nameof(Customer.LastName));
                        InputBirthdate.DataBindings.Add("Value", Customer, nameof(Customer.Birthdate));
                    }
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            _unitOfWork.Customer.Update(Customer);
            _unitOfWork.Complete();
            ListOfCustomers.DataSource = _unitOfWork.Customer.GetAll().ToList();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (addCustomerForm == null)
                addCustomerForm = new AddCustomerForm(_unitOfWork);

            addCustomerForm.ShowDialog();
            addCustomerForm.FormClosed += refreshList;
        }

        private void refreshList(object sender, FormClosedEventArgs e)
        {
            ListOfCustomers.DataSource = _unitOfWork.Customer.GetAll().ToList();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfCustomers.DataSource = _unitOfWork.Customer.GetAll().ToList();

        }
    }
}
