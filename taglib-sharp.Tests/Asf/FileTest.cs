using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for File</summary>
    [TestClass]
    [PexClass(typeof(File))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FileTest
    {

		/// <summary>Test stub for .ctor(String, ReadStyle)</summary>
		[PexMethod]
		public File ConstructorTest(string path, ReadStyle propertiesStyle)
		{
			File target = new File(path, propertiesStyle);
			return target;
			// TODO: add assertions to method FileTest.ConstructorTest(String, ReadStyle)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public File ConstructorTest01(string path)
		{
			File target = new File(path);
			return target;
			// TODO: add assertions to method FileTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(IFileAbstraction, ReadStyle)</summary>
		[PexMethod]
		public File ConstructorTest02(File.IFileAbstraction abstraction, ReadStyle propertiesStyle)
		{
			File target = new File(abstraction, propertiesStyle);
			return target;
			// TODO: add assertions to method FileTest.ConstructorTest02(IFileAbstraction, ReadStyle)
		}

		/// <summary>Test stub for .ctor(IFileAbstraction)</summary>
		[PexMethod]
		public File ConstructorTest03(File.IFileAbstraction abstraction)
		{
			File target = new File(abstraction);
			return target;
			// TODO: add assertions to method FileTest.ConstructorTest03(IFileAbstraction)
		}

	

		/// <summary>Test stub for ReadDWord()</summary>
		[PexMethod]
		public uint ReadDWordTest([PexAssumeUnderTest]File target)
		{
			uint result = target.ReadDWord();
			return result;
			// TODO: add assertions to method FileTest.ReadDWordTest(File)
		}

	

		/// <summary>Test stub for ReadObject(Int64)</summary>
		[PexMethod]
		public Object ReadObjectTest([PexAssumeUnderTest]File target, long position)
		{
			Object result = target.ReadObject(position);
			return result;
			// TODO: add assertions to method FileTest.ReadObjectTest(File, Int64)
		}

		/// <summary>Test stub for ReadObjects(UInt32, Int64)</summary>
		[PexMethod]
		public IEnumerable<Object> ReadObjectsTest(
			[PexAssumeUnderTest]File target,
			uint count,
			long position
		)
		{
			IEnumerable<Object> result = target.ReadObjects(count, position);
			return result;
			// TODO: add assertions to method FileTest.ReadObjectsTest(File, UInt32, Int64)
		}

		/// <summary>Test stub for ReadQWord()</summary>
		[PexMethod]
		public ulong ReadQWordTest([PexAssumeUnderTest]File target)
		{
			ulong result = target.ReadQWord();
			return result;
			// TODO: add assertions to method FileTest.ReadQWordTest(File)
		}

		/// <summary>Test stub for ReadUnicode(Int32)</summary>
		[PexMethod]
		public string ReadUnicodeTest([PexAssumeUnderTest]File target, int length)
		{
			string result = target.ReadUnicode(length);
			return result;
			// TODO: add assertions to method FileTest.ReadUnicodeTest(File, Int32)
		}

		/// <summary>Test stub for ReadWord()</summary>
		[PexMethod]
		public ushort ReadWordTest([PexAssumeUnderTest]File target)
		{
			ushort result = target.ReadWord();
			return result;
			// TODO: add assertions to method FileTest.ReadWordTest(File)
		}

		/// <summary>Test stub for RemoveTags(TagTypes)</summary>
		[PexMethod]
		public void RemoveTagsTest([PexAssumeUnderTest]File target, TagTypes types)
		{
			target.RemoveTags(types);
			// TODO: add assertions to method FileTest.RemoveTagsTest(File, TagTypes)
		}

		/// <summary>Test stub for Save()</summary>
		[PexMethod]
		public void SaveTest([PexAssumeUnderTest]File target)
		{
			target.Save();
			// TODO: add assertions to method FileTest.SaveTest(File)
		}

		/// <summary>Test stub for get_Properties()</summary>
		[PexMethod]
		public Properties PropertiesGetTest([PexAssumeUnderTest]File target)
		{
			Properties result = target.Properties;
			return result;
			// TODO: add assertions to method FileTest.PropertiesGetTest(File)
		}

	}
}
