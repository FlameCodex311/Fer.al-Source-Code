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
	[Category] // 0x000000018011DA20-0x000000018011DA50
	public class FeralAudioNode : ActionTask<GameObject> // TypeDefIndex: 14418
	{
		// Fields
		public EAudioAction audioAction; // 0x68
		public BBParameter<AudioScriptableObject> _audioScriptableObject; // 0x70
		public BBParameter<FeralAudioEmitter> _audioEmitter; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181544D10-0x0000000181545040 
	
		// Nested types
		public enum EAudioAction // TypeDefIndex: 14419
		{
			Play = 0,
			Stop = 1
		}
	
		// Constructors
		public FeralAudioNode(); // 0x0000000181544CD0-0x0000000181544D10
	
		// Methods
		protected override void OnExecute(); // 0x0000000181544A00-0x0000000181544CD0
	}
}
