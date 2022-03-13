// <copyright file="QRGen.cs" company="TheFriendyCodlingCompany">
// Copyright (c) TheFriendyCodlingCompany. All rights reserved.
// </copyright>

namespace QÖmürR.QR
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Runtime.InteropServices;
    using QRCoder;

    /// <summary>
    /// The q r gen.
    /// </summary>
    [ComVisible(true)]
    [Guid("4ADC7747-B8C1-41DE-AEE3-4E245FA4178E")]
    [ClassInterface(ClassInterfaceType.None)]
    public class QRGen : IQRGen
    {
        private readonly string tempPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="QRGen"/> class.
        /// </summary>
        public QRGen()
        {
            this.tempPath = Path.GetTempPath();
        }

        /// <inheritdoc/>
        public string CreateTempQR(string text, ImageFormat imageFormat)
        {
            try
            {
                string path;

                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);

                    path = this.tempPath + Path.GetRandomFileName() + '.' + imageFormat.ToString().ToLower();

                    qrCodeImage.Save(path, imageFormat.GetSystemDrawingImageFormat());
                }

                return path;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <inheritdoc/>
        public bool Init()
        {
            return true;
        }
    }
}