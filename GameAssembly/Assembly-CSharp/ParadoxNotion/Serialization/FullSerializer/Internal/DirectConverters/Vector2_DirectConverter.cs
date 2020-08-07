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
	public class Vector2_DirectConverter : fsDirectConverter<Vector2> // TypeDefIndex: 15945
	{
		// Constructors
		public Vector2_DirectConverter(); // 0x00000001806DA240-0x00000001806DA280
	
		// Methods
		protected override fsResult DoSerialize(Vector2 model, Dictionary<string, fsData> serialized); // 0x00000001806DA150-0x00000001806DA240
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Vector2 model); // 0x00000001806DA030-0x00000001806DA150
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806D9FF0-0x00000001806DA030
	}
}
