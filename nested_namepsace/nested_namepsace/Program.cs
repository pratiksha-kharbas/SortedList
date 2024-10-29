//namespace contain class which can preddefined userdefined
//namepspace can be used to access that contain class
//we can access namspace using dot
//Itis container that can contain class, interface, struct, enum, other namepsace


using System;
namespace nested_namespace
{
    namespace program
    {
        public class Program
        {
            public static void dispaly()
            {
                Console.WriteLine("nested proram");
            }
            public void display1()
            {
                Console.WriteLine("the nonstatic method");
            }
        }
    }
}
class add()
 {
    static void Main(string[] args)
      {
         nested_namespace.program.Program.dispaly();   // we call the nested namespace method dirctlt
        var newinstance =new nested_namespace.program.Program();
        newinstance.display1();
      }
}
   