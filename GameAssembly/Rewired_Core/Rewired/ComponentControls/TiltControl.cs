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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public sealed class TiltControl : CustomControllerControl // TypeDefIndex: 5812
	{
		// Fields
		private const float maxFullTiltAngle = 180f; // Metadata: 0x0072EC18
		private const float maxAngleOffset = 90f; // Metadata: 0x0072EC1C
		[CustomObfuscation] // 0x0000000180148F30-0x0000000180148F90
		[SerializeField] // 0x0000000180148F30-0x0000000180148F90
		[Tooltip] // 0x0000000180148F30-0x0000000180148F90
		private TiltDirection _allowedTiltDirections; // 0x28
		[CustomObfuscation] // 0x00000001801492C0-0x0000000180149320
		[SerializeField] // 0x00000001801492C0-0x0000000180149320
		[Tooltip] // 0x00000001801492C0-0x0000000180149320
		private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement; // 0x30
		[CustomObfuscation] // 0x0000000180149620-0x00000001801496A0
		[Range] // 0x0000000180149620-0x00000001801496A0
		[SerializeField] // 0x0000000180149620-0x00000001801496A0
		[Tooltip] // 0x0000000180149620-0x00000001801496A0
		private float _horizontalTiltLimit; // 0x38
		[CustomObfuscation] // 0x0000000180149C20-0x0000000180149CA0
		[Range] // 0x0000000180149C20-0x0000000180149CA0
		[SerializeField] // 0x0000000180149C20-0x0000000180149CA0
		[Tooltip] // 0x0000000180149C20-0x0000000180149CA0
		private float _horizontalRestAngle; // 0x3C
		[CustomObfuscation] // 0x000000018014A020-0x000000018014A080
		[SerializeField] // 0x000000018014A020-0x000000018014A080
		[Tooltip] // 0x000000018014A020-0x000000018014A080
		private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement; // 0x40
		[CustomObfuscation] // 0x000000018014A3E0-0x000000018014A460
		[Range] // 0x000000018014A3E0-0x000000018014A460
		[SerializeField] // 0x000000018014A3E0-0x000000018014A460
		[Tooltip] // 0x000000018014A3E0-0x000000018014A460
		private float _forwardTiltLimit; // 0x48
		[CustomObfuscation] // 0x000000018014A660-0x000000018014A6E0
		[Range] // 0x000000018014A660-0x000000018014A6E0
		[SerializeField] // 0x000000018014A660-0x000000018014A6E0
		[Tooltip] // 0x000000018014A660-0x000000018014A6E0
		private float _forwardRestAngle; // 0x4C
		[CustomObfuscation] // 0x000000018014AA60-0x000000018014AAC0
		[SerializeField] // 0x000000018014AA60-0x000000018014AAC0
		[Tooltip] // 0x000000018014AA60-0x000000018014AAC0
		private StandaloneAxis2D _axis2D; // 0x50
		private bool _useHAxis; // 0x58
		private bool _useFAxis; // 0x59
		private Func<Vector3> _getAccelerationValue; // 0x60
	
		// Properties
		public TiltDirection axesToUse { get; set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018143C000-0x000000018143C060
		public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement { get; } // 0x0000000180397720-0x0000000180397730 
		public float horizontalTiltLimit { get; set; } // 0x0000000180487DD0-0x0000000180487DE0 0x000000018143C1D0-0x000000018143C250
		public float horizontalRestAngle { get; set; } // 0x0000000180E426C0-0x0000000180E426D0 0x000000018143C140-0x000000018143C1D0
		public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement { get; } // 0x0000000180369B30-0x0000000180369B40 
		public float forwardTiltLimit { get; set; } // 0x0000000180487CC0-0x0000000180487CD0 0x000000018143C0F0-0x000000018143C140
		public float forwardRestAngle { get; set; } // 0x0000000180487D30-0x0000000180487D40 0x000000018143C060-0x000000018143C0F0
		public AxisCalibration horizontalAxisCalibration { get; } // 0x000000018143BFA0-0x000000018143BFD0 
		public AxisCalibration verticalAxisCalibration { get; } // 0x000000018143BFD0-0x000000018143C000 
		[Obsolete] // 0x000000018014B020-0x000000018014B050
		public Axis2DCalibration deadZoneType { get; } // 0x00000001809563B0-0x00000001809563D0 
		public Axis2DCalibration axis2DCalibration { get; } // 0x00000001809563B0-0x00000001809563D0 
		internal StandaloneAxis2D axis2D { get; } // 0x00000001803A27A0-0x00000001803A27B0 
		private Vector3 acceleration { get; } // 0x000000018143BF20-0x000000018143BFA0 
	
		// Nested types
		public enum TiltDirection // TypeDefIndex: 5813
		{
			Both = 0,
			Horizontal = 1,
			Forward = 2
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal TiltControl(); // 0x000000018143BCC0-0x000000018143BD70
	
		// Methods
		public void SetAccelerationSourceCallback(Func<Vector3> callback); // 0x00000001803A27E0-0x00000001803A27F0
		public void SetRestOrientation(); // 0x000000018143BA40-0x000000018143BCC0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnValidate(); // 0x000000018143B9F0-0x000000018143BA40
		internal override bool OnInitialize(); // 0x000000018143B960-0x000000018143B9E0
		internal override void OnUpdate(); // 0x000000018143B9E0-0x000000018143B9F0
		internal override void OnCustomControllerUpdate(); // 0x000000018143B7D0-0x000000018143B960
		public override void ClearValue(); // 0x000000018143B440-0x000000018143B610
		private void yoIzXjrqilGxCRhYNevhdDdokJQ(); // 0x000000018143C250-0x000000018143C790
		private void IXEKEFykLRaswFEjRpcTUAFhbDi(); // 0x000000018143B610-0x000000018143B7D0
		private void dzynYViRaRMlteHKPpYVKSjcRik(TiltDirection param_0000c6c6); // 0x000000018143BD70-0x000000018143BF20
	}
}
