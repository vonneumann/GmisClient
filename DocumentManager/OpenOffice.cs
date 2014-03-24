using System;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace PortableOpenOffice
{
	public class OpenOffice
	{
		private static OpenOffice mInstance;
		public static OpenOffice Instance
		{
			get
			{
				if(mInstance==null)
					mInstance=new OpenOffice();
				return mInstance;
			}
		}
		private OpenOffice()
		{
		}

		public void ConvertToPDF(string SourceFilename,string DestinationFilename)
		{
			ProcessStartInfo startInfo=new ProcessStartInfo();
			startInfo.CreateNoWindow=true;
			startInfo.FileName=GetPortableOpenOfficeExecutable();
			startInfo.Arguments=String.Format("-invisible macro:///"+ConversionLibrary+"."+ConversionModule+"."+ConversionFunction+"(\"{0}\",\"{1}\")",
				SourceFilename,DestinationFilename);
			Process p=new Process();
			p.StartInfo=startInfo;
			p.Start();
			p.WaitForExit();
		}
		private string GetApplicationDirectory()
		{
			return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName)+@"\";
		}
		private string GetPortableOpenOfficeExecutable()
		{
			if((ConfigurationSettings.AppSettings["PortableOpenOfficeDirectory"]==null)||
				(ConfigurationSettings.AppSettings["PortableOpenOfficeExecutable"]==null))
				throw new Exception("Settings variables not configured: PortableOpenOfficeDirectory,PortableOpenOfficeExecutable");

			return GetApplicationDirectory()+ConfigurationSettings.AppSettings["PortableOpenOfficeDirectory"]+
				ConfigurationSettings.AppSettings["PortableOpenOfficeExecutable"];
		}
		private string ConversionLibrary
		{
			get
			{
				if(ConfigurationSettings.AppSettings["PortableOpenOfficeConversionLibrary"]==null)
					throw new Exception("Settings variable not configured: PortableOpenOfficeConversionLibrary");

				return ConfigurationSettings.AppSettings["PortableOpenOfficeConversionLibrary"];
			}
		}
		private string ConversionModule
		{
			get
			{
				if(ConfigurationSettings.AppSettings["PortableOpenOfficeConversionModule"]==null)
					throw new Exception("Settings variable not configured: PortableOpenOfficeConversionModule");

				return ConfigurationSettings.AppSettings["PortableOpenOfficeConversionModule"];
			}
		}
		private string ConversionFunction
		{
			get
			{
				if(ConfigurationSettings.AppSettings["PortableOpenOfficeConversionFunction"]==null)
					throw new Exception("Settings variable not configured: PortableOpenOfficeConversionFunction");

				return ConfigurationSettings.AppSettings["PortableOpenOfficeConversionFunction"];
			}
		}

	}
}
