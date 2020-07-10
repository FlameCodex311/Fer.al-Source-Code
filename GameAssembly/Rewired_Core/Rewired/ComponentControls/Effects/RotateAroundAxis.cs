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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls.Effects
{
	public class RotateAroundAxis : UnityEngine.MonoBehaviour // TypeDefIndex: 5814
	{
		// Fields
		[CustomObfuscation] // 0x000000018014B1A0-0x000000018014B200
		[SerializeField] // 0x000000018014B1A0-0x000000018014B200
		[Tooltip] // 0x000000018014B1A0-0x000000018014B200
		private Speed _speed; // 0x18
		[CustomObfuscation] // 0x000000018014B500-0x000000018014B560
		[SerializeField] // 0x000000018014B500-0x000000018014B560
		[Tooltip] // 0x000000018014B500-0x000000018014B560
		private float _slowRotationSpeed; // 0x1C
		[CustomObfuscation] // 0x000000018014B870-0x000000018014B8D0
		[SerializeField] // 0x000000018014B870-0x000000018014B8D0
		[Tooltip] // 0x000000018014B870-0x000000018014B8D0
		private float _fastRotationSpeed; // 0x20
		[CustomObfuscation] // 0x000000018014BDB0-0x000000018014BE10
		[SerializeField] // 0x000000018014BDB0-0x000000018014BE10
		[Tooltip] // 0x000000018014BDB0-0x000000018014BE10
		private RotationAxis _rotateAroundAxis; // 0x24
		[CustomObfuscation] // 0x000000018014C340-0x000000018014C3A0
		[SerializeField] // 0x000000018014C340-0x000000018014C3A0
		[Tooltip] // 0x000000018014C340-0x000000018014C3A0
		private Space _relativeTo; // 0x28
		[CustomObfuscation] // 0x000000018014C740-0x000000018014C7A0
		[SerializeField] // 0x000000018014C740-0x000000018014C7A0
		[Tooltip] // 0x000000018014C740-0x000000018014C7A0
		private bool _reverse; // 0x2C
	
		// Properties
		public Speed speed { get; set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
		public float slowRotationSpeed { get; set; } // 0x00000001805D9070-0x00000001805D9080 0x00000001805D90A0-0x00000001805D90B0
		public float fastRotationSpeed { get; set; } // 0x0000000180487DA0-0x0000000180487DB0 0x00000001805D9090-0x00000001805D90A0
		public RotationAxis rotateAroundAxis { get; set; } // 0x00000001803C26F0-0x00000001803C2700 0x00000001804D0B90-0x00000001804D0BA0
		public Space relativeTo { get; set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0
		public bool reverse { get; set; } // 0x0000000180488600-0x0000000180488610 0x0000000180488610-0x0000000180488620
	
		// Nested types
		public enum Speed // TypeDefIndex: 5815
		{
			Stopped = 0,
			Slow = 1,
			Fast = 2
		}
	
		public enum RotationAxis // TypeDefIndex: 5816
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public RotateAroundAxis(); // 0x000000018143B350-0x000000018143B380
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void Update(); // 0x000000018143B1F0-0x000000018143B350
		private static Vector3 pFajXcJnBAviabKgRKrpIoSHfAMJ(RotationAxis param_0000c6cd); // 0x000000018143B380-0x000000018143B440
		public void SetSpeed(Speed speed); // 0x000000018036B1F0-0x000000018036B200
		public void SetSpeed(int speed); // 0x000000018143B120-0x000000018143B1F0
	}
}
