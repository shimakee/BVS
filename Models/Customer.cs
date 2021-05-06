using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer : BaseEntity, ICustomer
    {
        public Customer()
        {
            Birthdate = DateTime.Now;
        }
        private string _first;
        public string FirstName
        {
            get { return _first; }
            set
            {
                _first = value;
                OnPropertyChanged();
            }
        }

        private string _last;
        public string LastName
        {
            get { return _last; }
            set
            {
                _last = value;
                OnPropertyChanged();
            }
        }

        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                _birthdate = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get { return (int)(DateTime.Now - Birthdate).Days/365; }
        }
    }
}
