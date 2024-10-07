// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

// Console.WriteLine("Hello, World!");

/* To create a new project 
   === dotnet new console -n MyApp
*/
// string str = "gautampandey";
/*
String Interpolation $
Trim , TrimStart, TrimEnd
Replace,
Contains,
StartWith,
EndWith,

*/



// 

// string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// string xyz = "0123456789";
// Console.WriteLine($"{abc} , {xyz}");
// int ab = int.MaxValue;

// Console.WriteLine($"Maximum value of integer: {ab}");



// string str = "google";
// Dictionary<char, int> dict = new Dictionary<char, int>();

// foreach (char c in str.ToCharArray())
// {
//     if(dict.ContainsKey(c)){
//         dict[c] = dict.GetValueOrDefault(c,0)+1;
//     }else{
//         dict.Add(c,1);
//     }
// }
// List<char> charList = new List<char>();
// foreach( var i in dict){
//     if(i.Value > 1){
//         charList.Add(i.Key);
//     }
// }

// foreach (char c in charList)
// {
//     Console.Write($"{c}");
// }

// string str = "this is me and my laptop";

// string[] list = str.Split(" ");

// foreach (string s in list)
// {
//     string rs = reverseString(s);
//     Console.Write(rs + " ");
// }

// string reverseString(string str)
// {
//     string st = "";
//     for (int i = str.Length - 1; i >= 0; i--)
//     {
//         st = st + str[i];
//     }
//     return st;
// }


// string pa = "papa kahte hai beta nam krega";


// Dictionary<char, int> dict = new Dictionary<char, int>();

// foreach (char c in pa.ToCharArray())
// {
//     if(dict.ContainsKey(c)){
//         dict[c] = dict.GetValueOrDefault(c,0)+1;
//     }
//     else{
//         dict.Add(c,1);
//     }
// }
// char ch ='x' ;

// int max = int.MinValue;

// foreach( var i in dict){
//     if(i.Value > max){
//         max = i.Value;
//         ch = i.Key;
//     }
// }
// Console.WriteLine(ch+" "+ max);

// get all possible substrings


// string str = "gautam";

// var => local variable type interference

// var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// list.Remove(1);// this will work in both the cases

// If you want to print a number from the right side.

// Console.WriteLine(list[^1]);// It shows first number from the last.
// foreach(var i in list[2..5]){// 2 inclusive and 5 exclusive.
//     Console.WriteLine(i);
// }

// var names = new int[]{1, 2, 3, 4, 5};
// names = [..names, 10, 11, 12, 13];

// foreach(var i in names){
//     Console.WriteLine(i);
// }

/* Link method syntax vs Query syntax */

/*Query syntax
IEnumerab1e<int> scoreQuery =
from score in scores
where score > 80
orderby score descending
select score;
*/

/* Method syntax
var scoreQuery2 = scores.Where(s => s > 80).
                         OrderByDescending(s => s);

*/

/*
List<int> nums = [0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
//Query way
IEnumerable values = from num in nums
                      where num % 2 == 0
                      select num;
foreach( int val in values){
    Console.Write(val+" ");
}
// Method way
IEnumerable outputs = nums.Where(item => item%2 ==0);

foreach( int output in outputs){
    Console.Write(output+" ");
}
*/
// finding positive number in range 1 to 11
/*

List<int> nums = [-1, 2, 4, -80, 70, 60 , 30 , 40, -20, -10, -12, -10,-11, -10,1];

var positiveNums = nums[1..11].Where(item => item > 0);

foreach(int posNum in positiveNums){
    Console.Write(posNum+" ");
}

*/


/*
// similar to map in js
List<int> nums = [9, 8, 6, 5];
IEnumerable<int> squareValues = nums.Select(item => item* item);

foreach(int sqrVal in squareValues){
    Console.Write(sqrVal+" ");
}
*/



// int a = 0;
// Person p1 = new("John", "Doe", new DateOnly(1990, 01, 01));

// public class Person
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public DateOnly BirthDate { get; set; }

//     public Person(string FirstName, string LastName, DateOnly BirthDate)
//     {
//         this.FirstName = FirstName;
//         this.LastName = LastName;
//         this.BirthDate = BirthDate;
//     }

// }

// public class Gautam : Person
// {
//     public string Address { get; set; }
//     public Gautam(string firstName, string lastName, DateOnly birthDate, string Address) : base(firstName, lastName, birthDate)
//     {
//         this.Address = Address;
//     }


// }


// public class Person
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public DateOnly BirthDate { get; set; }

//     // Constructor to initialize the properties
//     public Person(string firstName, string lastName, DateOnly birthDate)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//         BirthDate = birthDate;
//     }
// }

// // Creating an instance of Person
// Person p1 = new Person("John", "Doe", new DateOnly(1990, 01, 01));

/* Abstract class */

// public abstract class Abc
// {
//     public abstract void print();
// }

// public class Xyz : Abc
// {
//     public override void print()
//     {
//         throw new NotImplementedException();
//     }
// }

// Xyz xy = new();
// Console.WriteLine(xy.doSomething());
// interface Abc{
//     public int doSomething();
// }
// public class Xyz:Abc{
//     public int doSomething(){
//         return 10;
//     }
// }


// first I need to create objects of Books and Magzines


LibraryItem[] books = new Book[10];
string[] bookTitles =
        [
            "To Kill a Mockingbird,Gautam",
            "1984,Gautam",
            "The Great Gatsby,Gautam",
            "The Catcher in the Rye,Gautam",
            "Moby-Dick,Gautam",
            "Pride and Prejudice,Gautam",
            "War and Peace,Gautam",
            "The Lord of the Rings,Gautam",
            "Harry Potter and the Sorcerer's Stone,Gautam",
            "The Hobbit,Gautam"
        ];

for (int i = 0; i < 10; i++)
{
    string[] arr = bookTitles[i].Split(",");
    DateOnly dateOnly = new();
    books[i] = new Book(arr[0], arr[1], dateOnly);
}



LibraryItem[] magazines = new Magazines[10];
List<string> magazineTitles = new List<string>()
        {
            "National Geographic",
            "TIME",
            "The New Yorker",
            "Forbes",
            "Vogue",
            "The Economist",
            "Harvard Business Review",
            "Scientific American",
            "Wired",
            "Popular Science"
        };

for (int i = 0; i < 10; i++)
{
    magazines[i] = new Magazines($"{10 + i}", "February", magazineTitles[i]);
}

string[] name = ["Gautam", "Nitesh", "Harendra", "Vikas", "Luvkush", "Hareram", "Aditya", "Shiv", "Sumiteshwar", "Muna"];

Patrons[] patrons = new Patrons[10];
for (int i = 0; i < 10; i++)
{
    patrons[i] = new Patrons(name[i]);
}

Library booksLibrary = new Library(books.ToList());
Library magazinesLibrary = new Library(magazines.ToList());
// Now I have two libraries books and magazines



// books[0].BorrowItem();
// booksLibrary.showBorrowedItems();

// magazines[0].BorrowItem();
// magazinesLibrary.showBorrowedItems();



// foreach( var book in books){
//     Console.WriteLine(book.Title);
// }







