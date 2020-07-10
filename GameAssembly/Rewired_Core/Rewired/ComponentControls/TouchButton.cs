/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.Attributes;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000180168160-0x00000001801681A0
	[DisallowMultipleComponent] // 0x0000000180168160-0x00000001801681A0
	public sealed class TouchButton : TouchInteractable // TypeDefIndex: 5845
	{
		// Fields
		private const float bIrMhBPndqbqBcilJMwjpMxegcN = 20f; // Metadata: 0x0072ECD8
		[CustomObfuscation] // 0x0000000180168410-0x0000000180168470
		[SerializeField] // 0x0000000180168410-0x0000000180168470
		[Tooltip] // 0x0000000180168410-0x0000000180168470
		private CustomControllerElementTargetSetForFloat _targetCustomControllerElement; // 0x128
		[CustomObfuscation] // 0x0000000180168770-0x00000001801687D0
		[SerializeField] // 0x0000000180168770-0x00000001801687D0
		[Tooltip] // 0x0000000180168770-0x00000001801687D0
		private ButtonType _buttonType; // 0x130
		[CustomObfuscation] // 0x00000001801688F0-0x0000000180168950
		[SerializeField] // 0x00000001801688F0-0x0000000180168950
		[Tooltip] // 0x00000001801688F0-0x0000000180168950
		private bool _activateOnSwipeIn; // 0x134
		[CustomObfuscation] // 0x0000000180168C10-0x0000000180168C70
		[SerializeField] // 0x0000000180168C10-0x0000000180168C70
		[Tooltip] // 0x0000000180168C10-0x0000000180168C70
		private bool _stayActiveOnSwipeOut; // 0x135
		[CustomObfuscation] // 0x0000000180168FC0-0x0000000180169020
		[SerializeField] // 0x0000000180168FC0-0x0000000180169020
		[Tooltip] // 0x0000000180168FC0-0x0000000180169020
		private bool _useDigitalAxisSimulation; // 0x136
		[CustomObfuscation] // 0x00000001801693D0-0x0000000180169450
		[FieldRange] // 0x00000001801693D0-0x0000000180169450
		[SerializeField] // 0x00000001801693D0-0x0000000180169450
		[Tooltip] // 0x00000001801693D0-0x0000000180169450
		private float _digitalAxisGravity; // 0x138
		[CustomObfuscation] // 0x000000018016AA40-0x000000018016AAC0
		[FieldRange] // 0x000000018016AA40-0x000000018016AAC0
		[SerializeField] // 0x000000018016AA40-0x000000018016AAC0
		[Tooltip] // 0x000000018016AA40-0x000000018016AAC0
		private float _digitalAxisSensitivity; // 0x13C
		[CustomObfuscation] // 0x000000018016AD00-0x000000018016AD60
		[SerializeField] // 0x000000018016AD00-0x000000018016AD60
		[Tooltip] // 0x000000018016AD00-0x000000018016AD60
		private StandaloneAxis _axis; // 0x140
		[CustomObfuscation] // 0x000000018016AF70-0x000000018016AFD0
		[SerializeField] // 0x000000018016AF70-0x000000018016AFD0
		[Tooltip] // 0x000000018016AF70-0x000000018016AFD0
		private TouchRegion _touchRegion; // 0x148
		[CustomObfuscation] // 0x000000018016B2D0-0x000000018016B330
		[SerializeField] // 0x000000018016B2D0-0x000000018016B330
		[Tooltip] // 0x000000018016B2D0-0x000000018016B330
		private bool _useTouchRegionOnly; // 0x150
		[CustomObfuscation] // 0x000000018016B580-0x000000018016B5E0
		[SerializeField] // 0x000000018016B580-0x000000018016B5E0
		[Tooltip] // 0x000000018016B580-0x000000018016B5E0
		private bool _moveToTouchPosition; // 0x151
		[CustomObfuscation] // 0x000000018016B770-0x000000018016B7D0
		[SerializeField] // 0x000000018016B770-0x000000018016B7D0
		[Tooltip] // 0x000000018016B770-0x000000018016B7D0
		private bool _returnOnRelease; // 0x152
		[CustomObfuscation] // 0x000000018016B9C0-0x000000018016BA20
		[SerializeField] // 0x000000018016B9C0-0x000000018016BA20
		[Tooltip] // 0x000000018016B9C0-0x000000018016BA20
		private bool _followTouchPosition; // 0x153
		[CustomObfuscation] // 0x000000018016BD20-0x000000018016BD80
		[SerializeField] // 0x000000018016BD20-0x000000018016BD80
		[Tooltip] // 0x000000018016BD20-0x000000018016BD80
		private bool _animateOnMoveToTouch; // 0x154
		[CustomObfuscation] // 0x000000018016C150-0x000000018016C1D0
		[Range] // 0x000000018016C150-0x000000018016C1D0
		[SerializeField] // 0x000000018016C150-0x000000018016C1D0
		[Tooltip] // 0x000000018016C150-0x000000018016C1D0
		private float _moveToTouchSpeed; // 0x158
		[CustomObfuscation] // 0x000000018016C4A0-0x000000018016C500
		[SerializeField] // 0x000000018016C4A0-0x000000018016C500
		[Tooltip] // 0x000000018016C4A0-0x000000018016C500
		private bool _animateOnReturn; // 0x15C
		[CustomObfuscation] // 0x000000018016C770-0x000000018016C7F0
		[Range] // 0x000000018016C770-0x000000018016C7F0
		[SerializeField] // 0x000000018016C770-0x000000018016C7F0
		[Tooltip] // 0x000000018016C770-0x000000018016C7F0
		private float _returnSpeed; // 0x160
		[CustomObfuscation] // 0x000000018016DE20-0x000000018016DE80
		[SerializeField] // 0x000000018016DE20-0x000000018016DE80
		[Tooltip] // 0x000000018016DE20-0x000000018016DE80
		private bool _manageRaycasting; // 0x164
		private float zZnZVrLVyeqSsazfkZvelwsSOc; // 0x168
		private float wlpbaVGQEViyvpKziXzyOTnaBtz; // 0x16C
		private TouchRegion cBhbvMMZNVdkVwMGcOhbZxYnKTO; // 0x170
		private Vector2 CVNaZFKWpgHSEgdRNrUgPhPiNrX; // 0x178
		private bool MejCErHRHJfvFEhWTCJGiWTOfjPq; // 0x180
		private bool PqDTICcamAIrJJSjGLHKIVPznycN; // 0x181
		private nmJOdZmANObDJaNczzHbyFiChru BuFtCznxroTCJTiccGSuCkoFGWe; // 0x184
		private int NnlmxMWJcRhEzfWxChxgLDOjRLL; // 0x188
		private int eLvDEkOWbJEhaAfNqwHMvBxRCnIg; // 0x18C
		[NonSerialized]
		private bool byeanBfvjEeOOwRBSBerFwsuBMBA; // 0x190
		[NonSerialized]
		private bool IXgubBiHZOnBAjLkDRcJjAfbtyr; // 0x191
		private IEnumerator iIJgAsbKKxNMNtomWTaEUMVoAnvE; // 0x198
		private FulEHeUoVkyNDHjDfouzidfyihgB uRBiOcOtAqAvLhajjVPQsbibEfy; // 0x1A0
		private Action<nmJOdZmANObDJaNczzHbyFiChru> UStkkCNXENjKTUJtDQelaVCUhFl; // 0x1A8
		private Action<nmJOdZmANObDJaNczzHbyFiChru> xuoFMVdYOOMYiQeBvgkKMKxlnlAJ; // 0x1B0
		[CustomObfuscation] // 0x000000018016E050-0x000000018016E0B0
		[SerializeField] // 0x000000018016E050-0x000000018016E0B0
		[Tooltip] // 0x000000018016E050-0x000000018016E0B0
		private AxisValueChangedEventHandler _onAxisValueChanged; // 0x1B8
		[CustomObfuscation] // 0x000000018016E370-0x000000018016E3D0
		[SerializeField] // 0x000000018016E370-0x000000018016E3D0
		[Tooltip] // 0x000000018016E370-0x000000018016E3D0
		private ButtonValueChangedEventHandler _onButtonValueChanged; // 0x1C0
		[CustomObfuscation] // 0x000000018016E770-0x000000018016E7D0
		[SerializeField] // 0x000000018016E770-0x000000018016E7D0
		[Tooltip] // 0x000000018016E770-0x000000018016E7D0
		private ButtonDownEventHandler _onButtonDown; // 0x1C8
		[CustomObfuscation] // 0x000000018016E920-0x000000018016E980
		[SerializeField] // 0x000000018016E920-0x000000018016E980
		[Tooltip] // 0x000000018016E920-0x000000018016E980
		private ButtonUpEventHandler _onButtonUp; // 0x1D0
		private Dictionary<int, PointerEventData> jYkJWWoFPivcEUzseannefjOlcc; // 0x1D8
	
		// Properties
		public CustomControllerElementTargetSetForFloat targetCustomControllerElement { get; } // 0x00000001803BD350-0x00000001803BD360 
		public ButtonType buttonType { get; set; } // 0x00000001810E21D0-0x00000001810E21E0 0x0000000181441FB0-0x0000000181441FD0
		public bool activateOnSwipeIn { get; set; } // 0x00000001814415F0-0x0000000181441600 0x0000000181441ED0-0x0000000181441EF0
		public bool stayActiveOnSwipeOut { get; set; } // 0x00000001814416C0-0x0000000181441750 0x0000000181442310-0x0000000181442360
		public bool useDigitalAxisSimulation { get; set; } // 0x0000000181441750-0x0000000181441760 0x0000000181442400-0x0000000181442460
		public float digitalAxisGravity { get; set; } // 0x0000000181441620-0x0000000181441630 0x0000000181441FD0-0x0000000181442040
		public float digitalAxisSensitivity { get; set; } // 0x0000000181441630-0x0000000181441640 0x0000000181442040-0x0000000181442070
		public TouchRegion touchRegion { get; set; } // 0x00000001803BD360-0x00000001803BD370 0x0000000181442360-0x0000000181442400
		public bool useTouchRegionOnly { get; set; } // 0x000000018081DD30-0x000000018081DD40 0x0000000181442460-0x0000000181442490
		public bool moveToTouchPosition { get; set; } // 0x0000000181441670-0x0000000181441680 0x0000000181442180-0x00000001814421A0
		public bool returnOnRelease { get; set; } // 0x00000001814416A0-0x00000001814416B0 0x0000000181442230-0x0000000181442270
		public bool followTouchPosition { get; set; } // 0x0000000181441640-0x0000000181441650 0x0000000181442070-0x00000001814420A0
		public bool animateOnMoveToTouch { get; set; } // 0x0000000181441600-0x0000000181441610 0x0000000181441EF0-0x0000000181441F50
		public float moveToTouchSpeed { get; set; } // 0x0000000181441680-0x0000000181441690 0x00000001814421A0-0x0000000181442220
		public bool animateOnReturn { get; set; } // 0x0000000181441610-0x0000000181441620 0x0000000181441F50-0x0000000181441FB0
		public float returnSpeed { get; set; } // 0x00000001814416B0-0x00000001814416C0 0x0000000181442270-0x0000000181442310
		public bool manageRaycasting { get; set; } // 0x0000000181441660-0x0000000181441670 0x00000001814420A0-0x0000000181442180
		public int pointerId { get; set; } // 0x0000000181441690-0x00000001814416A0 0x0000000181442220-0x0000000181442230
		public bool hasPointer { get; } // 0x0000000181441650-0x0000000181441660 
		internal StandaloneAxis axis { get; } // 0x00000001803BD3E0-0x00000001803BD3F0 
		private Action<nmJOdZmANObDJaNczzHbyFiChru> moveStartedDelegate { get; } // 0x000000018143E650-0x000000018143E6D0 
		private Action<nmJOdZmANObDJaNczzHbyFiChru> moveEndedDelegate { get; } // 0x0000000181441BD0-0x0000000181441C50 
		private float axisValue { get; } // 0x000000018143CA40-0x000000018143CA80 
		private float axisValuePrev { get; } // 0x0000000181441E90-0x0000000181441ED0 
		private bool buttonValue { get; } // 0x000000018143C9A0-0x000000018143C9D0 
		private bool buttonValuePrev { get; } // 0x000000018143E330-0x000000018143E360 
		private int effectivePointerId { get; } // 0x0000000181441CE0-0x0000000181441D10 
	
		// Events
		public event UnityAction<float> AxisValueChangedEvent {
			add; // 0x00000001814403D0-0x0000000181440430
			remove; // 0x0000000181441D70-0x0000000181441DD0
		}
		public event UnityAction<bool> ButtonValueChangedEvent {
			add; // 0x0000000181440490-0x00000001814404F0
			remove; // 0x0000000181441E30-0x0000000181441E90
		}
		public event UnityAction ButtonDownEvent {
			add; // 0x0000000181440430-0x0000000181440460
			remove; // 0x0000000181441DD0-0x0000000181441E00
		}
		public event UnityAction ButtonUpEvent {
			add; // 0x0000000181440460-0x0000000181440490
			remove; // 0x0000000181441E00-0x0000000181441E30
		}
	
		// Nested types
		public enum ButtonType // TypeDefIndex: 5846
		{
			Standard = 0,
			ToggleSwitch = 1
		}
	
		private enum nmJOdZmANObDJaNczzHbyFiChru // TypeDefIndex: 5847
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
			mECSSpoPNQyVKtfFebLkjUXhvjOu = 1,
			PRJNKxHAbZjpzWKQNbgkjaPwroE = 2
		}
	
		private enum dxNLfNtXMVHVLbHogBSUeLBVzVc // TypeDefIndex: 5848
		{
			IjuFlluoMybUtpSqFtBQAlMgUyR = 0,
			gNafaKVthTKHmnfzOTdmjsbShkI = 1
		}
	
		[Serializable]
		public class AxisValueChangedEventHandler : UnityEvent<float> // TypeDefIndex: 5849
		{
			// Constructors
			public AxisValueChangedEventHandler(); // 0x0000000181905E50-0x0000000181905E90
		}
	
		[Serializable]
		public class ButtonValueChangedEventHandler : UnityEvent<bool> // TypeDefIndex: 5850
		{
			// Constructors
			public ButtonValueChangedEventHandler(); // 0x0000000181905F10-0x0000000181905F50
		}
	
		[Serializable]
		public class ButtonDownEventHandler : UnityEvent // TypeDefIndex: 5851
		{
			// Constructors
			public ButtonDownEventHandler(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
		}
	
		[Serializable]
		public class ButtonUpEventHandler : UnityEvent // TypeDefIndex: 5852
		{
			// Constructors
			public ButtonUpEventHandler(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class lahBkZkuzGVbpLWkekNWgEnDeZd : IEnumerator<object> // TypeDefIndex: 5853
		{
			// Fields
			private object aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			public TouchButton gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public Vector2 erbciXuQzvXBDMaFjGkagbhOrZjH; // 0x28
			public PositionType gsIBthPMxNSjTSPdlhOsjYocNQz; // 0x30
			public float zIXUTQwEaFVKXvZqArCygkLbdpS; // 0x34
			public nmJOdZmANObDJaNczzHbyFiChru TDpRDgoLGUwPwbAPrEacJremjSL; // 0x38
			public RectTransform WtbrkPIYgmNbaIIdBixLaxUYXHM; // 0x40
			public Vector2 vjfjTqLzPfNFLdzitHirfUMiisA; // 0x48
			public float owUXTtTGwMxXVAIdOeWwRpqpNlZ; // 0x50
			public float PHdIVbYYdWRIsBIJgzEYyaAzjiB; // 0x54
			public float VQXGgbhdrmwUgRsbKgqIlusssgN; // 0x58
	
			// Properties
			object QGqPetJmjramAjqiOgIAXgxEFKEb { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public lahBkZkuzGVbpLWkekNWgEnDeZd(int <>1__state); // 0x0000000181446CC0-0x0000000181446CF0
	
			// Methods
			private bool MoveNext(); // 0x0000000181922E80-0x0000000181923290
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181923290-0x00000001819232E0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private TouchButton(); // 0x00000001814401C0-0x00000001814403D0
	
		// Methods
		public void SetRawValue(float value); // 0x000000018143F9B0-0x000000018143F9E0
		public void SetDefaultPosition(); // 0x000000018143F950-0x000000018143F9B0
		private void dTXVOGLPClUVVAAKVYflcVbiQsm(Vector2 param_0000c7d6); // 0x0000000181440AF0-0x0000000181440B00
		public void ReturnToDefaultPosition(bool instant); // 0x000000018143F7A0-0x000000018143F810
		public void ReturnToDefaultPosition(); // 0x000000018143F740-0x000000018143F7A0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void Awake(); // 0x000000018143C9D0-0x000000018143CA40
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnEnable(); // 0x000000018143EA40-0x000000018143EA70
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnDisable(); // 0x000000018143EA00-0x000000018143EA40
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnValidate(); // 0x000000018143F6E0-0x000000018143F710
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void Reset(); // 0x000000018143F710-0x000000018143F740
		internal override void OnUpdate(); // 0x000000018143F5E0-0x000000018143F6E0
		internal override bool OnInitialize(); // 0x000000018143EA70-0x000000018143EA90
		internal override void OnCustomControllerUpdate(); // 0x000000018143E930-0x000000018143EA00
		internal override void OnSubscribeEvents(); // 0x000000018143F0D0-0x000000018143F340
		internal override void OnUnsubscribeEvents(); // 0x000000018143F340-0x000000018143F5E0
		internal override void OnSetProperty(); // 0x000000018143F0A0-0x000000018143F0D0
		internal override void OnClear(); // 0x000000018143E790-0x000000018143E930
		public override void ClearValue(); // 0x000000018143CB00-0x000000018143CBD0
		internal override bool IsPressed(); // 0x000000018143D8D0-0x000000018143D9A0
		internal override bool IsThisOrTouchRegionGameObject(GameObject gameObject); // 0x000000018143D9A0-0x000000018143DAC0
		private void ZjUXNsmnJYWgFlMpjfaunoDKiZE(); // 0x0000000181440130-0x00000001814401C0
		private void vPspgCbeFlfQBjJzbhuEPiZuKGM(); // 0x00000001814427E0-0x00000001814428D0
		private void DPDaylhiQRFCvpaPMiWJpjsYBOaI(); // 0x000000018143CBD0-0x000000018143CD50
		private void lctSXJgIugjfPOOJMCDygMNeadYf(float param_0000c7d9, bool param_0000c7da); // 0x0000000181441AC0-0x0000000181441BD0
		private void UpKMnFZLnjaykwjUUlIAGqWLQIc(); // 0x000000018143FBB0-0x000000018143FD30
		private void WhBGgLQWYVaCbYVsfAeFInkuPvfE(); // 0x000000018143FEF0-0x000000018143FF80
		private new void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x000000018143DAC0-0x000000018143DB60
		private void NKNlCydnlBXQIccJquXuGYsvTVq(); // 0x000000018143E5E0-0x000000018143E650
		private bool jhXSzEmmmcbBXISYrRykAelTKSy(); // 0x0000000181441A30-0x0000000181441AC0
		private void WJRFWQuAuTbmrIPDuIrBAMWNGJy(TouchRegion param_0000c7db); // 0x000000018143FD30-0x000000018143FEF0
		private void YqUIagmZmDqhZOmwzYYjTAKNMXM(TouchRegion param_0000c7dc); // 0x000000018143FF80-0x0000000181440130
		private void dolfYmltAUQEwCZveRlESRdKGhK(); // 0x0000000181440BA0-0x0000000181440DE0
		private void EJfFBWkyvJGCMjDZNhsCIYvpicRr(Vector2 param_0000c7dd, bool param_0000c7de, float param_0000c7df, nmJOdZmANObDJaNczzHbyFiChru param_0000c7e0); // 0x000000018143CDC0-0x000000018143CFB0
		private void ETDmhjkAFEjajzDWGdMEpMSELEy(Vector2 param_0000c7e1, PositionType param_0000c7e2, bool param_0000c7e3, float param_0000c7e4, nmJOdZmANObDJaNczzHbyFiChru param_0000c7e5); // 0x000000018143CFB0-0x000000018143D7A0
		private IEnumerator MOcSsANHfuirGhceqnWqTPXDixq(Vector2 param_0000c7e6, PositionType param_0000c7e7, float param_0000c7e8, nmJOdZmANObDJaNczzHbyFiChru param_0000c7e9); // 0x000000018143E360-0x000000018143E410
		private void ipDAEIEeQzEPxaXwvPCRTSQaTzs(nmJOdZmANObDJaNczzHbyFiChru param_0000c7ea, Vector2 param_0000c7eb, PositionType param_0000c7ec); // 0x0000000181441860-0x0000000181441A30
		private void eVfAjyGWfOpyeqSVAiMULCjiULEV(nmJOdZmANObDJaNczzHbyFiChru param_0000c7ed); // 0x0000000181441110-0x0000000181441360
		private void zSKRLImfJTUTUZRnAFIzkXGPEHJ(nmJOdZmANObDJaNczzHbyFiChru param_0000c7ee); // 0x0000000181442990-0x0000000181442C20
		private void hYTALhDtqSGyQwuWJydLApykXsV(int param_0000c7ef); // 0x0000000181441760-0x0000000181441860
		private void CThRbRrJcLCZffvskgRNVWKvuHvv(); // 0x000000018143CA80-0x000000018143CB00
		private void MsGuhXEMmfanqTAvXbqFjDUICT(); // 0x000000018143E410-0x000000018143E5E0
		private bool oXEQziPQfUdlQaIpThRiZSJBOXU(); // 0x0000000181441C50-0x0000000181441CE0
		private void OZFNDbURhVZKFtFmWGnJgPfugYpe(); // 0x000000018143E770-0x000000018143E790
		private bool dhOQlLJinYpERxCGGhjOgbBZapAV(int param_0000c7f0); // 0x0000000181440B00-0x0000000181440BA0
		private PointerEventData LlGMCNteBCahnPiqWbTrHoAGivp(int param_0000c7f1, GameObject param_0000c7f2); // 0x000000018143DB60-0x000000018143E330
		private PointerEventData AMQXfcKdkhATGEHBZPeTJWJpfSUA(int param_0000c7f3); // 0x000000018143C790-0x000000018143C9A0
		private void cuuvieNpgXrCVXOlgxCyYFCjPIj(PointerEventData param_0000c7f4); // 0x0000000181440A80-0x0000000181440AF0
		private PointerEventData gEzDDiQGlFHTAMAVPqWluKHtuyP(int param_0000c7f5); // 0x0000000181441360-0x00000001814415F0
		private void RxEZUnGIHFENEtIpjktQHvdabdW(PointerEventData param_0000c7f6, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000c7f7); // 0x000000018143F810-0x000000018143F950
		private void uyQABlNHvFbAnbhXXlzvvLWQhYr(PointerEventData param_0000c7f8, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000c7f9); // 0x0000000181442550-0x0000000181442680
		private void cMtnsaxGhUfiDcRwjkYxflgBASiH(PointerEventData param_0000c7fa, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000c7fb); // 0x00000001814404F0-0x0000000181440A80
		private void EzJjjNAhQSmydhBVfCMGbRhVYoAK(PointerEventData param_0000c7fc, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000c7fd); // 0x000000018143D7A0-0x000000018143D890
		private void eCctVKDNgyQGyeaOcqjOyVlLJqO(int param_0000c7fe, Vector2 param_0000c7ff, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000c800); // 0x0000000181440EA0-0x0000000181441110
		private void vFVybIPqofnIcLfQTuNwraHYvlu(); // 0x0000000181442680-0x00000001814427E0
		internal override void OnPointerDown(PointerEventData eventData); // 0x000000018143EA90-0x000000018143ED50
		internal override void OnPointerUp(PointerEventData eventData); // 0x000000018143EFB0-0x000000018143F0A0
		internal override void OnPointerEnter(PointerEventData eventData); // 0x000000018143ED50-0x000000018143EE40
		internal override void OnPointerExit(PointerEventData eventData); // 0x000000018143EE40-0x000000018143EFB0
		private void UNbcuuayGpcyfmiBZBuudIKuPfc(PointerEventData param_0000c805); // 0x000000018143F9E0-0x000000018143FBB0
		private void dqhSGzzGTuUAkDceFrBwijGXgMqA(PointerEventData param_0000c806); // 0x0000000181440DE0-0x0000000181440EA0
		private void tXfPLNiZkWIqEpphZBMXLxItsJO(PointerEventData param_0000c807); // 0x0000000181442490-0x0000000181442550
		private void wRoAvqliQBrNDpVMGkCGlhCaNXc(PointerEventData param_0000c808); // 0x00000001814428D0-0x0000000181442990
		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(float param_0000c809); // 0x000000018143E6D0-0x000000018143E770
		private void DgbjMpJNXwVefEGkIZGgDiwZdZOd(bool param_0000c80a); // 0x000000018143CD50-0x000000018143CDC0
		private void IWFYBZFzWNTQXbIgUrIKvgoPPSA(); // 0x000000018143D890-0x000000018143D8D0
		private void rTmCbedKMmviQXkEYfJeKDiyJleM(); // 0x0000000181441D10-0x0000000181441D70
	}
}
