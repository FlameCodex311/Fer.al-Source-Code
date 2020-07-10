/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x00000001800F4E50-0x00000001800F4E90
	public class UIEffectCapturedImage : RawImage // TypeDefIndex: 15502
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-EffectCapture"; // Metadata: 0x00784B9D
		[FormerlySerializedAs] // 0x00000001800F5040-0x00000001800F50D0
		[Range] // 0x00000001800F5040-0x00000001800F50D0
		[SerializeField] // 0x00000001800F5040-0x00000001800F50D0
		[Tooltip] // 0x00000001800F5040-0x00000001800F50D0
		private float m_EffectFactor; // 0xE0
		[Range] // 0x00000001800F2350-0x00000001800F23C0
		[SerializeField] // 0x00000001800F2350-0x00000001800F23C0
		[Tooltip] // 0x00000001800F2350-0x00000001800F23C0
		private float m_ColorFactor; // 0xE4
		[FormerlySerializedAs] // 0x00000001800F55C0-0x00000001800F5650
		[Range] // 0x00000001800F55C0-0x00000001800F5650
		[SerializeField] // 0x00000001800F55C0-0x00000001800F5650
		[Tooltip] // 0x00000001800F55C0-0x00000001800F5650
		private float m_BlurFactor; // 0xE8
		[FormerlySerializedAs] // 0x00000001800F5950-0x00000001800F59C0
		[SerializeField] // 0x00000001800F5950-0x00000001800F59C0
		[Tooltip] // 0x00000001800F5950-0x00000001800F59C0
		private EffectMode m_EffectMode; // 0xEC
		[SerializeField] // 0x00000001800F5D30-0x00000001800F5D80
		[Tooltip] // 0x00000001800F5D30-0x00000001800F5D80
		private ColorMode m_ColorMode; // 0xF0
		[SerializeField] // 0x00000001800F5F80-0x00000001800F5FD0
		[Tooltip] // 0x00000001800F5F80-0x00000001800F5FD0
		private BlurMode m_BlurMode; // 0xF4
		[SerializeField] // 0x00000001800F6320-0x00000001800F6370
		[Tooltip] // 0x00000001800F6320-0x00000001800F6370
		private Color m_EffectColor; // 0xF8
		[SerializeField] // 0x00000001800F6720-0x00000001800F6770
		[Tooltip] // 0x00000001800F6720-0x00000001800F6770
		private DesamplingRate m_DesamplingRate; // 0x108
		[SerializeField] // 0x00000001800F6970-0x00000001800F69C0
		[Tooltip] // 0x00000001800F6970-0x00000001800F69C0
		private DesamplingRate m_ReductionRate; // 0x10C
		[SerializeField] // 0x00000001800F6CE0-0x00000001800F6D30
		[Tooltip] // 0x00000001800F6CE0-0x00000001800F6D30
		private FilterMode m_FilterMode; // 0x110
		[SerializeField] // 0x00000001800F7080-0x00000001800F70D0
		[Tooltip] // 0x00000001800F7080-0x00000001800F70D0
		private Material m_EffectMaterial; // 0x118
		[FormerlySerializedAs] // 0x00000001800F72C0-0x00000001800F7350
		[Range] // 0x00000001800F72C0-0x00000001800F7350
		[SerializeField] // 0x00000001800F72C0-0x00000001800F7350
		[Tooltip] // 0x00000001800F72C0-0x00000001800F7350
		private int m_BlurIterations; // 0x120
		[FormerlySerializedAs] // 0x00000001800F76B0-0x00000001800F7720
		[SerializeField] // 0x00000001800F76B0-0x00000001800F7720
		[Tooltip] // 0x00000001800F76B0-0x00000001800F7720
		private bool m_FitToScreen; // 0x124
		[SerializeField] // 0x00000001800F7AF0-0x00000001800F7B40
		[Tooltip] // 0x00000001800F7AF0-0x00000001800F7B40
		private bool m_CaptureOnEnable; // 0x125
		[SerializeField] // 0x00000001800F7D90-0x00000001800F7DE0
		[Tooltip] // 0x00000001800F7D90-0x00000001800F7DE0
		private bool m_ImmediateCapturing; // 0x126
		private RenderTexture _rt; // 0x128
		private static int s_CopyId; // 0x00
		private static int s_EffectId1; // 0x04
		private static int s_EffectId2; // 0x08
		private static int s_EffectFactorId; // 0x0C
		private static int s_ColorFactorId; // 0x10
		private static CommandBuffer s_CommandBuffer; // 0x18
	
		// Properties
		[Obsolete] // 0x00000001800F1360-0x00000001800F1390
		public float toneLevel { get; set; } // 0x0000000180610120-0x0000000180610130 0x0000000181486710-0x0000000181486790
		public float effectFactor { get; set; } // 0x0000000180610120-0x0000000180610130 0x0000000181486670-0x00000001814866F0
		public float colorFactor { get; set; } // 0x0000000181486490-0x00000001814864A0 0x00000001814865E0-0x0000000181486660
		[Obsolete] // 0x00000001800F4A30-0x00000001800F4A60
		public float blur { get; set; } // 0x0000000180F70FB0-0x0000000180F70FC0 0x0000000181486550-0x00000001814865D0
		public float blurFactor { get; set; } // 0x0000000180F70FB0-0x0000000180F70FC0 0x00000001814864D0-0x0000000181486550
		[Obsolete] // 0x00000001800F4C80-0x00000001800F4CB0
		public EffectMode toneMode { get; } // 0x00000001814864B0-0x00000001814864C0 
		public EffectMode effectMode { get; } // 0x00000001814864B0-0x00000001814864C0 
		public ColorMode colorMode { get; } // 0x000000018081E130-0x000000018081E140 
		public BlurMode blurMode { get; } // 0x0000000180E36620-0x0000000180E36630 
		public Color effectColor { get; set; } // 0x00000001814864A0-0x00000001814864B0 0x0000000181486660-0x0000000181486670
		public virtual Material effectMaterial { get; } // 0x00000001803BD3A0-0x00000001803BD3B0 
		public DesamplingRate desamplingRate { get; set; } // 0x00000001810D1BF0-0x00000001810D1C00 0x00000001810D1DF0-0x00000001810D1E00
		public DesamplingRate reductionRate { get; set; } // 0x00000001810D1C00-0x00000001810D1C10 0x00000001810D1E00-0x00000001810D1E10
		public FilterMode filterMode { get; set; } // 0x00000001810C9900-0x00000001810C9910 0x00000001813F3BC0-0x00000001813F3BD0
		public RenderTexture capturedTexture { get; } // 0x00000001803BD350-0x00000001803BD360 
		[Obsolete] // 0x00000001800F8530-0x00000001800F8560
		public int iterations { get; set; } // 0x0000000180641E60-0x0000000180641E70 0x0000000180F13130-0x0000000180F13140
		public int blurIterations { get; set; } // 0x0000000180641E60-0x0000000180641E70 0x0000000180F13130-0x0000000180F13140
		[Obsolete] // 0x00000001800F8760-0x00000001800F8790
		public bool keepCanvasSize { get; set; } // 0x000000018081DD40-0x000000018081DD50 0x00000001814866F0-0x0000000181486700
		public bool fitToScreen { get; set; } // 0x000000018081DD40-0x000000018081DD50 0x00000001814866F0-0x0000000181486700
		[Obsolete] // 0x00000001800B80C0-0x00000001800B80D0
		public RenderTexture targetTexture { get; set; } // 0x000000018035FCC0-0x000000018035FCD0 0x00000001803581E0-0x00000001803581F0
		public bool captureOnEnable { get; set; } // 0x0000000181486480-0x0000000181486490 0x00000001814865D0-0x00000001814865E0
		public bool immediateCapturing { get; set; } // 0x00000001814864C0-0x00000001814864D0 0x0000000181486700-0x0000000181486710
	
		// Nested types
		public enum DesamplingRate // TypeDefIndex: 15503
		{
			None = 0,
			x1 = 1,
			x2 = 2,
			x4 = 4,
			x8 = 8
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <_CoUpdateTextureOnNextFrame>d__95 : IEnumerator<object> // TypeDefIndex: 15504
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public UIEffectCapturedImage <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <_CoUpdateTextureOnNextFrame>d__95(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181484410-0x00000001814844B0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001814844B0-0x0000000181484500
		}
	
		// Constructors
		public UIEffectCapturedImage(); // 0x00000001814863F0-0x0000000181486480
	
		// Methods
		protected override void OnEnable(); // 0x00000001814855E0-0x0000000181485620
		protected override void OnDisable(); // 0x0000000181485560-0x00000001814855E0
		protected override void OnDestroy(); // 0x00000001814854A0-0x0000000181485560
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000181485620-0x0000000181485850
		public void GetDesamplingSize(DesamplingRate rate, out int w, out int h); // 0x0000000181485380-0x00000001814854A0
		public void Capture(); // 0x0000000181484F40-0x0000000181485380
		private void SetupCommandBuffer(); // 0x0000000181485900-0x0000000181486160
		public void Release(); // 0x0000000181485850-0x0000000181485900
		private void _Release(bool releaseRT); // 0x0000000181486280-0x0000000181486340
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		private void _SetDirty(); // 0x00000001803581E0-0x00000001803581F0
		private void _Release(ref RenderTexture obj); // 0x0000000181486340-0x00000001814863F0
		[IteratorStateMachine] // 0x00000001800F8010-0x00000001800F8060
		private IEnumerator _CoUpdateTextureOnNextFrame(); // 0x0000000181486220-0x0000000181486280
		private void UpdateTexture(); // 0x0000000181486160-0x0000000181486220
	}
}
