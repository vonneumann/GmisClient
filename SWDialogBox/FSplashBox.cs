using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SWDialogBox
{
	/// <summary>
	/// FSplash 的摘要说明。
	/// </summary>
	internal class FSplashBox : System.Windows.Forms.Form
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		private System.Drawing.Font _informationFont;
		private System.Drawing.Color _informationColor;

		public String OwnerName;
		public String Organization;
		public String ProductID;
		public String Information;
		public System.Drawing.Rectangle AccreditRectangle;
		public System.Drawing.Rectangle InformationRectangle;

		//定义消息框自身所需资源的资源管理对象。
		private System.Resources.ResourceManager _ownerResource;

		public FSplashBox()
		{
			//Windows 窗体设计器支持所必需的
			InitializeComponent();

			this.OwnerName = String.Empty;
			this.Information = String.Empty;
			this.Organization = Application.CompanyName;
			this.ProductID = Application.ProductName;
			this.AccreditRectangle = new System.Drawing.Rectangle(100, 110, 250, 60);
			this.InformationRectangle = new System.Drawing.Rectangle(100, 185, 250, 20);

			_informationFont = this.Font;
			_informationColor = this.ForeColor;

			//创建消息框自身所需资源的资源管理对象。
			_ownerResource = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing)
			{
				if(components != null)
				{
					components.Dispose();
				}
			}

			//释放所有资源
			_ownerResource.ReleaseAllResources();
			//释放基类中的资源
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FSplashBox));
			// 
			// FSplashBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(398, 243);
			this.ControlBox = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FSplashBox";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.FSplashBox_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FSplashBox_Paint);

		}
		#endregion

		internal System.Drawing.Color InformationColor
		{
			get
			{
				return _informationColor;
			}
			set
			{
				if(!value.IsEmpty)
					_informationColor = value;
			}
		}

		internal System.Drawing.Font InformationFont
		{
			get
			{
				return _informationFont;
			}
			set
			{
				if(value != null)
					_informationFont = value;
			}
		}

		/// <summary>
		/// 在窗体的默认位置显示提示信息。
		/// </summary>
		/// <param name="g">提供显示提示信息的System.Drawing.Graphics对象。</param>
		private void DrawInformation(System.Drawing.Graphics g)
		{
			//如果指定的显示位置为空则返回。
			if(this.InformationRectangle.IsEmpty)
				return;

			try
			{
				//如果指定的参数为空，则为当前窗体创建Graphics对象。
				if(g == null)
					g = this.CreateGraphics();

				g.DrawString(this.Information, _informationFont, new System.Drawing.SolidBrush(_informationColor), (System.Drawing.RectangleF)this.InformationRectangle, new StringFormat(StringFormatFlags.NoWrap));
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 在窗体的默认位置显示授权信息。
		/// </summary>
		/// <param name="g">提供显示提示信息的System.Drawing.Graphics对象。</param>
		private void DrawAccredit(System.Drawing.Graphics g)
		{
			//如果指定的显示位置为空则返回。
			if(this.AccreditRectangle.IsEmpty)
				return;

			try
			{
				//如果指定的参数为空，则为当前窗体创建Graphics对象。
				if(g == null)
					g = this.CreateGraphics();

				//设置临时矩形结构。
				System.Drawing.RectangleF layoutRectangle = (System.Drawing.RectangleF)this.AccreditRectangle;
				//设置显示文本信息的字符串格式。
				System.Drawing.StringFormat layoutFormat = new StringFormat(StringFormatFlags.NoWrap);

				try
				{
					//从资源包中获取“授权标题”的文本内容。
					String accreditTitle = _ownerResource.GetString("Accredit");

					//画“授权标题（本软件使用权属于）”字符串。
					g.DrawString(accreditTitle, this.Font, new SolidBrush(Color.DimGray), layoutRectangle, layoutFormat);

					//设置分隔线的纵坐标位置。
					layoutRectangle.Y += g.MeasureString(accreditTitle, this.Font).Height - 1;

					//画分隔线
					g.DrawLine(new System.Drawing.Pen(Color.DarkGray), layoutRectangle.X, layoutRectangle.Y, layoutRectangle.Right, layoutRectangle.Y);

					//重新设置文本显示的纵坐标位置。
					layoutRectangle.Y += 4;
				}
				catch
				{
				}

				//画“所有者名称”字符串。
				g.DrawString(this.OwnerName, this.Font, new SolidBrush(this.ForeColor), layoutRectangle, layoutFormat);

				//重新设置文本显示的纵坐标位置。
				layoutRectangle.Y += g.MeasureString(this.OwnerName, this.Font).Height;
				//画“组织的名称”字符串。
				g.DrawString(this.Organization, this.Font, new SolidBrush(this.ForeColor), layoutRectangle, layoutFormat);

				//重新设置文本显示的纵坐标位置。
				layoutRectangle.Y += g.MeasureString(this.Organization, this.Font).Height;
				//画“产品序列号”字符串。
				g.DrawString(this.ProductID, this.Font, new SolidBrush(this.ForeColor), layoutRectangle, layoutFormat);
			}
			catch
			{
				throw;
			}
		}

		internal void Refresh(String information, System.Drawing.Rectangle layoutRectangle, System.Drawing.Color foreColor, System.Drawing.Font font)
		{
			if(!layoutRectangle.IsEmpty)
				this.InformationRectangle = layoutRectangle;

			this.Information = information;
			this.InformationFont = font;
			this.InformationColor = foreColor;

			base.Refresh();
		}

		private void FSplashBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			this.DrawAccredit(e.Graphics);
			this.DrawInformation(e.Graphics);
		}

		private void FSplashBox_Load(object sender, System.EventArgs e)
		{
			this.TopLevel = true;

			if(this.BackgroundImage != null)
			{
				this.ClientSize = this.BackgroundImage.Size;

				if(this.Owner == null)
				{
					this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
					this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
				}
				else
				{
					this.Left = this.Owner.Left + (this.Owner.Width - this.Width) / 2;
					this.Top = this.Owner.Top + (this.Owner.Height - this.Height) / 2;
				}
			}
		}
	}
}
