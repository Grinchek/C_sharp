using System.Text;

namespace my_prog
{
    class My_class
    {
        static void Main(string[] args)
        {
            //pt1
            //string st1 = "First string"; 
            //string st2 = "inserted ";
            //st1 = st1.Insert(6, st2);
            //Console.WriteLine(st1);
            //pt2
            //bool IsPalindrom(string value)
            //{
            //    for (int i = 0; i < value.Length/2; i++)
            //    {
            //        if (value[i] != value[value.Length - i - 1])
            //        {
            //            return false;
            //        }
            //    }
            //    return true; 
            //}
            //Console.WriteLine(IsPalindrom("otto"));
            //p3
            Console.OutputEncoding = Encoding.UTF8;
            string st = "Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.";
            string[] tmp= st.Split(st, ' ');
            char[] onest;
            for (int i = 0; i < tmp.Length; i++)
            {
                onest += tmp[i].Split(tmp[i]);
            }
        }
    }

}