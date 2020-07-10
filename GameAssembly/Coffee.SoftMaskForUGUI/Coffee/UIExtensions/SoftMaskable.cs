/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Coffee.SoftMaskForUGUI.dll - Assembly: Coffee.SoftMaskForUGUI, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7415-7419

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class SoftMaskable : UnityEngine.MonoBehaviour, IMaterialModifier, ICanvasRaycastFilter, ISerializationCallbackReceiver // TypeDefIndex: 7419
	{
		// Fields
		private const int kVisibleInside = 85; // Metadata: 0x007419D1
		private const int kVisibleOutside = 170; // Metadata: 0x007419D5
		[HideInInspector] // 0x0000000180171DC0-0x0000000180171E30
		[Obsolete] // 0x0000000180171DC0-0x0000000180171E30
		[SerializeField] // 0x0000000180171DC0-0x0000000180171E30
		[Tooltip] // 0x0000000180171DC0-0x0000000180171E30
		private bool m_Inverse; // 0x18
		[HideInInspector] // 0x0000000180173520-0x0000000180173580
		[SerializeField] // 0x0000000180173520-0x0000000180173580
		[Tooltip] // 0x0000000180173520-0x0000000180173580
		private int m_MaskInteraction; // 0x1C
		[SerializeField] // 0x0000000180173820-0x0000000180173870
		[Tooltip] // 0x0000000180173820-0x0000000180173870
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
		public bool inverse { get; set; } // 0x00000001822C9120-0x00000001822C9130 0x00000001822C9130-0x00000001822C9180
		public Graphic graphic { get; } // 0x00000001822C9090-0x00000001822C9120 
	
		// Constructors
		public SoftMaskable(); // 0x00000001822C9080-0x00000001822C9090
		static SoftMaskable(); // 0x00000001822C9030-0x00000001822C9080
	
		// Methods
		public Material GetModifiedMaterial(Material baseMaterial); // 0x00000001822C8290-0x00000001822C8620
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x00000001822C8620-0x00000001822C88D0
		public void SetMaskInteraction(SpriteMaskInteraction intr); // 0x00000001822C8F70-0x00000001822C9010
		public void SetMaskInteraction(SpriteMaskInteraction layer0, SpriteMaskInteraction layer1, SpriteMaskInteraction layer2, SpriteMaskInteraction layer3); // 0x00000001822C8EA0-0x00000001822C8F70
		private void OnEnable(); // 0x00000001822C8A70-0x00000001822C8DE0
		private void OnDisable(); // 0x00000001822C88D0-0x00000001822C8A70
		private void ReleaseMaterial(ref Material mat); // 0x00000001822C8DE0-0x00000001822C8EA0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001822C9010-0x00000001822C9030
	}
}
