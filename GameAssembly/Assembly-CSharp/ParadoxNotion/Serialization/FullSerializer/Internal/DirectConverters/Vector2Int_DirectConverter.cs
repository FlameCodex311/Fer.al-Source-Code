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
	public class Vector2Int_DirectConverter : fsDirectConverter<Vector2Int> // TypeDefIndex: 15944
	{
		// Constructors
		public Vector2Int_DirectConverter(); // 0x00000001806D9FB0-0x00000001806D9FF0
	
		// Methods
		protected override fsResult DoSerialize(Vector2Int model, Dictionary<string, fsData> serialized); // 0x00000001806D9EB0-0x00000001806D9FB0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2Int model); // 0x00000001806D9D70-0x00000001806D9EB0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806D9D30-0x00000001806D9D70
	}
}
