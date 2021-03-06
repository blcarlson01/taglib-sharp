using TagLib;
using TagLib.Riff;
using System;
using Microsoft.Pex.Framework;
using TagLib.Tests;


namespace TagLib.Riff
{
	/// <summary>A factory for TagLib.Riff.File instances</summary>
	public static partial class RiffFileFactory
	{
		/// <summary>A factory for TagLib.Riff.File instances</summary>
		[PexFactoryMethod(typeof(File))]
		public static File Create()
		{
			string sample_file = TestPath.Samples + "sample.avi";			
			File file = new File(sample_file);			
			return file;
		}
	}
}
