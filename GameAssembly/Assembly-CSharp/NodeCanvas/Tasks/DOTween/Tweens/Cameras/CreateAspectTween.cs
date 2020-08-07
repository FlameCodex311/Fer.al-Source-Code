/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category] // 0x00000001801ECA40-0x00000001801ECB00
	[Description] // 0x00000001801ECA40-0x00000001801ECB00
	[Icon] // 0x00000001801ECA40-0x00000001801ECB00
	[Name] // 0x00000001801ECA40-0x00000001801ECB00
	public class CreateAspectTween : ActionTask<Camera> // TypeDefIndex: 15633
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<float> To; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807F7D40-0x00000001807F7E50 
	
		// Constructors
		public CreateAspectTween(); // 0x00000001807F7D00-0x00000001807F7D40
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F7C20-0x00000001807F7D00
	}
}
