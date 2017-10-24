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
public void SplitTest01ThrowsArgumentNullException219()
{
    ByteVectorCollection byteVectorCollection;
    byteVectorCollection = this.SplitTest01((ByteVector)null, (ByteVector)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void SplitTest01ThrowsArgumentNullException61()
{
    ByteVector byteVector;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    byteVectorCollection = this.SplitTest01(byteVector, (ByteVector)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void SplitTest01ThrowsArgumentNullException6101()
{
    ByteVector byteVector;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    byteVectorCollection = this.SplitTest01(byteVector, (ByteVector)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void SplitTest01ThrowsArgumentOutOfRangeException707()
{
    ByteVector byteVector;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void SplitTest01526()
{
    ByteVector byteVector;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector, 1);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
public void SplitTest01912()
{
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    byte[] bs1 = new byte[1];
    byteVector1 = new ByteVector(bs1, 1);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector1, 1);
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
public void SplitTest0191201()
{
    ByteVector byteVector;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[2];
    byteVector = new ByteVector(bs, 1);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector, 1);
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
public void SplitTest0191202()
{
    ByteVector byteVector;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[2];
    byteVector = new ByteVector(bs, 2);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector, 1);
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
public void SplitTest0191203()
{
    ByteVector byteVector;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[7];
    byteVector = new ByteVector(bs, 6);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector, 1);
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
public void SplitTest0191204()
{
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 5);
    byte[] bs1 = new byte[3];
    byteVector1 = new ByteVector(bs1, 1);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector1, 1);
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
[PexRaisedException(typeof(OverflowException))]
public void SplitTest01ThrowsOverflowException366()
{
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[7];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 5);
    byte[] bs1 = new byte[4];
    bs1[0] = (byte)1;
    byteVector1 = new ByteVector(bs1, 1);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector1, int.MaxValue);
}

[TestMethod]
[PexGeneratedBy(typeof(ByteVectorCollectionTest))]
public void SplitTest0191205()
{
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[7];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 6);
    byte[] bs1 = new byte[4];
    bs1[0] = (byte)1;
    byteVector1 = new ByteVector(bs1, 1);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector1, 1);
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
public void SplitTest0191206()
{
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[7];
    bs[0] = (byte)128;
    bs[1] = (byte)128;
    bs[2] = (byte)128;
    bs[3] = (byte)128;
    bs[4] = (byte)9;
    bs[5] = (byte)128;
    bs[6] = (byte)128;
    byteVector = new ByteVector(bs, 5);
    byte[] bs1 = new byte[6];
    bs1[0] = (byte)8;
    bs1[1] = (byte)128;
    bs1[2] = (byte)3;
    bs1[3] = (byte)5;
    bs1[4] = (byte)8;
    byteVector1 = new ByteVector(bs1, 5);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector1, 1);
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
public void SplitTest0191207()
{
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[6];
    bs[1] = (byte)1;
    byteVector = new ByteVector(bs, 5);
    byte[] bs1 = new byte[2];
    bs1[0] = (byte)1;
    byteVector1 = new ByteVector(bs1, 1);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector1, 1);
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
public void SplitTest01973()
{
    ByteVector byteVector;
    ByteVector byteVector1;
    ByteVectorCollection byteVectorCollection;
    byte[] bs = new byte[7];
    bs[6] = (byte)8;
    byteVector = new ByteVector(bs, 6);
    byte[] bs1 = new byte[6];
    bs1[0] = (byte)8;
    byteVector1 = new ByteVector(bs1, 5);
    byteVectorCollection = this.SplitTest01(byteVector, byteVector1, 64);
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
