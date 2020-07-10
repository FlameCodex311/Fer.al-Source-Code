/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	internal static class UnityEqualityComparer // TypeDefIndex: 8710
	{
		// Fields
		public static readonly IEqualityComparer<Vector2> Vector2; // 0x00
		public static readonly IEqualityComparer<Vector3> Vector3; // 0x08
		public static readonly IEqualityComparer<Vector4> Vector4; // 0x10
		public static readonly IEqualityComparer<Color> Color; // 0x18
		public static readonly IEqualityComparer<Color32> Color32; // 0x20
		public static readonly IEqualityComparer<Rect> Rect; // 0x28
		public static readonly IEqualityComparer<Bounds> Bounds; // 0x30
		public static readonly IEqualityComparer<Quaternion> Quaternion; // 0x38
		private static readonly RuntimeTypeHandle vector2Type; // 0x40
		private static readonly RuntimeTypeHandle vector3Type; // 0x48
		private static readonly RuntimeTypeHandle vector4Type; // 0x50
		private static readonly RuntimeTypeHandle colorType; // 0x58
		private static readonly RuntimeTypeHandle color32Type; // 0x60
		private static readonly RuntimeTypeHandle rectType; // 0x68
		private static readonly RuntimeTypeHandle boundsType; // 0x70
		private static readonly RuntimeTypeHandle quaternionType; // 0x78
		public static readonly IEqualityComparer<Vector2Int> Vector2Int; // 0x80
		public static readonly IEqualityComparer<Vector3Int> Vector3Int; // 0x88
		public static readonly IEqualityComparer<RangeInt> RangeInt; // 0x90
		public static readonly IEqualityComparer<RectInt> RectInt; // 0x98
		public static readonly IEqualityComparer<BoundsInt> BoundsInt; // 0xA0
		private static readonly RuntimeTypeHandle vector2IntType; // 0xA8
		private static readonly RuntimeTypeHandle vector3IntType; // 0xB0
		private static readonly RuntimeTypeHandle rangeIntType; // 0xB8
		private static readonly RuntimeTypeHandle rectIntType; // 0xC0
		private static readonly RuntimeTypeHandle boundsIntType; // 0xC8
	
		// Nested types
		private static class Cache<T> // TypeDefIndex: 8711
		{
			// Fields
			public static readonly IEqualityComparer<T> Comparer;
	
			// Constructors
			static Cache();
		}
	
		private sealed class Vector2EqualityComparer : IEqualityComparer<Vector2> // TypeDefIndex: 8712
		{
			// Constructors
			public Vector2EqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Vector2 self, Vector2 vector); // 0x0000000181674030-0x0000000181674080
			public int GetHashCode(Vector2 obj); // 0x0000000181674080-0x00000001816740B0
		}
	
		private sealed class Vector3EqualityComparer : IEqualityComparer<Vector3> // TypeDefIndex: 8713
		{
			// Constructors
			public Vector3EqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Vector3 self, Vector3 vector); // 0x0000000181674190-0x0000000181674210
			public int GetHashCode(Vector3 obj); // 0x0000000181674210-0x0000000181674270
		}
	
		private sealed class Vector4EqualityComparer : IEqualityComparer<Vector4> // TypeDefIndex: 8714
		{
			// Constructors
			public Vector4EqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Vector4 self, Vector4 vector); // 0x00000001816696E0-0x0000000181669760
			public int GetHashCode(Vector4 obj); // 0x0000000181669760-0x00000001816697D0
		}
	
		private sealed class ColorEqualityComparer : IEqualityComparer<Color> // TypeDefIndex: 8715
		{
			// Constructors
			public ColorEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Color self, Color other); // 0x00000001816696E0-0x0000000181669760
			public int GetHashCode(Color obj); // 0x0000000181669760-0x00000001816697D0
		}
	
		private sealed class RectEqualityComparer : IEqualityComparer<Rect> // TypeDefIndex: 8716
		{
			// Constructors
			public RectEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Rect self, Rect other); // 0x000000018166E480-0x000000018166E570
			public int GetHashCode(Rect obj); // 0x000000018166E570-0x000000018166E630
		}
	
		private sealed class BoundsEqualityComparer : IEqualityComparer<Bounds> // TypeDefIndex: 8717
		{
			// Constructors
			public BoundsEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Bounds self, Bounds vector); // 0x0000000181668240-0x0000000181668320
			public int GetHashCode(Bounds obj); // 0x0000000181668320-0x00000001816683B0
		}
	
		private sealed class QuaternionEqualityComparer : IEqualityComparer<Quaternion> // TypeDefIndex: 8718
		{
			// Constructors
			public QuaternionEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Quaternion self, Quaternion vector); // 0x00000001816696E0-0x0000000181669760
			public int GetHashCode(Quaternion obj); // 0x0000000181669760-0x00000001816697D0
		}
	
		private sealed class Color32EqualityComparer : IEqualityComparer<Color32> // TypeDefIndex: 8719
		{
			// Constructors
			public Color32EqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Color32 self, Color32 vector); // 0x0000000181669600-0x0000000181669670
			public int GetHashCode(Color32 obj); // 0x0000000181669670-0x00000001816696E0
		}
	
		private sealed class Vector2IntEqualityComparer : IEqualityComparer<Vector2Int> // TypeDefIndex: 8720
		{
			// Constructors
			public Vector2IntEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(Vector2Int self, Vector2Int vector); // 0x00000001816740B0-0x0000000181674130
			public int GetHashCode(Vector2Int obj); // 0x0000000181674130-0x0000000181674190
		}
	
		private sealed class Vector3IntEqualityComparer : IEqualityComparer<Vector3Int> // TypeDefIndex: 8721
		{
			// Fields
			public static readonly Vector3IntEqualityComparer Default; // 0x00
	
			// Constructors
			public Vector3IntEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
			static Vector3IntEqualityComparer(); // 0x00000001816743B0-0x0000000181674410
	
			// Methods
			public bool Equals(Vector3Int self, Vector3Int vector); // 0x0000000181674270-0x0000000181674320
			public int GetHashCode(Vector3Int obj); // 0x0000000181674320-0x00000001816743B0
		}
	
		private sealed class RangeIntEqualityComparer : IEqualityComparer<RangeInt> // TypeDefIndex: 8722
		{
			// Constructors
			public RangeIntEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(RangeInt self, RangeInt vector); // 0x000000018166E410-0x000000018166E450
			public int GetHashCode(RangeInt obj); // 0x000000018166E450-0x000000018166E480
		}
	
		private sealed class RectIntEqualityComparer : IEqualityComparer<RectInt> // TypeDefIndex: 8723
		{
			// Constructors
			public RectIntEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(RectInt self, RectInt other); // 0x000000018166E630-0x000000018166E710
			public int GetHashCode(RectInt obj); // 0x000000018166E710-0x000000018166E7D0
		}
	
		private sealed class BoundsIntEqualityComparer : IEqualityComparer<BoundsInt> // TypeDefIndex: 8724
		{
			// Constructors
			public BoundsIntEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(BoundsInt self, BoundsInt vector); // 0x00000001816683B0-0x0000000181668640
			public int GetHashCode(BoundsInt obj); // 0x0000000181668640-0x0000000181668800
		}
	
		// Constructors
		static UnityEqualityComparer(); // 0x0000000181673A20-0x0000000181674030
	
		// Methods
		public static IEqualityComparer<T> GetDefault<T>();
		private static object GetDefaultHelper(Type type); // 0x0000000181673310-0x0000000181673A20
	}
}
