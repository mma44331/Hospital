<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Hospital.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"  dir="rtl">
<head runat="server">
    
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
<meta name="description" content="">
<meta name="author" content="">
<link rel="icon" href="favicon.ico">
<title>הרשמה למערכת</title>
<!-- Simple bar CSS -->
<link rel="stylesheet" href="css/simplebar.css">
   <%-- <link rel="stylesheet" href="css/stylesheet1.css">--%>
<!-- Fonts CSS -->
<link href="https://fonts.googleapis.com/css2?family=Overpass:ital,wght@0,100;0,200;0,300;0,400;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,600;1,700;1,800;1,900&display=swap" rel="stylesheet">
<!-- Icons CSS -->
<link rel="stylesheet" href="css/feather.css">
<!-- Date Range Picker CSS -->
<link rel="stylesheet" href="css/daterangepicker.css">
<!-- App CSS -->
<link rel="stylesheet" href="css/app-light.css" id="lightTheme">
<link rel="stylesheet" href="css/app-dark.css" id="darkTheme" disabled>
</head>
  <body class="light rtl">
    <div class="wrapper vh-100">
      <div class="row align-items-center h-100">
        <form class="col-lg-3 col-md-4 col-10 mx-auto text-center">
          <a class="navbar-brand mx-auto mt-2 flex-fill text-center">
                <img src="/BackAdmin/images/לוגו אסותא.gif" width="100%" height="100%"/>
          </a>
            <form id="form1" runat="server">
            <div class="form-group">
                <label for="FullName" class="sr-only">שם מלא</label>
                <asp:TextBox id="FullName" runat="server" class="form-control form-control-lg" placeholder="שם מלא" />
                </div>
          <div class="form-group">
            <label for="Email" class="sr-only">כתובת אימייל</label>
            <asp:TextBox id="Email" runat="server" TextMode="Email"  class="form-control form-control-lg" placeholder="כתובת אימייל" />
          </div>
          <div class="form-group">
            <label for="Password" class="sr-only">סיסמה</label>
            <asp:TextBox  id="Password" runat="server" TextMode="Password" class="form-control form-control-lg" placeholder="סיסמה"/>
          </div>
                <div class="row">
                  <div class="col-md-10 col-sm-3">
                    <asp:Literal Id="LtlMsg" Runat="server"/>
                 </div>
                 </div>
          <div class="checkbox mb-3">
            <label>
              <input type="checkbox" value="remember-me"> זכור אותי </label>
          </div>
          <asp:button id="BtnLogin" runat="server" class="btn btn-lg btn-primary btn-block" type="submit" Text="התחברות" OnClick="BtnLogin_Click"/>
        </form>
       </form>
      </div>
    </div>
    <script src="js/jquery.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/moment.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/simplebar.min.js"></script>
    <script src='js/daterangepicker.js'></script>
    <script src='js/jquery.stickOnScroll.js'></script>
    <script src="js/tinycolor-min.js"></script>
    <script src="js/config.js"></script>
    <script src="js/apps.js"></script>
    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-56159088-1"></script>
    <script>
      window.dataLayer = window.dataLayer || [];

      function gtag()
      {
        dataLayer.push(arguments);
      }
      gtag('js', new Date());
      gtag('config', 'UA-56159088-1');
    </script>
  </body>
</html>
