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
	[Category] // 0x00000001801E4CA0-0x00000001801E4D60
	[Description] // 0x00000001801E4CA0-0x00000001801E4D60
	[Icon] // 0x00000001801E4CA0-0x00000001801E4D60
	[Name] // 0x00000001801E4CA0-0x00000001801E4D60
	public class CreateLookAtGameObjectTween : ActionTask<Rigidbody> // TypeDefIndex: 15623
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> LookAtObject; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		public AxisConstraint AxisConstraint; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807F9A80-0x00000001807F9B50 
	
		// Constructors
		public CreateLookAtGameObjectTween(); // 0x00000001807F9A40-0x00000001807F9A80
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F98F0-0x00000001807F9A40
	}
}
