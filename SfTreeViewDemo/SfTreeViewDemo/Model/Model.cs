#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml;
using Syncfusion.UI.Xaml.Core;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SfTreeViewDemo
{
     public class Model : INotifyPropertyChanged
    {
        #region Fields       

        private string header = string.Empty;
        private bool isexpanded = true;
        private DataTemplate imageTemplate;
        private ObservableCollection<Model> childs = null;

        #endregion

        #region Constructor        

        public Model(string header) :base()
        {
            Childs = new ObservableCollection<Model>();
            Header = header;
        }

        #endregion

        #region Properties
        public string Header
        {
            get
            {               
                return header;
            }
            set
            {
                header = value;
                this.RaisePropertyChanged("Header");
            }
        }

        public bool IsExpanded
        {
            get
            {
                return isexpanded;
            }
            set
            {
                isexpanded = value;
                this.RaisePropertyChanged("IsExpanded");
            }
        }
        
        public DataTemplate ImageTemplate
        {
            get { return imageTemplate; }
            set { imageTemplate = value; }
        }

        public ObservableCollection<Model> Childs
        {
            get
            {
                return childs;
            }
            set
            {
                childs = value;
                this.RaisePropertyChanged("Childs");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));                
            }
        }

        #endregion       
    }
}
