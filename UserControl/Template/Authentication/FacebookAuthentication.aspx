<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacebookAuthentication.aspx.cs" Inherits="Annex.UserControl.Template.Authentication.FacebookAuthentication" %>
<html>

<head>

<title>Login from Facebook </title>

<script type="text/javascript" src="http://code.jquery.com/jquery-latest.js"></script>

</head>

<body>

<script>

    // Load the SDK Asynchronously

    (function (d) {

        var js, id = 'facebook-jssdk', ref = d.getElementsByTagName('script')[0];

        if (d.getElementById(id)) { return; }

        js = d.createElement('script'); js.id = id; js.async = true;

        js.src = "//connect.facebook.net/en_US/all.js";

        ref.parentNode.insertBefore(js, ref);

    }(document));

    // Init the SDK upon load

    window.fbAsyncInit = function () {

        FB.init({

            appId: '238344797688422', // App ID

            channelUrl: '//' + window.location.hostname + '/channel', // Path to your Channel File

            status: true, // check login status

            cookie: true, // enable cookies to allow the server to access the session

            xfbml: true  // parse XFBML

        });

        // listen for and handle auth.statusChange events

        FB.Event.subscribe('auth.statusChange', function (response) {

            if (response.authResponse) {

                // user has auth'd your app and is logged into Facebook

                FB.api('/me', function (me) {

                    if (me.name) {

                        document.getElementById('auth-displayname').innerHTML = me.name;
                        document.getElementById('DisplayEmail').innerHTML = me.email;
                    }

                })

                document.getElementById('auth-loggedout').style.display = 'none';

                document.getElementById('auth-loggedin').style.display = 'block';

            } else {

                // user has not auth'd your app, or is not logged into Facebook

                document.getElementById('auth-loggedout').style.display = 'block';

                document.getElementById('auth-loggedin').style.display = 'none';

            }

        });

        $("#auth-logoutlink").click(function () { FB.logout(function () { window.location.reload(); }); });

    }

</script>

<h1>

    Login from Facebook</h1>

<div id="auth-status">

<div id="auth-loggedout">

 

<div class="fb-login-button" autologoutlink="true" scope="email">Login with Facebook</div>

</div>

<div id="auth-loggedin" style="display: none">

Hi, <span id="auth-displayname"></span>
Your Email : <span id="DisplayEmail"></span><br/>
</div>

</div>

</body>

</html>