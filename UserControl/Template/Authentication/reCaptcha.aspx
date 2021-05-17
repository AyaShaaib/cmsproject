<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reCaptcha.aspx.cs" Inherits="Annex.UserControl.Template.Authentication.reCaptcha" %>

<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<!DOCTYPE html>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>  
</head>
<body>
    <form id="form1" runat="server" method="post" onsubmit="return submitUserForm();">
     
        <div>
            <h3>Recaptcha</h3>
        </div>
        <div>
            <div class="g-recaptcha" data-sitekey="6LfAgyEaAAAAABPt9BH-aT23XE3kfhqyfCAXcx9e" data-callback="verifyCaptcha"></div>
            <div id="g-recaptcha-error"></div> 
        </div>
        <br />
        <div class="col-2">
           <input type="submit" name="submit" value="Submit" class="btn-primary"/>
        </div>
    
    </form>
    <script src='https://www.google.com/recaptcha/api.js'></script>
    <script>
        function submitUserForm() {
            var response = grecaptcha.getResponse();
            if (response.length == 0) {
                document.getElementById('g-recaptcha-error').innerHTML = '<span style="color:red;">This field is required.</span>';
                return false;
            }
            return true;
        }

        function verifyCaptcha() {
            document.getElementById('g-recaptcha-error').innerHTML = '';
        }
</script>
</body>

</html>