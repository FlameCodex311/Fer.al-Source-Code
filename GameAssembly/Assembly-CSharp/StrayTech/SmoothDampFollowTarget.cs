/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class SmoothDampFollowTarget : MonoBehaviour // TypeDefIndex: 14573
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform _followTarget; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 _targetOffset; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _smoothTime; // 0x34
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _useFixedUpdate; // 0x38
		private Vector3[] _vector3s; // 0x40
	
		// Constructors
		public SmoothDampFollowTarget(); // 0x0000000180CB7680-0x0000000180CB76D0
	
		// Methods
		private void Start(); // 0x0000000180CB74C0-0x0000000180CB7650
		private void Update(); // 0x0000000180CB7650-0x0000000180CB7680
		private void FixedUpdate(); // 0x0000000180CB7490-0x0000000180CB74C0
		private void DoUpdate(float deltaTime); // 0x0000000180CB6F10-0x0000000180CB7490
	}
}
