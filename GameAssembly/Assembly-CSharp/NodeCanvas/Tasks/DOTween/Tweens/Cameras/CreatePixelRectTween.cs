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
	[Category] // 0x0000000180149CD0-0x0000000180149D90
	[Description] // 0x0000000180149CD0-0x0000000180149D90
	[Icon] // 0x0000000180149CD0-0x0000000180149D90
	[Name] // 0x0000000180149CD0-0x0000000180149D90
	public class CreatePixelRectTween : ActionTask<Camera> // TypeDefIndex: 14530
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<Rect> To; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E8B290-0x0000000180E8B3A0 
	
		// Constructors
		public CreatePixelRectTween(); // 0x0000000180E8B250-0x0000000180E8B290
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8B170-0x0000000180E8B250
	}
}
