namespace FormTest
{
	partial class BaseForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( ) {
			this.propertyGrid = new System.Windows.Forms.PropertyGrid();
			this.ButtonBtn = new System.Windows.Forms.Button();
			this.PanelBtn = new System.Windows.Forms.Button();
			this.MutualBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// propertyGrid
			// 
			this.propertyGrid.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.propertyGrid.Location = new System.Drawing.Point( 0, 0 );
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size( 284, 262 );
			this.propertyGrid.TabIndex = 0;
			this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler( this.propertyGrid_PropertyValueChanged );
			// 
			// ButtonBtn
			// 
			this.ButtonBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.ButtonBtn.Location = new System.Drawing.Point( 13, 268 );
			this.ButtonBtn.Name = "ButtonBtn";
			this.ButtonBtn.Size = new System.Drawing.Size( 75, 23 );
			this.ButtonBtn.TabIndex = 1;
			this.ButtonBtn.Text = "Button Prop";
			this.ButtonBtn.UseVisualStyleBackColor = true;
			this.ButtonBtn.Click += new System.EventHandler( this.ButtonBtn_Click );
			// 
			// PanelBtn
			// 
			this.PanelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.PanelBtn.Location = new System.Drawing.Point( 101, 268 );
			this.PanelBtn.Name = "PanelBtn";
			this.PanelBtn.Size = new System.Drawing.Size( 75, 23 );
			this.PanelBtn.TabIndex = 2;
			this.PanelBtn.Text = "Panel Prop";
			this.PanelBtn.UseVisualStyleBackColor = true;
			this.PanelBtn.Click += new System.EventHandler( this.PanelBtn_Click );
			// 
			// MutualBtn
			// 
			this.MutualBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.MutualBtn.Location = new System.Drawing.Point( 189, 268 );
			this.MutualBtn.Name = "MutualBtn";
			this.MutualBtn.Size = new System.Drawing.Size( 75, 23 );
			this.MutualBtn.TabIndex = 3;
			this.MutualBtn.Text = "Mutual Prop";
			this.MutualBtn.UseVisualStyleBackColor = true;
			this.MutualBtn.Click += new System.EventHandler( this.MutualBtn_Click );
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 276, 299 );
			this.Controls.Add( this.MutualBtn );
			this.Controls.Add( this.PanelBtn );
			this.Controls.Add( this.ButtonBtn );
			this.Controls.Add( this.propertyGrid );
			this.Name = "BaseForm";
			this.Text = "Form Test";
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.PropertyGrid propertyGrid;
		private System.Windows.Forms.Button ButtonBtn;
		private System.Windows.Forms.Button PanelBtn;
		private System.Windows.Forms.Button MutualBtn;
	}
}

