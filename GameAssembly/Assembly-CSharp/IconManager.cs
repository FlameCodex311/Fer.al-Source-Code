/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class IconManager : SingletonManagerBase<IconManager> // TypeDefIndex: 10714
{
	// Fields
	private int _spiralFrameColumn; // 0x60
	private int _spiralFrameRow; // 0x64
	private int _spiralFrameColumnMax; // 0x68
	private int _spiralFrameColumnLastMax; // 0x6C
	private int _spiralFrameRowMax; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Texture2D _spiralTexture; // 0x78
	private float _iconRotationDegrees; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<IconManagerEntry> _iconEntries; // 0x88
	private Stack<int> _freeXPositions; // 0x90

	// Nested types
	private enum IconManagerEntryType // TypeDefIndex: 10715
	{
		Texture = 0,
		Model = 1
	}

	[Serializable]
	private class IconManagerEntry // TypeDefIndex: 10716
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 10717
		{
			// Fields
			public GameObject spiralImageGO; // 0x10

			// Constructors
			public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <StopSpiralTexture>b__0(); // 0x0000000180F700B0-0x0000000180F70140
		}

		// Constructors
		public IconManagerEntry(RawImage inOwnerImage, Icon3DAnimationType inAnimationType); // 0x0000000180F58E00-0x0000000180F58EB0

		// Methods
		public void CreateSpiralTexture(Texture2D inSpiralTexture, int inFrameColumn, int inFrameRow, int inFrameColumnMax); // 0x0000000180F573E0-0x0000000180F578B0
		public void UpdateSpiralTexture(int inFrameColumn, int inFrameRow, int inFrameColumnMax); // 0x0000000180F58D70-0x0000000180F58E00
		public void StopSpiralTexture(); // 0x0000000180F58BF0-0x0000000180F58D70
		public void FadeInOwnerImage(); // 0x0000000180F57AC0-0x0000000180F57B80
		public void SetIconTexture(Texture2D inTexture); // 0x0000000180F58AF0-0x0000000180F58BF0
		public void SetIconModel(GameObject inGameObject, Icon3DDefComponent inIconDefComponent, Stack<int> inFreeXPositions, Icon3DTextureSize inIcon3DTextureSize = Icon3DTextureSize.Medium /* Metadata: 0x00781F8A */, List<string> inFocusNames = null); // 0x0000000180F58100-0x0000000180F58AF0
		public void RenderModel(bool inFocus = true /* Metadata: 0x00781F8E */, bool inSetRotation = true /* Metadata: 0x00781F8F */); // 0x0000000180F57B80-0x0000000180F58100
		public void Destroy(Stack<int> inFreeXPositions); // 0x0000000180F578B0-0x0000000180F57AC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 10718
	{
		// Fields
		public IconManagerEntry inEntry; // 0x10
		public Item inItem; // 0x18
		public Action inFailureCallback; // 0x20

		// Constructors
		public <>c__DisplayClass14_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Assign2DIconToRawImage>b__0(Texture2D inTexture); // 0x0000000180F6F5A0-0x0000000180F6F7A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 10719
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
		public <>c__DisplayClass15_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Assign3DIconToRawImage>b__0(GameObject inGameObject); // 0x0000000180F6F7A0-0x0000000180F6FDB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 10720
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
		public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <AssignIconToRawImage>b__0(IconManagerEntry entry); // 0x0000000180F6FE70-0x0000000180F6FF10
		internal void <AssignIconToRawImage>b__1(); // 0x0000000180F6FF10-0x0000000180F6FF70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 10721
	{
		// Fields
		public RawImage inImage; // 0x10

		// Constructors
		public <>c__DisplayClass17_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <ReleaseIconFromRawImage>b__0(IconManagerEntry item); // 0x0000000180F6FF70-0x0000000180F70010
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 10722
	{
		// Fields
		public RawImage inImage; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <RefreshIconFromRawImage>b__0(IconManagerEntry item); // 0x0000000180F70010-0x0000000180F700B0
	}

	// Constructors
	public IconManager(); // 0x0000000180F5A260-0x0000000180F5A300

	// Methods
	public override void Init(); // 0x0000000180F59B50-0x0000000180F59BD0
	private static Bounds CalculateBounds(GameObject inGameObject, List<string> inFocusNames); // 0x0000000180F596D0-0x0000000180F59B50
	public override void MUpdate(); // 0x0000000180F59BD0-0x0000000180F5A0A0
	private bool Assign2DIconToRawImage(IconManagerEntry inEntry, Item inItem, BaseDef inDef, BaseInfo inInfo, Action inFailureCallback); // 0x0000000180F58EB0-0x0000000180F59020
	private bool Assign3DIconToRawImage(IconManagerEntry inEntry, Item inItem, BaseDef inDef, BaseInfo inInfo, Icon3DTextureSize inIcon3DTextureSize, List<string> inFocusNames, Action inFailureCallback); // 0x0000000180F59020-0x0000000180F592A0
	public void AssignIconToRawImage(Item inItem, BaseDef inDef, BaseInfo inInfo, RawImage inImage, Icon3DTextureSize inIcon3DTextureSize = Icon3DTextureSize.Medium /* Metadata: 0x00781F79 */, Icon3DAnimationType in3DAnimationType = Icon3DAnimationType.Updating /* Metadata: 0x00781F7D */, bool inForce3D = false /* Metadata: 0x00781F81 */, List<string> inFocusNames = null); // 0x0000000180F592A0-0x0000000180F596D0
	public void ReleaseIconFromRawImage(RawImage inImage); // 0x0000000180F5A190-0x0000000180F5A260
	public void RefreshIconFromRawImage(RawImage inImage); // 0x0000000180F5A0B0-0x0000000180F5A180
	private void ReleaseIconEntry(IconManagerEntry inEntry); // 0x0000000180F5A180-0x0000000180F5A190
	private void RefreshIconEntry(IconManagerEntry inEntry); // 0x0000000180F5A0A0-0x0000000180F5A0B0
}

