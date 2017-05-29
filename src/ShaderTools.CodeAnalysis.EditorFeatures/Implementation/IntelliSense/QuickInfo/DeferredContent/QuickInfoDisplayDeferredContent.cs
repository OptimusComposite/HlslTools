﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Windows;

namespace ShaderTools.CodeAnalysis.Editor.Implementation.IntelliSense.QuickInfo
{
    internal class QuickInfoDisplayDeferredContent : IDeferredQuickInfoContent
    {
        private readonly IDeferredQuickInfoContent _symbolGlyph;
        private readonly IDeferredQuickInfoContent _mainDescription;
        private readonly IDeferredQuickInfoContent _documentation;
        private readonly IDeferredQuickInfoContent _typeParameterMap;
        private readonly IDeferredQuickInfoContent _anonymousTypes;
        private readonly IDeferredQuickInfoContent _usageText;
        private readonly IDeferredQuickInfoContent _exceptionText;
        private readonly IDeferredQuickInfoContent _warningGlyph;

        public QuickInfoDisplayDeferredContent(
            IDeferredQuickInfoContent symbolGlyph,
            IDeferredQuickInfoContent warningGlyph,
            IDeferredQuickInfoContent mainDescription,
            IDeferredQuickInfoContent documentation,
            IDeferredQuickInfoContent typeParameterMap,
            IDeferredQuickInfoContent anonymousTypes,
            IDeferredQuickInfoContent usageText,
            IDeferredQuickInfoContent exceptionText)
        {
            _symbolGlyph = symbolGlyph;
            _warningGlyph = warningGlyph;
            _mainDescription = mainDescription;
            _documentation = documentation;
            _typeParameterMap = typeParameterMap;
            _anonymousTypes = anonymousTypes;
            _usageText = usageText;
            _exceptionText = exceptionText;
        }

        public FrameworkElement Create()
        {
            FrameworkElement warningGlyphElement = null;
            if (_warningGlyph != null)
            {
                warningGlyphElement = _warningGlyph.Create();
            }

            FrameworkElement symbolGlyphElement = null;
            if (_symbolGlyph != null)
            {
                symbolGlyphElement = _symbolGlyph.Create();
            }

            return new QuickInfoDisplayPanel(
                symbolGlyphElement,
                warningGlyphElement,
                _mainDescription.Create(),
                _documentation.Create(),
                _typeParameterMap.Create(),
                _anonymousTypes.Create(),
                _usageText.Create(),
                _exceptionText.Create());
        }
    }
}
