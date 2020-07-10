/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Design
{
	[AttributeUsage] // 0x00000001800C1DA0-0x00000001800C1DC0
	public class IconAttribute : Attribute // TypeDefIndex: 15353
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly bool fixedColor; // 0x18
		public readonly string runtimeIconTypeCallback; // 0x20
		public readonly Type fromType; // 0x28
	
		// Constructors
		public IconAttribute(string iconName = "" /* Metadata: 0x00784803 */, bool fixedColor = false /* Metadata: 0x00784807 */, string runtimeIconTypeCallback = "" /* Metadata: 0x00784808 */); // 0x0000000180E8E4D0-0x0000000180E8E520
		public IconAttribute(Type fromType); // 0x0000000180E8E520-0x0000000180E8E550
	}
}
