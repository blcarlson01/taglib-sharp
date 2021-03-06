using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v1;
using TagLib.Tests;

namespace TagLib.Id3v1.Tests
{
    /// <summary>This class contains parameterized unit tests for Tag</summary>
    [TestClass]
    [PexClass(typeof(Tag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TagTest
    {
	
		[PexMethod]
		public Tag FullTagTest([PexAssumeUnderTest]Tag tag, string title,
			string[] performers, string album, uint year, string comment, 
			uint track, string[] genres)
		{
			PexAssume.IsNotNull(genres);
			PexAssume.IsTrue(year < 10000);
			PexAssume.IsTrue(track < 257);
			
			tag.Title = title;
			tag.Performers = performers;
			tag.Album = album;
			tag.Comment = comment;
			tag.Genres = genres;
			tag.Year = year;
			tag.Track = track;

			PexAssert.AreEqual(title, tag.Title);

			if(performers == null)
			{
				PexAssert.AreEqual(typeof(string[]), tag.Performers.GetType());
			}
			else
			{
				PexAssert.AreEqual(performers.Length, tag.Performers.Length);
				PexAssert.AreEqual(string.Join("; ", performers), tag.JoinedPerformers);
			}			
			
			PexAssert.AreEqual(album,tag.Album );
			PexAssert.AreEqual(comment, tag.Comment);
			if(track == 256)
			{
				PexAssert.AreEqual(0, tag.Track);
			}
			else
			{
				PexAssert.AreEqual(track, tag.Track);
			}
			
			PexAssert.AreEqual(genres.Length, tag.Genres.Length);
			PexAssert.AreEqual(string.Join("; ", genres), tag.JoinedGenres);
			PexAssert.AreEqual(year, tag.Year);
			
			//Clear
			PexAssert.AreEqual(false, tag.IsEmpty);
			tag.Clear();
			PexAssert.IsTrue(tag.IsEmpty);

			return tag;
		}
				
		[PexMethod]
		public Tag ConstructorDataTest(ByteVector data, StringHandler handler)
		{
			PexAssume.IsNotNull(handler);
			Tag tag = new Tag(data);
			Tag.DefaultStringHandler = handler;
			PexAssert.IsNotNull(Tag.DefaultStringHandler);
			PexAssert.IsNotNull(tag);
			return tag;
		}
		
	}
}
