using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {

///<summary> 
/// Method that returns a list of numbers from 1 to 100. 
/// where a number is a multiple of 3, output “multiple of 3” 
/// where the number ends in a 6, output “ends in 6”.
///</summary>
///<returns>List<String> value like "6, multiple of 3, ends in 6".</returns>
static List<String> createList(){
    List<String> list = new List<String>(); // List for return.
    string output = String.Empty; // This is the value of the list.    
    for (int i = 1; i < 101; i++)
    {
        output = i.ToString();
        if((i%3)== 0){
            output += ", multiple of 3";
        }

        if((i%10)== 6){
            output += ", ends in 6";
        }
        list.Add(output);
    }
    return list;
}

        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            list = createList();
            list.ForEach(Console.WriteLine);
        }


    }
}
