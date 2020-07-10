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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal abstract class HIDControllerElementWithDataSet : HIDControllerElement // TypeDefIndex: 6402
	{
		// Fields
		internal FBPUlVOPtUXFfuAtXMDzKNjgpze dataSet; // 0x20
	
		// Nested types
		internal abstract class FBPUlVOPtUXFfuAtXMDzKNjgpze // TypeDefIndex: 6403
		{
			// Fields
			private int QZKeYnHKobJenAUrgkIhHOinlpxl; // 0x10
			private int[] lSNIHeHuthvpdsUkLYNMQLmHAaG; // 0x18
			protected fsFsHJrfhlKUoloaavsvBeNbHQc[] kfTISdkkctRzKjoxkCEklUCQgYlt; // 0x20
			public fsFsHJrfhlKUoloaavsvBeNbHQc hXsQEjeqlbsWHdImyyWjqLiDOxk; // 0x28
			private int JmjyOQGqMTQVyuPjpVribdoqBbW; // 0x30
			private int BiWKybgirUycdinIYBuMqCscBJH; // 0x34
			private bool UiuVfXaOVJlpnMDNdnJtrhHFBAyf; // 0x38
	
			// Properties
			protected int WGHFFzJMXRpPuoqnoZfReFkMDCNi { get; } // 0x000000018036CFF0-0x000000018036D000 
			protected int[] YIfdsEMRhAyoDoMFbNpXyyKydTj { get; } // 0x000000018038B150-0x000000018038B160 
			public UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk { set; } // 0x0000000180619140-0x00000001806191E0
	
			// Constructors
			public FBPUlVOPtUXFfuAtXMDzKNjgpze(); // 0x0000000180619130-0x0000000180619140
	
			// Methods
			public void WiwkhXbTqtUAtuYnZcgPRDAzAxt(UpdateLoopSetting param_0000d3e6, Func<UpdateLoopType, fsFsHJrfhlKUoloaavsvBeNbHQc> param_0000d3e7); // 0x0000000180618E20-0x0000000180619130
			private void xYKFisfBEYpeKTWojTkhmEaUJLp(UpdateLoopType param_0000d3e8, fsFsHJrfhlKUoloaavsvBeNbHQc param_0000d3e9); // 0x00000001806191E0-0x0000000180619290
			public virtual void Update(UpdateLoopType param_0000d3ea); // 0x0000000180618D50-0x0000000180618E20
			public void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x0000000180618CC0-0x0000000180618D50
		}
	
		internal abstract class fsFsHJrfhlKUoloaavsvBeNbHQc // TypeDefIndex: 6404
		{
			// Fields
			public readonly UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk; // 0x10
	
			// Constructors
			public fsFsHJrfhlKUoloaavsvBeNbHQc(UpdateLoopType updateLoop); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			public abstract void Reset();
		}
	
		// Constructors
		public HIDControllerElementWithDataSet(FBPUlVOPtUXFfuAtXMDzKNjgpze dataSet, byte reportId, HIDInfo hidInfo); // 0x0000000180619830-0x00000001806198A0
	
		// Methods
		public virtual void Update(UpdateLoopType updateLoop); // 0x00000001806197D0-0x0000000180619830
	}
}
