/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ActorInfo : WorldObjectInfo, ISerializationCallbackReceiver // TypeDefIndex: 12408
{
	// Fields
	[ChartDef] // 0x0000000180292080-0x0000000180292150
	[Header] // 0x0000000180292080-0x0000000180292150
	[Space] // 0x0000000180292080-0x0000000180292150
	public string actorClassDefID; // 0x18
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<ActorInfoBodyPart> bodyParts; // 0x20
	public Action<ActorInfoBodyPart> OnBodyPartSet; // 0x28
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _bodyColor1HSV; // 0x30
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _bodyColor2HSV; // 0x68
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _bodyColor3HSV; // 0xA0
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _bodyColor4HSV; // 0xD8
	public Action OnBodyColorChanged; // 0x110
	[ChartDef] // 0x0000000180293E20-0x0000000180293EF0
	[Header] // 0x0000000180293E20-0x0000000180293EF0
	[Space] // 0x0000000180293E20-0x0000000180293EF0
	public string eyeShapeDefID; // 0x118
	[ChartDef] // 0x00000001802943C0-0x0000000180294460
	public string eyePupilDefID; // 0x120
	private List<BaseDef> _eyeShapeDefs; // 0x128
	private List<BaseDef> _eyePupilDefs; // 0x130
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _eyeShapeColorHSV; // 0x138
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _eyePupilColorHSV; // 0x170
	public Action OnEyeColorChanged; // 0x1A8
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _sparkColor1HSV; // 0x1B0
	public Action OnSparkColorChanged; // 0x1E8
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _hornColor1HSV; // 0x1F0
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _hornColor2HSV; // 0x228
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _hornColor3HSV; // 0x260
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _hornColor4HSV; // 0x298
	public Action OnHornColorChanged; // 0x2D0
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _wingColor1HSV; // 0x2D8
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _wingColor2HSV; // 0x310
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _wingColor3HSV; // 0x348
	[ChartHSV] // 0x0000000180292510-0x0000000180292540
	[SerializeField] // 0x0000000180292510-0x0000000180292540
	private HSVColor _wingColor4HSV; // 0x380
	public Action OnWingColorChanged; // 0x3B8
	[ChartFloat] // 0x00000001801DE450-0x00000001801DE460
	public float eyeShapeScale; // 0x3C0
	[ChartFloat] // 0x00000001801DE450-0x00000001801DE460
	public float eyePupilScale; // 0x3C4
	[ChartList] // 0x0000000180296510-0x0000000180296570
	[Header] // 0x0000000180296510-0x0000000180296570
	[Space] // 0x0000000180296510-0x0000000180296570
	public List<ActorInfoClothingItem> clothingItems; // 0x3C8
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
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
	public HSVColor BodyColor1HSV { get; set; } // 0x00000001809977A0-0x00000001809977D0 0x00000001821DF320-0x00000001821DF3E0
	public HSVColor BodyColor2HSV { get; set; } // 0x00000001821DEC70-0x00000001821DECA0 0x00000001821DF3E0-0x00000001821DF4A0
	public HSVColor BodyColor3HSV { get; set; } // 0x00000001821DECA0-0x00000001821DECE0 0x00000001821DF4A0-0x00000001821DF570
	public HSVColor BodyColor4HSV { get; set; } // 0x00000001821DECE0-0x00000001821DED20 0x00000001821DF570-0x00000001821DF640
	public List<BaseDef> EyeShapeDefs { get; } // 0x00000001821DEF50-0x00000001821DF060 
	public List<BaseDef> EyePupilDefs { get; } // 0x00000001821DEE00-0x00000001821DEF10 
	public HSVColor EyeShapeColorHSV { get; set; } // 0x00000001821DEF10-0x00000001821DEF50 0x00000001821DF710-0x00000001821DF7E0
	public HSVColor EyePupilColorHSV { get; set; } // 0x00000001821DEDC0-0x00000001821DEE00 0x00000001821DF640-0x00000001821DF710
	public HSVColor SparkColor1HSV { get; set; } // 0x00000001821DF1E0-0x00000001821DF220 0x00000001821DFB70-0x00000001821DFC40
	public HSVColor HornColor1HSV { get; set; } // 0x00000001821DF060-0x00000001821DF0A0 0x00000001821DF7E0-0x00000001821DF8B0
	public HSVColor HornColor2HSV { get; set; } // 0x00000001821DF0A0-0x00000001821DF0E0 0x00000001821DF8B0-0x00000001821DF980
	public HSVColor HornColor3HSV { get; set; } // 0x00000001821DF0E0-0x00000001821DF120 0x00000001821DF980-0x00000001821DFA50
	public HSVColor HornColor4HSV { get; set; } // 0x00000001821DF120-0x00000001821DF160 0x00000001821DFA50-0x00000001821DFB20
	public HSVColor WingColor1HSV { get; set; } // 0x00000001821DF220-0x00000001821DF260 0x00000001821DFC40-0x00000001821DFD10
	public HSVColor WingColor2HSV { get; set; } // 0x00000001821DF260-0x00000001821DF2A0 0x00000001821DFD10-0x00000001821DFDE0
	public HSVColor WingColor3HSV { get; set; } // 0x00000001821DF2A0-0x00000001821DF2E0 0x00000001821DFDE0-0x00000001821DFEB0
	public HSVColor WingColor4HSV { get; set; } // 0x00000001821DF2E0-0x00000001821DF320 0x00000001821DFEB0-0x00000001821DFF80
	public ActorClassDefComponent ClassDefComponent { get; } // 0x00000001821DED20-0x00000001821DEDC0 
	public List<ActorInfoBodyPart> AttachedBodyParts { get; } // 0x00000001821DE9E0-0x00000001821DEC70 
	public bool IsDesignerMode { get; } // 0x0000000180380950-0x0000000180380960 
	public ActorInfoDecalEntry SelectedDecalEntry { get; set; } // 0x00000001821DF1D0-0x00000001821DF1E0 0x00000001821DFB50-0x00000001821DFB70
	public float SelectedDecalEntryOutlinePulse { get; set; } // 0x00000001821DF1C0-0x00000001821DF1D0 0x00000001821DFB30-0x00000001821DFB50
	public HSVColor SelectedDecalEntryOutlineColor { get; } // 0x00000001821DF170-0x00000001821DF1C0 
	public bool IsRefreshingDirty { get; set; } // 0x00000001821DF160-0x00000001821DF170 0x00000001821DFB20-0x00000001821DFB30

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass104_0 // TypeDefIndex: 12409
	{
		// Fields
		public ActorBodyPartDefComponent inPartDefComponent; // 0x10

		// Constructors
		public <>c__DisplayClass104_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SetBodyPart>b__0(ActorInfoBodyPart part); // 0x00000001821EBCE0-0x00000001821EBD30
	}

	// Constructors
	public ActorInfo(); // 0x00000001821DE270-0x00000001821DE9E0

	// Methods
	public override void ResetCaches(); // 0x00000001821DCE40-0x00000001821DCE60
	public void OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
	public void OnAfterDeserialize(); // 0x00000001821DB9A0-0x00000001821DC610
	public void RefreshAttachedBodyParts(); // 0x00000001821DC610-0x00000001821DC620
	public ActorInfoScaleGroup GetScaleGroupWithDefID(string inGroupDefID); // 0x00000001821DB140-0x00000001821DB2E0
	public ActorInfoBodyPart GetAttachedBodyPartForNode(BaseDef inNodeDef); // 0x00000001821DAC40-0x00000001821DAC60
	public ActorInfoBodyPart GetAttachedBodyPartForNode(string inNodeDefID); // 0x00000001821DAA90-0x00000001821DAC40
	public List<ActorInfoBodyPart> GetBodyPartsForNode(BaseDef inNodeDef); // 0x00000001821DAEC0-0x00000001821DAEE0
	public List<ActorInfoBodyPart> GetBodyPartsForNode(string inNodeDefID); // 0x00000001821DAC60-0x00000001821DAEC0
	public bool IsBodyPartAttached(ActorBodyPartDefComponent inDef); // 0x00000001821DB2E0-0x00000001821DB490
	public void SetEyeShape(BaseDef inDecalDef); // 0x00000001821DDE80-0x00000001821DDF10
	public void SetPupilShape(BaseDef inDecalDef); // 0x00000001821DDF10-0x00000001821DDFA0
	public void SetEyeShapeScale(float inScale); // 0x00000001821DDE60-0x00000001821DDE80
	public void SetEyePupilScale(float inScale); // 0x00000001821DDE40-0x00000001821DDE60
	public void SetBodyPart(ActorBodyPartDefComponent inPartDefComponent); // 0x00000001821DD010-0x00000001821DD250
	public bool ClothingItemIsEquipped(Item inItem); // 0x00000001821DA470-0x00000001821DA610
	public ValueTuple<ActorInfoClothingItem, List<ActorInfoClothingItem>> AddClothingItem(Item inItem); // 0x00000001821D9200-0x00000001821D9E40
	public void AddClothingItem(ActorInfoClothingItem inItem); // 0x00000001821D9E40-0x00000001821D9F60
	public void RemoveClothingItem(Item inItem); // 0x00000001821DC910-0x00000001821DCA90
	public void RemoveClothingItem(ActorInfoClothingItem inItem); // 0x00000001821DCA90-0x00000001821DCB90
	public List<ActorInfoClothingItem> RemoveClothingItemsOnGroup(ActorAttachNodeGroupDefComponent inAttachNodeGroup); // 0x00000001821DCB90-0x00000001821DCD10
	public void RemoveAllClothingItems(); // 0x00000001821DC620-0x00000001821DC740
	public ActorInfoDecalEntry AddDecal(BaseDef inDecalDef); // 0x00000001821D9F60-0x00000001821DA2F0
	public ActorInfoDecalEntry AddDuplicateDecal(ActorInfoDecalEntry inDecalEntry); // 0x00000001821DA2F0-0x00000001821DA470
	public void RemoveAllDecals(); // 0x00000001821DC740-0x00000001821DC910
	public void RemoveDecal(ActorInfoDecalEntry inDecalEntry); // 0x00000001821DCD10-0x00000001821DCE40
	public ActorInfoBodyPart GetDecalBodyPart(ActorInfoDecalEntry inDecalEntry); // 0x00000001821DAEE0-0x00000001821DB140
	public void SetDecalShape(BaseDef inDecalDef, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DDB10-0x00000001821DDBA0
	public void SetDecalPositionFromHit(RaycastHit inHit, RaycastHit? inMirrorHit, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DD6A0-0x00000001821DD960
	public void SetDecalRotation(float inDecalRotation, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DD960-0x00000001821DDA30
	public void SetDecalColor(HSVColor inDecalColor, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DD500-0x00000001821DD5F0
	public void SetDecalScale(float inNormalizedScale, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DDA30-0x00000001821DDB10
	public void SetDecalAlpha(float inAlpha, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DD250-0x00000001821DD310
	public void SetDecalEnabled(bool inEnabled, ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DD5F0-0x00000001821DD6A0
	public void SetDefaultDecalsEnabled(bool inEnabled); // 0x00000001821DDBA0-0x00000001821DDBC0
	public void FlipDecalX(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DA910-0x00000001821DA9D0
	public void FlipDecalY(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DA9D0-0x00000001821DAA90
	public bool DecalIsAtBottomLayer(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DA610-0x00000001821DA7A0
	public bool DecalIsAtTopLayer(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DA7A0-0x00000001821DA910
	public void MoveDecalUp(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DB770-0x00000001821DB9A0
	public void MoveDecalDown(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart); // 0x00000001821DB540-0x00000001821DB770
	public void MirrorDecal(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inBodyPart, bool inMirror); // 0x00000001821DB490-0x00000001821DB540
	public void SetDecalBodyPart(ActorInfoDecalEntry inDecalEntry, ActorInfoBodyPart inOriginalBodyPart, ActorInfoBodyPart inNewBodyPart); // 0x00000001821DD310-0x00000001821DD500
	public void SetDirty(ActorInfoDirtyType inType, bool inValue = true /* Metadata: 0x007B9862 */); // 0x00000001821DDBC0-0x00000001821DDE40
	public void SetAllDirty(bool inValue = true /* Metadata: 0x007B9863 */); // 0x00000001821DCE60-0x00000001821DD010
	public void SyncInventoryItems(Inventory inv); // 0x00000001821DDFA0-0x00000001821DE270
}

