using TagLib;
using TagLib.Riff;
using System;
using Microsoft.Pex.Framework;
using TagLib.Tests;

namespace TagLib.Riff
{
	/// <summary>A factory for TagLib.Riff.InfoTag instances</summary>
	public static partial class InfoTagFactory
	{
		/// <summary>A factory for TagLib.Riff.InfoTag instances</summary>
		[PexFactoryMethod(typeof(InfoTag))]
		public static InfoTag Create(long position_l, int length_i)
		{
			string sample_file = TestPath.Samples + "sample.avi";
			File file = new File(sample_file);
			InfoTag infoTag = new InfoTag(file, position_l, length_i);
			return infoTag;
		}

		[PexFactoryMethod(typeof(InfoTag))]
		public static InfoTag Create()
		{
			InfoTag infoTag = new InfoTag();
			return infoTag;
		}

		[PexFactoryMethod(typeof(InfoTag))]
		public static InfoTag Create(ByteVector byteVector)
		{
			PexAssume.IsNotNull(byteVector);
			PexAssume.IsTrue(byteVector.Count >= 127);
			PexAssume.IsTrue(byteVector.EndsWith("DIVXTAG"));
			InfoTag infoTag = new InfoTag(byteVector);
			return infoTag;
		}
	}
}
