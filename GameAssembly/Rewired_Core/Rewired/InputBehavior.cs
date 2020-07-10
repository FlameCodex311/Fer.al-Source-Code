/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[Serializable]
	public sealed class InputBehavior // TypeDefIndex: 6535
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string _name; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private float _joystickAxisSensitivity; // 0x20
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private bool _digitalAxisSimulation; // 0x24
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private bool _digitalAxisSnap; // 0x25
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private bool _digitalAxisInstantReverse; // 0x26
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _digitalAxisGravity; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private float _digitalAxisSensitivity; // 0x2C
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private MouseXYAxisMode _mouseXYAxisMode; // 0x30
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private MouseOtherAxisMode _mouseOtherAxisMode; // 0x34
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private float _mouseXYAxisSensitivity; // 0x38
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc; // 0x3C
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _mouseOtherAxisSensitivity; // 0x40
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private float _customControllerAxisSensitivity; // 0x44
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private float _buttonDoublePressSpeed; // 0x48
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _buttonShortPressTime; // 0x4C
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _buttonShortPressExpiresIn; // 0x50
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _buttonLongPressTime; // 0x54
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _buttonLongPressExpiresIn; // 0x58
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _buttonDeadZone; // 0x5C
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _buttonDownBuffer; // 0x60
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private float _buttonRepeatRate; // 0x64
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private float _buttonRepeatDelay; // 0x68
	
		// Properties
		public int id { get; internal set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public string name { get; internal set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public float joystickAxisSensitivity { get; set; } // 0x0000000180487DA0-0x0000000180487DB0 0x0000000180488510-0x0000000180488540
		public bool digitalAxisSimulation { get; set; } // 0x0000000180487D80-0x0000000180487D90 0x00000001804884F0-0x0000000180488500
		public bool digitalAxisSnap { get; set; } // 0x0000000180487D90-0x0000000180487DA0 0x0000000180488500-0x0000000180488510
		public bool digitalAxisInstantReverse { get; set; } // 0x0000000180487D60-0x0000000180487D70 0x00000001804884B0-0x00000001804884C0
		public float digitalAxisGravity { get; set; } // 0x0000000180487D50-0x0000000180487D60 0x0000000180488480-0x00000001804884B0
		public float digitalAxisSensitivity { get; set; } // 0x0000000180487D70-0x0000000180487D80 0x00000001804884C0-0x00000001804884F0
		public MouseXYAxisMode mouseXYAxisMode { get; set; } // 0x000000018043DDC0-0x000000018043DDD0 0x000000018036B7A0-0x000000018036B7F0
		public MouseOtherAxisMode mouseOtherAxisMode { get; set; } // 0x000000018043E170-0x000000018043E180 0x000000018036C610-0x000000018036C620
		public float mouseXYAxisSensitivity { get; set; } // 0x0000000180487DD0-0x0000000180487DE0 0x0000000180488570-0x00000001804885A0
		public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc { get; set; } // 0x0000000180487DC0-0x0000000180487DD0 0x000000018036C630-0x000000018036C640
		public float mouseOtherAxisSensitivity { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x0000000180488540-0x0000000180488570
		public float customControllerAxisSensitivity { get; set; } // 0x0000000180487D40-0x0000000180487D50 0x0000000180488450-0x0000000180488480
		public float buttonDoublePressSpeed { get; set; } // 0x0000000180487CC0-0x0000000180487CD0 0x00000001804882C0-0x00000001804882F0
		public float buttonShortPressTime { get; set; } // 0x0000000180487D30-0x0000000180487D40 0x0000000180488420-0x0000000180488450
		public float buttonShortPressExpiresIn { get; set; } // 0x0000000180487D20-0x0000000180487D30 0x00000001804883F0-0x0000000180488420
		public float buttonLongPressTime { get; set; } // 0x0000000180487CF0-0x0000000180487D00 0x0000000180488370-0x00000001804883A0
		public float buttonLongPressExpiresIn { get; set; } // 0x0000000180487CE0-0x0000000180487CF0 0x0000000180488340-0x0000000180488370
		public float buttonDeadZone { get; set; } // 0x0000000180487CB0-0x0000000180487CC0 0x0000000180488290-0x00000001804882C0
		public float buttonDownBuffer { get; set; } // 0x0000000180487CD0-0x0000000180487CE0 0x00000001804882F0-0x0000000180488340
		public float buttonRepeatRate { get; set; } // 0x0000000180487D10-0x0000000180487D20 0x00000001804883C0-0x00000001804883F0
		public float buttonRepeatDelay { get; set; } // 0x0000000180487D00-0x0000000180487D10 0x00000001804883A0-0x00000001804883C0
	
		// Constructors
		public InputBehavior(); // 0x0000000180487C80-0x0000000180487CB0
		public InputBehavior(InputBehavior source); // 0x0000000180487B10-0x0000000180487C80
	
		// Methods
		public string ToXmlString(); // 0x0000000180487A50-0x0000000180487B10
		public bool ImportXmlString(string xmlString); // 0x0000000180486A10-0x0000000180486AF0
		public string ToJsonString(); // 0x0000000180487990-0x0000000180487A50
		public bool ImportJsonString(string jsonString); // 0x0000000180486930-0x0000000180486A10
		public bool ImportData(InputBehavior inputBehavior); // 0x0000000180486700-0x0000000180486930
		public InputBehavior Clone(); // 0x0000000180486560-0x0000000180486700
		public void Reset(); // 0x00000001804877B0-0x0000000180487990
		internal SerializedObject JijNtvxBfxSyvZqRuViZInoAdyr(); // 0x0000000180486AF0-0x0000000180487570
		internal void oOJgtRfrJindxeXPtlOXKDmATym(SerializedObject param_0000dbfc); // 0x0000000180487DE0-0x0000000180488290
		private static void NdcJYipIwyegYQfyTrsLRzhzdYx(InputBehavior param_0000dbfd, InputBehavior param_0000dbfe, bool param_0000dbff); // 0x0000000180487570-0x00000001804877B0
	}
}
