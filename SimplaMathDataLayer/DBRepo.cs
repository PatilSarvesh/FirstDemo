
namespace SimplaMathDataLayer
{
    public class DBRepo
    {
        public void SaveData(int input1,int input2, int result)
        {
            StreamWriter writter = new StreamWriter("abc.txt");
            writter.Write($"{input1} + {input2} == {result}");
            writter.Close();
        }
    }
}