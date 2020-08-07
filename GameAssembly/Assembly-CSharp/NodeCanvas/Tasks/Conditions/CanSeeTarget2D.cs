/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802298E0-0x0000000180229940
	[Description] // 0x00000001802298E0-0x0000000180229940
	public class CanSeeTarget2D : ConditionTask<Transform> // TypeDefIndex: 15216
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<float> awarnessDistance; // 0x78
		[SliderField] // 0x0000000180229F50-0x0000000180229F70
		public BBParameter<float> viewAngle; // 0x80
		public Vector2 offset; // 0x88
		private RaycastHit2D hit; // 0x90
	
		// Properties
		protected override string info { get; } // 0x0000000180793340-0x0000000180793380 
	
		// Constructors
		public CanSeeTarget2D(); // 0x00000001807932C0-0x0000000180793340
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807925E0-0x0000000180792B10
		public override void OnDrawGizmosSelected(); // 0x0000000180792B10-0x00000001807932C0
	}
}
