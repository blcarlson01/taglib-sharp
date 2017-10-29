using TagLib;
using System;
using Microsoft.Pex.Framework;

namespace TagLib
{
	/// <summary>A factory for TagLib.ByteVector instances</summary>
	public static partial class ByteVectorFactory
	{
		/// <summary>A factory for TagLib.ByteVector instances</summary>
		[PexFactoryMethod(typeof(ByteVector))]
		public static ByteVector Create()
		{
			
			ByteVector byteVector = new ByteVector();
			return byteVector;

			// TODO: Edit factory method of ByteVector
			// This method should be able to configure the object in all possible ways.
			// Add as many parameters as needed,
			// and assign their values to each field by using the API.
		}
	}
}
