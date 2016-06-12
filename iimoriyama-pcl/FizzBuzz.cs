using System;

namespace iimoriyama_pcl
{
	public class FizzBuzz
	{
		public bool IsFizz(int num)
		{
			if (num < 0)
			{
				throw new ArgumentException("0以上を入力してください。");
			}

			return num / 3 != 0 && num % 3 == 0;
		}

		public bool IsBuzz(int num)
		{
			if (num < 0)
			{
				throw new ArgumentException("0以上を入力してください。");
			}
			return num / 5 != 0 && num % 5 == 0;
		}

		public bool IsFizzBuzz(int num)
		{
			if (num < 0)
			{
				throw new ArgumentException("0以上を入力してください。");
			}
			return this.IsFizz(num) && this.IsBuzz(num);
		}

		public string Game(int num)
		{
			if (num < 0)
			{
				throw new ArgumentException("0以上を入力してください。");
			}

			if (this.IsFizzBuzz(num))
			{
				return "FizzBuzz";
			}
			if (this.IsFizz(num))
			{
				return "Fizz";
			}
			if (this.IsBuzz(num))
			{
				return "Buzz";
			}
			return num.ToString();
		}
	}
}
