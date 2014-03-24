using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
//using PDF=PDFMAKERAPILib;
using PortableOpenOffice;

namespace SZCGC.DocumentManager
{
	/// <summary>
	/// 
	/// </summary>
	/// 

	public class CCWordApp 
	{
		private Word.ApplicationClass oWordApplic;	// a reference to Word application
		private Word.Document oDoc;					// a reference to the document

//        public InvokeControlMemberDelegate ojbInvokeControlMember;
        		
		public CCWordApp()
		{
			// activate the interface with the COM object of Microsoft Word
			oWordApplic = new Word.ApplicationClass();
		}

		// Open a file (the file must exists) and activate it
		public void Open( string strFileName)
		{
//			oWordApplic = new Word.ApplicationClass();
            object fileName = strFileName;
            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;
            string strFileType = strFileName.Substring(strFileName.LastIndexOf(".") + 1);

            if (strFileType == "doc")
            {
                object templatePath=@strFileName;
                oDoc = oWordApplic.Documents.Add(ref templatePath, ref missing, ref missing, ref missing);
            }
            else
            {
                oDoc = oWordApplic.Documents.Open(ref fileName, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
            }
            oDoc.Activate();			
		}		


		// Open a new document
		public void Open( )
		{
			object missing = System.Reflection.Missing.Value;
			oDoc = oWordApplic.Documents.Add(ref missing, ref missing,ref missing, ref missing);

			oDoc.Activate();			
		}		


		public void ActiveDoc(string strFileName)
		{
			oWordApplic.Application.Visible = true;
		}

		public void Quit( )
		{
			object missing = System.Reflection.Missing.Value;
			if (oDoc !=null)
			{
				oDoc.Close(ref missing, ref missing, ref missing);
				oDoc = null;
			}
			if (oWordApplic!=null)
			{
				oWordApplic.Application.Quit(ref missing, ref missing, ref missing);
				oWordApplic = null;
			}		
		}
		
		public void FormProtect(ref object PassWord)
		{
			object missing = System.Reflection.Missing.Value;
			oDoc.Protect(Word.WdProtectionType.wdAllowOnlyFormFields,ref missing, ref PassWord, ref missing,ref missing);
		}

		public void Save( )
		{
			oDoc.Save();			
		}		

		public void SaveAs(string strFileName )
		{
			object missing = System.Reflection.Missing.Value;
			object fileName = strFileName;

			oDoc.SaveAs(ref fileName, ref missing,ref missing, ref missing,ref missing,ref missing,ref missing,
				ref missing,ref missing,ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
		}		

		// Save the document in HTML format
		public void SaveAsHtml(string strFileName )
		{
			object missing = System.Reflection.Missing.Value;
			object fileName = strFileName;
			object Format = (int)Word.WdSaveFormat.wdFormatHTML;
			oDoc.SaveAs(ref fileName, ref Format,ref missing, ref missing,ref missing,ref missing,ref missing,
				ref missing,ref missing,ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
		}		

//		public void SaveAsPdf(string strFileName )
//		{
////			object missing = System.Type.Missing;
////			
////			object pdfPath=strFileName.Substring(0,strFileName.LastIndexOf("."))+".pdf";
////			
////			object oBoolF =new object();
////			oBoolF=false;
////			object oBoolT =new object();
////			oBoolT=true;
////			object Range =new object();
////			Range = Word.WdPrintOutRange.wdPrintAllDocument;
////			object Item =new object();
////			Item = Word.WdPrintOutItem.wdPrintDocumentContent;
////			object PageType =new object();
////			PageType = Word.WdPrintOutPages.wdPrintAllPages;
////			
////			object oStr =new object();
////			oStr="";
////			
////			object oNum0=new object();
////			oNum0=0;
////			
////			object oNum1=new object();
////			oNum1=1;
////			
////			try
////			{
////				oWordApplic = new Word.ApplicationClass();
////				this.Open(strFileName);
////				oWordApplic.ActivePrinter = "Adobe PDF";
////			
////				oWordApplic.PrintOut(ref oBoolF,ref missing ,ref Range, ref pdfPath,ref missing,ref missing ,ref Item,ref oNum1, ref oStr, ref PageType, ref oBoolF,ref oBoolT, ref oStr,ref missing , ref oBoolF, ref oNum0, ref oNum0, ref oNum0,ref oNum0);
////							
////				System.Diagnostics.Process.Start((string)pdfPath);
////				//			
////				//								PDF.PDFMakerApp app = new PDF.PDFMakerApp();
////				//								app.CreatePDF(strFileName,pdfPath,PDF.PDFMakerSettings.kConvertAllPages,false,true,true,missing);
////				//								System.Diagnostics.Process.Start(pdfPath);
////			}
////			catch(Exception er)
////			{
////				MessageBox.Show(er.ToString());
////			}
////			finally
////			{
////				Quit();
////			}		
//
//			string pdfPath=strFileName.Substring(0,strFileName.LastIndexOf("."))+".pdf";
//			object missing = System.Type.Missing;
//
//			try
//			{						
//				PDF.PDFMakerApp app = new PDF.PDFMakerApp();
//				app.CreatePDF(strFileName,pdfPath,PDF.PDFMakerSettings.kConvertAllPages,false,true,true,missing);
//				System.Diagnostics.Process.Start(pdfPath);
//			}
//			catch(Exception er)
//			{
//				MessageBox.Show(er.ToString());
//			}
//			finally
//			{
//				Quit();
//			}		
//
//			//			string pdfPath=strFileName.Substring(0,strFileName.LastIndexOf("."))+".pdf";
//			//			try
//			//			{
//			//				OpenOffice.Instance.ConvertToPDF(strFileName,pdfPath);
//			//				System.Diagnostics.Process.Start(pdfPath);
//			//			}
//			//			catch (Exception er)
//			//			{
//			//				MessageBox.Show(er.ToString());
//			//			}
//			//			finally
//			//			{
//			//				Quit();
//			//			}	
//		}

		public void InsertText( string strText)
		{
			oWordApplic.Selection.TypeText(strText);
		}

		public void InsertLineBreak( )
		{
			oWordApplic.Selection.TypeParagraph();
		}
		public void InsertLineBreak( int nline)
		{
			for (int i=0; i<nline; i++)
				oWordApplic.Selection.TypeParagraph();
		}

		// Change the paragraph alignement
		public void SetAlignment(string strType )
		{
			switch (strType)
			{
				case "Center" :
					oWordApplic.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
				break;
				case "Left" :
					oWordApplic.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
					break;
				case "Right" :
					oWordApplic.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
					break;
				case "Justify" :
					oWordApplic.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
					break;
			}
	
		}


		// if you use thif function to change the font you should call it again with 
		// no parameter in order to set the font without a particular format
		public void SetFont( string strType )
		{
			switch (strType)
			{
				case "Bold":
					oWordApplic.Selection.Font.Bold = 1;
					break;
				case "Italic":
					oWordApplic.Selection.Font.Italic = 1;
					break;
				case "Underlined":
					oWordApplic.Selection.Font.Subscript = 0;
					break;
			}
			
		}
		
		// disable all the style 
		public void SetFont( )
		{
			oWordApplic.Selection.Font.Bold = 0;
			oWordApplic.Selection.Font.Italic = 0;
			oWordApplic.Selection.Font.Subscript = 0;
		
		}

		public void SetFontName( string strType )
		{
			oWordApplic.Selection.Font.Name = strType;
			
		} 

		public void SetFontSize( int nSize )
		{
			oWordApplic.Selection.Font.Size = nSize;
			
		} 

		public void InsertPagebreak()
		{
			// VB : Selection.InsertBreak Type:=wdPageBreak
			object pBreak= (int)Word.WdBreakType.wdPageBreak;
			oWordApplic.Selection.InsertBreak(ref pBreak );
		}

		// Go to a predefined bookmark, if the bookmark doesn't exists the application will raise an error

		public Word.Range GotoBookMark( string strBookMarkName)
		{
			// VB :  Selection.GoTo What:=wdGoToBookmark, Name:="nome"
			object missing = System.Reflection.Missing.Value;

			object Bookmark = (int)Word.WdGoToItem.wdGoToBookmark;
			object NameBookMark = strBookMarkName;
			return oWordApplic.Selection.GoTo(ref Bookmark, ref missing, ref missing,ref NameBookMark);
		}

		public void GoToTheEnd( )
		{
			// VB :  Selection.EndKey Unit:=wdStory
			object missing = System.Reflection.Missing.Value;
			object unit ;
			unit = Word.WdUnits.wdStory ;
			oWordApplic.Selection.EndKey ( ref unit, ref missing);
			
		} 
		public void GoToTheBeginning( )
		{
			// VB : Selection.HomeKey Unit:=wdStory
			object missing = System.Reflection.Missing.Value;
			object unit ;
			unit = Word.WdUnits.wdStory ;
			oWordApplic.Selection.HomeKey ( ref unit, ref missing);
			
		} 

		public void GoToTheTable(int ntable )
		{
			//	Selection.GoTo What:=wdGoToTable, Which:=wdGoToFirst, Count:=1, Name:=""
			//    Selection.Find.ClearFormatting
			//    With Selection.Find
			//        .Text = ""
			//        .Replacement.Text = ""
			//        .Forward = True
			//        .Wrap = wdFindContinue
			//        .Format = False
			//        .MatchCase = False
			//        .MatchWholeWord = False
			//        .MatchWildcards = False
			//        .MatchSoundsLike = False
			//        .MatchAllWordForms = False
			//    End With

			object missing = System.Reflection.Missing.Value;
			object what;
			what = Word.WdUnits.wdTable ;
			object which;
			which = Word.WdGoToDirection.wdGoToFirst;
			object count;
			count = 1 ;
			oWordApplic.Selection.GoTo( ref what, ref which, ref count, ref missing);
			oWordApplic.Selection.Find.ClearFormatting();

			oWordApplic.Selection.Text = "";
						
		} 

		public void GoToRightCell( )
		{
			// Selection.MoveRight Unit:=wdCell
			
			object missing = System.Reflection.Missing.Value;
			object direction;
			direction = Word.WdUnits.wdCell;
			oWordApplic.Selection.MoveRight(ref direction,ref missing,ref missing);
		} 

		public void GoToLeftCell( )
		{
			// Selection.MoveRight Unit:=wdCell
			
			object missing = System.Reflection.Missing.Value;
			object direction;
			direction = Word.WdUnits.wdCell;
			oWordApplic.Selection.MoveLeft(ref direction,ref missing,ref missing);
		} 

		public void GoToDownCell( )
		{
			// Selection.MoveRight Unit:=wdCell
			
			object missing = System.Reflection.Missing.Value;
			object direction;
			direction = Word.WdUnits.wdLine;
			oWordApplic.Selection.MoveDown(ref direction,ref missing,ref missing);
		} 

		public void GoToUpCell( )
		{
			// Selection.MoveRight Unit:=wdCell
			
			object missing = System.Reflection.Missing.Value;
			object direction;
			direction = Word.WdUnits.wdLine;
			oWordApplic.Selection.MoveUp(ref direction,ref missing,ref missing);
		}

		public void CreateTalbe(DataSet ObjData,string strBookMarkName)
		{
			if (ObjData.Tables[0].Rows.Count !=0)
			{
				object missing = System.Reflection.Missing.Value;
			
				//object start = 0;
				//object end = 0;
				//Word.Range tableLocation = oWordApplic.ActiveDocument.Range(ref start, ref end);
				Word.Range tableLocation = GotoBookMark(strBookMarkName);

				int rowCount;
				int colCount;

				////判断是否包含选择列
				//bool hasSelectColumn;
				//hasSelectColumn = false;
				//foreach (TableCell tc in HeadRow.Cells)
				//{
				//    if (tc.Text == "&nbsp;")
				//    {
				//        hasSelectColumn = true;
				//        break;
				//    }
				//}

				//if (hasSelectColumn)
				//{
				//    colCount = HeadRow.Cells.Count - 1;
				//}
				//else
				//{
				//    colCount = HeadRow.Cells.Count;
				//}




				//在WORD中生成表格,列数为表的列数，行数为表的行数加1,因为有列标题行
				ObjData.Tables[0].Columns.Remove("project_code");
				ObjData.Tables[0].Columns.Remove("contract_name");
				ObjData.Tables[0].Columns.Remove("num");


				DataTable dt=ObjData.Tables[0];
				colCount=dt.Columns.Count ;
				rowCount = dt.Rows.Count + 1;


				Word.Table objTable = oWordApplic.Selection.Tables.Add(tableLocation, rowCount, colCount, ref missing, ref missing);

				Word.Border border=objTable.Borders[Word.WdBorderType.wdBorderLeft];
				border.LineStyle=Word.WdLineStyle.wdLineStyleSingle;
				border.LineWidth=Word.WdLineWidth.wdLineWidth050pt;
				border.Color=Word.WdColor.wdColorAutomatic;

				border=objTable.Borders[Word.WdBorderType.wdBorderRight];
				border.LineStyle=Word.WdLineStyle.wdLineStyleSingle;
				border.LineWidth=Word.WdLineWidth.wdLineWidth050pt;
				border.Color=Word.WdColor.wdColorAutomatic;

				border=objTable.Borders[Word.WdBorderType.wdBorderTop];
				border.LineStyle=Word.WdLineStyle.wdLineStyleSingle;
				border.LineWidth=Word.WdLineWidth.wdLineWidth050pt;
				border.Color=Word.WdColor.wdColorAutomatic;

				border=objTable.Borders[Word.WdBorderType.wdBorderBottom];
				border.LineStyle=Word.WdLineStyle.wdLineStyleSingle;
				border.LineWidth=Word.WdLineWidth.wdLineWidth050pt;
				border.Color=Word.WdColor.wdColorAutomatic;

				border=objTable.Borders[Word.WdBorderType.wdBorderHorizontal];
				border.LineStyle=Word.WdLineStyle.wdLineStyleSingle;
				border.LineWidth=Word.WdLineWidth.wdLineWidth050pt;
				border.Color=Word.WdColor.wdColorAutomatic;

				border=objTable.Borders[Word.WdBorderType.wdBorderVertical];
				border.LineStyle=Word.WdLineStyle.wdLineStyleSingle;
				border.LineWidth=Word.WdLineWidth.wdLineWidth050pt;
				border.Color=Word.WdColor.wdColorAutomatic;

				int colIndex ;
				int rowIndex ;

				//创建列标题行
				colIndex = 0;

				if (ObjData.Tables[0].TableName=="project_contract_estate_element")
				{
					foreach (DataColumn dc in dt.Columns)
					{
						colIndex += 1;
						if (dc.ColumnName=="obligee")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("房地产权利人");
						}
						else if (dc.ColumnName=="credentials")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("房地产证号");
						}
						else if (dc.ColumnName=="detail")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("房地产名称、栋号、房号");
						}			
					
					}
				}
				else if (ObjData.Tables[0].TableName=="project_contract_chattel_element")
				{
					foreach (DataColumn dc in dt.Columns)
					{
						colIndex += 1;

						objTable.Cell(1, colIndex).Range.Select();
						this.SetAlignment("Center");

						if (dc.ColumnName=="name")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("名称");
							objTable.Columns[colIndex].PreferredWidthType=Word.WdPreferredWidthType.wdPreferredWidthPercent;
							objTable.Columns[colIndex].PreferredWidth=25F;
						}
						else if (dc.ColumnName=="amount")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("数量");
							objTable.Columns[colIndex].PreferredWidthType=Word.WdPreferredWidthType.wdPreferredWidthPercent;
							objTable.Columns[colIndex].PreferredWidth=10F;
						}
						else if (dc.ColumnName=="source_amount")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("原值");
							objTable.Columns[colIndex].PreferredWidthType=Word.WdPreferredWidthType.wdPreferredWidthPercent;
							objTable.Columns[colIndex].PreferredWidth=15F;
						}			
						else if (dc.ColumnName=="specification")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("编号(型号)");
							objTable.Columns[colIndex].PreferredWidthType=Word.WdPreferredWidthType.wdPreferredWidthPercent;
							objTable.Columns[colIndex].PreferredWidth=25F;
						}		
						else if (dc.ColumnName=="invoice_num")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("发票号码");
							objTable.Columns[colIndex].PreferredWidthType=Word.WdPreferredWidthType.wdPreferredWidthPercent;
							objTable.Columns[colIndex].PreferredWidth=25F;
						}		
					}
				}
				else if (ObjData.Tables[0].TableName=="project_contract_car_element")
				{
					foreach (DataColumn dc in dt.Columns)
					{
						colIndex += 1;

						objTable.Cell(1, colIndex).Range.Select();
						this.SetAlignment("Center");

						if (dc.ColumnName=="car_owner")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("机动车所有人");
						}
						else if (dc.ColumnName=="car_type")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("车辆类型");
						}
						else if (dc.ColumnName=="car_register_num")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("机动车登记编号");
						}			
						else if (dc.ColumnName=="car_num")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("车牌号码");
						}		
						else if (dc.ColumnName=="car_brand_num")
						{
							objTable.Cell(1, colIndex).Range.InsertAfter("品牌型号");
						}		
					}
				}

				//创建数据行
				rowIndex = 1;
				foreach (DataRow dr in dt.Rows)
				{
					rowIndex += 1;
					colIndex=0;
					foreach (DataColumn dc in dr.Table.Columns)
					{				
						colIndex+=1;                  
						objTable.Cell(rowIndex, colIndex).Range.InsertAfter(dr[dc.ColumnName].ToString());
						objTable.Cell(rowIndex, colIndex).Range.Select();
						this.SetAlignment("Center");
					}
				}

				//设置表格格式
				//objTable.Borders.InsideLineStyle = 1;
				//objTable.Borders.OutsideLineStyle = 1;

			}

	
			//// this function doesn't work
			//public void InsertPageNumber( string strType, bool bHeader )
			//{
			//    object missing = System.Reflection.Missing.Value;
			//    object alignment ;
			//    object bFirstPage = false;
			//    object bF = true;
			//    //if (bHeader == true)
			//    //WordApplic.Selection.HeaderFooter.PageNumbers.ShowFirstPageNumber = bF;
			//    switch (strType)
			//    {
			//        case "Center":
			//            alignment = Word.WdPageNumberAlignment.wdAlignPageNumberCenter;
			//            //WordApplic.Selection.HeaderFooter.PageNumbers.Add(ref alignment,ref bFirstPage);
			//            //Word.Selection objSelection = WordApplic.pSelection;
					
			//            oWordApplic.Selection.HeaderFooter.PageNumbers.Item(1).Alignment = Word.WdPageNumberAlignment.wdAlignPageNumberCenter;
			//            break;
			//        case "Right":
			//            alignment = Word.WdPageNumberAlignment.wdAlignPageNumberRight;
			//            oWordApplic.Selection.HeaderFooter.PageNumbers.Item(1).Alignment = Word.WdPageNumberAlignment.wdAlignPageNumberRight;
			//            break;
			//        case "Left":
			//            alignment = Word.WdPageNumberAlignment.wdAlignPageNumberLeft;
			//            oWordApplic.Selection.HeaderFooter.PageNumbers.Add(ref alignment,ref bFirstPage);
			//            break;
			//    }
            
			//}
		}

	}
	//object units = WdUnits.wdCharacter;
	//object last=doc.Characters.Count;
	//doc.Range(ref first, ref last).Delete(ref units, ref last)
}
