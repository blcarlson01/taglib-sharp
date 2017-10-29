using TagLib.Asf;
using System;
using Microsoft.Pex.Framework;

namespace TagLib.Asf
{
	/// <summary>A factory for TagLib.Asf.Tag instances</summary>
	public static partial class TagFactory
	{
		/// <summary>A factory for TagLib.Asf.Tag instances</summary>
		[PexFactoryMethod(typeof(Tag))]
		public static Tag Create(HeaderObject header_headerObject)
		{
			Tag tag = new Tag();
			return tag;

			// TODO: Edit factory method of Tag
			// This method should be able to configure the object in all possible ways.
			// Add as many parameters as needed,
			// and assign their values to each field by using the API.
		}
	}
}
