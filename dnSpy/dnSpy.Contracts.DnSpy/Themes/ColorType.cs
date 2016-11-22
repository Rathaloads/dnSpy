﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace dnSpy.Contracts.Themes {
	/// <summary>
	/// Color type
	/// </summary>
	public enum ColorType : uint {
#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
		// The order and names of the following constants must match dnSpy.Contracts.Text.TextColor
		Text = 0x00004000,
		FirstNR = Text, // Text should be first so ToString() picks it instead of FirstNR
		Operator,
		Punctuation,
		Number,
		Comment,
		Keyword,
		String,
		VerbatimString,
		Char,
		Namespace,
		Type,
		SealedType,
		StaticType,
		Delegate,
		Enum,
		Interface,
		ValueType,
		Module,
		TypeGenericParameter,
		MethodGenericParameter,
		InstanceMethod,
		StaticMethod,
		ExtensionMethod,
		InstanceField,
		EnumField,
		LiteralField,
		StaticField,
		InstanceEvent,
		StaticEvent,
		InstanceProperty,
		StaticProperty,
		Local,
		Parameter,
		PreprocessorKeyword,
		PreprocessorText,
		Label,
		OpCode,
		ILDirective,
		ILModule,
		ExcludedCode,
		XmlDocCommentAttributeName,
		XmlDocCommentAttributeQuotes,
		XmlDocCommentAttributeValue,
		XmlDocCommentCDataSection,
		XmlDocCommentComment,
		XmlDocCommentDelimiter,
		XmlDocCommentEntityReference,
		XmlDocCommentName,
		XmlDocCommentProcessingInstruction,
		XmlDocCommentText,
		XmlLiteralAttributeName,
		XmlLiteralAttributeQuotes,
		XmlLiteralAttributeValue,
		XmlLiteralCDataSection,
		XmlLiteralComment,
		XmlLiteralDelimiter,
		XmlLiteralEmbeddedExpression,
		XmlLiteralEntityReference,
		XmlLiteralName,
		XmlLiteralProcessingInstruction,
		XmlLiteralText,
		XmlAttribute,
		XmlAttributeQuotes,
		XmlAttributeValue,
		XmlCDataSection,
		XmlComment,
		XmlDelimiter,
		XmlKeyword,
		XmlName,
		XmlProcessingInstruction,
		XmlText,
		XamlAttribute,
		XamlAttributeQuotes,
		XamlAttributeValue,
		XamlCDataSection,
		XamlComment,
		XamlDelimiter,
		XamlKeyword,
		XamlMarkupExtensionClass,
		XamlMarkupExtensionParameterName,
		XamlMarkupExtensionParameterValue,
		XamlName,
		XamlProcessingInstruction,
		XamlText,
		XmlDocToolTipHeader,
		Assembly,
		AssemblyExe,
		AssemblyModule,
		DirectoryPart,
		FileNameNoExtension,
		FileExtension,
		Error,
		ToStringEval,
		ReplPrompt1,
		ReplPrompt2,
		ReplOutputText,
		ReplScriptOutputText,
		Black,
		Blue,
		Cyan,
		DarkBlue,
		DarkCyan,
		DarkGray,
		DarkGreen,
		DarkMagenta,
		DarkRed,
		DarkYellow,
		Gray,
		Green,
		Magenta,
		Red,
		White,
		Yellow,
		InvBlack,
		InvBlue,
		InvCyan,
		InvDarkBlue,
		InvDarkCyan,
		InvDarkGray,
		InvDarkGreen,
		InvDarkMagenta,
		InvDarkRed,
		InvDarkYellow,
		InvGray,
		InvGreen,
		InvMagenta,
		InvRed,
		InvWhite,
		InvYellow,
		DebugLogExceptionHandled,
		DebugLogExceptionUnhandled,
		DebugLogStepFiltering,
		DebugLogLoadModule,
		DebugLogUnloadModule,
		DebugLogExitProcess,
		DebugLogExitThread,
		DebugLogProgramOutput,
		DebugLogMDA,
		DebugLogTimestamp,
		LineNumber,
		ReplLineNumberInput1,
		ReplLineNumberInput2,
		ReplLineNumberOutput,
		VisibleWhitespace,
		SelectedText,
		InactiveSelectedText,
		HighlightedReference,
		HighlightedWrittenReference,
		HighlightedDefinition,
		CurrentStatement,
		CurrentStatementMarker,
		CallReturn,
		CallReturnMarker,
		ActiveStatementMarker,
		BreakpointStatement,
		BreakpointStatementMarker,
		SelectedBreakpointStatementMarker,
		DisabledBreakpointStatementMarker,
		CurrentLine,
		CurrentLineNoFocus,
		HexText,
		HexOffset,
		HexByte0,
		HexByte1,
		HexByteError,
		HexAscii,
		HexCaret,
		HexInactiveCaret,
		HexSelection,
		GlyphMargin,
		BraceMatching,
		LineSeparator,
		FindMatchHighlightMarker,
		BlockStructureNamespace,
		BlockStructureType,
		BlockStructureModule,
		BlockStructureValueType,
		BlockStructureInterface,
		BlockStructureMethod,
		BlockStructureAccessor,
		BlockStructureAnonymousMethod,
		BlockStructureConstructor,
		BlockStructureDestructor,
		BlockStructureOperator,
		BlockStructureConditional,
		BlockStructureLoop,
		BlockStructureProperty,
		BlockStructureEvent,
		BlockStructureTry,
		BlockStructureCatch,
		BlockStructureFilter,
		BlockStructureFinally,
		BlockStructureFault,
		BlockStructureLock,
		BlockStructureUsing,
		BlockStructureFixed,
		BlockStructureSwitch,
		BlockStructureCase,
		BlockStructureLocalFunction,
		BlockStructureOther,
		BlockStructureXml,
		BlockStructureXaml,
		CompletionMatchHighlight,
		CompletionSuffix,
		SignatureHelpDocumentation,
		SignatureHelpCurrentParameter,
		SignatureHelpParameter,
		SignatureHelpParameterDocumentation,
		Url,
		HexPeDosHeader,
		HexPeFileHeader,
		HexPeOptionalHeader32,
		HexPeOptionalHeader64,
		HexPeSection,
		HexPeSectionName,
		HexCor20Header,
		HexStorageSignature,
		HexStorageHeader,
		HexStorageStream,
		HexStorageStreamName,
		HexStorageStreamNameInvalid,
		HexTablesStream,
		HexTableName,
		DocumentListMatchHighlight,
		GacMatchHighlight,
		AppSettingsTreeViewNodeMatchHighlight,
		AppSettingsTextMatchHighlight,
		HexCurrentLine,
		HexCurrentLineNoFocus,
		HexInactiveSelectedText,

		// Must be last in this group
		LastNR,






		// ********************************************************************************
		// ONLY APPEND VALUES. DON'T REMOVE SORT OR RENAME ANYTHING. (unless you can recompile
		// EVERYTHING that depend on these values)
		// ********************************************************************************
		DefaultText = 0x00100000,
		FirstUI = DefaultText,

		SystemColorsControl,
		SystemColorsControlDark,
		SystemColorsControlDarkDark,
		SystemColorsControlLight,
		SystemColorsControlLightLight,
		SystemColorsControlText,
		SystemColorsGrayText,
		SystemColorsHighlight,
		SystemColorsHighlightText,
		SystemColorsInactiveCaption,
		SystemColorsInactiveCaptionText,
		SystemColorsInactiveSelectionHighlight,
		SystemColorsInactiveSelectionHighlightText,
		SystemColorsMenuText,
		SystemColorsWindow,
		SystemColorsWindowText,
		PEHex,
		PEHexBorder,
		DialogWindow,
		DialogWindowActiveCaption,
		DialogWindowActiveDebuggingBorder,
		DialogWindowActiveDefaultBorder,
		DialogWindowButtonHoverInactive,
		DialogWindowButtonHoverInactiveBorder,
		DialogWindowButtonHoverInactiveGlyph,
		DialogWindowButtonInactiveBorder,
		DialogWindowButtonInactiveGlyph,
		DialogWindowInactiveBorder,
		DialogWindowInactiveCaption,
		EnvironmentBackgroundBrush,
		EnvironmentBackground,
		EnvironmentForeground,
		EnvironmentMainWindowActiveCaption,
		EnvironmentMainWindowActiveDebuggingBorder,
		EnvironmentMainWindowActiveDefaultBorder,
		EnvironmentMainWindowButtonActiveBorder,
		EnvironmentMainWindowButtonActiveGlyph,
		EnvironmentMainWindowButtonDown,
		EnvironmentMainWindowButtonDownBorder,
		EnvironmentMainWindowButtonDownGlyph,
		EnvironmentMainWindowButtonHoverActive,
		EnvironmentMainWindowButtonHoverActiveBorder,
		EnvironmentMainWindowButtonHoverActiveGlyph,
		EnvironmentMainWindowButtonHoverInactive,
		EnvironmentMainWindowButtonHoverInactiveBorder,
		EnvironmentMainWindowButtonHoverInactiveGlyph,
		EnvironmentMainWindowButtonInactiveBorder,
		EnvironmentMainWindowButtonInactiveGlyph,
		EnvironmentMainWindowInactiveBorder,
		EnvironmentMainWindowInactiveCaption,
		ControlShadow,
		GridSplitterPreviewFill,
		GroupBoxBorderBrush,
		TopLevelMenuHeaderHoverBorder,
		TopLevelMenuHeaderHover,
		MenuItemSeparatorFillTop,
		MenuItemSeparatorFillBottom,
		MenuItemGlyphPanelBorderBrush,
		MenuItemHighlightedInnerBorder,
		MenuItemDisabledForeground,
		MenuItemDisabledGlyphPanelBackground,
		MenuItemDisabledGlyphFill,
		ToolBarButtonPressed,
		ToolBarSeparatorFill,
		ToolBarButtonHover,
		ToolBarButtonHoverBorder,
		ToolBarButtonPressedBorder,
		ToolBarMenuBorder,
		ToolBarSubMenuBackground,
		ToolBarButtonChecked,
		ToolBarOpenHeaderBackground,
		ToolBarIconVerticalBackground,
		ToolBarVerticalBackground,
		ToolBarIconBackground,
		ToolBarHorizontalBackground,
		ToolBarDisabledFill,
		ToolBarDisabledBorder,
		EnvironmentCommandBar,
		EnvironmentCommandBarIcon,
		EnvironmentCommandBarMenuMouseOverSubmenuGlyph,
		EnvironmentCommandBarMenuSeparator,
		EnvironmentCommandBarCheckBox,
		EnvironmentCommandBarSelectedIcon,
		EnvironmentCommandBarCheckBoxMouseOver,
		EnvironmentCommandBarHoverOverSelectedIcon,
		EnvironmentCommandBarMenuItemMouseOver,
		CommonControlsButtonIconBackground,
		CommonControlsButton,
		CommonControlsButtonBorder,
		CommonControlsButtonBorderDefault,
		CommonControlsButtonBorderDisabled,
		CommonControlsButtonBorderFocused,
		CommonControlsButtonBorderHover,
		CommonControlsButtonBorderPressed,
		CommonControlsButtonDefault,
		CommonControlsButtonDisabled,
		CommonControlsButtonFocused,
		CommonControlsButtonHover,
		CommonControlsButtonPressed,
		CommonControlsCheckBoxBackground,
		CommonControlsCheckBoxBackgroundDisabled,
		CommonControlsCheckBoxBackgroundFocused,
		CommonControlsCheckBoxBackgroundHover,
		CommonControlsCheckBoxBackgroundPressed,
		CommonControlsCheckBoxBorder,
		CommonControlsCheckBoxBorderDisabled,
		CommonControlsCheckBoxBorderFocused,
		CommonControlsCheckBoxBorderHover,
		CommonControlsCheckBoxBorderPressed,
		CommonControlsCheckBoxGlyph,
		CommonControlsCheckBoxGlyphDisabled,
		CommonControlsCheckBoxGlyphFocused,
		CommonControlsCheckBoxGlyphHover,
		CommonControlsCheckBoxGlyphPressed,
		CommonControlsCheckBoxText,
		CommonControlsCheckBoxTextDisabled,
		CommonControlsCheckBoxTextFocused,
		CommonControlsCheckBoxTextHover,
		CommonControlsCheckBoxTextPressed,
		CommonControlsComboBoxBackground,
		CommonControlsComboBoxBackgroundDisabled,
		CommonControlsComboBoxBackgroundFocused,
		CommonControlsComboBoxBackgroundHover,
		CommonControlsComboBoxBackgroundPressed,
		CommonControlsComboBoxBorder,
		CommonControlsComboBoxBorderDisabled,
		CommonControlsComboBoxBorderFocused,
		CommonControlsComboBoxBorderHover,
		CommonControlsComboBoxBorderPressed,
		CommonControlsComboBoxGlyph,
		CommonControlsComboBoxGlyphBackground,
		CommonControlsComboBoxGlyphBackgroundDisabled,
		CommonControlsComboBoxGlyphBackgroundFocused,
		CommonControlsComboBoxGlyphBackgroundHover,
		CommonControlsComboBoxGlyphBackgroundPressed,
		CommonControlsComboBoxGlyphDisabled,
		CommonControlsComboBoxGlyphFocused,
		CommonControlsComboBoxGlyphHover,
		CommonControlsComboBoxGlyphPressed,
		CommonControlsComboBoxListBackground,
		CommonControlsComboBoxListBorder,
		CommonControlsComboBoxListItemBackgroundHover,
		CommonControlsComboBoxListItemBorderHover,
		CommonControlsComboBoxListItemText,
		CommonControlsComboBoxListItemTextHover,
		CommonControlsComboBoxSeparator,
		CommonControlsComboBoxSeparatorFocused,
		CommonControlsComboBoxSeparatorHover,
		CommonControlsComboBoxSeparatorPressed,
		CommonControlsComboBoxText,
		CommonControlsComboBoxTextDisabled,
		CommonControlsComboBoxTextFocused,
		CommonControlsComboBoxTextHover,
		CommonControlsComboBoxTextInputSelection,
		CommonControlsComboBoxTextPressed,
		CommonControlsRadioButtonBackground,
		CommonControlsRadioButtonBackgroundDisabled,
		CommonControlsRadioButtonBackgroundFocused,
		CommonControlsRadioButtonBackgroundHover,
		CommonControlsRadioButtonBackgroundPressed,
		CommonControlsRadioButtonBorder,
		CommonControlsRadioButtonBorderDisabled,
		CommonControlsRadioButtonBorderFocused,
		CommonControlsRadioButtonBorderHover,
		CommonControlsRadioButtonBorderPressed,
		CommonControlsRadioButtonGlyph,
		CommonControlsRadioButtonGlyphDisabled,
		CommonControlsRadioButtonGlyphFocused,
		CommonControlsRadioButtonGlyphHover,
		CommonControlsRadioButtonGlyphPressed,
		CommonControlsRadioButtonText,
		CommonControlsRadioButtonTextDisabled,
		CommonControlsRadioButtonTextFocused,
		CommonControlsRadioButtonTextHover,
		CommonControlsRadioButtonTextPressed,
		CommonControlsTextBox,
		CommonControlsTextBoxBorder,
		CommonControlsTextBoxBorderDisabled,
		CommonControlsTextBoxBorderError,
		CommonControlsTextBoxBorderFocused,
		CommonControlsTextBoxDisabled,
		CommonControlsTextBoxError,
		CommonControlsTextBoxFocused,
		CommonControlsTextBoxMouseOverBorder,
		CommonControlsTextBoxSelection,
		CommonControlsFocusVisual,
		TabItemForeground,
		TabItemStaticBackground,
		TabItemStaticBorder,
		TabItemMouseOverBackground,
		TabItemMouseOverBorder,
		TabItemSelectedBackground,
		TabItemSelectedBorder,
		TabItemDisabledBackground,
		TabItemDisabledBorder,
		ListBoxBackground,
		ListBoxBorder,
		ListBoxItemMouseOverBackground,
		ListBoxItemMouseOverBorder,
		ListBoxItemSelectedInactiveBackground,
		ListBoxItemSelectedInactiveBorder,
		ListBoxItemSelectedActiveBackground,
		ListBoxItemSelectedActiveBorder,
		ContextMenuBackground,
		ContextMenuBorderBrush,
		ContextMenuRectangleFill,
		ExpanderStaticCircleStroke,
		ExpanderStaticCircleFill,
		ExpanderStaticArrowStroke,
		ExpanderMouseOverCircleStroke,
		ExpanderMouseOverCircleFill,
		ExpanderMouseOverArrowStroke,
		ExpanderPressedCircleStroke,
		ExpanderPressedCircleFill,
		ExpanderPressedArrowStroke,
		ExpanderDisabledCircleStroke,
		ExpanderDisabledCircleFill,
		ExpanderDisabledArrowStroke,
		ProgressBarProgress,
		ProgressBarBackground,
		ProgressBarBorder,
		ResizeGripperForeground,
		EnvironmentScrollBarArrowBackground,
		EnvironmentScrollBarArrowDisabledBackground,
		EnvironmentScrollBarArrowGlyph,
		EnvironmentScrollBarArrowGlyphDisabled,
		EnvironmentScrollBarArrowGlyphMouseOver,
		EnvironmentScrollBarArrowGlyphPressed,
		EnvironmentScrollBarArrowMouseOverBackground,
		EnvironmentScrollBarArrowPressedBackground,
		EnvironmentScrollBarBackground,
		EnvironmentScrollBarBorder,
		EnvironmentScrollBarThumbBackground,
		EnvironmentScrollBarThumbDisabled,
		EnvironmentScrollBarThumbMouseOverBackground,
		EnvironmentScrollBarThumbPressedBackground,
		StatusBarDebugging,
		ToolTipBackground,
		ToolTipBorderBrush,
		ToolTipForeground,
		ScreenTip,
		ScreenTipBorder,
		CompletionToolTip,
		CompletionToolTipBorder,
		QuickInfo,
		QuickInfoBorder,
		SignatureHelp,
		SignatureHelpBorder,
		CilButton,
		CilButtonBorder,
		CilButtonBorderFocused,
		CilButtonBorderHover,
		CilButtonBorderPressed,
		CilButtonError,
		CilButtonErrorBorder,
		CilButtonFocused,
		CilButtonHover,
		CilButtonPressed,
		CilCheckBoxBackground,
		CilCheckBoxBackgroundDisabled,
		CilCheckBoxBackgroundFocused,
		CilCheckBoxBackgroundHover,
		CilCheckBoxBackgroundPressed,
		CilCheckBoxBorder,
		CilCheckBoxBorderDisabled,
		CilCheckBoxBorderFocused,
		CilCheckBoxBorderHover,
		CilCheckBoxBorderPressed,
		CilCheckBoxGlyph,
		CilCheckBoxGlyphDisabled,
		CilCheckBoxGlyphFocused,
		CilCheckBoxGlyphHover,
		CilCheckBoxGlyphPressed,
		CilCheckBoxText,
		CilCheckBoxTextDisabled,
		CilCheckBoxTextFocused,
		CilCheckBoxTextHover,
		CilCheckBoxTextPressed,
		CilComboBoxBorderFocused,
		CilComboBoxBorderHover,
		CilComboBoxBorderPressed,
		CilComboBoxError,
		CilComboBoxErrorBorder,
		CilComboBoxListBackground,
		CilComboBoxListBorder,
		CilComboBoxListItemBackgroundHover,
		CilComboBoxListItemBorderHover,
		CilComboBoxListItemTextHover,
		CilGridViewBorder,
		CilGridViewItemContainerMouseOverHoverBorder,
		CilGridViewItemContainerSelectedBorder,
		CilGridViewItemContainerSelectedInactiveBorder,
		CilGridViewItemContainerSelectedMouseOverBorder,
		CilGridViewListItemHoverFill,
		CilGridViewListItemSelectedFill,
		CilGridViewListItemSelectedHoverFill,
		CilGridViewListItemSelectedInactiveFill,
		CilGridViewListViewItemFocusVisualStroke,
		CilListBoxBorder,
		CilListBoxItemMouseOverBackground,
		CilListBoxItemMouseOverBorder,
		CilListBoxItemSelectedActiveBackground,
		CilListBoxItemSelectedActiveBorder,
		CilListBoxItemSelectedInactiveBackground,
		CilListBoxItemSelectedInactiveBorder,
		CilListViewItem0,
		CilListViewItem1,
		CilTextBoxDisabled,
		CilTextBoxDisabledBorder,
		CilTextBoxError,
		CilTextBoxErrorBorder,
		CilTextBoxFocusedBorder,
		CilTextBoxMouseOverBorder,
		CilTextBoxSelection,
		GridViewBackground,
		GridViewBorder,
		HeaderDefault,
		HeaderGlyph,
		HeaderMouseDown,
		HeaderMouseOver,
		HeaderMouseOverGlyph,
		HeaderSeparatorLine,
		GridViewListViewForeground,
		GridViewItemContainerMouseOverHoverBorder,
		GridViewItemContainerSelectedBorder,
		GridViewItemContainerSelectedInactiveBorder,
		GridViewItemContainerSelectedMouseOverBorder,
		GridViewListItemHoverFill,
		GridViewListItemSelectedFill,
		GridViewListItemSelectedHoverFill,
		GridViewListItemSelectedInactiveFill,
		GridViewListViewItemFocusVisualStroke,
		DecompilerTextViewWaitAdorner,
		ListArrowBackground,
		TreeViewItemMouseOver,
		TreeViewItemSelected,
		TreeView,
		TreeViewBorder,
		TreeViewGlyph,
		TreeViewGlyphMouseOver,
		TVItemAlternationBackground,
		AppSettingsTreeView,
		AppSettingsTreeViewBorder,
		EnvironmentFileTabBackground,
		EnvironmentFileTabBorder,
		EnvironmentFileTabButtonDownInactiveBorder,
		EnvironmentFileTabButtonDownInactive,
		EnvironmentFileTabButtonDownInactiveGlyph,
		EnvironmentFileTabButtonDownSelectedActiveBorder,
		EnvironmentFileTabButtonDownSelectedActive,
		EnvironmentFileTabButtonDownSelectedActiveGlyph,
		EnvironmentFileTabButtonDownSelectedInactiveBorder,
		EnvironmentFileTabButtonDownSelectedInactive,
		EnvironmentFileTabButtonDownSelectedInactiveGlyph,
		EnvironmentFileTabButtonHoverInactiveBorder,
		EnvironmentFileTabButtonHoverInactive,
		EnvironmentFileTabButtonHoverInactiveGlyph,
		EnvironmentFileTabButtonHoverSelectedActiveBorder,
		EnvironmentFileTabButtonHoverSelectedActive,
		EnvironmentFileTabButtonHoverSelectedActiveGlyph,
		EnvironmentFileTabButtonHoverSelectedInactiveBorder,
		EnvironmentFileTabButtonHoverSelectedInactive,
		EnvironmentFileTabButtonHoverSelectedInactiveGlyph,
		EnvironmentFileTabButtonSelectedActiveGlyph,
		EnvironmentFileTabButtonSelectedInactiveGlyph,
		EnvironmentFileTabInactiveBorder,
		EnvironmentFileTabInactiveGradient,
		EnvironmentFileTabInactiveText,
		EnvironmentFileTabSelectedBorder,
		EnvironmentFileTabSelectedGradient,
		EnvironmentFileTabSelectedText,
		EnvironmentFileTabText,
		EnvironmentFileTabHotGradient,
		EnvironmentFileTabHotBorder,
		EnvironmentFileTabHotText,
		EnvironmentFileTabHotGlyph,
		EnvironmentTitleBarActive,
		EnvironmentTitleBarActiveBorder,
		EnvironmentTitleBarActiveGradient,
		EnvironmentTitleBarDragHandle,
		EnvironmentTitleBarDragHandleActive,
		EnvironmentTitleBarInactive,
		EnvironmentTitleBarInactiveBorder,
		EnvironmentTitleBarInactiveGradient,
		EnvironmentToolWindow,
		EnvironmentToolWindowBorder,
		EnvironmentToolWindowButtonActiveGlyph,
		EnvironmentToolWindowButtonDown,
		EnvironmentToolWindowButtonDownActiveGlyph,
		EnvironmentToolWindowButtonDownBorder,
		EnvironmentToolWindowButtonHoverActive,
		EnvironmentToolWindowButtonHoverActiveBorder,
		EnvironmentToolWindowButtonHoverActiveGlyph,
		EnvironmentToolWindowButtonHoverInactive,
		EnvironmentToolWindowButtonHoverInactiveBorder,
		EnvironmentToolWindowButtonHoverInactiveGlyph,
		EnvironmentToolWindowButtonInactiveGlyph,
		EnvironmentToolWindowTabBorder,
		EnvironmentToolWindowTabGradient,
		EnvironmentToolWindowTabMouseOverBackgroundGradient,
		EnvironmentToolWindowTabMouseOverBorder,
		EnvironmentToolWindowTabMouseOverText,
		EnvironmentToolWindowTabSelectedActiveText,
		EnvironmentToolWindowTabSelectedBorder,
		EnvironmentToolWindowTabSelectedTab,
		EnvironmentToolWindowTabSelectedText,
		EnvironmentToolWindowTabText,
		SearchBoxWatermark,
		MemoryWindowDisabled,
		TreeViewNode,
		EnvironmentDropDownGlyph,
		EnvironmentDropDownMouseOverGlyph,
		EnvironmentDropDownMouseDownGlyph,
		EnvironmentCommandBarMouseOverBackground,
		EnvironmentCommandBarMouseDownBackground,
		EnvironmentComboBoxDisabledBackground,
		EnvironmentIconGeneralStroke,
		EnvironmentIconGeneralFill,
		EnvironmentIconActionFill,
		SearchControlMouseOverDropDownButtonGlyph,

		// Add new color types before this comment

		LastUI,
#pragma warning restore 1591 // Missing XML comment for publicly visible type or member
	}
}
