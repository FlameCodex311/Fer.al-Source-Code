/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class SmoothDampFollowTarget : MonoBehaviour // TypeDefIndex: 13906
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform _followTarget; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 _targetOffset; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _smoothTime; // 0x34
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _useFixedUpdate; // 0x38
		private Vector3[] _vector3s; // 0x40
	
		// Constructors
		public SmoothDampFollowTarget(); // 0x0000000181203090-0x00000001812030E0
	
		// Methods
		private void Start(); // 0x0000000181202EC0-0x0000000181203060
		private void Update(); // 0x0000000181203060-0x0000000181203090
		private void FixedUpdate(); // 0x0000000181202E90-0x0000000181202EC0
		private void DoUpdate(float deltaTime); // 0x00000001812028B0-0x0000000181202E90
	}
}
