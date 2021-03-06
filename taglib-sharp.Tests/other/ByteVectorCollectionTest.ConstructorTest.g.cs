using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Tests
{
	public partial class ByteVectorCollectionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
public void ConstructorTest209()
{
    ByteVectorCollection byteVectorCollection;
    byteVectorCollection = this.ConstructorTest((IEnumerable<ByteVector>)null);
    Assert.IsNotNull((object)byteVectorCollection);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsReadOnly);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsFixedSize);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsSynchronized);
    Assert.IsNotNull(((ListBase<ByteVector>)byteVectorCollection).SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((ListBase<ByteVector>)byteVectorCollection).SyncRoot, 
                       (object)byteVectorCollection));
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
public void ConstructorTest35()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector[] byteVectors = new ByteVector[0];
    byteVectorCollection =
      this.ConstructorTest((IEnumerable<ByteVector>)byteVectors);
    Assert.IsNotNull((object)byteVectorCollection);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsReadOnly);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsFixedSize);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsSynchronized);
    Assert.IsNotNull(((ListBase<ByteVector>)byteVectorCollection).SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((ListBase<ByteVector>)byteVectorCollection).SyncRoot, 
                       (object)byteVectorCollection));
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
public void ConstructorTest461()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector[] byteVectors = new ByteVector[1];
    byteVectorCollection =
      this.ConstructorTest((IEnumerable<ByteVector>)byteVectors);
    Assert.IsNotNull((object)byteVectorCollection);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsReadOnly);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsFixedSize);
    Assert.AreEqual<bool>
        (false, ((ListBase<ByteVector>)byteVectorCollection).IsSynchronized);
    Assert.IsNotNull(((ListBase<ByteVector>)byteVectorCollection).SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((ListBase<ByteVector>)byteVectorCollection).SyncRoot, 
                       (object)byteVectorCollection));
}
	}
}
