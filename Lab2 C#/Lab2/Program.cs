using System;
using Text_;
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Text txt = new Text();

			char[] txtLine1 = { 'G', 'o', 'o', 'd', ' ', ' ', 'd', 'a', 'y', ' ', 't', 'o', 'd', 'a', 'y' };
			char[] txtLine2 = { ' ', 'G', 'o', 'o', 'd', ' ', 'd', 'a', 'y', ' ', 'n', 'e', 'x', 't', ' ', 'd', 'a', 'y' };
			char[] txtLine3 = { 'G', 'o', 'o', 'd', ' ', 'd', 'a', 'y', ' ', ' ', 'y', 'e', 's', 't', 'e', 'r', 'd', 'a', 'y' };
			txt.addToText(txtLine1);
			txt.addToText(txtLine2);
			txt.addToText(txtLine3);
			txt.GetContent();
			Console.WriteLine("Процент приголосних: " + txt.PercVoiced());
			Console.WriteLine("Довжина найкоротшого рядка: " + txt.SmallestLength() + "\n");

			Console.WriteLine("Після заміних повторення пробілів: ");
			txt.RemoveDoubleSpaces();
			txt.GetContent();

			Console.WriteLine("Після видалення пробілів на початку та вкінці: ");
			txt.RemoveStartEndSpaces();
			txt.GetContent();

			Console.WriteLine("Після видалення останнього рядка: ");
			txt.delLine();
			txt.GetContent();
			
		}
	}
}
