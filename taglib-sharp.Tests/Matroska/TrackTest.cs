using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for Track</summary>
    [TestClass]
    [PexClass(typeof(Track))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TrackTest
    {

		/// <summary>Test stub for .ctor(File, EBMLreader)</summary>
		[PexMethod]
		public Track ConstructorTest(File _file, EBMLreader element)
		{
			Track target = new Track(_file, element);
			return target;
			// TODO: add assertions to method TrackTest.ConstructorTest(File, EBMLreader)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Track target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method TrackTest.DescriptionGetTest(Track)
		}

		/// <summary>Test stub for get_Duration()</summary>
		[PexMethod]
		public TimeSpan DurationGetTest([PexAssumeUnderTest]Track target)
		{
			TimeSpan result = target.Duration;
			return result;
			// TODO: add assertions to method TrackTest.DurationGetTest(Track)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]Track target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method TrackTest.MediaTypesGetTest(Track)
		}

		/// <summary>Test stub for get_UID()</summary>
		[PexMethod]
		public ulong UIDGetTest([PexAssumeUnderTest]Track target)
		{
			ulong result = target.UID;
			return result;
			// TODO: add assertions to method TrackTest.UIDGetTest(Track)
		}

		/// <summary>Test stub for get_UIDType()</summary>
		[PexMethod]
		public MatroskaID UIDTypeGetTest([PexAssumeUnderTest]Track target)
		{
			MatroskaID result = target.UIDType;
			return result;
			// TODO: add assertions to method TrackTest.UIDTypeGetTest(Track)
		}

		/// <summary>Test stub for get_UnknownElements()</summary>
		[PexMethod]
		public List<EBMLreader> UnknownElementsGetTest([PexAssumeUnderTest]Track target)
		{
			List<EBMLreader> result = target.UnknownElements;
			return result;
			// TODO: add assertions to method TrackTest.UnknownElementsGetTest(Track)
		}

		/// <summary>Test stub for set_UID(UInt64)</summary>
		[PexMethod]
		public void UIDSetTest([PexAssumeUnderTest]Track target, ulong value)
		{
			target.UID = value;
			// TODO: add assertions to method TrackTest.UIDSetTest(Track, UInt64)
		}
	}
}
