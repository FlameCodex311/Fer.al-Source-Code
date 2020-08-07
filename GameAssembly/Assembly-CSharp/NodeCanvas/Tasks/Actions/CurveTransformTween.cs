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

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018025F760-0x000000018025F7C0
	[Name] // 0x000000018025F760-0x000000018025F7C0
	public class CurveTransformTween : ActionTask<Transform> // TypeDefIndex: 15389
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
		public enum TransformMode // TypeDefIndex: 15390
		{
			Position = 0,
			Rotation = 1,
			Scale = 2
		}
	
		public enum TweenMode // TypeDefIndex: 15391
		{
			Absolute = 0,
			Additive = 1
		}
	
		public enum PlayMode // TypeDefIndex: 15392
		{
			Normal = 0,
			PingPong = 1
		}
	
		// Constructors
		public CurveTransformTween(); // 0x0000000180CC1280-0x0000000180CC1310
	
		// Methods
		protected override void OnExecute(); // 0x0000000180CC0D30-0x0000000180CC1020
		protected override void OnUpdate(); // 0x0000000180CC1020-0x0000000180CC1280
	}
}
