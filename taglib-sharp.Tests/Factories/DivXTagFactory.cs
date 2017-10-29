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
		public static DivXTag Create(ByteVector data_byteVector)
		{
			DivXTag divXTag = new DivXTag();
			return divXTag;

			// TODO: Edit factory method of DivXTag
			// This method should be able to configure the object in all possible ways.
			// Add as many parameters as needed,
			// and assign their values to each field by using the API.
		}
	}
}
