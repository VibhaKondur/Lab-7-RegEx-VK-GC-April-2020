using System;
using System.Text.RegularExpressions;

namespace VK_Lab_7_C.net_4_30_2020
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public static bool ValidateNames(string name)
    {
        if (Regex.IsMatch(name, "([A-Z][a-zA-Z]{1,30}$)"))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static bool ValidateEmails(string email)
    {
        if (Regex.IsMatch(email, "(^[A-Za-z][5-10]._% + - + @ [A-Z][5-10].-] +.[A-Z]{2,3}$)"))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static bool ValidatePhoneNumber(string phonenumber)
    {
        if (Regex.IsMatch(phonenumber, "(/(?([0-9]{3}))?([ .-]?)([0-9]{3})2([0-9]{4})/)"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool ValidateDate(string date)
    {
        if (Regex.IsMatch(date, "(^d{1,2}\\d{1,2}\\d{4}$)"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
