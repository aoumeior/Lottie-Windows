﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Toolkit.Uwp.UI.Lottie.LottieToWinComp
{
    /// <summary>
    /// Issues.
    /// </summary>
    sealed class TranslationIssues
    {
        readonly HashSet<(string Code, string Description)> _issues = new HashSet<(string Code, string Description)>();
        readonly bool _throwOnIssue;

        internal TranslationIssues(bool throwOnIssue)
        {
            _throwOnIssue = throwOnIssue;
        }

        internal (string Code, string Description)[] GetIssues() => _issues.ToArray();

        internal void AnimatedRectangleWithTrimPathIsNotSupported() => Report("LT0001", "Rectangle with animated size and TrimPath is not supported");

        internal void AnimatedTrimOffsetWithStaticTrimOffsetIsNotSupported() => Report("LT0002", "Animated trim offset with static trim offset is not supported");

        internal void AnimationMultiplicationIsNotSupported() => Report("LT0003", "Multiplication of two or more animated values is not supported");

        internal void BlendModeNotNormal(string layer, string blendMode) => Report("LT0004", $"{layer} has {blendMode} as blend mode. Only Normal is supported.");

        internal void CombiningAnimatedShapesIsNotSupported() => Report("LT0005", "Combining animated shapes is not supported");

        internal void GradientFillIsNotSupported() => Report("LT0006", "Gradient fill is not supported");

        internal void GradientStrokeIsNotSupported() => Report("LT0007", "Gradient stroke is not supported");

        internal void ImageLayerIsNotSupported() => Report("LT0009", "Image layers are not supported");

        internal void MergingALargeNumberOfShapesIsNotSupported() => Report("LT0010", "Merging a large number of shape is not supported");

        internal void MultipleAnimatedRoundedCornersIsNotSupported() => Report("LT0011", "Multiple animated rounded corners is not supported");

        internal void MultipleFillsIsNotSupported() => Report("LT0012", "Multiple fills is not supported");

        internal void MultipleStrokesIsNotSupported() => Report("LT0013", "Multiple strokes is not supported");

        internal void MultipleTrimPathsIsNotSupported() => Report("LT0014", "Multiple trim paths is not supported");

        internal void OpacityAndColorAnimatedTogetherIsNotSupported() => Report("LT0015", "Opacity and color animated at the same time is not supported");

        internal void PathWithRoundedCornersIsNotSupported() => Report("LT0016", "Path with rounded corners is not supported");

        internal void PolystarIsNotSupported() => Report("LT0017", "Polystar is not supported");

        internal void RepeaterIsNotSupported() => Report("LT0018", "Repeater is not supported");

        internal void TextLayerIsNotSupported() => Report("LT0019", "Text layer is not supported");

        internal void ThreeDIsNotSupported() => Report("LT0020", "3d composition is not supported");

        internal void ThreeDLayerIsNotSupported() => Report("LT0021", "3d layer is not supported");

        internal void TimeStretchIsNotSupported() => Report("LT0022", "Time stretch is not supported");

        internal void MaskWithInvertIsNotSupported() => Report("LT0023", "Mask with invert is not supported");

        internal void MaskWithUnsupportedMode(string mode) => Report("LT0024", $"Mask mode: {mode} is not supported");

        internal void MaskWithAlphaIsNotSupported() => Report("LT0025", "Mask with alpha value other than 1 is not supported");

        internal void MultipleShapeMasksIsNotSupported() => Report("LT0026", "Mask with multiple shapes is not supported");

        internal void CombiningMultipleShapesIsNotSupported() => Report("LT0027", "Combining multiple shapes is not supported");

        internal void ReferencedAssetDoesNotExist(string RefId) => Report("LT0028", $"Referenced asset {RefId} does not exist");

        internal void InvalidAssetReferenceFromLayer(string layerType, string assetRefId, string assetType, string expectedAssetType) => Report("LT0029", $"{layerType} referenced asset {assetRefId} of type {assetType} which is invalid. Expected an asset of type {expectedAssetType}.");

        internal void ImageFileExpected(string filePath) => Report("LT0030", $"Image file expected at {filePath}");

        void Report(string code, string description)
        {
            _issues.Add((code, description));

            if (_throwOnIssue)
            {
                throw new NotSupportedException($"{code}: {description}");
            }
        }
    }
}
