using System;

namespace Less07_task01
{
	class Program
	{
		static void Main(string[] args)
		{
			MyStruct inst = new MyStruct(4);

			Console.WriteLine(
"{0}\t{1}\t{2}\t", inst.X, inst.Y, inst.Z);

			Console.ReadKey();
		}
	}

	struct MyStruct
	{
		int x;
		int y;
		int z;

		public MyStruct(int x, int y, int z)
			: this(x, y)
		{
			this.z = z;
		}

		public MyStruct(int x, int y) : this(x)
		{
			this.y = y;
		}

		public MyStruct(int x) : this()
		{
			this.x = x;
		}

		public int X { get { return x; } }
		public int Y { get { return y; } }
		public int Z { get { return z; } }
	}
}