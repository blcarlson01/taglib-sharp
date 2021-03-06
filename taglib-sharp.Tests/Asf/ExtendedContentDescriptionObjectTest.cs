using TagLib;
using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for ExtendedContentDescriptionObject</summary>
    [TestClass]
    [PexClass(typeof(ExtendedContentDescriptionObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ExtendedContentDescriptionObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public ExtendedContentDescriptionObject ConstructorTest(File file, long position)
		{
			ExtendedContentDescriptionObject target = new ExtendedContentDescriptionObject(file, position);
			return target;
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public ExtendedContentDescriptionObject ConstructorTest01()
		{
			ExtendedContentDescriptionObject target = new ExtendedContentDescriptionObject();
			return target;
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.ConstructorTest01()
		}

		/// <summary>Test stub for AddDescriptor(ContentDescriptor)</summary>
		[PexMethod]
		public void AddDescriptorTest([PexAssumeUnderTest]ExtendedContentDescriptionObject target, ContentDescriptor descriptor)
		{
			target.AddDescriptor(descriptor);
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.AddDescriptorTest(ExtendedContentDescriptionObject, ContentDescriptor)
		}

		/// <summary>Test stub for GetDescriptors(String[])</summary>
		[PexMethod]
		public IEnumerable<ContentDescriptor> GetDescriptorsTest([PexAssumeUnderTest]ExtendedContentDescriptionObject target, string[] names)
		{
			IEnumerable<ContentDescriptor> result = target.GetDescriptors(names);
			return result;
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.GetDescriptorsTest(ExtendedContentDescriptionObject, String[])
		}

		/// <summary>Test stub for GetEnumerator()</summary>
		[PexMethod]
		public IEnumerator<ContentDescriptor> GetEnumeratorTest([PexAssumeUnderTest]ExtendedContentDescriptionObject target)
		{
			IEnumerator<ContentDescriptor> result = target.GetEnumerator();
			return result;
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.GetEnumeratorTest(ExtendedContentDescriptionObject)
		}

		/// <summary>Test stub for RemoveDescriptors(String)</summary>
		[PexMethod]
		public void RemoveDescriptorsTest([PexAssumeUnderTest]ExtendedContentDescriptionObject target, string name)
		{
			target.RemoveDescriptors(name);
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.RemoveDescriptorsTest(ExtendedContentDescriptionObject, String)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]ExtendedContentDescriptionObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.RenderTest(ExtendedContentDescriptionObject)
		}

		/// <summary>Test stub for SetDescriptors(String, ContentDescriptor[])</summary>
		[PexMethod]
		public void SetDescriptorsTest(
			[PexAssumeUnderTest]ExtendedContentDescriptionObject target,
			string name,
			ContentDescriptor[] descriptors
		)
		{
			target.SetDescriptors(name, descriptors);
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.SetDescriptorsTest(ExtendedContentDescriptionObject, String, ContentDescriptor[])
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]ExtendedContentDescriptionObject target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method ExtendedContentDescriptionObjectTest.IsEmptyGetTest(ExtendedContentDescriptionObject)
		}
	}
}
