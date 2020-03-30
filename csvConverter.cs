using System;

namespace IO {
	public class csvConverter
	{
		public static int OUT_T[] Convert<IN_T, OUT_T>(IN_T[] items, Func<IN_T, OUT_T> F))
		{
			int len = items.length;
			OUT_T[] result = new OUT_T(len);
			for (int i = 0; i<len; i++) 
			{
				result[i] = Func(items[i]);
			}
			return result;
	}
		static void Main(string[] args)
		{
	StreamReader input = new StreamReader("items.csv");
	StreamWriter output = new StreamWriter("sorted.txt");
	while (!input.EndOfStream)
    {
		string line = input.ReadLine();
		string[] toks = line.Split(',');
		int[] values = Convert(toks, Int32.Parse);
		Array.Sort(values);
		foreach (int value in values)
        {
			output.Write(value + " ");
        }
		input.Close();
		output.Close();
    }
}
