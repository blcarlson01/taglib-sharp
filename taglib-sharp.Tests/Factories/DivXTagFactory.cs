using TagLib;
using TagLib.Riff;
using System;
using Microsoft.Pex.Framework;

namespace TagLib.Riff
{
	/// <summary>A factory for TagLib.Riff.DivXTag instances</summary>
	public static partial class DivXTagFactory
	{
		/// <summary>A factory for TagLib.Riff.DivXTag instances</summary>
		[PexFactoryMethod(typeof(DivXTag))]
		public static DivXTag Create()
		{
			DivXTag divXTag = new DivXTag();
			return divXTag;
		}

		[PexFactoryMethod(typeof(DivXTag))]
		public static DivXTag Create(ByteVector byteVector)
		{
			PexAssume.IsNotNull(byteVector);
			PexAssume.IsTrue(byteVector.Count >= 127);
			PexAssume.IsTrue(byteVector.EndsWith("DIVXTAG"));
			DivXTag divXTag = new DivXTag(byteVector);
			return divXTag;
		}
	}
}
