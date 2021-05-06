using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BaseEntity : IEntity, INotifyPropertyChanged
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateCreated;
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set
            {
                _dateCreated = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateUpdated;
        public DateTime DateUpdated
        {
            get { return _dateUpdated; }
            set
            {
                _dateUpdated = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] String property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
