using TagLib.Aac;
using System;
using Microsoft.Pex.Framework;

namespace TagLib.Aac
{
	/// <summary>A factory for TagLib.Aac.AudioHeader instances</summary>
	public static partial class AudioHeaderFactory
	{
		/// <summary>A factory for TagLib.Aac.AudioHeader instances</summary>
		[PexFactoryMethod(typeof(AudioHeader))]
		public static object Create()
		{
			return AudioHeader.Unknown;
		}
	}
}
