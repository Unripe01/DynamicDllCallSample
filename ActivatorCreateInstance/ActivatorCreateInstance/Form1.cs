using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ActivatorCreateInstance
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 外部Dllの呼び出し
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click( object sender, EventArgs e )
		{
			System.Reflection.Assembly asm;
			try
			{
				asm = System.Reflection.Assembly.LoadFrom( "DllSample.dll" );
				Type t = asm.GetType( "DllSample.Class1" );
				dynamic dm = Activator.CreateInstance( t );
				//dll内部のメソッドMethod1を呼び出す
				dm.Method1();
			}
			catch ( Exception ex )
			{
				MessageBox.Show("アセンブリがありません。" + ex.Message );
			}
		}
	}
}
