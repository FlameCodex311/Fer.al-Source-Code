/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public static class TypeConverter // TypeDefIndex: 15835
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static CustomConverter customConverter; // 0x00
	
		// Events
		public static event CustomConverter customConverter {
			add; // 0x00000001804EA5F0-0x00000001804EA6A0
			remove; // 0x00000001804EA6A0-0x00000001804EA750
		}
	
		// Nested types
		public delegate Func<object, object> CustomConverter(Type fromType, Type toType); // TypeDefIndex: 15836; 0x00000001804D58A0-0x00000001804D5DB0
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 15837
		{
			// Fields
			public Type toType; // 0x10
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <Get>b__2(object value); // 0x00000001804ECDF0-0x00000001804ECED0
			internal object <Get>b__4(object value); // 0x00000001804ECED0-0x00000001804ECFA0
			internal object <Get>b__6(object value); // 0x00000001804ECFA0-0x00000001804ED100
			internal object <Get>b__7(object value); // 0x00000001804ED100-0x00000001804ED1D0
			internal object <Get>b__8(object value); // 0x00000001804ED1D0-0x00000001804ED330
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15838
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
			static <>c(); // 0x00000001804ED350-0x00000001804ED3B0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <Get>b__4_0(object value); // 0x00000001804EC160-0x00000001804EC170
			internal object <Get>b__4_1(object value); // 0x00000001804EC890-0x00000001804EC8E0
			internal object <Get>b__4_3(object value); // 0x00000001804EC8E0-0x00000001804EC930
			internal object <Get>b__4_5(object value); // 0x00000001804EC930-0x00000001804ECA80
			internal object <Get>b__4_9(object value); // 0x00000001804ECA80-0x00000001804ECB90
			internal object <Get>b__4_10(object value); // 0x00000001804EC170-0x00000001804EC320
			internal object <Get>b__4_11(object value); // 0x00000001804EC320-0x00000001804EC430
			internal object <Get>b__4_12(object value); // 0x00000001804EC430-0x00000001804EC5D0
			internal object <Get>b__4_13(object value); // 0x00000001804EC5D0-0x00000001804EC670
			internal object <Get>b__4_14(object value); // 0x00000001804EC670-0x00000001804EC730
			internal object <Get>b__4_15(object value); // 0x00000001804EC730-0x00000001804EC7E0
			internal object <Get>b__4_16(object value); // 0x00000001804EC7E0-0x00000001804EC890
		}
	
		// Methods
		public static Func<object, object> Get(Type fromType, Type toType); // 0x00000001804E9300-0x00000001804EA5F0
		public static bool CanConvert(Type fromType, Type toType); // 0x00000001804E92E0-0x00000001804E9300
	}
}
