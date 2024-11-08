using LIB7_3;
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
using static LIB7_3.Man;

namespace PracticalSeven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Man person; //Создает поле person типа Man для хранения информации о человеке
        private Students student;
        public MainWindow()
        {
            InitializeComponent();
            person = new Man();
            student = new Students();
        }
        private void Exit_Click(object sender, RoutedEventArgs e) //Создание кнопки для меню "Справка" - выход
        {
            Application.Current.Shutdown();
        }

        // Обработчик кнопки "О программе"
        private void About_Click(object sender, RoutedEventArgs e) //Создание кнопки для меню "Справка" - о программе
        {
            MessageBox.Show("Разработчик: Сухомяткина Ксения\nНомер работы: 7\nЗадание: Использовать класс Man (человек), с полями: имя, возраст, пол и вес. Создать производный класс Student, имеющий характеристики: факультет, курс, группа. Определить методы изменения возраста, веса, перехода на следующий курс, перевода в другую группу", "О программе");
        }
        private void SetParams_Click(object sender, RoutedEventArgs e)
        {
            person.SetParams(NameTB.Text, int.Parse(AgeTB.Text), GenderTB.Text, double.Parse(WeightTB.Text));//Передает введеные методы в SetParams
            OutputTB.Text = person.ToString();//Обновляет текст в текстовом блоке, выводя информацию о человеке
        }
        private void SetParams_2_Click(object sender, RoutedEventArgs e)
        {
            person.SetParams(NameTB_2.Text, int.Parse(AgeTB_2.Text), GenderTB_2.Text, double.Parse(WeightTB_2.Text));//Передает введеные методы в SetParams
            OutputTB_2.Text = person.ToString();//Обновляет текст в текстовом блоке, выводя информацию о человеке
        }
        private void CompareWeightBTN_Click(object sender, RoutedEventArgs e)
        {
            string otherName = NameTB_2.Text;
            int otherAge = int.Parse(AgeTB_2.Text);
            string otherGender = GenderTB_2.Text;
            double otherWeight = double.Parse(WeightTB_2.Text);
            Man otherPerson = new Man();
            otherPerson.SetParams(otherName, otherAge, otherGender, otherWeight);

            //сравнение веса
            string compareResult = person.CompareWeight(otherPerson);
            OutputTB_3.Text = compareResult;
        }
        private void RiseAgeBTN_Click(object sender, RoutedEventArgs e)
        {
            person.RiseAge();
            OutputTB_3.Text = person.ToString();
        }

        private void SetStudentsParams_Click(object sender, RoutedEventArgs e)
        {
            student.SetStudentsParams(NameTB.Text, int.Parse(AgeTB.Text), GenderTB.Text, double.Parse(WeightTB.Text), fTB.Text, int.Parse(kTB.Text), gTB.Text);
            OutputTB.Text = student.ToString();
        }

        private void NextCourse_Click(object sender, RoutedEventArgs e)
        {
            student.NextCourse();
            OutputTB.Text = student.ToString();
        }

        private void EditGroup_Click(object sender, RoutedEventArgs e)
        {
            student.NewGroup(gTB.Text);
            OutputTB.Text = student.ToString();
        }
    }
}