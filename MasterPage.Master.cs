﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace e_rehistro
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*AuthenticationPage.Visible = true;*/
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            AuthenticationPage.Visible = false;
            HomePage.Visible = true;
            RegistrationPage.Visible = false;
            FirstRegistrationForm.Visible = false;
            SecondRegistrationForm.Visible = false;
            NewsAndEventsPage.Visible = false;
            AboutPage.Visible = false;
            ContactsPage.Visible = false;
        }

        protected void Registration_Click(object sender, EventArgs e)
        {
            AuthenticationPage.Visible = false;
            HomePage.Visible = false;
            RegistrationPage.Visible = true;
            FirstRegistrationForm.Visible = false;
            SecondRegistrationForm.Visible = false;
            NewsAndEventsPage.Visible = false;
            AboutPage.Visible = false;
            ContactsPage.Visible = false;
        }

        protected void NewsAndEvents_Click(object sender, EventArgs e)
        {
            AuthenticationPage.Visible = false;
            HomePage.Visible = false;
            RegistrationPage.Visible = false;
            FirstRegistrationForm.Visible = false;
            SecondRegistrationForm.Visible = false;
            NewsAndEventsPage.Visible = true;
            AboutPage.Visible = false;
            ContactsPage.Visible = false;
        }

        protected void About_Click(object sender, EventArgs e)
        {
            AuthenticationPage.Visible = false;
            HomePage.Visible = false;
            RegistrationPage.Visible = false;
            FirstRegistrationForm.Visible = false;
            SecondRegistrationForm.Visible = false;
            NewsAndEventsPage.Visible = false;
            AboutPage.Visible = true;
            ContactsPage.Visible = false;
        }

        protected void Contacts_Click(object sender, EventArgs e)
        {
            AuthenticationPage.Visible = false;
            HomePage.Visible = false;
            RegistrationPage.Visible = false;
            FirstRegistrationForm.Visible = false;
            SecondRegistrationForm.Visible = false;
            NewsAndEventsPage.Visible = false;
            AboutPage.Visible = false;
            ContactsPage.Visible = true;
        }
    }
}