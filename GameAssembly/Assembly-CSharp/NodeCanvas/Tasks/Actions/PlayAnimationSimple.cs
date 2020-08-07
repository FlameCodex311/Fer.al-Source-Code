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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180245D50-0x0000000180245D80
	public class PlayAnimationSimple : ActionTask<Animation> // TypeDefIndex: 15302
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<AnimationClip> animationClip; // 0x68
		[SliderField] // 0x0000000180246120-0x0000000180246140
		public float crossFadeTime; // 0x70
		public WrapMode animationWrap; // 0x74
		public bool waitActionFinish; // 0x78
		private static Dictionary<Animation, AnimationClip> lastPlayedClips; // 0x00
	
		// Properties
		protected override string info { get; } // 0x000000018079DF50-0x000000018079DFB0 
	
		// Constructors
		public PlayAnimationSimple(); // 0x000000018079DF00-0x000000018079DF50
		static PlayAnimationSimple(); // 0x000000018079DEA0-0x000000018079DF00
	
		// Methods
		protected override string OnInit(); // 0x000000018079DD10-0x000000018079DE10
		protected override void OnExecute(); // 0x000000018079DA80-0x000000018079DD10
		protected override void OnUpdate(); // 0x000000018079DE10-0x000000018079DEA0
	}
}
