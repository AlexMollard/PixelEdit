using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Vector2
{
	public float x;
	public float y;

	public Vector2(float x, float y)
	{
		this.x = x;
		this.y = y;
	}

	public Vector2(Point point)
	{
		this.x = (float)point.X;
		this.y = (float)point.Y;
	}

	public float Magnitude()
	{
		return (float)Math.Sqrt(x * x + y * y);
	}

	public void Normalise()
	{
		float length = Magnitude();
		if (length != 0.0f)
		{
			x /= length;
			y /= length;
		}
	}

	public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
	{
		return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
	}

	public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
	{
		return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
	}

	public static Vector2 operator *(Vector2 lhs, float rhs)
	{
		return new Vector2(lhs.x * rhs, lhs.y * rhs);
	}

	public Point GetPoint()
	{
		return new Point((int)x, (int)y);
	}
}
