using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    class Validation
    {
     
        public static bool Text(params string[] text)
        {
            int i = 0;
            foreach(string item in text)
            {
                if (string.IsNullOrEmpty(text[i]) || string.IsNullOrWhiteSpace(text[i++]))
                {
                    return false;
                }
                
            }
            
            return true;
        }
        public static bool IsDouble(params string[] strings)
        {
            double Number;
            foreach (string str in strings)
            {
                if (double.TryParse(str, out Number)==false) return false;
            }
            return true;
        }
        public static bool IsNumber(string str)
        {
            int Number;
            if (int.TryParse(str, out Number)) return true;
            return false;
        }
        public static bool DoesStringContainsDigit(string str)
        {
            try
            {

                foreach (char item in str)
                {
                    if (IsNumber(item.ToString()))
                    {
                        return true;

                    }
                }
            }
            catch
            {
                
            }

            return false;
        }
        public static bool ValidEmail(string email)
        {
            string[] domains = { ".com", ".net", ".edu", ".co","org", ".COM", ".NET", ".EDU", ".CO","ORG"};

            if (email.Contains("@"))
            {
                string[] str = email.Split('@');
                if (str.Length == 2)
                {
                    foreach (string domain in domains)
                    {
                        if (str[1].EndsWith(domain))
                        {
                            return true;
                        }
                    }
                }

            }



            return false;
        }
        public static bool ValidCgpa(string cgpa)
        {
            if (IsDouble(cgpa))
            {
                if (Convert.ToDouble(cgpa) <= 4.0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ValidGpa(string cgpa)
        {
            if (IsDouble(cgpa))
            {
                if (Convert.ToDouble(cgpa) <= 5.0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
