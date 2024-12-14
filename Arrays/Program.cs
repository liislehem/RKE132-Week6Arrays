
//massiivid vajalikud,e t salvestada andmeid 1 kohas.
//1 massiivis vaid 1 tüüpi andmed

//string[] fruit = { "apples", "bananas", "oranges" };

string[] fruit = new string[3];
//deklareerides tuleb kindel olla mitu ja millised andmed lähevad sinna, hiljem ei saa muuta. 

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in your array");

for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit)
{
    Console.WriteLine(element);
}
//foreach ei võimalda muuta andmeid. Saab vaid kuvada või kasutada

