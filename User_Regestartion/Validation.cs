using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problems
{
    public class Validation
    {

        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string emailId = "^[a-z]{3,}([.]{1}[a-z]{2,})?[/@/][a-z]{2,5}[/./][a-z]{2,5}([.]{1}[a-z]{2})?$";
        public static string mobileNo = "^91[/ /][6-9]{1}[0-9]{9}$";
        public static string password = "^[a-zA-Z0-9]{8,}";
        public static string password_2 = @"^(?=.*[A-Z])[[a-zA-Z1-9]{1}][[a-zA-Z0-9]{7,}]";
        public static string password_3 = @"^(?=.*[0-9])[a-zA-Z0-9]{8,}$";
        public static string password_4 = "^.*(?=.{8,})(?=.*)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        public static string mail = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";
        public void Validate(string data)
        {
            string result = Regex.IsMatch(data, mail) ? $"{data}: valid" : $"{data}: invalid";

            Console.WriteLine(result);
        }
        public void ValidatingPassword_4(string data)
        {
            string result = Regex.IsMatch(data, password_4) ? $"{data}: Valid Password" : $"{data}: Invalid Password";

            Console.WriteLine(result);
        }

        public void ValidatingPassword_3(string data)
        {
            string result = Regex.IsMatch(data, password_3) ? $"{data}: Valid Password" : $"{data}: Invalid Password";

            Console.WriteLine(result);
        }

        public void ValidatingPassword_2(string data)
        {
            string result = Regex.IsMatch(data, password_2) ? $"{data}: Valid Password" : $"{data}: InValid Password";

            Console.WriteLine(result);
        }

        public void ValidatingPassword(string data)
        {
            string result = Regex.IsMatch(data, password) ? $"{data}: Valid Password" : $"{data}: Invalid Password";

            Console.WriteLine(result);
        }

        public bool ValidatingNumber(string data)
        {
            bool result = Regex.IsMatch(data, mobileNo) ? true : false;
            return result;

        }
        public bool Validating_Email(string data)
        {
            bool result = Regex.IsMatch(data, emailId) ? true : false;

            return result;
        }


        public bool ValidateFirstName(string data)
        {

            bool result = Regex.IsMatch(data, firstName) ? true : false;

            return result;


        }

        public bool ValidateLastName(string data)
        {

            bool result = Regex.IsMatch(data, lastName) ? true : false;

            return result;

        }
    }
}
