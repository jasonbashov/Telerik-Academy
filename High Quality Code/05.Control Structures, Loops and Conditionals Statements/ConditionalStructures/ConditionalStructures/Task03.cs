bool expectedValueFound = false;
int loopIterationCounter = 100;

for (int i = 0; i < loopIterationCounter; i++)
{
    Console.WriteLine(array[i]);
    if (i % 10 == 0)
    {
        if (array[i] == expectedValue)
        {
			expectedValue = true;
            break;
        }
    }
}

// More code here

if (expectedValueFound)
{
    Console.WriteLine("Value Found");
}