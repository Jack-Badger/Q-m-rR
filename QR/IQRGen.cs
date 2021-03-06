// <copyright file="IQRGen.cs" company="TheFriendyCodlingCompany">
// Copyright (c) TheFriendyCodlingCompany. All rights reserved.
// </copyright>

namespace QÖmürR.QR
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The q r generator.
    /// </summary>
    [ComVisible(true)]
    [Guid("6665C9A9-EF6B-408E-8E6D-F9DEEE381C09")]
    [TypeLibImportClass(typeof(QRGen))]
    public interface IQRGen
    {
        /// <summary>
        /// Inits the qr generator.
        /// </summary>
        /// <returns>A bool.</returns>
        bool Init();

        /// <summary>
        /// Creates the temp q r.
        /// </summary>
        /// <param name="embedText">The embed text.</param>
        /// <param name="imageFormat">The image format.</param>
        /// <returns>A string.</returns>
        string CreateTempQR(string embedText, [MarshalAs(UnmanagedType.I4)] ImageFormat imageFormat);
    }
}