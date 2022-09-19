using System;

public class Structure
{
	//Set to private to ensure control of input
	private static int _width;
	private static int _height;
	private static int _length;

	//Easier property syntax
	public int Quality { get; set; }
	

	//Methods to set properties; Need to refactor into one
	public void SetWidth(int width)
	{
		_width = width;
	}

	public void SetHeight(int height)
	{
		_height = height;
	}

	public void SetLength(int length)
	{
		_length = length;
	}

	//Methods to get properties; Need to refactor into one
	public int GetLength()
	{
		return _length;
	}
	
	public int GetWidth()
	{
		return _width;
	}
	
	public int GetHeight()
	{
		return _height;
	}
}
