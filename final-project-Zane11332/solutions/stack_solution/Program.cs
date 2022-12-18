Stack<string> landmarks = new Stack<string>();

landmarks.Push("Bent Tree");
landmarks.Push("Petrified Stump");
landmarks.Push("Flowery Meadow");
landmarks.Push("Waterfall");
landmarks.Push("Bolder Field");

int size = landmarks.Count;
Console.WriteLine("Directions Back:");
for (int i = 0; i < size; i++)
{
    Console.WriteLine(landmarks.Pop());
}







