
class Progra{

  static void Main(string [] args){
    Console.WriteLine("Welcome To Classes");
    test1 tt=new test1();
    tt.PrintMSG();
    tt.PrintMSG2();

  }
}


public class test1{
  string name="CAD BATCH 01";

  public void PrintMSG(){
    Console.WriteLine(name);
  }

  public void PrintMSG2(){
    Console.WriteLine("hi ..! " + name);
  }

}
