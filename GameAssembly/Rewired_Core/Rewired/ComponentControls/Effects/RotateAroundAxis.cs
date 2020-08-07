/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls.Effects
{
	public class RotateAroundAxis : UnityEngine.MonoBehaviour // TypeDefIndex: 5973
	{
		// Fields
		[CustomObfuscation] // 0x00000001801E8F70-0x00000001801E8FD0
		[SerializeField] // 0x00000001801E8F70-0x00000001801E8FD0
		[Tooltip] // 0x00000001801E8F70-0x00000001801E8FD0
		private Speed _speed; // 0x18
		[CustomObfuscation] // 0x00000001801E9340-0x00000001801E93A0
		[SerializeField] // 0x00000001801E9340-0x00000001801E93A0
		[Tooltip] // 0x00000001801E9340-0x00000001801E93A0
		private float _slowRotationSpeed; // 0x1C
		[CustomObfuscation] // 0x00000001801E95B0-0x00000001801E9610
		[SerializeField] // 0x00000001801E95B0-0x00000001801E9610
		[Tooltip] // 0x00000001801E95B0-0x00000001801E9610
		private float _fastRotationSpeed; // 0x20
		[CustomObfuscation] // 0x00000001801E99F0-0x00000001801E9A50
		[SerializeField] // 0x00000001801E99F0-0x00000001801E9A50
		[Tooltip] // 0x00000001801E99F0-0x00000001801E9A50
		private RotationAxis _rotateAroundAxis; // 0x24
		[CustomObfuscation] // 0x00000001801E9D30-0x00000001801E9D90
		[SerializeField] // 0x00000001801E9D30-0x00000001801E9D90
		[Tooltip] // 0x00000001801E9D30-0x00000001801E9D90
		private Space _relativeTo; // 0x28
		[CustomObfuscation] // 0x00000001801EA0B0-0x00000001801EA110
		[SerializeField] // 0x00000001801EA0B0-0x00000001801EA110
		[Tooltip] // 0x00000001801EA0B0-0x00000001801EA110
		private bool _reverse; // 0x2C
	
		// Properties
		public Speed speed { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
		public float slowRotationSpeed { get; set; } // 0x0000000180918C20-0x0000000180918C30 0x0000000180918CF0-0x0000000180918D00
		public float fastRotationSpeed { get; set; } // 0x0000000180373AF0-0x0000000180373B00 0x0000000180373B00-0x0000000180373B10
		public RotationAxis rotateAroundAxis { get; set; } // 0x0000000180491DB0-0x0000000180491DC0 0x0000000180569610-0x0000000180569620
		public Space relativeTo { get; set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0
		public bool reverse { get; set; } // 0x0000000180626230-0x0000000180626240 0x0000000180626250-0x0000000180626260
	
		// Nested types
		public enum Speed // TypeDefIndex: 5974
		{
			Stopped = 0,
			Slow = 1,
			Fast = 2
		}
	
		public enum RotationAxis // TypeDefIndex: 5975
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public RotateAroundAxis(); // 0x0000000180918BF0-0x0000000180918C20
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Update(); // 0x0000000180918A90-0x0000000180918BF0
		private static Vector3 pFajXcJnBAviabKgRKrpIoSHfAMJ(RotationAxis param_0000c93d); // 0x0000000180918C30-0x0000000180918CF0
		public void SetSpeed(Speed speed); // 0x00000001803F46C0-0x00000001803F46D0
		public void SetSpeed(int speed); // 0x00000001809189C0-0x0000000180918A90
	}
}
