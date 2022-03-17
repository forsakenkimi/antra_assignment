//1.when we want to store the information that should not be changed, we can use string to store like password or username
//when a string need modification often, we can use StringBuilder to achieve modification, because stringbuilder object has certain allocated memory based on number of character it contains, so stringbuilder object will not waste any memory. 

//2.Array class

//3.sort(Array)

//4.array.length

//5.NO we define the type of data that an array can store during the initialization. 

//6.The Clone() method returns a new array (a shallow copy) object containing all the elements in the original array.
//The CopyTo() method copies the elements into another existing array.
//Both perform a shallow copy.
//A shallow copy means the contents (each array element) contains references to the same object as the elements in the original array.

//int[] arr = new int[1];
//arr[0] = 1; 

//int[] arr1 = new int[5];
////object arrc = arr.Clone();
//arr.CopyTo(arr1,1);
//Console.WriteLine(arr1[1]);

//int[] arr = new int[10] {1,2,3,4,5,6,7,8,9,10};
//int[] arr2 = new int[arr.Length];
//int idx = 0;
//foreach (int i in arr) { 
//    arr2[idx] = i;
//    idx++;
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//for (int i = 0; i < arr2.Length; i++)
//{
//    Console.WriteLine(arr2[i]);
//}

//2
//using System.Collections;

//ArrayList arr = new ArrayList();
//while (true)
//{
//    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
//    string input = Console.ReadLine();
//    if (input[0] == '-' && input[1] == '-')
//    {
//        arr.Clear();
//    }
//    else if (input[0] == '+') { 
//        string item = input.Substring(2);
//        arr.Add(item);
//    }
//    else if (input[0] == '-')
//    {
//        arr.Remove(input.Substring(2));
//    }

//}
//for (int i = 0; i < arr.Count; i++) {
//    Console.WriteLine(arr[i]);      
//}

//3
//int n = 20;
//int[] res = new int[n];
//int idx = 0;
//for (int i = 2; i <= n; i++) {
//    bool flag = true;
//    for (int j = 2; j <= Math.Sqrt(i) + 1; j++) {
//        if (i % j == 0 & i != j) {
//            flag = false;
//        }
//    }
//    if (flag != false) {
//        res[idx] = i;
//        idx++;
//    }
//}

//for (int i = 0; i < n; i++) {
//    Console.WriteLine(res[i]);
//}
//int r = 3;
//int resIdx = 0;
//int[] arr = new int[] { 1, 2, 3, 4, 5 };
//int[] res = new int[arr.Length];
//for (int i = 0; i < arr.Length; i++) {
//    int sum = 0;
//    int idx = i;
//    int times = r ;
//    while (times != 0) {
//        idx = idx - 1;
//        if (idx < 0) {
//            idx = arr.Length - 1;
//        }
//        sum = sum + arr[idx];
//        times = times - 1;
//    }
//    res[resIdx] = sum;
//    resIdx++;
//}

//for (int i = 0; i < res.Length; i++) {
//    Console.WriteLine(res[i]);
//}

//5
//int[] arr = new int[] { 0,1,1,5,2,2,6,3,3};
//int max = 1;
//int num = arr[0];
//int curLength = 1;
//for (int i = 1; i < arr.Length; i++) {
//    if (arr[i] == arr[i - 1])
//    {
//        curLength++;
//    }
//    else if (arr[i] != arr[i - 1]) {
//        if (curLength > max) {
//            num = arr[i - 1];
//            max = curLength;
//        }
//        curLength = 1;
//    }
//}

//if (curLength > max)
//{
//    num = arr[arr.Length - 1];
//    max = curLength;
//}
//int[] res = new int[max];
//for (int i = 0; i < max; i++) {
//    res[i] = num;
//}

//for (int i = 0; i < max; i++)
//{
//    Console.WriteLine(res[i]);
//}

//7
//int[] arr = new int[] { 7,7,7,0,2,2,2,0,10,10,10 };
//int max = Int32.MinValue;
//int min = Int32.MaxValue;
//for (int i = 0; i < arr.Length; i++) {
//    if (arr[i] > max) {
//        max = arr[i];
//    }
//    if (arr[i] < min) {
//        min = arr[i];
//    }
//}
//int length = max - min + 1;
//int[] res = new int[length];
//int maxOccur = 0;
//HashSet<int> set = new HashSet<int>(); 
//for (int i = 0; i < arr.Length; i++) {
//    res[arr[i] - min] = res[arr[i] - min] + 1;
//    if (res[arr[i] - min] > maxOccur) {
//        maxOccur = res[arr[i] - min];
//    }
//}

//for (int i = 0; i < res.Length; i++) {
//    if (res[i] == maxOccur) {
//        set.Add(i + min);
//    }
//}
//int leftMost = 0;
//for (int i = 0; i < arr.Length; i++) {
//    if (set.Contains(arr[i])) {
//        leftMost = arr[i];
//        break;
//    }
//}
//foreach (int n in set) {
//    Console.WriteLine($"{n} occurs {maxOccur}");
//}
//Console.WriteLine($"left most {leftMost}");

//1
//string s = "abcde";
//for (int i = s.Length - 1; i > -1; i--) {
//    Console.Write(s[i]);
//}

//char[] arr = s.ToCharArray();
//Array.Reverse(arr);
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i]);
//}


//2
//string s = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
//s.Split( new char[] { ',', '.', ';', '=', '(', ')', '&', '[', ']', '"','\'});



//3
//string s = "Hi,exe? ABBA! Hog fully a string: ExE. Bob ExE";

//string[] sArray1 = s.Split(new char[6] { ',', '?', '!', ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
//HashSet<string> set = new HashSet<string>();
//foreach (string i in sArray1)
//{
//    int head = 0;
//    int tail = i.Length - 1;
//    if (i.Length > 0 && Char.IsLetter(i[0]))
//    {
//        Console.WriteLine(i);
//    }
//    else
//    {
//        bool flag = true;
//        while (head < tail)
//        {
//            if (i[head] == i[tail])
//            {
//                head++;
//                tail--;
//            }
//            else
//            {
//                flag = false;
//                break;
//            }
//        }
//        if (flag && set.Contains(i) != true)
//        {
//            Console.WriteLine(i);
//        }
//        set.Add(i);
//    }
//};

//4
//String s = "https://www.apple.com/iphone";
//String[] arr = s.Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);
//foreach (string i in arr)
//{
//    Console.WriteLine(i);
//}

//int idx = 0;
//if (arr[0].Contains("http") || arr[0].Contains("ftp"))
//{
//    Console.WriteLine("protocol = " + arr[idx]);
//    idx++;
//}
//else {
//    Console.WriteLine("protocol = ");
//}


//Console.WriteLine("sever = " + arr[idx]);
//idx++;

//if (idx == arr.Length) {
//    Console.WriteLine("resource = ");
//} else { 
//    Console.WriteLine("resource = " + arr[idx]);
//}



