using System;
using System.Windows.Forms;

namespace SWDialogBox
{
	/// <summary>
	/// 指定若干常数，用以定义 MessageBox 上将显示哪些按钮。
	/// </summary>
	[Flags]
	public enum MessageBoxButton
	{
		/// <summary>
		/// 消息框包含“确定(OK)”按钮。
		/// </summary>
		OK			=	0,

		/// <summary>
		/// 消息框包含“确定(OK)”和“取消(Cancel)”按钮。
		/// </summary>
		OKCancel	=	1,

		/// <summary>
		/// 消息框包含“重试(Retry)”和“取消(Cancel)”按钮。
		/// </summary>
		RetryCancel	=	2,

		/// <summary>
		/// 消息框包含“是(Yes)”和“否(No)”按钮。
		/// </summary>
		YesNo		=	4,

		/// <summary>
		/// 消息框包含“是(Yes)”、“否(No)”和“取消(Cancel)”按钮。
		/// </summary>
		YesNoCancel	=	8,

		/// <summary>
		/// 消息框包含“详细(Detail)”按钮。
		/// </summary>
		Detail		=	16,

		/// <summary>
		/// 消息框上的第一个按钮是默认按钮。
		/// </summary>
		DefaultButton1	=	0,
		/// <summary>
		/// 消息框上的第二个按钮是默认按钮。
		/// </summary>
		DefaultButton2	=	256,
		/// <summary>
		/// 消息框上的第三个按钮是默认按钮。
		/// </summary>
		DefaultButton3	=	512
	}

	/// <summary>
	/// 指定若干常数，用以定义 MessageBox 上将显示的图标类型。
	/// </summary>
	[Flags]
	public enum MessageBoxIcon
	{
		/// <summary>
		/// 消息框未包含图标。
		/// </summary>
		None		=	0,
		/// <summary>
		/// 该消息框包含一个图标，该图标是由一个红色背景的圆圈及其中的白色 X 组成的。
		/// </summary>
		Error		=	32,
		/// <summary>
		/// 该消息框包含一个图标，该图标是由一个黄色背景的三角形及其中的一个感叹号组成的。
		/// </summary>
		Warning		=	96,

		/// <summary>
		/// 该消息框包含一个图标，该图标是由一个红色背景的圆圈及其中的白色 X 组成的。
		/// </summary>
		Critical	=	32,
		/// <summary>
		/// 该消息框包含一个图标，该图标是由一个圆圈和其中的一个问号组成的。
		/// </summary>
		Question	=	64,
		/// <summary>
		/// 该消息框包含一个图标，该图标是由一个黄色背景的三角形及其中的一个感叹号组成的。
		/// </summary>
		Exclamation	=	96,
		/// <summary>
		/// 该消息框包含一个图标，该图标是由一个圆圈及其中的小写字母 i 组成的。
		/// </summary>
		Information	=	128,
	}

	/// <summary>
	/// 显示可包含文本、按钮和符号（通知并指示用户）的消息框。
	/// </summary>
	public class MessageBox
	{
		private static System.Drawing.Icon moIcon;

		static MessageBox()
		{
			moIcon = null;
		}

		/// <summary>
		/// 该构造函数为私有类型，将阻止该类实例化。
		/// </summary>
		private MessageBox()
		{
		}

		/// <summary>
		/// 获取或设置消息框窗体左上角的系统图标。
		/// </summary>
		/// <remarks>
		/// 该值为空值（在Visual Basic中为Nothing）默认为系统提供的图标。
		/// </remarks>
		public static System.Drawing.Icon Icon
		{
			get
			{
				return moIcon;
			}
			set
			{
				moIcon = value;
			}
		}

		/// <summary>
		/// 显示指定消息编号对应信息的消息框。
		/// </summary>
		/// <param name="messageID">消息编号。</param>
		/// <returns>System.Window.Forms.DialogResult 值之一。</returns>
		public static System.Windows.Forms.DialogResult Show(String messageID)
		{
			return SWDialogBox.MessageBox.Show(messageID, null);
		}

		/// <summary>
		/// 显示指定消息编号对应信息的消息框。
		/// </summary>
		/// <param name="messageID">消息编号。</param>
		/// <param name="args">要使用 format 写入的对象的数组。</param>
		/// <returns>System.Window.Forms.DialogResult 值之一。</returns>
		public static System.Windows.Forms.DialogResult Show(String messageID, params Object[] args)
		{
			SWDialogBox.FMessageBox messageForm = null;

			try
			{
				messageForm = new SWDialogBox.FMessageBox();
				messageForm.Icon = moIcon;
				return messageForm.ShowDialog(messageID, args);
			}
			catch
			{
				throw;
			}
			finally
			{
				if(messageForm != null)
					messageForm.Dispose();
			}
		}

		/// <summary>
		/// 显示具有指定文本、标题、详细注视、按钮、图标和默认按钮的消息框。
		/// </summary>
		/// <param name="message">消息框中显示的文本。</param>
		/// <param name="caption">消息框的标题栏中显示的文本。</param>
		/// <param name="description">消息框的详细注视栏中显示的文本。</param>
		/// <param name="button">SWDialogBox.MessageBoxButton 值之一，它指定在消息框中显示哪些按钮及默认按钮。</param>
		/// <param name="icon">SWDialogBox.MessageBoxIcon 值之一，它指定在消息框中显示哪个图标。</param>
		/// <returns>System.Window.Forms.DialogResult 值之一。</returns>
		public static System.Windows.Forms.DialogResult Show(String message, String caption, String description, SWDialogBox.MessageBoxButton button, SWDialogBox.MessageBoxIcon icon)
		{
			SWDialogBox.FMessageBox messageForm = null;

			try
			{
				messageForm = new SWDialogBox.FMessageBox();
				messageForm.Icon = moIcon;
				return messageForm.ShowDialog(message, caption, description, button, icon);
			}
			catch
			{
				throw;
			}
			finally
			{
				if(messageForm != null)
					messageForm.Dispose();
			}
		}
	}
}
