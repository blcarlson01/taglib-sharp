using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Riff;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Riff.Tests
{
	public partial class MovieIdTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(MovieIdTagTest))]
[PexRaisedException(typeof(ArgumentNullException))]
public void ConstructorTestThrowsArgumentNullException693()
{
    MovieIdTag movieIdTag;
    movieIdTag = this.ConstructorTest((ByteVector)null);
}

[TestMethod]
[PexGeneratedBy(typeof(MovieIdTagTest))]
public void ConstructorTest2()
{
    ByteVector byteVector;
    MovieIdTag movieIdTag;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    movieIdTag = this.ConstructorTest(byteVector);
    Assert.IsNotNull((object)movieIdTag);
}

[TestMethod]
[PexGeneratedBy(typeof(MovieIdTagTest))]
public void ConstructorTest201()
{
    ByteVector byteVector;
    MovieIdTag movieIdTag;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    movieIdTag = this.ConstructorTest(byteVector);
    Assert.IsNotNull((object)movieIdTag);
}

[TestMethod]
[PexGeneratedBy(typeof(MovieIdTagTest))]
public void ConstructorTest202()
{
    ByteVector byteVector;
    MovieIdTag movieIdTag;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    movieIdTag = this.ConstructorTest(byteVector);
    Assert.IsNotNull((object)movieIdTag);
}

[TestMethod]
[PexGeneratedBy(typeof(MovieIdTagTest))]
public void ConstructorTest203()
{
    ByteVector byteVector;
    MovieIdTag movieIdTag;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 10);
    movieIdTag = this.ConstructorTest(byteVector);
    Assert.IsNotNull((object)movieIdTag);
}

[TestMethod]
[PexGeneratedBy(typeof(MovieIdTagTest))]
public void ConstructorTest204()
{
    ByteVector byteVector;
    MovieIdTag movieIdTag;
    byte[] bs = new byte[18];
    byteVector = new ByteVector(bs, 18);
    movieIdTag = this.ConstructorTest(byteVector);
    Assert.IsNotNull((object)movieIdTag);
}
	}
}
