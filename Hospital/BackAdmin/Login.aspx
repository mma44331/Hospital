<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Hospital.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"  dir="rtl">
<head runat="server">
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
      <div class="container text-center">


          <div class="row p-2">
    <div class="col-md-4 col-sm-3">
      שם מלא
    </div>
    <div class="col-md-2 col-sm-3">
        <asp:TextBox ID="TxtFulName" runat="server" placeholder="נא הזן שם מלא"/>
    </div>
  </div>
            
          <div class="row p-2">
   <div class="col-md-4 col-sm-3">
   אימייל
  </div>
  <div class="col-md-2 col-sm-3">
      <asp:TextBox ID="Textemail" runat="server" placeholder="נא הזן כתובת אימייל"/>
  </div>
  </div>
              
          <div class="row p-2">
  <div class="col-md-4 col-sm-2">
      סיסמה
  </div>
       <div class="col-md-2 col-sm-3">
     <asp:TextBox ID="Textpassword" TextMode="Password" runat="server" placeholder="נא הזן סיסמה"/>
  </div>
 </div>
              
          <div class="row p-2">
  <div class="col-md-4 col-sm-3">
 התחברות
  </div>
  <div class="col-md-1 col-sm-3">
      <asp:button ID="BtnLogin" runat="server" Class="btn btn-outline-success text-" text="התחברות" OnClick="BtnLogin_Click"/>
  </div>
 </div>

          <div class="row">
  <div class="col-md-10 col-sm-3">
    <asp:Literal Id="LtlMsg" Runat="server"/>
 </div>
 </div>
     </div>
    </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
