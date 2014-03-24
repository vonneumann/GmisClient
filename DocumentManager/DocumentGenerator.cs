using System;
using System.Windows.Forms ;
using System.Xml;
using System.Data;
using System.Reflection ;

namespace SZCGC.DocumentManager
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	public class DocumentGenerator
	{
		//定义文档真实名字
		private string _docRealName = "";
		public string DocRealName
		{
			get { return _docRealName; }
		}

		public DocumentGenerator()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public void GenerateDocument(DataSet ElementSet,DataSet EstateList,DataSet ChattelList,DataSet CarList,CCWordApp WordTemplate)
		{
			//遍历所有合同要素记录
			string strBookMarkName;
			string strElementValue;
			string strElementType;
			string strElementFrom;
			foreach (DataRow dr in ElementSet.Tables[0].Rows)
			{
				//'将项目合同要素替换合同模板的BOOKMARK标记；
				strBookMarkName= dr["element_bookmark"].ToString() == "" ? "" : dr["element_bookmark"].ToString();
				strElementValue=dr["element_value"].ToString() == "" ? "" : dr["element_value"].ToString();
				strElementType=dr["element_type"].ToString() == "" ? "" : dr["element_type"].ToString();
				strElementFrom=dr["element_from"].ToString() == "" ? "" : dr["element_from"].ToString();
				try
				{
					if (strElementType=="TEXT")
					{
						WordTemplate.GotoBookMark(strBookMarkName);
						WordTemplate.InsertText(strElementValue);
					}
					else if (strElementType=="GRID")
					{
						if (strElementFrom=="project_contract_estate_element" && EstateList!=null)
						{
							WordTemplate.CreateTalbe(EstateList,strBookMarkName);
						}
						else if (strElementFrom=="project_contract_chattel_element" && ChattelList!=null)
						{
							WordTemplate.CreateTalbe(ChattelList,strBookMarkName);
						}
						else if (strElementFrom=="project_contract_car_element" && CarList!=null)
						{
							WordTemplate.CreateTalbe(CarList,strBookMarkName);
						}
					}
				}
				catch (Exception er)
				{
					continue;
				}
			}

//			//获取文档模板及其绝对路径
//			XmlDocument docSetting = new XmlDocument();
//			docSetting.LoadXml(DocGenerateSetting);
//			XmlNode docSettingNode = docSetting.FirstChild;
//			string fileServerPath = docSettingNode.Attributes["template"].Value;
//			string filePath = fileServerPath;
//
//			//设置文档真实名字
//			string strDotName=filePath.Substring(filePath.LastIndexOf("\\") + 1);
//			_docRealName=strDotName.Substring(0,strDotName.LastIndexOf("."))+".doc";
//
//			//打开文档模板
//			CCWordApp objCCWordApp = new CCWordApp();
////			objCCWordApp.ojbInvokeControlMember = new InvokeControlMemberDelegate(this.InvokeControlMember);
//			objCCWordApp.Open(filePath);
//
////			//设置文字居中
////			objCCWordApp.SetAlignment("Center");
//
//
//			//遍历所有的BookMark节点
//			foreach (XmlNode tmpNode in docSettingNode.SelectNodes("BookMark"))
//			{
//				string strBookMarkName = tmpNode.Attributes["id"].Value;
//
//				//遍历所有BookMark节点下Control节点
//				foreach (XmlNode tmpControlNode in tmpNode.SelectNodes("Control"))
//				{
//					string[] strControls = tmpControlNode.Attributes["id"].Value.Split(new char[] { '.' });
//					string strParentControlID = "";
//					string strControlID="";
//					if (strControls.Length != 0)
//					{
//						strParentControlID = strControls[0].ToString();
//						strControlID = strControls[1].ToString();
//					}
//					else
//					{
//						strParentControlID = "";
//						strControlID = tmpControlNode.Attributes["id"].Value;
//					}
//
//					string strControlType = tmpControlNode.Attributes["type"].Value;
//					string strControlInvokeAttribute = tmpControlNode.Attributes["invokeattribute"].Value;
//
//					//遍历用户控件上的所有控件//
//					foreach (Control c in ObjForm.Controls)
//					{
//						//如果控件ID与配置文件定义匹配//
//						if (c.GetType().ToString() == strControlType & c.Name == strControlID)
//						{
//							try
//							{
//								//将文档中相应的BookMark设置为该控件的属性值
//
//								objCCWordApp.GotoBookMark(strBookMarkName);
//								if (c is System.Windows.Forms.DataGrid)
//								{
//									objCCWordApp.CreateTalbe((c as System.Windows.Forms.DataGrid),strBookMarkName);
//								}
//								else
//								{
//									objCCWordApp.InsertText(InvokeControlMember(strControlInvokeAttribute, c));
//								}
//
//								break;
//							}
//							catch 
//							{
//								break;
//							}
//						}
//					}
//				}
//			}
//
//			//保存生成的文档//
//			string saveDocName= Guid.NewGuid().ToString() +".doc";
//			string saveDocPath = @System.Windows.Forms.Application.StartupPath + @"\Document\" + saveDocName;
//			objCCWordApp.SaveAs(saveDocPath);       
//
//			objCCWordApp.Quit();
//
//			//返回文档名称
//			return saveDocName;
		}

//		//从数据库中读取文档并下载到服务器端目录//
//		public string DownloadFile(string FileGuid)
//		{
//			//根据GUID从数据库中获取文档字节流
//			byte[] objByte = Container2.OpenFile(FileGuid);
//
//			//根据GUID从数据库中获取文档名和文档类型//
//			string strSql = " SELECT file_type,file_name" +
//				" FROM risk_project_file" +
//				" WHERE risk_project_file_guid='" + FileGuid + "'";
//			DataTable dt = Container2.GetCommonData(strSql, "TempTable");
//			string strFileType = "";
//			string strFileName = "";
//			if (dt.Rows.Count != 0)
//			{
//				strFileType = (string)dt.Rows[0]["file_type"];
//				strFileName = (string)dt.Rows[0]["file_name"];
//			}
//
//
//			//设置文档真实名字
//			_docRealName = strFileName ;
//
//			//在服务器端的Document目录中创建该文档
//			string strDocName = Guid.NewGuid().ToString() + "." + strFileType;
//			string FilePath = @IoryCommon.GetServerPath() + @"\Document\" + strDocName;
//			FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
//
//			//将文档字节流写入文档中//
//			fs.Write(objByte, 0, objByte.Length);
//			fs.Close();
//
//			//返回文档名称
//			return strDocName;
// 
//		}

		//使用反射调用控件的属性
		private string InvokeControlMember(string InvokeAttribute,Control Control)
		{
//			if (Control is System.Web.UI.WebControls.DropDownList)
//			{
//				return (Control as Iory.Framework.WebControls.NewDropDownList).SelectedItem.Text;
//			}
//			else if (Control is System.Web.UI.WebControls.CheckBox)
//			{
//				if ((Control as System.Web.UI.WebControls.CheckBox).Checked)
//				{ 
//					return "是";
//				}
//				else
//				{
//					return "否";
//				}
//
//			}
			return (string)Control.GetType().InvokeMember(InvokeAttribute, BindingFlags.GetProperty, null, Control, null);
        
		}
	}
}
