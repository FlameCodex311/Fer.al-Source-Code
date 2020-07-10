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
	[Category] // 0x000000018011DD10-0x000000018011DD40
	public class StopFeralAudioNode : ActionTask<GameObject> // TypeDefIndex: 14421
	{
		// Fields
		public BBParameter<AudioScriptableObject> _audioScriptableObject; // 0x68
		public BBParameter<FeralAudioEmitter> _audioEmitter; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812650C0-0x0000000181265210 
	
		// Constructors
		public StopFeralAudioNode(); // 0x0000000181265080-0x00000001812650C0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181264FC0-0x0000000181265080
	}
}
