using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NoteBox
{
	/// <summary>
	/// NoteForm 的摘要说明。
	/// </summary>
	public class NoteForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;

		private int screenWidth;//屏幕宽度
		private int screenHeight;//屏幕高度
		private bool finished=false;//是否完全显示提示窗口

		public NoteForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//

			screenHeight = Screen.PrimaryScreen.Bounds.Height;
			screenWidth = Screen.PrimaryScreen.Bounds.Width;
			//设置提示窗口坐标在屏幕可显示区域之外
			Location = new Point(screenWidth-Width, screenHeight);
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(124, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "提示";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 39);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(268, 50);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "尊敬的用户：\r\n    你现在使用的软件是盗版软件，请到微软公司注册成为正版用户，以获得微软的官方支持。";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(104, 96);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "知道了";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// NoteForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(292, 126);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NoteForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "NoteForm";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnOK;

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (!finished)//如果提示窗口没有完全显示
			{
				//如果提示窗口的纵坐标与提示窗口的高度之和大于屏幕高度
				if (Location.Y + Height >= screenHeight)
				{
					Location = new Point(Location.X, Location.Y - 20);
				}
			}
			else//如果提示窗口已经完成了显示，并且点击了确定按钮
			{
				//如果提示窗口没有完全从屏幕上消失
				if (Location.Y < screenHeight)
				{
					Location = new Point(Location.X, Location.Y + 20);
				}
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			//设置完成了显示，以便让提示控件移出屏幕可显示区域
			finished = true;
		}
	}
}
