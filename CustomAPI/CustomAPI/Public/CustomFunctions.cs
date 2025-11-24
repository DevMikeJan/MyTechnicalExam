namespace CustomAPI.Public
{
    public static class CustomFunctions
    {
        public static string RemoveSpecificZero(int zeroLen, string lenZeroToRemove)
        {
            string zeros = "";

            for (int i = 1; i <= zeroLen; i++)
                zeros += "0";

            int len = lenZeroToRemove.Length;
            string result;

            result = zeros.Remove(1, len);

            return result;
        }
    }
}
