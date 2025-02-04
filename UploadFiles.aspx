<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadFiles.aspx.cs" Inherits="FileUploading.UploadFiles" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload Multiple Files</title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fileUpload" runat="server" AllowMultiple="true" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload"  OnClick="btnUpload_Click" />
            <asp:Label ID="lblStatus" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>