using System;

namespace SWDialogBox
{
	/// <summary>
	/// 指示登录是否成功的返回状态。
	/// </summary>
	public enum LoginResult
	{
		/// <summary>
		/// 忽略返回值。
		/// </summary>
		None				=	-1,
		/// <summary>
		/// 登录成功。
		/// </summary>
		Success				=	0,
		/// <summary>
		/// 登录过程中发生未知的错误或异常。
		/// </summary>
		Unknown				=	99,
		/// <summary>
		/// 登录超时。
		/// </summary>
		Timeout				=	1,
		/// <summary>
		/// 无效或非法的登录帐户。
		/// </summary>
		InvalidUserName		=	2,
		/// <summary>
		/// 无效的登录口令。
		/// </summary>
		InvalidPassword		=	3,
		/// <summary>
		/// 无效的服务器。
		/// </summary>
		InvalidServer		=	4,
		/// <summary>
		/// 无效的数据库。
		/// </summary>
		InvalidDatabase		=	5,
		/// <summary>
		/// 无效的权限，指当前登录用户被系统拒绝登入。
		/// </summary>
		InvalidPermission	=	6,
	}

	/// <summary>
	/// 为 SWDialogBox.LoginBox.Logined 事件提供数据。
	/// </summary>
	public class LoginedEventArgs : System.EventArgs
	{
		private SWDialogBox.LoginResult mnLoginResult;

		/// <summary>
		/// 获取或设置登录状态的返回值。
		/// </summary>
		public SWDialogBox.LoginResult Result
		{
			get
			{
				return mnLoginResult;
			}
			set
			{
				mnLoginResult = value;
			}
		}

		/// <summary>
		/// 初始化 SWDialogBox.LoginedEventArgs 类的一个新实例。
		/// </summary>
		/// <param name="loginResult">返回的登录状态。</param>
		public LoginedEventArgs(SWDialogBox.LoginResult loginResult)
		{
			mnLoginResult = loginResult;
		}
	}

	/// <summary>
	/// 表示将处理 SWDialogBox.Logined 事件的方法。
	/// </summary>
	public delegate void LoginedEventHandler(Object sender, SWDialogBox.LoginedEventArgs e);

	/// <summary>
	/// 显示可包含用户名、口令和服务器等信息（通知并指示用户）的登录框。
	/// </summary>
	public class LoginBox
	{
		private Boolean					_useSecurity;
		private String					_userName;
		private String					_password;
		private String					_database;
		private String					_server;
		private String					_title;
		private Int32					_timeout;
		private Int32					_maxCount;
		private System.Drawing.Color	_backColor;
		private System.Drawing.Color	_foreColor;
		private System.Drawing.Image	_backgroundImage;
		private System.Drawing.Image	_titleImage;

		private SWDialogBox.LoginedEventArgs moLoginedEventArgs;

		/// <summary>
		/// 在单击“确定”按钮后发生。
		/// </summary>
		public event SWDialogBox.LoginedEventHandler Logined;

		/// <summary>
		/// 激发 SWDialogBox.LoginBox.Logined 事件。
		/// </summary>
		/// <param name="e">提供给事件的参数。</param>
		protected virtual void OnLogined(SWDialogBox.LoginedEventArgs e)
		{
			if(Logined != null)
				Logined(this, e);
		}

		/// <summary>
		/// 初始化 SWDialogBox.LoginBox 类的一个新实例。
		/// </summary>
		public LoginBox()
		{
//			_title		= null;
//			_timeout	= 30;
//			_maxCount	= 3;
//			_useSecurity = false;
//			_backColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
//			_foreColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlText);
//			_backgroundImage = null;
//
//			System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SWDialogBox.SWDialogBox", this.GetType().Assembly);
//			System.Drawing.Image image = rm.GetObject("BITMAP-Title") as System.Drawing.Image;
//
//			_titleImage = image;

			moLoginedEventArgs = new SWDialogBox.LoginedEventArgs(SWDialogBox.LoginResult.Success);
		}

		#region 公共属性
		/// <summary>
		/// 获取或设置登录的用户名称。
		/// </summary>
		public String UserName
		{
			get
			{
				return _userName;
			}
			set
			{
				_userName = value.Trim();
			}
		}

		/// <summary>
		/// 获取或设置登录口令。
		/// </summary>
		public String Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}

		/// <summary>
		/// 获取或设置登录的服务器地址。
		/// </summary>
		public String Server
		{
			get
			{
				return _server;
			}
			set
			{
				_server = value;
			}
		}

		/// <summary>
		/// 获取或设置登录的数据库名称。
		/// </summary>
		public String Database
		{
			get
			{
				return _database;
			}
			set
			{
				_database = value;
			}
		}

		/// <summary>
		/// 获取或设置登录的超时期限，建议使用单位为‘秒’。
		/// </summary>
		public Int32 Timeout
		{
			get
			{
				return _timeout;
			}
			set
			{
				_timeout = value;
			}
		}

		public bool UseSecurity
		{
			get
			{
				return _useSecurity;
			}
			set
			{
				_useSecurity = value;
			}
		}

		/// <summary>
		/// 获取或设置最大的登录次数。
		/// </summary>
		/// <remarks>
		/// 该值应大于或等于零，为零时表示不限登录次数。
		/// </remarks>
		public Int32 MaxCount
		{
			get
			{
				return _maxCount;
			}
			set
			{
				_maxCount = value >= 0 ? value : 3;
			}
		}

