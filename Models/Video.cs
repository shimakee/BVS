﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Video : BaseEntity
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private VideoCategory _category;
        public VideoCategory Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged();
            }
        }

        private int _stock;
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 0)
                    _stock = 0;
                else
                    _stock = value;
                OnPropertyChanged();
            }
        }

        public decimal Price { get { return (Category == VideoCategory.DVD) ? 50 : 25; } }

    }

    public enum VideoCategory
    {
        VCD,
        DVD
    }
}
