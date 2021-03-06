using TagLib;
using TagLib.Id3v1;
using System;
using Microsoft.Pex.Framework;
using TagLib.Tests;

namespace TagLib.Id3v1
{
	/// <summary>A factory for TagLib.Id3v1.Tag instances</summary>
	public static partial class TagFactory
	{
		/// <summary>A factory for TagLib.Id3v1.Tag instances</summary>
		[PexFactoryMethod(typeof(Tag))]
		public static Tag Create(ByteVector byteVector)
		{
			PexAssume.IsNotNull(byteVector);
			PexAssume.IsTrue(byteVector.Count >= 125);
			Tag tag = new Tag(byteVector);
			return tag;
		}

		[PexFactoryMethod(typeof(Tag))]
		public static Tag Create()
		{
			Tag tag = new Tag();
			ByteVector rendered = tag.Render();
			return new Id3v1.Tag(rendered); 
		}
		
	}
}
