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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000180207D20-0x0000000180207D60
	[DisallowMultipleComponent] // 0x0000000180207D20-0x0000000180207D60
	public sealed class TouchButton : TouchInteractable // TypeDefIndex: 6004
	{
		// Fields
		private const float bIrMhBPndqbqBcilJMwjpMxegcN = 20f; // Metadata: 0x00763975
		[CustomObfuscation] // 0x0000000180207F10-0x0000000180207F70
		[SerializeField] // 0x0000000180207F10-0x0000000180207F70
		[Tooltip] // 0x0000000180207F10-0x0000000180207F70
		private CustomControllerElementTargetSetForFloat _targetCustomControllerElement; // 0x128
		[CustomObfuscation] // 0x00000001802082A0-0x0000000180208300
		[SerializeField] // 0x00000001802082A0-0x0000000180208300
		[Tooltip] // 0x00000001802082A0-0x0000000180208300
		private ButtonType _buttonType; // 0x130
		[CustomObfuscation] // 0x00000001802085E0-0x0000000180208640
		[SerializeField] // 0x00000001802085E0-0x0000000180208640
		[Tooltip] // 0x00000001802085E0-0x0000000180208640
		private bool _activateOnSwipeIn; // 0x134
		[CustomObfuscation] // 0x00000001802089A0-0x0000000180208A00
		[SerializeField] // 0x00000001802089A0-0x0000000180208A00
		[Tooltip] // 0x00000001802089A0-0x0000000180208A00
		private bool _stayActiveOnSwipeOut; // 0x135
		[CustomObfuscation] // 0x0000000180208DD0-0x0000000180208E30
		[SerializeField] // 0x0000000180208DD0-0x0000000180208E30
		[Tooltip] // 0x0000000180208DD0-0x0000000180208E30
		private bool _useDigitalAxisSimulation; // 0x136
		[CustomObfuscation] // 0x0000000180209010-0x0000000180209090
		[FieldRange] // 0x0000000180209010-0x0000000180209090
		[SerializeField] // 0x0000000180209010-0x0000000180209090
		[Tooltip] // 0x0000000180209010-0x0000000180209090
		private float _digitalAxisGravity; // 0x138
		[CustomObfuscation] // 0x00000001802093C0-0x0000000180209440
		[FieldRange] // 0x00000001802093C0-0x0000000180209440
		[SerializeField] // 0x00000001802093C0-0x0000000180209440
		[Tooltip] // 0x00000001802093C0-0x0000000180209440
		private float _digitalAxisSensitivity; // 0x13C
		[CustomObfuscation] // 0x0000000180209860-0x00000001802098C0
		[SerializeField] // 0x0000000180209860-0x00000001802098C0
		[Tooltip] // 0x0000000180209860-0x00000001802098C0
		private StandaloneAxis _axis; // 0x140
		[CustomObfuscation] // 0x0000000180209B20-0x0000000180209B80
		[SerializeField] // 0x0000000180209B20-0x0000000180209B80
		[Tooltip] // 0x0000000180209B20-0x0000000180209B80
		private TouchRegion _touchRegion; // 0x148
		[CustomObfuscation] // 0x0000000180209DC0-0x0000000180209E20
		[SerializeField] // 0x0000000180209DC0-0x0000000180209E20
		[Tooltip] // 0x0000000180209DC0-0x0000000180209E20
		private bool _useTouchRegionOnly; // 0x150
		[CustomObfuscation] // 0x000000018020A140-0x000000018020A1A0
		[SerializeField] // 0x000000018020A140-0x000000018020A1A0
		[Tooltip] // 0x000000018020A140-0x000000018020A1A0
		private bool _moveToTouchPosition; // 0x151
		[CustomObfuscation] // 0x000000018020A410-0x000000018020A470
		[SerializeField] // 0x000000018020A410-0x000000018020A470
		[Tooltip] // 0x000000018020A410-0x000000018020A470
		private bool _returnOnRelease; // 0x152
		[CustomObfuscation] // 0x000000018020A760-0x000000018020A7C0
		[SerializeField] // 0x000000018020A760-0x000000018020A7C0
		[Tooltip] // 0x000000018020A760-0x000000018020A7C0
		private bool _followTouchPosition; // 0x153
		[CustomObfuscation] // 0x000000018020A960-0x000000018020A9C0
		[SerializeField] // 0x000000018020A960-0x000000018020A9C0
		[Tooltip] // 0x000000018020A960-0x000000018020A9C0
		private bool _animateOnMoveToTouch; // 0x154
		[CustomObfuscation] // 0x000000018020AC20-0x000000018020ACA0
		[Range] // 0x000000018020AC20-0x000000018020ACA0
		[SerializeField] // 0x000000018020AC20-0x000000018020ACA0
		[Tooltip] // 0x000000018020AC20-0x000000018020ACA0
		private float _moveToTouchSpeed; // 0x158
		[CustomObfuscation] // 0x000000018020AFF0-0x000000018020B050
		[SerializeField] // 0x000000018020AFF0-0x000000018020B050
		[Tooltip] // 0x000000018020AFF0-0x000000018020B050
		private bool _animateOnReturn; // 0x15C
		[CustomObfuscation] // 0x000000018020B2F0-0x000000018020B370
		[Range] // 0x000000018020B2F0-0x000000018020B370
		[SerializeField] // 0x000000018020B2F0-0x000000018020B370
		[Tooltip] // 0x000000018020B2F0-0x000000018020B370
		private float _returnSpeed; // 0x160
		[CustomObfuscation] // 0x000000018020B5C0-0x000000018020B620
		[SerializeField] // 0x000000018020B5C0-0x000000018020B620
		[Tooltip] // 0x000000018020B5C0-0x000000018020B620
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
		[CustomObfuscation] // 0x000000018020B7C0-0x000000018020B820
		[SerializeField] // 0x000000018020B7C0-0x000000018020B820
		[Tooltip] // 0x000000018020B7C0-0x000000018020B820
		private AxisValueChangedEventHandler _onAxisValueChanged; // 0x1B8
		[CustomObfuscation] // 0x000000018020BBB0-0x000000018020BC10
		[SerializeField] // 0x000000018020BBB0-0x000000018020BC10
		[Tooltip] // 0x000000018020BBB0-0x000000018020BC10
		private ButtonValueChangedEventHandler _onButtonValueChanged; // 0x1C0
		[CustomObfuscation] // 0x000000018020BDE0-0x000000018020BE40
		[SerializeField] // 0x000000018020BDE0-0x000000018020BE40
		[Tooltip] // 0x000000018020BDE0-0x000000018020BE40
		private ButtonDownEventHandler _onButtonDown; // 0x1C8
		[CustomObfuscation] // 0x000000018020C160-0x000000018020C1C0
		[SerializeField] // 0x000000018020C160-0x000000018020C1C0
		[Tooltip] // 0x000000018020C160-0x000000018020C1C0
		private ButtonUpEventHandler _onButtonUp; // 0x1D0
		private Dictionary<int, PointerEventData> jYkJWWoFPivcEUzseannefjOlcc; // 0x1D8
	
		// Properties
		public CustomControllerElementTargetSetForFloat targetCustomControllerElement { get; } // 0x00000001803EF180-0x00000001803EF190 
		public ButtonType buttonType { get; set; } // 0x000000018091EDF0-0x000000018091EE00 0x000000018091F790-0x000000018091F7B0
		public bool activateOnSwipeIn { get; set; } // 0x000000018091EDC0-0x000000018091EDD0 0x000000018091F6B0-0x000000018091F6D0
		public bool stayActiveOnSwipeOut { get; set; } // 0x000000018091EE90-0x000000018091EF20 0x000000018091FAF0-0x000000018091FB40
		public bool useDigitalAxisSimulation { get; set; } // 0x000000018091EF20-0x000000018091EF30 0x000000018091FBE0-0x000000018091FC40
		public float digitalAxisGravity { get; set; } // 0x000000018091EE00-0x000000018091EE10 0x000000018091F7B0-0x000000018091F820
		public float digitalAxisSensitivity { get; set; } // 0x000000018091EE10-0x000000018091EE20 0x000000018091F820-0x000000018091F850
		public TouchRegion touchRegion { get; set; } // 0x0000000180616920-0x0000000180616930 0x000000018091FB40-0x000000018091FBE0
		public bool useTouchRegionOnly { get; set; } // 0x000000018091EF30-0x000000018091EF40 0x000000018091FC40-0x000000018091FC70
		public bool moveToTouchPosition { get; set; } // 0x000000018091EE50-0x000000018091EE60 0x000000018091F960-0x000000018091F980
		public bool returnOnRelease { get; set; } // 0x000000018091EE70-0x000000018091EE80 0x000000018091FA10-0x000000018091FA50
		public bool followTouchPosition { get; set; } // 0x000000018091EE20-0x000000018091EE30 0x000000018091F850-0x000000018091F880
		public bool animateOnMoveToTouch { get; set; } // 0x000000018091EDD0-0x000000018091EDE0 0x000000018091F6D0-0x000000018091F730
		public float moveToTouchSpeed { get; set; } // 0x000000018058C870-0x000000018058C880 0x000000018091F980-0x000000018091FA00
		public bool animateOnReturn { get; set; } // 0x000000018091EDE0-0x000000018091EDF0 0x000000018091F730-0x000000018091F790
		public float returnSpeed { get; set; } // 0x000000018091EE80-0x000000018091EE90 0x000000018091FA50-0x000000018091FAF0
		public bool manageRaycasting { get; set; } // 0x000000018091EE40-0x000000018091EE50 0x000000018091F880-0x000000018091F960
		public int pointerId { get; set; } // 0x000000018091EE60-0x000000018091EE70 0x000000018091FA00-0x000000018091FA10
		public bool hasPointer { get; } // 0x000000018091EE30-0x000000018091EE40 
		internal StandaloneAxis axis { get; } // 0x00000001803EF170-0x00000001803EF180 
		private Action<nmJOdZmANObDJaNczzHbyFiChru> moveStartedDelegate { get; } // 0x000000018091BEB0-0x000000018091BF30 
		private Action<nmJOdZmANObDJaNczzHbyFiChru> moveEndedDelegate { get; } // 0x000000018091F3B0-0x000000018091F430 
		private float axisValue { get; } // 0x000000018091A2F0-0x000000018091A330 
		private float axisValuePrev { get; } // 0x000000018091F670-0x000000018091F6B0 
		private bool buttonValue { get; } // 0x000000018091A250-0x000000018091A280 
		private bool buttonValuePrev { get; } // 0x000000018091BBA0-0x000000018091BBD0 
		private int effectivePointerId { get; } // 0x000000018091F4C0-0x000000018091F4F0 
	
		// Events
		public event UnityAction<float> AxisValueChangedEvent {
			add; // 0x000000018091DBD0-0x000000018091DC30
			remove; // 0x000000018091F550-0x000000018091F5B0
		}
		public event UnityAction<bool> ButtonValueChangedEvent {
			add; // 0x000000018091DC90-0x000000018091DCF0
			remove; // 0x000000018091F610-0x000000018091F670
		}
		public event UnityAction ButtonDownEvent {
			add; // 0x000000018091DC30-0x000000018091DC60
			remove; // 0x000000018091F5B0-0x000000018091F5E0
		}
		public event UnityAction ButtonUpEvent {
			add; // 0x000000018091DC60-0x000000018091DC90
			remove; // 0x000000018091F5E0-0x000000018091F610
		}
	
		// Nested types
		public enum ButtonType // TypeDefIndex: 6005
		{
			Standard = 0,
			ToggleSwitch = 1
		}
	
		private enum nmJOdZmANObDJaNczzHbyFiChru // TypeDefIndex: 6006
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
			mECSSpoPNQyVKtfFebLkjUXhvjOu = 1,
			PRJNKxHAbZjpzWKQNbgkjaPwroE = 2
		}
	
		private enum dxNLfNtXMVHVLbHogBSUeLBVzVc // TypeDefIndex: 6007
		{
			IjuFlluoMybUtpSqFtBQAlMgUyR = 0,
			gNafaKVthTKHmnfzOTdmjsbShkI = 1
		}
	
		[Serializable]
		public class AxisValueChangedEventHandler : UnityEvent<float> // TypeDefIndex: 6008
		{
			// Constructors
			public AxisValueChangedEventHandler(); // 0x00000001810ABE10-0x00000001810ABE50
		}
	
		[Serializable]
		public class ButtonValueChangedEventHandler : UnityEvent<bool> // TypeDefIndex: 6009
		{
			// Constructors
			public ButtonValueChangedEventHandler(); // 0x00000001810ABED0-0x00000001810ABF10
		}
	
		[Serializable]
		public class ButtonDownEventHandler : UnityEvent // TypeDefIndex: 6010
		{
			// Constructors
			public ButtonDownEventHandler(); // 0x0000000180372000-0x0000000180372010
		}
	
		[Serializable]
		public class ButtonUpEventHandler : UnityEvent // TypeDefIndex: 6011
		{
			// Constructors
			public ButtonUpEventHandler(); // 0x0000000180372000-0x0000000180372010
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class lahBkZkuzGVbpLWkekNWgEnDeZd : IEnumerator<object> // TypeDefIndex: 6012
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
			object QGqPetJmjramAjqiOgIAXgxEFKEb { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public lahBkZkuzGVbpLWkekNWgEnDeZd(int <>1__state); // 0x0000000180924460-0x0000000180924490
	
			// Methods
			private bool MoveNext(); // 0x00000001810C8AA0-0x00000001810C8EB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001810C8EB0-0x00000001810C8F00
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private TouchButton(); // 0x000000018091D9C0-0x000000018091DBD0
	
		// Methods
		public void SetRawValue(float value); // 0x000000018091D1D0-0x000000018091D200
		public void SetDefaultPosition(); // 0x000000018091D170-0x000000018091D1D0
		private void dTXVOGLPClUVVAAKVYflcVbiQsm(Vector2 param_0000ca46); // 0x000000018091E2E0-0x000000018091E2F0
		public void ReturnToDefaultPosition(bool instant); // 0x000000018091CFD0-0x000000018091D040
		public void ReturnToDefaultPosition(); // 0x000000018091CF70-0x000000018091CFD0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void Awake(); // 0x000000018091A280-0x000000018091A2F0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnEnable(); // 0x000000018091C290-0x000000018091C2C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnDisable(); // 0x000000018091C250-0x000000018091C290
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnValidate(); // 0x000000018091CF10-0x000000018091CF40
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void Reset(); // 0x000000018091CF40-0x000000018091CF70
		internal override void OnUpdate(); // 0x000000018091CE10-0x000000018091CF10
		internal override bool OnInitialize(); // 0x000000018091C2C0-0x000000018091C2E0
		internal override void OnCustomControllerUpdate(); // 0x000000018091C190-0x000000018091C250
		internal override void OnSubscribeEvents(); // 0x000000018091C910-0x000000018091CB80
		internal override void OnUnsubscribeEvents(); // 0x000000018091CB80-0x000000018091CE10
		internal override void OnSetProperty(); // 0x000000018091C8E0-0x000000018091C910
		internal override void OnClear(); // 0x000000018091BFF0-0x000000018091C190
		public override void ClearValue(); // 0x000000018091A3B0-0x000000018091A470
		internal override bool IsPressed(); // 0x000000018091B160-0x000000018091B230
		internal override bool IsThisOrTouchRegionGameObject(GameObject gameObject); // 0x000000018091B230-0x000000018091B350
		private void ZjUXNsmnJYWgFlMpjfaunoDKiZE(); // 0x000000018091D930-0x000000018091D9C0
		private void vPspgCbeFlfQBjJzbhuEPiZuKGM(); // 0x000000018091FFC0-0x00000001809200B0
		private void DPDaylhiQRFCvpaPMiWJpjsYBOaI(); // 0x000000018091A470-0x000000018091A5F0
		private void lctSXJgIugjfPOOJMCDygMNeadYf(float param_0000ca49, bool param_0000ca4a); // 0x000000018091F2A0-0x000000018091F3B0
		private void UpKMnFZLnjaykwjUUlIAGqWLQIc(); // 0x000000018091D3C0-0x000000018091D540
		private void WhBGgLQWYVaCbYVsfAeFInkuPvfE(); // 0x000000018091D700-0x000000018091D780
		private new void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x000000018091B350-0x000000018091B3F0
		private void NKNlCydnlBXQIccJquXuGYsvTVq(); // 0x000000018091BE40-0x000000018091BEB0
		private bool jhXSzEmmmcbBXISYrRykAelTKSy(); // 0x000000018091F210-0x000000018091F2A0
		private void WJRFWQuAuTbmrIPDuIrBAMWNGJy(TouchRegion param_0000ca4b); // 0x000000018091D540-0x000000018091D700
		private void YqUIagmZmDqhZOmwzYYjTAKNMXM(TouchRegion param_0000ca4c); // 0x000000018091D780-0x000000018091D930
		private void dolfYmltAUQEwCZveRlESRdKGhK(); // 0x000000018091E390-0x000000018091E5D0
		private void EJfFBWkyvJGCMjDZNhsCIYvpicRr(Vector2 param_0000ca4d, bool param_0000ca4e, float param_0000ca4f, nmJOdZmANObDJaNczzHbyFiChru param_0000ca50); // 0x000000018091A660-0x000000018091A850
		private void ETDmhjkAFEjajzDWGdMEpMSELEy(Vector2 param_0000ca51, PositionType param_0000ca52, bool param_0000ca53, float param_0000ca54, nmJOdZmANObDJaNczzHbyFiChru param_0000ca55); // 0x000000018091A850-0x000000018091B030
		private IEnumerator MOcSsANHfuirGhceqnWqTPXDixq(Vector2 param_0000ca56, PositionType param_0000ca57, float param_0000ca58, nmJOdZmANObDJaNczzHbyFiChru param_0000ca59); // 0x000000018091BBD0-0x000000018091BC80
		private void ipDAEIEeQzEPxaXwvPCRTSQaTzs(nmJOdZmANObDJaNczzHbyFiChru param_0000ca5a, Vector2 param_0000ca5b, PositionType param_0000ca5c); // 0x000000018091F040-0x000000018091F210
		private void eVfAjyGWfOpyeqSVAiMULCjiULEV(nmJOdZmANObDJaNczzHbyFiChru param_0000ca5d); // 0x000000018091E8F0-0x000000018091EB40
		private void zSKRLImfJTUTUZRnAFIzkXGPEHJ(nmJOdZmANObDJaNczzHbyFiChru param_0000ca5e); // 0x0000000180920170-0x0000000180920400
		private void hYTALhDtqSGyQwuWJydLApykXsV(int param_0000ca5f); // 0x000000018091EF40-0x000000018091F040
		private void CThRbRrJcLCZffvskgRNVWKvuHvv(); // 0x000000018091A330-0x000000018091A3B0
		private void MsGuhXEMmfanqTAvXbqFjDUICT(); // 0x000000018091BC80-0x000000018091BE40
		private bool oXEQziPQfUdlQaIpThRiZSJBOXU(); // 0x000000018091F430-0x000000018091F4C0
		private void OZFNDbURhVZKFtFmWGnJgPfugYpe(); // 0x000000018091BFD0-0x000000018091BFF0
		private bool dhOQlLJinYpERxCGGhjOgbBZapAV(int param_0000ca60); // 0x000000018091E2F0-0x000000018091E390
		private PointerEventData LlGMCNteBCahnPiqWbTrHoAGivp(int param_0000ca61, GameObject param_0000ca62); // 0x000000018091B3F0-0x000000018091BBA0
		private PointerEventData AMQXfcKdkhATGEHBZPeTJWJpfSUA(int param_0000ca63); // 0x000000018091A040-0x000000018091A250
		private void cuuvieNpgXrCVXOlgxCyYFCjPIj(PointerEventData param_0000ca64); // 0x000000018091E270-0x000000018091E2E0
		private PointerEventData gEzDDiQGlFHTAMAVPqWluKHtuyP(int param_0000ca65); // 0x000000018091EB40-0x000000018091EDC0
		private void RxEZUnGIHFENEtIpjktQHvdabdW(PointerEventData param_0000ca66, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000ca67); // 0x000000018091D040-0x000000018091D170
		private void uyQABlNHvFbAnbhXXlzvvLWQhYr(PointerEventData param_0000ca68, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000ca69); // 0x000000018091FD30-0x000000018091FE60
		private void cMtnsaxGhUfiDcRwjkYxflgBASiH(PointerEventData param_0000ca6a, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000ca6b); // 0x000000018091DCF0-0x000000018091E270
		private void EzJjjNAhQSmydhBVfCMGbRhVYoAK(PointerEventData param_0000ca6c, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000ca6d); // 0x000000018091B030-0x000000018091B120
		private void eCctVKDNgyQGyeaOcqjOyVlLJqO(int param_0000ca6e, Vector2 param_0000ca6f, dxNLfNtXMVHVLbHogBSUeLBVzVc param_0000ca70); // 0x000000018091E690-0x000000018091E8F0
		private void vFVybIPqofnIcLfQTuNwraHYvlu(); // 0x000000018091FE60-0x000000018091FFC0
		internal override void OnPointerDown(PointerEventData eventData); // 0x000000018091C2E0-0x000000018091C590
		internal override void OnPointerUp(PointerEventData eventData); // 0x000000018091C7F0-0x000000018091C8E0
		internal override void OnPointerEnter(PointerEventData eventData); // 0x000000018091C590-0x000000018091C680
		internal override void OnPointerExit(PointerEventData eventData); // 0x000000018091C680-0x000000018091C7F0
		private void UNbcuuayGpcyfmiBZBuudIKuPfc(PointerEventData param_0000ca75); // 0x000000018091D200-0x000000018091D3C0
		private void dqhSGzzGTuUAkDceFrBwijGXgMqA(PointerEventData param_0000ca76); // 0x000000018091E5D0-0x000000018091E690
		private void tXfPLNiZkWIqEpphZBMXLxItsJO(PointerEventData param_0000ca77); // 0x000000018091FC70-0x000000018091FD30
		private void wRoAvqliQBrNDpVMGkCGlhCaNXc(PointerEventData param_0000ca78); // 0x00000001809200B0-0x0000000180920170
		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(float param_0000ca79); // 0x000000018091BF30-0x000000018091BFD0
		private void DgbjMpJNXwVefEGkIZGgDiwZdZOd(bool param_0000ca7a); // 0x000000018091A5F0-0x000000018091A660
		private void IWFYBZFzWNTQXbIgUrIKvgoPPSA(); // 0x000000018091B120-0x000000018091B160
		private void rTmCbedKMmviQXkEYfJeKDiyJleM(); // 0x000000018091F4F0-0x000000018091F550
	}
}
