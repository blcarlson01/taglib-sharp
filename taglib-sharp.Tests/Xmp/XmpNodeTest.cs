using System.Collections.Generic;
using System.Xml;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Xmp;

namespace TagLib.Xmp.Tests
{
    /// <summary>This class contains parameterized unit tests for XmpNode</summary>
    [TestClass]
    [PexClass(typeof(XmpNode))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class XmpNodeTest
    {

		/// <summary>Test stub for .ctor(String, String)</summary>
		[PexMethod]
		public XmpNode ConstructorTest(string ns, string name)
		{
			XmpNode target = new XmpNode(ns, name);
			return target;
			// TODO: add assertions to method XmpNodeTest.ConstructorTest(String, String)
		}

		/// <summary>Test stub for .ctor(String, String, String)</summary>
		[PexMethod]
		public XmpNode ConstructorTest01(
			string ns,
			string name,
			string value
		)
		{
			XmpNode target = new XmpNode(ns, name, value);
			return target;
			// TODO: add assertions to method XmpNodeTest.ConstructorTest01(String, String, String)
		}

		/// <summary>Test stub for Accept(XmpNodeVisitor)</summary>
		[PexMethod]
		public void AcceptTest([PexAssumeUnderTest]XmpNode target, XmpNodeVisitor visitor)
		{
			target.Accept(visitor);
			// TODO: add assertions to method XmpNodeTest.AcceptTest(XmpNode, XmpNodeVisitor)
		}

		/// <summary>Test stub for AddChild(XmpNode)</summary>
		[PexMethod]
		public void AddChildTest([PexAssumeUnderTest]XmpNode target, XmpNode node)
		{
			target.AddChild(node);
			// TODO: add assertions to method XmpNodeTest.AddChildTest(XmpNode, XmpNode)
		}

		/// <summary>Test stub for AddQualifier(XmpNode)</summary>
		[PexMethod]
		public void AddQualifierTest([PexAssumeUnderTest]XmpNode target, XmpNode node)
		{
			target.AddQualifier(node);
			// TODO: add assertions to method XmpNodeTest.AddQualifierTest(XmpNode, XmpNode)
		}

		/// <summary>Test stub for Dump()</summary>
		[PexMethod]
		public void DumpTest([PexAssumeUnderTest]XmpNode target)
		{
			target.Dump();
			// TODO: add assertions to method XmpNodeTest.DumpTest(XmpNode)
		}

		/// <summary>Test stub for Dump(String)</summary>
		[PexMethod]
		internal void DumpTest01([PexAssumeUnderTest]XmpNode target, string prefix)
		{
			target.Dump();
			// TODO: add assertions to method XmpNodeTest.DumpTest01(XmpNode, String)
		}

		/// <summary>Test stub for GetChild(String, String)</summary>
		[PexMethod]
		public XmpNode GetChildTest(
			[PexAssumeUnderTest]XmpNode target,
			string ns,
			string name
		)
		{
			XmpNode result = target.GetChild(ns, name);
			return result;
			// TODO: add assertions to method XmpNodeTest.GetChildTest(XmpNode, String, String)
		}

		/// <summary>Test stub for GetQualifier(String, String)</summary>
		[PexMethod]
		public XmpNode GetQualifierTest(
			[PexAssumeUnderTest]XmpNode target,
			string ns,
			string name
		)
		{
			XmpNode result = target.GetQualifier(ns, name);
			return result;
			// TODO: add assertions to method XmpNodeTest.GetQualifierTest(XmpNode, String, String)
		}

		/// <summary>Test stub for RemoveChild(XmpNode)</summary>
		[PexMethod]
		public void RemoveChildTest([PexAssumeUnderTest]XmpNode target, XmpNode node)
		{
			target.RemoveChild(node);
			// TODO: add assertions to method XmpNodeTest.RemoveChildTest(XmpNode, XmpNode)
		}

		/// <summary>Test stub for RenderInto(XmlNode)</summary>
		[PexMethod]
		public void RenderIntoTest([PexAssumeUnderTest]XmpNode target, XmlNode parent)
		{
			target.RenderInto(parent);
			// TODO: add assertions to method XmpNodeTest.RenderIntoTest(XmpNode, XmlNode)
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public List<XmpNode> ChildrenGetTest([PexAssumeUnderTest]XmpNode target)
		{
			List<XmpNode> result = target.Children;
			return result;
			// TODO: add assertions to method XmpNodeTest.ChildrenGetTest(XmpNode)
		}

		/// <summary>Test stub for get_Name()</summary>
		[PexMethod]
		public string NameGetTest([PexAssumeUnderTest]XmpNode target)
		{
			string result = target.Name;
			return result;
			// TODO: add assertions to method XmpNodeTest.NameGetTest(XmpNode)
		}

		/// <summary>Test stub for get_QualifierCount()</summary>
		[PexMethod]
		public int QualifierCountGetTest([PexAssumeUnderTest]XmpNode target)
		{
			int result = target.QualifierCount;
			return result;
			// TODO: add assertions to method XmpNodeTest.QualifierCountGetTest(XmpNode)
		}

		
	}
}
