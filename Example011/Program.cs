void FillArray (int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col) {
    int count = col.Length;
    int pos = 0;
    while (pos < count) {
        Console.WriteLine(col[pos]);
        pos++;
    }
}

int IndexOf(int[] collection, int find) {
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count) {
        if (collection[index] == find) {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int P = IndexOf(array, 4);
Console.WriteLine(P);

