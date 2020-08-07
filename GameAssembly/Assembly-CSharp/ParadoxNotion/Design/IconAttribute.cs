/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Design
{
	[AttributeUsage] // 0x00000001801D0D90-0x00000001801D0DB0
	public class IconAttribute : Attribute // TypeDefIndex: 15958
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly bool fixedColor; // 0x18
		public readonly string runtimeIconTypeCallback; // 0x20
		public readonly Type fromType; // 0x28
	
		// Constructors
		public IconAttribute(string iconName = "" /* Metadata: 0x007BB719 */, bool fixedColor = false /* Metadata: 0x007BB71D */, string runtimeIconTypeCallback = "" /* Metadata: 0x007BB71E */); // 0x00000001806CC250-0x00000001806CC2A0
		public IconAttribute(Type fromType); // 0x00000001806CC2A0-0x00000001806CC2D0
	}
}
