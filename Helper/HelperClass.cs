using System.Diagnostics;

namespace StudentWebsite.Helper
{
    public class HelperClass
    {
        public void WriteaFile(string name,int cls,int roll)
        {
            var path = @"C:\Users\user\source\repos\StudentWebsite\Notepad\A.txt";
            StreamWriter ob = new StreamWriter(path, true);


            ob.WriteLine("Name     :"+name);
            ob.WriteLine("Class    :"+cls);
            ob.WriteLine("RollNo   :"+roll);

            ob.Close();
            Process.Start("notepad.exe", path );

        }
    }
}
