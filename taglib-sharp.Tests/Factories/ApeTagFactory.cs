using TagLib;
using TagLib.Ape;
using System;
using Microsoft.Pex.Framework;

namespace TagLib.Ape
{
	/// <summary>A factory for TagLib.Ape.Tag instances</summary>
	public static partial class TagFactory
	{
		/// <summary>A factory for TagLib.Ape.Tag instances</summary>
		[PexFactoryMethod(typeof(Tag))]
		public static Tag Create()
		{			
			return new Tag();		
		}
	}
}
