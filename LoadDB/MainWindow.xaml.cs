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
using LoadDB.Models;
using Microsoft.EntityFrameworkCore;

namespace LoadDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Load()
        {
            var list = Prn211Context.INSTANCE.Students.Include(x => x.Depart).ToList();
            lvDisplay.ItemsSource = list;
            lvDisplay.Items.Refresh();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Student st = GetStudent();
            if (st == null) { return; }
            var x = Prn211Context.INSTANCE.Students.Find(st.Id);
            if (x != null) { return; }
            Prn211Context.INSTANCE.Students.Add(st);
            Prn211Context.INSTANCE.SaveChanges();
            Load();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Student st = GetStudent();
            if (st == null) { return; }
            var x = Prn211Context.INSTANCE.Students.Find(st.Id);
            if (x == null) { return; }
            x.Name = st.Name;
            x.Gpa = st.Gpa;
            x.Dob = st.Dob;
            x.DepartId = st.DepartId;
            x.Gender = st.Gender;
            Prn211Context.INSTANCE.Students.Update(x);
            Prn211Context.INSTANCE.SaveChanges();
            Load();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var x = Prn211Context.INSTANCE.Students.Find(id);
            if (x == null) { return; }
            Prn211Context.INSTANCE.Students.Remove(x);
            Prn211Context.INSTANCE.SaveChanges();
            Load();
        }

        private Student GetStudent()
        {
            Student st = new Student();
            try
            {
                st.Id = int.Parse(txtId.Text);
                st.Name = txtName.Text;
                st.Gender = rbMale.IsChecked == true;
                st.Dob = (DateOnly.FromDateTime(dpDob.SelectedDate.Value));
                st.Gpa = double.Parse(txtGPA.Text);
                st.DepartId = spDepart.Tag.ToString();
                return st;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void LoadDepart(string s)
        {
            spDepart.Children.Clear();
            foreach (Department department in Prn211Context.INSTANCE.Departments)
            {
                RadioButton rd = new RadioButton() { Content = department.Name, Tag = department.Id, IsChecked = (department.Id.Equals(s)) };
                rd.Checked += Rd_Checked;
                spDepart.Children.Add(rd);
            }
        }

        private void Rd_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            spDepart.Tag = rd.Tag;
        }

        private void lvDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student st = lvDisplay.SelectedItem as Student;
            if (st != null)
            {
                bool currentGender = st.Gender;
                if (!currentGender) rbFemale.IsChecked = true;
                else rbMale.IsChecked = true;
            }
            if (spDepart.Tag != null)
            {
                LoadDepart(spDepart.Tag.ToString());
            }
            else
            {
                LoadDepart("SE");
            }
        }
    }
}