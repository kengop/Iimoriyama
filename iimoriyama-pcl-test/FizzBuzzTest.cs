using Microsoft.VisualStudio.TestTools.UnitTesting;
using iimoriyama_pcl;
using System.Collections.Generic;

namespace iimoriyama_pcl_test
{
	[TestClass]
	public class FizzBuzzTest
	{
		[TestMethod]
		public void IsFizzTest()
		{
			var f = new FizzBuzz();

			Assert.AreEqual(false, f.IsFizz(0));

			Assert.AreEqual(false, f.IsFizz(2));
			Assert.AreEqual(true, f.IsFizz(3));
			Assert.AreEqual(false, f.IsFizz(4));
		}

		[TestMethod]
		public void IsBuzzTest()
		{
			var f = new FizzBuzz();

			Assert.AreEqual(false, f.IsBuzz(0));

			Assert.AreEqual(false, f.IsBuzz(4));
			Assert.AreEqual(true, f.IsBuzz(5));
			Assert.AreEqual(false, f.IsBuzz(6));
		}

		[TestMethod]
		public void IsFizzBuzzTest()
		{
			var f = new FizzBuzz();

			Assert.AreEqual(false, f.IsFizzBuzz(0));

			Assert.AreEqual(false, f.IsFizzBuzz(13));
			Assert.AreEqual(true, f.IsFizzBuzz(15));
			Assert.AreEqual(false, f.IsFizzBuzz(16));
		}

		[TestMethod]
		public void GameTest()
		{
			var f = new FizzBuzz();
			var e = new Dictionary<int, string>()
			{
				{ 1, "1" },
				{ 2, "2"},
				{ 3, "Fizz"},
				{ 4, "4"},
				{ 5, "Buzz"},
				{ 6, "Fizz"},
				{ 7, "7"},
				{ 8, "8"},
				{ 9, "Fizz"},
				{10, "Buzz"},
				{11, "11"},
				{12, "Fizz"},
				{13, "13"},
				{14, "14"},
				{15, "FizzBuzz"},
				{16, "16"}
			};

			foreach(var i in e)
			{
				Assert.AreEqual(i.Value, f.Game(i.Key));
			}
		}
	}
}
