namespace IVT.Tools
{
    public static class StringTool
    {
        public static string AddSOrNot(int number)
        {
            if (number == 1 || number == -1)
            {
                return "";
            }
            else
            {
                return "s";
            }
        }

        public static string IsOrAre(int number)
        {
            if (number == 1 || number == -1)
            {
                return "is";
            }
            else
            {
                return "are";
            }
        }
    }
}