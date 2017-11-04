using Microsoft.Pex.Framework.Exceptions;
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
	public partial class DivXTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void FullTagClearTest460()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[0];
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException885()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[1];
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void FullTagClearTest252()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[0];
    this.FullTagClearTest(divXTag, "﻿", ss, 0u, "﻿", ss1);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void FullTagClearTestThrowsPexAssertFailedException591()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[0];
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void FullTagClearTest526()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[0];
    this.FullTagClearTest(divXTag, "\0", ss, 1u, "\0", ss1);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void FullTagClearTestThrowsPexAssertFailedException264()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[1];
    ss1[0] = "\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void FullTagClearTestThrowsPexAssertFailedException557()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[0];
    this.FullTagClearTest(divXTag, "\0", ss, 11024u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void FullTagClearTest492()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[1];
    ss1[0] = "Action";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void FullTagClearTest138()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[2];
    string[] ss1 = new string[0];
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void FullTagClearTest667()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[0];
    this.FullTagClearTest(divXTag, "\0", ss, 260u, "\0", ss1);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException739()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[2];
    string[] ss1 = new string[2];
    ss[0] = "\0";
    ss[1] = "\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException178()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    ss[0] = "";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException780()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[2];
    string[] ss1 = new string[2];
    ss[0] = "\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException494()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[3];
    string[] ss1 = new string[2];
    ss[0] = "\0";
    ss[2] = "\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException800()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    ss[0] = "\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0﻿", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException858()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    ss[0] = "\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0　﻿", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void FullTagClearTestThrowsPexAssertFailedException789()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[0];
    ss[0] = ";";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void FullTagClearTest609()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[0];
    string[] ss1 = new string[0];
    this.FullTagClearTest(divXTag, "\0\t\0﻿", ss, 0u, "\0\0", ss1);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void FullTagClearTestThrowsPexAssertFailedException234()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[0];
    ss[0] = ";\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void FullTagClearTestThrowsPexAssertFailedException968()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[0];
    ss[0] = "\0;";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void FullTagClearTestThrowsPexAssertFailedException516()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[0];
    ss[0] = ";;";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void FullTagClearTest391()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[0];
    ss[0] = "\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException12()
{
    DivXTag divXTag;
    divXTag = DivXTagFactory.Create();
    string[] ss = new string[3];
    string[] ss1 = new string[3];
    ss[0] = "\0";
    this.FullTagClearTest(divXTag, "\0", ss, 0u, "\0", ss1);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagClearTestThrowsNullReferenceException777()
{
    ByteVector byteVector;
    DivXTag divXTag;
    byte[] bs = new byte[198];
    bs[0] = (byte)68;
    bs[1] = (byte)68;
    bs[2] = (byte)68;
    bs[3] = (byte)68;
    bs[4] = (byte)68;
    bs[5] = (byte)68;
    bs[6] = (byte)68;
    bs[7] = (byte)68;
    bs[8] = (byte)68;
    bs[9] = (byte)68;
    bs[10] = (byte)68;
    bs[11] = (byte)68;
    bs[12] = (byte)68;
    bs[13] = (byte)68;
    bs[14] = (byte)68;
    bs[15] = (byte)68;
    bs[16] = (byte)68;
    bs[17] = (byte)68;
    bs[18] = (byte)68;
    bs[19] = (byte)68;
    bs[20] = (byte)68;
    bs[21] = (byte)68;
    bs[22] = (byte)68;
    bs[23] = (byte)68;
    bs[24] = (byte)68;
    bs[25] = (byte)68;
    bs[26] = (byte)68;
    bs[27] = (byte)68;
    bs[28] = (byte)68;
    bs[29] = (byte)68;
    bs[30] = (byte)68;
    bs[31] = (byte)68;
    bs[32] = (byte)68;
    bs[33] = (byte)68;
    bs[34] = (byte)68;
    bs[35] = (byte)68;
    bs[36] = (byte)68;
    bs[37] = (byte)68;
    bs[38] = (byte)68;
    bs[39] = (byte)68;
    bs[40] = (byte)68;
    bs[41] = (byte)68;
    bs[42] = (byte)68;
    bs[43] = (byte)68;
    bs[44] = (byte)68;
    bs[45] = (byte)68;
    bs[46] = (byte)68;
    bs[47] = (byte)68;
    bs[48] = (byte)68;
    bs[49] = (byte)68;
    bs[50] = (byte)68;
    bs[51] = (byte)68;
    bs[52] = (byte)68;
    bs[53] = (byte)68;
    bs[54] = (byte)68;
    bs[55] = (byte)68;
    bs[56] = (byte)68;
    bs[57] = (byte)68;
    bs[58] = (byte)68;
    bs[59] = (byte)68;
    bs[60] = (byte)68;
    bs[61] = (byte)68;
    bs[62] = (byte)68;
    bs[63] = (byte)68;
    bs[64] = (byte)68;
    bs[65] = (byte)68;
    bs[66] = (byte)68;
    bs[67] = (byte)68;
    bs[68] = (byte)68;
    bs[69] = (byte)68;
    bs[70] = (byte)68;
    bs[71] = (byte)68;
    bs[72] = (byte)68;
    bs[73] = (byte)68;
    bs[74] = (byte)68;
    bs[75] = (byte)68;
    bs[76] = (byte)68;
    bs[77] = (byte)68;
    bs[78] = (byte)68;
    bs[79] = (byte)68;
    bs[80] = (byte)68;
    bs[81] = (byte)68;
    bs[82] = (byte)68;
    bs[83] = (byte)68;
    bs[84] = (byte)68;
    bs[85] = (byte)68;
    bs[86] = (byte)68;
    bs[87] = (byte)68;
    bs[88] = (byte)68;
    bs[89] = (byte)68;
    bs[90] = (byte)68;
    bs[91] = (byte)68;
    bs[92] = (byte)68;
    bs[93] = (byte)68;
    bs[94] = (byte)68;
    bs[95] = (byte)68;
    bs[96] = (byte)68;
    bs[97] = (byte)68;
    bs[98] = (byte)68;
    bs[99] = (byte)68;
    bs[100] = (byte)68;
    bs[101] = (byte)68;
    bs[102] = (byte)68;
    bs[103] = (byte)68;
    bs[104] = (byte)68;
    bs[105] = (byte)68;
    bs[106] = (byte)68;
    bs[107] = (byte)68;
    bs[108] = (byte)68;
    bs[109] = (byte)68;
    bs[110] = (byte)68;
    bs[111] = (byte)68;
    bs[112] = (byte)68;
    bs[113] = (byte)68;
    bs[114] = (byte)68;
    bs[115] = (byte)68;
    bs[116] = (byte)68;
    bs[117] = (byte)68;
    bs[118] = (byte)68;
    bs[119] = (byte)68;
    bs[120] = (byte)68;
    bs[121] = (byte)68;
    bs[122] = (byte)68;
    bs[123] = (byte)68;
    bs[124] = (byte)68;
    bs[125] = (byte)68;
    bs[126] = (byte)68;
    bs[sbyte.MaxValue] = (byte)68;
    bs[128] = (byte)68;
    bs[129] = (byte)73;
    bs[130] = (byte)86;
    bs[131] = (byte)88;
    bs[132] = (byte)84;
    bs[133] = (byte)65;
    bs[134] = (byte)71;
    bs[135] = (byte)68;
    bs[136] = (byte)68;
    bs[137] = (byte)68;
    bs[138] = (byte)68;
    bs[139] = (byte)68;
    bs[140] = (byte)68;
    bs[141] = (byte)68;
    bs[142] = (byte)68;
    bs[143] = (byte)68;
    bs[144] = (byte)68;
    bs[145] = (byte)68;
    bs[146] = (byte)68;
    bs[147] = (byte)68;
    bs[148] = (byte)68;
    bs[149] = (byte)68;
    bs[150] = (byte)68;
    bs[151] = (byte)68;
    bs[152] = (byte)68;
    bs[153] = (byte)68;
    bs[154] = (byte)68;
    bs[155] = (byte)68;
    bs[156] = (byte)68;
    bs[157] = (byte)68;
    bs[158] = (byte)68;
    bs[159] = (byte)68;
    bs[160] = (byte)68;
    bs[161] = (byte)68;
    bs[162] = (byte)68;
    bs[163] = (byte)68;
    bs[164] = (byte)68;
    bs[165] = (byte)68;
    bs[166] = (byte)68;
    bs[167] = (byte)68;
    bs[168] = (byte)68;
    bs[169] = (byte)68;
    bs[170] = (byte)68;
    bs[171] = (byte)68;
    bs[172] = (byte)68;
    bs[173] = (byte)68;
    bs[174] = (byte)68;
    bs[175] = (byte)68;
    bs[176] = (byte)68;
    bs[177] = (byte)68;
    bs[178] = (byte)68;
    bs[179] = (byte)68;
    bs[180] = (byte)68;
    bs[181] = (byte)68;
    bs[182] = (byte)68;
    bs[183] = (byte)68;
    bs[184] = (byte)68;
    bs[185] = (byte)68;
    bs[186] = (byte)68;
    bs[187] = (byte)68;
    bs[188] = (byte)68;
    bs[189] = (byte)68;
    bs[190] = (byte)68;
    bs[191] = (byte)68;
    bs[192] = (byte)68;
    bs[193] = (byte)68;
    bs[194] = (byte)68;
    bs[195] = (byte)68;
    bs[196] = (byte)68;
    bs[197] = (byte)68;
    byteVector = ByteVectorFactory.Create(bs, 135);
    divXTag = DivXTagFactory.Create(byteVector);
    string[] ss = new string[198];
    string[] ss1 = new string[198];
    this.FullTagClearTest
        (divXTag, new string('\0', 128), ss, 0u, new string('\0', 128), ss1);
}
	}
}
