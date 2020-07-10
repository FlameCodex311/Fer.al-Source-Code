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

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category] // 0x00000001801426E0-0x00000001801427A0
	[Description] // 0x00000001801426E0-0x00000001801427A0
	[Icon] // 0x00000001801426E0-0x00000001801427A0
	[Name] // 0x00000001801426E0-0x00000001801427A0
	public class CreateMaterialVectorTween : ActionTask<Renderer> // TypeDefIndex: 14517
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> Value; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> PropertyName; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E8A180-0x0000000180E8A230 
	
		// Constructors
		public CreateMaterialVectorTween(); // 0x0000000180E8A140-0x0000000180E8A180
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E89FB0-0x0000000180E8A140
	}
}
