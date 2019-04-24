using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Allocatr
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        DatabaseManager DbManager = new DatabaseManager();
        ObservableCollection<Project> Projects;

        public MainPage()
        {
            InitializeComponent();
            Projects = new ObservableCollection<Project>(DbManager.FindAllProjects());
            ProjectsListView.ItemsSource = Projects;
        }

        async void OnProjectSelected(ListView sender, ItemTappedEventArgs args)
        {
            var projectSelected = (Project)args.Item;
            await Navigation.PushAsync(new ProjectDetailsPage(projectSelected));
        }
    }
}
