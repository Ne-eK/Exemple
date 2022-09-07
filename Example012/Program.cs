/*
void Metod (string msg, int count) {
    int i = 0;
    while (i < count) {
        Console.WriteLine(msg);
        i++;
    }
}

Metod(count: 4, msg: "new text");
*/
////////////////////////////////////////////////////////////////////
/*
int Metod2 (){
    return DateTime.Now.Year;
}
int year = Metod2();
Console.WriteLine(year);
*/
/////////////////////////////////////////////////////////////////////
/*
string Metod3 (int count, string c) {
    int i = 0;
    string result = String.Empty;
    while (i < count) {
        result = result + c;
        i++;
    }
    return result;
}

Console.WriteLine(Metod3(c: "Yes", count: 3));
*/
//////////////////////////////////////////////////////////////////////
/*
for (int i = 2; i <= 9; i++) {
    for (int j = 2; j <= 10; j++) {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(" ");
}
*/
////////////////////////////////////////////////////////////////////
/*
string text = "Привет! Как дела?";

string Replace (string text, char OldValue, char NewValue) {
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++){
        if(text[i] == OldValue) result = result + NewValue;
        else result = result + text[i];
    }
    return result;
}
string NewText = Replace(text, ' ', '/');
Console.WriteLine(NewText);
*/
//////////////////////////////////////////////////////////////////////
// Сортировка выбором

int[] arr = {1, 2, 3, 4, 5, 6, 7, 80, 9, 10};

void PrintArray(int[] Mass){
    for (int i = 0; i < Mass.Length; i++){
        Console.Write(Mass[i] + " ");
    }
    Console.WriteLine();
}

void Sort(int[] Mass){
    for (int i = 0; i < Mass.Length; i++){
        int MinPosition = i;
        for (int j = i + 1; j < Mass.Length; j++) {
            if (Mass[j] < Mass[MinPosition]) MinPosition = j;
            }
        int temp = Mass[i];
        Mass[i] = Mass[MinPosition];
        Mass[MinPosition] = temp;
    }
}

PrintArray(arr);
Sort(arr);
PrintArray(arr);


