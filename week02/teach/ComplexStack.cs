public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

// the start with a static class 
// and a static method that takes a string and returns a boolean
// the method checks if the parentheses in the string are balanced
// it uses a stack to keep track of the opening parentheses
// it returns true if the parentheses are balanced, false otherwise
// the method handles '(', '[', '{' as opening parentheses
// and ')', ']', '}' as closing parentheses
// it returns false if there is a mismatch or if there are unclosed parentheses
// the method is case-sensitive and does not handle other characters