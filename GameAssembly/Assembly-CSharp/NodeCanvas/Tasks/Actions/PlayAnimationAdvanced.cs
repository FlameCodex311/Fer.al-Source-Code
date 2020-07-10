/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800E2640-0x00000001800E2670
	public class PlayAnimationAdvanced : ActionTask<Animation> // TypeDefIndex: 14201
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<AnimationClip> animationClip; // 0x68
		public WrapMode animationWrap; // 0x70
		public AnimationBlendMode blendMode; // 0x74
		[SliderField] // 0x00000001800E2930-0x00000001800E2950
		public float playbackSpeed; // 0x78
		[SliderField] // 0x00000001800E2A20-0x00000001800E2A40
		public float crossFadeTime; // 0x7C
		public PlayDirections playDirection; // 0x80
		public BBParameter<string> mixTransformName; // 0x88
		public BBParameter<int> animationLayer; // 0x90
		public bool queueAnimation; // 0x98
		public bool waitActionFinish; // 0x99
		private string animationToPlay; // 0xA0
		private int dir; // 0xA8
		private Transform mixTransform; // 0xB0
	
		// Properties
		protected override string info { get; } // 0x0000000181558750-0x00000001815587B0 
	
		// Constructors
		public PlayAnimationAdvanced(); // 0x00000001815586E0-0x0000000181558750
	
		// Methods
		protected override string OnInit(); // 0x0000000181558530-0x0000000181558630
		protected override void OnExecute(); // 0x0000000181557E80-0x0000000181558530
		protected override void OnUpdate(); // 0x0000000181558630-0x00000001815586E0
		private Transform FindTransform(Transform parent, string name); // 0x0000000181557D70-0x0000000181557E80
	}
}
