using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    class csValidator
    {
        public static bool IsValidName(String name)
        {
           for(int i  = 0; i < name.Length; i++) 
            {
                if(!((name[i] >= 'A' && name[i] <= 'Z')||(name[i] >= 'a' && name[i] <= 'z')))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsValidEmail(string email)
        {
            int dot = -1;
            int at = -1;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    at++;
                }
                else if (email[i] == '.')
                {
                    dot++;
                }

            }
            if (dot == -1)
            {
                return false;
            }
            else if (at == -1)
            {
                return false;
            }
            else if (dot < at)
            {
                return false;
            }
            return true;
        }
        public static int GetAge(String b_Date)
        {
           
            DateTime birthday = DateTime.Parse(b_Date);
            DateTime today = DateTime.Now;
            int i = birthday.CompareTo(today);
            if (i < 0)
            {
                
                TimeSpan t = today - birthday;
                DateTime age = DateTime.MinValue + t;

                int years = age.Year - 1;
                 return years;
            }
            else
            {
                return 0;
            }
        }
        public static bool IsValidPassword(String pass) {

            int uppercaseLetterCount = 0;
            int lowerCaseLetterCount = 0;
            int numberCount = 0;
            int specialCharactersCount = 0;
            int[] specialChar = { '!', '@', '#', ';', '.', '&', '*', '%', ',', '|' };
            if (pass.Length >= 8)
            {
                foreach (char c in pass)
                { 
                  if(c >= 'A' && c <= 'Z')
                    {
                        uppercaseLetterCount++;
                    }
                  else if(c >= 'a' && c <= 'z')
                    {
                        lowerCaseLetterCount++;
                    }
                  else if(c >= '0' && c <= '9')
                    {
                        numberCount++;
                    }
                  foreach (char ch in specialChar)
                  { 
                     if(c == ch)
                        {
                            specialCharactersCount++;
                        }
                  }
                }
              
                if(uppercaseLetterCount == 0 || lowerCaseLetterCount == 0 || numberCount == 0 || specialCharactersCount == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        
        }
    }
}
