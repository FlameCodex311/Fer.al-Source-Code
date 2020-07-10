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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category] // 0x0000000180148DC0-0x0000000180148E80
	[Description] // 0x0000000180148DC0-0x0000000180148E80
	[Icon] // 0x0000000180148DC0-0x0000000180148E80
	[Name] // 0x0000000180148DC0-0x0000000180148E80
	public class CreateNearPlaneClipTween : ActionTask<Camera> // TypeDefIndex: 14528
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<float> To; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E8AAF0-0x0000000180E8AC00 
	
		// Constructors
		public CreateNearPlaneClipTween(); // 0x0000000180E8AAB0-0x0000000180E8AAF0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8A9D0-0x0000000180E8AAB0
	}
}
