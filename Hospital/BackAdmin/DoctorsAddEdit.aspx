<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="DoctorsAddEdit.aspx.cs" Inherits="Hospital.BackAdmin.DoctorsAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>הוסף / עריכת רופא</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
                  <div class="col">
                    <h2 class="h3 md-0 page-title">הוסף / ערוך רופא</h2>
               
                  <div class="align-items-lg-center">
                    <form>
                      <div class="form-row">
                        <div class="form-group col-md-6">
                          <label for="inputFName4">שם פרטי</label>
                          <input type="text" class="form-control" id="inputFName4" placeholder="שם פרטי">
                        </div>
                        <div class="form-group col-md-6">
                          <label for="inputPassword4">שם משפחה</label>
                          <input type="text" class="form-control" id="inputLName4" placeholder="שם משפחה">
                        </div>
                      </div> <!-- שם פרטי / משפחה-->
                      <div class="form-row">
                        <div class="form-group col-md-6">
                          <label for="inputId4">תעודת זהות</label>
                          <input type="text" class="form-control" id="inputId4" placeholder="תעודת זהות">
                       </div>
                       <div class="form-group col-md-6">
                          <label for="inputPhone4">טלפון</label>
                          <input type="number" class="form-control" id="inputPhone4" placeholder="טלפון">
                       </div>
                      </div> <!-- טלפון / מספר זהות-->
                      <div class="form-row">
                        <div class="form-group col-md-6">
                          <label for="inputCity4">עיר</label>
                          <input type="text" class="form-control" id="inputCity4" placeholder="עיר">
                        </div>
                        <div class="form-group col-md-6">
                          <label for="inputDomain4">תחום התמקצעות</label>
                          <input type="week" class="form-control" id="inputDomain4" placeholder="תחום התמקצעות">
                       </div>
                      </div> <!-- עיר / תחום התמקצעות-->
                      <div class="form-row">
                        <div class="form-group col-md-6">
                          <label for="inputSeniority4">וותק</label>
                          <input type="date" class="form-control" id="inputSeniority4" placeholder="וותק">
                             <div class="form-group col-md-6">
                              <label for="inputSeniority4">שמור</label>
                              <button type="submit" class="btn btn-primary">שמור</button>
                           </div>
                        </div>
                       </div>
                       
                      </form>
                  </div>
                 </div>
                      
                 


                    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooterCnt" runat="server">
</asp:Content>
