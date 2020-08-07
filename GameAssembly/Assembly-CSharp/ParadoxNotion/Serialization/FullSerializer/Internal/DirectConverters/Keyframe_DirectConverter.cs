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
	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 15940
	{
		// Constructors
		public Keyframe_DirectConverter(); // 0x00000001806CC8C0-0x00000001806CC900
	
		// Methods
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized); // 0x00000001806CC640-0x00000001806CC8C0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model); // 0x00000001806CC330-0x00000001806CC640
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806CC2D0-0x00000001806CC330
	}
}
