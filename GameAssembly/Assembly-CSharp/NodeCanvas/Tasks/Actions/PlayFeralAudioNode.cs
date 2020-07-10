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
	[Category] // 0x000000018011DB00-0x000000018011DB30
	public class PlayFeralAudioNode : ActionTask<GameObject> // TypeDefIndex: 14420
	{
		// Fields
		public BBParameter<AudioScriptableObject> _audioScriptableObject; // 0x68
		public BBParameter<FeralAudioEmitter> _audioEmitter; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001815591B0-0x0000000181559300 
	
		// Constructors
		public PlayFeralAudioNode(); // 0x0000000181559170-0x00000001815591B0
	
		// Methods
		protected override void OnExecute(); // 0x00000001815590B0-0x0000000181559170
	}
}
