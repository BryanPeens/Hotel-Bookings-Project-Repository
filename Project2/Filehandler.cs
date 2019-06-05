using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project2
{
    class Filehandler
    {
        FileStream fs;
        StreamReader sr;
        StreamWriter wr;

        public void Checkfile(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show("Could not open Suites.sts file - check file");
            }
        }
        public List<string> Readfile(string filename)
        {
            Checkfile(filename);
            List<string> lines = new List<string>();
            fs = new FileStream(filename,FileMode.Open,FileAccess.Read);
            sr = new StreamReader(fs);
            try
            {
                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
            return lines;
        }
        public void Writefile(string filename, List<string> lines, bool option)
        {
            //Checkfile(filename);
            fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            wr = new StreamWriter(fs);
            try
            {
                foreach (string item in lines)
                {
                    wr.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wr.Close();
                fs.Close();
            }
        }
    }
}
