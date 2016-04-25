/*
Use Visual Studio 2015 to create a blank console application. 
Write code to read the C:\boot.ini file,
and then write it to a file named bootutf7.txt using the UTF-7 encoding type.
For example, the following code (which requires the System.IO namespace) would work:
Run your application, and open the boot-utf7.txt file in Notepad.
If the file was translated correctly, Notepad will display it with some invalid characters
because Notepad does not support the UTF-7 encoding type.
*/

using System.IO;
using System.Text;

namespace UTF7Translator {
	class UTF7Translator {

		static void Main (string[] args) {
			StreamReader sr = new StreamReader(@"C:\GDrive\desktop.ini"); 
			StreamWriter sw = new StreamWriter(@"C:\GDrive\desktop-utf7.txt", false, Encoding.UTF7); 
			sw.WriteLine(sr.ReadToEnd()); 
			sw.Close(); 
			sr.Close(); }
	}
}