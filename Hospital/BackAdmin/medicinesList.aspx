
<%@ Page Title="רשימת תרופות" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="medicinesList.aspx.cs" Inherits="Hospital.BackAdmin.medicinesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
                    <div class="col-md-10 my-4">
                  <div class="card shadow">
                    <div class="card-body">
                      <h5 class="card-title">רשימת תרופות</h5>
                       <table class="table table-hover">
                        <thead>
                          <tr>
                            <th>שם תרופה</th>
                            <th>מחיר</th>
                            <th>בר קוד</th>
                              <th>פרטים</th>
                          </tr>
                        </thead>
                        <tbody>
                         <asp:Repeater ID="RptMedicines" runat="server">
                           <ItemTemplate>
                          <tr>
                            <td><%#Eval("Mname")%></td>
                            <td><%#Eval("Price")%></td>
                            <td><%#Eval("MBarCod")%></td>
                            <td><span class="badge badge-pill badge-warning"><a href="MedicinesAddEdit.aspx?MId=<%#Eval("MId")%>">פרטים</a></span></td>
                          </tr>
                          </ItemTemplate>
                       </asp:Repeater>
                        </tbody>
                      </table>
                    </div>
                  </div>
                </div> <!-- simple table -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
