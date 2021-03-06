using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ape;

namespace TagLib.Ape.Tests
{
    /// <summary>This class contains parameterized unit tests for Item</summary>
    [TestClass]
    [PexClass(typeof(Item))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ItemTest
    {

		/// <summary>Test stub for .ctor(ByteVector, Int32)</summary>
		[PexMethod]
		public Item ConstructorTest(ByteVector data, int offset)
		{
			Item target = new Item(data, offset);
			return target;
			// TODO: add assertions to method ItemTest.ConstructorTest(ByteVector, Int32)
		}

		/// <summary>Test stub for .ctor(String, String)</summary>
		[PexMethod]
		public Item ConstructorTest01(string key, string value)
		{
			Item target = new Item(key, value);
			return target;
			// TODO: add assertions to method ItemTest.ConstructorTest01(String, String)
		}

		/// <summary>Test stub for .ctor(String, String[])</summary>
		[PexMethod]
		public Item ConstructorTest02(string key, string[] value)
		{
			Item target = new Item(key, value);
			return target;
			// TODO: add assertions to method ItemTest.ConstructorTest02(String, String[])
		}

		/// <summary>Test stub for .ctor(String, ByteVector)</summary>
		[PexMethod]
		public Item ConstructorTest03(string key, ByteVector value)
		{
			Item target = new Item(key, value);
			return target;
			// TODO: add assertions to method ItemTest.ConstructorTest03(String, ByteVector)
		}

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Item CloneTest([PexAssumeUnderTest]Item target)
		{
			Item result = target.Clone();
			return result;
			// TODO: add assertions to method ItemTest.CloneTest(Item)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]Item target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method ItemTest.RenderTest(Item)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]Item target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method ItemTest.ToStringTest(Item)
		}

		/// <summary>Test stub for ToStringArray()</summary>
		[PexMethod]
		public string[] ToStringArrayTest([PexAssumeUnderTest]Item target)
		{
			string[] result = target.ToStringArray();
			return result;
			// TODO: add assertions to method ItemTest.ToStringArrayTest(Item)
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]Item target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method ItemTest.IsEmptyGetTest(Item)
		}

		/// <summary>Test stub for get_Key()</summary>
		[PexMethod]
		public string KeyGetTest([PexAssumeUnderTest]Item target)
		{
			string result = target.Key;
			return result;
			// TODO: add assertions to method ItemTest.KeyGetTest(Item)
		}

		/// <summary>Test stub for get_ReadOnly()</summary>
		[PexMethod]
		public bool ReadOnlyGetTest([PexAssumeUnderTest]Item target)
		{
			bool result = target.ReadOnly;
			return result;
			// TODO: add assertions to method ItemTest.ReadOnlyGetTest(Item)
		}

		/// <summary>Test stub for get_Size()</summary>
		[PexMethod]
		public int SizeGetTest([PexAssumeUnderTest]Item target)
		{
			int result = target.Size;
			return result;
			// TODO: add assertions to method ItemTest.SizeGetTest(Item)
		}

		/// <summary>Test stub for get_Type()</summary>
		[PexMethod]
		public ItemType TypeGetTest([PexAssumeUnderTest]Item target)
		{
			ItemType result = target.Type;
			return result;
			// TODO: add assertions to method ItemTest.TypeGetTest(Item)
		}

		/// <summary>Test stub for get_Value()</summary>
		[PexMethod]
		public ByteVector ValueGetTest([PexAssumeUnderTest]Item target)
		{
			ByteVector result = target.Value;
			return result;
			// TODO: add assertions to method ItemTest.ValueGetTest(Item)
		}

		/// <summary>Test stub for set_ReadOnly(Boolean)</summary>
		[PexMethod]
		public void ReadOnlySetTest([PexAssumeUnderTest]Item target, bool value)
		{
			target.ReadOnly = value;
			// TODO: add assertions to method ItemTest.ReadOnlySetTest(Item, Boolean)
		}

		/// <summary>Test stub for set_Type(ItemType)</summary>
		[PexMethod]
		public void TypeSetTest([PexAssumeUnderTest]Item target, ItemType value)
		{
			target.Type = value;
			// TODO: add assertions to method ItemTest.TypeSetTest(Item, ItemType)
		}
	}
}
