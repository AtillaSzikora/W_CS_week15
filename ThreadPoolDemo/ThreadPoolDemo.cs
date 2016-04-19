/*
Exercise 3: Use the ThreadPool to Queue Work Items 
In this lab, you will create an application that uses the thread pool to queue up methods to call on separate threads.
If you encounter a problem completing an exercise, the completed projects are available on the companion CD in the Code folder. 
1. Create a blank console application with the name ThreadPoolDemo. 
2. Include (or import for Visual Basic) the System.Threading namespace. 
3. Create a new method to simply display some text. Call it ShowMyText. Accept one parameter of type object, and call it state. 
4. Create a new string variable inside the ShowMyText method, and cast the state parameter to a string while storing it in the new text variable. 
5. Inside the ShowMyText method, write out the ManagedThreadId of the current thread and write the new string out to the console.
6. In the Main method of the console application, create a new instance of the WaitCallback delegate that refers to the ShowMyText method. 
7. Use the ThreadPool to queue up several calls to the WaitCallback delegate, specifying different strings as the object state. 
8. Build the project, and resolve any errors. Verify that the console application successfully shows each of the calls to the ShowMyText methods out to the console. 
Note that some of the work items are executed on different threads.
*/

using System;
using System.Threading;

namespace ThreadPoolDemo {
	class ThreadPoolDemo {

		static void Main(string[] args) {
			WaitCallback callback = new WaitCallback(ShowMyText);
			ThreadPool.QueueUserWorkItem(callback, "Hello");
			ThreadPool.QueueUserWorkItem(callback, "Hi");
			ThreadPool.QueueUserWorkItem(callback, "Heya");
			ThreadPool.QueueUserWorkItem(callback, "Goodbye");
			Console.Read(); }

		static void ShowMyText(object state) {
			string myText = (string)state;
			Console.WriteLine("Thread: {0} - {1}", Thread.CurrentThread.ManagedThreadId, myText); }
	}
}