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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal abstract class HIDControllerElementWithDataSet : HIDControllerElement // TypeDefIndex: 6561
	{
		// Fields
		internal FBPUlVOPtUXFfuAtXMDzKNjgpze dataSet; // 0x20
	
		// Nested types
		internal abstract class FBPUlVOPtUXFfuAtXMDzKNjgpze // TypeDefIndex: 6562
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
			protected int WGHFFzJMXRpPuoqnoZfReFkMDCNi { get; } // 0x0000000180387590-0x0000000180387930 
			protected int[] YIfdsEMRhAyoDoMFbNpXyyKydTj { get; } // 0x0000000180372430-0x0000000180372440 
			public UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk { set; } // 0x0000000180E5D040-0x0000000180E5D0E0
	
			// Constructors
			public FBPUlVOPtUXFfuAtXMDzKNjgpze(); // 0x0000000180E5D030-0x0000000180E5D040
	
			// Methods
			public void WiwkhXbTqtUAtuYnZcgPRDAzAxt(UpdateLoopSetting param_0000d656, Func<UpdateLoopType, fsFsHJrfhlKUoloaavsvBeNbHQc> param_0000d657); // 0x0000000180E5CD30-0x0000000180E5D030
			private void xYKFisfBEYpeKTWojTkhmEaUJLp(UpdateLoopType param_0000d658, fsFsHJrfhlKUoloaavsvBeNbHQc param_0000d659); // 0x0000000180E5D0E0-0x0000000180E5D180
			public virtual void Update(UpdateLoopType param_0000d65a); // 0x0000000180E5CC70-0x0000000180E5CD30
			public void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x0000000180E5CBE0-0x0000000180E5CC70
		}
	
		internal abstract class fsFsHJrfhlKUoloaavsvBeNbHQc // TypeDefIndex: 6563
		{
			// Fields
			public readonly UpdateLoopType wWvAsBevxHsqtvaIJuSLgaJqAjGk; // 0x10
	
			// Constructors
			public fsFsHJrfhlKUoloaavsvBeNbHQc(UpdateLoopType updateLoop); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			public abstract void Reset();
		}
	
		// Constructors
		public HIDControllerElementWithDataSet(FBPUlVOPtUXFfuAtXMDzKNjgpze dataSet, byte reportId, HIDInfo hidInfo); // 0x0000000180E5D720-0x0000000180E5D790
	
		// Methods
		public virtual void Update(UpdateLoopType updateLoop); // 0x0000000180E5D6C0-0x0000000180E5D720
	}
}
