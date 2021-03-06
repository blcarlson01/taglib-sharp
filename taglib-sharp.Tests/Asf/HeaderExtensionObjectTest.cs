using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for HeaderExtensionObject</summary>
    [TestClass]
    [PexClass(typeof(HeaderExtensionObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HeaderExtensionObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public HeaderExtensionObject ConstructorTest(File file, long position)
		{
			HeaderExtensionObject target = new HeaderExtensionObject(file, position);
			return target;
			// TODO: add assertions to method HeaderExtensionObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for AddObject(Object)</summary>
		[PexMethod]
		public void AddObjectTest([PexAssumeUnderTest]HeaderExtensionObject target, Object obj)
		{
			target.AddObject(obj);
			// TODO: add assertions to method HeaderExtensionObjectTest.AddObjectTest(HeaderExtensionObject, Object)
		}

		/// <summary>Test stub for AddUniqueObject(Object)</summary>
		[PexMethod]
		public void AddUniqueObjectTest([PexAssumeUnderTest]HeaderExtensionObject target, Object obj)
		{
			target.AddUniqueObject(obj);
			// TODO: add assertions to method HeaderExtensionObjectTest.AddUniqueObjectTest(HeaderExtensionObject, Object)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]HeaderExtensionObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method HeaderExtensionObjectTest.RenderTest(HeaderExtensionObject)
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Object> ChildrenGetTest([PexAssumeUnderTest]HeaderExtensionObject target)
		{
			IEnumerable<Object> result = target.Children;
			return result;
			// TODO: add assertions to method HeaderExtensionObjectTest.ChildrenGetTest(HeaderExtensionObject)
		}
	}
}
