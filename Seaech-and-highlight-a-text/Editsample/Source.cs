#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BusinessObject
{
    /// <summary>
    ///  Sport class implemented with INotifyPropertyChanged interface
    /// </summary>
    public class Sport : INotifyPropertyChanged
    {
	
        #region Local variables

        int _sportID;
        string _sportName;
        double _interest;

        #endregion

        #region Properties

        public int SportID
        {
            get
            {
                return this._sportID;
            }
            set
            {
                this._sportID = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("SportID"));
            }
        }
        public string SportName
        {
            get
            {
                return this._sportName;
            }
            set
            {
                this._sportName = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("SportName"));
            }
        }

        public Double Interest
        {
            get
            {
                return this._interest;
            }
            set
            {
                this._interest = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("Interest"));
            }
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, args);
        }

        #endregion

    }
	
    /// <summary>
    ///  ObservableCollection class to hold a list of sport object
    /// </summary>
    public class Sports : ObservableCollection<Sport>
    {
        #region Constructor
		int fire;
		//int a = a + b;
        public Sports()
            : base()
        {
            Add(new Sport() { SportID = 101, SportName = "Golf", Interest = 9 });
            Add(new Sport() { SportID = 102, SportName = "Soccer", Interest = 40 });
            Add(new Sport() { SportID = 103, SportName = "Cricket", Interest = 15 });
            Add(new Sport() { SportID = 104, SportName = "Rugby", Interest = 7 });
            Add(new Sport() { SportID = 105, SportName = "Atheletics", Interest = 3 });
            Add(new Sport() { SportID = 106, SportName = "Tennis", Interest = 10 });
            Add(new Sport() { SportID = 107, SportName = "Baseball", Interest = 6 });
            Add(new Sport() { SportID = 108, SportName = "Basketball", Interest = 10 });
        }

        #endregion
    }

}
