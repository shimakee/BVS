using BusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infosoft_technical.ViewModel
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        private IUnitOfWork _unitOfWork;

        public event PropertyChangedEventHandler PropertyChanged;

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value;
                OnPropertyChanged();
            }
        }
        public CustomerViewModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Customer = new Customer();
        }

        private void OnPropertyChanged([CallerMemberName] String property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public void Load()
        {

        }

        public void AddCustomer()
        {
            _unitOfWork.Customer.Add(Customer);
            _unitOfWork.Complete();
        }
        public void UpdateCustomer()
        {

        }
    }
}
