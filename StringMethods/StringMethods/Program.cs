using System;
using System.Text;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, Welcome to IncubXperts family!";
            string str2 = "Welcome";
            Console.WriteLine(str);

            //clone()
            string str1 = (String)str.Clone();
            Console.WriteLine("Clone string : {0}", str1);

            //compare() using == and Equals()
           
            Console.WriteLine(str == str1); //True
            Console.WriteLine(str.Equals(str1)); //True
            Console.WriteLine(str.Equals(str2)); //False

            //CompareOrdinal()
            Console.WriteLine(string.CompareOrdinal(str, str2)); // negative output
            Console.WriteLine(string.CompareOrdinal(str, str1)); // both strings are equal so output is 0
            Console.WriteLine(string.CompareOrdinal(str2, str)); //positive output

            //CompareTo() : returns an integer value
            Console.WriteLine(str.CompareTo(str1));
            Console.WriteLine(str1.CompareTo(str2));

            //Concat()
            string strconcat = String.Concat(str1, str2);

            Console.WriteLine("Concatenated string is: {0}", strconcat);


            //contain()
            String substr1 = "welcome";
            String substr2 = "Welcome";

            Console.WriteLine(str.Contains(substr1)); //False (lowercase)
            Console.WriteLine(str.Contains(substr2)); // True

            //copy()



            //copyTo()
            
            char[] arr = { 'I', 'n', 'c', 'l', 'u', 'd', 'H', 'e', 'l', 'p' };
            str.CopyTo(0, arr, 0, 6);
            Console.WriteLine((arr));

            // EndsWith()
            bool x, y;

            x = str1.EndsWith("!");
            y = str2.EndsWith("welcome");
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());

            //format()
            string strA;

            strA = String.Format("There are {0} cats in my {1} and no {2}", 2, "house", "dogs");

            Console.WriteLine(strA);

            //GetEnumerator


            //GetHashCode
            int s1 = str.GetHashCode();
            Console.WriteLine("string 1: {0} and hashcode: {1}", str, s1); //will return a 32-bit signed integer hash code

            //GetType
            Console.WriteLine(str.GetType());
            Console.WriteLine(s1.GetType());

            //GetTypeCode()
            Console.WriteLine("The TypeCode for {0}': {1}", str1, str1.GetTypeCode());
            Console.WriteLine("The TypeCode for {0}': {1}", s1, s1.GetTypeCode());

            //IndexOf()
            int index1 = str.IndexOf('W');

            Console.WriteLine("The Index Value of character 'W' is " + index1);
            //This method returns the zero-based index of the first occurrence of the specified character within the string.
            //In case no such character founds then it returns -1.

            //insert()
            string strB = str.Insert(5, "ok");
            Console.WriteLine("New string: {0} ", strB );

            //intern() : is used to retrieve reference to the specified String.
            string strIntern = string.Intern(str2);
            Console.WriteLine(str2);
            Console.WriteLine(strIntern);

            //IsInterned() method is used to get reference of the specified string.


            //IsNormalized() method is used to check whether the given string is in a particular Unicode normalization form or not

            bool value;
            value = str1.IsNormalized();
            Console.WriteLine("String is : {0}", str1);
            Console.WriteLine("Is str1 string is in normalized form?: {0}",
                                                                    value);

            //IsNullOrEmpty:used to check whether the specified string
            //is null or an Empty string
            string strC = "";
            string strD = null;
            bool b1 = string.IsNullOrEmpty(str);
            bool b2 = string.IsNullOrEmpty(strC);
            bool b3 = string.IsNullOrEmpty(strD);
            Console.WriteLine(b1); //False
            Console.WriteLine(b2); //True
            Console.WriteLine(b3); //True


            //IsNullOrWhiteSpace() :check whether the specified string is null
            //or contains only white-space character

            string strWhiteSpc = " ";
            bool b4 = string.IsNullOrWhiteSpace(strWhiteSpc);
            Console.WriteLine(b4);

            //join(): used to concatenate the elements of a String array
            //with the help of a user-specified separator between
            //each element of the string array.
            object[] array = { "Hello", "Welcome", 123, 456 };
            string strjoin = string.Join(",", array);
            Console.WriteLine("Value of string is  {0}", strjoin);


            //LastIndexOf() :used to find last occurrence of given character
            //within string
            int index = str.LastIndexOf('X');
            Console.WriteLine(index);


            //LastIndexOfAny(): used to find index position of the last occurrence
            //of one or more characters specified in this string.
            char[] ch = { 'r', 'b' };
            int indexany = str.LastIndexOfAny(ch);//Finds 'r' at the last  
            Console.WriteLine(indexany);


            //padleft():  right-aligns the characters in this string by padding them with specified character on the left
            Console.WriteLine("Pad  20 :'{0}'", str2.PadLeft(20));// totalwidth is greater then string length
            Console.WriteLine("Pad  2 :'{0}'", str2.PadLeft(2)); // totalwidth is less then string length


            //padright():  left-aligns the characters in this string by padding them with specified character on the left
            Console.WriteLine("Pad  20 :'{0}'", str2.PadRight(20));// totalwidth is greater then string length
            Console.WriteLine("Pad  2 :'{0}'", str2.PadRight(2)); // totalwidth is less then string length

            //remove() : removes all the characters from the specified index till the end of the string
            string strR = str.Remove(5);
            Console.WriteLine("New String1 :{0} ",strR);


            //replace()
            Console.WriteLine("NewString: " + str.Replace('s', 'G'));


            //split(): returns array of string
            string[] s2 = str.Split(' ');
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
            }


            //startswith()
            Boolean result = str.StartsWith('w');
            Console.WriteLine("Given string starts with specified char? : {0}", result);


            //substring()
            string substr = str.Substring(5);
            Console.WriteLine("Sub String: {0}", substr);



            //ToCharArray()
            char[] chars = str.ToCharArray();

            Console.WriteLine("String: " + str);
            Console.WriteLine("Character array :");

            // to display the resulted character array
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(" " + chars[i]);
            }



            //tolower()
            string lowerstr1 = str1.ToLower();
            Console.WriteLine(lowerstr1);


            //tolowervariant()
            string strlower = "HelloWelcome";
            string strV = strlower.ToLowerInvariant();
            Console.WriteLine(strV);


            //ToString() method is used to get instance of String.
            string strtostr = str.ToString();
            Console.WriteLine(strtostr);

            //toupper()
            string upperstr1 = str1.ToUpper();
            Console.WriteLine(upperstr1);


            //trim(): used to removes all leading and trailing white-space characters from the current String 
            string strtrim = " GFG";
            string strtrim1 = " GFG ";
            Console.WriteLine(strtrim.Trim());
            Console.WriteLine(strtrim1.Trim());




            //TrimStart() and trimend()
            string strP = "*****0000abc000****";
            string strQ = "  abc";
            string strT = "  -GFG-";
            string strS  = "  GeeksforGeeks";

            char[] charsToTrim1 = { '*', '0' };

            Console.WriteLine(strP.TrimStart(charsToTrim1));
            Console.WriteLine(strQ.TrimStart());
            Console.WriteLine(strT.TrimStart('-'));
            Console.WriteLine(strS.TrimStart(' ', 'G', 'e', 'k', 's'));


            
            
            //stringbuilder methods

            //append() : used to add or append a string value of an object to the end of a string

            // "20" is capacity
            StringBuilder s = new StringBuilder("HELLO ", 20);

            s.Append("Welcome");

            // after printing "GEEKS"
            // a new line append
            s.AppendLine(" to my family");
            Console.WriteLine(s);



            //AppendFormat()
            StringBuilder AppendFor = new StringBuilder("Your total amount is ");
            AppendFor.AppendFormat("{0:C} ", 50);
            Console.WriteLine(AppendFor);


            //insert()
            StringBuilder sinsert = new StringBuilder("HELLO ", 20);

            // "Hie" insert after 6th index
            sinsert.Insert(6, "Hie");
            Console.WriteLine(sinsert);



            

            // remove starts from index 5
            // and remove happes 3 index 
            // after index 5
            sinsert.Remove(5, 3);

            Console.WriteLine(sinsert);


            //Replace 
            sinsert.Replace("e", "hello");

            Console.WriteLine(sinsert);











        }
    }
}
