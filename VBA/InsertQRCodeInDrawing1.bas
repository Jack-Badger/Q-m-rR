Attribute VB_Name = "InsertQRCodeInDrawing1"
Option Explicit

Dim swApp As SldWorks.SldWorks


Sub main()

    Set swApp = Application.SldWorks

    Dim omQRGen As New QRGen.QRGen
    
    'TODO Init
    omQRGen.Init

    Dim userInput As String
    
    userInput = VBA.InputBox("Please Enter QR Text", "Insert QR Code in Sheet")

    Dim imageTempPath As String

    imageTempPath = omQRGen.CreateQR(userInput)
    
    Dim swModel As SldWorks.ModelDoc2
    Set swModel = swApp.ActiveDoc
    
    swModel.SketchManager.InsertSketchPicture imageTempPath
    
    'TODO error checking
    
End Sub
