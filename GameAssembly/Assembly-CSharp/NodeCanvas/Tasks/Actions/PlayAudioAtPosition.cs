/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180226880-0x00000001802268B0
	public class PlayAudioAtPosition : ActionTask<Transform> // TypeDefIndex: 15312
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<AudioClip> audioClip; // 0x68
		[SliderField] // 0x0000000180246120-0x0000000180246140
		public float volume; // 0x70
		public bool waitActionFinish; // 0x74
	
		// Properties
		protected override string info { get; } // 0x000000018079E140-0x000000018079E1A0 
	
		// Constructors
		public PlayAudioAtPosition(); // 0x000000018079E100-0x000000018079E140
	
		// Methods
		protected override void OnExecute(); // 0x000000018079DFB0-0x000000018079E080
		protected override void OnUpdate(); // 0x000000018079E080-0x000000018079E100
	}
}
