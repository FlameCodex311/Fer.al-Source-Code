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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class HIDGyroscope : HIDControllerElementWithDataSet // TypeDefIndex: 6414
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
		public float[] rawValue { get; } // 0x000000018061A340-0x000000018061A4A0 
		public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> events { get; } // 0x000000018061A1E0-0x000000018061A340 
	
		// Nested types
		internal class xoDNqPyYukPHaalvKDfsSvNgVzQ : HIDControllerElementWithDataSet.FBPUlVOPtUXFfuAtXMDzKNjgpze // TypeDefIndex: 6415
		{
			// Fields
			private int czwiIZKyAknjkMciFFJJFgQPSkut; // 0x40
			private int wLREUfQCezeMvHoFzmQMeqYzcedr; // 0x44
	
			// Properties
			public float[] eWkCANcBkaiDxZUsVOlJifJUZgpo { get; } // 0x0000000180625EA0-0x0000000180625F50 
			public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> CwiXTYjYEpsCePDSubaxCKamKEGx { get; } // 0x0000000180625DF0-0x0000000180625EA0 
	
			// Constructors
			public xoDNqPyYukPHaalvKDfsSvNgVzQ(UpdateLoopSetting updateLoopSetting, int valueLength, int eventCapacity); // 0x0000000180625C30-0x0000000180625CD0
	
			// Methods
			public override void Update(UpdateLoopType param_0000d46c); // 0x0000000180625AA0-0x0000000180625C30
			public void UQootxjXqIDuSdQLreCsJKPkYOm(float[] param_0000d46d, float param_0000d46e); // 0x0000000180625920-0x0000000180625AA0
			private HIDControllerElementWithDataSet.fsFsHJrfhlKUoloaavsvBeNbHQc dHihwHIJNAbwIXNzkrwAOZTncEW(UpdateLoopType param_0000d46f); // 0x0000000180625CD0-0x0000000180625DF0
		}
	
		internal class YqsjoDOkiSqcvIImjyMvGmFtaRK : HIDControllerElementWithDataSet.fsFsHJrfhlKUoloaavsvBeNbHQc // TypeDefIndex: 6416
		{
			// Fields
			private float[] TZMgsvJYjHVFHduTwAMMosvrfOF; // 0x18
			public float[] eWkCANcBkaiDxZUsVOlJifJUZgpo; // 0x20
			public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> CwiXTYjYEpsCePDSubaxCKamKEGx; // 0x28
			private ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> magaMpbhcqHKXwPhgpMcMSonXIt; // 0x30
	
			// Constructors
			public YqsjoDOkiSqcvIImjyMvGmFtaRK(UpdateLoopType updateLoop, int valueLength, int eventCapacity); // 0x0000000180624EF0-0x0000000180624FE0
	
			// Methods
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x00000001806249F0-0x0000000180624C40
			public void ZCQKmvcOXNATzEJVRrhmfgISsVPG(float[] param_0000d473, float param_0000d474); // 0x0000000180624CE0-0x0000000180624EF0
			public override void Reset(); // 0x0000000180624C40-0x0000000180624CE0
		}
	
		public class MHFgKytqZWorXhVxTJLZCCoNZhX : ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> // TypeDefIndex: 6417
		{
			// Fields
			public Vector3 eWkCANcBkaiDxZUsVOlJifJUZgpo; // 0x10
			public float RNhhaBXJSRDVYjlOvGsJHopqhGOD; // 0x1C
	
			// Constructors
			public MHFgKytqZWorXhVxTJLZCCoNZhX(); // 0x000000018036B6C0-0x000000018036B6D0
			public MHFgKytqZWorXhVxTJLZCCoNZhX(float[] rawValues, float deltaTime); // 0x0000000180620370-0x00000001806203B0
	
			// Methods
			public void bnteExvucnBsCpxQAJWOTetSFlq(float[] param_0000d477, float param_0000d478); // 0x00000001806203B0-0x0000000180620480
			public void Set(MHFgKytqZWorXhVxTJLZCCoNZhX param_0000d479); // 0x0000000180620340-0x0000000180620370
			public bool Equals(MHFgKytqZWorXhVxTJLZCCoNZhX param_0000d47a); // 0x0000000180620270-0x0000000180620340
			public void Clear(); // 0x0000000180620260-0x0000000180620270
			public int CompareTo(MHFgKytqZWorXhVxTJLZCCoNZhX other); // 0x000000018035FCC0-0x000000018035FCD0
		}
	
		// Constructors
		public HIDGyroscope(UpdateLoopSetting updateLoopSetting, byte reportId, HIDInfo hidInfo, int valueLength, int startingEventCapacity, Action<byte[], float[]> calcValueDelegate, Func<float> getSensorDeltaTimeDelegate); // 0x0000000180619FF0-0x000000018061A1E0
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamps); // 0x0000000180619B60-0x0000000180619FF0
	}
}
