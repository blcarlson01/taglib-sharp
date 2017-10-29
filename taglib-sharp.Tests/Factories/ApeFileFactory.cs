using TagLib;
using TagLib.Ape;
using System;
using Microsoft.Pex.Framework;

namespace TagLib.Ape
{
	/// <summary>A factory for TagLib.Ape.File instances</summary>
	public static partial class FileFactory
	{
		/// <summary>A factory for TagLib.Ape.File instances</summary>
		[PexFactoryMethod(typeof(File))]
		public static File Create(
			File.IFileAbstraction abstraction_iFileAbstraction,
			ReadStyle propertiesStyle_i,
			string value_s,
			string reason_s1
		)
		{
			//var tag = (Audible.Tag)File.Create(Path.Combine(BaseDirectory, "first.aa")).Tag;

			File file = new File(abstraction_iFileAbstraction, propertiesStyle_i);
			
			return file;

			// TODO: Edit factory method of File
			// This method should be able to configure the object in all possible ways.
			// Add as many parameters as needed,
			// and assign their values to each field by using the API.
		}
	}
}
