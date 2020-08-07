/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Coffee.SoftMaskForUGUI.dll - Assembly: Coffee.SoftMaskForUGUI, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7581-7585

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class SoftMaskable : UnityEngine.MonoBehaviour, IMaterialModifier, ICanvasRaycastFilter, ISerializationCallbackReceiver // TypeDefIndex: 7585
	{
		// Fields
		private const int kVisibleInside = 85; // Metadata: 0x007766BF
		private const int kVisibleOutside = 170; // Metadata: 0x007766C3
		[HideInInspector] // 0x0000000180214790-0x0000000180214800
		[Obsolete] // 0x0000000180214790-0x0000000180214800
		[SerializeField] // 0x0000000180214790-0x0000000180214800
		[Tooltip] // 0x0000000180214790-0x0000000180214800
		private bool m_Inverse; // 0x18
		[HideInInspector] // 0x0000000180214DA0-0x0000000180214E00
		[SerializeField] // 0x0000000180214DA0-0x0000000180214E00
		[Tooltip] // 0x0000000180214DA0-0x0000000180214E00
		private int m_MaskInteraction; // 0x1C
		[SerializeField] // 0x0000000180215020-0x0000000180215070
		[Tooltip] // 0x0000000180215020-0x0000000180215070
		private bool m_UseStencil; // 0x20
		private Graphic _graphic; // 0x28
		private SoftMask _softMask; // 0x30
		private Material _maskMaterial; // 0x38
		private static int s_SoftMaskTexId; // 0x00
		private static int s_StencilCompId; // 0x04
		private static int s_MaskInteractionId; // 0x08
		private static int s_GameVPId; // 0x0C
		private static int s_GameTVPId; // 0x10
		private static List<SoftMaskable> s_ActiveSoftMaskables; // 0x18
		private static int[] s_Interactions; // 0x20
		private static Material s_DefaultMaterial; // 0x28
	
		// Properties
		public bool inverse { get; set; } // 0x00000001820C0EC0-0x00000001820C0ED0 0x00000001820C0ED0-0x00000001820C0F20
		public Graphic graphic { get; } // 0x00000001820C0E30-0x00000001820C0EC0 
	
		// Constructors
		public SoftMaskable(); // 0x00000001820C0E20-0x00000001820C0E30
		static SoftMaskable(); // 0x00000001820C0DD0-0x00000001820C0E20
	
		// Methods
		public Material GetModifiedMaterial(Material baseMaterial); // 0x00000001820C0050-0x00000001820C03D0
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x00000001820C03D0-0x00000001820C0670
		public void SetMaskInteraction(SpriteMaskInteraction intr); // 0x00000001820C0D10-0x00000001820C0DB0
		public void SetMaskInteraction(SpriteMaskInteraction layer0, SpriteMaskInteraction layer1, SpriteMaskInteraction layer2, SpriteMaskInteraction layer3); // 0x00000001820C0C40-0x00000001820C0D10
		private void OnEnable(); // 0x00000001820C0810-0x00000001820C0B80
		private void OnDisable(); // 0x00000001820C0670-0x00000001820C0810
		private void ReleaseMaterial(ref Material mat); // 0x00000001820C0B80-0x00000001820C0C40
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001820C0DB0-0x00000001820C0DD0
	}
}
