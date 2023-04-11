internal class Program
{
    private static void Main(string[] args)
    {
        double exapmle1 = 2.345;
        double example2 = -23.809;
        Console.WriteLine(GetDigitWord(exapmle1));
        Console.WriteLine(GetDigitWord(example2));
    }
    public static string GetDigitWord(double examle)
    {
        string strExamle = examle.ToString();
        string returnExamle = "";
        foreach (char c in strExamle)
        {
            switch (c)
            {
                case '0': returnExamle += "zero "; break;
                case '1': returnExamle += "one "; break;
                case '2': returnExamle += "two "; break;
                case '3': returnExamle += "three "; break;
                case '4': returnExamle += "four "; break;
                case '5': returnExamle += "five "; break;
                case '6': returnExamle += "six "; break;
                case '7': returnExamle += "seven "; break;
                case '8': returnExamle += "eight "; break;
                case '9': returnExamle += "nine "; break;
                case '-': returnExamle += "minus "; break;
                case ',': returnExamle += "point "; break;
            }
        }
        return returnExamle;
    }
}