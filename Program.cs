/* These are just tests of diferent commands from the reference */
using System;
using CSharp.Introduction;  
using MessageSource = CSharp.Introduction.HelloMessage;  
namespace delagate
{
	enum Color { Red, Blue, Green }
	class MainClass

	{
		delegate void SimpleDelegate();

		static void F() {  
			System.Console.WriteLine("HOLA");  
		}  
		public static void Main(string[] args)
		{
			SimpleDelegate d = new SimpleDelegate(F);  
			d(); 
			F ();

			MessageSource m = new MessageSource();  
			System.Console.WriteLine(m.Message); 
		}

	}
}

// HelloLibrary.cs  
namespace CSharp.Introduction  
{  
	public class HelloMessage  
	{  
		public string Message {  
			get {  
				return "hello, world";  
			}  
		}  
	}  
}  
