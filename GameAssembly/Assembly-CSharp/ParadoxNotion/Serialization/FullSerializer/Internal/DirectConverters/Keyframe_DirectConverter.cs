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
	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 15340
	{
		// Constructors
		public Keyframe_DirectConverter(); // 0x000000018137DD60-0x000000018137DDA0
	
		// Methods
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized); // 0x000000018137DAE0-0x000000018137DD60
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model); // 0x000000018137D7D0-0x000000018137DAE0
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018137D770-0x000000018137D7D0
	}
}
