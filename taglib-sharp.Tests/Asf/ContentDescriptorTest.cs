using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for ContentDescriptor</summary>
    [TestClass]
    [PexClass(typeof(ContentDescriptor))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ContentDescriptorTest
    {

		/// <summary>Test stub for .ctor(String, String)</summary>
		[PexMethod]
		public ContentDescriptor ConstructorTest(string name, string value)
		{
			ContentDescriptor target = new ContentDescriptor(name, value);
			return target;
			// TODO: add assertions to method ContentDescriptorTest.ConstructorTest(String, String)
		}

		/// <summary>Test stub for .ctor(String, ByteVector)</summary>
		[PexMethod]
		public ContentDescriptor ConstructorTest01(string name, ByteVector value)
		{
			ContentDescriptor target = new ContentDescriptor(name, value);
			return target;
			// TODO: add assertions to method ContentDescriptorTest.ConstructorTest01(String, ByteVector)
		}

		/// <summary>Test stub for .ctor(String, UInt32)</summary>
		[PexMethod]
		public ContentDescriptor ConstructorTest02(string name, uint value)
		{
			ContentDescriptor target = new ContentDescriptor(name, value);
			return target;
			// TODO: add assertions to method ContentDescriptorTest.ConstructorTest02(String, UInt32)
		}

		/// <summary>Test stub for .ctor(String, UInt64)</summary>
		[PexMethod]
		public ContentDescriptor ConstructorTest03(string name, ulong value)
		{
			ContentDescriptor target = new ContentDescriptor(name, value);
			return target;
			// TODO: add assertions to method ContentDescriptorTest.ConstructorTest03(String, UInt64)
		}

		/// <summary>Test stub for .ctor(String, UInt16)</summary>
		[PexMethod]
		public ContentDescriptor ConstructorTest04(string name, ushort value)
		{
			ContentDescriptor target = new ContentDescriptor(name, value);
			return target;
			// TODO: add assertions to method ContentDescriptorTest.ConstructorTest04(String, UInt16)
		}

		/// <summary>Test stub for .ctor(String, Boolean)</summary>
		[PexMethod]
		public ContentDescriptor ConstructorTest05(string name, bool value)
		{
			ContentDescriptor target = new ContentDescriptor(name, value);
			return target;
			// TODO: add assertions to method ContentDescriptorTest.ConstructorTest05(String, Boolean)
		}


		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method ContentDescriptorTest.RenderTest(ContentDescriptor)
		}

		/// <summary>Test stub for ToBool()</summary>
		[PexMethod]
		public bool ToBoolTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			bool result = target.ToBool();
			return result;
			// TODO: add assertions to method ContentDescriptorTest.ToBoolTest(ContentDescriptor)
		}

		/// <summary>Test stub for ToByteVector()</summary>
		[PexMethod]
		public ByteVector ToByteVectorTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			ByteVector result = target.ToByteVector();
			return result;
			// TODO: add assertions to method ContentDescriptorTest.ToByteVectorTest(ContentDescriptor)
		}

		/// <summary>Test stub for ToDWord()</summary>
		[PexMethod]
		public uint ToDWordTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			uint result = target.ToDWord();
			return result;
			// TODO: add assertions to method ContentDescriptorTest.ToDWordTest(ContentDescriptor)
		}

		/// <summary>Test stub for ToQWord()</summary>
		[PexMethod]
		public ulong ToQWordTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			ulong result = target.ToQWord();
			return result;
			// TODO: add assertions to method ContentDescriptorTest.ToQWordTest(ContentDescriptor)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method ContentDescriptorTest.ToStringTest(ContentDescriptor)
		}

		/// <summary>Test stub for ToWord()</summary>
		[PexMethod]
		public ushort ToWordTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			ushort result = target.ToWord();
			return result;
			// TODO: add assertions to method ContentDescriptorTest.ToWordTest(ContentDescriptor)
		}

		/// <summary>Test stub for get_Name()</summary>
		[PexMethod]
		public string NameGetTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			string result = target.Name;
			return result;
			// TODO: add assertions to method ContentDescriptorTest.NameGetTest(ContentDescriptor)
		}

		/// <summary>Test stub for get_Type()</summary>
		[PexMethod]
		public DataType TypeGetTest([PexAssumeUnderTest]ContentDescriptor target)
		{
			DataType result = target.Type;
			return result;
			// TODO: add assertions to method ContentDescriptorTest.TypeGetTest(ContentDescriptor)
		}
	}
}
