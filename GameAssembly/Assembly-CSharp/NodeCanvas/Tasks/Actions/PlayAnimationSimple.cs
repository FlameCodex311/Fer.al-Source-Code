/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800E2640-0x00000001800E2670
	public class PlayAnimationSimple : ActionTask<Animation> // TypeDefIndex: 14202
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<AnimationClip> animationClip; // 0x68
		[SliderField] // 0x00000001800E2A20-0x00000001800E2A40
		public float crossFadeTime; // 0x70
		public WrapMode animationWrap; // 0x74
		public bool waitActionFinish; // 0x78
		private static Dictionary<Animation, AnimationClip> lastPlayedClips; // 0x00
	
		// Properties
		protected override string info { get; } // 0x0000000181558C90-0x0000000181558CF0 
	
		// Constructors
		public PlayAnimationSimple(); // 0x0000000181558C40-0x0000000181558C90
		static PlayAnimationSimple(); // 0x0000000181558BE0-0x0000000181558C40
	
		// Methods
		protected override string OnInit(); // 0x0000000181558A50-0x0000000181558B50
		protected override void OnExecute(); // 0x00000001815587B0-0x0000000181558A50
		protected override void OnUpdate(); // 0x0000000181558B50-0x0000000181558BE0
	}
}
