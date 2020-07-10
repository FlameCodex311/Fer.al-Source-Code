/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using DG.Tweening.Core;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SimpleWeatherSystem : ManagedBehaviour // TypeDefIndex: 12714
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static SimpleWeatherSystem <instance>k__BackingField; // 0x00
	public Renderer skybox; // 0x50
	public Renderer skyboxBottom; // 0x58
	public Renderer cloudLayer1; // 0x60
	public Renderer cloudLayer2; // 0x68
	public Renderer backgroundObj; // 0x70
	public Light mainSceneLight; // 0x78
	[EnumList] // 0x0000000180115B30-0x0000000180115BA0
	[Space] // 0x0000000180115B30-0x0000000180115BA0
	public List<WeatherData> weatherData; // 0x80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private WeatherState <currentWeather>k__BackingField; // 0x88
	private Material _skyboxMaterial; // 0x90
	private Material _skyboxBottomMaterial; // 0x98
	private Material _cloudLayer1Material; // 0xA0
	private Material _cloudLayer2Material; // 0xA8
	private Material _backgroundObjMaterial; // 0xB0
	private bool _activeSceneSet; // 0xB8

	// Properties
	public static SimpleWeatherSystem instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181357D60-0x0000000181357DA0 0x0000000181357DA0-0x0000000181357DE0
	public WeatherState currentWeather { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018049D3B0-0x000000018049D3C0 0x000000018049D3C0-0x000000018049D3D0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForScene>d__24 : IEnumerator<object> // TypeDefIndex: 12715
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SimpleWeatherSystem <>4__this; // 0x20
		public Action inCallback; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForScene>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181360AF0-0x0000000181360BF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181360BF0-0x0000000181360C40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 12716
	{
		// Fields
		public SkyboxColorInfo skyboxColors; // 0x10

		// Constructors
		public <>c__DisplayClass28_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <UpdateSkyboxColors>b__0(); // 0x00000001813604D0-0x00000001813609D0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12717
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static DOGetter<Color> <>9__28_1; // 0x08
		public static DOSetter<Color> <>9__28_2; // 0x10
		public static DOGetter<float> <>9__28_3; // 0x18
		public static DOSetter<float> <>9__28_4; // 0x20
		public static DOGetter<float> <>9__28_5; // 0x28
		public static DOSetter<float> <>9__28_6; // 0x30

		// Constructors
		static <>c(); // 0x00000001813609D0-0x0000000181360A30
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal Color <UpdateSkyboxColors>b__28_1(); // 0x0000000181166CB0-0x0000000181166CE0
		internal void <UpdateSkyboxColors>b__28_2(Color x); // 0x0000000181166CE0-0x0000000181166D00
		internal float <UpdateSkyboxColors>b__28_3(); // 0x0000000181360440-0x0000000181360450
		internal void <UpdateSkyboxColors>b__28_4(float x); // 0x0000000181360450-0x0000000181360460
		internal float <UpdateSkyboxColors>b__28_5(); // 0x0000000181166D00-0x0000000181166D10
		internal void <UpdateSkyboxColors>b__28_6(float x); // 0x0000000181166D10-0x0000000181166D20
	}

	// Constructors
	public SimpleWeatherSystem(); // 0x0000000181357D00-0x0000000181357D60

	// Methods
	public override void MStart(); // 0x0000000181356E30-0x0000000181356E80
	public override void MOnDestroy(); // 0x0000000181356DF0-0x0000000181356E30
	public override void MUpdate(); // 0x0000000181356E80-0x0000000181356F80
	[IteratorStateMachine] // 0x00000001801179D0-0x0000000180117A20
	private IEnumerator WaitForScene(Action inCallback); // 0x0000000181357C90-0x0000000181357D00
	public void SetWeatherState(WeatherState inState); // 0x0000000181356F80-0x0000000181357190
	private void UpdateGameObjectRefs(WeatherData inData, bool inEnabled); // 0x0000000181357520-0x0000000181357750
	private void StopCurrentWeatherFx(); // 0x0000000181357350-0x0000000181357520
	private void UpdateSkyboxColors(SkyboxColorInfo skyboxColors); // 0x0000000181357750-0x0000000181357C90
	private void SetupSkyboxMaterials(); // 0x0000000181357190-0x0000000181357350
	[DeMethodButton] // 0x0000000180117C30-0x0000000180117C90
	private void ChangeWeatherNow(); // 0x0000000181356DD0-0x0000000181356DF0
	private void PickNextWeatherState(); // 0x0000000181356DD0-0x0000000181356DF0
}

