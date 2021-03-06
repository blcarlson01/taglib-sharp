using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IIM;

namespace TagLib.IIM.Tests
{
    /// <summary>This class contains parameterized unit tests for IIMReader</summary>
    [TestClass]
    [PexClass(typeof(IIMReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IIMReaderTest
    {

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public IIMReader ConstructorTest(ByteVector data)
		{
			IIMReader target = new IIMReader(data);
			return target;
			// TODO: add assertions to method IIMReaderTest.ConstructorTest(ByteVector)
		}

		/// <summary>Test stub for Process()</summary>
		[PexMethod]
		public IIMTag ProcessTest([PexAssumeUnderTest]IIMReader target)
		{
			IIMTag result = target.Process();
			return result;
			// TODO: add assertions to method IIMReaderTest.ProcessTest(IIMReader)
		}
	}
}
