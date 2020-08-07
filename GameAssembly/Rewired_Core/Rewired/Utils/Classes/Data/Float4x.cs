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
	public struct Float4x : IEquatable<Rewired.Utils.Classes.Data.Float4x> // TypeDefIndex: 7005
	{
		// Fields
		public const int Length = 4; // Metadata: 0x007666F6
		public float a; // 0x00
		public float b; // 0x04
		public float c; // 0x08
		public float d; // 0x0C
		private static Func<Float4x, Float4x, Float4x> _additionDelegate; // 0x00
		private static Func<Float4x, Float4x, Float4x> _subtractionDelegate; // 0x08
		private static Func<Float4x, Float4x, Float4x> _multiplicationDelegate; // 0x10
		private static Func<Float4x, Float4x, Float4x> _divisionDelegate; // 0x18
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x00000001800B51D0-0x00000001800B5290 0x00000001800B5290-0x00000001800B53B0
		public static Float4x Zero { get; } // 0x0000000180A67270-0x0000000180A67280 
	
		// Constructors
		public Float4x(float a, float b, float c, float d); // 0x0000000180007650-0x0000000180007670
	
		// Methods
		public Float4x Clone(); // 0x00000001800B4FE0-0x00000001800B5010
		public static Float4x Clone(Float4x obj); // 0x0000000181091990-0x00000001810919B0
		public override bool Equals(object obj); // 0x00000001800B5010-0x00000001800B5100
		public override int GetHashCode(); // 0x00000001800B5150-0x00000001800B51C0
		public bool Equals(Float4x other); // 0x00000001800B5100-0x00000001800B5150
		public override string ToString(); // 0x00000001800B51C0-0x00000001800B51D0
		public static Float4x Add(Float4x value1, Float4x value2); // 0x0000000181091920-0x0000000181091990
		public static Float4x Subtract(Float4x value1, Float4x value2); // 0x0000000181091D00-0x0000000181092080
		public static Float4x Multiply(Float4x value1, Float4x value2); // 0x0000000181091C90-0x0000000181091D00
		public static Float4x Divide(Float4x value1, Float4x value2); // 0x00000001810919B0-0x0000000181091A20
		public static Func<Float4x, Float4x, Float4x> GetAdditionDelegate(); // 0x0000000181091A20-0x0000000181091AB0
		public static Func<Float4x, Float4x, Float4x> GetSubtractionDelegate(); // 0x0000000181091C00-0x0000000181091C90
		public static Func<Float4x, Float4x, Float4x> GetMultiplicationDelegate(); // 0x0000000181091B70-0x0000000181091C00
		public static Func<Float4x, Float4x, Float4x> GetDivisionDelegate(); // 0x0000000181091AB0-0x0000000181091B70
		public static implicit operator Float4x(Vector4 obj); // 0x00000001810920E0-0x0000000181092100
		public static implicit operator Vector4(Float4x obj); // 0x0000000181092100-0x0000000181092140
		public static Float4x operator +(Float4x value1, Float4x value2); // 0x000000018057D230-0x000000018057D250
		public static Float4x operator -(Float4x value1, Float4x value2); // 0x00000001810921A0-0x00000001810921C0
		public static Float4x operator *(Float4x value1, Float4x value2); // 0x0000000181092140-0x0000000181092160
		public static Float4x operator /(Float4x value1, Float4x value2); // 0x00000001810920C0-0x00000001810920E0
		public static Float4x operator +(Float4x value1, float value2); // 0x0000000181092080-0x00000001810920A0
		public static Float4x operator -(Float4x value1, float value2); // 0x0000000181092180-0x00000001810921A0
		public static Float4x operator *(Float4x value1, float value2); // 0x0000000181092160-0x0000000181092180
		public static Float4x operator /(Float4x value1, float value2); // 0x00000001810920A0-0x00000001810920C0
	}
}
