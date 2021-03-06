﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;

namespace ShaderTools.CodeAnalysis.Editor.Commands
{
    /// <summary>
    /// Arguments for the Down arrow key being pressed.
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal class DownKeyCommandArgs : CommandArgs
    {
        public DownKeyCommandArgs(ITextView textView, ITextBuffer subjectBuffer)
            : base(textView, subjectBuffer)
        {
        }
    }
}
