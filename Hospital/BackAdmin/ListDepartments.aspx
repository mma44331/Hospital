
<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="ListDepartments.aspx.cs" Inherits="Hospital.BackAdmin.ListDepartments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>רשימת מחלקות</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
                  <div class="row">
                <!-- Small table -->
                <div class="col-md-6 my-4">
                  <div class="card shadow">
                    <div class="card-body">
                      <h5 class="card-title">רשימת מחלקות</h5>               
                      <table class="table table-hover table-sm">
                        <thead>
                          <tr>
                            <th>קוד מחלקה</th>
                            <th>שם מחלקה</th>
                            <th>ראש מחלקה</th>                           
                          </tr>
                        </thead>
                        <tbody>
                          <asp:Repeater ID="RptDepartments" runat="server">
                             <ItemTemplate>
                               <tr>
                                  <td><a href="DepartmentsAddEdit.aspx?DId=<%#Eval("DId")%>"><%#Eval("DId") %></a></td>
                                  <td><%#Eval("DName") %></td>
                                  <td><%#Eval("DHead") %></td>                                      
                               </tr>
                             </ItemTemplate>
                          </asp:Repeater>                          
                        </tbody>
                      </table>
                    </div>
                  </div>
                </div> <!-- simple table -->
                <!--Expandable rows -->
              </div> <!-- end section -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
