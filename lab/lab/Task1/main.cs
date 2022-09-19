/*
 * Задание№1
Создайте класс, представляющий учебный класс ClassRoom.
Создайте класс ученик - Pupil.
В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса
базового класса Pupil и переопределите каждый из методов, в зависимости от
успеваемости ученика.
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен
состоять из 4 учеников.
Предусмотрите возможность того, что пользователь может передать 2 или 3
аргумента.
Выведите информацию о том, как все ученики экземпляра класса ClassRoom
умеют учиться, читать, писать, отдыхать.
*.
*/

using System.Diagnostics;

namespace Task1
{
    public class Program
    {
        public abstract class Pupil
        {

            private readonly string? Name;

            public Pupil(string? name)
            {
                Name = name;
            }

            public string? name {
                get { return this.Name; }
                }

            public abstract void Study();

            public abstract void Read();


            public abstract void Write();

            public abstract void Relax();

        }

        public class ExcellentPupil : Pupil
        {
            private readonly string? Name;
            
            public ExcellentPupil(string? name) : base(name)
            {
                this.Name = name;
            }

            public string? name
            {
                get { return this.Name; }
            }


            public override void Study()
            {
                Console.WriteLine(this.name);
                Console.WriteLine($"I study excellent!");
            }

            public override void Read()
            {
                Console.WriteLine("My speech is perfect! I'm the best reader ever!");
            }

            public override void Write()
            {
                Console.Write("My handwriting is beautiful. I know all the grammar!");
            }

            public override void Relax()
            {
                Console.WriteLine("I read books!\n");
            }
        }



        public class GoodPupil : Pupil
        {
            private readonly string? Name;



            public GoodPupil(string? name) : base(name)
            {
                Name = name;
            }


            public string? name
            {
                get { return this.Name; }
            }


            public override void Study()
                
            {
                Console.WriteLine(this.name);
                Console.WriteLine($"I study good!");
            }

            public override void Read()
            {
                Console.WriteLine("My speech is rather good! I'm good reader ever!");
            }

            public override void Write()
            {
                Console.Write("My handwriting is nice. I know a lot of grammar!");
            }

            public override void Relax()
            {
                Console.WriteLine("I watch TV and sometimes read books!\n");
            }
        }

        public class BadPupil : Pupil
        {


            private readonly string? Name;


            public BadPupil(string? name) : base(name)
            {
                Name = name;
            }

            public string? name
            {
                get { return this.Name; }
            }



            public override void Study()
            {
                Console.WriteLine(this.name);
                Console.WriteLine($"I don't care about study!");
            }

            public override void Read()
            {
                
                Console.WriteLine("My speech is fooking good! I'm the worst reader ever!");
            }

            public override void Write()
            {
                Console.Write("My handwriting is BAD . I know nothing!");
            }

            public override void Relax()
            {
                Console.WriteLine("I smoke weed & drink beer and eat KFC!\n");
            }
        }





        public class Classroom
        {

            List<Pupil> pupils = new List<Pupil>();

            public Classroom(params string?[] par)
            {
                for (int x = 0; x < par.Length; ++x)
                {
                    if ((x + 1) % 2 == 0)
                    {
                        this.pupils.Add(new GoodPupil(par[x]));
                    }
                    else if ((x +1) % 3 == 0)
                    {
                        this.pupils.Add(new ExcellentPupil(par[x]));
                    }
                    else
                    {
                        this.pupils.Add(new BadPupil(par[x]));
                    }
                }
            }

            public void StudentInfo(int index)
            {
                if (index < pupils.Count && index >= 0)
                {
                    pupils[index].Study();
                    pupils[index].Write();
                    pupils[index].Read();
                    pupils[index].Relax();
                }
            }


           

        }

       

        public static void Main(string[] argv)
        {

            

            Classroom classroom = new Classroom("Karl","Mark","Zoya");

            classroom.StudentInfo(0);
            classroom.StudentInfo(1);
            classroom.StudentInfo(2);


        }
    }
}