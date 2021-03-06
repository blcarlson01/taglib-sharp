using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for SubtitleTrack</summary>
    [TestClass]
    [PexClass(typeof(SubtitleTrack))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SubtitleTrackTest
    {

		/// <summary>Test stub for .ctor(File, EBMLreader)</summary>
		[PexMethod]
		public SubtitleTrack ConstructorTest(File _file, EBMLreader element)
		{
			SubtitleTrack target = new SubtitleTrack(_file, element);
			return target;
			// TODO: add assertions to method SubtitleTrackTest.ConstructorTest(File, EBMLreader)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]SubtitleTrack target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method SubtitleTrackTest.MediaTypesGetTest(SubtitleTrack)
		}

		/// <summary>Test stub for get_UnknownElements()</summary>
		[PexMethod]
		public List<EBMLreader> UnknownElementsGetTest([PexAssumeUnderTest]SubtitleTrack target)
		{
			List<EBMLreader> result = target.UnknownElements;
			return result;
			// TODO: add assertions to method SubtitleTrackTest.UnknownElementsGetTest(SubtitleTrack)
		}
	}
}
