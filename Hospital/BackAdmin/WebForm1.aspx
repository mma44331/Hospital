<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Hospital.BackAdmin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
       <%--  <div class="col-md-6 my-4">--%>
   <div class="card shadow">
     <div class="card-body">
       <h5 class="card-title">רשימת אישפוזים</h5>
       <table class="table table-bordered table-hover mb-0">
         <thead>
           <tr>
             <th>תעודת זהות</th>
             <th>תאריך קבלה</th>
             <th>רופא מטפל</th>
             <th>תיאור המצב</th>
             <th>סיכום</th>
             <th>תאריך שחרור</th>
           </tr>
         </thead>
         <tbody>
             <asp:Repeater ID="RptHIL" runat="server">
           <ItemTemplate>
             <tr>
             <td><%#Eval("Id")%></td>
             <td><%#Eval("DReception")%></td>
             <td><%#Eval("DId")%></td>
             <td><%#Eval("TDescription")%></td>
             <td><%#Eval("TSummary")%></td>
             <td>
               <div class="custom-control custom-switch">
                 <input type="checkbox" class="custom-control-input" id="c1" checked>
                 <label class="custom-control-label" for="c1"></label>
               </div>
             </td>
           </tr>

        </ItemTemplate>
      </asp:Repeater>
         </tbody>
       </table>
     </div>
  <%-- </div>--%>
 </div> <!-- Bordered table -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
