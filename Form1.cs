using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Mouse_Paint
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class fclsMousePaint : System.Windows.Forms.Form
	{
		private Graphics m_objGraphics;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fclsMousePaint()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// fclsMousePaint
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Name = "fclsMousePaint";
			this.Text = "Paint with the Mouse";
			this.Load += new System.EventHandler(this.fclsMousePaint_Load);
			this.Closed += new System.EventHandler(this.fclsMousePaint_Closed);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fclsMousePaint_MouseMove);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new fclsMousePaint());
		}

		private void fclsMousePaint_Load(object sender, System.EventArgs e)
		{
			m_objGraphics = this.CreateGraphics();
		}

		private void fclsMousePaint_Closed(object sender, System.EventArgs e)
		{
			m_objGraphics.Dispose();
		}

		private void fclsMousePaint_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Rectangle rectEllipse = new Rectangle() ;

			if (e.Button != MouseButtons.Left) return;

			rectEllipse.X = e.X - 1;
			rectEllipse.Y = e.Y - 1;
			rectEllipse.Width = 2;
			rectEllipse.Height = 2;

			m_objGraphics.DrawEllipse(System.Drawing.Pens.Blue, rectEllipse);

		}
	}
}
