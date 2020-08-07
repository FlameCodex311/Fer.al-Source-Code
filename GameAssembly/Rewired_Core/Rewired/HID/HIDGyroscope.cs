/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class HIDGyroscope : HIDControllerElementWithDataSet // TypeDefIndex: 6573
	{
		// Fields
		public float timestamp; // 0x28
		public readonly float[] lastRawValue; // 0x30
		public readonly int valueLength; // 0x38
		private readonly byte[] wuZPrKFhqfAdgfTBtloBkqjVrylu; // 0x40
		private readonly float[] YfaqzewlXPKFkPwZPpmCBUugDFN; // 0x48
		private readonly int vUlXhrGGqPAoBatyhmmMclfytPX; // 0x50
		private readonly int hKTyGPOfFdpmnBQRnpBRLEKDhlKk; // 0x54
		private readonly Action<byte[], float[]> PDRBnHNQdiYApABXTHhIWvbNQyR; // 0x58
		private readonly Func<float> AXqBAWcyjZmkDlhCfZNaGLEdhxw; // 0x60
	
		// Properties
		public float[] rawValue { get; } // 0x0000000180E5E200-0x0000000180E5E360 
		public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> events { get; } // 0x0000000180E5E0A0-0x0000000180E5E200 
	
		// Nested types
		internal class xoDNqPyYukPHaalvKDfsSvNgVzQ : HIDControllerElementWithDataSet.FBPUlVOPtUXFfuAtXMDzKNjgpze // TypeDefIndex: 6574
		{
			// Fields
			private int czwiIZKyAknjkMciFFJJFgQPSkut; // 0x40
			private int wLREUfQCezeMvHoFzmQMeqYzcedr; // 0x44
	
			// Properties
			public float[] eWkCANcBkaiDxZUsVOlJifJUZgpo { get; } // 0x0000000180E695D0-0x0000000180E69680 
			public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> CwiXTYjYEpsCePDSubaxCKamKEGx { get; } // 0x0000000180E69520-0x0000000180E695D0 
	
			// Constructors
			public xoDNqPyYukPHaalvKDfsSvNgVzQ(UpdateLoopSetting updateLoopSetting, int valueLength, int eventCapacity); // 0x0000000180E69360-0x0000000180E69400
	
			// Methods
			public override void Update(UpdateLoopType param_0000d6dc); // 0x0000000180E691E0-0x0000000180E69360
			public void UQootxjXqIDuSdQLreCsJKPkYOm(float[] param_0000d6dd, float param_0000d6de); // 0x0000000180E69060-0x0000000180E691E0
			private HIDControllerElementWithDataSet.fsFsHJrfhlKUoloaavsvBeNbHQc dHihwHIJNAbwIXNzkrwAOZTncEW(UpdateLoopType param_0000d6df); // 0x0000000180E69400-0x0000000180E69520
		}
	
		internal class YqsjoDOkiSqcvIImjyMvGmFtaRK : HIDControllerElementWithDataSet.fsFsHJrfhlKUoloaavsvBeNbHQc // TypeDefIndex: 6575
		{
			// Fields
			private float[] TZMgsvJYjHVFHduTwAMMosvrfOF; // 0x18
			public float[] eWkCANcBkaiDxZUsVOlJifJUZgpo; // 0x20
			public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> CwiXTYjYEpsCePDSubaxCKamKEGx; // 0x28
			private ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> magaMpbhcqHKXwPhgpMcMSonXIt; // 0x30
	
			// Constructors
			public YqsjoDOkiSqcvIImjyMvGmFtaRK(UpdateLoopType updateLoop, int valueLength, int eventCapacity); // 0x0000000180E68640-0x0000000180E68730
	
			// Methods
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x0000000180E68160-0x0000000180E683A0
			public void ZCQKmvcOXNATzEJVRrhmfgISsVPG(float[] param_0000d6e3, float param_0000d6e4); // 0x0000000180E68440-0x0000000180E68640
			public override void Reset(); // 0x0000000180E683A0-0x0000000180E68440
		}
	
		public class MHFgKytqZWorXhVxTJLZCCoNZhX : ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> // TypeDefIndex: 6576
		{
			// Fields
			public Vector3 eWkCANcBkaiDxZUsVOlJifJUZgpo; // 0x10
			public float RNhhaBXJSRDVYjlOvGsJHopqhGOD; // 0x1C
	
			// Constructors
			public MHFgKytqZWorXhVxTJLZCCoNZhX(); // 0x0000000180373240-0x0000000180373250
			public MHFgKytqZWorXhVxTJLZCCoNZhX(float[] rawValues, float deltaTime); // 0x0000000180E64010-0x0000000180E64050
	
			// Methods
			public void bnteExvucnBsCpxQAJWOTetSFlq(float[] param_0000d6e7, float param_0000d6e8); // 0x0000000180E64050-0x0000000180E64120
			public void Set(MHFgKytqZWorXhVxTJLZCCoNZhX param_0000d6e9); // 0x0000000180E63FE0-0x0000000180E64010
			public bool Equals(MHFgKytqZWorXhVxTJLZCCoNZhX param_0000d6ea); // 0x0000000180E63F10-0x0000000180E63FE0
			public void Clear(); // 0x0000000180E63F00-0x0000000180E63F10
			public int CompareTo(MHFgKytqZWorXhVxTJLZCCoNZhX other); // 0x000000018037DDC0-0x000000018037DDD0
		}
	
		// Constructors
		public HIDGyroscope(UpdateLoopSetting updateLoopSetting, byte reportId, HIDInfo hidInfo, int valueLength, int startingEventCapacity, Action<byte[], float[]> calcValueDelegate, Func<float> getSensorDeltaTimeDelegate); // 0x0000000180E5DEB0-0x0000000180E5E0A0
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamps); // 0x0000000180E5DA40-0x0000000180E5DEB0
	}
}
