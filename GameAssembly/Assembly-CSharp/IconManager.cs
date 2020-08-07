/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class IconManager : SingletonManagerBase<IconManager> // TypeDefIndex: 12222
{
	// Fields
	private int _spiralFrameColumn; // 0x60
	private int _spiralFrameRow; // 0x64
	private int _spiralFrameColumnMax; // 0x68
	private int _spiralFrameColumnLastMax; // 0x6C
	private int _spiralFrameRowMax; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Texture2D _spiralTexture; // 0x78
	private float _iconRotationDegrees; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<IconManagerEntry> _iconEntries; // 0x88
	private Stack<int> _freeXPositions; // 0x90

	// Nested types
	private enum IconManagerEntryType // TypeDefIndex: 12223
	{
		Texture = 0,
		Model = 1
	}

	[Serializable]
	private class IconManagerEntry // TypeDefIndex: 12224
	{
		// Fields
		public IconManagerEntryType entryType; // 0x10
		public bool refresh; // 0x14
		public bool released; // 0x15
		public RawImage ownerImage; // 0x18
		public RawImage spiralImage; // 0x20
		public QRoutine downloadRoutine; // 0x28
		public bool finishedDownloadAndSetup; // 0x30
		public Texture2D iconTexture; // 0x38
		public Icon3DAnimationType animationType; // 0x40
		public GameObject iconParent; // 0x48
		public GameObject iconObject; // 0x50
		public UI_SpinWithMouse iconSpinWithMouse; // 0x58
		public Icon3DDefComponent icon3DDefComponent; // 0x60
		public Camera iconObjectRenderCamera; // 0x68
		public RenderTexture iconObjectRenderTex; // 0x70
		public int iconXPosition; // 0x78
		public List<string> iconObjectCameraFocusNames; // 0x80

		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 12225
		{
			// Fields
			public GameObject spiralImageGO; // 0x10

			// Constructors
			public <>c__DisplayClass20_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <StopSpiralTexture>b__0(); // 0x00000001806312F0-0x0000000180631380
		}

		// Constructors
		public IconManagerEntry(RawImage inOwnerImage, Icon3DAnimationType inAnimationType); // 0x0000000180622160-0x0000000180622210

		// Methods
		public void CreateSpiralTexture(Texture2D inSpiralTexture, int inFrameColumn, int inFrameRow, int inFrameColumnMax); // 0x0000000180620720-0x0000000180620BD0
		public void UpdateSpiralTexture(int inFrameColumn, int inFrameRow, int inFrameColumnMax); // 0x00000001806220D0-0x0000000180622160
		public void StopSpiralTexture(); // 0x0000000180621F60-0x00000001806220D0
		public void FadeInOwnerImage(); // 0x0000000180620DD0-0x0000000180620E90
		public void SetIconTexture(Texture2D inTexture); // 0x0000000180621E60-0x0000000180621F60
		public void SetIconModel(GameObject inGameObject, Icon3DDefComponent inIconDefComponent, Stack<int> inFreeXPositions, Icon3DTextureSize inIcon3DTextureSize = Icon3DTextureSize.Medium /* Metadata: 0x007B9645 */, List<string> inFocusNames = null); // 0x0000000180621400-0x0000000180621E60
		public void RenderModel(bool inFocus = true /* Metadata: 0x007B9649 */, bool inSetRotation = true /* Metadata: 0x007B964A */); // 0x0000000180620E90-0x0000000180621400
		public void Destroy(Stack<int> inFreeXPositions); // 0x0000000180620BD0-0x0000000180620DD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 12226
	{
		// Fields
		public IconManagerEntry inEntry; // 0x10
		public Item inItem; // 0x18
		public Action inFailureCallback; // 0x20

		// Constructors
		public <>c__DisplayClass14_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Assign2DIconToRawImage>b__0(Texture2D inTexture); // 0x00000001806306D0-0x00000001806308C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 12227
	{
		// Fields
		public IconManagerEntry inEntry; // 0x10
		public BaseDef inDef; // 0x18
		public Item inItem; // 0x20
		public BaseInfo inInfo; // 0x28
		public Icon3DDefComponent icon3DDefComponent; // 0x30
		public IconManager <>4__this; // 0x38
		public Icon3DTextureSize inIcon3DTextureSize; // 0x40
		public List<string> inFocusNames; // 0x48
		public Action inFailureCallback; // 0x50

		// Constructors
		public <>c__DisplayClass15_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Assign3DIconToRawImage>b__0(GameObject inGameObject); // 0x00000001806308C0-0x0000000180630EB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 12228
	{
		// Fields
		public RawImage inImage; // 0x10
		public IconManager <>4__this; // 0x18
		public IconManagerEntry nEntry; // 0x20
		public Item inItem; // 0x28
		public BaseDef inDef; // 0x30
		public BaseInfo inInfo; // 0x38
		public Icon3DTextureSize inIcon3DTextureSize; // 0x40
		public List<string> inFocusNames; // 0x48

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <AssignIconToRawImage>b__0(IconManagerEntry entry); // 0x0000000180630F70-0x0000000180631010
		internal void <AssignIconToRawImage>b__1(); // 0x0000000180631010-0x0000000180631070
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 12229
	{
		// Fields
		public RawImage inImage; // 0x10

		// Constructors
		public <>c__DisplayClass17_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <ReleaseIconFromRawImage>b__0(IconManagerEntry item); // 0x0000000180631070-0x0000000180631110
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 12230
	{
		// Fields
		public RawImage inImage; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <RefreshIconFromRawImage>b__0(IconManagerEntry item); // 0x0000000180631110-0x00000001806311B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 12231
	{
		// Fields
		public RawImage inImage; // 0x10

		// Constructors
		public <>c__DisplayClass19_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetIconTargetFromRawImage>b__0(IconManagerEntry item); // 0x00000001806311B0-0x0000000180631250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 12232
	{
		// Fields
		public RawImage inImage; // 0x10

		// Constructors
		public <>c__DisplayClass20_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetRenderCameraFromRawImage>b__0(IconManagerEntry item); // 0x0000000180631250-0x00000001806312F0
	}

	// Constructors
	public IconManager(); // 0x0000000180623730-0x00000001806237D0

	// Methods
	public override void Init(); // 0x0000000180623040-0x00000001806230C0
	private static Bounds CalculateBounds(GameObject inGameObject, List<string> inFocusNames); // 0x0000000180622A20-0x0000000180622E90
	public override void MUpdate(); // 0x00000001806230C0-0x0000000180623590
	private bool Assign2DIconToRawImage(IconManagerEntry inEntry, Item inItem, BaseDef inDef, BaseInfo inInfo, Action inFailureCallback); // 0x0000000180622210-0x0000000180622380
	private bool Assign3DIconToRawImage(IconManagerEntry inEntry, Item inItem, BaseDef inDef, BaseInfo inInfo, Icon3DTextureSize inIcon3DTextureSize, List<string> inFocusNames, Action inFailureCallback); // 0x0000000180622380-0x0000000180622600
	public void AssignIconToRawImage(Item inItem, BaseDef inDef, BaseInfo inInfo, RawImage inImage, Icon3DTextureSize inIcon3DTextureSize = Icon3DTextureSize.Medium /* Metadata: 0x007B9634 */, Icon3DAnimationType in3DAnimationType = Icon3DAnimationType.Updating /* Metadata: 0x007B9638 */, bool inForce3D = false /* Metadata: 0x007B963C */, List<string> inFocusNames = null); // 0x0000000180622600-0x0000000180622A20
	public void ReleaseIconFromRawImage(RawImage inImage); // 0x0000000180623670-0x0000000180623730
	public void RefreshIconFromRawImage(RawImage inImage); // 0x00000001806235A0-0x0000000180623660
	public Transform GetIconTargetFromRawImage(RawImage inImage); // 0x0000000180622E90-0x0000000180622F70
	public Camera GetRenderCameraFromRawImage(RawImage inImage); // 0x0000000180622F70-0x0000000180623040
	private void ReleaseIconEntry(IconManagerEntry inEntry); // 0x0000000180623660-0x0000000180623670
	private void RefreshIconEntry(IconManagerEntry inEntry); // 0x0000000180623590-0x00000001806235A0
}

