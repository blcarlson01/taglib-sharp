// <copyright file="ByteVectorCollectionTest.cs">Copyright (c) 2006-2007 Brian Nickel.  Copyright (c) 2009-2010 Other contributors</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for ByteVectorCollection</summary>
    [PexClass(typeof(ByteVectorCollection))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ByteVectorCollectionTest
    {
        /// <summary>Test stub for .ctor(IEnumerable`1&lt;ByteVector&gt;)</summary>
        [PexMethod]
        public ByteVectorCollection ConstructorTest(IEnumerable<ByteVector> list)
        {
            ByteVectorCollection target = new ByteVectorCollection(list);
            return target;
            // TODO: add assertions to method ByteVectorCollectionTest.ConstructorTest(IEnumerable`1<ByteVector>)
        }

        /// <summary>Test stub for .ctor(ByteVector[])</summary>
        [PexMethod]
        public ByteVectorCollection ConstructorTest01(ByteVector[] list)
        {
            ByteVectorCollection target = new ByteVectorCollection(list);
            return target;
            // TODO: add assertions to method ByteVectorCollectionTest.ConstructorTest01(ByteVector[])
        }

        /// <summary>Test stub for SortedInsert(ByteVector, Boolean)</summary>
        [PexMethod]
        public void SortedInsertTest(
            [PexAssumeUnderTest]ByteVectorCollection target,
            ByteVector item,
            bool unique
        )
        {
            target.SortedInsert(item, unique);
            // TODO: add assertions to method ByteVectorCollectionTest.SortedInsertTest(ByteVectorCollection, ByteVector, Boolean)
        }

        /// <summary>Test stub for Split(ByteVector, ByteVector, Int32, Int32)</summary>
        [PexMethod]
        public ByteVectorCollection SplitTest(
            ByteVector vector,
            ByteVector pattern,
            int byteAlign,
            int max
        )
        {
            ByteVectorCollection result
               = ByteVectorCollection.Split(vector, pattern, byteAlign, max);
            return result;
            // TODO: add assertions to method ByteVectorCollectionTest.SplitTest(ByteVector, ByteVector, Int32, Int32)
        }

        /// <summary>Test stub for Split(ByteVector, ByteVector, Int32)</summary>
        [PexMethod]
        public ByteVectorCollection SplitTest01(
            ByteVector vector,
            ByteVector pattern,
            int byteAlign
        )
        {
            ByteVectorCollection result
               = ByteVectorCollection.Split(vector, pattern, byteAlign);
            return result;
            // TODO: add assertions to method ByteVectorCollectionTest.SplitTest01(ByteVector, ByteVector, Int32)
        }

        /// <summary>Test stub for Split(ByteVector, ByteVector)</summary>
        [PexMethod]
        public ByteVectorCollection SplitTest02(ByteVector vector, ByteVector pattern)
        {
            ByteVectorCollection result = ByteVectorCollection.Split(vector, pattern);
            return result;
            // TODO: add assertions to method ByteVectorCollectionTest.SplitTest02(ByteVector, ByteVector)
        }

        /// <summary>Test stub for ToByteVector(ByteVector)</summary>
        [PexMethod]
        public ByteVector ToByteVectorTest(
            [PexAssumeUnderTest]ByteVectorCollection target,
            ByteVector separator
        )
        {
            ByteVector result = target.ToByteVector(separator);
            return result;
            // TODO: add assertions to method ByteVectorCollectionTest.ToByteVectorTest(ByteVectorCollection, ByteVector)
        }
    }
}
