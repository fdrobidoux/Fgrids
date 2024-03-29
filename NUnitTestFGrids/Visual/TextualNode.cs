﻿using FGraph.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NUnitTestFGraph.Visual
{
    [DebuggerDisplay("{Text}")]
    public class TextNode : Node
    {
        public string Text { get; set; }

        public TextNode(VisualGraph graph, string text) : base(graph)
        {
            Text = text;
        }


    }
}
