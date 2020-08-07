/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: DemiLib.dll - Assembly: DemiLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5861-5870

namespace DG.DemiLib
{
	[Serializable]
	public struct DeSkinColor // TypeDefIndex: 5866
	{
		// Fields
		public Color free; // 0x00
		public Color pro; // 0x10
	
		// Constructors
		public DeSkinColor(Color free, Color pro); // 0x00000001800DF9D0-0x00000001800DF9E0
		public DeSkinColor(float freeGradation, float proGradation); // 0x0000000180145970-0x00000001801459C0
		public DeSkinColor(Color color); // 0x0000000180145960-0x0000000180145970
	
		// Methods
		public static implicit operator DeSkinColor(Color v); // 0x00000001820E24D0-0x00000001820E24E0
		public override string ToString(); // 0x00000001801458E0-0x0000000180145960
	}
}
