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
	[Category] // 0x000000018014B9C0-0x000000018014BA80
	[Description] // 0x000000018014B9C0-0x000000018014BA80
	[Icon] // 0x000000018014B9C0-0x000000018014BA80
	[Name] // 0x000000018014B9C0-0x000000018014BA80
	public class CreateShakeRotationVectorTween : ActionTask<Camera> // TypeDefIndex: 14535
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<Vector3> Strength; // 0x70
		public BBParameter<int> vibrato; // 0x78
		public BBParameter<float> randomness; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x0000000180E8D200-0x0000000180E8D3C0 
	
		// Constructors
		public CreateShakeRotationVectorTween(); // 0x0000000180E8D1C0-0x0000000180E8D200
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8D050-0x0000000180E8D1C0
	}
}
