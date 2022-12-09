using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentationApp.View
{
    /// <summary>
    /// Interaction logic for PanelView.xaml
    /// </summary>
    public partial class PanelView : UserControl
    {
        public PanelView()
        {
            InitializeComponent();
        }
        //int buttonRow = 1;
        //int buttonColumn = 1;
        int SlideNr = 1;

        public void AddProjectButtons()
        {

            Button newbtn = new Button();
            newbtn.Content = SlideNr.ToString();
            newbtn.Name = "Slide" + SlideNr.ToString();
            newbtn.Width = 300;
            newbtn.Height = 150;
            newbtn.Margin = new Thickness(5);
            

            //if(buttonColumn == 5) { buttonColumn = 1; buttonRow++; }
            //Grid.SetRow(newbtn, buttonRow);
            //Grid.SetColumn(newbtn, buttonColumn);
            
            SlideGrid.Children.Add(newbtn);

            
            //buttonColumn++;
            SlideNr++;
        }

        private void AddnewSlide(object sender, RoutedEventArgs e)
        {
            AddProjectButtons();
        }
    }
}
