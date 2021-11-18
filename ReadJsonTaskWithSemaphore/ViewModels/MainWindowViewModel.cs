using Newtonsoft.Json;
using OpenQA.Selenium;
using ReadJsonTaskWithSemaphore.Command;
using ReadJsonTaskWithSemaphore.Models;
using System;
using System.Collections.Generic;
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

        public MainWindowViewModel(MainWindow mainWindow)
        {
            text = @"{
  'Model': 'BMW',
  'Vendor': 'M5',
  'Year': '2016',
   
}";
            StartButtonClick = new RelayCommand((sender) =>
            {
                Car car = new Car();
                car = JsonConvert.DeserializeObject<Car>("1.json");
               
                
                

            });
        }
    }
}
