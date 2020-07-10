/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 73: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8910-8940

namespace AmplifyImpostors
{
	[CreateAssetMenu] // 0x0000000180170890-0x00000001801708D0
	public class AmplifyImpostorBakePreset : ScriptableObject // TypeDefIndex: 8927
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public Shader BakeShader; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public Shader RuntimeShader; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public PresetPipeline Pipeline; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public int AlphaIndex; // 0x2C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<TextureOutput> Output; // 0x30
	
		// Constructors
		public AmplifyImpostorBakePreset(); // 0x00000001822AD300-0x00000001822AD360
	}
}
