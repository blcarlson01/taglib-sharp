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
public void ReadOnlyGetTest886()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[12];
    byteVector = new ByteVector(bs, 12);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)item);
    Assert.AreEqual<string>("", item.Key);
    Assert.IsNull(item.Value);
    Assert.AreEqual<int>(9, item.Size);
    Assert.AreEqual<ItemType>(ItemType.Text, item.Type);
    Assert.AreEqual<bool>(false, item.ReadOnly);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
public void ReadOnlyGetTest407()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[12];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 12);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)item);
    Assert.AreEqual<string>("", item.Key);
    Assert.IsNull(item.Value);
    Assert.AreEqual<int>(10, item.Size);
    Assert.AreEqual<ItemType>(ItemType.Text, item.Type);
    Assert.AreEqual<bool>(false, item.ReadOnly);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest01()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[324];
    bs[1] = (byte)1;
    byteVector = new ByteVector(bs, 324);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
public void ReadOnlyGetTest661()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[11];
    bs[8] = (byte)1;
    byteVector = new ByteVector(bs, 11);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)item);
    Assert.AreEqual<string>("", item.Key);
    Assert.IsNull(item.Value);
    Assert.AreEqual<int>(10, item.Size);
    Assert.AreEqual<ItemType>(ItemType.Text, item.Type);
    Assert.AreEqual<bool>(false, item.ReadOnly);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest02()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[486];
    bs[1] = (byte)1;
    bs[8] = (byte)8;
    byteVector = new ByteVector(bs, 486);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest03()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[350];
    bs[1] = (byte)1;
    bs[8] = (byte)1;
    bs[9] = (byte)8;
    byteVector = new ByteVector(bs, 350);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest04()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[390];
    bs[1] = (byte)1;
    bs[8] = (byte)1;
    bs[9] = (byte)1;
    bs[10] = (byte)1;
    byteVector = new ByteVector(bs, 390);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest05()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[354];
    bs[1] = (byte)1;
    byteVector = new ByteVector(bs, 320);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
public void ReadOnlyGetTest821()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[24];
    bs[8] = (byte)1;
    bs[9] = (byte)1;
    bs[10] = (byte)1;
    bs[11] = (byte)1;
    bs[12] = (byte)1;
    bs[13] = (byte)1;
    bs[14] = (byte)1;
    bs[15] = (byte)128;
    bs[16] = (byte)1;
    bs[17] = (byte)1;
    bs[18] = (byte)1;
    bs[19] = (byte)1;
    byteVector = new ByteVector(bs, 24);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)item);
    Assert.AreEqual<string>("�", item.Key);
    Assert.IsNull(item.Value);
    Assert.AreEqual<int>(21, item.Size);
    Assert.AreEqual<ItemType>(ItemType.Text, item.Type);
    Assert.AreEqual<bool>(false, item.ReadOnly);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest06()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[320];
    bs[1] = (byte)1;
    bs[8] = (byte)128;
    bs[9] = (byte)1;
    bs[10] = (byte)1;
    bs[11] = (byte)1;
    bs[12] = (byte)1;
    bs[13] = (byte)1;
    bs[14] = (byte)1;
    bs[15] = (byte)1;
    bs[16] = (byte)1;
    bs[17] = (byte)1;
    bs[18] = (byte)1;
    bs[19] = (byte)1;
    byteVector = new ByteVector(bs, 320);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest07()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[403];
    bs[1] = (byte)1;
    bs[8] = (byte)1;
    bs[9] = (byte)1;
    bs[10] = (byte)1;
    bs[11] = (byte)1;
    bs[12] = (byte)1;
    bs[13] = (byte)1;
    bs[14] = (byte)1;
    bs[15] = (byte)1;
    bs[16] = (byte)1;
    bs[17] = (byte)1;
    bs[18] = (byte)128;
    bs[19] = (byte)1;
    bs[20] = (byte)1;
    bs[21] = (byte)1;
    byteVector = new ByteVector(bs, 403);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest08()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[322];
    bs[1] = (byte)1;
    bs[8] = (byte)1;
    bs[9] = (byte)1;
    bs[10] = (byte)1;
    bs[11] = (byte)1;
    bs[12] = (byte)1;
    bs[13] = (byte)1;
    bs[14] = (byte)1;
    bs[15] = (byte)1;
    bs[16] = (byte)1;
    bs[17] = (byte)1;
    bs[18] = (byte)1;
    bs[19] = (byte)1;
    bs[20] = (byte)1;
    bs[21] = (byte)1;
    bs[22] = (byte)1;
    byteVector = new ByteVector(bs, 322);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest09()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[350];
    bs[1] = (byte)1;
    bs[8] = (byte)1;
    bs[9] = (byte)1;
    bs[10] = (byte)1;
    bs[11] = (byte)1;
    bs[12] = (byte)1;
    bs[13] = (byte)1;
    bs[14] = (byte)1;
    bs[15] = (byte)1;
    bs[16] = (byte)1;
    bs[17] = (byte)1;
    bs[18] = (byte)1;
    bs[19] = (byte)1;
    bs[20] = (byte)1;
    bs[21] = (byte)1;
    bs[22] = (byte)1;
    bs[23] = (byte)1;
    bs[24] = (byte)128;
    bs[25] = (byte)1;
    bs[26] = (byte)1;
    bs[27] = (byte)1;
    byteVector = new ByteVector(bs, 350);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}

[TestMethod]
[PexGeneratedBy(typeof(ItemTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ReadOnlyGetTest10()
{
    ByteVector byteVector;
    Item item;
    bool b;
    byte[] bs = new byte[397];
    bs[1] = (byte)1;
    bs[8] = (byte)1;
    bs[9] = (byte)4;
    bs[10] = (byte)2;
    bs[11] = (byte)1;
    bs[12] = (byte)1;
    bs[13] = (byte)1;
    bs[14] = (byte)1;
    bs[15] = (byte)1;
    bs[16] = (byte)1;
    bs[17] = (byte)1;
    bs[18] = (byte)1;
    bs[19] = (byte)1;
    bs[20] = (byte)1;
    bs[21] = (byte)1;
    bs[22] = (byte)1;
    bs[23] = (byte)1;
    bs[24] = (byte)2;
    bs[25] = (byte)2;
    bs[26] = (byte)1;
    bs[27] = (byte)1;
    byteVector = new ByteVector(bs, 397);
    item = new Item(byteVector, 0);
    b = this.ReadOnlyGetTest(item);
}
	}
}
