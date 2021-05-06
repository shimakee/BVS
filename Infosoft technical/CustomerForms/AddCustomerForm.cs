using BusinessLayer;
using DataAccessLayer;
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

namespace Infosoft_technical
{
    public partial class AddCustomerForm : Form
    {
        public Customer Customer { get; set; }
        private readonly IUnitOfWork _unitOfWork;
        public AddCustomerForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            Customer = new Customer();
            InputFirstName.DataBindings.Add("Text", Customer, nameof(Customer.FirstName));
            InputLastName.DataBindings.Add("Text", Customer, nameof(Customer.LastName));
            InputBirthdate.DataBindings.Add("Value", Customer, nameof(Customer.Birthdate));
        }

        private void submit_Click(object sender, EventArgs e)
        {
            _unitOfWork.Customer.Add(Customer);
            _unitOfWork.Complete();
            Customer = new Customer();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
