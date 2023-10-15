using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewGroup
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var students = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Doe", ID = 1, Section = "Section A" },
                new Student { FirstName = "Jane", LastName = "Smith", ID = 2, Section = "Section A" },
                new Student { FirstName = "Mike", LastName = "Johnson", ID = 3, Section = "Section B" },
                new Student { FirstName = "Emily", LastName = "Brown", ID = 4, Section = "Section B" },
            };

            var groupedStudents = students.GroupBy(s => s.Section).Select(g => new Grouping<string, Student>(g.Key, g.ToList())).ToList();

            listView.ItemsSource = groupedStudents;
        }
    }
}
