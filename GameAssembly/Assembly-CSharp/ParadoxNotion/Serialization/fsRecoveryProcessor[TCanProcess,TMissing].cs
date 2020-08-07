/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization
{
	public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor // TypeDefIndex: 15884
		where TMissing : TCanProcess, IMissingRecoverable
	{
		// Fields
		private const string FIELD_NAME_TYPE = "_missingType"; // Metadata: 0x007BB62A
		private const string FIELD_NAME_STATE = "_recoveryState"; // Metadata: 0x007BB63A
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 15885
		{
			// Fields
			public Dictionary<string, fsData> json;
	
			// Constructors
			public <>c__DisplayClass3_0();
	
			// Methods
			internal bool <OnBeforeDeserialize>b__0(KeyValuePair<string, fsData> kvp);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15886
		{
			// Fields
			public static readonly <>c<TCanProcess, TMissing> <>9;
			public static Func<KeyValuePair<string, fsData>, string> <>9__3_1;
			public static Func<KeyValuePair<string, fsData>, fsData> <>9__3_2;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal string <OnBeforeDeserialize>b__3_1(KeyValuePair<string, fsData> c);
			internal fsData <OnBeforeDeserialize>b__3_2(KeyValuePair<string, fsData> c);
		}
	
		// Constructors
		public fsRecoveryProcessor();
	
		// Methods
		public override bool CanProcess(Type type);
		public override void OnBeforeDeserialize(Type storageType, ref fsData data);
	}
}
