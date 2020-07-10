/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ActorInfo : WorldObjectInfo, ISerializationCallbackReceiver // TypeDefIndex: 10885
{
	// Fields
	[ChartDef] // 0x00000001800EF540-0x00000001800EF610
	[Header] // 0x00000001800EF540-0x00000001800EF610
	[Space] // 0x00000001800EF540-0x00000001800EF610
	public string actorClassDefID; // 0x18
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<ActorInfoBodyPart> bodyParts; // 0x20
	public Action<ActorInfoBodyPart> OnBodyPartSet; // 0x28
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _bodyColor1HSV; // 0x30
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _bodyColor2HSV; // 0x68
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _bodyColor3HSV; // 0xA0
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _bodyColor4HSV; // 0xD8
	public Action OnBodyColorChanged; // 0x110
	[ChartDef] // 0x00000001800F1410-0x00000001800F14E0
	[Header] // 0x00000001800F1410-0x00000001800F14E0
	[Space] // 0x00000001800F1410-0x00000001800F14E0
	public string eyeShapeDefID; // 0x118
	[ChartDef] // 0x00000001800F1AE0-0x00000001800F1B80
	public string eyePupilDefID; // 0x120
	private List<BaseDef> _eyeShapeDefs; // 0x128
	private List<BaseDef> _eyePupilDefs; // 0x130
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _eyeShapeColorHSV; // 0x138
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _eyePupilColorHSV; // 0x170
	public Action OnEyeColorChanged; // 0x1A8
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _sparkColor1HSV; // 0x1B0
	public Action OnSparkColorChanged; // 0x1E8
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _hornColor1HSV; // 0x1F0
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _hornColor2HSV; // 0x228
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _hornColor3HSV; // 0x260
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _hornColor4HSV; // 0x298
	public Action OnHornColorChanged; // 0x2D0
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _wingColor1HSV; // 0x2D8
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _wingColor2HSV; // 0x310
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _wingColor3HSV; // 0x348
	[ChartHSV] // 0x00000001800EFB40-0x00000001800EFB70
	[SerializeField] // 0x00000001800EFB40-0x00000001800EFB70
	private HSVColor _wingColor4HSV; // 0x380
	public Action OnWingColorChanged; // 0x3B8
	[ChartFloat] // 0x00000001800B5960-0x00000001800B5970
	public float eyeShapeScale; // 0x3C0
	[ChartFloat] // 0x00000001800B5960-0x00000001800B5970
	public float eyePupilScale; // 0x3C4
	[ChartList] // 0x00000001800F3940-0x00000001800F39A0
	[Header] // 0x00000001800F3940-0x00000001800F39A0
	[Space] // 0x00000001800F3940-0x00000001800F39A0
	public List<ActorInfoClothingItem> clothingItems; // 0x3C8
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool defaultDecalsEnabled; // 0x3D0
	public Action<ActorInfoClothingItem, bool> OnClothingEquip; // 0x3D8
	public Action<ActorInfoDecalEntry> OnDecalAdded; // 0x3E0
	public Action<ActorInfoDecalEntry> OnDecalRemoved; // 0x3E8
	[NonSerialized]
	private ActorClassDefComponent _classDefComponent; // 0x3F0
	[NonSerialized]
	private List<ActorInfoBodyPart> _attachedBodyParts; // 0x3F8
	public List<ActorInfoScaleGroup> scaleGroups; // 0x400
	private Dictionary<string, ActorInfoClothingItem> _attachNodeToClothingItemDict; // 0x408
	private ActorInfoDecalEntry _selectedDecalEntry; // 0x410
	private float _selectedDecalEntryOutlinePulse; // 0x418
	[NonSerialized]
	private bool _isRefreshingDirty; // 0x41C

	// Properties
	public HSVColor BodyColor1HSV { get; set; } // 0x0000000180480410-0x0000000180480440 0x000000018140D7C0-0x000000018140D880
	public HSVColor BodyColor2HSV { get; set; } // 0x000000018140D0F0-0x000000018140D120 0x000000018140D880-0x000000018140D940
	public HSVColor BodyColor3HSV { get; set; } // 0x000000018140D120-0x000000018140D160 0x000000018140D940-0x000000018140DA10
	public HSVColor BodyColor4HSV { get; set; } // 0x000000018140D160-0x000000018140D1A0 0x000000018140DA10-0x000000018140DAE0
	public List<BaseDef> EyeShapeDefs { get; } // 0x000000018140D3E0-0x000000018140D500 
	public List<BaseDef> EyePupilDefs { get; } // 0x000000018140D280-0x000000018140D3A0 
	public HSVColor EyeShapeColorHSV { get; set; } // 0x000000018140D3A0-0x000000018140D3E0 0x000000018140DBB0-0x000000018140DC80
	public HSVColor EyePupilColorHSV { get; set; } // 0x000000018140D240-0x000000018140D280 0x000000018140DAE0-0x000000018140DBB0
	public HSVColor SparkColor1HSV { get; set; } // 0x000000018140D680-0x000000018140D6C0 0x000000018140E010-0x000000018140E0E0
	public HSVColor HornColor1HSV { get; set; } // 0x000000018140D500-0x000000018140D540 0x000000018140DC80-0x000000018140DD50
	public HSVColor HornColor2HSV { get; set; } // 0x000000018140D540-0x000000018140D580 0x000000018140DD50-0x000000018140DE20
	public HSVColor HornColor3HSV { get; set; } // 0x000000018140D580-0x000000018140D5C0 0x000000018140DE20-0x000000018140DEF0
	public HSVColor HornColor4HSV { get; set; } // 0x000000018140D5C0-0x000000018140D600 0x000000018140DEF0-0x000000018140DFC0
	public HSVColor WingColor1HSV { get; set; } // 0x000000018140D6C0-0x000000018140D700 0x000000018140E0E0-0x000000018140E1B0
	public HSVColor WingColor2HSV { get; set; } // 0x000000018140D700-0x000000018140D740 0x000000018140E1B0-0x000000018140E280
	public HSVColor WingColor3HSV { get; set; } // 0x000000018140D740-0x000000018140D780 0x000000018140E280-0x000000018140E350
	public HSVColor WingColor4HSV { get; set; } // 0x000000018140D780-0x000000018140D7C0 0x000000018140E350-0x000000018140E420
	public ActorClassDefComponent ClassDefComponent { get; } // 0x000000018140D1A0-0x000000018140D240 
	public List<ActorInfoBodyPart> AttachedBodyParts { get; } // 0x000000018140CE50-0x000000018140D0F0 
	public bool IsDesignerMode { get; } // 0x00000001803C28F0-0x00000001803C2900 
	public ActorInfoDecalEntry SelectedDecalEntry { get; set; } // 0x000000018140D670-0x000000018140D680 0x000000018140DFF0-0x000000018140E010
	public float SelectedDecalEntryOutlinePulse { get; set; } // 0x000000018140D660-0x000000018140D670 0x000000018140DFD0-0x000000018140DFF0
	public HSVColor SelectedDecalEntryOutlineColor { get; } // 0x000000018140D610-0x000000018140D660 
	public bool IsRefreshingDirty { get; set; } // 0x000000018140D600-0x000000018140D610 0x000000018140DFC0-0x000000018140DFD0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass104_0 // TypeDefIndex: 10886
	{
		// Fields
		public ActorBodyPartDefComponent inPartDefComponent; // 0x10

		// Constructors
		public <>c__DisplayClass104_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SetBodyPart>b__0(ActorInfoBodyPart part); // 0x000000018141C8E0-0x000000018141C930
	}

	// Constructors
	public ActorInfo(); // 0x000000018140C6E0-0x000000018140CE50

	// Methods
	public override void ResetCaches(); // 0x000000018140B250-0x000000018140B270
	public void OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
	public void OnAfterDeserialize(); // 0x0000000181409D90-0x000000018140AA00
	public void RefreshAttachedBodyParts(); // 0x000000018140AA00-0x000000018140AA10
	public ActorInfoScaleGroup GetScaleGroupWithDefID(string inGroupDefID); // 0x00000001814094F0-0x0000000181409690
	public ActorInfoBodyPart GetAttachedBodyPartForNode(BaseDef inNodeDef); // 0x0000000181408FC0-0x0000000181408FF0
	public ActorInfoBodyPart GetAttachedBodyPartForNode(string inNodeDefID); // 0x0000000181408E10-0x0000000181408FC0
	public List<ActorInfoBodyPart> GetBodyPartsForNode(BaseDef inNodeDef); // 0x0000000181409250-0x0000000181409280
	public List<ActorInfoBodyPart> GetBodyPartsForNode(string inNodeDefID); // 0x0000000181408FF0-0x0000000181409250
	public bool IsBodyPartAttached(ActorBodyPartDefComponent inDef); // 0x0000000181409690-0x0000000181409850
	public void SetEyeShape(BaseDef inDecalDef); // 0x000000018140C2E0-0x000000018140C370
	public void SetPupilShape(BaseDef inDecalDef); // 0x000000018140C370-0x000000018140C400
	public void SetEyeShapeScale(float inScale); // 0x000000018140C2C0-0x000000018140C2E0
	public void SetEyePupilScale(float inScale); // 0x000000018140C2A0-0x000000018140C2C0
	public void SetBodyPart(ActorBodyPartDefComponent inPartDefComponent); // 0x000000018140B430-0x000000018140B680
	public bool ClothingItemIsEquipped(Item inItem); // 0x00000001814087C0-0x0000000181408970
	public ValueTuple<ActorInfoClothingItem, List<ActorInfoClothingItem>> AddClothingItem(Item inItem); // 0x00000001814074F0-0x0000000181408180
	public void AddClothingItem(ActorInfoClothingItem inItem); // 0x0000000181408180-0x00000001814082A0
	public void RemoveClothingItem(Item inItem); // 0x000000018140AD10-0x000000018140AE90
	public void RemoveClothingItem(ActorInfoClothingItem inItem); // 0x000000018140AE90-0x000000018140AFA0
	public List<ActorInfoClothingItem> RemoveClothingItemsOnGroup(ActorAttachNodeGroupDefComponent inAttachNodeGroup); // 0x000000018140AFA0-0x000000018140B120
	public void RemoveAllClothingItems(); // 0x000000018140AA10-0x000000018140AB30
	public ActorInfoDecalEntry AddDecal(BaseDef inDecalDef); // 0x00000001814082A0-0x0000000181408630
	public ActorInfoDecalEntry AddDuplicateDecal(ActorInfoDecalEntry inDecalEntry); // 0x0000000181408630-0x00000001814087C0
	public void RemoveAllDecals(); // 0x000000018140AB30-0x000000018140AD10
	public void RemoveDecal(ActorInfoDecalEntry inDecalEntry); // 0x000000018140B120-0x000000018140B250
	public ActorInfoBodyPart GetDecalBodyPart(ActorInfoDecalEntry inDecalEntry); // 0x0000000181409280-0x00000001814094F0
	public void SetDecalShape(BaseDef inDecalDef, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x000000018140BF70-0x000000018140C000
	public void SetDecalPositionFromHit(RaycastHit inHit, RaycastHit? inMirrorHit, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x000000018140BAF0-0x000000018140BDB0
	public void SetDecalRotation(float inDecalRotation, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x000000018140BDB0-0x000000018140BE90
	public void SetDecalColor(HSVColor inDecalColor, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x000000018140B950-0x000000018140BA40
	public void SetDecalScale(float inNormalizedScale, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x000000018140BE90-0x000000018140BF70
	public void SetDecalAlpha(float inAlpha, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x000000018140B680-0x000000018140B750
	public void SetDecalEnabled(bool inEnabled, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x000000018140BA40-0x000000018140BAF0
	public void SetDefaultDecalsEnabled(bool inEnabled); // 0x000000018140C000-0x000000018140C020
	public void FlipDecalX(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x0000000181408C90-0x0000000181408D50
	public void FlipDecalY(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x0000000181408D50-0x0000000181408E10
	public bool DecalIsAtBottomLayer(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x0000000181408970-0x0000000181408B10
	public bool DecalIsAtTopLayer(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x0000000181408B10-0x0000000181408C90
	public void MoveDecalUp(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x0000000181409B50-0x0000000181409D90
	public void MoveDecalDown(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x0000000181409910-0x0000000181409B50
	public void MirrorDecal(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart, bool inMirror); // 0x0000000181409850-0x0000000181409910
	public void SetDecalBodyPart(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inOriginalBodyPart, ActorInfoBodyPart inNewBodyPart); // 0x000000018140B750-0x000000018140B950
	public void SetDirty(ActorInfoDirtyType inType, bool inValue = true /* Metadata: 0x0078211E */); // 0x000000018140C020-0x000000018140C2A0
	public void SetAllDirty(bool inValue = true /* Metadata: 0x0078211F */); // 0x000000018140B270-0x000000018140B430
	public void SyncInventoryItems(Inventory inv); // 0x000000018140C400-0x000000018140C6E0
}

