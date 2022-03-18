// See https://aka.ms/new-console-template for more information


using System;

//1.
//internal members are visible in the same asembly
//public members are visible thoughtout the program
//private members are visible in class where they were defined
//protected members are visible in the same class or sub class

//2.
//static called by class
//const variable cant be changed
//readonly

//3.
//create an object

//4. It is possible to split the definition of a class, a struct, an interface or a method over two or more source files. When working on large projects, spreading a class over separate files enables multiple programmers to work on it at the same time.

//5. a data structure that contains a sequence of elements of different data types.

//6.  record keyword to define a reference type that provides built-in functionality for encapsulating data.

//7.
//overide happens in between subclass and parent class. Same method signature with different implementation
//overload happens in the same class. Methods with same name having different parameters and implememtation

//8. field is a variable
//property is a member taht provides mechanism to read, write, and compute the value of a private field.It is special methods called accessor

//9.
//set defaulf value

//10. Interface is a contract among the classes. It is a description of behavior that the implementation class will have.
//Interface has no constuctor. Interface cant have fields. Interface can only have public, abstract methods by default.Interface support mutilple inheratence. 

//11. public

//12 T

//13 T

//14 F

//15 F

//16 T

//17.T

//18.T

//19.F

//20.F

//21.T

//22.F

//23.T

public class hw
{

    //1.
    public void reverse(int[] arr)
    {
        int n = arr.Length;
        int[] res = new int[n];
        for (int i = 0; i < n; i++)
        {
            res[n - 1 - i] = arr[i];
        }

        for (int i = 0; i < n; i++)
        {
            arr[i] = res[i];
        }

    }

    public void PrintNumbers(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    public int Fibonacci(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        if (n == 2)
        {
            return 1;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        hw test = new hw();
        //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        //test.reverse(arr);
        //test.PrintNumbers(arr);


        //Console.WriteLine(test.Fibonacci(3));

        //Color c = new Color(1, 1, 1, 1);
        //Ball b = new Ball(1, c, 2);
        //b.Pop();
        //b.Size = 10;
        //for (int i = 0; i < 10; i++)
        //{
        //    b.Throw();
        //}

        //Console.WriteLine(b.ThrowTimes());

    }

}
//Designing and Building Classes

public class encap
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual void TestMethod()
    {

    }

}

public abstract class abstr
{
    public abstract void AbstractMethod();
}

public class inher : abstr
{
    public override void AbstractMethod()
    {
        Console.WriteLine("this is an implementation");
    }


}

public class poly : encap
{
    public override void TestMethod()
    {
        Console.WriteLine("override is run time polymorphism");
    }
}

public abstract class Person
{
    public int Age { get; set; }
    public string Name { get; set; }

    public List<string> address;

    public virtual decimal SalaryCal(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("salary can not be negative");
        }
        return n * 12;
    }

    public int old()
    {
        return Age;
    }

    public void setAddress(string s)
    {
        address.Add(s);
    }

    public List<string> getAddress()
    {
        return address;
    }
}

public class Student : Person
{
    private decimal deposit { get; set; }
    public override decimal SalaryCal(int n)
    {
        return base.SalaryCal(n) - 100;
    }

    public Dictionary<string, string> Course { get; set; }

    public int GetGpa()
    {
        int cur = 0;
        int gpa = -1;
        int sum = 0;
        int count = 0;
        foreach (string s in Course.Values)
        {
            count++;
            switch (s)
            {
                case "A":
                    cur = 5;
                    break;
                case "B":
                    cur = 4;
                    break;
                case "C":
                    cur = 3;
                    break;
                case "D":
                    cur = 2;
                    break;
                default:
                    cur = 1;
                    break;
            }

        }
        sum = sum + cur;
        gpa = sum / count;
        return gpa;
    }
}

public class Instructor : Person
{
    public DateTime joinDate { get; set; }

    public int experience { get; set; }
    private decimal deposit { get; set; }
    public override decimal SalaryCal(int n)
    {
        return base.SalaryCal(n) * (DateTime.Now - joinDate).Days;
    }

    public int departmentId { get; set; }


}


public class Course
{
    public List<Student> studentList { get; set; }
}

public class Department
{
    public Instructor instructor { get; set; }
    public decimal Budget { get; set; }

    public List<Course> course { get; set; }
}
public interface ICourseService
{

}
public interface IStudentService : IPersonService
{

}

public interface IInstructorService : IPersonService
{

}

public interface IDepartmentService
{

}

public interface IPersonService
{
    public abstract void PersonMethod();
}
//


public class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public int Alpha { get; set; }
    public Color(int i, int j, int k, int l)
    {
        Red = i;
        Green = j;
        Blue = k;
        Alpha = l;
    }
    public Color(int i, int j, int k)
    {
        Red = i;
        Green = j;
        Blue = k;
        Alpha = 255;
    }

    public Color()
    {

    }
    public int GrayScale()
    {
        return (Red + Green + Blue) / 3;
    }
}


public class Ball
{
    public int Size { get; set; }
    public Color? Color { get; set; }

    public int Number { get; set; }

    public Ball(int n, Color c, int m)
    {
        Size = n;
        Color = c;
        Number = m;
    }

    public void Pop()
    {
        this.Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
        {
            Number++;
        }

    }
    public int ThrowTimes()
    {
        return Number;
    }
}