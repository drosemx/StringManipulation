using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 )
            {
                System.Console.WriteLine("Please enter a numeric argument.");

            }
            //Declaring and Initializing Strings

                // Declare without initializing.
                string message1;

                // Initialize to null.
                string message2 = null;

                // Initialize as an empty string.
                // Use the Empty constant instead of the literal "".
                string message3 = System.String.Empty;

                // Initialize with a regular string literal.
                string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

                // Initialize with a verbatim string literal.
                string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

                // Use System.String if you prefer.
                System.String greeting = "Hello World!";

                // In local variables (i.e. within a method body)
                // you can use implicit typing.
                var temp = "I'm still a strongly-typed System.String!";

                // Use a const string to prevent 'message4' from
                // being used to store another string value.
                const string message4 = "You can't get rid of me!";

                // Use the String constructor only when creating
                // a string from a char*, char[], or sbyte*. See
                // System.String documentation for details.
                char[] letters = { 'A', 'B', 'C' };
                string alphabet = new string(letters);

            //

            string columns = "Column 1\tColumn 2\tColumn 3";
            //Output: Column 1        Column 2        Column 3

            string rows = "Row 1\r\nRow 2\r\nRow 3";
            /* Output:
              Row 1
              Row 2
              Row 3
            */

            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
            //Output: "The Æolean Harp", by Samuel Taylor Coleridge

            //

            string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
            System.Text.StringBuilder sb = new System.Text.StringBuilder(question);

            for (int j = 0; j < sb.Length; j++)
            {
                if (System.Char.IsLower(sb[j]) == true)
                    sb[j] = System.Char.ToUpper(sb[j]);
                else if (System.Char.IsUpper(sb[j]) == true)
                    sb[j] = System.Char.ToLower(sb[j]);
            }
            // Store the new string.
            string corrected = sb.ToString();
            System.Console.WriteLine(corrected);
            // Output: How does Microsoft Word deal with the Caps Lock key?

            //
            if (args.ToString() == "hola" )            
            System.Console.WriteLine(args.ToString());
            
        }
    }
}
