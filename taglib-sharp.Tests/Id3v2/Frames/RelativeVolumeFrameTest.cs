using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for RelativeVolumeFrame</summary>
    [TestClass]
    [PexClass(typeof(RelativeVolumeFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RelativeVolumeFrameTest
    {

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public RelativeVolumeFrame ConstructorTest(string identification)
		{
			RelativeVolumeFrame target = new RelativeVolumeFrame(identification);
			return target;
			// TODO: add assertions to method RelativeVolumeFrameTest.ConstructorTest(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public RelativeVolumeFrame ConstructorTest01(ByteVector data, byte version)
		{
			RelativeVolumeFrame target = new RelativeVolumeFrame(data, version);
			return target;
			// TODO: add assertions to method RelativeVolumeFrameTest.ConstructorTest01(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]RelativeVolumeFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.CloneTest(RelativeVolumeFrame)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public RelativeVolumeFrame GetTest(
			Tag tag,
			string identification,
			bool create
		)
		{
			RelativeVolumeFrame result = RelativeVolumeFrame.Get(tag, identification, create);
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.GetTest(Tag, String, Boolean)
		}

		/// <summary>Test stub for GetPeakVolume(ChannelType)</summary>
		[PexMethod]
		public double GetPeakVolumeTest([PexAssumeUnderTest]RelativeVolumeFrame target, ChannelType type)
		{
			double result = target.GetPeakVolume(type);
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.GetPeakVolumeTest(RelativeVolumeFrame, ChannelType)
		}

		/// <summary>Test stub for GetPeakVolumeIndex(ChannelType)</summary>
		[PexMethod]
		public ulong GetPeakVolumeIndexTest([PexAssumeUnderTest]RelativeVolumeFrame target, ChannelType type)
		{
			ulong result = target.GetPeakVolumeIndex(type);
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.GetPeakVolumeIndexTest(RelativeVolumeFrame, ChannelType)
		}

		/// <summary>Test stub for GetVolumeAdjustment(ChannelType)</summary>
		[PexMethod]
		public float GetVolumeAdjustmentTest([PexAssumeUnderTest]RelativeVolumeFrame target, ChannelType type)
		{
			float result = target.GetVolumeAdjustment(type);
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.GetVolumeAdjustmentTest(RelativeVolumeFrame, ChannelType)
		}

		/// <summary>Test stub for GetVolumeAdjustmentIndex(ChannelType)</summary>
		[PexMethod]
		public short GetVolumeAdjustmentIndexTest([PexAssumeUnderTest]RelativeVolumeFrame target, ChannelType type)
		{
			short result = target.GetVolumeAdjustmentIndex(type);
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.GetVolumeAdjustmentIndexTest(RelativeVolumeFrame, ChannelType)
		}

		/// <summary>Test stub for SetPeakVolume(ChannelType, Double)</summary>
		[PexMethod]
		public void SetPeakVolumeTest(
			[PexAssumeUnderTest]RelativeVolumeFrame target,
			ChannelType type,
			double peak
		)
		{
			target.SetPeakVolume(type, peak);
			// TODO: add assertions to method RelativeVolumeFrameTest.SetPeakVolumeTest(RelativeVolumeFrame, ChannelType, Double)
		}

		/// <summary>Test stub for SetPeakVolumeIndex(ChannelType, UInt64)</summary>
		[PexMethod]
		public void SetPeakVolumeIndexTest(
			[PexAssumeUnderTest]RelativeVolumeFrame target,
			ChannelType type,
			ulong index
		)
		{
			target.SetPeakVolumeIndex(type, index);
			// TODO: add assertions to method RelativeVolumeFrameTest.SetPeakVolumeIndexTest(RelativeVolumeFrame, ChannelType, UInt64)
		}

		/// <summary>Test stub for SetVolumeAdjustment(ChannelType, Single)</summary>
		[PexMethod]
		public void SetVolumeAdjustmentTest(
			[PexAssumeUnderTest]RelativeVolumeFrame target,
			ChannelType type,
			float adjustment
		)
		{
			target.SetVolumeAdjustment(type, adjustment);
			// TODO: add assertions to method RelativeVolumeFrameTest.SetVolumeAdjustmentTest(RelativeVolumeFrame, ChannelType, Single)
		}

		/// <summary>Test stub for SetVolumeAdjustmentIndex(ChannelType, Int16)</summary>
		[PexMethod]
		public void SetVolumeAdjustmentIndexTest(
			[PexAssumeUnderTest]RelativeVolumeFrame target,
			ChannelType type,
			short index
		)
		{
			target.SetVolumeAdjustmentIndex(type, index);
			// TODO: add assertions to method RelativeVolumeFrameTest.SetVolumeAdjustmentIndexTest(RelativeVolumeFrame, ChannelType, Int16)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]RelativeVolumeFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.ToStringTest(RelativeVolumeFrame)
		}

		/// <summary>Test stub for get_Channels()</summary>
		[PexMethod]
		public ChannelType[] ChannelsGetTest([PexAssumeUnderTest]RelativeVolumeFrame target)
		{
			ChannelType[] result = target.Channels;
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.ChannelsGetTest(RelativeVolumeFrame)
		}

		/// <summary>Test stub for get_Identification()</summary>
		[PexMethod]
		public string IdentificationGetTest([PexAssumeUnderTest]RelativeVolumeFrame target)
		{
			string result = target.Identification;
			return result;
			// TODO: add assertions to method RelativeVolumeFrameTest.IdentificationGetTest(RelativeVolumeFrame)
		}
	}
}
