/*
Exercise 2: Use a Mutex to Create a Single-Instance Application 
In this lab, you create a simple console application in which you will use a Mutex to ensure there is only one instance of the application running at any point. If you encounter a problem completing an exercise, the completed projects are available on the companion CD in the Code folder. 
1. Create a new console application called SingleInstance. 
2. In the main code file, include (or import for Visual Basic) System.Threading. 
3. In the main method of the console application, create a local Mutex variable and assign it a null (or Nothing in Visual Basic). 
4. Create a constant string to hold the name of the shared Mutex. Make the value “RUNMEONCE”. 
5. Create a try/catch block. 
6. Inside the try section of the try/catch block, call the Mutex.OpenExisting method, using the constant string defined in step 4 as the name of the Mutex. Then assign the result to the Mutex variable created in step 2. 
7. For the catch section of the try/catch block, catch a WaitHandleCannotBeOpenedException to determine that the named Mutex doesn’t exist. 
8. Next, test the Mutex variable created in step 2 for null (or Nothing in Visual Basic) to see whether the Mutex could be found.
9. If the Mutex was not found, create the Mutex with the constant string from step 
10. If the Mutex was found, close the Mutex variable and exit the application.
11. Build the project, and resolve any errors. Verify that only one instance of the application can be run at once.
*/

namespace SingleInstance {
	class SingleInstance {

		static void Main (string[] args) {

		}
	}
}
