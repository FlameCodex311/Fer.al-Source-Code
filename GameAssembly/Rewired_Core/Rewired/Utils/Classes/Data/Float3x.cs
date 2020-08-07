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
	public struct Float3x : IEquatable<Rewired.Utils.Classes.Data.Float3x> // TypeDefIndex: 7004
	{
		// Fields
		public const int Length = 3; // Metadata: 0x007666F2
		public float a; // 0x00
		public float b; // 0x04
		public float c; // 0x08
		private static Func<Float3x, Float3x, Float3x> _additionDelegate; // 0x00
		private static Func<Float3x, Float3x, Float3x> _subtractionDelegate; // 0x08
		private static Func<Float3x, Float3x, Float3x> _multiplicationDelegate; // 0x10
		private static Func<Float3x, Float3x, Float3x> _divisionDelegate; // 0x18
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x00000001800B4E60-0x00000001800B4F00 0x00000001800B4F00-0x00000001800B4FE0
		public static Float3x Zero { get; } // 0x00000001810916D0-0x00000001810916E0 
	
		// Constructors
		public Float3x(float x, float y, float z); // 0x00000001800A1C40-0x00000001800A1C90
	
		// Methods
		public Float3x Clone(); // 0x00000001800B4CA0-0x00000001800B4CC0
		public static Float3x Clone(Float3x obj); // 0x00000001810910D0-0x0000000181091100
		public override bool Equals(object obj); // 0x00000001800B4CC0-0x00000001800B4DA0
		public override int GetHashCode(); // 0x00000001800B4DF0-0x00000001800B4E50
		public bool Equals(Float3x other); // 0x00000001800B4DA0-0x00000001800B4DF0
		public override string ToString(); // 0x00000001800B4E50-0x00000001800B4E60
		public static Float3x Add(Float3x value1, Float3x value2); // 0x0000000181091070-0x00000001810910D0
		public static Float3x Subtract(Float3x value1, Float3x value2); // 0x0000000181091400-0x00000001810916D0
		public static Float3x Multiply(Float3x value1, Float3x value2); // 0x00000001810913A0-0x0000000181091400
		public static Float3x Divide(Float3x value1, Float3x value2); // 0x0000000181091100-0x0000000181091160
		public static Func<Float3x, Float3x, Float3x> GetAdditionDelegate(); // 0x0000000181091160-0x00000001810911F0
		public static Func<Float3x, Float3x, Float3x> GetSubtractionDelegate(); // 0x0000000181091310-0x00000001810913A0
		public static Func<Float3x, Float3x, Float3x> GetMultiplicationDelegate(); // 0x0000000181091280-0x0000000181091310
		public static Func<Float3x, Float3x, Float3x> GetDivisionDelegate(); // 0x00000001810911F0-0x0000000181091280
		public static implicit operator Float3x(Vector3 obj); // 0x00000001810917D0-0x00000001810917F0
		public static implicit operator Vector3(Float3x obj); // 0x00000001810917F0-0x0000000181091830
		public static Float3x operator +(Float3x value1, Float3x value2); // 0x00000001810916E0-0x0000000181091720
		public static Float3x operator -(Float3x value1, Float3x value2); // 0x00000001810918E0-0x0000000181091920
		public static Float3x operator *(Float3x value1, Float3x value2); // 0x0000000181091830-0x0000000181091870
		public static Float3x operator /(Float3x value1, Float3x value2); // 0x0000000181091790-0x00000001810917D0
		public static Float3x operator +(Float3x value1, float value2); // 0x0000000181091720-0x0000000181091750
		public static Float3x operator -(Float3x value1, float value2); // 0x00000001810918A0-0x00000001810918E0
		public static Float3x operator *(Float3x value1, float value2); // 0x0000000181091870-0x00000001810918A0
		public static Float3x operator /(Float3x value1, float value2); // 0x0000000181091750-0x0000000181091790
	}
}
