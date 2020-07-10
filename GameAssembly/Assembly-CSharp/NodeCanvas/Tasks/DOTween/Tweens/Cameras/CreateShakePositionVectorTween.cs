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
	[Category] // 0x000000018014AD30-0x000000018014ADF0
	[Description] // 0x000000018014AD30-0x000000018014ADF0
	[Icon] // 0x000000018014AD30-0x000000018014ADF0
	[Name] // 0x000000018014AD30-0x000000018014ADF0
	public class CreateShakePositionVectorTween : ActionTask<Camera> // TypeDefIndex: 14533
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<Vector3> Strength; // 0x70
		public BBParameter<int> vibrato; // 0x78
		public BBParameter<float> randomness; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x0000000180E8CB60-0x0000000180E8CD20 
	
		// Constructors
		public CreateShakePositionVectorTween(); // 0x0000000180E8CB20-0x0000000180E8CB60
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8C9B0-0x0000000180E8CB20
	}
}
