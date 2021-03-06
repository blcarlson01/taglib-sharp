using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for FilePropertiesObject</summary>
    [TestClass]
    [PexClass(typeof(FilePropertiesObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FilePropertiesObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public FilePropertiesObject ConstructorTest(File file, long position)
		{
			FilePropertiesObject target = new FilePropertiesObject(file, position);
			return target;
			// TODO: add assertions to method FilePropertiesObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.RenderTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_CreationDate()</summary>
		[PexMethod]
		public DateTime CreationDateGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			DateTime result = target.CreationDate;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.CreationDateGetTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_DataPacketsCount()</summary>
		[PexMethod]
		public ulong DataPacketsCountGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			ulong result = target.DataPacketsCount;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.DataPacketsCountGetTest(FilePropertiesObject)
		}

	

		/// <summary>Test stub for get_FileSize()</summary>
		[PexMethod]
		public ulong FileSizeGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			ulong result = target.FileSize;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.FileSizeGetTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_Flags()</summary>
		[PexMethod]
		public uint FlagsGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			uint result = target.Flags;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.FlagsGetTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_MaximumBitrate()</summary>
		[PexMethod]
		public uint MaximumBitrateGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			uint result = target.MaximumBitrate;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.MaximumBitrateGetTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_MaximumDataPacketSize()</summary>
		[PexMethod]
		public uint MaximumDataPacketSizeGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			uint result = target.MaximumDataPacketSize;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.MaximumDataPacketSizeGetTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_MinimumDataPacketSize()</summary>
		[PexMethod]
		public uint MinimumDataPacketSizeGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			uint result = target.MinimumDataPacketSize;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.MinimumDataPacketSizeGetTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_PlayDuration()</summary>
		[PexMethod]
		public TimeSpan PlayDurationGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			TimeSpan result = target.PlayDuration;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.PlayDurationGetTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_Preroll()</summary>
		[PexMethod]
		public ulong PrerollGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			ulong result = target.Preroll;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.PrerollGetTest(FilePropertiesObject)
		}

		/// <summary>Test stub for get_SendDuration()</summary>
		[PexMethod]
		public TimeSpan SendDurationGetTest([PexAssumeUnderTest]FilePropertiesObject target)
		{
			TimeSpan result = target.SendDuration;
			return result;
			// TODO: add assertions to method FilePropertiesObjectTest.SendDurationGetTest(FilePropertiesObject)
		}
	}
}
