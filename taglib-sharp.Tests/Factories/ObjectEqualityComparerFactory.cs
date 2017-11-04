using System;
using Microsoft.Pex.Framework;

namespace System.Collections.Generic
{
	/// <summary>A factory for System.Collections.Generic.ObjectEqualityComparer`1[TagLib.ByteVector] instances</summary>
	public static partial class ObjectEqualityComparerFactory
	{
		/// <summary>A factory for System.Collections.Generic.ObjectEqualityComparer`1[TagLib.ByteVector] instances</summary>
		[PexFactoryMethod(typeof(GC), "System.Collections.Generic.ObjectEqualityComparer`1[[TagLib.ByteVector, taglib-sharp, Version=2.1.0.0, Culture=neutral, PublicKeyToken=db62eba44689b5b0]]")]
		public static object Create()
		{
			throw new NotImplementedException();

			// TODO: Edit factory method of ObjectEqualityComparer`1<ByteVector>
			// This method should be able to configure the object in all possible ways.
			// Add as many parameters as needed,
			// and assign their values to each field by using the API.
		}
	}
}
