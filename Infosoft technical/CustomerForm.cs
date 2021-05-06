using BusinessLayer;
using DataAccessLayer;
using Infosoft_technical.ViewModel;
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
        public CustomerForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            CustomerViewModel viewModel = new CustomerViewModel(unitOfWork);
            viewModel.Customer.FirstName = InputFirstName.Text;
            viewModel.Customer.LastName = InputLastName.Text;
            viewModel.Customer.Birthdate = InputBirthdate.SelectionRange.Start;
            submit.Click += delegate { viewModel.AddCustomer(); };
        }

        //private void submit_Click(object sender, EventArgs e)
        //{
        //    _unitOfWork.Customer.Add(customer);
        //    _unitOfWork.Complete();
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
