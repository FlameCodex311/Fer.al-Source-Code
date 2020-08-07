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
	public class Vector3Int_DirectConverter : fsDirectConverter<Vector3Int> // TypeDefIndex: 15946
	{
		// Constructors
		public Vector3Int_DirectConverter(); // 0x00000001806DA5B0-0x00000001806DA5F0
	
		// Methods
		protected override fsResult DoSerialize(Vector3Int model, Dictionary<string, fsData> serialized); // 0x00000001806DA470-0x00000001806DA5B0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector3Int model); // 0x00000001806DA2D0-0x00000001806DA470
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806DA280-0x00000001806DA2D0
	}
}
