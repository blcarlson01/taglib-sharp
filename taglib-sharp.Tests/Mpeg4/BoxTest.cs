using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for Box</summary>
    [TestClass]
    [PexClass(typeof(Box))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BoxTest
    {

		/// <summary>Test stub for AddChild(Box)</summary>
		[PexMethod]
		public void AddChildTest([PexAssumeUnderTest]Box target, Box box)
		{
			target.AddChild(box);
			// TODO: add assertions to method BoxTest.AddChildTest(Box, Box)
		}

		/// <summary>Test stub for ClearChildren()</summary>
		[PexMethod]
		public void ClearChildrenTest([PexAssumeUnderTest]Box target)
		{
			target.ClearChildren();
			// TODO: add assertions to method BoxTest.ClearChildrenTest(Box)
		}

		/// <summary>Test stub for GetChild(ByteVector)</summary>
		[PexMethod]
		public Box GetChildTest([PexAssumeUnderTest]Box target, ByteVector type)
		{
			Box result = target.GetChild(type);
			return result;
			// TODO: add assertions to method BoxTest.GetChildTest(Box, ByteVector)
		}

		/// <summary>Test stub for GetChildRecursively(ByteVector)</summary>
		[PexMethod]
		public Box GetChildRecursivelyTest([PexAssumeUnderTest]Box target, ByteVector type)
		{
			Box result = target.GetChildRecursively(type);
			return result;
			// TODO: add assertions to method BoxTest.GetChildRecursivelyTest(Box, ByteVector)
		}

		/// <summary>Test stub for RemoveChild(ByteVector)</summary>
		[PexMethod]
		public void RemoveChildTest([PexAssumeUnderTest]Box target, ByteVector type)
		{
			target.RemoveChild(type);
			// TODO: add assertions to method BoxTest.RemoveChildTest(Box, ByteVector)
		}

		/// <summary>Test stub for RemoveChild(Box)</summary>
		[PexMethod]
		public void RemoveChildTest01([PexAssumeUnderTest]Box target, Box box)
		{
			target.RemoveChild(box);
			// TODO: add assertions to method BoxTest.RemoveChildTest01(Box, Box)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]Box target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method BoxTest.RenderTest(Box)
		}

		/// <summary>Test stub for get_BoxType()</summary>
		[PexMethod]
		public ByteVector BoxTypeGetTest([PexAssumeUnderTest]Box target)
		{
			ByteVector result = target.BoxType;
			return result;
			// TODO: add assertions to method BoxTest.BoxTypeGetTest(Box)
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Box> ChildrenGetTest([PexAssumeUnderTest]Box target)
		{
			IEnumerable<Box> result = target.Children;
			return result;
			// TODO: add assertions to method BoxTest.ChildrenGetTest(Box)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]Box target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method BoxTest.DataGetTest(Box)
		}

		/// <summary>Test stub for get_Handler()</summary>
		[PexMethod]
		public IsoHandlerBox HandlerGetTest([PexAssumeUnderTest]Box target)
		{
			IsoHandlerBox result = target.Handler;
			return result;
			// TODO: add assertions to method BoxTest.HandlerGetTest(Box)
		}

		/// <summary>Test stub for get_HasChildren()</summary>
		[PexMethod]
		public bool HasChildrenGetTest([PexAssumeUnderTest]Box target)
		{
			bool result = target.HasChildren;
			return result;
			// TODO: add assertions to method BoxTest.HasChildrenGetTest(Box)
		}

		/// <summary>Test stub for get_Size()</summary>
		[PexMethod]
		public int SizeGetTest([PexAssumeUnderTest]Box target)
		{
			int result = target.Size;
			return result;
			// TODO: add assertions to method BoxTest.SizeGetTest(Box)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]Box target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method BoxTest.DataSetTest(Box, ByteVector)
		}
	}
}
