using System;
namespace LIB7_3
{
    public class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public void SetParams(string name, int age, string gender, double weight) // ����� ��� ��������� ���� ����������
        {
            Name = name; //������������� ���
            Age = age; //������������� �������
            Gender = gender; //������������� ���
            Weight = weight; // ������������� �������
        }
        public void SetParams(string name, int age) //������������� ����� ��� ��������� ������ ����� � ��������
        {
            Name = name;
            Age = age;
        }
        public void RiseAge() //����� �� ���������� ����� �� 1 ���
        {
            Age++;
        }
        public void RiseAgeTwo() //����� �� ���������� ����� �� 1 ���
        {
            Age++;
        }
        public string CompareWeight(Man other)//�������� MAN other - ��� ���������
        {
            if (this.Weight > other.Weight)
            {
                return $"{this.Name} �������, ��� {other.Name}";
            }
            else if (this.Weight < other.Weight)
            {
                return $"{this.Name}, ����� ��� {other.Name}";
            }
            return $"{this.Name} � {other.Name} ����� ���������";
        }
        public override string ToString()
        {
            return $"���: {Name}, �������: {Age}, ���: {Gender}, ���: {Weight}";
        }

        //����������� ����� Student

        public class Students : Man 
        { 
            public string Facultet {  get; set; }
            public int Course { get; set; }
            public string Group { get; set; }

            //��������� ���������� ��������, ������� ��������� SetParams
            public void SetStudentsParams(string name, int age, string gender, double weight, string facultet, int course, string group)
            {
                SetParams(name, age, gender, weight);
                Facultet = facultet;
                Course = course;
                Group = group;
            }

            //����� ��������� ���� ��������
            public void NewWeight(double newWeight)
            {
                Weight = newWeight;
            }
            //����� ��� �������� �� ��������� ����
            public void NextCourse()
            {
                Course++;
            }
            //����� ��� ��������� ������ ��������
            public void NewGroup(string newGroup)
            {
                Group = newGroup;
            }
            //��������������� ������ ��� ������ ���������� � ��������
            public override string ToString()
            {
                return base.ToString() + $" ��������� - {Facultet}, ���� - {Course} ������ - {Group}";
            }
        }
    }

}
