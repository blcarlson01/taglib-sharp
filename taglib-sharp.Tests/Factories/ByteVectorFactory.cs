using TagLib;
using System;
using Microsoft.Pex.Framework;

namespace TagLib
{
	/// <summary>A factory for TagLib.ByteVector instances</summary>
	public static partial class ByteVectorFactory
	{
		public static ByteVector Create(params byte[] data)
		{
			PexAssume.IsNotNull(data);
			ByteVector byteVector = new ByteVector(data);
			return byteVector;
		}

		public static ByteVector Create()
		{

			ByteVector byteVector = new ByteVector();
			return byteVector;

			// TODO: Edit factory method of ByteVector
			// This method should be able to configure the object in all possible ways.
			// Add as many parameters as needed,
			// and assign their values to each field by using the API.
		}
		/// <summary>A factory for TagLib.ByteVector instances</summary>
		[PexFactoryMethod(typeof(ByteVector))]
		public static ByteVector Create(byte[] data_bs, int length_i)
		{
			PexAssume.IsTrue(length_i > 0);
			PexAssume.IsTrue(length_i < data_bs.Length);
			ByteVector byteVector = new ByteVector(data_bs, length_i);
			return byteVector;
		}
	}
}
