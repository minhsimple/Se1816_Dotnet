using System.Collections;
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

namespace FirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String[][] subjectSemester = {
            ["PRF192", "MAE101", "CEA201", "CSI104"],
            ["PRO192", "MAD101", "OSG202", "SSG104"],
            ["JPD113", "CSD201", "DBI202", "LAB211"],
            ["MAS291", "JPD123", "IOT102", "PRJ301"],
            ["SWP391", "SWR302", "SWT301", "PRN212"],
            ["OJT202", "ENW492c"],
            ["EXE101", "PRU212", "PRM392", "SWD392"],
            ["EXE201", "MLN122", "WDU203c", "PRN231", "MLN111"],
            ["MLN131", "VNR202", "SEP490", "HCM202"]
        };

        public int[] getArraySemester(String[][] subjectSemester)
        {
            int[] arraySemester = new int[subjectSemester.Length];
            for (int i = 0; i < arraySemester.Length; i++)
            {
                arraySemester[i] = i + 1;
            }
            return arraySemester;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            String Id = txtID.Text;
            String FullName = txtFullName.Text;
            Boolean isFemale = rdoGenderFemale.IsChecked == true;
            String gender = isFemale ? "Female" : "Male";
            int semester = int.Parse(cbbSemester.Text);
            ArrayList favorSubjects = new ArrayList();
            foreach (var item in checkBoxPanel.Children)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    bool isChecked = checkBox.IsChecked ?? false;
                    if (isChecked) { favorSubjects.Add(checkBox.Content); }
                }
            }
            string result = String.Join(", ", favorSubjects.ToArray());
            lblInfo.Content = $"Student name is {FullName}\n Id is{Id}\n{gender}\n Studying at semester {semester}\n favor subject is {result}";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbbSemester.ItemsSource = getArraySemester(subjectSemester);
            cbbSemester.SelectedIndex = 0;
        }

        private void cbbSemester_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            checkBoxPanel.Children.Clear();
            int semester;
            int.TryParse(cbbSemester.SelectedItem.ToString(), out semester);
            switch (semester)
            {
                case 1:
                    for (int i = 0; i < subjectSemester[0].Length; i++)
                    {
                        AddCheckBox(subjectSemester[0][i]);

                    }

                    break;
                case 2:
                    for (int i = 0; i < subjectSemester[1].Length; i++)
                    {
                        AddCheckBox(subjectSemester[1][i]);

                    }

                    break;
                case 3:
                    for (int i = 0; i < subjectSemester[2].Length; i++)
                    {
                        AddCheckBox(subjectSemester[2][i]);

                    }

                    break;
                case 4:
                    for (int i = 0; i < subjectSemester[3].Length; i++)
                    {
                        AddCheckBox(subjectSemester[3][i]);

                    }

                    break;
                case 5:
                    for (int i = 0; i < subjectSemester[4].Length; i++)
                    {
                        AddCheckBox(subjectSemester[4][i]);

                    }

                    break;

                case 6:
                    for (int i = 0; i < subjectSemester[5].Length; i++)
                    {
                        AddCheckBox(subjectSemester[5][i]);

                    }

                    break;
                case 7:
                    for (int i = 0; i < subjectSemester[6].Length; i++)
                    {
                        AddCheckBox(subjectSemester[6][i]);

                    }

                    break;
                case 8:
                    for (int i = 0; i < subjectSemester[7].Length; i++)
                    {
                        AddCheckBox(subjectSemester[7][i]);

                    }

                    break;
                case 9:
                    for (int i = 0; i < subjectSemester[8].Length; i++)
                    {
                        AddCheckBox(subjectSemester[8][i]);

                    }

                    break;

            }

        }
        private void AddCheckBox(string content)
        {
            CheckBox checkBox = new CheckBox
            {
                Content = content,
                Margin = new Thickness(5),
                Name = content,
            };
            checkBoxPanel.Children.Add(checkBox);
        }


    }
}