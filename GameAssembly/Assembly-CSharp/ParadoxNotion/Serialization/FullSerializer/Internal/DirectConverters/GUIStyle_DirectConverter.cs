/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle> // TypeDefIndex: 15938
	{
		// Constructors
		public GUIStyle_DirectConverter(); // 0x00000001806CBE10-0x00000001806CBE50
	
		// Methods
		protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized); // 0x00000001806CB3C0-0x00000001806CBE10
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model); // 0x00000001806CA320-0x00000001806CB3C0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806CA2D0-0x00000001806CA320
	}
}
