int size = 8;
int [] array = new int [size];
for (int i = 0; i < array.Length;i++){
    array[i] = new Random().Next(1,100);
}
//foreach(int el in array){

//Console.WriteLine(el);}
string joinedarray = string.Join(",", array);
Console.WriteLine(joinedarray);

