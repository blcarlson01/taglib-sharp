using TagLib.Asf;
using System;
using Microsoft.Pex.Framework;

namespace TagLib.Asf
{
	/// <summary>A factory for TagLib.Asf.HeaderObject instances</summary>
	public static partial class HeaderObjectFactory
	{
		/// <summary>A factory for TagLib.Asf.HeaderObject instances</summary>
		[PexFactoryMethod(typeof(HeaderObject))]
		public static HeaderObject Create(File file_file, long position_l)
		{
			HeaderObject headerObject = new HeaderObject(file_file, position_l);
			return headerObject;

			// TODO: Edit factory method of HeaderObject
			// This method should be able to configure the object in all possible ways.
			// Add as many parameters as needed,
			// and assign their values to each field by using the API.
		}
	}
}
