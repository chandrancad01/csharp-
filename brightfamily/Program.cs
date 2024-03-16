namespace brightfamily{
    class Program
    {
        static void Main(string[] args){
        bright bt=new bright(); 
        Console.WriteLine("Ferrosh is branch manager of bright service");
         Console.WriteLine("Karthick is branch staff in bright service");
        Console.WriteLine("I HAVE " +bt.getBranchmanager());
        Console.WriteLine("I HAVE " +bt.getBranchstaff());
        Console.WriteLine("I HAVE " +bt.getStudent());       
        Console.WriteLine("******************************");
ai ais=new ai();
        Console.WriteLine("Hi I am ai batch student");
 
       Console.WriteLine("I can access to my class "+bt.getcourses()+"courses");
        Console.WriteLine("******************************");
        
cad cadg=new cad();
        Console.WriteLine("Hi I am cad batch student");     
 Console.WriteLine("******************************");
        
        student Std=new student();
        Console.WriteLine("I have a using a some tools"); 
        }
    }
}