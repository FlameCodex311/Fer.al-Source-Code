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
	[Category] // 0x000000018014A2D0-0x000000018014A390
	[Description] // 0x000000018014A2D0-0x000000018014A390
	[Icon] // 0x000000018014A2D0-0x000000018014A390
	[Name] // 0x000000018014A2D0-0x000000018014A390
	public class CreateRectTween : ActionTask<Camera> // TypeDefIndex: 14531
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<Rect> To; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E8BBD0-0x0000000180E8BCE0 
	
		// Constructors
		public CreateRectTween(); // 0x0000000180E8BB90-0x0000000180E8BBD0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8BAB0-0x0000000180E8BB90
	}
}
