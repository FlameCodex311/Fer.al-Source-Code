/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800E5E40-0x00000001800E5E70
	public class PlayAudioAtPosition : ActionTask<Transform> // TypeDefIndex: 14212
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<AudioClip> audioClip; // 0x68
		[SliderField] // 0x00000001800E2A20-0x00000001800E2A40
		public float volume; // 0x70
		public bool waitActionFinish; // 0x74
	
		// Properties
		protected override string info { get; } // 0x0000000181558E90-0x0000000181558EF0 
	
		// Constructors
		public PlayAudioAtPosition(); // 0x0000000181558E50-0x0000000181558E90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181558CF0-0x0000000181558DC0
		protected override void OnUpdate(); // 0x0000000181558DC0-0x0000000181558E50
	}
}
