using Delegates_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Predicate
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var result = nums.FindAll(m => m % 2 == 0 && m > 5);
            //Console.WriteLine(result.Count);
            //Console.WriteLine(SumOfNumberDividedBy3And7(Division, nums));
            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 , 9, 21};
            //Console.WriteLine(nums.FindAll(m => m % 3 == 0 && m % 7 == 0).Sum(m=>m));
            #endregion
            #region Task2
            List<Person> list1 = new List<Person>();
            list1.Add(new Person { Salary = 5000, Name = "CJ", Surname = "Homie", Address = "Groove Street"});
            list1.Add(new Person { Salary = 2000, Name = "Mark", Surname = "Albertson", Address = "NYC Square"});
            list1.Add(new Person { Salary = 4000, Name = "Benjamin", Surname = "Franklin", Address = "Wall Street"});
            list1.Add(new Person { Salary = 789, Name = "David", Surname = "Hater", Address = "Hollywood"});
            list1.Add(new Person { Salary = 457, Name = "Alex", Surname = "Perreira", Address = "Los Angeles"});




            #endregion


            #region Task3
            //List<Book> list2 = new List<Book>();

            //list2.Add(new Book { Author = "Nizami", Books = "book1" });
            //list2.Add(new Book { Author = "Nizami", Books = "book2" });
            //list2.Add(new Book { Author = "Jalil", Books = "book3" });
            //list2.Add(new Book { Author = "Mammad", Books = "book4" });
            //list2.Add(new Book { Author = "Nizami", Books = "book5" });

            //ShowAuthors(SelectBookAuthors, list2);


            #endregion


            #region Task4
            List<Employee> list3 = new List<Employee>() { };
            list3.Add(new Employee { Age = 24, SalaryEmp = 1500 });
            list3.Add(new Employee { Age = 30, SalaryEmp = 2500 });
            list3.Add(new Employee { Age = 35, SalaryEmp = 3000 });
            list3.Add(new Employee { Age = 19, SalaryEmp = 5000 });
            list3.Add(new Employee { Age = 45, SalaryEmp = 3000 });


            #endregion

            #region ClassPractice
            //ShowString(StringToLower, "QWewqweWEQW", 18);
            //ShowString(StringToUpper, "QWewqweWEQW", 18);


            //ChangeString func = StringToLower;
            //func += delegate (string str, int age)
            //{
            //    Console.WriteLine(str.ToUpper() + "- Age :" + age);
            //};
            //func += (str, age) => Console.WriteLine(str.ToUpper() + "- Age :" + age);
            //func.Invoke("MsmsMMs", 18);

            //Action<string, int> action = StringToLower;
            //action.Invoke("Orxan", 66);

            //    string name = "Nihad";

            //    ShowString(StringToUpper, name, 25);

            //    Action action = Test;
            //    action.Invoke();


            //ShowPower(CalculatePower, 2, 3);

            //Action<int, int> action = CalculatePower;
            //action(2, 3);


            //List<int> str = new List<int>() { 1, 5, 1, 4, 4, 4, 4, 64, 6, 7 };
            //int[] str = { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine(ShowStringLength(GetStringLength, "string"));

            //Func<string, int> func = GetStringLength;
            //Console.WriteLine(func.Invoke("String"));


            //Console.WriteLine(ShowFactorial(CalculateFactorial, 5));

            //Func<int, int> func = CalculateFactorial;
            //Console.WriteLine(func.Invoke(5));
            #endregion
        }
        #region Task2
        //public delegate void Salaries(int money);

        //public static void CheckSalaryInformation(List<Person> list)
        //{
        //    foreach (var item in list)
        //    {
        //        if (item.Salary > 1000)
        //        {
        //            Console.WriteLine(item.Name + " " + item.Surname + " " + item.Address);
        //        }
        //    }

        //}

        //public static void ShowInfo(Salaries sal, List<Person> list)
        //{
        //    sal(list);
        //}
        #endregion
        #region Task3
        //public delegate void Authors(string aut);

        //public static void SelectBookAuthors(List<Book> list2)
        //{
        //    foreach (var item in list2)
        //    {
        //        if (item.Author == "Nizami")
        //        {
        //            Console.WriteLine(item.Books);
        //        }
        //    }
        //}

        //public static void ShowAuthors(Authors authors, List<Book> list2)
        //{
        //    authors(list2);
        //}
        #endregion
        #region Task4
        public delegate void AAA(string aAAut);

        public static void BBB(List<Employee> list3)
        {
            foreach (var item in list3)
            {
                int count = 0;
                int sum = 0;
                if (item.Age > 20 && item.Age < 40)
                {
                    sum += item.SalaryEmp;
                    count++;
                    Console.WriteLine(sum/count);
                }
            }
        }

        //public static void ShowAuthors(Authors authors, List<Book> list2)
        //{
        //    authors(list2);
        //}
        #endregion










        #region ClassPractice
        public static  int CalculateFactorial(int n)
        {
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                count *= i;
            }
            return count;
        }

        public static  int ShowFactorial(Func<int, int> func, int factorial)
        {
            return func(factorial);
        }




        public static int GetStringLength(string str)
        {
            return str.Length;
        }

        public static int ShowStringLength(/*StringLength func*/Func<string, int> func, string str)
        {
            return func(str);
        }



        public static void CalculatePower(int a, int b)
        {
            Console.WriteLine(Math.Pow(a,b));
        }

        public static void ShowPower(Action<int, int> action, int number1, int number2)
        {
            action(number1, number2);
        }




        public static void Test()
        {
            Console.WriteLine("test");
        }

        //public delegate void ChangeString(string str, int age);


        public static void StringToLower(string str, int age)
        {
            Console.WriteLine(str.ToLower() + "-" + age);
        }

        public static void StringToUpper(string str, int age)
        {
            Console.WriteLine(str.ToUpper() + "-" + age);
        }


        //public static void ShowString(ChangeString func, string str, int age)
        //{
        //    func(str, age);
        //}

        public static void ShowString(Action<string, int> func, string str, int age)
        {
            func(str, age);
        }




        public static bool Division(int num)
        {
            return num % 3 == 0 && num % 7 == 0;
        }

        public static int SumOfNumberDividedBy3And7(Predicate<int> predicate, List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }
            return sum;
        }

        public static bool CheckOddNums(int number)
        {
            return number % 2 != 0;
        }

        public static bool CheckEvenNums(int number)
        {
            return number % 2 == 0;
        }


        public static bool CheckGreaterThanFour(int number)
        {
            return number > 4;
        }

        //public static int Sum(CheckNums predicate, int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;


        //}
        #endregion

    }


}
