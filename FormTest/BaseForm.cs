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
		private StockComponents.MultiText testMT = new StockComponents.MultiText();
		private StockComponents.Meter testMeter = new StockComponents.Meter();
		private StockComponents.DropdownMenu testDpm = new StockComponents.DropdownMenu();

		public BaseForm( ) {
			InitializeComponent();

			//testMP.Items.Add( new Picture( "PICTURE1" ) );
			//testMP.Items.Add( new Picture( "PICTURE2" ) );
			//testMP.Items.Add( new Picture( "PICTURE3" ) );

			testMP.Items.Add( "PICTURE1 NAME" );
			testMP.Items.Add( "PICTURE2 NAME" );
			testMP.Items.Remove( testMP.Items[0] );

			testMT.Items.Add( "TEXT1 NAME" );
			testMT.Items.Add( "TEXT2 NAME" );
			testMT.Items.Remove( testMT.Items[ 0 ] );

			testBtn.Actions.Selected.ActionsPWD.Add( "" );

			testDpm.Items.Add( 5 );
			testDpm.Items.Add( 2 );
			testDpm.Items.Add( 0 );

			//testMP.template.Add( new Picture( "PICTURE1" ) );
			//testMP.template.Add( new Picture( "PICTURE2" ) );
			//testMP.template.Add( new Picture( "PICTURE3" ) );

			propertyGrid.PropertySort = PropertySort.Alphabetical;
			//propertyGrid.ToolbarVisible = false;
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

		private void MTBtn_Click(object sender, EventArgs e) {
			Console.WriteLine( "* Showing MULTI-TEXT properties *" );
			propertyGrid.SelectedObject = testMT;
		}

		private void MeterBtn_Click(object sender, EventArgs e) {
			Console.WriteLine( "* Showing METER properties *" );
			propertyGrid.SelectedObject = testMeter;

		}

		private void DpmBtn_Click(object sender, EventArgs e) {
			Console.WriteLine( "* Showing DROPDOWN-MENU properties *" );
			propertyGrid.SelectedObject = testDpm;
		}
	}
}