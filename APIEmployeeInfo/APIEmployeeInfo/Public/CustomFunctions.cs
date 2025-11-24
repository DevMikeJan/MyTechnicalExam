using System;

namespace APIEmployeeInfo.Public
{
    public static class CustomFunctions
    {

        public static int NullInt(this object input)
        {
            if (input == null || input == DBNull.Value || input == "")
                return 0;
            else
                return Convert.ToInt32(input);

        }

        public static string NullAlpha(object input)
        {
            if (input == null || input == DBNull.Value || input == "")
                return "";
            else
                return (string)input.ToString();
        }

        public static string NullAlphaM(this object input)
        {
            if (input == null || input == DBNull.Value || input == "")
                return "";
            else
                return (string)input.ToString();
        }

    }
}
