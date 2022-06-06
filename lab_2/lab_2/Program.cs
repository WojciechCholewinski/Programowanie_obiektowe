using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Treść zadania:   dirask.com/posts/WSEI-2021-2022-lato-labN-1-IS-Programowanie-obiektowe-lab-2-Dlk7w1
namespace Lab_02___Zadanie____zadanie_do_domu_
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher treacher = new Teacher("Maria Skłodowska", 50);

            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");

            student1.AddTask("Taks A", TaskStatus.Waiting);
            student1.AddTask("Taks B", TaskStatus.Waiting);
            student1.AddTask("Taks C", TaskStatus.Rejected);

            student2.AddTask("Taks A", TaskStatus.Waiting);
            student2.AddTask("Taks B", TaskStatus.Waiting);
            student2.AddTask("Taks C", TaskStatus.Rejected);

            student3.AddTask("Taks D", TaskStatus.Done);
            student3.AddTask("Taks E", TaskStatus.Waiting);
            student3.AddTask("Taks F", TaskStatus.Waiting);

            student3.UpdateTask(1, TaskStatus.Done);
            student3.UpdateTask(2, TaskStatus.Progress);

            Person[] persons = { treacher, student1, student2, student3 };
            Classroom classroom = new Classroom("Sala Komputerowa", persons);

            Console.WriteLine(classroom);

            Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false



        }
    }
    public class Person
    {
        protected string name;
        protected int age;

        public int Age { get => age; }
        public string Name { get => name; }

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public override bool Equals(object other)
        {
            if (other == null) return false;
            if (other == this) return true;

            if (!(other is Person person))
                return false;

            return object.Equals(this.name, person.name)
                && object.Equals(this.age, person.age);
        }

        public override string ToString()
        {
            return $"{this.name} ({this.age} y.o.)";
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////

    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {

        }

        public override string ToString()
        {
            return "Treacher: " + base.ToString();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////

    public class Student : Person
    {
        protected string group;
        //protected List<Task> tasks;
        protected List<Task> tasks = new List<Task>();

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public Student(string name, int age, string group) : base(name, age)
        {
            Group = group;
        }
        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            Group = group;
            this.tasks = tasks;
        } 
        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            tasks.Add(new Task(taskName, taskStatus));
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            //tasks.RemoveAt(index);
            //tasks.Insert(index, new Task(Name, taskStatus));      //błąd - wyświetlało się imię i nazwisko

            this.tasks[index].Status = taskStatus;                  //dobrze
        }

        public override string ToString()
        {
            return $"Student: {base.ToString()}\nGroup: {group}\nTasks:\n 1. {tasks[0]}\n 2. {tasks[1]}\n 3. {tasks[2]}";
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////

    public class Classroom
    {
        private Person[] persons;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Classroom(string name, Person[] persons)
        {
            Name = name;
            this.persons = persons;
        }
        public override string ToString()
        {
            return $"Classroom: {name} \n\n{persons[0]}\n\n{persons[1]}\n\n{persons[2]}\n\n{persons[3]}\n\n\n";
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////

    public class Task
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private TaskStatus status;

        public TaskStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public Task(string name, TaskStatus status)
        {
            Name = name;
            Status = status;
        }

        //public override bool Equals(object other)
        //{
        //    if (other == null) return false;
        //    if (other == this) return true;

        //    if (!(other is Task task)) return false;

        //    return Object.Equals(this.Name, name)           //błędy
        //        && Object.Equals(this.Status, status);      //błędy
        //}

        public override string ToString()
        {
            return $"{this.name} [ {this.status} ]";
        }

    }

    /////////////////////////////////////////////////////////////////////////////////////////////

    public enum TaskStatus
    {
        Waiting, Progress, Done, Rejected
    }
}
