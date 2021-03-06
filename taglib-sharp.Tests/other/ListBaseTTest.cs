using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for ListBase`1</summary>
    [TestClass]
    [PexClass(typeof(ListBase<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ListBaseTTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public ListBase<T> ConstructorTest<T>()
			where T : IComparable<T>
		{
			ListBase<T> target = new ListBase<T>();
			return target;
			// TODO: add assertions to method ListBaseTTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(ListBase`1&lt;!0&gt;)</summary>
		[PexMethod]
		public ListBase<T> ConstructorTest01<T>(ListBase<T> list)
			where T : IComparable<T>
		{
			ListBase<T> target = new ListBase<T>(list);
			return target;
			// TODO: add assertions to method ListBaseTTest.ConstructorTest01(ListBase`1<!!0>)
		}

		/// <summary>Test stub for .ctor(!0[])</summary>
		[PexMethod]
		public ListBase<T> ConstructorTest02<T>(T[] list)
			where T : IComparable<T>
		{
			ListBase<T> target = new ListBase<T>(list);
			return target;
			// TODO: add assertions to method ListBaseTTest.ConstructorTest02(!!0[])
		}

		/// <summary>Test stub for Add(ListBase`1&lt;!0&gt;)</summary>
		[PexMethod]
		public void AddTest<T>([PexAssumeUnderTest]ListBase<T> target, ListBase<T> list)
			where T : IComparable<T>
		{
			target.Add(list);
			// TODO: add assertions to method ListBaseTTest.AddTest(ListBase`1<!!0>, ListBase`1<!!0>)
		}

		/// <summary>Test stub for Add(IEnumerable`1&lt;!0&gt;)</summary>
		[PexMethod]
		public void AddTest01<T>([PexAssumeUnderTest]ListBase<T> target, IEnumerable<T> list)
			where T : IComparable<T>
		{
			target.Add(list);
			// TODO: add assertions to method ListBaseTTest.AddTest01(ListBase`1<!!0>, IEnumerable`1<!!0>)
		}

		/// <summary>Test stub for Add(!0[])</summary>
		[PexMethod]
		public void AddTest02<T>([PexAssumeUnderTest]ListBase<T> target, T[] list)
			where T : IComparable<T>
		{
			target.Add(list);
			// TODO: add assertions to method ListBaseTTest.AddTest02(ListBase`1<!!0>, !!0[])
		}

		/// <summary>Test stub for Add(!0)</summary>
		[PexMethod]
		public void AddTest03<T>([PexAssumeUnderTest]ListBase<T> target, T item)
			where T : IComparable<T>
		{
			target.Add(item);
			// TODO: add assertions to method ListBaseTTest.AddTest03(ListBase`1<!!0>, !!0)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			target.Clear();
			// TODO: add assertions to method ListBaseTTest.ClearTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for Contains(!0)</summary>
		[PexMethod]
		public bool ContainsTest<T>([PexAssumeUnderTest]ListBase<T> target, T item)
			where T : IComparable<T>
		{
			bool result = target.Contains(item);
			return result;
			// TODO: add assertions to method ListBaseTTest.ContainsTest(ListBase`1<!!0>, !!0)
		}

		/// <summary>Test stub for CopyTo(!0[], Int32)</summary>
		[PexMethod]
		public void CopyToTest<T>(
			[PexAssumeUnderTest]ListBase<T> target,
			T[] array,
			int arrayIndex
		)
			where T : IComparable<T>
		{
			target.CopyTo(array, arrayIndex);
			// TODO: add assertions to method ListBaseTTest.CopyToTest(ListBase`1<!!0>, !!0[], Int32)
		}

		/// <summary>Test stub for GetEnumerator()</summary>
		[PexMethod]
		public IEnumerator<T> GetEnumeratorTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			IEnumerator<T> result = target.GetEnumerator();
			return result;
			// TODO: add assertions to method ListBaseTTest.GetEnumeratorTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for IndexOf(!0)</summary>
		[PexMethod]
		public int IndexOfTest<T>([PexAssumeUnderTest]ListBase<T> target, T item)
			where T : IComparable<T>
		{
			int result = target.IndexOf(item);
			return result;
			// TODO: add assertions to method ListBaseTTest.IndexOfTest(ListBase`1<!!0>, !!0)
		}

		/// <summary>Test stub for Insert(Int32, !0)</summary>
		[PexMethod]
		public void InsertTest<T>(
			[PexAssumeUnderTest]ListBase<T> target,
			int index,
			T item
		)
			where T : IComparable<T>
		{
			target.Insert(index, item);
			// TODO: add assertions to method ListBaseTTest.InsertTest(ListBase`1<!!0>, Int32, !!0)
		}

		/// <summary>Test stub for Remove(!0)</summary>
		[PexMethod]
		public bool RemoveTest<T>([PexAssumeUnderTest]ListBase<T> target, T item)
			where T : IComparable<T>
		{
			bool result = target.Remove(item);
			return result;
			// TODO: add assertions to method ListBaseTTest.RemoveTest(ListBase`1<!!0>, !!0)
		}

		/// <summary>Test stub for RemoveAt(Int32)</summary>
		[PexMethod]
		public void RemoveAtTest<T>([PexAssumeUnderTest]ListBase<T> target, int index)
			where T : IComparable<T>
		{
			target.RemoveAt(index);
			// TODO: add assertions to method ListBaseTTest.RemoveAtTest(ListBase`1<!!0>, Int32)
		}

		/// <summary>Test stub for SortedInsert(!0, Boolean)</summary>
		[PexMethod]
		public void SortedInsertTest<T>(
			[PexAssumeUnderTest]ListBase<T> target,
			T item,
			bool unique
		)
			where T : IComparable<T>
		{
			target.SortedInsert(item, unique);
			// TODO: add assertions to method ListBaseTTest.SortedInsertTest(ListBase`1<!!0>, !!0, Boolean)
		}

		/// <summary>Test stub for SortedInsert(!0)</summary>
		[PexMethod]
		public void SortedInsertTest01<T>([PexAssumeUnderTest]ListBase<T> target, T item)
			where T : IComparable<T>
		{
			target.SortedInsert(item);
			// TODO: add assertions to method ListBaseTTest.SortedInsertTest01(ListBase`1<!!0>, !!0)
		}

		/// <summary>Test stub for ToArray()</summary>
		[PexMethod]
		public T[] ToArrayTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			T[] result = target.ToArray();
			return result;
			// TODO: add assertions to method ListBaseTTest.ToArrayTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for ToString(String)</summary>
		[PexMethod]
		public string ToStringTest<T>([PexAssumeUnderTest]ListBase<T> target, string separator)
			where T : IComparable<T>
		{
			string result = target.ToString(separator);
			return result;
			// TODO: add assertions to method ListBaseTTest.ToStringTest(ListBase`1<!!0>, String)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest01<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method ListBaseTTest.ToStringTest01(ListBase`1<!!0>)
		}

		/// <summary>Test stub for get_Count()</summary>
		[PexMethod]
		public int CountGetTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			int result = target.Count;
			return result;
			// TODO: add assertions to method ListBaseTTest.CountGetTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method ListBaseTTest.IsEmptyGetTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for get_IsFixedSize()</summary>
		[PexMethod]
		public bool IsFixedSizeGetTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			bool result = target.IsFixedSize;
			return result;
			// TODO: add assertions to method ListBaseTTest.IsFixedSizeGetTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for get_IsReadOnly()</summary>
		[PexMethod]
		public bool IsReadOnlyGetTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			bool result = target.IsReadOnly;
			return result;
			// TODO: add assertions to method ListBaseTTest.IsReadOnlyGetTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for get_IsSynchronized()</summary>
		[PexMethod]
		public bool IsSynchronizedGetTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			bool result = target.IsSynchronized;
			return result;
			// TODO: add assertions to method ListBaseTTest.IsSynchronizedGetTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for get_Item(Int32)</summary>
		[PexMethod]
		public T ItemGetTest<T>([PexAssumeUnderTest]ListBase<T> target, int index)
			where T : IComparable<T>
		{
			T result = target[index];
			return result;
			// TODO: add assertions to method ListBaseTTest.ItemGetTest(ListBase`1<!!0>, Int32)
		}

		/// <summary>Test stub for get_SyncRoot()</summary>
		[PexMethod]
		public object SyncRootGetTest<T>([PexAssumeUnderTest]ListBase<T> target)
			where T : IComparable<T>
		{
			object result = target.SyncRoot;
			return result;
			// TODO: add assertions to method ListBaseTTest.SyncRootGetTest(ListBase`1<!!0>)
		}

		/// <summary>Test stub for set_Item(Int32, !0)</summary>
		[PexMethod]
		public void ItemSetTest<T>(
			[PexAssumeUnderTest]ListBase<T> target,
			int index,
			T value
		)
			where T : IComparable<T>
		{
			target[index] = value;
			// TODO: add assertions to method ListBaseTTest.ItemSetTest(ListBase`1<!!0>, Int32, !!0)
		}
	}
}
