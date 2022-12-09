using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PresentationApp.ViewModel;
using PresentationApp.Model;

namespace PresentationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ProjectsManager Projects;
        public MainWindow()
        {
            InitializeComponent();
            Projects = new ProjectsManager();

            //temp default project
            Projects.AddNewProject();
        }

        private void AddNewProjectButton(object sender, RoutedEventArgs e)
        {
            Button NewAddition = new Button();
        }

        private void Project1(object sender, RoutedEventArgs e)
        {
            DataContext = new PanelViewModel(Projects.GetFirstProject());
            
        }

        private void Project2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
