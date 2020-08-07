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
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve> // TypeDefIndex: 15935
	{
		// Constructors
		public AnimationCurve_DirectConverter(); // 0x00000001806C3F30-0x00000001806C3F70
	
		// Methods
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized); // 0x00000001806C3D50-0x00000001806C3F30
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model); // 0x00000001806C3AF0-0x00000001806C3D50
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806C3AA0-0x00000001806C3AF0
	}
}
