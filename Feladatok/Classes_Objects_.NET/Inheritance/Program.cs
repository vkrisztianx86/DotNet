using static Inheritance.Human;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human newhuman = new Human();
            newhuman.Age = 10;
            Console.WriteLine(newhuman);
            newhuman.Read();
            newhuman.Move(10);
            Console.Write("\n");

            Student student = new Student();
            Console.WriteLine(student);
            student.Age = 20;
            student.Read();
            student.Move(20);
            student.Move(33);
            Console.Write("\n");

            Teacher teacher = new Teacher();
            Console.WriteLine(teacher);
            teacher.Age = 30;
            teacher.Read();
            teacher.Move(30);
            teacher.Moving(44);
            teacher.Moving(66);
            Console.Write("\n");

            Auto a = new Auto();
            Console.WriteLine(a);
            a.Move(11);
            a.Moving(55);
            a.Moving(66);
            Console.Write("\n");
            Human experimentHuman = teacher;
            experimentHuman.Read();
            //teacher.Teach();
            ((Teacher) experimentHuman).Teach();
            //Teacher experimentTeacher = new Human();

            List<Human> humans = new List<Human>();
            humans.Add(experimentHuman);
            humans.Add(newhuman);
            humans.Add(student);
            humans.Add(teacher);
            

            foreach (Human human in humans)
            {
                human.Read();
                //((Teacher)human).Teach();

            }

            List<IMoving> imove = new List<IMoving>();
            imove.Add(experimentHuman);
            imove.Add(newhuman);
            imove.Add(student);
            imove.Add(teacher);
            imove.Add(a);

            foreach (IMoving h in imove)
            {
                h.Moving(66);

            }
            //Class1 studentclass = new Class1();
            //Console.WriteLine(studentclass);
        }
    }
}
