using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticPassword
{
    class Generate
    {
        ArrayList chars;
        ArrayList specialChars;
        int passwordLength;
        Random rnd;

        public Generate(ArrayList specialChars, int passwordLength)
        {
            rnd = new Random();
            chars = new ArrayList();
            this.specialChars = specialChars;
            this.passwordLength = passwordLength;
            setChars();
        }
        //create list of all chars that are used to generate the password
        private void setChars()
        {
            for (int i = 48; i <= 122; i++)
            {
                //indexes 0 - 9 : 0 - 9
                //indexes 10 - 35: A - Z
                //indexes 36 - 72: a - z
                if ((i >= 48 && i <= 57) || (i >= 65 && i <= 90) || (i >= 97 && i <= 122))
                {
                    chars.Add((char)i);
                }
            }
            //add the user selected special chars
            foreach (char c in specialChars)
            {
                chars.Add(c);
            }
        }

        public string create()
        {
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                password.Append(chars[rnd.Next(0, chars.Count - 1)]);
            }
            return password.ToString();
        }


    }
}
