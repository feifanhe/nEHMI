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
using BasicAttributes.Helper;

namespace FormTest
{
	public partial class BaseForm : Form
	{
		private StockComponents.Button testBtn = new StockComponents.Button();
		private StockComponents.Panel testPanel = new StockComponents.Panel();

		public BaseForm( ) {
			InitializeComponent();

			propertyGrid.PropertySort = PropertySort.Alphabetical;
			//propertyGrid.ToolbarVisible = false;
		}

		private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
			//Console.WriteLine( "* PROPERTY VALUE CHANGED *" );

			//testBtn.Properties = propertyGrid.SelectedObject as AttributesPacker;

			//propertyGrid.Refresh();
		}

		private void ButtonBtn_Click(object sender, EventArgs e) {
			Console.WriteLine( "* Showing BUTTON properties *" );
			propertyGrid.SelectedObject = testBtn;
		}

		private void PanelBtn_Click(object sender, EventArgs e) {
			Console.WriteLine( "* Showing PANEL properties *" );
			propertyGrid.SelectedObject = testPanel;
		}

		private void MutualBtn_Click(object sender, EventArgs e) {
			Console.WriteLine( "* Showing MUTUAL properties *" );
			propertyGrid.SelectedObjects = new object[] { testBtn, testPanel };
		}
	}
}