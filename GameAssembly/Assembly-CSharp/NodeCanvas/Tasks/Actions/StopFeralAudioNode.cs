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
	[Category] // 0x000000018028AF10-0x000000018028AF40
	public class StopFeralAudioNode : ActionTask<GameObject> // TypeDefIndex: 15527
	{
		// Fields
		public BBParameter<AudioScriptableObject> _audioScriptableObject; // 0x68
		public BBParameter<FeralAudioEmitter> _audioEmitter; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A9830-0x00000001807A9980 
	
		// Constructors
		public StopFeralAudioNode(); // 0x00000001807A97F0-0x00000001807A9830
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A9730-0x00000001807A97F0
	}
}
