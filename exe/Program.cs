string[] arrayA = new string[] {"23","pip","cat","moscow","-)34"};
string[] arrayB = new string[arrayA.Length];

void NewArray(string[] arrayA, string[] arrayB )
{   
    int count = 0;

   for(int i = 0; i < arrayA.Length; i++)
   {
        if(arrayA[i].Length <= 3)
        {
            arrayB[count] = arrayA[i];
            count++;
        }
   }
   
   
}

void PrintArray(string[]array)  
{
    for( var i = 0; i < array.Length; i++)
    {
        Console.Write($" '{array[i]}' ");
    }
}


NewArray(arrayA, arrayB);
PrintArray(arrayA);

Console.WriteLine();

PrintArray(arrayB);


