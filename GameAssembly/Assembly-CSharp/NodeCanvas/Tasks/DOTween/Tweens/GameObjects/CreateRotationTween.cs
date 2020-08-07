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

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category] // 0x00000001801EC0A0-0x00000001801EC160
	[Description] // 0x00000001801EC0A0-0x00000001801EC160
	[Icon] // 0x00000001801EC0A0-0x00000001801EC160
	[Name] // 0x00000001801EC0A0-0x00000001801EC160
	public class CreateRotationTween : ActionTask // TypeDefIndex: 15632
	{
		// Fields
		public BBParameter<Vector3> DestinationRotation; // 0x68
		public BBParameter<GameObject> DestinationGameObject; // 0x70
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x78
		public RotateMode RotateMode; // 0x80
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807FC5B0-0x00000001807FC770 
	
		// Constructors
		public CreateRotationTween(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FC290-0x00000001807FC470
	}
}
