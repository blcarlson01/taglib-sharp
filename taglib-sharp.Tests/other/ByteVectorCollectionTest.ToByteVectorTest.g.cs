using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
[ExpectedException(typeof(ArgumentNullException))]
public void ToByteVectorTestThrowsArgumentNullException355()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector byteVector;
    byteVectorCollection = new ByteVectorCollection((ByteVector[])null);
    byteVector = this.ToByteVectorTest(byteVectorCollection, (ByteVector)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ToByteVectorTestThrowsArgumentNullException35501()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector byteVector;
    ByteVector[] byteVectors = new ByteVector[0];
    byteVectorCollection = new ByteVectorCollection(byteVectors);
    byteVector = this.ToByteVectorTest(byteVectorCollection, (ByteVector)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
public void ToByteVectorTest262()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector byteVector;
    ByteVector byteVector1;
    byteVectorCollection = new ByteVectorCollection((ByteVector[])null);
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    byteVector1 = this.ToByteVectorTest(byteVectorCollection, byteVector);
    Assert.IsNotNull((object)byteVector1);
    Assert.AreEqual<bool>(false, byteVector1.IsSynchronized);
    Assert.IsNotNull(byteVector1.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector1.SyncRoot, (object)byteVector1));
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
public void ToByteVectorTest26201()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector byteVector;
    ByteVector byteVector1;
    byteVectorCollection = new ByteVectorCollection((ByteVector[])null);
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    byteVector1 = this.ToByteVectorTest(byteVectorCollection, byteVector);
    Assert.IsNotNull((object)byteVector1);
    Assert.AreEqual<bool>(false, byteVector1.IsSynchronized);
    Assert.IsNotNull(byteVector1.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector1.SyncRoot, (object)byteVector1));
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
[ExpectedException(typeof(ArgumentNullException))]
public void ToByteVectorTestThrowsArgumentNullException35502()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector byteVector;
    ByteVector[] byteVectors = new ByteVector[1];
    byteVectorCollection = new ByteVectorCollection(byteVectors);
    byteVector = this.ToByteVectorTest(byteVectorCollection, (ByteVector)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
public void ToByteVectorTest26202()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVector[] byteVectors = new ByteVector[1];
    byteVectorCollection = new ByteVectorCollection(byteVectors);
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    byteVector1 = this.ToByteVectorTest(byteVectorCollection, byteVector);
    Assert.IsNotNull((object)byteVector1);
    Assert.AreEqual<bool>(false, byteVector1.IsSynchronized);
    Assert.IsNotNull(byteVector1.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector1.SyncRoot, (object)byteVector1));
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
public void ToByteVectorTest26203()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVector[] byteVectors = new ByteVector[5];
    byteVectorCollection = new ByteVectorCollection(byteVectors);
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    byteVector1 = this.ToByteVectorTest(byteVectorCollection, byteVector);
    Assert.IsNotNull((object)byteVector1);
    Assert.AreEqual<bool>(false, byteVector1.IsSynchronized);
    Assert.IsNotNull(byteVector1.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector1.SyncRoot, (object)byteVector1));
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
public void ToByteVectorTest26204()
{
    ByteVectorCollection byteVectorCollection;
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVector[] byteVectors = new ByteVector[5];
    byteVectorCollection = new ByteVectorCollection(byteVectors);
    byte[] bs = new byte[4];
    byteVector = new ByteVector(bs, 2);
    byteVector1 = this.ToByteVectorTest(byteVectorCollection, byteVector);
    Assert.IsNotNull((object)byteVector1);
    Assert.AreEqual<bool>(false, byteVector1.IsSynchronized);
    Assert.IsNotNull(byteVector1.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector1.SyncRoot, (object)byteVector1));
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
