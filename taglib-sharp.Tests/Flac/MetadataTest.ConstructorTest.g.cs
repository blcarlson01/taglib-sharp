using TagLib;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TagLib.Flac;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Flac.Tests
{
	public partial class MetadataTest
	{

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTestThrowsArgumentNullException307()
{
    Metadata metadata;
    metadata = this.ConstructorTest((IEnumerable<Block>)null);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
public void ConstructorTest154()
{
    Metadata metadata;
    Block[] blocks = new Block[0];
    metadata = this.ConstructorTest((IEnumerable<Block>)blocks);
    Assert.IsNotNull((object)metadata);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConstructorTestThrowsNullReferenceException7()
{
    Metadata metadata;
    Block[] blocks = new Block[1];
    metadata = this.ConstructorTest((IEnumerable<Block>)blocks);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
public void ConstructorTest590()
{
    ByteVector byteVector;
    Block block;
    Metadata metadata;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    block = new Block(BlockType.StreamInfo, byteVector);
    Block[] blocks = new Block[1];
    blocks[0] = block;
    metadata = this.ConstructorTest((IEnumerable<Block>)blocks);
    Assert.IsNotNull((object)metadata);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
public void ConstructorTest59001()
{
    ByteVector byteVector;
    Block block;
    Metadata metadata;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    block = new Block(BlockType.StreamInfo, byteVector);
    Block[] blocks = new Block[1];
    blocks[0] = block;
    metadata = this.ConstructorTest((IEnumerable<Block>)blocks);
    Assert.IsNotNull((object)metadata);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
public void ConstructorTest59002()
{
    ByteVector byteVector;
    Block block;
    Metadata metadata;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 1);
    block = new Block(BlockType.StreamInfo, byteVector);
    Block[] blocks = new Block[1];
    blocks[0] = block;
    metadata = this.ConstructorTest((IEnumerable<Block>)blocks);
    Assert.IsNotNull((object)metadata);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorTestThrowsCorruptFileException21()
{
    ByteVector byteVector;
    Block block;
    Metadata metadata;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 1);
    block = new Block(BlockType.Picture, byteVector);
    Block[] blocks = new Block[1];
    blocks[0] = block;
    metadata = this.ConstructorTest((IEnumerable<Block>)blocks);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTestThrowsArgumentOutOfRangeException579()
{
    ByteVector byteVector;
    Block block;
    Metadata metadata;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 1);
    block = new Block(BlockType.XiphComment, byteVector);
    Block[] blocks = new Block[1];
    blocks[0] = block;
    metadata = this.ConstructorTest((IEnumerable<Block>)blocks);
}
	}
}
