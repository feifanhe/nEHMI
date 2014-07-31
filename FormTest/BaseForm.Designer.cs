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
			this.DisplayBtn = new System.Windows.Forms.Button();
			this.MpBtn = new System.Windows.Forms.Button();
			this.MTBtn = new System.Windows.Forms.Button();
			this.MeterBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// propertyGrid
			// 
			this.propertyGrid.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.propertyGrid.Location = new System.Drawing.Point( 12, 12 );
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size( 252, 262 );
			this.propertyGrid.TabIndex = 0;
			// 
			// ButtonBtn
			// 
			this.ButtonBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.ButtonBtn.Location = new System.Drawing.Point( 13, 346 );
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
			this.PanelBtn.Location = new System.Drawing.Point( 101, 346 );
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
			this.MutualBtn.Location = new System.Drawing.Point( 189, 346 );
			this.MutualBtn.Name = "MutualBtn";
			this.MutualBtn.Size = new System.Drawing.Size( 75, 23 );
			this.MutualBtn.TabIndex = 3;
			this.MutualBtn.Text = "Mutual Prop";
			this.MutualBtn.UseVisualStyleBackColor = true;
			this.MutualBtn.Click += new System.EventHandler( this.MutualBtn_Click );
			// 
			// DisplayBtn
			// 
			this.DisplayBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.DisplayBtn.Location = new System.Drawing.Point( 12, 317 );
			this.DisplayBtn.Name = "DisplayBtn";
			this.DisplayBtn.Size = new System.Drawing.Size( 75, 23 );
			this.DisplayBtn.TabIndex = 4;
			this.DisplayBtn.Text = "Display Prop";
			this.DisplayBtn.UseVisualStyleBackColor = true;
			this.DisplayBtn.Click += new System.EventHandler( this.DisplayBtn_Click );
			// 
			// MpBtn
			// 
			this.MpBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.MpBtn.Location = new System.Drawing.Point( 101, 317 );
			this.MpBtn.Name = "MpBtn";
			this.MpBtn.Size = new System.Drawing.Size( 75, 23 );
			this.MpBtn.TabIndex = 5;
			this.MpBtn.Text = "M. Pic Prop";
			this.MpBtn.UseVisualStyleBackColor = true;
			this.MpBtn.Click += new System.EventHandler( this.MpBtn_Click );
			// 
			// MTBtn
			// 
			this.MTBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.MTBtn.Location = new System.Drawing.Point( 189, 317 );
			this.MTBtn.Name = "MTBtn";
			this.MTBtn.Size = new System.Drawing.Size( 75, 23 );
			this.MTBtn.TabIndex = 6;
			this.MTBtn.Text = "M. Txt Prop";
			this.MTBtn.UseVisualStyleBackColor = true;
			this.MTBtn.Click += new System.EventHandler( this.MTBtn_Click );
			// 
			// MeterBtn
			// 
			this.MeterBtn.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.MeterBtn.Location = new System.Drawing.Point( 13, 288 );
			this.MeterBtn.Name = "MeterBtn";
			this.MeterBtn.Size = new System.Drawing.Size( 75, 23 );
			this.MeterBtn.TabIndex = 7;
			this.MeterBtn.Text = "Meter Prop";
			this.MeterBtn.UseVisualStyleBackColor = true;
			this.MeterBtn.Click += new System.EventHandler( this.MeterBtn_Click );
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 276, 377 );
			this.Controls.Add( this.MeterBtn );
			this.Controls.Add( this.MTBtn );
			this.Controls.Add( this.MpBtn );
			this.Controls.Add( this.DisplayBtn );
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
		private System.Windows.Forms.Button DisplayBtn;
		private System.Windows.Forms.Button MpBtn;
		private System.Windows.Forms.Button MTBtn;
		private System.Windows.Forms.Button MeterBtn;
	}
}

