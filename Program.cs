namespace GameOverLoaderBuilder
{
	#region Зависимости

	using System;
	using System.Threading;
	using System.Windows.Forms;

	#endregion

	internal static class Program
	{
		[STAThread]
		public static void Main()
		{
			RunUnique();
		}

		/// <summary>
		/// Проверка Mutex и запуск формы
		/// </summary>
		internal static void RunUnique()
		{
			try
			{
				bool flag = true;
				using (new Mutex(true, string.Concat(@"Local\{", MutEx.GetGUID(), "}"), out flag))
				{
					if (flag) { Application.Run(new LrBFrm()); }
				}
			}
			catch (Exception ex) { throw new Exception("Error Mutex Application", ex); }
		}
	}
}