using tree_solution;

int small = 1;
int medium = 2;
int large = 3;
int xlarge = 4;
int xxlarge = 5;
int xxxlarge = 6;

BinarySearchTree sizes = new BinarySearchTree();
sizes.Insert(small);
sizes.Insert(medium);
sizes.Insert(large);
sizes.Insert(xlarge);
sizes.Insert(xxlarge);
sizes.Insert(xxxlarge);

List<int> sortedList = new List<int>();
foreach (var box in sizes)
{
    sortedList.Add(box);
}

BinarySearchTree sortedSizes = new BinarySearchTree();
InsertMiddle(sortedList.ToArray(),0,sortedList.Count - 1, sortedSizes);

Console.WriteLine($"Sizes Height: {sizes.GetHeight()}");
Console.WriteLine($"Sizes: {sizes}");
Console.WriteLine($"Sorted sizes: {sortedSizes.GetHeight()}");
Console.WriteLine($"Sorted sizes: {sortedSizes}");

// ------------------------------------------------------------------------------------------------

static void InsertMiddle(int[] sortedNumbers, int first, int last, BinarySearchTree bst) {
    if (sortedNumbers.Length != 0)
    {
        int middle = (first+last) / 2;
        bst.Insert(sortedNumbers[middle]);
        if ( middle != last)
        {
            InsertMiddle(sortedNumbers, first, middle, bst);
        }
        if (first != middle + 1)
        {
            InsertMiddle(sortedNumbers, middle + 1, last, bst);
        }
    }
}