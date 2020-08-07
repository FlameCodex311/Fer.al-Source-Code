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
	[Category] // 0x000000018028ADE0-0x000000018028AE10
	public class PlayFeralAudioNode : ActionTask<GameObject> // TypeDefIndex: 15526
	{
		// Fields
		public BBParameter<AudioScriptableObject> _audioScriptableObject; // 0x68
		public BBParameter<FeralAudioEmitter> _audioEmitter; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018079E460-0x000000018079E5B0 
	
		// Constructors
		public PlayFeralAudioNode(); // 0x000000018079E420-0x000000018079E460
	
		// Methods
		protected override void OnExecute(); // 0x000000018079E360-0x000000018079E420
	}
}
