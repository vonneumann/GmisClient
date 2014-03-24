using System;

namespace SWDialogBox
{
	/// <summary>
	/// 显示包含授权用户、组织和产品序列号的封面窗口。
	/// </summary>
	public class SplashBox : System.IDisposable
	{
		private SWDialogBox.FSplashBox _splashForm;

		/// <summary>
		/// 初始化 SWSystem.Windows.Forms.DialogBoxs.SplashBox 类的一个新实例。
		/// </summary>
		public SplashBox()
		{
			_splashForm = new SWDialogBox.FSplashBox();
		}

		/// <summary>
		/// 释放由 SWSystem.Windows.Forms.DialogBoxs.SplashBox 占用的所有资源。
		/// </summary>
		public void Dispose()
		{
			if(_splashForm != null)
				_splashForm.Close();

			_splashForm.Dispose();
		}

		/// <summary>
		/// 获取或设置“封面”窗体显示的文本的字体。
		/// </summary>
		public System.Drawing.Font Font
		{
			get
			{
				return _splashForm.Font;
			}
			set
			{
				_splashForm.Font = value;
			}
		}

		/// <summary>
		/// 获取或设置“封面”窗体的前景颜色。
		/// </summary>
		public System.Drawing.Color ForeColor
		{
			get
			{
				return _splashForm.ForeColor;
			}
			set
			{
				_splashForm.ForeColor = value;
			}
		}

		/// <summary>
		/// 获取或设置“封面”窗体显示的背景图片。
		/// </summary>
		public System.Drawing.Image BackgroundImage
		{
			get
			{
				return _splashForm.BackgroundImage;
			}
			set
			{
				_splashForm.BackgroundImage = value;
			}
		}

		/// <summary>
		/// 获取或设置当前鼠标指针位于“封面”窗体上时显示的光标。
		/// </summary>
		public System.Windows.Forms.Cursor Cursor
		{
			get
			{
				return _splashForm.Cursor;
			}
			set
			{
				_splashForm.Cursor = value;
			}
		}

		/// <summary>
		/// 关闭“封面”窗体。
		/// </summary>
		public void Close()
		{
			_splashForm.Hide();
		}

		/// <summary>
		/// 刷新“封面”窗体。
		/// </summary>
		public void Refresh()
		{
			_splashForm.Refresh();
		}

		/// <summary>
		/// 在“封面”窗体中的指定位置显示指定的信息文本。
		/// </summary>
		/// <param name="information">显示的信息文本内容。</param>
		public void Refresh(String information)
		{
			_splashForm.Refresh(information, System.Drawing.Rectangle.Empty, System.Drawing.Color.Empty, null);
		}

		/// <summary>
		/// 在“封面”窗体中的指定位置显示指定的信息文本。
		/// </summary>
		/// <param name="information">显示的信息文本内容。</param>
		/// <param name="foreColor">显示的信息文本的颜色。</param>
		public void Refresh(String information, System.Drawing.Color foreColor)
		{
			_splashForm.Refresh(information, System.Drawing.Rectangle.Empty, foreColor, null);
		}

		/// <summary>
		/// 在“封面”窗体中的指定位置显示指定的信息文本。
		/// </summary>
		/// <param name="information">显示的信息文本内容。</param>
		/// <param name="foreColor">显示的信息文本的颜色。</param>
		/// <param name="font">显示的信息文本的字体。</param>
		public void Refresh(String information, System.Drawing.Color foreColor, System.Drawing.Font font)
		{
			_splashForm.Refresh(information, System.Drawing.Rectangle.Empty, foreColor, font);
		}

		/// <summary>
		/// 在“封面”窗体中的指定位置显示指定的信息文本。
		/// </summary>
		/// <param name="information">显示的信息文本内容。</param>
		/// <param name="layoutRectangle">显示的信息位置区域。</param>
		public void Refresh(String information, System.Drawing.Rectangle layoutRectangle)
		{
			_splashForm.Refresh(information, layoutRectangle, System.Drawing.Color.Empty, null);
		}

		/// <summary>
		/// 在“封面”窗体中的指定位置显示指定的信息文本。
		/// </summary>
		/// <param name="information">显示的信息文本内容。</param>
		/// <param name="layoutRectangle">显示的信息位置区域。</param>
		/// <param name="foreColor">显示的信息文本的颜色。</param>
		public void Refresh(String information, System.Drawing.Rectangle layoutRectangle, System.Drawing.Color foreColor)
		{
			_splashForm.Refresh(information, layoutRectangle, foreColor, null);
		}

		/// <summary>
		/// 在“封面”窗体中的指定位置显示指定的信息文本。
		/// </summary>
		/// <param name="information">显示的信息文本内容。</param>
		/// <param name="layoutRectangle">显示的信息位置区域。</param>
		/// <param name="foreColor">显示的信息文本的颜色。</param>
		/// <param name="font">显示的信息文本的字体。</param>
		public void Refresh(String information, System.Drawing.Rectangle layoutRectangle, System.Drawing.Color foreColor, System.Drawing.Font font)
		{
			_splashForm.Refresh(information, layoutRectangle, foreColor, font);
		}

