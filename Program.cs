using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
 
  public  class PasswordStrength
    {
        enum PasswordStrenght : byte
        {
            easy = 0,
            normal = 1,
            hard = 2

        }
        public static string GeneratePassword(PasswordStrenght passwordStrenght)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            char ch;
            if(passwordStrenght==0)
            {
                for (int i = 0; i < 6; i++)
                {
                    ch = Convert.ToChar(random.Next());
                    sb.Append(ch);
                }

                return sb.ToString().ToLower().ToString();
              
            }
            else if(passwordStrenght==1)
            {
                
                for(int i=0;i<4;i++)
                {
                    ch = Convert.ToChar(random.Next());
                    sb.Append(ch);
                }
                sb.Append(random.Next());
                sb.Append(random.Next());
                for (int i=5;i<10;i++)
                {
                    ch = Convert.ToChar(random.Next());
                    sb.Append(ch);
                }
                return sb.ToString().ToUpper().ToString();
            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    sb.Append((byte)random.Next(33, 126));

                        }
                return sb.ToString();
            }

        }
        static void Main(string[] args)
        {
            string passLine = "lozinka1 test2 pogodok";
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);
        }
    }

  
}
