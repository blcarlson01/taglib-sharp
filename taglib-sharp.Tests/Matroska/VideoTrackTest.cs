using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for VideoTrack</summary>
    [TestClass]
    [PexClass(typeof(VideoTrack))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class VideoTrackTest
    {

		/// <summary>Test stub for .ctor(File, EBMLreader)</summary>
		[PexMethod]
		public VideoTrack ConstructorTest(File _file, EBMLreader element)
		{
			VideoTrack target = new VideoTrack(_file, element);
			return target;
			// TODO: add assertions to method VideoTrackTest.ConstructorTest(File, EBMLreader)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]VideoTrack target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method VideoTrackTest.MediaTypesGetTest(VideoTrack)
		}

		/// <summary>Test stub for get_UnknownElements()</summary>
		[PexMethod]
		public List<EBMLreader> UnknownElementsGetTest([PexAssumeUnderTest]VideoTrack target)
		{
			List<EBMLreader> result = target.UnknownElements;
			return result;
			// TODO: add assertions to method VideoTrackTest.UnknownElementsGetTest(VideoTrack)
		}

		/// <summary>Test stub for get_VideoHeight()</summary>
		[PexMethod]
		public int VideoHeightGetTest([PexAssumeUnderTest]VideoTrack target)
		{
			int result = target.VideoHeight;
			return result;
			// TODO: add assertions to method VideoTrackTest.VideoHeightGetTest(VideoTrack)
		}

		/// <summary>Test stub for get_VideoWidth()</summary>
		[PexMethod]
		public int VideoWidthGetTest([PexAssumeUnderTest]VideoTrack target)
		{
			int result = target.VideoWidth;
			return result;
			// TODO: add assertions to method VideoTrackTest.VideoWidthGetTest(VideoTrack)
		}
	}
}
