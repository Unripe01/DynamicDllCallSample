using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DllSample
{
	public class Class1
	{
		/// <summary>
		/// Instance生成時、Windows Formを呼び出します
		/// </summary>
		public Class1()
		{
			System.Windows.Forms.MessageBox.Show("Hello World");
		}

		/// <summary>
		/// Methodコール時、Windows Formを呼び出します
		/// </summary>
		public void Method1()
		{
			System.Windows.Forms.MessageBox.Show( "Hello Method1" );
		}

	}
}
