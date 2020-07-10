/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800FCA20-0x00000001800FCA80
	[Name] // 0x00000001800FCA20-0x00000001800FCA80
	public class CurveTransformTween : ActionTask<Transform> // TypeDefIndex: 14286
	{
		// Fields
		public TransformMode transformMode; // 0x68
		public TweenMode mode; // 0x6C
		public PlayMode playMode; // 0x70
		public BBParameter<Vector3> targetPosition; // 0x78
		public BBParameter<AnimationCurve> curve; // 0x80
		public BBParameter<float> time; // 0x88
		private Vector3 original; // 0x90
		private Vector3 final; // 0x9C
		private bool ponging; // 0xA8
	
		// Nested types
		public enum TransformMode // TypeDefIndex: 14287
		{
			Position = 0,
			Rotation = 1,
			Scale = 2
		}
	
		public enum TweenMode // TypeDefIndex: 14288
		{
			Absolute = 0,
			Additive = 1
		}
	
		public enum PlayMode // TypeDefIndex: 14289
		{
			Normal = 0,
			PingPong = 1
		}
	
		// Constructors
		public CurveTransformTween(); // 0x000000018174CF30-0x000000018174CFC0
	
		// Methods
		protected override void OnExecute(); // 0x000000018174C9C0-0x000000018174CCC0
		protected override void OnUpdate(); // 0x000000018174CCC0-0x000000018174CF30
	}
}
