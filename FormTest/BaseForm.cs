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
		private StockComponents.Display testDisplay = new StockComponents.Display();
		private StockComponents.MultiPicture testMP = new StockComponents.MultiPicture();

		public BaseForm( ) {
			InitializeComponent();

			testMP.Items.Add<Picture>( new Picture( "PICTURE1" ) );
			testMP.Items.Add<Picture>( new Picture( "PICTURE2" ) );
			testMP.Items.Add<Picture>( new Picture( "PICTURE3" ) );

			testMP.template.Add( new Picture( "PICTURE1" ) );
			testMP.template.Add( new Picture( "PICTURE2" ) );
			testMP.template.Add( new Picture( "PICTURE3" ) );

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

		private void DisplayBtn_Click(object sender, EventArgs e) {
			Console.WriteLine( "* Showing DISPLAY properties *" );
			propertyGrid.SelectedObject = testDisplay;
		}

		private void MpBtn_Click(object sender, EventArgs e) {
			Console.WriteLine( "* Showing MULTI-PICTURE properties *" );
			propertyGrid.SelectedObject = testMP;
		}
	}
}