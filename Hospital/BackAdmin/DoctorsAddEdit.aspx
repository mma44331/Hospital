
<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="DoctorsAddEdit.aspx.cs" Inherits="Hospital.BackAdmin.DoctorsAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>הוסף / עריכת רופא</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
      <div class="from row">
          <div class="col-6">        
                <h2 class="h3 md-0 page-title">הוסף / ערוך רופא</h2>           
              <div class="align-items-lg-center">                
                  <div class="form-row">
                        <asp:HiddenField ID="HidId" runat="server" Value="-1"/>
                    <div class="form-group col-md-6">
                      <label for="FName">שם פרטי</label>
                      <asp:TextBox runat="server" class="form-control" id="FName" placeholder="שם פרטי"/>
                    </div>
                    <div class="form-group col-md-6">
                      <label for="LName">שם משפחה</label>
                      <asp:TextBox runat="server" class="form-control" id="LName" placeholder="שם משפחה"/>
                    </div>
                  </div> <!-- שם פרטי / משפחה-->
                  <div class="form-row">
                    <div class="form-group col-md-6">
                      <label for="DId">תעודת זהות</label>
                      <asp:TextBox runat="server" class="form-control" id="DId" placeholder="תעודת זהות"/>
                   </div>
                   <div class="form-group col-md-6">
                      <label for="Phone">טלפון</label>
                      <asp:TextBox runat="server" type="text" class="form-control" id="Phone" placeholder="טלפון"/>
                   </div>
                  </div> <!-- טלפון / מספר זהות-->
                  <div class="form-row">
                    <div class="form-group col-md-6">
                      <label for="City">עיר</label>
                      <asp:DropDownList runat="server" type="text" class="form-control" id="DDLCity" placeholder="עיר"/>
                    </div>
                    <div class="form-group col-md-6">
                      <label for="Domain">תחום התמקצעות</label>
                      <asp:DropDownList runat="server" class="form-control" id="DDLDomain" placeholder="תחום התמקצעות"/>
                   </div>
                  </div> <!-- עיר / תחום התמקצעות-->
                  <div class="form-row">
                    <div class="form-group col-md-6">
                      <label for="Seniority">תחילת השמה</label>
                      <asp:TextBox runat="server" textmode="DateTime" class="form-control" id="Seniority" placeholder="תחילת השמה"/>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="Seniority"></label>
                       <asp:Literal runat="server" id="LtlS" />
                    </div>

                      <asp:Literal ID="LtlCheck" runat="server"></asp:Literal>
                     
                    <div class="form-group col-md-6">                      
                      <asp:button runat="server" id="Save" type="submit" class="btn btn-primary" Text="שמור" OnClick="Save_Click"/>
                    </div>                   
                 </div>                                  
              </div>
             </div>            
      </div>            
                   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
