using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoVisualSampleEntry</summary>
    [TestClass]
    [PexClass(typeof(IsoVisualSampleEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoVisualSampleEntryTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoVisualSampleEntry ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoVisualSampleEntry target = new IsoVisualSampleEntry(header, file, handler);
			return target;
			// TODO: add assertions to method IsoVisualSampleEntryTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]IsoVisualSampleEntry target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method IsoVisualSampleEntryTest.DescriptionGetTest(IsoVisualSampleEntry)
		}

		/// <summary>Test stub for get_Duration()</summary>
		[PexMethod]
		public TimeSpan DurationGetTest([PexAssumeUnderTest]IsoVisualSampleEntry target)
		{
			TimeSpan result = target.Duration;
			return result;
			// TODO: add assertions to method IsoVisualSampleEntryTest.DurationGetTest(IsoVisualSampleEntry)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]IsoVisualSampleEntry target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method IsoVisualSampleEntryTest.MediaTypesGetTest(IsoVisualSampleEntry)
		}

		/// <summary>Test stub for get_VideoHeight()</summary>
		[PexMethod]
		public int VideoHeightGetTest([PexAssumeUnderTest]IsoVisualSampleEntry target)
		{
			int result = target.VideoHeight;
			return result;
			// TODO: add assertions to method IsoVisualSampleEntryTest.VideoHeightGetTest(IsoVisualSampleEntry)
		}

		/// <summary>Test stub for get_VideoWidth()</summary>
		[PexMethod]
		public int VideoWidthGetTest([PexAssumeUnderTest]IsoVisualSampleEntry target)
		{
			int result = target.VideoWidth;
			return result;
			// TODO: add assertions to method IsoVisualSampleEntryTest.VideoWidthGetTest(IsoVisualSampleEntry)
		}
	}
}
