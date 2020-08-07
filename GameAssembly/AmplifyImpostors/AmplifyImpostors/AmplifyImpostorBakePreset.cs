/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 74: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9076-9106

namespace AmplifyImpostors
{
	[CreateAssetMenu] // 0x000000018020FEF0-0x000000018020FF30
	public class AmplifyImpostorBakePreset : ScriptableObject // TypeDefIndex: 9093
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Shader BakeShader; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Shader RuntimeShader; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public PresetPipeline Pipeline; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int AlphaIndex; // 0x2C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<TextureOutput> Output; // 0x30
	
		// Constructors
		public AmplifyImpostorBakePreset(); // 0x0000000182084D10-0x0000000182084D70
	}
}
