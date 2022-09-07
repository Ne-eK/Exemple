int[,] image = new int[,] {
    {0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 1, 0, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
    {0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 0, 1, 0, 0, 0, 0, 1, 0, 0},
    {0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
};

void Printimg (int[,] img) {
    for (int i = 0; i < img.GetLength(0); i++) {
        for (int j = 0; j < img.GetLength(1); j++) {
            if (img[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void Fillimg (int row, int col) {
    if (image[row, col] == 0) {
        image[row, col] = 1;
        Fillimg(row - 1, col);
        Fillimg(row, col - 1);
        Fillimg(row + 1, col);
        Fillimg(row, col +1);
    }
}

Printimg(image);
Fillimg(5,5);
Printimg(image);

