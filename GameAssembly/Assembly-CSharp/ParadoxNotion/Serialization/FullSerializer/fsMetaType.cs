/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsMetaType // TypeDefIndex: 15918
	{
		// Fields
		private static Dictionary<Type, fsMetaType> _metaTypes; // 0x00
		private static Dictionary<Type, object> _defaultInstances; // 0x08
		private ObjectGenerator generator; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <reflectedType>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private fsMetaProperty[] <Properties>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <DeserializeOverwriteRequest>k__BackingField; // 0x28
	
		// Properties
		public Type reflectedType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public fsMetaProperty[] Properties { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public bool DeserializeOverwriteRequest { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804D9980-0x00000001804D9990
	
		// Nested types
		private delegate object ObjectGenerator(); // TypeDefIndex: 15919; 0x0000000180971630-0x0000000180971850
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 15920
		{
			// Fields
			public Type reflectedType; // 0x10
	
			// Constructors
			public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <GetGenerator>b__0(); // 0x00000001811ABC30-0x00000001811ABCB0
			internal object <GetGenerator>b__1(); // 0x00000001811ABCB0-0x00000001811ABCC0
			internal object <GetGenerator>b__2(); // 0x00000001811ABCC0-0x00000001811ABD00
			internal object <GetGenerator>b__4(); // 0x00000001811ABD00-0x00000001811ABD60
			internal object <GetGenerator>b__5(); // 0x00000001811ABD60-0x00000001811ABDC0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15921
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static ObjectGenerator <>9__21_3; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001811ABF70-0x00000001811ABFD0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <GetGenerator>b__21_3(); // 0x00000001811ABB10-0x00000001811ABB50
		}
	
		// Constructors
		private fsMetaType(Type reflectedType); // 0x00000001811B6390-0x00000001811B6460
		static fsMetaType(); // 0x00000001811B6300-0x00000001811B6390
	
		// Methods
		public static fsMetaType Get(Type type); // 0x00000001811B6090-0x00000001811B6250
		public static void FlushMem(); // 0x00000001811B5AA0-0x00000001811B5B50
		private static void CollectProperties(List<fsMetaProperty> properties, Type reflectedType); // 0x00000001811B57F0-0x00000001811B5A10
		public static bool CanSerializeField(FieldInfo field); // 0x00000001811B54C0-0x00000001811B57F0
		private static ObjectGenerator GetGenerator(Type reflectedType); // 0x00000001811B5CE0-0x00000001811B6090
		private static bool HasDefaultConstructor(Type reflectedType); // 0x00000001811B6250-0x00000001811B6300
		public object GetDefaultInstance(); // 0x00000001811B5B50-0x00000001811B5CE0
		public object CreateInstance(); // 0x00000001811B5A10-0x00000001811B5AA0
	}
}
