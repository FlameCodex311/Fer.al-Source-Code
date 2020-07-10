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
	public class Gradient_DirectConverter : fsDirectConverter<Gradient> // TypeDefIndex: 15337
	{
		// Constructors
		public Gradient_DirectConverter(); // 0x000000018137D730-0x000000018137D770
	
		// Methods
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized); // 0x000000018137D5B0-0x000000018137D730
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model); // 0x000000018137D3C0-0x000000018137D5B0
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018137D370-0x000000018137D3C0
	}
}
