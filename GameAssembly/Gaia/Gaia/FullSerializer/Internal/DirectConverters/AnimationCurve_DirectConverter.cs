/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal.DirectConverters
{
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve> // TypeDefIndex: 9168
	{
		// Constructors
		public AnimationCurve_DirectConverter(); // 0x00000001818E2650-0x00000001818E2690
	
		// Methods
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized); // 0x00000001818E2360-0x00000001818E2650
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model); // 0x00000001818E1DE0-0x00000001818E2360
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818E1D90-0x00000001818E1DE0
	}
}
