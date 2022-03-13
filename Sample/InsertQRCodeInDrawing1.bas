'Remember to add Project Reference
'Tools>References>Browse to QRGen

Option Explicit On

Dim swApp As SldWorks.SldWorks

Sub main()

    'TODO error checking
    
    Set swApp = Application.SldWorks

    Dim omQRGen As New QRGen.QRGen

    'TODO Init
    omQRGen.Init

    'Test Image Formats
    Debug.Print omQRGen.CreateTempQR("Bitmap", ImageFormat.ImageFormat_Bmp)
    Debug.Print omQRGen.CreateTempQR("Jpeg", ImageFormat.ImageFormat_Jpeg)
    Debug.Print omQRGen.CreateTempQR("Png", ImageFormat.ImageFormat_Png)
    Debug.Print omQRGen.CreateTempQR("Tiff", ImageFormat.ImageFormat_Tiff)
        
    Dim userInput As String
    userInput = VBA.InputBox("Please Enter QR Text", "Insert QR Code in Sheet")

    'Test Insert
    Dim imageTempPath As String
    imageTempPath = omQRGen.CreateTempQR(userInput, ImageFormat.ImageFormat_Bmp)

    Dim swModel As SldWorks.ModelDoc2
    Set swModel = swApp.ActiveDoc
    
    swModel.SketchManager.InsertSketchPicture imageTempPath

End Sub
