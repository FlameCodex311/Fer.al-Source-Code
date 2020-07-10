/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer.Internal;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsMetaType // TypeDefIndex: 15318
	{
		// Fields
		private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes; // 0x00
		private ObjectGenerator generator; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <reflectedType>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private fsMetaProperty[] <Properties>k__BackingField; // 0x20
	
		// Properties
		public Type reflectedType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public fsMetaProperty[] Properties { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	
		// Nested types
		private delegate object ObjectGenerator(); // TypeDefIndex: 15319; 0x0000000180ABE4F0-0x0000000180ABE710
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 15320
		{
			// Fields
			public FieldInfo field; // 0x10
	
			// Constructors
			public <>c__DisplayClass14_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CollectProperties>b__0(Type t); // 0x000000018117B730-0x000000018117B7A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 15321
		{
			// Fields
			public FieldInfo field; // 0x10
	
			// Constructors
			public <>c__DisplayClass15_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CanSerializeField>b__0(Type t); // 0x000000018117B7A0-0x000000018117B810
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 15322
		{
			// Fields
			public Type reflectedType; // 0x10
	
			// Constructors
			public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <GetGenerator>b__0(); // 0x000000018117B810-0x000000018117B890
			internal object <GetGenerator>b__1(); // 0x000000018117B890-0x000000018117B8A0
			internal object <GetGenerator>b__2(); // 0x000000018117B8A0-0x000000018117B8E0
			internal object <GetGenerator>b__4(); // 0x000000018117B8E0-0x000000018117B940
			internal object <GetGenerator>b__5(); // 0x000000018117B940-0x000000018117B950
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15323
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static ObjectGenerator <>9__16_3; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018117C1E0-0x000000018117C240
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <GetGenerator>b__16_3(); // 0x000000018117A8C0-0x000000018117A900
		}
	
		// Constructors
		private fsMetaType(fsConfig config, Type reflectedType); // 0x000000018117EAA0-0x000000018117EDB0
		static fsMetaType(); // 0x000000018117EA40-0x000000018117EAA0
	
		// Methods
		public static fsMetaType Get(fsConfig config, Type type); // 0x000000018117E7E0-0x000000018117E990
		public static void ClearCache(); // 0x000000018117DFB0-0x000000018117E040
		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType); // 0x000000018117E040-0x000000018117E2A0
		private static bool CanSerializeField(fsConfig config, FieldInfo field); // 0x000000018117DD90-0x000000018117DFB0
		private static ObjectGenerator GetGenerator(Type reflectedType); // 0x000000018117E470-0x000000018117E7E0
		private static bool HasDefaultConstructor(Type reflectedType); // 0x000000018117E990-0x000000018117EA40
		public object CreateInstance(); // 0x000000018117E2A0-0x000000018117E470
	}
}
