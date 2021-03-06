using TagLib;
using TagLib.Ape;
using System;
using Microsoft.Pex.Framework;
using TagLib.Tests;

namespace TagLib.Ape
{
	/// <summary>A factory for TagLib.Ape.File instances</summary>
	public static partial class FileFactory
	{
		/// <summary>A factory for TagLib.Ape.File instances</summary>
		[PexFactoryMethod(typeof(File))]
		public static File Create()
		{
			string sample_file = TestPath.Samples + "sample.ape";
			File file = new File(sample_file);
			return file;
		}
	}
}
