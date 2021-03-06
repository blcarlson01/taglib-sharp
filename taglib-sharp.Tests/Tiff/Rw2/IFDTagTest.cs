using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Tiff.Rw2;

namespace TagLib.Tiff.Rw2.Tests
{
    /// <summary>This class contains parameterized unit tests for IFDTag</summary>
    [TestClass]
    [PexClass(typeof(IFDTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IFDTagTest
    {

		

		/// <summary>Test stub for get_FocalLengthIn35mmFilm()</summary>
		[PexMethod]
		public uint? FocalLengthIn35mmFilmGetTest([PexAssumeUnderTest]IFDTag target)
		{
			uint? result = target.FocalLengthIn35mmFilm;
			return result;
			// TODO: add assertions to method IFDTagTest.FocalLengthIn35mmFilmGetTest(IFDTag)
		}

		/// <summary>Test stub for get_ISOSpeedRatings()</summary>
		[PexMethod]
		public uint? ISOSpeedRatingsGetTest([PexAssumeUnderTest]IFDTag target)
		{
			uint? result = target.ISOSpeedRatings;
			return result;
			// TODO: add assertions to method IFDTagTest.ISOSpeedRatingsGetTest(IFDTag)
		}

		/// <summary>Test stub for set_FocalLengthIn35mmFilm(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void FocalLengthIn35mmFilmSetTest([PexAssumeUnderTest]IFDTag target, uint? value)
		{
			target.FocalLengthIn35mmFilm = value;
			// TODO: add assertions to method IFDTagTest.FocalLengthIn35mmFilmSetTest(IFDTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_ISOSpeedRatings(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void ISOSpeedRatingsSetTest([PexAssumeUnderTest]IFDTag target, uint? value)
		{
			target.ISOSpeedRatings = value;
			// TODO: add assertions to method IFDTagTest.ISOSpeedRatingsSetTest(IFDTag, Nullable`1<UInt32>)
		}
	}
}
