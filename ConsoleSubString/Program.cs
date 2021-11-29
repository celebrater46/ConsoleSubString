// See https://aka.ms/new-console-template for more information

using System;

// Console.WriteLine("Hello, World!");
class Sample
{
    static void Main()
    {
        string str = "第三世界収容所";
        Console.WriteLine(str.Substring(0, 1));
        Console.WriteLine(str.Substring(1, 5));
        Console.WriteLine(str.Substring(6));
        // Console.ReadKey();
        
        string src_str = "白金グループ";
        // string target_str = "白金"; // 白金
        string target_str = "グループ"; // グループ
        // Console.WriteLine(src_str.Substring(src_str.IndexOf(target_str), target_str.Length)); 
        Console.WriteLine(src_str.Substring(0, src_str.IndexOf(target_str))); 
        // Console.WriteLine(src_str.Substring(2, target_str.Length)); 
        Console.ReadKey();
    }
}