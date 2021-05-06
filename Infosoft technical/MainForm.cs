using BusinessLayer;
using DataAccessLayer;
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
    public partial class MainForm : Form
    {
        private CustomerForm customerForm { get; set; }
        private readonly IUnitOfWork _unitOfWork;
        public MainForm(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerForm == null)
                customerForm = new CustomerForm(_unitOfWork);
            customerForm.ShowDialog();
        }
    }
}