		/// <summary>
		/// 获取或设置登录框窗体的标题。
		/// </summary>
		/// <remarks>
		/// 该值为空值（在Visual Basic中为Nothing）默认为系统提供的标题内容。
		/// </remarks>
		public String Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
			}
		}

		/// <summary>
		/// 获取或设置登录框窗体的前景颜色。
		/// </summary>
		public System.Drawing.Color ForeColor
		{
			get
			{
				return _foreColor;
			}
			set
			{
				_foreColor = value;
			}
		}

		/// <summary>
		/// 获取或设置登录框窗体的背景颜色。
		/// </summary>
		public System.Drawing.Color BackColor
		{
			get
			{
				return _backColor;
			}
			set
			{
				_backColor = value;
			}
		}

		/// <summary>
		/// 获取或设置登录框窗体的背景图像。
		/// </summary>
		public System.Drawing.Image BackgroundImage
		{
			get
			{
				return _backgroundImage;
			}
			set
			{
				_backgroundImage = value;
			}
		}

		/// <summary>
		/// 获取或设置登录框窗体的标题栏的显示图像。
		/// </summary>
		public System.Drawing.Image TitleImage
		{
			get
			{
				return _titleImage;
			}
			set
			{
				_titleImage = value;
			}
		}
		#endregion

		#region 公共方法
		/// <summary>
		/// 设置系统登录信息。
		/// </summary>
		/// <param name="UserName">登录用户。</param>
		/// <param name="Password">登录口令。</param>
		/// <param name="Server">登录服务器。</param>
		/// <param name="Database">登录数据库。</param>
		/// <param name="Timeout">登录超时。</param>
		public void SetLogin(String UserName, String Password, String Server, String Database, Int32 Timeout)
		{
			_userName = UserName.Trim();
			_password = Password;
			_server = Server;
			_database = Database;
			_timeout = Timeout;
		}

		/// <summary>
		/// 打开登录窗体。
		/// </summary>
		/// <returns>
		/// 真：表示登录成功，在 SWDialogBox.LoginBox.Logined 事件中返回的 SWDialogBox.LoginedEventArgs 类型参数的 Result 属性被设置为 SWDialogBox.LoginResult.Success 值。
		/// 假：表示登录失败，即登录操作被取消。
		/// </returns>
		public Boolean Login()
		{
			return this.Login(null, null);
		}

		/// <summary>
		/// 打开登录窗体。
		/// </summary>
		/// <param name="title">登录窗体的标题。</param>
		/// <returns>
		/// 真：表示登录成功，在 SWDialogBox.LoginBox.Logined 事件中返回的 SWDialogBox.LoginedEventArgs 类型参数的 Result 属性被设置为 SWDialogBox.LoginResult.Success 值。
		/// 假：表示登录失败，即登录操作被取消。
		/// </returns>
		public Boolean Login(String title)
		{
			return this.Login(null, title);
		}

		/// <summary>
		/// 打开登录窗体。
		/// </summary>
		/// <param name="owner">登录窗体的所有者。</param>
		/// <returns>
		/// 真：表示登录成功，在 SWDialogBox.LoginBox.Logined 事件中返回的 SWDialogBox.LoginedEventArgs 类型参数的 Result 属性被设置为 SWDialogBox.LoginResult.Success 值。
		/// 假：表示登录失败，即登录操作被取消。
		/// </returns>
		public Boolean Login(System.Windows.Forms.IWin32Window owner)
		{
			return this.Login(owner, null);
		}

		/// <summary>
		/// 打开登录窗体。
		/// </summary>
		/// <param name="owner">登录窗体的所有者。</param>
		/// <param name="title">登录窗体的标题。</param>
		/// <returns>
		/// 真：表示登录成功，在 SWDialogBox.LoginBox.Logined 事件中返回的 SWDialogBox.LoginedEventArgs 类型参数的 Result 属性被设置为 SWDialogBox.LoginResult.Success 值。
		/// 假：表示登录失败，即登录操作被取消。
		/// </returns>
		public Boolean Login(System.Windows.Forms.IWin32Window owner, String title)
		{
			FLoginBox loginForm = null;

			try
			{
				System.Windows.Forms.DialogResult result;

				loginForm = new FLoginBox();
				loginForm.SetLogin(_userName, _password, _server, _database, _timeout, moLoginedEventArgs.Result);
//				loginForm.UseSecurity = _useSecurity;
//				loginForm.picTitle.Image = _titleImage;
//				loginForm.picTitle.Visible = (_titleImage != null);
//				loginForm.BackgroundImage = _backgroundImage;

//				if(title != null)
//					_title = title;
//
//				if(_title != null)
//					loginForm.Text = _title;

				for(int i=0; i<_maxCount || _maxCount==0; i++)
				{
					loginForm.SetResult(moLoginedEventArgs.Result);

					if(owner == null)
					{
						loginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						result = loginForm.ShowDialog();
					}	
					else
					{
						loginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						result = loginForm.ShowDialog(owner);
					}

					if(result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Yes)
					{
						_userName = loginForm.UserName;
						_password = loginForm.Password;
						_database = loginForm.Database;
						_server = loginForm.Server;
						_timeout = loginForm.Timeout;
						_useSecurity = loginForm.UseSecurity;

						//激发“Logined”事件
						this.OnLogined(moLoginedEventArgs);

						switch(moLoginedEventArgs.Result)
						{
							case SWDialogBox.LoginResult.Success:
								loginForm.writeAppXML(loginForm.UserName);
								return (result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Yes);
							case SWDialogBox.LoginResult.None:
								i--;
								break;
						}
					}
					else//此处不能屏蔽，按“取消”按钮后，直接退出；否则，需按“取消按钮”设定次数后退出 qxd remark 2006-11-15
						break;
				}
			}
			catch
			{
				return false;
			}
			finally
			{
				if(loginForm != null)
					loginForm.Dispose();
			}

			return false;
		}
		#endregion
	}
}
