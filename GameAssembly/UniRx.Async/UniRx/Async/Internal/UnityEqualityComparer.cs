/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal static class UnityEqualityComparer // TypeDefIndex: 8876
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
		private static class Cache<T> // TypeDefIndex: 8877
		{
			// Fields
			public static readonly IEqualityComparer<T> Comparer;
	
			// Constructors
			static Cache();
		}
	
		private sealed class Vector2EqualityComparer : IEqualityComparer<Vector2> // TypeDefIndex: 8878
		{
			// Constructors
			public Vector2EqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Vector2 self, Vector2 vector); // 0x0000000180E1F990-0x0000000180E1F9E0
			public int GetHashCode(Vector2 obj); // 0x0000000180E1F9E0-0x0000000180E1FA10
		}
	
		private sealed class Vector3EqualityComparer : IEqualityComparer<Vector3> // TypeDefIndex: 8879
		{
			// Constructors
			public Vector3EqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Vector3 self, Vector3 vector); // 0x0000000180E1FAF0-0x0000000180E1FB70
			public int GetHashCode(Vector3 obj); // 0x0000000180E1FB70-0x0000000180E1FBD0
		}
	
		private sealed class Vector4EqualityComparer : IEqualityComparer<Vector4> // TypeDefIndex: 8880
		{
			// Constructors
			public Vector4EqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Vector4 self, Vector4 vector); // 0x0000000180E164B0-0x0000000180E16530
			public int GetHashCode(Vector4 obj); // 0x0000000180E16530-0x0000000180E165A0
		}
	
		private sealed class ColorEqualityComparer : IEqualityComparer<Color> // TypeDefIndex: 8881
		{
			// Constructors
			public ColorEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Color self, Color other); // 0x0000000180E164B0-0x0000000180E16530
			public int GetHashCode(Color obj); // 0x0000000180E16530-0x0000000180E165A0
		}
	
		private sealed class RectEqualityComparer : IEqualityComparer<Rect> // TypeDefIndex: 8882
		{
			// Constructors
			public RectEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Rect self, Rect other); // 0x0000000180E1AF10-0x0000000180E1B000
			public int GetHashCode(Rect obj); // 0x0000000180E1B000-0x0000000180E1B0C0
		}
	
		private sealed class BoundsEqualityComparer : IEqualityComparer<Bounds> // TypeDefIndex: 8883
		{
			// Constructors
			public BoundsEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Bounds self, Bounds vector); // 0x0000000180E152B0-0x0000000180E15390
			public int GetHashCode(Bounds obj); // 0x0000000180E15390-0x0000000180E15420
		}
	
		private sealed class QuaternionEqualityComparer : IEqualityComparer<Quaternion> // TypeDefIndex: 8884
		{
			// Constructors
			public QuaternionEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Quaternion self, Quaternion vector); // 0x0000000180E164B0-0x0000000180E16530
			public int GetHashCode(Quaternion obj); // 0x0000000180E16530-0x0000000180E165A0
		}
	
		private sealed class Color32EqualityComparer : IEqualityComparer<Color32> // TypeDefIndex: 8885
		{
			// Constructors
			public Color32EqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Color32 self, Color32 vector); // 0x0000000180E163D0-0x0000000180E16440
			public int GetHashCode(Color32 obj); // 0x0000000180E16440-0x0000000180E164B0
		}
	
		private sealed class Vector2IntEqualityComparer : IEqualityComparer<Vector2Int> // TypeDefIndex: 8886
		{
			// Constructors
			public Vector2IntEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(Vector2Int self, Vector2Int vector); // 0x0000000180E1FA10-0x0000000180E1FA90
			public int GetHashCode(Vector2Int obj); // 0x0000000180E1FA90-0x0000000180E1FAF0
		}
	
		private sealed class Vector3IntEqualityComparer : IEqualityComparer<Vector3Int> // TypeDefIndex: 8887
		{
			// Fields
			public static readonly Vector3IntEqualityComparer Default; // 0x00
	
			// Constructors
			public Vector3IntEqualityComparer(); // 0x0000000180373240-0x0000000180373250
			static Vector3IntEqualityComparer(); // 0x0000000180E1FD10-0x0000000180E1FD70
	
			// Methods
			public bool Equals(Vector3Int self, Vector3Int vector); // 0x0000000180E1FBD0-0x0000000180E1FC80
			public int GetHashCode(Vector3Int obj); // 0x0000000180E1FC80-0x0000000180E1FD10
		}
	
		private sealed class RangeIntEqualityComparer : IEqualityComparer<RangeInt> // TypeDefIndex: 8888
		{
			// Constructors
			public RangeIntEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(RangeInt self, RangeInt vector); // 0x0000000180E1AEA0-0x0000000180E1AEE0
			public int GetHashCode(RangeInt obj); // 0x0000000180E1AEE0-0x0000000180E1AF10
		}
	
		private sealed class RectIntEqualityComparer : IEqualityComparer<RectInt> // TypeDefIndex: 8889
		{
			// Constructors
			public RectIntEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(RectInt self, RectInt other); // 0x0000000180E1B0C0-0x0000000180E1B1A0
			public int GetHashCode(RectInt obj); // 0x0000000180E1B1A0-0x0000000180E1B260
		}
	
		private sealed class BoundsIntEqualityComparer : IEqualityComparer<BoundsInt> // TypeDefIndex: 8890
		{
			// Constructors
			public BoundsIntEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(BoundsInt self, BoundsInt vector); // 0x0000000180E15420-0x0000000180E156A0
			public int GetHashCode(BoundsInt obj); // 0x0000000180E156A0-0x0000000180E15860
		}
	
		// Constructors
		static UnityEqualityComparer(); // 0x0000000180E1F390-0x0000000180E1F990
	
		// Methods
		public static IEqualityComparer<T> GetDefault<T>();
		private static object GetDefaultHelper(Type type); // 0x0000000180E1EC80-0x0000000180E1F390
	}
}
