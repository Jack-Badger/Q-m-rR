// <copyright file="ImageFormatEx.cs" company="TheFriendyCodlingCompany">
// Copyright (c) TheFriendyCodlingCompany. All rights reserved.
// </copyright>

namespace QÖmürR.QR
{
    using System;

    /// <summary>
    /// The image format ex.
    /// </summary>
    internal static class ImageFormatEx
    {
        /// <summary>
        /// Gets the system drawing image format.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns>A System.Drawing.Imaging.ImageFormat.</returns>
        internal static System.Drawing.Imaging.ImageFormat GetSystemDrawingImageFormat(this ImageFormat format)
        {
            switch (format)
            {
                case ImageFormat.Bmp: return System.Drawing.Imaging.ImageFormat.Bmp;
                case ImageFormat.Png: return System.Drawing.Imaging.ImageFormat.Png;
                case ImageFormat.Tiff: return System.Drawing.Imaging.ImageFormat.Tiff;
                case ImageFormat.Jpeg: return System.Drawing.Imaging.ImageFormat.Jpeg;

                default:
                    throw new ArgumentException("Format not supported.  [Bmp, Png, Tiff, Jpeg])", nameof(format));
            }
        }
    }
}
