<%@ Page Title="הוסף/ ערוך אישפוז" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="HIzationsAddEdit.aspx.cs" Inherits="Hospital.BackAdmin.HIzationsAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
     <div class="row justify-content-center">
   <div class="col-12 col-xl-10">
     <div class="row align-items-center my-4">
       <div class="col">
         <h2 class="h3 mb-0 page-title">אישפוזים</h2>
       </div>
     </div>  
       <hr class="my-4">
       <h5 class="mb-2 mt-4">הוסף/ ערוך אישפוז</h5>
       <div class="form-row">
           <asp:HiddenField ID="HId" runat="server" Value="-1"/>
            <div class="form-group col-md-4">
                <label for="id">תעודת זהות</label>
              <asp:TextBox Id="PId" runat="server" class="form-control" placeholder="תעודת זהות"/>
            </div>
         <div class="form-group col-md-4">
           <label for="fname">שם פרטי</label>
         <asp:TextBox Id="FNmae" runat="server" class="form-control" placeholder="שם פרטי"/>
         </div>
         <div class="form-group col-md-4">
           <label for="lname">שם משפחה</label>
         <asp:TextBox Id="LName" runat="server"  class="form-control" placeholder="שם משפחה"/>
         </div>
            <div class="form-group col-md-6">
                <label for="tdescription">תיאור מצב</label>
              <asp:TextBox Id="TDescription" runat="server" TextMode="MultiLine" Rows="3" Columns="10" class="form-control" placeholder="תיאור מצב"/>
            </div>
            <div class="form-group col-md-6">
                <label for="tsummary">סיכום</label>
              <asp:TextBox Id="TSummary" runat="server" TextMode="MultiLine" Rows="3" Columns="10" class="form-control" placeholder="סיכום"/>
            </div>
             <div class="form-group col-md-4">
               <label for="DId">רופא מטפל</label>
              <asp:DropDownList Id="DDLId" runat="server" class="form-control"/>
            </div>
            <div class="form-group col-md-4">
               <label for="dreception">תאריך קבלה</label>
             <asp:TextBox Id="DReception" runat="server" TextMode="Date" class="form-control" placeholder="תאריך קבלה"/>
           </div>
           <div class="form-group col-md-4">
            <label for="drelease">תאריך שיחרור</label>
           <asp:TextBox Id="DRelease" runat="server" TextMode="Date" class="form-control" placeholder="תאריך שיחרור"/>
         </div>
       </div>
         <div class="row align-items-center my-6">
           <div class="col-auto">
           <asp:Button ID="BtnSave" runat="server" Text="שמור" class="btn btn-primary" OnClick="BtnSave_Click"/>
           </div>          
         </div>   
        <div class="row align-items-center my-6">
           <div class="col-auto">
           <asp:Button ID="BtnDelete" runat="server" Text="מחק" class="btn btn-primary" OnClick="BtnDelete_Click"/>
           </div>          
         </div>   
    </div>
         </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
