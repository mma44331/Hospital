<%@ Page Title="עריכת תרופות" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="MedicinesAddEdit.aspx.cs" Inherits="Hospital.BackAdmin.MedicinesAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
                    <h2>הוספת/עריכת תרופות</h2>
                    <div class="col-md-4">
                  <div class="card shadow mb-3">
                    <div class="card-body">
                      <p class="mb-2"><strong>עדכן פרטי תרופה:</strong></p>
                      <div class="form-row">
                           <asp:HiddenField ID="HidId" runat="server" Value="-1"/>
                        <div class="form-group col-md-8">
                          <label for="simple-select2">שם תרופה</label>
                            <asp:TextBox ID="Mname" runat="server" placeholder="הכנס שם תרופה" class="from-control"/>
                            <label for="simple-select2">בר קוד תרופה</label>
                            <asp:TextBox ID="MBarCod" runat="server" placeholder="הכנס בר קוד " class="from-control"/>
                            <label for="simple-select2">מחיר תרופה</label>
                            <asp:TextBox ID="Price" runat="server" placeholder="הכנס מחיר " class="from-control"/>



                            <asp:Button ID="BtnSave" runat="server"  type="submit" class="btn btn-primary" Text="עדכן" OnClick="BtnSave_Click" />

                        </div> <!-- form-group -->
                         <!-- form-group -->
                      </div> <!-- form-row -->
                    </div> <!-- /.card-body -->
                  </div> <!-- /.card -->
                 </div> <!-- /.col -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
