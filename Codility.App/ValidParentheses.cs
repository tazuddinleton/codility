namespace Codility.App;


public class ValidParentheses
{
    public static bool IsValid(string s) {
        string stack = "";
        char[] ch = s.ToCharArray();
        foreach(var c in  ch) {
            if (stack.Length == 0 || c.ToString() != stack[stack.Length-1].ToString()) {                
                if (c.ToString() == "(") {
                    stack += ")";
                } else if (c.ToString() == "{") {
                    stack += "}";
                } else if (c.ToString() == "[") {
                    stack += "]";
                }
            } else {
                stack = stack.Substring(0, stack.Length-1);
            }
        }
        return stack == "";
    }
    
}