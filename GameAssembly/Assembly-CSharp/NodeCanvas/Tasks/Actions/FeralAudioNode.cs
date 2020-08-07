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
	[Category] // 0x000000018028AAB0-0x000000018028AAE0
	public class FeralAudioNode : ActionTask<GameObject> // TypeDefIndex: 15524
	{
		// Fields
		public EAudioAction audioAction; // 0x68
		public BBParameter<AudioScriptableObject> _audioScriptableObject; // 0x70
		public BBParameter<FeralAudioEmitter> _audioEmitter; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BAA8E0-0x0000000180BAAC10 
	
		// Nested types
		public enum EAudioAction // TypeDefIndex: 15525
		{
			Play = 0,
			Stop = 1
		}
	
		// Constructors
		public FeralAudioNode(); // 0x0000000180BAA8A0-0x0000000180BAA8E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAA5E0-0x0000000180BAA8A0
	}
}
