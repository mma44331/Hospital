﻿<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="DoctorsList.aspx.cs" Inherits="Hospital.BackAdmin.DoctorsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>רשימת רופאים</title>
<%--    <link rel="stylesheet" type="text/css" a href="./css/custom.css" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
       <div class="row align-items-center my-4">
    <div class="col">
      <h2 class="h3 mb-0 page-title">רופאים</h2>
    </div>
    <div class="col-auto">
      <button type="button" class="btn btn-secondary"><span class="fe fe-trash fe-12 mr-2"></span>Delete</button>
      <button type="button" class="btn btn-primary"><span class="fe fe-filter fe-12 mr-2"></span>Create</button>
    </div>
  </div>
  <div class="row">
    <asp:Repeater ID="RptD" runat="server">
        <ItemTemplate>
             <div class="col-md-3">
   <div class="card shadow mb-4">
     <div class="card-body text-center">
       <div class="avatar avatar-lg mt-4">
         <a href="">
           <img src="./assets/avatars/face-4.jpg" alt="..." class="avatar-img rounded-circle">
         </a>
       </div>
       <div class="card-text my-2">
         <strong class="card-title my-0">דר' <%#Eval("DLname")%></strong>
         <p class="small text-muted mb-0"><%#Eval("Domain")%></p>
         <p class="small"><span class="badge badge-light text-muted"><%#Eval("City")%></span></p>
       </div>
     </div> <!-- ./card-text -->
     <div class="card-footer">
       <div class="row align-items-center justify-content-between">
         <div class="col-auto">
           <small>
             <span class="dot dot-lg bg-success mr-1"></span> Online </small>
         </div>
         <div class="col-auto">
           <div class="file-action">
             <button type="button" class="btn btn-link dropdown-toggle more-vertical p-0 text-muted mx-auto" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
               <span class="text-muted sr-only">Action</span>
             </button>
             <div class="dropdown-menu m-2"> 
               <a class="dropdown-item" href="DoctorsAddEdit.aspx?Id=<%#Eval("Id") %>"><i class="fe fe-meh fe-12 mr-4"></i>פרטי רופא</a>
               <a class="dropdown-item" href="/PatzientList.aspx<%#Eval("Id")%>"><i class="fe fe-message-circle fe-12 mr-4"></i>רשימת פציאנטים</a>
               <a class="dropdown-item" href="#"><i class="fe fe-delete fe-12 mr-4"></i>מחיקת רופא</a>
             </div>
           </div>
         </div>
       </div>
     </div> <!-- /.card-footer -->
   </div>
 </div> <!-- .col -->
        </ItemTemplate>
    </asp:Repeater>
   
    <div class="col-md-9">
    </div> <!-- .col -->
  </div> <!-- .row -->
  <nav aria-label="Table Paging" class="my-3">
    <ul class="pagination justify-content-end mb-0">
      <li class="page-item"><a class="page-link" href="#">הקודם</a></li>
      <li class="page-item active"><a class="page-link" href="#">1</a></li>
      <li class="page-item"><a class="page-link" href="#">2</a></li>
      <li class="page-item"><a class="page-link" href="#">3</a></li>
      <li class="page-item"><a class="page-link" href="#">הבא</a></li>
    </ul>
  </nav>

   <div class="modal fade modal-notif modal-slide" tabindex="-1" role="dialog" aria-labelledby="defaultModalLabel" aria-hidden="true">
     <div class="modal-dialog modal-sm" role="document">
       <div class="modal-content">
         <div class="modal-header">
           <h5 class="modal-title" id="defaultModalLabel">Notifications</h5>
           <button type="button" class="close" data-dismiss="modal" aria-label="Close">
             <span aria-hidden="true">&times;</span>
           </button>
         </div>
         <div class="modal-body">
           <div class="list-group list-group-flush my-n3">
             <div class="list-group-item bg-transparent">
               <div class="row align-items-center">
                 <div class="col-auto">
                   <span class="fe fe-box fe-24"></span>
                 </div>
                 <div class="col">
                   <small><strong>Package has uploaded successfull</strong></small>
                   <div class="my-0 text-muted small">Package is zipped and uploaded</div>
                   <small class="badge badge-pill badge-light text-muted">1m ago</small>
                 </div>
               </div>
             </div>
             <div class="list-group-item bg-transparent">
               <div class="row align-items-center">
                 <div class="col-auto">
                   <span class="fe fe-download fe-24"></span>
                 </div>
                 <div class="col">
                   <small><strong>Widgets are updated successfull</strong></small>
                   <div class="my-0 text-muted small">Just create new layout Index, form, table</div>
                   <small class="badge badge-pill badge-light text-muted">2m ago</small>
                 </div>
               </div>
             </div>
             <div class="list-group-item bg-transparent">
               <div class="row align-items-center">
                 <div class="col-auto">
                   <span class="fe fe-inbox fe-24"></span>
                 </div>
                 <div class="col">
                   <small><strong>Notifications have been sent</strong></small>
                   <div class="my-0 text-muted small">Fusce dapibus, tellus ac cursus commodo</div>
                   <small class="badge badge-pill badge-light text-muted">30m ago</small>
                 </div>
               </div> <!-- / .row -->
             </div>
             <div class="list-group-item bg-transparent">
               <div class="row align-items-center">
                 <div class="col-auto">
                   <span class="fe fe-link fe-24"></span>
                 </div>
                 <div class="col">
                   <small><strong>Link was attached to menu</strong></small>
                   <div class="my-0 text-muted small">New layout has been attached to the menu</div>
                   <small class="badge badge-pill badge-light text-muted">1h ago</small>
                 </div>
               </div>
             </div> <!-- / .row -->
           </div> <!-- / .list-group -->
         </div>
         <div class="modal-footer">
           <button type="button" class="btn btn-secondary btn-block" data-dismiss="modal">Clear All</button>
         </div>
       </div>
     </div>
   </div>
   <div class="modal fade modal-shortcut modal-slide" tabindex="-1" role="dialog" aria-labelledby="defaultModalLabel" aria-hidden="true">
     <div class="modal-dialog" role="document">
       <div class="modal-content">
         <div class="modal-header">
           <h5 class="modal-title" id="defaultModalLabel">Shortcuts</h5>
           <button type="button" class="close" data-dismiss="modal" aria-label="Close">
             <span aria-hidden="true">&times;</span>
           </button>
         </div>
         <div class="modal-body px-5">
           <div class="row align-items-center">
             <div class="col-6 text-center">
               <div class="squircle bg-success justify-content-center">
                 <i class="fe fe-cpu fe-32 align-self-center text-white"></i>
               </div>
               <p>Control area</p>
             </div>
             <div class="col-6 text-center">
               <div class="squircle bg-primary justify-content-center">
                 <i class="fe fe-activity fe-32 align-self-center text-white"></i>
               </div>
               <p>Activity</p>
             </div>
           </div>
           <div class="row align-items-center">
             <div class="col-6 text-center">
               <div class="squircle bg-primary justify-content-center">
                 <i class="fe fe-droplet fe-32 align-self-center text-white"></i>
               </div>
               <p>Droplet</p>
             </div>
             <div class="col-6 text-center">
               <div class="squircle bg-primary justify-content-center">
                 <i class="fe fe-upload-cloud fe-32 align-self-center text-white"></i>
               </div>
               <p>Upload</p>
             </div>
           </div>
           <div class="row align-items-center">
             <div class="col-6 text-center">
               <div class="squircle bg-primary justify-content-center">
                 <i class="fe fe-users fe-32 align-self-center text-white"></i>
               </div>
               <p>Users</p>
             </div>
             <div class="col-6 text-center">
               <div class="squircle bg-primary justify-content-center">
                 <i class="fe fe-settings fe-32 align-self-center text-white"></i>
               </div>
               <p>Settings</p>
             </div>
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