		/// <summary>
		/// 显示“封面”窗体。
		/// </summary>
		/// <param name="ownerName">授权的用户名称。</param>
		/// <param name="organizationName">授权的组织或公司名称。</param>
		/// <param name="productID">授权的产品序列号。</param>
		public void Show(String ownerName, String organizationName, String productID)
		{
			this.Show(null, ownerName, organizationName, productID, System.Drawing.Rectangle.Empty);
		}

		/// <summary>
		/// 显示“封面”窗体。
		/// </summary>
		/// <param name="ownerName">授权的用户名称。</param>
		/// <param name="organizationName">授权的组织或公司名称。</param>
		/// <param name="productID">授权的产品序列号。</param>
		/// <param name="layoutRectangle">显示授权信息的位置区域。</param>
		public void Show(String ownerName, String organizationName, String productID, System.Drawing.Rectangle layoutRectangle)
		{
			this.Show(null, ownerName, organizationName, productID, layoutRectangle);
		}

		/// <summary>
		/// 显示“封面”窗体。
		/// </summary>
		/// <param name="owner">拥有“封面”窗体的所有者。</param>
		/// <param name="ownerName">授权的用户名称。</param>
		/// <param name="organizationName">授权的组织或公司名称。</param>
		/// <param name="productID">授权的产品序列号。</param>
		public void Show(System.Windows.Forms.IWin32Window owner, String ownerName, String organizationName, String productID)
		{
			this.Show(owner, ownerName, organizationName, productID, System.Drawing.Rectangle.Empty);
		}

		/// <summary>
		/// 显示“封面”窗体。
		/// </summary>
		/// <param name="owner">拥有“封面”窗体的所有者。</param>
		/// <param name="ownerName">授权的用户名称。</param>
		/// <param name="organizationName">授权的组织或公司名称。</param>
		/// <param name="productID">授权的产品序列号。</param>
		/// <param name="layoutRectangle">显示授权信息的位置区域。</param>
		public void Show(System.Windows.Forms.IWin32Window owner, String ownerName, String organizationName, String productID, System.Drawing.Rectangle layoutRectangle)
		{
			_splashForm.OwnerName = ownerName;
			_splashForm.ProductID = productID;
			_splashForm.Organization = organizationName;

			if(layoutRectangle != System.Drawing.Rectangle.Empty)
				_splashForm.AccreditRectangle = layoutRectangle;

			if(owner != null)
				_splashForm.Owner = (System.Windows.Forms.Form)owner;

			_splashForm.Show();
		}

		/// <summary>
		/// 以模式方式显示“封面”窗体。
		/// </summary>
		/// <param name="ownerName">授权的用户名称。</param>
		/// <param name="organizationName">授权的组织或公司名称。</param>
		/// <param name="productID">授权的产品序列号。</param>
		/// <returns>System.Windows.Forms.DialogResult 值之一。</returns>
		public System.Windows.Forms.DialogResult ShowDialog(String ownerName, String organizationName, String productID)
		{
			return this.ShowDialog(null, ownerName, organizationName, productID, System.Drawing.Rectangle.Empty);
		}

		/// <summary>
		/// 以模式方式显示“封面”窗体。
		/// </summary>
		/// <param name="ownerName">授权的用户名称。</param>
		/// <param name="organizationName">授权的组织或公司名称。</param>
		/// <param name="productID">授权的产品序列号。</param>
		/// <param name="layoutRectangle">显示授权信息的位置区域。</param>
		/// <returns>System.Windows.Forms.DialogResult 值之一。</returns>
		public System.Windows.Forms.DialogResult ShowDialog(String ownerName, String organizationName, String productID, System.Drawing.Rectangle layoutRectangle)
		{
			return this.ShowDialog(null, ownerName, organizationName, productID, layoutRectangle);
		}

		/// <summary>
		/// 以模式方式显示“封面”窗体。
		/// </summary>
		/// <param name="owner">拥有“封面”窗体的所有者。</param>
		/// <param name="ownerName">授权的用户名称。</param>
		/// <param name="organizationName">授权的组织或公司名称。</param>
		/// <param name="productID">授权的产品序列号。</param>
		/// <returns>System.Windows.Forms.DialogResult 值之一。</returns>
		public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner, String ownerName, String organizationName, String productID)
		{
			return this.ShowDialog(owner, ownerName, organizationName, productID, System.Drawing.Rectangle.Empty);
		}

		/// <summary>
		/// 以模式方式显示“封面”窗体。
		/// </summary>
		/// <param name="owner">拥有“封面”窗体的所有者。</param>
		/// <param name="ownerName">授权的用户名称。</param>
		/// <param name="organizationName">授权的组织或公司名称。</param>
		/// <param name="productID">授权的产品序列号。</param>
		/// <param name="layoutRectangle">显示授权信息的位置区域。</param>
		/// <returns>System.Windows.Forms.DialogResult 值之一。</returns>
		public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner, String ownerName, String organizationName, String productID, System.Drawing.Rectangle layoutRectangle)
		{
			_splashForm.OwnerName = ownerName;
			_splashForm.ProductID = productID;
			_splashForm.Organization = organizationName;

			if(layoutRectangle != System.Drawing.Rectangle.Empty)
				_splashForm.AccreditRectangle = layoutRectangle;

			if(owner == null)
				return _splashForm.ShowDialog();
			else
				return _splashForm.ShowDialog(owner);
		}
	}
}
