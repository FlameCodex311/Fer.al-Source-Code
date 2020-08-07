/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Plugins.Options
{
	public struct PathOptions : IPlugOptions // TypeDefIndex: 5797
	{
		// Fields
		public PathMode mode; // 0x00
		public OrientType orientType; // 0x04
		public AxisConstraint lockPositionAxis; // 0x08
		public AxisConstraint lockRotationAxis; // 0x0C
		public bool isClosedPath; // 0x10
		public Vector3 lookAtPosition; // 0x14
		public Transform lookAtTransform; // 0x20
		public float lookAhead; // 0x28
		public bool hasCustomForwardDirection; // 0x2C
		public Quaternion forward; // 0x30
		public bool useLocalPosition; // 0x40
		public Transform parent; // 0x48
		public bool isRigidbody; // 0x50
		internal Quaternion startupRot; // 0x54
		internal float startupZRot; // 0x64
		internal bool addedExtraStartWp; // 0x68
		internal bool addedExtraEndWp; // 0x69
	
		// Methods
		public void Reset(); // 0x00000001800DFA20-0x00000001800DFB20
	}
}
