using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v1;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Id3v1.Tests
{
	public partial class TagTest
	{

	

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorDataTestThrowsCorruptFileException20003()
{
    ByteVector byteVector;
    Tag tag;
    byte[] bs = new byte[196];
    bs[0] = (byte)84;
    bs[1] = (byte)84;
    bs[2] = (byte)84;
    bs[3] = (byte)84;
    bs[4] = (byte)84;
    bs[5] = (byte)84;
    bs[6] = (byte)84;
    bs[7] = (byte)84;
    bs[8] = (byte)84;
    bs[9] = (byte)84;
    bs[10] = (byte)84;
    bs[11] = (byte)84;
    bs[12] = (byte)84;
    bs[13] = (byte)84;
    bs[14] = (byte)84;
    bs[15] = (byte)84;
    bs[16] = (byte)84;
    bs[17] = (byte)84;
    bs[18] = (byte)84;
    bs[19] = (byte)84;
    bs[20] = (byte)84;
    bs[21] = (byte)84;
    bs[22] = (byte)84;
    bs[23] = (byte)84;
    bs[24] = (byte)84;
    bs[25] = (byte)84;
    bs[26] = (byte)84;
    bs[27] = (byte)84;
    bs[28] = (byte)84;
    bs[29] = (byte)84;
    bs[30] = (byte)84;
    bs[31] = (byte)84;
    bs[32] = (byte)84;
    bs[33] = (byte)84;
    bs[34] = (byte)84;
    bs[35] = (byte)84;
    bs[36] = (byte)84;
    bs[37] = (byte)84;
    bs[38] = (byte)84;
    bs[39] = (byte)84;
    bs[40] = (byte)84;
    bs[41] = (byte)84;
    bs[42] = (byte)84;
    bs[43] = (byte)84;
    bs[44] = (byte)84;
    bs[45] = (byte)84;
    bs[46] = (byte)84;
    bs[47] = (byte)84;
    bs[48] = (byte)84;
    bs[49] = (byte)84;
    bs[50] = (byte)84;
    bs[51] = (byte)84;
    bs[52] = (byte)84;
    bs[53] = (byte)84;
    bs[54] = (byte)84;
    bs[55] = (byte)84;
    bs[56] = (byte)84;
    bs[57] = (byte)84;
    bs[58] = (byte)84;
    bs[59] = (byte)84;
    bs[60] = (byte)84;
    bs[61] = (byte)84;
    bs[62] = (byte)84;
    bs[63] = (byte)84;
    bs[64] = (byte)84;
    bs[65] = (byte)84;
    bs[66] = (byte)84;
    bs[67] = (byte)84;
    bs[68] = (byte)84;
    bs[69] = (byte)84;
    bs[70] = (byte)84;
    bs[71] = (byte)84;
    bs[72] = (byte)84;
    bs[73] = (byte)84;
    bs[74] = (byte)84;
    bs[75] = (byte)84;
    bs[76] = (byte)84;
    bs[77] = (byte)84;
    bs[78] = (byte)84;
    bs[79] = (byte)84;
    bs[80] = (byte)84;
    bs[81] = (byte)84;
    bs[82] = (byte)84;
    bs[83] = (byte)84;
    bs[84] = (byte)84;
    bs[85] = (byte)84;
    bs[86] = (byte)84;
    bs[87] = (byte)84;
    bs[88] = (byte)84;
    bs[89] = (byte)84;
    bs[90] = (byte)84;
    bs[91] = (byte)84;
    bs[92] = (byte)84;
    bs[93] = (byte)84;
    bs[94] = (byte)84;
    bs[95] = (byte)84;
    bs[96] = (byte)84;
    bs[97] = (byte)84;
    bs[98] = (byte)84;
    bs[99] = (byte)84;
    bs[100] = (byte)84;
    bs[101] = (byte)84;
    bs[102] = (byte)84;
    bs[103] = (byte)84;
    bs[104] = (byte)84;
    bs[105] = (byte)84;
    bs[106] = (byte)84;
    bs[107] = (byte)84;
    bs[108] = (byte)84;
    bs[109] = (byte)84;
    bs[110] = (byte)84;
    bs[111] = (byte)84;
    bs[112] = (byte)84;
    bs[113] = (byte)84;
    bs[114] = (byte)84;
    bs[115] = (byte)84;
    bs[116] = (byte)84;
    bs[117] = (byte)84;
    bs[118] = (byte)84;
    bs[119] = (byte)84;
    bs[120] = (byte)84;
    bs[121] = (byte)84;
    bs[122] = (byte)84;
    bs[123] = (byte)84;
    bs[124] = (byte)84;
    bs[125] = (byte)84;
    bs[126] = (byte)84;
    bs[sbyte.MaxValue] = (byte)84;
    bs[128] = (byte)84;
    bs[129] = (byte)84;
    bs[130] = (byte)84;
    bs[131] = (byte)84;
    bs[132] = (byte)84;
    bs[133] = (byte)84;
    bs[134] = (byte)84;
    bs[135] = (byte)84;
    bs[136] = (byte)84;
    bs[137] = (byte)84;
    bs[138] = (byte)84;
    bs[139] = (byte)84;
    bs[140] = (byte)84;
    bs[141] = (byte)84;
    bs[142] = (byte)84;
    bs[143] = (byte)84;
    bs[144] = (byte)84;
    bs[145] = (byte)84;
    bs[146] = (byte)84;
    bs[147] = (byte)84;
    bs[148] = (byte)84;
    bs[149] = (byte)84;
    bs[150] = (byte)84;
    bs[151] = (byte)84;
    bs[152] = (byte)84;
    bs[153] = (byte)84;
    bs[154] = (byte)84;
    bs[155] = (byte)84;
    bs[156] = (byte)84;
    bs[157] = (byte)84;
    bs[158] = (byte)84;
    bs[159] = (byte)84;
    bs[160] = (byte)84;
    bs[161] = (byte)84;
    bs[162] = (byte)84;
    bs[163] = (byte)84;
    bs[164] = (byte)84;
    bs[165] = (byte)84;
    bs[166] = (byte)84;
    bs[167] = (byte)84;
    bs[168] = (byte)84;
    bs[169] = (byte)84;
    bs[170] = (byte)84;
    bs[171] = (byte)84;
    bs[172] = (byte)84;
    bs[173] = (byte)84;
    bs[174] = (byte)84;
    bs[175] = (byte)84;
    bs[176] = (byte)84;
    bs[177] = (byte)84;
    bs[178] = (byte)84;
    bs[179] = (byte)84;
    bs[180] = (byte)84;
    bs[181] = (byte)84;
    bs[182] = (byte)84;
    bs[183] = (byte)84;
    bs[184] = (byte)84;
    bs[185] = (byte)84;
    bs[186] = (byte)84;
    bs[187] = (byte)84;
    bs[188] = (byte)84;
    bs[189] = (byte)84;
    bs[190] = (byte)84;
    bs[191] = (byte)84;
    bs[192] = (byte)84;
    bs[193] = (byte)84;
    bs[194] = (byte)84;
    bs[195] = (byte)84;
    byteVector = ByteVectorFactory.Create(bs, 133);
    StringHandler s0 = new StringHandler();
    tag = this.ConstructorDataTest(byteVector, s0);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorDataTestThrowsCorruptFileException20004()
{
    ByteVector byteVector;
    Tag tag;
    byte[] bs = new byte[193];
    bs[0] = (byte)84;
    bs[1] = (byte)65;
    byteVector = ByteVectorFactory.Create(bs, 132);
    StringHandler s0 = new StringHandler();
    tag = this.ConstructorDataTest(byteVector, s0);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void ConstructorDataTest40303()
{
    ByteVector byteVector;
    Tag tag;
    byte[] bs = new byte[192];
    bs[0] = (byte)84;
    bs[1] = (byte)65;
    bs[2] = (byte)71;
    bs[3] = (byte)71;
    bs[4] = (byte)71;
    bs[5] = (byte)71;
    bs[6] = (byte)71;
    bs[7] = (byte)71;
    bs[8] = (byte)71;
    bs[9] = (byte)71;
    bs[10] = (byte)71;
    bs[11] = (byte)71;
    bs[12] = (byte)71;
    bs[13] = (byte)71;
    bs[14] = (byte)71;
    bs[15] = (byte)71;
    bs[16] = (byte)71;
    bs[17] = (byte)71;
    bs[18] = (byte)71;
    bs[19] = (byte)71;
    bs[20] = (byte)71;
    bs[21] = (byte)71;
    bs[22] = (byte)71;
    bs[23] = (byte)71;
    bs[24] = (byte)71;
    bs[25] = (byte)71;
    bs[26] = (byte)71;
    bs[27] = (byte)71;
    bs[28] = (byte)71;
    bs[29] = (byte)71;
    bs[30] = (byte)71;
    bs[31] = (byte)71;
    bs[32] = (byte)71;
    bs[33] = (byte)71;
    bs[34] = (byte)71;
    bs[35] = (byte)71;
    bs[36] = (byte)71;
    bs[37] = (byte)71;
    bs[38] = (byte)71;
    bs[39] = (byte)71;
    bs[40] = (byte)71;
    bs[41] = (byte)71;
    bs[42] = (byte)71;
    bs[43] = (byte)71;
    bs[44] = (byte)71;
    bs[45] = (byte)71;
    bs[46] = (byte)71;
    bs[47] = (byte)71;
    bs[48] = (byte)71;
    bs[49] = (byte)71;
    bs[50] = (byte)71;
    bs[51] = (byte)71;
    bs[52] = (byte)71;
    bs[53] = (byte)71;
    bs[54] = (byte)71;
    bs[55] = (byte)71;
    bs[56] = (byte)71;
    bs[57] = (byte)71;
    bs[58] = (byte)71;
    bs[59] = (byte)71;
    bs[60] = (byte)71;
    bs[61] = (byte)71;
    bs[62] = (byte)71;
    bs[63] = (byte)71;
    bs[64] = (byte)71;
    bs[65] = (byte)71;
    bs[66] = (byte)71;
    bs[67] = (byte)71;
    bs[68] = (byte)71;
    bs[69] = (byte)71;
    bs[70] = (byte)71;
    bs[71] = (byte)71;
    bs[72] = (byte)71;
    bs[73] = (byte)71;
    bs[74] = (byte)71;
    bs[75] = (byte)71;
    bs[76] = (byte)71;
    bs[77] = (byte)71;
    bs[78] = (byte)71;
    bs[79] = (byte)71;
    bs[80] = (byte)71;
    bs[81] = (byte)71;
    bs[82] = (byte)71;
    bs[83] = (byte)71;
    bs[84] = (byte)71;
    bs[85] = (byte)71;
    bs[86] = (byte)71;
    bs[87] = (byte)71;
    bs[88] = (byte)71;
    bs[89] = (byte)71;
    bs[90] = (byte)71;
    bs[91] = (byte)71;
    bs[92] = (byte)71;
    bs[93] = (byte)71;
    bs[94] = (byte)71;
    bs[95] = (byte)71;
    bs[96] = (byte)71;
    bs[97] = (byte)71;
    bs[98] = (byte)71;
    bs[99] = (byte)71;
    bs[100] = (byte)71;
    bs[101] = (byte)71;
    bs[102] = (byte)71;
    bs[103] = (byte)71;
    bs[104] = (byte)71;
    bs[105] = (byte)71;
    bs[106] = (byte)71;
    bs[107] = (byte)71;
    bs[108] = (byte)71;
    bs[109] = (byte)71;
    bs[110] = (byte)71;
    bs[111] = (byte)71;
    bs[112] = (byte)71;
    bs[113] = (byte)71;
    bs[114] = (byte)71;
    bs[115] = (byte)71;
    bs[116] = (byte)71;
    bs[117] = (byte)71;
    bs[118] = (byte)71;
    bs[119] = (byte)71;
    bs[120] = (byte)71;
    bs[121] = (byte)71;
    bs[122] = (byte)71;
    bs[123] = (byte)71;
    bs[124] = (byte)71;
    bs[125] = (byte)71;
    bs[126] = (byte)71;
    bs[sbyte.MaxValue] = (byte)71;
    bs[128] = (byte)71;
    bs[129] = (byte)71;
    bs[130] = (byte)71;
    bs[131] = (byte)71;
    bs[132] = (byte)71;
    bs[133] = (byte)71;
    bs[134] = (byte)71;
    bs[135] = (byte)71;
    bs[136] = (byte)71;
    bs[137] = (byte)71;
    bs[138] = (byte)71;
    bs[139] = (byte)71;
    bs[140] = (byte)71;
    bs[141] = (byte)71;
    bs[142] = (byte)71;
    bs[143] = (byte)71;
    bs[144] = (byte)71;
    bs[145] = (byte)71;
    bs[146] = (byte)71;
    bs[147] = (byte)71;
    bs[148] = (byte)71;
    bs[149] = (byte)71;
    bs[150] = (byte)71;
    bs[151] = (byte)71;
    bs[152] = (byte)71;
    bs[153] = (byte)71;
    bs[154] = (byte)71;
    bs[155] = (byte)71;
    bs[156] = (byte)71;
    bs[157] = (byte)71;
    bs[158] = (byte)71;
    bs[159] = (byte)71;
    bs[160] = (byte)71;
    bs[161] = (byte)71;
    bs[162] = (byte)71;
    bs[163] = (byte)71;
    bs[164] = (byte)71;
    bs[165] = (byte)71;
    bs[166] = (byte)71;
    bs[167] = (byte)71;
    bs[168] = (byte)71;
    bs[169] = (byte)71;
    bs[170] = (byte)71;
    bs[171] = (byte)71;
    bs[172] = (byte)71;
    bs[173] = (byte)71;
    bs[174] = (byte)71;
    bs[175] = (byte)71;
    bs[176] = (byte)71;
    bs[177] = (byte)71;
    bs[178] = (byte)71;
    bs[179] = (byte)71;
    bs[180] = (byte)71;
    bs[181] = (byte)71;
    bs[182] = (byte)71;
    bs[183] = (byte)71;
    bs[184] = (byte)71;
    bs[185] = (byte)71;
    bs[186] = (byte)71;
    bs[187] = (byte)71;
    bs[188] = (byte)71;
    bs[189] = (byte)71;
    bs[190] = (byte)71;
    bs[191] = (byte)71;
    byteVector = ByteVectorFactory.Create(bs, 134);
    StringHandler s0 = new StringHandler();
    tag = this.ConstructorDataTest(byteVector, s0);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void ConstructorDataTest40304()
{
    ByteVector byteVector;
    Tag tag;
    byte[] bs = new byte[193];
    bs[0] = (byte)84;
    bs[1] = (byte)65;
    bs[2] = (byte)71;
    byteVector = ByteVectorFactory.Create(bs, 192);
    StringHandler s0 = new StringHandler();
    tag = this.ConstructorDataTest(byteVector, s0);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void ConstructorDataTest40305()
{
    ByteVector byteVector;
    Tag tag;
    byte[] bs = new byte[177];
    bs[0] = (byte)84;
    bs[1] = (byte)65;
    bs[2] = (byte)71;
    bs[3] = (byte)84;
    bs[4] = (byte)84;
    bs[5] = (byte)84;
    bs[6] = (byte)84;
    bs[7] = (byte)84;
    bs[8] = (byte)84;
    bs[9] = (byte)84;
    bs[10] = (byte)84;
    bs[11] = (byte)84;
    bs[12] = (byte)84;
    bs[13] = (byte)84;
    bs[14] = (byte)84;
    bs[15] = (byte)84;
    bs[16] = (byte)84;
    bs[17] = (byte)84;
    bs[18] = (byte)84;
    bs[19] = (byte)84;
    bs[20] = (byte)84;
    bs[21] = (byte)84;
    bs[22] = (byte)84;
    bs[23] = (byte)84;
    bs[24] = (byte)84;
    bs[25] = (byte)84;
    bs[26] = (byte)84;
    bs[27] = (byte)84;
    bs[28] = (byte)84;
    bs[29] = (byte)84;
    bs[30] = (byte)84;
    bs[31] = (byte)84;
    bs[32] = (byte)84;
    bs[33] = (byte)84;
    bs[34] = (byte)84;
    bs[35] = (byte)84;
    bs[36] = (byte)84;
    bs[37] = (byte)84;
    bs[38] = (byte)84;
    bs[39] = (byte)84;
    bs[40] = (byte)84;
    bs[41] = (byte)84;
    bs[42] = (byte)84;
    bs[43] = (byte)84;
    bs[44] = (byte)84;
    bs[45] = (byte)84;
    bs[46] = (byte)84;
    bs[47] = (byte)84;
    bs[48] = (byte)84;
    bs[49] = (byte)84;
    bs[50] = (byte)84;
    bs[51] = (byte)84;
    bs[52] = (byte)84;
    bs[53] = (byte)84;
    bs[54] = (byte)84;
    bs[55] = (byte)84;
    bs[56] = (byte)84;
    bs[57] = (byte)84;
    bs[58] = (byte)84;
    bs[59] = (byte)84;
    bs[60] = (byte)84;
    bs[61] = (byte)84;
    bs[62] = (byte)84;
    bs[63] = (byte)84;
    bs[64] = (byte)84;
    bs[65] = (byte)84;
    bs[66] = (byte)84;
    bs[67] = (byte)84;
    bs[68] = (byte)84;
    bs[69] = (byte)84;
    bs[70] = (byte)84;
    bs[71] = (byte)84;
    bs[72] = (byte)84;
    bs[73] = (byte)84;
    bs[74] = (byte)84;
    bs[75] = (byte)84;
    bs[76] = (byte)84;
    bs[77] = (byte)84;
    bs[78] = (byte)84;
    bs[79] = (byte)84;
    bs[80] = (byte)84;
    bs[81] = (byte)84;
    bs[82] = (byte)84;
    bs[83] = (byte)84;
    bs[84] = (byte)84;
    bs[85] = (byte)84;
    bs[86] = (byte)84;
    bs[87] = (byte)84;
    bs[88] = (byte)84;
    bs[89] = (byte)84;
    bs[90] = (byte)84;
    bs[91] = (byte)84;
    bs[92] = (byte)84;
    bs[93] = (byte)84;
    bs[94] = (byte)84;
    bs[95] = (byte)84;
    bs[96] = (byte)84;
    bs[97] = (byte)84;
    bs[98] = (byte)84;
    bs[99] = (byte)84;
    bs[100] = (byte)84;
    bs[101] = (byte)84;
    bs[102] = (byte)84;
    bs[103] = (byte)84;
    bs[104] = (byte)84;
    bs[105] = (byte)84;
    bs[106] = (byte)84;
    bs[107] = (byte)84;
    bs[108] = (byte)84;
    bs[109] = (byte)84;
    bs[110] = (byte)84;
    bs[111] = (byte)84;
    bs[112] = (byte)84;
    bs[113] = (byte)84;
    bs[114] = (byte)84;
    bs[115] = (byte)84;
    bs[116] = (byte)84;
    bs[117] = (byte)84;
    bs[118] = (byte)84;
    bs[119] = (byte)84;
    bs[120] = (byte)84;
    bs[121] = (byte)84;
    bs[122] = (byte)84;
    bs[123] = (byte)84;
    bs[124] = (byte)84;
    bs[126] = (byte)1;
    bs[sbyte.MaxValue] = (byte)84;
    bs[128] = (byte)84;
    bs[129] = (byte)84;
    bs[130] = (byte)84;
    bs[131] = (byte)84;
    bs[132] = (byte)84;
    bs[133] = (byte)84;
    bs[134] = (byte)84;
    bs[135] = (byte)84;
    bs[136] = (byte)84;
    bs[137] = (byte)84;
    bs[138] = (byte)84;
    bs[139] = (byte)84;
    bs[140] = (byte)84;
    bs[141] = (byte)84;
    bs[142] = (byte)84;
    bs[143] = (byte)84;
    bs[144] = (byte)84;
    bs[145] = (byte)84;
    bs[146] = (byte)84;
    bs[147] = (byte)84;
    bs[148] = (byte)84;
    bs[149] = (byte)84;
    bs[150] = (byte)84;
    bs[151] = (byte)84;
    bs[152] = (byte)84;
    bs[153] = (byte)84;
    bs[154] = (byte)84;
    bs[155] = (byte)84;
    bs[156] = (byte)84;
    bs[157] = (byte)84;
    bs[158] = (byte)84;
    bs[159] = (byte)84;
    bs[160] = (byte)84;
    bs[161] = (byte)84;
    bs[162] = (byte)84;
    bs[163] = (byte)84;
    bs[164] = (byte)84;
    bs[165] = (byte)84;
    bs[166] = (byte)84;
    bs[167] = (byte)84;
    bs[168] = (byte)84;
    bs[169] = (byte)84;
    bs[170] = (byte)84;
    bs[171] = (byte)84;
    bs[172] = (byte)84;
    bs[173] = (byte)84;
    bs[174] = (byte)84;
    bs[175] = (byte)84;
    bs[176] = (byte)84;
    byteVector = ByteVectorFactory.Create(bs, 168);
    StringHandler s0 = new StringHandler();
    tag = this.ConstructorDataTest(byteVector, s0);
    Assert.IsNotNull((object)tag);
}
	}
}
