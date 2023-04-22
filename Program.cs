void bubble_sort(int[] jsArray)
{
    int jsArrayL = jsArray.Length;
    for (int i = 0; i < jsArrayL; i++)
        for (int j = 0; j < jsArrayL; j++)
            if (jsArray[i] < jsArray[j])
            {
                (jsArray[j], jsArray[i]) = (jsArray[i], jsArray[j]);
            }
}

void sort_by_insertion(int[] jsArray)
{
    int jsArrayL = jsArray.Length;
    int i, j;
    int jsArrayNumb;
    for (i = 1; i < jsArrayL; i++)
    {
        jsArrayNumb = jsArray[i];
        j = i - 1;
        while (j >= 0 && jsArray[j] > jsArrayNumb)
        {
            jsArray[j + 1] = jsArray[j];
            j--;
        }
        jsArray[j + 1] = jsArrayNumb;
    }
}
void jsArrayDisplay(int[] jsArray)
{
    int jsArrayL = jsArray.Length;
    for (int i = 0; i < jsArrayL; i++)
        Console.Write(jsArray[i] + " ");
    Console.WriteLine();
}
Random random = new Random();
int[] jsArray = new int[20];
for (int i = 0; i < jsArray.Length; i++)
    jsArray[i] = random.Next(0, 100);

Console.WriteLine("Start of a sorting program\n");

jsArrayDisplay(jsArray);

Console.WriteLine("Bubble sort:");
bubble_sort(jsArray);
jsArrayDisplay(jsArray);

Console.WriteLine("Sorting by insertion:");
sort_by_insertion(jsArray);
jsArrayDisplay(jsArray);

Console.WriteLine("Made by Jakub \"xLoriki\" Soloducha");