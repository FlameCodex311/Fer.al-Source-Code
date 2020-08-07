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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180245D50-0x0000000180245D80
	public class PlayAnimationAdvanced : ActionTask<UnityEngine.Animation> // TypeDefIndex: 15301
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<AnimationClip> animationClip; // 0x68
		public WrapMode animationWrap; // 0x70
		public AnimationBlendMode blendMode; // 0x74
		[SliderField] // 0x0000000180245F80-0x0000000180245FA0
		public float playbackSpeed; // 0x78
		[SliderField] // 0x0000000180246120-0x0000000180246140
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
		protected override string info { get; } // 0x000000018079DA20-0x000000018079DA80 
	
		// Constructors
		public PlayAnimationAdvanced(); // 0x000000018079D9B0-0x000000018079DA20
	
		// Methods
		protected override string OnInit(); // 0x000000018079D810-0x000000018079D910
		protected override void OnExecute(); // 0x000000018079D200-0x000000018079D810
		protected override void OnUpdate(); // 0x000000018079D910-0x000000018079D9B0
		private Transform FindTransform(Transform parent, string name); // 0x000000018079D0F0-0x000000018079D200
	}
}
