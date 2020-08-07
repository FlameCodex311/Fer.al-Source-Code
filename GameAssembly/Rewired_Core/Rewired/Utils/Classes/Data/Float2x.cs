/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct Float2x : IEquatable<Rewired.Utils.Classes.Data.Float2x> // TypeDefIndex: 7003
	{
		// Fields
		public const int Length = 2; // Metadata: 0x007666EE
		public float a; // 0x00
		public float b; // 0x04
		private static Func<Float2x, Float2x, Float2x> _additionDelegate; // 0x00
		private static Func<Float2x, Float2x, Float2x> _subtractionDelegate; // 0x08
		private static Func<Float2x, Float2x, Float2x> _multiplicationDelegate; // 0x10
		private static Func<Float2x, Float2x, Float2x> _divisionDelegate; // 0x18
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x00000001800B4B40-0x00000001800B4BD0 0x00000001800B4BD0-0x00000001800B4CA0
		public static Float2x Zero { get; } // 0x0000000181090E60-0x0000000181090E70 
	
		// Constructors
		public Float2x(float a, float b); // 0x00000001800A1C30-0x00000001800A1C40
	
		// Methods
		public Float2x Clone(); // 0x00000001800B4950-0x00000001800B4970
		public static Float2x Clone(Float2x obj); // 0x0000000181090B00-0x0000000181090B30
		public override bool Equals(object obj); // 0x00000001800B49A0-0x00000001800B4A70
		public override int GetHashCode(); // 0x00000001800B4A70-0x00000001800B4AB0
		public bool Equals(Float2x other); // 0x00000001800B4970-0x00000001800B49A0
		public override string ToString(); // 0x00000001800B4AB0-0x00000001800B4B40
		public static Float2x Add(Float2x value1, Float2x value2); // 0x0000000181090AC0-0x0000000181090B00
		public static Float2x Subtract(Float2x value1, Float2x value2); // 0x0000000181090E20-0x0000000181090E60
		public static Float2x Multiply(Float2x value1, Float2x value2); // 0x0000000181090DE0-0x0000000181090E20
		public static Float2x Divide(Float2x value1, Float2x value2); // 0x0000000181090B30-0x0000000181090B70
		public static Func<Float2x, Float2x, Float2x> GetAdditionDelegate(); // 0x0000000181090B70-0x0000000181090C00
		public static Func<Float2x, Float2x, Float2x> GetSubtractionDelegate(); // 0x0000000181090D20-0x0000000181090DE0
		public static Func<Float2x, Float2x, Float2x> GetMultiplicationDelegate(); // 0x0000000181090C90-0x0000000181090D20
		public static Func<Float2x, Float2x, Float2x> GetDivisionDelegate(); // 0x0000000181090C00-0x0000000181090C90
		public static implicit operator Float2x(Vector2 obj); // 0x0000000181090B00-0x0000000181090B30
		public static implicit operator Vector2(Float2x obj); // 0x0000000180AA8680-0x0000000180AA86C0
		public static Float2x operator +(Float2x value1, Float2x value2); // 0x0000000181090E70-0x0000000181090EB0
		public static Float2x operator -(Float2x value1, Float2x value2); // 0x0000000181090FF0-0x0000000181091030
		public static Float2x operator *(Float2x value1, Float2x value2); // 0x0000000181090F70-0x0000000181090FB0
		public static Float2x operator /(Float2x value1, Float2x value2); // 0x0000000181090EF0-0x0000000181090F30
		public static Float2x operator +(Float2x value1, float value2); // 0x0000000181090EB0-0x0000000181090EF0
		public static Float2x operator -(Float2x value1, float value2); // 0x0000000181091030-0x0000000181091070
		public static Float2x operator *(Float2x value1, float value2); // 0x0000000181090FB0-0x0000000181090FF0
		public static Float2x operator /(Float2x value1, float value2); // 0x0000000181090F30-0x0000000181090F70
	}
}
