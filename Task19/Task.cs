public class Tasks
{
    public static Boolean IsPalindrome(Int32 number)
    {
        var originalNumber = number.ToString();
     
        char[] charArray = originalNumber.ToCharArray();
        Array.Reverse( charArray );
        var reversedNumber = new string( charArray );
        
        return originalNumber.Equals(reversedNumber);
    }
}