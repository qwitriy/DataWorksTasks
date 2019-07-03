namespace DataWorksTasks
{
    public static class BracketsVerificator
    {
        public static bool Verify(string expression)
        {
            var balance = 0;
            
            foreach (var ch in expression.ToCharArray())
            {
                if(ch == '(')
                {
                    balance++;
                }
                else if(ch == ')')
                {
                    if (balance == 0)
                    {
                        return false;
                    }

                    balance--;
                }
            }
            
            return balance == 0;
        }
    }
}