namespace Utility;
using System.IO;

public class FileIOManager{

     public  void ReadData( ){
        string data =File.ReadAllText(@"C:\Users\IET\Pictures\DOT_NET\Threading\product.json");

     }

    public void WriteData(string data){
        // string data=" ";
        File.WriteAllText(@"C:\Users\IET\Pictures\DOT_NET\Threading\product.json",data);

    }
}