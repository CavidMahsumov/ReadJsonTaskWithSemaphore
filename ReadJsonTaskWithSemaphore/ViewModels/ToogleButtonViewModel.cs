using ReadJsonTaskWithSemaphore.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ReadJsonTaskWithSemaphore.ViewModels
{
   public class ToogleButtonViewModel:BaseViewModel
    {

        Thickness LeftSide = new Thickness(-39, 0, 0, 0);
        Thickness RightSide = new Thickness(0, 0, -39, 0);
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(250, 0, 0));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(130, 190, 125));
        private bool Toggled = false;
        public bool Toggled1 { get => Toggled; set => Toggled = value; }
        public RelayCommand ToogleButtonClick { get; set; }
        public RelayCommand ToogleButtonClickDot { get; set; }
        public ToogleButtonViewModel(ToogleButtonUserControl toogleButtonUserControl)
        {

            toogleButtonUserControl.Back.Fill = Off;
            Toggled = false;
            toogleButtonUserControl.Dot.Margin = LeftSide;

            ToogleButtonClick = new RelayCommand((sender) =>
            {


             

                if (!Toggled)
                {
                    toogleButtonUserControl.Back.Fill = On;
                    Toggled = true;
                    toogleButtonUserControl.Dot.Margin = RightSide;

                }
                else
                {

                    toogleButtonUserControl.Back.Fill = Off;
                    Toggled = false;
                    toogleButtonUserControl.Dot.Margin = LeftSide;

                }



            });
            ToogleButtonClickDot = new RelayCommand((sender) =>
            {

                if (!Toggled)
                {
                    toogleButtonUserControl.Back.Fill = On;
                    Toggled = true;
                    toogleButtonUserControl.Dot.Margin = RightSide;


                }
                else
                {

                    toogleButtonUserControl.Back.Fill = Off;
                    Toggled = false;
                    toogleButtonUserControl.Dot.Margin = LeftSide;

                }

            });
        }
    }
}
