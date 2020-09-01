using System;

namespace largestNoOfSeries
{
    class Array
    {
        static void Main(string[] args)
        {
            int number,large=0;

           while(true)
           {
    
             Console.WriteLine("Enter the number");
             number = Convert.ToInt32(Console.ReadLine());
             
                    if(number>large)
                    {
                        large=number;
                    }     
            if(number==-1)
            break;
           }  
            Console.WriteLine("The largest number is " +large); 
        }
    }
}
