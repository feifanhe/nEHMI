using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StockComponents;

using System.Reflection;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Threading;

namespace FormTest
{
	public partial class BaseForm : Form
	{
		public BaseForm( ) {
			InitializeComponent();

			StockComponents.Button testBtn = new StockComponents.Button();
			testBtn.Text.FontSize = 12;

			propertyGrid.SelectedObject = testBtn.Properties;
		}
	}
}