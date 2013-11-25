SSL-Ghost
=========

Demo of moving in and out of SSL HTTPS in a C# ASP .NET MVC web application. Demonstrates using SSL HTTPS for specific pages in an MVC application (login, change password, etc), while all other pages remain non-SSL.

This example demonstrates 2 specific uses for SSL:

1. SSL on a login page.
2. SSL on a modal dialog, contained on a non-SSL page (ie., a change password dialog where the form post targets an HTTPS url), using JSONP for cross-domain (HTTP -> HTTPS).

The example also includes a RequireHttpsByConfig attribute for enabling/disabling SSL in the ASP .NET MVC web application by changing a web.config value.

Read the full tutorial at http://www.primaryobjects.com/CMS/Article140.aspx

---
Copyright © 2011 Kory Becker (http://www.primaryobjects.com)

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
