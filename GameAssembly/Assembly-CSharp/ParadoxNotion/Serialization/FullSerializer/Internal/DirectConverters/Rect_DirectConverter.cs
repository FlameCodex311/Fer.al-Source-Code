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
	public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 15943
	{
		// Constructors
		public Rect_DirectConverter(); // 0x00000001806D0670-0x00000001806D06B0
	
		// Methods
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized); // 0x00000001806D0440-0x00000001806D0670
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model); // 0x00000001806D01B0-0x00000001806D0440
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806D0170-0x00000001806D01B0
	}
}
