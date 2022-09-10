using System;

public class Structure
{
	//Set to private to ensure control of input
	private static int _width;
	private static int _height;
	private static int _length;

	//Methods to set properties
	public static void SetWidth(int Width)
	{
		_width = Width;
	}

	public static void SetHeight(int Height)
	{
		_height = Height;
	}

	public static void SetLength(int Length)
	{
		_length = Length;
	}

}
