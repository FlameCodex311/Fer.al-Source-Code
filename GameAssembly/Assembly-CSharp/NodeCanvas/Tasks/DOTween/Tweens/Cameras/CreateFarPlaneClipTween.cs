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
	[Category] // 0x0000000180148090-0x0000000180148150
	[Description] // 0x0000000180148090-0x0000000180148150
	[Icon] // 0x0000000180148090-0x0000000180148150
	[Name] // 0x0000000180148090-0x0000000180148150
	public class CreateFarPlaneClipTween : ActionTask<Camera> // TypeDefIndex: 14526
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<float> To; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E891D0-0x0000000180E892E0 
	
		// Constructors
		public CreateFarPlaneClipTween(); // 0x0000000180E89190-0x0000000180E891D0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E890B0-0x0000000180E89190
	}
}
