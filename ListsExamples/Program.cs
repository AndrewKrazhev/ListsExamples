internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] array1 = new int [3];

        array1[0] = 5;
        array1[1] = 6;
        array1[2] = 7;


        int[] array2 = new int[3] 
        {
            1, 2, 23
        };  

        foreach (int i in array1) {
            Console.WriteLine(i);
        }

       
        List<string> exampeList = new List<string>() {"one", "two", "three"};



        List<int> intList = new List<int>(array2);


             List<string> exampeList2 = new List<string>() 
        {
            "***один***",
            "***два***",
            "***три***"

        };

        List<string> exampleList3 = new List<string>(exampeList2);

        List<string> exampleList4 = new List<string>(16);
        
        //Console.WriteLine(exampleList3[1]);
        exampleList3.Add("***четыре***");
        ///Console.WriteLine(exampleList3[3]);
        //exampleList3.Clear();
        
        foreach (var values in exampleList3)
        {
            Console.WriteLine(values);
        }

        




 


    }
}