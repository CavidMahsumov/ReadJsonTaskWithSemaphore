using Newtonsoft.Json;
using OpenQA.Selenium;
using ReadJsonTaskWithSemaphore.Command;
using ReadJsonTaskWithSemaphore.Json;
using ReadJsonTaskWithSemaphore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ReadJsonTaskWithSemaphore.ViewModels
{
   public class MainWindowViewModel:BaseViewModel
    {
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(240, 222, 45));
        public IWebElement txtProductSearch1 = null;
        public string FileName { get; set; }
        public string text { get; set; }
        public RelayCommand  StartButtonClick { get; set; }
        public static DataBase DataBase  = new DataBase();
        public MainWindowViewModel(MainWindow mainWindow)
        {
        //    Car car1 = new Car { Model = "Lx", Vendor = "Lexus", Year = 2015, ImagePath = "https://github.com/CavidMahsumov/CarGalleryImages/blob/main/Lexsus%20LX.jpg?raw=true" };
        //    Car car2 = new Car { Model = "F", Vendor = "Lexus", Year = 2015, ImagePath = "https://github.com/CavidMahsumov/CarGalleryImages/blob/main/LexsusF.jpg?raw=true" };
        //    Car car3 = new Car { Model = "RangeRover", Vendor = "LandRover", Year = 2015, ImagePath = "https://github.com/CavidMahsumov/CarGalleryImages/blob/main/LandRover.jpg?raw=true" };
        //    Car car4 = new Car { Model = "Optima", Vendor = "Kia", Year = 2015, ImagePath = "https://github.com/CavidMahsumov/CarGalleryImages/blob/main/Kia%20Optima.jpg?raw=true" };

        //    ObservableCollection<Car> Cars = new ObservableCollection<Car>();
        //    Cars.Add(car1);
        //    Cars.Add(car2);
        //    Cars.Add(car3);
        //    Cars.Add(car4);
        //    DataBase.Cars = Cars;

        //    JsonHelper.JSONSerialization(DataBase);

            StartButtonClick = new RelayCommand((sender) =>
            {
                JsonHelper.JSONDeSerialization(ref DataBase);
                mainWindow.listbox.ItemsSource = DataBase.Cars;

            });

        }
    }
}
