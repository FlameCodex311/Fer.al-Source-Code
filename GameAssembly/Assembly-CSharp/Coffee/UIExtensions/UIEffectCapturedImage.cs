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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x00000001801FFEB0-0x00000001801FFEF0
	public class UIEffectCapturedImage : RawImage // TypeDefIndex: 16341
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-EffectCapture"; // Metadata: 0x007BBD0D
		[FormerlySerializedAs] // 0x00000001802000E0-0x0000000180200170
		[Range] // 0x00000001802000E0-0x0000000180200170
		[SerializeField] // 0x00000001802000E0-0x0000000180200170
		[Tooltip] // 0x00000001802000E0-0x0000000180200170
		private float m_EffectFactor; // 0xE0
		[Range] // 0x00000001801FCFB0-0x00000001801FD020
		[SerializeField] // 0x00000001801FCFB0-0x00000001801FD020
		[Tooltip] // 0x00000001801FCFB0-0x00000001801FD020
		private float m_ColorFactor; // 0xE4
		[FormerlySerializedAs] // 0x00000001802006A0-0x0000000180200730
		[Range] // 0x00000001802006A0-0x0000000180200730
		[SerializeField] // 0x00000001802006A0-0x0000000180200730
		[Tooltip] // 0x00000001802006A0-0x0000000180200730
		private float m_BlurFactor; // 0xE8
		[FormerlySerializedAs] // 0x0000000180200A60-0x0000000180200AD0
		[SerializeField] // 0x0000000180200A60-0x0000000180200AD0
		[Tooltip] // 0x0000000180200A60-0x0000000180200AD0
		private EffectMode m_EffectMode; // 0xEC
		[SerializeField] // 0x0000000180200E40-0x0000000180200E90
		[Tooltip] // 0x0000000180200E40-0x0000000180200E90
		private ColorMode m_ColorMode; // 0xF0
		[SerializeField] // 0x0000000180200F70-0x0000000180200FC0
		[Tooltip] // 0x0000000180200F70-0x0000000180200FC0
		private BlurMode m_BlurMode; // 0xF4
		[SerializeField] // 0x0000000180202500-0x0000000180202550
		[Tooltip] // 0x0000000180202500-0x0000000180202550
		private Color m_EffectColor; // 0xF8
		[SerializeField] // 0x0000000180202790-0x00000001802027E0
		[Tooltip] // 0x0000000180202790-0x00000001802027E0
		private DesamplingRate m_DesamplingRate; // 0x108
		[SerializeField] // 0x0000000180202B70-0x0000000180202BC0
		[Tooltip] // 0x0000000180202B70-0x0000000180202BC0
		private DesamplingRate m_ReductionRate; // 0x10C
		[SerializeField] // 0x0000000180202DD0-0x0000000180202E20
		[Tooltip] // 0x0000000180202DD0-0x0000000180202E20
		private FilterMode m_FilterMode; // 0x110
		[SerializeField] // 0x0000000180203090-0x00000001802030E0
		[Tooltip] // 0x0000000180203090-0x00000001802030E0
		private Material m_EffectMaterial; // 0x118
		[FormerlySerializedAs] // 0x0000000180203470-0x0000000180203500
		[Range] // 0x0000000180203470-0x0000000180203500
		[SerializeField] // 0x0000000180203470-0x0000000180203500
		[Tooltip] // 0x0000000180203470-0x0000000180203500
		private int m_BlurIterations; // 0x120
		[FormerlySerializedAs] // 0x0000000180203AE0-0x0000000180203B50
		[SerializeField] // 0x0000000180203AE0-0x0000000180203B50
		[Tooltip] // 0x0000000180203AE0-0x0000000180203B50
		private bool m_FitToScreen; // 0x124
		[SerializeField] // 0x0000000180205230-0x0000000180205280
		[Tooltip] // 0x0000000180205230-0x0000000180205280
		private bool m_CaptureOnEnable; // 0x125
		[SerializeField] // 0x0000000180205500-0x0000000180205550
		[Tooltip] // 0x0000000180205500-0x0000000180205550
		private bool m_ImmediateCapturing; // 0x126
		private RenderTexture _rt; // 0x128
		private static int s_CopyId; // 0x00
		private static int s_EffectId1; // 0x04
		private static int s_EffectId2; // 0x08
		private static int s_EffectFactorId; // 0x0C
		private static int s_ColorFactorId; // 0x10
		private static CommandBuffer s_CommandBuffer; // 0x18
	
		// Properties
		[Obsolete] // 0x00000001801FAC00-0x00000001801FAC30
		public float toneLevel { get; set; } // 0x000000018078A9F0-0x000000018078AA00 0x000000018078AC90-0x000000018078AD10
		public float effectFactor { get; set; } // 0x000000018078A9F0-0x000000018078AA00 0x000000018078ABE0-0x000000018078AC60
		public float colorFactor { get; set; } // 0x000000018078A9D0-0x000000018078A9E0 0x000000018078AB50-0x000000018078ABD0
		[Obsolete] // 0x00000001801FFB60-0x00000001801FFB90
		public float blur { get; set; } // 0x00000001804405A0-0x00000001804405B0 0x000000018078AAC0-0x000000018078AB40
		public float blurFactor { get; set; } // 0x00000001804405A0-0x00000001804405B0 0x000000018078AA40-0x000000018078AAC0
		[Obsolete] // 0x00000001801FFCD0-0x00000001801FFD00
		public EffectMode toneMode { get; } // 0x000000018078AA00-0x000000018078AA10 
		public EffectMode effectMode { get; } // 0x000000018078AA00-0x000000018078AA10 
		public ColorMode colorMode { get; } // 0x00000001804DE030-0x00000001804DE040 
		public BlurMode blurMode { get; } // 0x000000018078A9B0-0x000000018078A9C0 
		public Color effectColor { get; set; } // 0x000000018078A9E0-0x000000018078A9F0 0x000000018078ABD0-0x000000018078ABE0
		public virtual Material effectMaterial { get; } // 0x00000001803916B0-0x00000001803916C0 
		public DesamplingRate desamplingRate { get; set; } // 0x000000018057C2E0-0x000000018057C2F0 0x000000018057C500-0x000000018057C510
		public DesamplingRate reductionRate { get; set; } // 0x000000018057C2F0-0x000000018057C300 0x000000018057C510-0x000000018057C520
		public FilterMode filterMode { get; set; } // 0x000000018078AA10-0x000000018078AA20 0x000000018078AC60-0x000000018078AC70
		public RenderTexture capturedTexture { get; } // 0x00000001803EF180-0x00000001803EF190 
		[Obsolete] // 0x0000000180205FF0-0x0000000180206020
		public int iterations { get; set; } // 0x0000000180491490-0x00000001804914A0 0x0000000180491190-0x00000001804911A0
		public int blurIterations { get; set; } // 0x0000000180491490-0x00000001804914A0 0x0000000180491190-0x00000001804911A0
		[Obsolete] // 0x0000000180206340-0x0000000180206370
		public bool keepCanvasSize { get; set; } // 0x000000018078AA20-0x000000018078AA30 0x000000018078AC70-0x000000018078AC80
		public bool fitToScreen { get; set; } // 0x000000018078AA20-0x000000018078AA30 0x000000018078AC70-0x000000018078AC80
		[Obsolete] // 0x00000001801E0130-0x00000001801E0140
		public RenderTexture targetTexture { get; set; } // 0x000000018037DDC0-0x000000018037DDD0 0x00000001803774A0-0x00000001803774B0
		public bool captureOnEnable { get; set; } // 0x000000018078A9C0-0x000000018078A9D0 0x000000018078AB40-0x000000018078AB50
		public bool immediateCapturing { get; set; } // 0x000000018078AA30-0x000000018078AA40 0x000000018078AC80-0x000000018078AC90
	
		// Nested types
		public enum DesamplingRate // TypeDefIndex: 16342
		{
			None = 0,
			x1 = 1,
			x2 = 2,
			x4 = 4,
			x8 = 8
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <_CoUpdateTextureOnNextFrame>d__95 : IEnumerator<object> // TypeDefIndex: 16343
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public UIEffectCapturedImage <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <_CoUpdateTextureOnNextFrame>d__95(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180787180-0x0000000180787220
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180787220-0x0000000180787270
		}
	
		// Constructors
		public UIEffectCapturedImage(); // 0x000000018078A920-0x000000018078A9B0
	
		// Methods
		protected override void OnEnable(); // 0x0000000180789B30-0x0000000180789B70
		protected override void OnDisable(); // 0x0000000180789AB0-0x0000000180789B30
		protected override void OnDestroy(); // 0x00000001807899F0-0x0000000180789AB0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180789B70-0x0000000180789DA0
		public void GetDesamplingSize(DesamplingRate rate, out int w, out int h); // 0x00000001807898D0-0x00000001807899F0
		public void Capture(); // 0x00000001807894A0-0x00000001807898D0
		private void SetupCommandBuffer(); // 0x0000000180789E50-0x000000018078A690
		public void Release(); // 0x0000000180789DA0-0x0000000180789E50
		private void _Release(bool releaseRT); // 0x000000018078A7B0-0x000000018078A870
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		private void _SetDirty(); // 0x00000001803774A0-0x00000001803774B0
		private void _Release(ref RenderTexture obj); // 0x000000018078A870-0x000000018078A920
		[IteratorStateMachine] // 0x00000001802059F0-0x0000000180205A40
		private IEnumerator _CoUpdateTextureOnNextFrame(); // 0x000000018078A750-0x000000018078A7B0
		private void UpdateTexture(); // 0x000000018078A690-0x000000018078A750
	}
}
