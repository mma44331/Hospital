<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="PatientDetails.aspx.cs" Inherits="Hospital.BackAdmin.PatientDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>פרטי פציאנט</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
            <div class="col-md-6">
            <div class="card shadow mb-4">
            <div class="card-header">
                <strong class="card-title">פרטי פציאנט</strong>
            </div>
            <div class="card-body">
                <asp:HiddenField ID="HidP" runat="server" Value="-1" />
                <form class="needs-validation" novalidate>
                <div class="form-row">
                    <div class="col-md-6 mb-3">
                    <label for="validationCustom3">שם פרטי</label>
                    <asp:TextBox  id="FName" runat="server" type="text" class="form-control"  placeholder="שם פרטי" />
                    <div class="valid-feedback"> Looks good! </div>
                    </div>
                    <div class="col-md-6 mb-3">
                    <label for="validationCustom4">שם משפחה</label>
                    <asp:TextBox  id="LName" runat="server" type="text"  class="form-control" placeholder="שם משפחה"/>
                    <div class="valid-feedback"> Looks good! </div>
                    </div>
                    <div class="col-md-6 mb-3">
                    <label for="validationCustom4">תעודת זהות</label>
                    <asp:TextBox id="Id" runat="server" type="text" class="form-control"  Placeholder="תעודת זהות"/>
                    <div class="valid-feedback"> Looks good! </div>
                    </div>
                    <div class="col-md-6 mb-3">
                    <label for="validationCustom4">טלפון</label>
                    <asp:TextBox id="Phone" runat="server" type="text" class="form-control" Placeholder="טלפון"/>
                    <div class="valid-feedback"> Looks good! </div>
                    </div>
                    <div class="col-md-6 mb-3">
                    <label for="validationCustom4">עיר</label>
                    <asp:TextBox ID="City" runat="server" type="text" class="form-control" placeholder="עיר" />
                    <div class="valid-feedback"> Looks good! </div>
                    </div>
                    <div class="col-md-6 mb-3">
                    <label for="validationCustom4">כתובת</label>
                    <asp:TextBox id="Address" runat="server" type="text" class="form-control" placeholder="כתובת" />
                    <div class="valid-feedback"> Looks good! </div>
                     </div>
                     <div class="col-md-6 mb-3">
                     <label for="validationCustom4">בחר מחלקה</label>
                    <asp:DropDownList id="Platoon" runat="server" class="form-control input-Platoon"/>
                    <div class="invalid-feedback">אנא בחר מחלקה</div>  
                     </div>
                     <div class="col-md-6 mb-3">
                    <label for="validationCustom4">שם רופא</label>
                    <asp:DropDownList id="DDLDId" runat="server" class="form-control input-DId" />
                    <div class="valid-feedback">בחר רופא </div> 
                </div>
                </div> <!-- /.form-row -->
                <div class="form-row">
                    <div class="col-md-4 mb-2">
                    <label for="validationSelect2">מגדר</label>
                    <asp:DropDownList id="Gender" runat="server" class="form-control select2">
                        <asp:ListItem Text="בחר מגדר" Value="-1"/>
                        <asp:ListItem Text="זכר" Value="0"/>
                        <asp:ListItem Text="נקבה" Value="1"/>                       
                    </asp:DropDownList>
                    <div class="invalid-feedback"> אנא בחר מגדר </div>
                </div>
                <div class="col-md-4 mb-2">
                    <label for="custom-zip">גיל</label>
                    <asp:TextBox id="Age" runat="server" Type="number" class="form-control input-Age"  maxlength="3" placeholder="גיל"/>
                    <div class="invalid-feedback">אנא עדכן גיל</div>
                </div>
                   <div class="col-md-4 mb-2">
                        <label for="custom-zip">מספר רכב</label>
                        <asp:TextBox id="CarNumber" runat="server" class="form-control input-CarNumber" placeholder="מספר רכב" />
                        <div class="invalid-feedback">אנא עדכן מספר רכב</div>
                   </div>
                </div>
                <div class="from-row">
                    <div class="form-group col-md-6">
                        <asp:Button ID="BtnSave" runat="server" CssClass="alert-danger" Text="שמור" OnClick="BtnSave_Click"/>
                  </div>
                  <div class="col-3">
                     <asp:Button ID="BtnDelete" runat="server" CssClass="alert-danger" Text="מחק פציאנט" OnClick="BtnDelete_Click"/>
                  </div>
               <%-- </div>--%>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
