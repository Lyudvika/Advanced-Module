using ImplementingCustomList;

CustomList customList = new CustomList();
customList.Add(5);
customList.Add(6);
//5 6

customList.RemoveAt(1);
//5

Console.WriteLine(customList.Contains(0)); //false
Console.WriteLine(customList.Contains(5)); //true
Console.WriteLine(customList.Contains(6));  //false

customList.Add(9);  //5 9 
customList.Swap(0, 1);  //9 5 

customList.Add(6);  //9 5 6 
customList.Add(7);  //9 5 6 7

customList.RemoveAt(0); // 5 6 7
customList.RemoveAt(1); // 5 7

customList.Insert(1, 5);    //5 5 7

customList.Swap(0, 5);  //Invalid index.

Console.WriteLine(customList);
Console.WriteLine(customList.Count);    // 3