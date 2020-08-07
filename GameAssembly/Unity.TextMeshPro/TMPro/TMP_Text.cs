/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 9025
	{
		// Fields
		[SerializeField] // 0x00000001801EA4B0-0x00000001801EA4F0
		[TextArea] // 0x00000001801EA4B0-0x00000001801EA4F0
		protected string m_text; // 0xC8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isRightToLeft; // 0xD0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_FontAsset m_fontAsset; // 0xD8
		protected TMP_FontAsset m_currentFontAsset; // 0xE0
		protected bool m_isSDFShader; // 0xE8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Material m_sharedMaterial; // 0xF0
		protected Material m_currentMaterial; // 0xF8
		protected MaterialReference[] m_materialReferences; // 0x100
		protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
		protected TMP_RichTextTagStack<MaterialReference> m_materialReferenceStack; // 0x110
		protected int m_currentMaterialIndex; // 0x158
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Material[] m_fontSharedMaterials; // 0x160
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Material m_fontMaterial; // 0x168
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Material[] m_fontMaterials; // 0x170
		protected bool m_isMaterialDirty; // 0x178
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Color32 m_fontColor32; // 0x17C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Color m_fontColor; // 0x180
		protected static Color32 s_colorWhite; // 0x00
		protected Color32 m_underlineColor; // 0x190
		protected Color32 m_strikethroughColor; // 0x194
		protected Color32 m_highlightColor; // 0x198
		protected Vector4 m_highlightPadding; // 0x19C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_enableVertexGradient; // 0x1AC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected ColorMode m_colorMode; // 0x1B0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected VertexGradient m_fontColorGradient; // 0x1B4
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_SpriteAsset m_spriteAsset; // 0x200
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_tintAllSprites; // 0x208
		protected bool m_tintSprite; // 0x209
		protected Color32 m_spriteColor; // 0x20C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_overrideHtmlColors; // 0x210
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Color32 m_faceColor; // 0x214
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Color32 m_outlineColor; // 0x218
		protected float m_outlineWidth; // 0x21C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_fontSize; // 0x220
		protected float m_currentFontSize; // 0x224
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_fontSizeBase; // 0x228
		protected TMP_RichTextTagStack<float> m_sizeStack; // 0x230
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected FontWeight m_fontWeight; // 0x248
		protected FontWeight m_FontWeightInternal; // 0x24C
		protected TMP_RichTextTagStack<FontWeight> m_FontWeightStack; // 0x250
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_enableAutoSizing; // 0x268
		protected float m_maxFontSize; // 0x26C
		protected float m_minFontSize; // 0x270
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_fontSizeMin; // 0x274
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_fontSizeMax; // 0x278
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected FontStyles m_fontStyle; // 0x27C
		protected FontStyles m_FontStyleInternal; // 0x280
		protected TMP_FontStyleStack m_fontStyleStack; // 0x284
		protected bool m_isUsingBold; // 0x28E
		[FormerlySerializedAs] // 0x00000001801FD900-0x00000001801FD940
		[SerializeField] // 0x00000001801FD900-0x00000001801FD940
		protected TextAlignmentOptions m_textAlignment; // 0x290
		protected TextAlignmentOptions m_lineJustification; // 0x294
		protected TMP_RichTextTagStack<TextAlignmentOptions> m_lineJustificationStack; // 0x298
		protected Vector3[] m_textContainerLocalCorners; // 0x2B0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_characterSpacing; // 0x2B8
		protected float m_cSpacing; // 0x2BC
		protected float m_monoSpacing; // 0x2C0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_wordSpacing; // 0x2C4
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_lineSpacing; // 0x2C8
		protected float m_lineSpacingDelta; // 0x2CC
		protected float m_lineHeight; // 0x2D0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_lineSpacingMax; // 0x2D4
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_paragraphSpacing; // 0x2D8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_charWidthMaxAdj; // 0x2DC
		protected float m_charWidthAdjDelta; // 0x2E0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_enableWordWrapping; // 0x2E4
		protected bool m_isCharacterWrappingEnabled; // 0x2E5
		protected bool m_isNonBreakingSpace; // 0x2E6
		protected bool m_isIgnoringAlignment; // 0x2E7
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_wordWrappingRatios; // 0x2E8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TextOverflowModes m_overflowMode; // 0x2EC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected int m_firstOverflowCharacterIndex; // 0x2F0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_Text m_linkedTextComponent; // 0x2F8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isLinkedTextComponent; // 0x300
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isTextTruncated; // 0x301
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_enableKerning; // 0x302
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_enableExtraPadding; // 0x303
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool checkPaddingRequired; // 0x304
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isRichText; // 0x305
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_parseCtrlCharacters; // 0x306
		protected bool m_isOverlay; // 0x307
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isOrthographic; // 0x308
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isCullingEnabled; // 0x309
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_ignoreRectMaskCulling; // 0x30A
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_ignoreCulling; // 0x30B
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TextureMappingOptions m_horizontalMapping; // 0x30C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TextureMappingOptions m_verticalMapping; // 0x310
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_uvLineOffset; // 0x314
		protected TextRenderFlags m_renderMode; // 0x318
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected VertexSortingOrder m_geometrySortingOrder; // 0x31C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_VertexBufferAutoSizeReduction; // 0x320
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected int m_firstVisibleCharacter; // 0x324
		protected int m_maxVisibleCharacters; // 0x328
		protected int m_maxVisibleWords; // 0x32C
		protected int m_maxVisibleLines; // 0x330
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_useMaxVisibleDescender; // 0x334
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected int m_pageToDisplay; // 0x338
		protected bool m_isNewPage; // 0x33C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Vector4 m_margin; // 0x340
		protected float m_marginLeft; // 0x350
		protected float m_marginRight; // 0x354
		protected float m_marginWidth; // 0x358
		protected float m_marginHeight; // 0x35C
		protected float m_width; // 0x360
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_TextInfo m_textInfo; // 0x368
		protected bool m_havePropertiesChanged; // 0x370
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isUsingLegacyAnimationComponent; // 0x371
		protected Transform m_transform; // 0x378
		protected RectTransform m_rectTransform; // 0x380
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <autoSizeTextContainer>k__BackingField; // 0x388
		protected bool m_autoSizeTextContainer; // 0x389
		protected Mesh m_mesh; // 0x390
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isVolumetricText; // 0x398
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_SpriteAnimator m_spriteAnimator; // 0x3A0
		protected float m_flexibleHeight; // 0x3A8
		protected float m_flexibleWidth; // 0x3AC
		protected float m_minWidth; // 0x3B0
		protected float m_minHeight; // 0x3B4
		protected float m_maxWidth; // 0x3B8
		protected float m_maxHeight; // 0x3BC
		protected LayoutElement m_LayoutElement; // 0x3C0
		protected float m_preferredWidth; // 0x3C8
		protected float m_renderedWidth; // 0x3CC
		protected bool m_isPreferredWidthDirty; // 0x3D0
		protected float m_preferredHeight; // 0x3D4
		protected float m_renderedHeight; // 0x3D8
		protected bool m_isPreferredHeightDirty; // 0x3DC
		protected bool m_isCalculatingPreferredValues; // 0x3DD
		private int m_recursiveCount; // 0x3E0
		protected int m_layoutPriority; // 0x3E4
		protected bool m_isCalculateSizeRequired; // 0x3E8
		protected bool m_isLayoutDirty; // 0x3E9
		protected bool m_verticesAlreadyDirty; // 0x3EA
		protected bool m_layoutAlreadyDirty; // 0x3EB
		protected bool m_isAwake; // 0x3EC
		internal bool m_isWaitingOnResourceLoad; // 0x3ED
		internal bool m_isInputParsingRequired; // 0x3EE
		internal TextInputSources m_inputSource; // 0x3F0
		protected string old_text; // 0x3F8
		protected float m_fontScale; // 0x400
		protected float m_fontScaleMultiplier; // 0x404
		protected char[] m_htmlTag; // 0x408
		protected RichTextTagAttribute[] m_xmlAttribute; // 0x410
		protected float[] m_attributeParameterValues; // 0x418
		protected float tag_LineIndent; // 0x420
		protected float tag_Indent; // 0x424
		protected TMP_RichTextTagStack<float> m_indentStack; // 0x428
		protected bool tag_NoParsing; // 0x440
		protected bool m_isParsingText; // 0x441
		protected Matrix4x4 m_FXMatrix; // 0x444
		protected bool m_isFXMatrixSet; // 0x484
		protected UnicodeChar[] m_TextParsingBuffer; // 0x488
		private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x490
		protected char[] m_input_CharArray; // 0x498
		private int m_charArray_Length; // 0x4A0
		protected int m_totalCharacterCount; // 0x4A4
		protected WordWrapState m_SavedWordWrapState; // 0x4A8
		protected WordWrapState m_SavedLineState; // 0x738
		protected int m_characterCount; // 0x9C8
		protected int m_firstCharacterOfLine; // 0x9CC
		protected int m_firstVisibleCharacterOfLine; // 0x9D0
		protected int m_lastCharacterOfLine; // 0x9D4
		protected int m_lastVisibleCharacterOfLine; // 0x9D8
		protected int m_lineNumber; // 0x9DC
		protected int m_lineVisibleCharacterCount; // 0x9E0
		protected int m_pageNumber; // 0x9E4
		protected float m_maxAscender; // 0x9E8
		protected float m_maxCapHeight; // 0x9EC
		protected float m_maxDescender; // 0x9F0
		protected float m_maxLineAscender; // 0x9F4
		protected float m_maxLineDescender; // 0x9F8
		protected float m_startOfLineAscender; // 0x9FC
		protected float m_lineOffset; // 0xA00
		protected Extents m_meshExtents; // 0xA04
		protected Color32 m_htmlColor; // 0xA14
		protected TMP_RichTextTagStack<Color32> m_colorStack; // 0xA18
		protected TMP_RichTextTagStack<Color32> m_underlineColorStack; // 0xA30
		protected TMP_RichTextTagStack<Color32> m_strikethroughColorStack; // 0xA48
		protected TMP_RichTextTagStack<Color32> m_highlightColorStack; // 0xA60
		protected TMP_ColorGradient m_colorGradientPreset; // 0xA78
		protected TMP_RichTextTagStack<TMP_ColorGradient> m_colorGradientStack; // 0xA80
		protected float m_tabSpacing; // 0xA98
		protected float m_spacing; // 0xA9C
		protected TMP_RichTextTagStack<int> m_styleStack; // 0xAA0
		protected TMP_RichTextTagStack<int> m_actionStack; // 0xAB8
		protected float m_padding; // 0xAD0
		protected float m_baselineOffset; // 0xAD4
		protected TMP_RichTextTagStack<float> m_baselineOffsetStack; // 0xAD8
		protected float m_xAdvance; // 0xAF0
		protected TMP_TextElementType m_textElementType; // 0xAF4
		protected TMP_TextElement m_cached_TextElement; // 0xAF8
		protected TMP_Character m_cached_Underline_Character; // 0xB00
		protected TMP_Character m_cached_Ellipsis_Character; // 0xB08
		protected TMP_SpriteAsset m_defaultSpriteAsset; // 0xB10
		protected TMP_SpriteAsset m_currentSpriteAsset; // 0xB18
		protected int m_spriteCount; // 0xB20
		protected int m_spriteIndex; // 0xB24
		protected int m_spriteAnimationID; // 0xB28
		protected bool m_ignoreActiveState; // 0xB2C
		private readonly float[] k_Power; // 0xB30
		protected static Vector2 k_LargePositiveVector2; // 0x04
		protected static Vector2 k_LargeNegativeVector2; // 0x0C
		protected static float k_LargePositiveFloat; // 0x14
		protected static float k_LargeNegativeFloat; // 0x18
		protected static int k_LargePositiveInt; // 0x1C
		protected static int k_LargeNegativeInt; // 0x20
	
		// Properties
		public string text { get; set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001805CD550-0x00000001805CD5E0
		public bool isRightToLeftText { get; set; } // 0x00000001805CB7D0-0x00000001805CB7E0 0x00000001805CCCC0-0x00000001805CCD20
		public TMP_FontAsset font { get; set; } // 0x00000001805CB740-0x00000001805CB750 0x00000001805CCA50-0x00000001805CCB20
		public virtual Material fontSharedMaterial { get; set; } // 0x000000018037DDB0-0x000000018037DDC0 0x00000001805CC7B0-0x00000001805CC880
		public virtual Material[] fontSharedMaterials { get; set; } // 0x00000001805CB6D0-0x00000001805CB6F0 0x00000001805CC750-0x00000001805CC7B0
		public Material fontMaterial { get; set; } // 0x00000001805CB680-0x00000001805CB6A0 0x00000001805CC640-0x00000001805CC750
		public virtual Material[] fontMaterials { get; set; } // 0x00000001805CB6A0-0x00000001805CB6C0 0x00000001805CC750-0x00000001805CC7B0
		public override Color color { get; set; } // 0x00000001805CB4E0-0x00000001805CB4F0 0x00000001805CC350-0x00000001805CC3C0
		public float alpha { get; set; } // 0x00000001805CB390-0x00000001805CB3A0 0x00000001805CC1E0-0x00000001805CC210
		public bool enableVertexGradient { get; set; } // 0x00000001805CB520-0x00000001805CB530 0x00000001805CC4B0-0x00000001805CC4E0
		public VertexGradient colorGradient { get; set; } // 0x00000001805CB4B0-0x00000001805CB4E0 0x00000001805CC300-0x00000001805CC350
		public TMP_ColorGradient colorGradientPreset { get; set; } // 0x00000001805CB4A0-0x00000001805CB4B0 0x00000001805CC2E0-0x00000001805CC300
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x00000001805CC050-0x00000001805CC060 0x00000001805CD500-0x00000001805CD550
		public bool tintAllSprites { get; set; } // 0x00000001805CC0D0-0x00000001805CC0E0 0x00000001805CD5E0-0x00000001805CD610
		public bool overrideColorTags { get; set; } // 0x00000001805CBB80-0x00000001805CBB90 0x00000001805CD360-0x00000001805CD390
		public Color32 faceColor { get; set; } // 0x00000001805CB550-0x00000001805CB640 0x00000001805CC590-0x00000001805CC610
		public Color32 outlineColor { get; set; } // 0x00000001805CB9A0-0x00000001805CBA90 0x00000001805CD230-0x00000001805CD2A0
		public float outlineWidth { get; set; } // 0x00000001805CBA90-0x00000001805CBB70 0x00000001805CD2A0-0x00000001805CD300
		public float fontSize { get; set; } // 0x00000001805CB710-0x00000001805CB720 0x00000001805CC920-0x00000001805CC990
		public float fontScale { get; } // 0x00000001805CB6C0-0x00000001805CB6D0 
		public FontWeight fontWeight { get; set; } // 0x00000001805CB730-0x00000001805CB740 0x00000001805CC9F0-0x00000001805CCA50
		public float pixelsPerUnit { get; } // 0x00000001805CBBC0-0x00000001805CBE30 
		public bool enableAutoSizing { get; set; } // 0x00000001805CB4F0-0x00000001805CB500 0x00000001805CC3C0-0x00000001805CC410
		public float fontSizeMin { get; set; } // 0x00000001805CB700-0x00000001805CB710 0x00000001805CC8D0-0x00000001805CC920
		public float fontSizeMax { get; set; } // 0x00000001805CB6F0-0x00000001805CB700 0x00000001805CC880-0x00000001805CC8D0
		public FontStyles fontStyle { get; set; } // 0x00000001805CB720-0x00000001805CB730 0x00000001805CC990-0x00000001805CC9F0
		public bool isUsingBold { get; } // 0x00000001805CB800-0x00000001805CB810 
		public TextAlignmentOptions alignment { get; set; } // 0x00000001805CB380-0x00000001805CB390 0x00000001805CC1B0-0x00000001805CC1E0
		public float characterSpacing { get; set; } // 0x00000001805CB480-0x00000001805CB490 0x00000001805CC220-0x00000001805CC280
		public float wordSpacing { get; set; } // 0x00000001805CC190-0x00000001805CC1A0 0x00000001805CD690-0x00000001805CD6F0
		public float lineSpacing { get; set; } // 0x00000001805CB8E0-0x00000001805CB8F0 0x00000001805CCE00-0x00000001805CCE60
		public float lineSpacingAdjustment { get; set; } // 0x00000001805CB8D0-0x00000001805CB8E0 0x00000001805CCDA0-0x00000001805CCE00
		public float paragraphSpacing { get; set; } // 0x00000001805CBBA0-0x00000001805CBBB0 0x00000001805CD3C0-0x00000001805CD420
		public float characterWidthAdjustment { get; set; } // 0x00000001805CB490-0x00000001805CB4A0 0x00000001805CC280-0x00000001805CC2E0
		public bool enableWordWrapping { get; set; } // 0x00000001805CB530-0x00000001805CB540 0x00000001805CC4E0-0x00000001805CC540
		public float wordWrappingRatios { get; set; } // 0x00000001805CC1A0-0x00000001805CC1B0 0x00000001805CD6F0-0x00000001805CD750
		public TextOverflowModes overflowMode { get; set; } // 0x00000001805CBB70-0x00000001805CBB80 0x00000001805CD300-0x00000001805CD360
		public bool isTextOverflowing { get; } // 0x00000001805CB7E0-0x00000001805CB7F0 
		public int firstOverflowCharacterIndex { get; } // 0x00000001805CB640-0x00000001805CB650 
		public TMP_Text linkedTextComponent { get; set; } // 0x00000001805CB8F0-0x00000001805CB900 0x00000001805CCE60-0x00000001805CD0B0
		public bool isLinkedTextComponent { get; set; } // 0x00000001805CB7A0-0x00000001805CB7B0 0x00000001805CCBE0-0x00000001805CCC40
		public bool isTextTruncated { get; } // 0x00000001805CB7F0-0x00000001805CB800 
		public bool enableKerning { get; set; } // 0x00000001805CB510-0x00000001805CB520 0x00000001805CC450-0x00000001805CC4B0
		public bool extraPadding { get; set; } // 0x00000001805CB540-0x00000001805CB550 0x00000001805CC540-0x00000001805CC590
		public bool richText { get; set; } // 0x00000001805CBF50-0x00000001805CBF60 0x00000001805CD4A0-0x00000001805CD500
		public bool parseCtrlCharacters { get; set; } // 0x00000001805CBBB0-0x00000001805CBBC0 0x00000001805CD420-0x00000001805CD480
		public bool isOverlay { get; set; } // 0x00000001805CB7C0-0x00000001805CB7D0 0x00000001805CCC70-0x00000001805CCCC0
		public bool isOrthographic { get; set; } // 0x00000001805CB7B0-0x00000001805CB7C0 0x00000001805CCC40-0x00000001805CCC70
		public bool enableCulling { get; set; } // 0x00000001805CB500-0x00000001805CB510 0x00000001805CC410-0x00000001805CC450
		public bool ignoreRectMaskCulling { get; set; } // 0x00000001805CB780-0x00000001805CB790 0x00000001805CCBA0-0x00000001805CCBC0
		public bool ignoreVisibility { get; set; } // 0x00000001805CB790-0x00000001805CB7A0 0x00000001805CCBC0-0x00000001805CCBE0
		public TextureMappingOptions horizontalMapping { get; set; } // 0x00000001805CB770-0x00000001805CB780 0x00000001805CCB70-0x00000001805CCBA0
		public TextureMappingOptions verticalMapping { get; set; } // 0x00000001805CC180-0x00000001805CC190 0x00000001805CD660-0x00000001805CD690
		public float mappingUvLineOffset { get; set; } // 0x00000001805CB900-0x00000001805CB910 0x00000001805CD0B0-0x00000001805CD0E0
		public TextRenderFlags renderMode { get; set; } // 0x00000001805CBF40-0x00000001805CBF50 0x00000001805CD480-0x00000001805CD4A0
		public VertexSortingOrder geometrySortingOrder { get; set; } // 0x00000001805CB750-0x00000001805CB760 0x00000001805CCB20-0x00000001805CCB40
		public bool vertexBufferAutoSizeReduction { get; set; } // 0x00000001805CC170-0x00000001805CC180 0x00000001805CD640-0x00000001805CD660
		public int firstVisibleCharacter { get; set; } // 0x00000001805CB650-0x00000001805CB660 0x00000001805CC610-0x00000001805CC640
		public int maxVisibleCharacters { get; set; } // 0x00000001805CB930-0x00000001805CB940 0x00000001805CD1A0-0x00000001805CD1D0
		public int maxVisibleWords { get; set; } // 0x00000001805CB950-0x00000001805CB960 0x00000001805CD200-0x00000001805CD230
		public int maxVisibleLines { get; set; } // 0x00000001805CB940-0x00000001805CB950 0x00000001805CD1D0-0x00000001805CD200
		public bool useMaxVisibleDescender { get; set; } // 0x0000000180475D50-0x0000000180475D60 0x00000001805CD610-0x00000001805CD640
		public int pageToDisplay { get; set; } // 0x00000001805CBB90-0x00000001805CBBA0 0x00000001805CD390-0x00000001805CD3C0
		public virtual Vector4 margin { get; set; } // 0x00000001805CB910-0x00000001805CB920 0x00000001805CD0E0-0x00000001805CD1A0
		public TMP_TextInfo textInfo { get; } // 0x00000001805CC0C0-0x00000001805CC0D0 
		public bool havePropertiesChanged { get; set; } // 0x00000001805CB760-0x00000001805CB770 0x00000001805CCB40-0x00000001805CCB70
		public bool isUsingLegacyAnimationComponent { get; set; } // 0x00000001805CB810-0x00000001805CB820 0x00000001805CCD20-0x00000001805CCD30
		public new Transform transform { get; } // 0x00000001805CC0E0-0x00000001805CC170 
		public new RectTransform rectTransform { get; } // 0x00000001805CBEB0-0x00000001805CBF40 
		public virtual bool autoSizeTextContainer { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001805CB3A0-0x00000001805CB3B0 0x00000001805CC210-0x00000001805CC220
		public virtual Mesh mesh { get; } // 0x00000001805CB970-0x00000001805CB980 
		public bool isVolumetricText { get; set; } // 0x00000001805CB820-0x00000001805CB830 0x00000001805CCD30-0x00000001805CCDA0
		public Bounds bounds { get; } // 0x00000001805CB3B0-0x00000001805CB480 
		public Bounds textBounds { get; } // 0x00000001805CC060-0x00000001805CC0C0 
		protected TMP_SpriteAnimator spriteAnimator { get; } // 0x00000001805CBF60-0x00000001805CC050 
		public float flexibleHeight { get; } // 0x00000001805CB660-0x00000001805CB670 
		public float flexibleWidth { get; } // 0x00000001805CB670-0x00000001805CB680 
		public float minWidth { get; } // 0x00000001805CB990-0x00000001805CB9A0 
		public float minHeight { get; } // 0x00000001805CB980-0x00000001805CB990 
		public float maxWidth { get; } // 0x00000001805CB960-0x00000001805CB970 
		public float maxHeight { get; } // 0x00000001805CB920-0x00000001805CB930 
		protected LayoutElement layoutElement { get; } // 0x00000001805CB830-0x00000001805CB8C0 
		public virtual float preferredWidth { get; } // 0x00000001805CBE70-0x00000001805CBEB0 
		public virtual float preferredHeight { get; } // 0x00000001805CBE30-0x00000001805CBE70 
		public virtual float renderedWidth { get; } // 0x00000001805B9450-0x00000001805B9470 
		public virtual float renderedHeight { get; } // 0x00000001805B92A0-0x00000001805B92C0 
		public int layoutPriority { get; } // 0x00000001805CB8C0-0x00000001805CB8D0 
	
		// Nested types
		internal enum TextInputSources // TypeDefIndex: 9026
		{
			Text = 0,
			SetText = 1,
			SetCharArray = 2,
			String = 3
		}
	
		protected struct UnicodeChar // TypeDefIndex: 9027
		{
			// Fields
			public int unicode; // 0x00
			public int stringIndex; // 0x04
			public int length; // 0x08
		}
	
		// Constructors
		protected TMP_Text(); // 0x00000001805CAB80-0x00000001805CB380
		static TMP_Text(); // 0x00000001805CAA40-0x00000001805CAB80
	
		// Methods
		protected virtual void LoadFontAsset(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void SetSharedMaterial(Material mat); // 0x00000001803774A0-0x00000001803774B0
		protected virtual Material GetMaterial(Material mat); // 0x000000018037DDC0-0x000000018037DDD0
		protected virtual void SetFontBaseMaterial(Material mat); // 0x00000001803774A0-0x00000001803774B0
		protected virtual Material[] GetSharedMaterials(); // 0x000000018037DDC0-0x000000018037DDD0
		protected virtual void SetSharedMaterials(Material[] materials); // 0x00000001803774A0-0x00000001803774B0
		protected virtual Material[] GetMaterials(Material[] mats); // 0x000000018037DDC0-0x000000018037DDD0
		protected virtual Material CreateMaterialInstance(Material source); // 0x00000001805B3CD0-0x00000001805B3D80
		protected void SetVertexColorGradient(TMP_ColorGradient gradient); // 0x00000001805C2830-0x00000001805C28E0
		protected void SetTextSortingOrder(VertexSortingOrder order); // 0x00000001803774A0-0x00000001803774B0
		protected void SetTextSortingOrder(int[] order); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void SetFaceColor(Color32 color); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void SetOutlineColor(Color32 color); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void SetOutlineThickness(float thickness); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void SetShaderDepth(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void SetCulling(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual float GetPaddingForMaterial(); // 0x000000018058C7E0-0x000000018058C7F0
		protected virtual float GetPaddingForMaterial(Material mat); // 0x000000018058C7E0-0x000000018058C7F0
		protected virtual Vector3[] GetTextContainerLocalCorners(); // 0x000000018037DDC0-0x000000018037DDD0
		public virtual void ForceMeshUpdate(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void ForceMeshUpdate(bool ignoreActiveState); // 0x00000001803774A0-0x00000001803774B0
		internal void SetTextInternal(string text); // 0x00000001805C2460-0x00000001805C24B0
		public virtual void UpdateGeometry(Mesh mesh, int index); // 0x00000001803774A0-0x00000001803774B0
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x00000001803774A0-0x00000001803774B0
		public virtual void UpdateVertexData(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void SetVertices(Vector3[] vertices); // 0x00000001803774A0-0x00000001803774B0
		public virtual void UpdateMeshPadding(); // 0x00000001803774A0-0x00000001803774B0
		public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x00000001805B3DF0-0x00000001805B3E90
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x00000001805B3D80-0x00000001805B3DF0
		protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x00000001803774A0-0x00000001803774B0
		protected void ParseInputText(); // 0x00000001805BBFA0-0x00000001805BC020
		public void SetText(string text); // 0x00000001805C24B0-0x00000001805C2520
		public void SetText(string text, bool syncTextInputBox); // 0x00000001805C24B0-0x00000001805C2520
		public void SetText(string text, float arg0); // 0x00000001805C2590-0x00000001805C25C0
		public void SetText(string text, float arg0, float arg1); // 0x00000001805C2800-0x00000001805C2830
		public void SetText(string text, float arg0, float arg1, float arg2); // 0x00000001805C25C0-0x00000001805C2800
		public void SetText(StringBuilder text); // 0x00000001805C2520-0x00000001805C2590
		public void SetCharArray(char[] sourceText); // 0x00000001805C0C90-0x00000001805C14A0
		public void SetCharArray(char[] sourceText, int start, int length); // 0x00000001805C0490-0x00000001805C0C90
		public void SetCharArray(int[] sourceText, int start, int length); // 0x00000001805C14A0-0x00000001805C1CB0
		protected void SetTextArrayToCharArray(char[] sourceText, ref UnicodeChar[] charBuffer); // 0x00000001805C1CB0-0x00000001805C2460
		protected void StringToCharArray(string sourceText, ref UnicodeChar[] charBuffer); // 0x00000001805C3470-0x00000001805C4370
		protected void StringBuilderToIntArray(StringBuilder sourceText, ref UnicodeChar[] charBuffer); // 0x00000001805C28E0-0x00000001805C3470
		private bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001805BCE70-0x00000001805BD1C0
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001805BCAE0-0x00000001805BCE70
		private bool ReplaceOpeningStyleTag(ref char[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001805BD1C0-0x00000001805BD550
		private bool ReplaceOpeningStyleTag(ref StringBuilder sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001805BD550-0x00000001805BD8B0
		private bool ReplaceClosingStyleTag(ref string sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001805BC830-0x00000001805BCAE0
		private bool ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001805BC020-0x00000001805BC2D0
		private bool ReplaceClosingStyleTag(ref char[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001805BC2D0-0x00000001805BC580
		private bool ReplaceClosingStyleTag(ref StringBuilder sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001805BC580-0x00000001805BC830
		private bool IsTagName(ref string text, string tag, int index); // 0x00000001805BBA10-0x00000001805BBB20
		private bool IsTagName(ref char[] text, string tag, int index); // 0x00000001805BB7B0-0x00000001805BB8E0
		private bool IsTagName(ref int[] text, string tag, int index); // 0x00000001805BB8E0-0x00000001805BBA10
		private bool IsTagName(ref StringBuilder text, string tag, int index); // 0x00000001805BBB20-0x00000001805BBC40
		private int GetTagHashCode(ref string text, int index, out int closeIndex); // 0x00000001805B9820-0x00000001805B98F0
		private int GetTagHashCode(ref char[] text, int index, out int closeIndex); // 0x00000001805B98F0-0x00000001805B99B0
		private int GetTagHashCode(ref int[] text, int index, out int closeIndex); // 0x00000001805B99B0-0x00000001805B9A70
		private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex); // 0x00000001805B9740-0x00000001805B9820
		private void ResizeInternalArray<T>(ref T[] array);
		protected void AddFloatToCharArray(double number, ref int index, int precision); // 0x00000001805B0AA0-0x00000001805B0CC0
		protected void AddIntToCharArray(double number, ref int index, int precision); // 0x00000001805B0CC0-0x00000001805B0EF0
		protected virtual int SetArraySizes(UnicodeChar[] chars); // 0x000000018037DDC0-0x000000018037DDD0
		protected virtual void GenerateTextMesh(); // 0x00000001803774A0-0x00000001803774B0
		public Vector2 GetPreferredValues(); // 0x00000001805B8E50-0x00000001805B8ED0
		public Vector2 GetPreferredValues(float width, float height); // 0x00000001805B8FE0-0x00000001805B9090
		public Vector2 GetPreferredValues(string text); // 0x00000001805B8ED0-0x00000001805B8FE0
		public Vector2 GetPreferredValues(string text, float width, float height); // 0x00000001805B8D80-0x00000001805B8E50
		protected float GetPreferredWidth(); // 0x00000001805B9110-0x00000001805B9280
		protected float GetPreferredWidth(Vector2 margin); // 0x00000001805B9090-0x00000001805B9110
		protected float GetPreferredHeight(); // 0x00000001805B8B30-0x00000001805B8D00
		protected float GetPreferredHeight(Vector2 margin); // 0x00000001805B8D00-0x00000001805B8D80
		public Vector2 GetRenderedValues(); // 0x00000001805B9390-0x00000001805B9450
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters); // 0x00000001805B92C0-0x00000001805B9390
		protected float GetRenderedWidth(); // 0x00000001805B9450-0x00000001805B9470
		protected float GetRenderedWidth(bool onlyVisibleCharacters); // 0x00000001805B9470-0x00000001805B9490
		protected float GetRenderedHeight(); // 0x00000001805B92A0-0x00000001805B92C0
		protected float GetRenderedHeight(bool onlyVisibleCharacters); // 0x00000001805B9280-0x00000001805B92A0
		protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing); // 0x00000001805B0EF0-0x00000001805B3AD0
		protected virtual Bounds GetCompoundBounds(); // 0x0000000180592A40-0x0000000180592A50
		protected Bounds GetTextBounds(); // 0x00000001805B9A70-0x00000001805B9F20
		protected Bounds GetTextBounds(bool onlyVisibleCharacters); // 0x00000001805B9F20-0x00000001805BA410
		protected virtual void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x00000001803774A0-0x00000001803774B0
		protected void ResizeLineExtents(int size); // 0x00000001805BD940-0x00000001805BDC30
		public virtual TMP_TextInfo GetTextInfo(string text); // 0x000000018037DDC0-0x000000018037DDD0
		public virtual void ComputeMarginSize(); // 0x00000001803774A0-0x00000001803774B0
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count); // 0x00000001805C0070-0x00000001805C0490
		protected int RestoreWordWrappingState(ref WordWrapState state); // 0x00000001805BDC30-0x00000001805BE050
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor); // 0x00000001805BE050-0x00000001805BF330
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor); // 0x00000001805BF330-0x00000001805C0070
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4); // 0x00000001805B7B90-0x00000001805B8840
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric); // 0x00000001805B6230-0x00000001805B7B90
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4); // 0x00000001805B7B90-0x00000001805B8840
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor); // 0x00000001805B4710-0x00000001805B6230
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor); // 0x00000001805B3E90-0x00000001805B4710
		protected void LoadDefaultSettings(); // 0x00000001805BBC40-0x00000001805BBF20
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset); // 0x00000001805B9490-0x00000001805B9740
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c); // 0x00000001805BD8B0-0x00000001805BD940
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight); // 0x00000001805B8920-0x00000001805B89F0
		protected virtual void SetActiveSubMeshes(bool state); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void ClearSubMeshObjects(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void ClearMesh(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void ClearMesh(bool uploadGeometry); // 0x00000001803774A0-0x00000001803774B0
		public virtual string GetParsedText(); // 0x00000001805B89F0-0x00000001805B8B30
		protected Vector2 PackUV(float x, float y, float scale); // 0x00000001805BBF60-0x00000001805BBFA0
		protected float PackUV(float x, float y); // 0x00000001805BBF20-0x00000001805BBF60
		internal virtual void InternalUpdate(); // 0x00000001803774A0-0x00000001803774B0
		protected int HexToInt(char hex); // 0x00000001805BB6A0-0x00000001805BB7B0
		protected int GetUTF16(string text, int i); // 0x00000001805BA410-0x00000001805BA4F0
		protected int GetUTF16(StringBuilder text, int i); // 0x00000001805BA4F0-0x00000001805BA5D0
		protected int GetUTF32(string text, int i); // 0x00000001805BA760-0x00000001805BA8F0
		protected int GetUTF32(StringBuilder text, int i); // 0x00000001805BA5D0-0x00000001805BA760
		protected Color32 HexCharsToColor(char[] hexChars, int tagCount); // 0x00000001805BA8F0-0x00000001805BB290
		protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length); // 0x00000001805BB290-0x00000001805BB6A0
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters); // 0x00000001805B8840-0x00000001805B8920
		protected float ConvertToFloat(char[] chars, int startIndex, int length); // 0x00000001805B3CA0-0x00000001805B3CD0
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex); // 0x00000001805B3AD0-0x00000001805B3CA0
		protected bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex); // 0x00000001805C4370-0x00000001805CAA40
	}
}
