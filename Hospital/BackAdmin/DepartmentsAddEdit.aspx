

<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="DepartmentsAddEdit.aspx.cs" Inherits="Hospital.BackAdmin.AddNewDepartments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>פרטי מחלקה</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
                    <div class="card shadow col-6">
                  <div class="card-header">
                    <strong class="card-title">הוסף / ערוך מחלקה</strong>
                  </div>
                  <div class="col-12 align-content-lg-center">
                    <form>
                        <asp:HiddenField ID="DHeadId" runat="server" />
                        <asp:HiddenField ID="HidDid" runat="server" Value="-1"/>
                      <div class="form-group row">
                        <label for="inputDepartments" class="col-sm-3 col-form-label">שם מחלקה</label>
                        <div class="col-sm-9">
                          <asp:TextBox id="TxtDepName" runat="server" class="form-control"  placeholder="שם מחלקה"/>
                        </div>
                      </div>
                      <div class="form-group row">
                        <label for="inputPassword3" class="col-sm-3 col-form-label">ראש מחלקה</label>
                        <div class="col-sm-9">
                          <asp:DropDownList id="DDLDHead" runat="server" class="form-control"   placeholder="ראש מחלקה"/>
                        </div>
                      </div>
                        <div class="row">
                          <div class="col-md-10 col-sm-10" style="text-align: center;">
                            <asp:Label Id="LtlMsg" Runat="server" Style="color: #FF0000" />
                         </div>
                         </div>
                      <div class="form-group mb-2">
                        <asp:Button ID="BtnDep" runat="server" class="btn btn-primary" Text="שמור מחלקה" OnClick="BtnDep_Click"/>
                      </div>
                        <div class="form-group mb-2">
                              <asp:Button ID="BtnDepDel" runat="server" class="btn btn-primary" Text="מחק מחלקה" OnClick="BtnDepDel_Click"/>
                            </div>
                       </form>
                  </div>
                </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
