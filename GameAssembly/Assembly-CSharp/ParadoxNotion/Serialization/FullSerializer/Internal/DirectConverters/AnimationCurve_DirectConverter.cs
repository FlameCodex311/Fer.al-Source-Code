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
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve> // TypeDefIndex: 15335
	{
		// Constructors
		public AnimationCurve_DirectConverter(); // 0x000000018137AF80-0x000000018137AFC0
	
		// Methods
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized); // 0x000000018137ADA0-0x000000018137AF80
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model); // 0x000000018137AB40-0x000000018137ADA0
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018137AAF0-0x000000018137AB40
	}
}
