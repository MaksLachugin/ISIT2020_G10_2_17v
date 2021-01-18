using System;
using System.IO;
using System.Windows.Forms;

namespace UtilsPack
{
    public class MyDialogFile
    {

        public static string SelectTextFileAndReturnPath(string path)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = path;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;


                }
            }
            return "";
        }

        public static string SelectTextFileAndReturnPath()
        {
            return SelectTextFileAndReturnPath(BasePathInProject());
        }

        public static string CurrentPath() {
            string path = Directory.GetCurrentDirectory();
            return path;
        }

        public static string BasePathInProject() {
            string s = CurrentPath();

            if (s.EndsWith("Debug")) {
                s = s.Substring(0, s.Length - 6);
            }
            if (s.EndsWith("Release"))
            {
                s = s.Substring(0, s.Length - 7);
            }
            if (s.EndsWith("bin\\"))
            {
                s = s.Substring(0, s.Length - 4);
            }

            return s;
        }
    }

}