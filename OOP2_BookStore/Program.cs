using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace OOP2_BookStore
{
	static class Program
	{
		public static MainForm mainform;
		public static List<Observer> observer;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(false);
			mainform = new MainForm();
			observer = new List<Observer>();
			AttachObserver(new Logger());
			Application.Run(mainform);
        }
		/// <summary>
		/// it notifies the observers
		/// </summary>
		/// <param name="formname"></param>
		/// <param name="bttnname"></param>
		public static void NotifyObserver(string formname, string bttnname)
		{
			foreach (Observer item in observer)
			{
				item.record(formname, bttnname);
			}
		}
		/// <summary>
		/// add new item observer list
		/// </summary>
		/// <param name="observe"></param>
		public static void AttachObserver(Observer observe)
		{
			observer.Add(observe);
		}
	}
}