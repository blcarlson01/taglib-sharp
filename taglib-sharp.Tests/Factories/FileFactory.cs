using TagLib;
using TagLib.Aac;
using System;
using Microsoft.Pex.Framework;
using TagLib.Tests;

namespace TagLib.Aac
{
	/// <summary>A factory for TagLib.Aac.File instances</summary>
	public static partial class FileFactory
	{
		/// <summary>A factory for TagLib.Aac.File instances</summary>
		[PexFactoryMethod(typeof(File))]
		public static File Create(string tmp_file)
		{
			string sample_file = TestPath.Samples + "sample.aac";			
			System.IO.File.Copy(sample_file, tmp_file);
			File file = new File(tmp_file);
			//((File)file).MimeType = value_s;
			//((File)file).MarkAsCorrupt(reason_s1);
			return file;
		}
	}
}
