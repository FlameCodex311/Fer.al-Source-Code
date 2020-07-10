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
	public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 15342
	{
		// Constructors
		public Rect_DirectConverter(); // 0x0000000181383600-0x0000000181383640
	
		// Methods
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized); // 0x00000001813833D0-0x0000000181383600
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model); // 0x0000000181383140-0x00000001813833D0
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181383100-0x0000000181383140
	}
}
