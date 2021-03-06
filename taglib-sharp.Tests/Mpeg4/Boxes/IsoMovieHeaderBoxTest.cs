using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoMovieHeaderBox</summary>
    [TestClass]
    [PexClass(typeof(IsoMovieHeaderBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoMovieHeaderBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoMovieHeaderBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoMovieHeaderBox target = new IsoMovieHeaderBox(header, file, handler);
			return target;
			// TODO: add assertions to method IsoMovieHeaderBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_CreationTime()</summary>
		[PexMethod]
		public DateTime CreationTimeGetTest([PexAssumeUnderTest]IsoMovieHeaderBox target)
		{
			DateTime result = target.CreationTime;
			return result;
			// TODO: add assertions to method IsoMovieHeaderBoxTest.CreationTimeGetTest(IsoMovieHeaderBox)
		}

		/// <summary>Test stub for get_Duration()</summary>
		[PexMethod]
		public TimeSpan DurationGetTest([PexAssumeUnderTest]IsoMovieHeaderBox target)
		{
			TimeSpan result = target.Duration;
			return result;
			// TODO: add assertions to method IsoMovieHeaderBoxTest.DurationGetTest(IsoMovieHeaderBox)
		}

		/// <summary>Test stub for get_ModificationTime()</summary>
		[PexMethod]
		public DateTime ModificationTimeGetTest([PexAssumeUnderTest]IsoMovieHeaderBox target)
		{
			DateTime result = target.ModificationTime;
			return result;
			// TODO: add assertions to method IsoMovieHeaderBoxTest.ModificationTimeGetTest(IsoMovieHeaderBox)
		}

		/// <summary>Test stub for get_NextTrackId()</summary>
		[PexMethod]
		public uint NextTrackIdGetTest([PexAssumeUnderTest]IsoMovieHeaderBox target)
		{
			uint result = target.NextTrackId;
			return result;
			// TODO: add assertions to method IsoMovieHeaderBoxTest.NextTrackIdGetTest(IsoMovieHeaderBox)
		}

		/// <summary>Test stub for get_Rate()</summary>
		[PexMethod]
		public double RateGetTest([PexAssumeUnderTest]IsoMovieHeaderBox target)
		{
			double result = target.Rate;
			return result;
			// TODO: add assertions to method IsoMovieHeaderBoxTest.RateGetTest(IsoMovieHeaderBox)
		}

		/// <summary>Test stub for get_Volume()</summary>
		[PexMethod]
		public double VolumeGetTest([PexAssumeUnderTest]IsoMovieHeaderBox target)
		{
			double result = target.Volume;
			return result;
			// TODO: add assertions to method IsoMovieHeaderBoxTest.VolumeGetTest(IsoMovieHeaderBox)
		}
	}
}
