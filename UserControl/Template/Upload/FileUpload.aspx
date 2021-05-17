<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="Annex.UserControl.Template.Upload.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="node_modules/blueimp-file-upload/js/jquery.fileupload.js"></script>
    <link rel="shortcut icon" href="/assets/images/favicon.ico" />
    <link href="/plugins/morris/morris.css" rel="stylesheet" />
    <link href="/fonts/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="/assets/css/icons.css" rel="stylesheet" type="text/css" />
    <link href="/assets/css/style.css" rel="stylesheet" type="text/css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous"/>

</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-sm-2"></div>
            <div class="col-sm-2"><asp:FileUpload runat="server" ID="AddFiles" CssClass=" btn btn-success" Text="Add Files" /></div>
            
        </div>
    </form>
</body>
</html>
