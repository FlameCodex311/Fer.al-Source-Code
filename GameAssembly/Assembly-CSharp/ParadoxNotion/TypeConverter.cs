/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion
{
	public static class TypeConverter // TypeDefIndex: 14688
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static CustomConverter customConverter; // 0x00
	
		// Events
		public static event CustomConverter customConverter {
			add; // 0x00000001811791C0-0x0000000181179270
			remove; // 0x0000000181179270-0x0000000181179320
		}
	
		// Nested types
		public delegate Func<object, object> CustomConverter(Type fromType, Type toType); // TypeDefIndex: 14689; 0x0000000181166F30-0x00000001811673E0
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 14690
		{
			// Fields
			public Type toType; // 0x10
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <Get>b__2(object value); // 0x000000018117B950-0x000000018117BA30
			internal object <Get>b__4(object value); // 0x000000018117BA30-0x000000018117BB00
			internal object <Get>b__6(object value); // 0x000000018117BB00-0x000000018117BC70
			internal object <Get>b__7(object value); // 0x000000018117BC70-0x000000018117BD40
			internal object <Get>b__8(object value); // 0x000000018117BD40-0x000000018117BEB0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14691
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<object, object> <>9__4_0; // 0x08
			public static Func<object, object> <>9__4_1; // 0x10
			public static Func<object, object> <>9__4_3; // 0x18
			public static Func<object, object> <>9__4_5; // 0x20
			public static Func<object, object> <>9__4_9; // 0x28
			public static Func<object, object> <>9__4_10; // 0x30
			public static Func<object, object> <>9__4_11; // 0x38
			public static Func<object, object> <>9__4_12; // 0x40
			public static Func<object, object> <>9__4_13; // 0x48
			public static Func<object, object> <>9__4_14; // 0x50
			public static Func<object, object> <>9__4_15; // 0x58
			public static Func<object, object> <>9__4_16; // 0x60
	
			// Constructors
			static <>c(); // 0x000000018117C120-0x000000018117C180
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <Get>b__4_0(object value); // 0x00000001804DE840-0x00000001804DE850
			internal object <Get>b__4_1(object value); // 0x000000018117B020-0x000000018117B070
			internal object <Get>b__4_3(object value); // 0x000000018117B070-0x000000018117B0C0
			internal object <Get>b__4_5(object value); // 0x000000018117B0C0-0x000000018117B210
			internal object <Get>b__4_9(object value); // 0x000000018117B210-0x000000018117B330
			internal object <Get>b__4_10(object value); // 0x000000018117A900-0x000000018117AAB0
			internal object <Get>b__4_11(object value); // 0x000000018117AAB0-0x000000018117ABC0
			internal object <Get>b__4_12(object value); // 0x000000018117ABC0-0x000000018117AD60
			internal object <Get>b__4_13(object value); // 0x000000018117AD60-0x000000018117AE00
			internal object <Get>b__4_14(object value); // 0x000000018117AE00-0x000000018117AEC0
			internal object <Get>b__4_15(object value); // 0x000000018117AEC0-0x000000018117AF70
			internal object <Get>b__4_16(object value); // 0x000000018117AF70-0x000000018117B020
		}
	
		// Methods
		public static Func<object, object> Get(Type fromType, Type toType); // 0x0000000181177ED0-0x00000001811791C0
		public static bool CanConvert(Type fromType, Type toType); // 0x0000000181177EB0-0x0000000181177ED0
	}
}
