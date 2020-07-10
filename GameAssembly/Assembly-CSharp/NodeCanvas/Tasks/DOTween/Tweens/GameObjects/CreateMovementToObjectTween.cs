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
	[Category] // 0x0000000180143370-0x0000000180143430
	[Description] // 0x0000000180143370-0x0000000180143430
	[Icon] // 0x0000000180143370-0x0000000180143430
	[Name] // 0x0000000180143370-0x0000000180143430
	public class CreateMovementToObjectTween : ActionTask // TypeDefIndex: 14518
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> DestinationObject; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		public BBParameter<bool> UseSnapping; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E8A3C0-0x0000000180E8A4E0 
	
		// Constructors
		public CreateMovementToObjectTween(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8A230-0x0000000180E8A3C0
	}
}
