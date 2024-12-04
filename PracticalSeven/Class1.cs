using System;
namespace LIB7_3
{
    public class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public void SetParams(string name, int age, string gender, double weight) // Метод для установки всех параметров
        {
            Name = name; //Устанавливает имя
            Age = age; //Устанавливает возраст
            Gender = gender; //Устанавливает пол
            Weight = weight; // Устанавлвиает возраст
        }
        public void SetParams(string name, int age) //Перегруженный метод для установки только имени и возраста
        {
            Name = name;
            Age = age;
        }
        public void RiseAge() //Метод на увеличение роста на 1 год
        {
            Age++;
        }
        public void RiseAgeTwo() //Метод на увеличение роста на 1 год
        {
            Age++;
        }
        public string CompareWeight(Man other)//параметр MAN other - имя параметра
        {
            if (this.Weight > other.Weight)
            {
                return $"{this.Name} тяжелее, чем {other.Name}";
            }
            else if (this.Weight < other.Weight)
            {
                return $"{this.Name}, легче чем {other.Name}";
            }
            return $"{this.Name} и {other.Name} весят одинаково";
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Пол: {Gender}, Вес: {Weight}";
        }

        //производный класс Student 7 практика

        public class Students : Man 
        { 
            public string Facultet {  get; set; } //Название факультета
            public int Course { get; set; } //Номер курса
            public string Group { get; set; } //Название группы

            //Прописываем метод для установки параметров студента, которые принимают необходимы параметры и вызывает метод SET PARAMS из класса Man который устанавливает общие параметры
            //Установка параметров студента, включая параметры SetParams
            public void SetStudentsParams(string name, int age, string gender, double weight, string facultet, int course, string group)
            {
                SetParams(name, age, gender, weight);
                Facultet = facultet;
                Course = course;
                Group = group;
            }

            //Метод изменения веса студента
            public void NewWeight(double newWeight)
            {
                Weight = newWeight;
            }
            //Метод для перехода на следующий курс
            public void NextCourse()
            {
                Course++;
            }
            //Метод для изменения группы студента
            public void NewGroup(string newGroup)
            {
                Group = newGroup;
            }
            //Переопределение метода для вывода информации о студенте
            public override string ToString()
            {
                return base.ToString() + $" Факультет - {Facultet}, Курс - {Course} Группа - {Group}";
            }
        }
    }

}
