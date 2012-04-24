SSL-Ghost
=========

Demo of moving in and out of SSL HTTPS in a C# ASP .NET MVC web application. Demonstrates using SSL HTTPS for specific pages in an MVC application (login, change password, etc), while all other pages remain non-SSL.

This example demonstrates 2 specific uses for SSL:

1. SSL on a login page.
2. SSL on a modal dialog, contained on a non-SSL page (ie., a change password dialog where the form post targets an HTTPS url), using JSONP for cross-domain (HTTP -> HTTPS).

The example also includes a RequireHttpsByConfig attribute for enabling/disabling SSL in the ASP .NET MVC web application by changing a web.config value.

Read the full tutorial at http://www.primaryobjects.com/CMS/Article140.aspx