using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ape;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Ape.Tests
{
	public partial class ItemTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
public void RenderTest979()
{
    ByteVector byteVector;
    Item item;
    ByteVector byteVector1;
    byte[] bs = new byte[12];
    byteVector = new ByteVector(bs, 12);
    item = new Item(byteVector, 0);
    byteVector1 = this.RenderTest(item);
    Assert.IsNotNull((object)byteVector1);
    Assert.AreEqual<bool>(false, byteVector1.IsSynchronized);
    Assert.IsNotNull(byteVector1.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector1.SyncRoot, (object)byteVector1));
    Assert.IsNotNull((object)item);
    Assert.AreEqual<string>("", item.Key);
    Assert.IsNull(item.Value);
    Assert.AreEqual<int>(9, item.Size);
    Assert.AreEqual<ItemType>(ItemType.Text, item.Type);
    Assert.AreEqual<bool>(false, item.ReadOnly);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
public void RenderTest148()
{
    ByteVector byteVector;
    Item item;
    ByteVector byteVector1;
    byte[] bs = new byte[11];
    bs[8] = (byte)1;
    byteVector = new ByteVector(bs, 11);
    item = new Item(byteVector, 0);
    byteVector1 = this.RenderTest(item);
    Assert.IsNotNull((object)byteVector1);
    Assert.AreEqual<bool>(false, byteVector1.IsSynchronized);
    Assert.IsNotNull(byteVector1.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector1.SyncRoot, (object)byteVector1));
    Assert.IsNotNull((object)item);
    Assert.AreEqual<string>("", item.Key);
    Assert.IsNull(item.Value);
    Assert.AreEqual<int>(10, item.Size);
    Assert.AreEqual<ItemType>(ItemType.Text, item.Type);
    Assert.AreEqual<bool>(false, item.ReadOnly);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
public void RenderTest34()
{
    ByteVector byteVector;
    Item item;
    ByteVector byteVector1;
    byte[] bs = new byte[12];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 12);
    item = new Item(byteVector, 0);
    byteVector1 = this.RenderTest(item);
    Assert.IsNotNull((object)byteVector1);
    Assert.AreEqual<bool>(false, byteVector1.IsSynchronized);
    Assert.IsNotNull(byteVector1.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector1.SyncRoot, (object)byteVector1));
    Assert.IsNotNull((object)item);
    Assert.AreEqual<string>("", item.Key);
    Assert.IsNull(item.Value);
    Assert.AreEqual<int>(10, item.Size);
    Assert.AreEqual<ItemType>(ItemType.Text, item.Type);
    Assert.AreEqual<bool>(false, item.ReadOnly);
}
	}
}
