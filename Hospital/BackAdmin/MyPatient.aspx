
<%@ Page Title="הפציאנטים שלי" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="MyPatient.aspx.cs" Inherits="Hospital.BackAdmin.MyPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
      <div class="card-body">
    <h5 class="card-title">הפציאנטים שלי</h5>
    <table class="table table-hover table-sm">
      <thead>
        <tr>
          <th>תעודת זהות</th>
          <th>שם פרטי</th>
          <th>שם משפחה</th>      
          <th>עיר</th>
          <th>גיל</th> 
          <th>מין</th>   
          <th>מאושפז במחלקה</th> 
           <th>פרטי פציאנט</th> 
        </tr>
      </thead>
      <tbody>
          <asp:Repeater ID="RPL" runat="server">
              <ItemTemplate>
                <tr>
                    <td><%#Eval("PId")%></td>
                    <td><%#Eval("PFname")%></td>
                    <td><%#Eval("PLname")%></td>                 
                    <td><%#Eval("PCity")%></td>
                    <td><%#Eval("PAge")%></td>
                    <td><%#Eval("PGender")%></td>  
                     <td><%#Eval("Platoon")%></td>  
                    <td><a class="text-warning" href="PatientDetails.aspx?PCId=<%#Eval("PCId")%>"</a>פרטים</td>
               </tr>
              </ItemTemplate>
          </asp:Repeater>
      </tbody>
    </table>
  </div>
              
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
