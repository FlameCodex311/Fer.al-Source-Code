/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public sealed class TiltControl : CustomControllerControl // TypeDefIndex: 5971
	{
		// Fields
		private const float maxFullTiltAngle = 180f; // Metadata: 0x007638B5
		private const float maxAngleOffset = 90f; // Metadata: 0x007638B9
		[CustomObfuscation] // 0x00000001801E5270-0x00000001801E52D0
		[SerializeField] // 0x00000001801E5270-0x00000001801E52D0
		[Tooltip] // 0x00000001801E5270-0x00000001801E52D0
		private TiltDirection _allowedTiltDirections; // 0x28
		[CustomObfuscation] // 0x00000001801E55F0-0x00000001801E5650
		[SerializeField] // 0x00000001801E55F0-0x00000001801E5650
		[Tooltip] // 0x00000001801E55F0-0x00000001801E5650
		private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement; // 0x30
		[CustomObfuscation] // 0x00000001801E5B00-0x00000001801E5B80
		[Range] // 0x00000001801E5B00-0x00000001801E5B80
		[SerializeField] // 0x00000001801E5B00-0x00000001801E5B80
		[Tooltip] // 0x00000001801E5B00-0x00000001801E5B80
		private float _horizontalTiltLimit; // 0x38
		[CustomObfuscation] // 0x00000001801E5F50-0x00000001801E5FD0
		[Range] // 0x00000001801E5F50-0x00000001801E5FD0
		[SerializeField] // 0x00000001801E5F50-0x00000001801E5FD0
		[Tooltip] // 0x00000001801E5F50-0x00000001801E5FD0
		private float _horizontalRestAngle; // 0x3C
		[CustomObfuscation] // 0x00000001801E6470-0x00000001801E64D0
		[SerializeField] // 0x00000001801E6470-0x00000001801E64D0
		[Tooltip] // 0x00000001801E6470-0x00000001801E64D0
		private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement; // 0x40
		[CustomObfuscation] // 0x00000001801E6870-0x00000001801E68F0
		[Range] // 0x00000001801E6870-0x00000001801E68F0
		[SerializeField] // 0x00000001801E6870-0x00000001801E68F0
		[Tooltip] // 0x00000001801E6870-0x00000001801E68F0
		private float _forwardTiltLimit; // 0x48
		[CustomObfuscation] // 0x00000001801E6E60-0x00000001801E6EE0
		[Range] // 0x00000001801E6E60-0x00000001801E6EE0
		[SerializeField] // 0x00000001801E6E60-0x00000001801E6EE0
		[Tooltip] // 0x00000001801E6E60-0x00000001801E6EE0
		private float _forwardRestAngle; // 0x4C
		[CustomObfuscation] // 0x00000001801E73F0-0x00000001801E7450
		[SerializeField] // 0x00000001801E73F0-0x00000001801E7450
		[Tooltip] // 0x00000001801E73F0-0x00000001801E7450
		private StandaloneAxis2D _axis2D; // 0x50
		private bool _useHAxis; // 0x58
		private bool _useFAxis; // 0x59
		private Func<Vector3> _getAccelerationValue; // 0x60
	
		// Properties
		public TiltDirection axesToUse { get; set; } // 0x000000018043C680-0x000000018043C690 0x00000001809198B0-0x0000000180919910
		public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement { get; } // 0x00000001803745C0-0x00000001803745D0 
		public float horizontalTiltLimit { get; set; } // 0x0000000180788790-0x00000001807887A0 0x0000000180919A80-0x0000000180919B00
		public float horizontalRestAngle { get; set; } // 0x0000000180379EF0-0x0000000180379F00 0x00000001809199F0-0x0000000180919A80
		public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement { get; } // 0x00000001803C7290-0x00000001803C72A0 
		public float forwardTiltLimit { get; set; } // 0x00000001804D5810-0x00000001804D5820 0x00000001809199A0-0x00000001809199F0
		public float forwardRestAngle { get; set; } // 0x0000000180379EA0-0x0000000180379EB0 0x0000000180919910-0x00000001809199A0
		public AxisCalibration horizontalAxisCalibration { get; } // 0x0000000180919850-0x0000000180919880 
		public AxisCalibration verticalAxisCalibration { get; } // 0x0000000180919880-0x00000001809198B0 
		[Obsolete] // 0x00000001801E8D70-0x00000001801E8DA0
		public Axis2DCalibration deadZoneType { get; } // 0x0000000180919830-0x0000000180919850 
		public Axis2DCalibration axis2DCalibration { get; } // 0x0000000180919830-0x0000000180919850 
		internal StandaloneAxis2D axis2D { get; } // 0x0000000180378320-0x0000000180378330 
		private Vector3 acceleration { get; } // 0x00000001809197B0-0x0000000180919830 
	
		// Nested types
		public enum TiltDirection // TypeDefIndex: 5972
		{
			Both = 0,
			Horizontal = 1,
			Forward = 2
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal TiltControl(); // 0x0000000180919560-0x0000000180919610
	
		// Methods
		public void SetAccelerationSourceCallback(Func<Vector3> callback); // 0x00000001804AF510-0x00000001804AF520
		public void SetRestOrientation(); // 0x00000001809192E0-0x0000000180919560
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnValidate(); // 0x0000000180919290-0x00000001809192E0
		internal override bool OnInitialize(); // 0x0000000180919200-0x0000000180919280
		internal override void OnUpdate(); // 0x0000000180919280-0x0000000180919290
		internal override void OnCustomControllerUpdate(); // 0x0000000180919080-0x0000000180919200
		public override void ClearValue(); // 0x0000000180918D00-0x0000000180918EC0
		private void yoIzXjrqilGxCRhYNevhdDdokJQ(); // 0x0000000180919B00-0x000000018091A040
		private void IXEKEFykLRaswFEjRpcTUAFhbDi(); // 0x0000000180918EC0-0x0000000180919080
		private void dzynYViRaRMlteHKPpYVKSjcRik(TiltDirection param_0000c936); // 0x0000000180919610-0x00000001809197B0
	}
}
