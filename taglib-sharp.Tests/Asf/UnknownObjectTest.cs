using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for UnknownObject</summary>
    [TestClass]
    [PexClass(typeof(UnknownObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnknownObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public UnknownObject ConstructorTest(File file, long position)
		{
			UnknownObject target = new UnknownObject(file, position);
			return target;
			// TODO: add assertions to method UnknownObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]UnknownObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method UnknownObjectTest.RenderTest(UnknownObject)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]UnknownObject target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method UnknownObjectTest.DataGetTest(UnknownObject)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]UnknownObject target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method UnknownObjectTest.DataSetTest(UnknownObject, ByteVector)
		}
	}
}
