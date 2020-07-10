/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle> // TypeDefIndex: 15338
	{
		// Constructors
		public GUIStyle_DirectConverter(); // 0x000000018137D330-0x000000018137D370
	
		// Methods
		protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized); // 0x000000018137C8E0-0x000000018137D330
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model); // 0x000000018137B840-0x000000018137C8E0
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018137B7F0-0x000000018137B840
	}
}
