internal class Program
{
    private static void Main(string[] args)
    {
        List<int> mylist = new List<int>(); // khoi tao list trong
        for (int i = 0;i < 10;i++){
            mylist.Add(i);
        }
        foreach (var item in mylist){
            Console.Write(item+",");
        }
        mylist.RemoveAt(5);
        Console.WriteLine();
        foreach (var item in mylist){
            Console.Write(item+",");
        }
    }
    // count so phan tu bao gom trong list
    // Add them phan tu vao list
    // Removeat(index)
    // clear xoa toan bo list
}