using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for HeaderObject</summary>
    [TestClass]
    [PexClass(typeof(HeaderObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HeaderObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public HeaderObject ConstructorTest(File file, long position)
		{
			HeaderObject target = new HeaderObject(file, position);
			return target;
			// TODO: add assertions to method HeaderObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for AddObject(Object)</summary>
		[PexMethod]
		public void AddObjectTest([PexAssumeUnderTest]HeaderObject target, Object obj)
		{
			target.AddObject(obj);
			// TODO: add assertions to method HeaderObjectTest.AddObjectTest(HeaderObject, Object)
		}

		/// <summary>Test stub for AddUniqueObject(Object)</summary>
		[PexMethod]
		public void AddUniqueObjectTest([PexAssumeUnderTest]HeaderObject target, Object obj)
		{
			target.AddUniqueObject(obj);
			// TODO: add assertions to method HeaderObjectTest.AddUniqueObjectTest(HeaderObject, Object)
		}

		/// <summary>Test stub for RemoveContentDescriptors()</summary>
		[PexMethod]
		public void RemoveContentDescriptorsTest([PexAssumeUnderTest]HeaderObject target)
		{
			target.RemoveContentDescriptors();
			// TODO: add assertions to method HeaderObjectTest.RemoveContentDescriptorsTest(HeaderObject)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]HeaderObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method HeaderObjectTest.RenderTest(HeaderObject)
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Object> ChildrenGetTest([PexAssumeUnderTest]HeaderObject target)
		{
			IEnumerable<Object> result = target.Children;
			return result;
			// TODO: add assertions to method HeaderObjectTest.ChildrenGetTest(HeaderObject)
		}

		/// <summary>Test stub for get_Extension()</summary>
		[PexMethod]
		public HeaderExtensionObject ExtensionGetTest([PexAssumeUnderTest]HeaderObject target)
		{
			HeaderExtensionObject result = target.Extension;
			return result;
			// TODO: add assertions to method HeaderObjectTest.ExtensionGetTest(HeaderObject)
		}

		/// <summary>Test stub for get_HasContentDescriptors()</summary>
		[PexMethod]
		public bool HasContentDescriptorsGetTest([PexAssumeUnderTest]HeaderObject target)
		{
			bool result = target.HasContentDescriptors;
			return result;
			// TODO: add assertions to method HeaderObjectTest.HasContentDescriptorsGetTest(HeaderObject)
		}

		/// <summary>Test stub for get_Properties()</summary>
		[PexMethod]
		public Properties PropertiesGetTest([PexAssumeUnderTest]HeaderObject target)
		{
			Properties result = target.Properties;
			return result;
			// TODO: add assertions to method HeaderObjectTest.PropertiesGetTest(HeaderObject)
		}
	}
}
